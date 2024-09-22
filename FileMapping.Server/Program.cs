using System;
using System.IO.MemoryMappedFiles;
using System.Text;

var mmf = MemoryMappedFile.CreateNew("testmap", 1000);
using (var stream = mmf.CreateViewStream())
{
    byte[] buffer = Encoding.UTF8.GetBytes("Hello from File Mapping");
    stream.Write(buffer, 0, buffer.Length);
    Console.WriteLine("Data written to memory mapped file.");
}