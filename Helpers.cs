using System.IO;

namespace Kizuna
{
    public static class Helpers
    {
        public static byte[] ToBytes(this Stream input)
        {
            using MemoryStream ms = new();
            input.CopyTo(ms);
            return ms.ToArray();
        }
    }
}
