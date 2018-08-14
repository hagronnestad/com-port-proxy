using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ComPortProxy {

    internal class Program {

        public static SerialPort sp1 = new SerialPort("COM4", 115200); // ESP
        public static SerialPort sp2 = new SerialPort("COM3", 115200); // Nextion

        public static BackgroundWorker bw1 = new BackgroundWorker();
        public static BackgroundWorker bw2 = new BackgroundWorker();

        public static Timer t1 = new Timer();
        public static long bps1 = 0;

        private static void Main(string[] args) {
            t1.Enabled = true;
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
            t1.Start();

            bw1.DoWork += Bw1_DoWork;
            bw2.DoWork += Bw2_DoWork;

            bw2.WorkerReportsProgress = true;
            bw2.ProgressChanged += Bw2_ProgressChanged;

            bw1.RunWorkerAsync();
            bw2.RunWorkerAsync();

            Console.ReadLine();
        }

        private static void T1_Tick(object sender, EventArgs e) {
            Console.WriteLine($"Bytes per second: {bps1}");
            bps1 = 0;
        }

        private static void Bw1_DoWork(object sender, DoWorkEventArgs e) {
            var buffer = new byte[1024];

            while (!bw1.CancellationPending) {

                try {
                    if (!sp1.IsOpen) sp1.Open();

                    var c = sp1.Read(buffer, 0, buffer.Length);
                    sp2.Write(buffer, 0, c);

                    bps1 += c;

                    //Console.Write(Encoding.UTF8.GetString(new byte[] { b }));

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

                    bw2.ReportProgress(0, new SerialProgress() { Data = buffer.Take(c).ToArray() });

                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    throw;
                }

            }
        }

        private static void Bw2_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            var sp = e.UserState as SerialProgress;

            //Console.Write(Encoding.UTF8.GetString(new byte[] { b }));
            Console.Write(BitConverter.ToString(sp.Data).Replace("-", " "));
            Console.Write(" ");
        }
    }
}