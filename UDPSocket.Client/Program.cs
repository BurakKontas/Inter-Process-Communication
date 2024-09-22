using System.Net.Sockets;
using System.Text;

UdpClient udpClient = new UdpClient();
string message = "Hello from UDP Client!";
byte[] messageBytes = Encoding.UTF8.GetBytes(message);

while (true)
{
    udpClient.Send(messageBytes, messageBytes.Length, "localhost", 11000);

    Console.WriteLine("Message sent to server.");

    Thread.Sleep(1000);
}

udpClient.Close();