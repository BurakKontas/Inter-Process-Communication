using System.IO.MemoryMappedFiles;
using System.Text;

using MemoryMappedFile mmf = MemoryMappedFile.CreateNew("sharedMemory", 1024);
using MemoryMappedViewAccessor accessor = mmf.CreateViewAccessor();

Console.WriteLine("Shared memory oluşturuldu, veri yazılıyor...");

int messageCounter = 0;

while (true)
{
    // Mesaj ve timestamp oluştur
    string message = $"Mesaj {messageCounter++}: Merhaba Client! Gönderim Zamanı: {DateTime.Now}";
    byte[] messageBytes = Encoding.UTF8.GetBytes(message);

    // Shared memory'ye yaz
    accessor.WriteArray(0, messageBytes, 0, messageBytes.Length);

    Console.WriteLine($"{message} - shared memory'ye yazıldı.");

    // 2 saniyede bir yeni mesaj yaz
    Thread.Sleep(2000);
}