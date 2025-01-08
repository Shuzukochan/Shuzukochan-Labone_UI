using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace Labone_UI
{
    public class UartManager
    {
        private static readonly UartManager _instance = new();
        public static UartManager Instance => _instance;
        public SerialPort SerialPort { get; private set; }

        private UartManager()
        {
            SerialPort = new SerialPort
            {
                PortName = "COM12",
                BaudRate = 115200,
                Parity = Parity.None,
                DataBits = 8,
                StopBits = StopBits.One,
                Handshake = Handshake.None
            };
        }

        public void Open()
        {
            if (!SerialPort.IsOpen)
            {
                SerialPort.Open();
            }
        }

        public void Close()
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }
        }

        public void Send(string data)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.WriteLine(data);
            }
            else
            {
                throw new InvalidOperationException("UART port is not open.");
            }
        }

        public string Receive()
        {
            if (SerialPort.IsOpen)
            {
                return SerialPort.ReadExisting();
            }
            else
            {
                throw new InvalidOperationException("UART port is not open.");
            }
        }
    }
}
