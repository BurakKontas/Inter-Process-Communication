using System.IO.MemoryMappedFiles;
using System.Text;

Console.WriteLine("Shared memory'ye bağlanılıyor...");

using MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("sharedMemory");
using MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor();

byte[] messageBytes = new byte[1024];

while (true)
{
    // Shared memory'den mesajı oku
    accessor.ReadArray(0, messageBytes, 0, messageBytes.Length);
    string message = Encoding.UTF8.GetString(messageBytes).TrimEnd('\0');

    // Boş değilse ekrana yaz
    if (!string.IsNullOrEmpty(message))
    {
        Console.WriteLine($"Server'dan gelen mesaj: {message}");
    }

    // 1 saniyede bir kontrol et
    Thread.Sleep(1000);
}