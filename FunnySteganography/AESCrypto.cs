using System.IO;
using System.Security.Cryptography;

namespace FunnySteganography
{
    public static class AESCrypto
    {
        // The Meow Key
        public static readonly byte[] AES_KEY = {
            0x08, 0x1C, 0x01, 0x3C, 0x1B, 0x41, 0x6B, 0x61,
            0x74, 0x73, 0x75, 0x6B, 0x69, 0x4A, 0x69, 0x61
        };

        public static readonly byte[] AES_IV = {
            0x6E, 0x65, 0x6B, 0x6F, 0x73, 0x6D, 0x61, 0x6C,
            0x6C, 0x72, 0x75, 0x38, 0x30, 0x39, 0x32, 0x33
        };

        public static byte[] encrypt(byte[] data, byte[] key, byte[] iv)
        {
            AesManaged aes = new AesManaged();
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }

        public static byte[] decrypt(byte[] data, byte[] key, byte[] iv)
        {
            AesManaged aes = new AesManaged();
            using (MemoryStream ms = new MemoryStream(data))
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(key, iv), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
            }
        }
    }
}