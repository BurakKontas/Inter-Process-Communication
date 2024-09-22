using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

var listener = new TcpListener(IPAddress.Loopback, 5000);
listener.Start();
var client = listener.AcceptTcpClient();
var stream = client.GetStream();
byte[] buffer = new byte[1024];
int bytesRead = stream.Read(buffer, 0, buffer.Length);
string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
Console.WriteLine("Received message: " + message);