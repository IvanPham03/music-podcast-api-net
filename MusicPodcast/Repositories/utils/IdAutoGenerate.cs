using System;
using System.Security.Cryptography;
using System.Text;

namespace MusicPodcast.Services.utils
{
    public class IdAutoGenerate
    {
        public string GenerateId(string inputString)
        {
            // Tạo một đối tượng cho chuỗi đầu vào
            var bytes = Encoding.UTF8.GetBytes(inputString);

            // Tạo một đối tượng MD5 để tạo hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(bytes);

                // Kết hợp thời gian và hash để tạo ID
                long timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                byte[] combinedBytes = new byte[hashBytes.Length + sizeof(long)];
                Buffer.BlockCopy(hashBytes, 0, combinedBytes, 0, hashBytes.Length);
                Buffer.BlockCopy(BitConverter.GetBytes(timestamp), 0, combinedBytes, hashBytes.Length, sizeof(long));

                string id = Convert.ToBase64String(combinedBytes);

                return id;
            }
        }
    }
}

