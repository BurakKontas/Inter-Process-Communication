using System.IO.Pipes;
using System.Text;

var server = new NamedPipeServerStream("test_pipe");
Console.WriteLine("Waiting for connection...");
server.WaitForConnection();

using (var reader = new StreamReader(server, Encoding.UTF8))
{
    string message = reader.ReadLine();
    Console.WriteLine("Received from client: " + message);
}