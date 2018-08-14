using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComPortProxy.Ui {

    public partial class FormMain : Form {

        public FormMain() {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            cmbPort1.Items.AddRange(SerialPort.GetPortNames());
            cmbPort2.Items.AddRange(SerialPort.GetPortNames());
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        public static SerialPort sp1 = new SerialPort();
        public static SerialPort sp2 = new SerialPort();

        public static BackgroundWorker bw1 = new BackgroundWorker();
        public static BackgroundWorker bw2 = new BackgroundWorker();

        public static Timer t1 = new Timer();
        public static long bps1 = 0;
        public static long bps2 = 0;

        private void T1_Tick(object sender, EventArgs e) {
            lblPort1to2.Text = $"{bps1} bps";
            lblPort2to1.Text = $"{bps2} bps";
            bps1 = 0;
            bps2 = 0;
        }

        private static void Bw1_DoWork(object sender, DoWorkEventArgs e) {
            var buffer = new byte[1024];

            while (!bw1.CancellationPending) {

                try {
                    if (!sp1.IsOpen) sp1.Open();

                    var c = sp1.Read(buffer, 0, buffer.Length);
                    sp2.Write(buffer, 0, c);

                    bps1 += c;

                    bw1.ReportProgress(0, new SerialProgress() { Data = buffer.Take(c).ToArray() });

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
        }

        private static void Bw2_DoWork(object sender, DoWorkEventArgs e) {
            var buffer = new byte[1024];

            while (!bw1.CancellationPending) {

                try {
                    if (!sp2.IsOpen) sp2.Open();

                    var c = sp2.Read(buffer, 0, buffer.Length);
                    sp1.Write(buffer, 0, c);

                    bps2 += c;

                    bw2.ReportProgress(0, new SerialProgress() { Data = buffer.Take(c).ToArray() });

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
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
            if (rbUtf81.Checked) ldt = LogDataType.Utf8;
            if (rbHex1.Checked) ldt = LogDataType.Hex;

            LogData(ldt, txtData1, sp.Data);
        }

        private void Bw2_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            var sp = e.UserState as SerialProgress;

            var ldt = LogDataType.Disabled;
            if (rbAscii2.Checked) ldt = LogDataType.Ascii;
            if (rbUtf82.Checked) ldt = LogDataType.Utf8;
            if (rbHex2.Checked) ldt = LogDataType.Hex;

            LogData(ldt, txtData2, sp.Data);
        }

        public void LogData(LogDataType ldt, TextBox txt, byte[] data) {
            switch (ldt) {
                case LogDataType.Ascii:
                    txt.AppendText(Encoding.ASCII.GetString(data));
                    break;

                case LogDataType.Utf8:
                    txt.AppendText(Encoding.UTF8.GetString(data));
                    break;

                case LogDataType.Hex:
                    txt.AppendText(BitConverter.ToString(data).Replace("-", " "));
                    txt.AppendText(" ");
                    break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e) {
            t1.Enabled = true;
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
            t1.Start();

            sp1.BaudRate = int.Parse(cmbPort1Speed.Text);
            sp1.PortName = cmbPort1.Text;
            sp2.BaudRate = int.Parse(cmbPort2Speed.Text);
            sp2.PortName = cmbPort2.Text;

            bw1.DoWork += Bw1_DoWork;
            bw1.WorkerReportsProgress = true;
            bw1.ProgressChanged += Bw1_ProgressChanged;

            bw2.DoWork += Bw2_DoWork;
            bw2.WorkerReportsProgress = true;
            bw2.ProgressChanged += Bw2_ProgressChanged;

            bw1.RunWorkerAsync();
            bw2.RunWorkerAsync();

            Console.ReadLine();
        }
    }
}