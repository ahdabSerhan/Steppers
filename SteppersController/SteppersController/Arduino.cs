using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersController
{
 
    class Arduino
    {
        public enum Direction { Up = 1, Down = 2 };
        public enum Step { Half = 1, Full = 2 };
        public enum Opcode { Set = 1, Move = 2, Read = 3, MoveAll = 4, AddPin = 5, SetStep = 6 };
        public enum PinType { Digital = 1, Analog = 2 }

        public SerialPort serial;
        public bool connect(string port, int baud)
        {
            serial = new SerialPort(port, baud);
            serial.Open();
            serial.DataReceived += Serial_DataReceived;
            return serial.IsOpen;
        }
    
        public void disconnect()
        {
            this.serial.Close();
            this.serial.Dispose();
            serial = null;
        }
        public void sendPacket(byte[] packet)
        {
            serial.Write(packet, 0, packet.Length);
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = serial.ReadLine();
        }

        public static string[] getPorts()
        {
            return SerialPort.GetPortNames();
        }

    }

}
