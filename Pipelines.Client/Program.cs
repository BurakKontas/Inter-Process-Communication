using System.IO.Pipes;
using System.Text;

using (var client = new NamedPipeClientStream("test_pipe"))
{
    client.Connect();
    using (var writer = new StreamWriter(client, Encoding.UTF8))
    {
        writer.WriteLine("Hello from client!");
        writer.Flush();
    }
}