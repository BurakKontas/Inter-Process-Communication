using System;
using System.IO.MemoryMappedFiles;
using System.Text;

var mmf = MemoryMappedFile.OpenExisting("testmap");
using (var stream = mmf.CreateViewStream())
{
    byte[] buffer = new byte[1000];
    stream.Read(buffer, 0, buffer.Length);
    string message = Encoding.UTF8.GetString(buffer).TrimEnd('\0');
    Console.WriteLine("Data read from memory mapped file: " + message);
}