using System.Net.Sockets;
using System.Net;
using System.Text;

UdpClient udpServer = new UdpClient(11000);
IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 11000);

Console.WriteLine("UDP Server is listening on port 11000...");

while (true)
{
    byte[] receivedBytes = udpServer.Receive(ref remoteEP);
    string receivedMessage = Encoding.UTF8.GetString(receivedBytes);
    Console.WriteLine($"Received: {receivedMessage} from {remoteEP}");
}