using System;
using System.Security.Cryptography;
using System.Text;

namespace MusicPodcast.Services.utils
{
    public class IdAutoGenerate
    {
        public string GenerateId(string inputString)
        {
            Guid uniqueId = Guid.NewGuid();
            return uniqueId.ToString();
        }
    }
}


