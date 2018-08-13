using System;
using System.IO.Ports;
using System.Text;

namespace ComPortProxy {

    internal class Program {

        public static SerialPort spESP = new SerialPort("COM4", 115200);
        public static SerialPort spNextion = new SerialPort("COM3", 9600);

        private static void Main(string[] args) {
            spESP.Open();
            spNextion.Open();

            while (true) {
                var b = (byte) spESP.ReadByte();
                spNextion.Write(new byte[] { b }, 0, 1);

                Console.Write(Encoding.UTF8.GetString(new byte[] { b }));
            }
        }

    }
}