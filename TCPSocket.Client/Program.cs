using System;
using System.Net.Sockets;
using System.Text;

var client = new TcpClient("localhost", 5000);
var stream = client.GetStream();
byte[] buffer = Encoding.UTF8.GetBytes("Hello from Socket Client");
stream.Write(buffer, 0, buffer.Length);
Console.WriteLine("Message sent to server.");