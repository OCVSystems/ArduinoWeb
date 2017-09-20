using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO.Ports;



namespace ArduinoWeb
{
    public enum ValueToSend
    {
        sendOFF = 0, sendRed = 1, sendGreen = 2, sendBoth = 3
    }
    public class Arduino
    {
        private SerialPort port;
        public int BaudRate { get; set; }
        public string PortName { get; set; }
        public Arduino()
        {
            port = new SerialPort();
            BaudRate = 9600;
            PortName = "COM3";
        }
        public void Send(ValueToSend value)
        {
            switch (value)
            {
                case ValueToSend.sendOFF:
                    {
                        BaudRate = BaudRate;
                        port.PortName = PortName;
                        port.Open();
                        port.WriteLine("0");
                        port.Close();
                    }
                    break;
                case ValueToSend.sendGreen:
                    {
                        BaudRate = BaudRate;
                        port.PortName = PortName;
                        port.Open();
                        port.WriteLine("2");
                        port.Close();
                    }
                    break;
                case ValueToSend.sendRed:
                    {
                        BaudRate = BaudRate;
                        port.PortName = PortName;
                        port.Open();
                        port.WriteLine("1");
                        port.Close();
                    }
                    break;
                case ValueToSend.sendBoth:
                    {
                        BaudRate = BaudRate;
                        port.PortName = PortName;
                        port.Open();
                        port.WriteLine("3");
                        port.Close();
                    }
                    break;
                default:
                    {
                        port.Open();
                        port.WriteLine("0");
                        port.Close();
                    }
                    break;
            }
        }

    }
}