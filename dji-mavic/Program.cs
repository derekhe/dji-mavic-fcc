using System.IO.Ports;

var serialPort = new SerialPort("COM6", 19200, 0,8,StopBits.One);
serialPort.Open();
var b1 = new byte[] { 85, 13, 4, 33, 42, 31, 0, 0, 0, 0, 1, 134, 32 };
var b2 = new byte[] { 85, 24, 4, 32, 2, 9, 0, 0, 64, 9, 39, 0, 2, 72, 0, 255, 255, 2, 0, 0, 0, 0, 129, 31 };
serialPort.Write(b1,0, b1.Length);
serialPort.Write(b2,0, b2.Length);
Console.WriteLine("FCC enabled");
