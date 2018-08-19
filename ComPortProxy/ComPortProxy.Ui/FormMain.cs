using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ComPortProxy.Ui {

    public partial class FormMain : Form {

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            cmbPort1.Items.AddRange(SerialPort.GetPortNames());
            cmbPort2.Items.AddRange(SerialPort.GetPortNames());

            t1.Tick += T1_Tick;
            t1.Enabled = true;
            t1.Interval = 1000;

            bw1.WorkerSupportsCancellation = true;
            bw1.WorkerReportsProgress = true;
            bw1.DoWork += Bw1_DoWork;
            bw1.ProgressChanged += Bw1_ProgressChanged;

            bw2.DoWork += Bw2_DoWork;
            bw2.WorkerSupportsCancellation = true;
            bw2.WorkerReportsProgress = true;
            bw2.ProgressChanged += Bw2_ProgressChanged;

            sp1.ReadTimeout = sp1.WriteTimeout = sp2.ReadTimeout = sp2.ReadTimeout = 1000;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        public static SerialPort sp1 = new SerialPort();
        public static SerialPort sp2 = new SerialPort();

        public static BackgroundWorker bw1 = new BackgroundWorker();
        public static BackgroundWorker bw2 = new BackgroundWorker();

        public static System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        public static long bps1 = 0;
        public static long bps2 = 0;

        private void T1_Tick(object sender, EventArgs e) {
            lblPort1to2.Text = $"{bps1} bytes/s";
            lblPort2to1.Text = $"{bps2} bytes/s";
            bps1 = 0;
            bps2 = 0;
        }

        private static void Bw1_DoWork(object sender, DoWorkEventArgs e) {
            var buffer = new byte[4096];

            while (!bw1.CancellationPending) {

                try {
                    if (!sp1.IsOpen) sp1.Open();

                    var c = sp1.Read(buffer, 0, buffer.Length);
                    sp2.Write(buffer, 0, c);

                    bps1 += c;

                    bw1.ReportProgress(0, new SerialProgress() { Data = buffer.Take(c).ToArray() });

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }

            }

            Debug.WriteLine("Bw1_DoWork complete");
        }

        private static void Bw2_DoWork(object sender, DoWorkEventArgs e) {
            var buffer = new byte[4096];

            while (!bw2.CancellationPending) {

                try {
                    if (!sp2.IsOpen) sp2.Open();

                    var c = sp2.Read(buffer, 0, buffer.Length);
                    sp1.Write(buffer, 0, c);

                    bps2 += c;

                    bw2.ReportProgress(0, new SerialProgress() { Data = buffer.Take(c).ToArray() });

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }

            }

            Debug.WriteLine("Bw2_DoWork complete");
        }

        public enum LogDataType {
            Disabled,
            Ascii,
            Utf8,
            Hex
        }

        private void Bw1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            var sp = e.UserState as SerialProgress;

            var ldt = LogDataType.Disabled;
            if (rbAscii1.Checked) ldt = LogDataType.Ascii;
            if (rbHex1.Checked) ldt = LogDataType.Hex;

            if (ldt != LogDataType.Disabled) LogData(ldt, txtData1, sp.Data);
        }

        private void Bw2_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            var sp = e.UserState as SerialProgress;

            var ldt = LogDataType.Disabled;
            if (rbAscii2.Checked) ldt = LogDataType.Ascii;
            if (rbHex2.Checked) ldt = LogDataType.Hex;

            if (ldt != LogDataType.Disabled) LogData(ldt, txtData2, sp.Data);
        }

        public void LogData(LogDataType ldt, TextBox txt, byte[] data) {
            switch (ldt) {
                case LogDataType.Ascii:
                    txt.AppendText(Encoding.ASCII.GetString(data));
                    Debug.Write(Encoding.ASCII.GetString(data));
                    break;

                case LogDataType.Hex:
                    txt.AppendText(BitConverter.ToString(data).Replace("-", " "));
                    txt.AppendText(" ");
                    Debug.Write(BitConverter.ToString(data).Replace("-", " "));
                    Debug.Write(" ");
                    break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            try {
                sp1.BaudRate = int.Parse(cmbPort1Speed.Text);
                sp1.PortName = cmbPort1.Text;

                sp2.BaudRate = int.Parse(cmbPort2Speed.Text);
                sp2.PortName = cmbPort2.Text;

                sp1.Open();
                sp2.Open();

                t1.Start();
                bw1.RunWorkerAsync();
                bw2.RunWorkerAsync();

                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;

            } catch (Exception ex) {
                if (sp1.IsOpen) sp1.Close();
                if (sp2.IsOpen) sp2.Close();

                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e) {
            btnDisconnect.Enabled = false;

            bw1.CancelAsync();
            bw2.CancelAsync();

            while (bw1.IsBusy || bw2.IsBusy) {
                Application.DoEvents();
            }

            sp1.Close();
            sp2.Close();

            t1.Stop();

            lblPort1to2.Text = "0 bytes/s";
            lblPort2to1.Text = "0 bytes/s";

            bps1 = 0;
            bps2 = 0;

            btnConnect.Enabled = true;
        }

        private void btnClear1_Click(object sender, EventArgs e) {
            txtData1.Clear();
        }

        private void btnClear2_Click(object sender, EventArgs e) {
            txtData2.Clear();
        }

        private void rbDisabled1_CheckedChanged(object sender, EventArgs e) {
            txtData1.Enabled = !rbDisabled1.Checked;
            txtData1.Clear();
        }

        private void rbDisabled2_CheckedChanged(object sender, EventArgs e) {
            txtData2.Enabled = !rbDisabled2.Checked;
            txtData2.Clear();
        }

        private void rbAscii1_CheckedChanged(object sender, EventArgs e) {
            txtData1.Clear();
        }

        private void rbAscii2_CheckedChanged(object sender, EventArgs e) {
            txtData2.Clear();
        }

        private void rbHex1_CheckedChanged(object sender, EventArgs e) {
            txtData1.Clear();
        }

        private void rbHex2_CheckedChanged(object sender, EventArgs e) {
            txtData2.Clear();
        }
    }
}