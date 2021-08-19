using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Reflection;

namespace Sha2Hash
{
    class Program
    {
        static void Main()
        {
            string filePath = Assembly.GetEntryAssembly().Location;

            var a = GetSha2HashStr(filePath);
            Console.WriteLine(a);

            var b = GetSha2HashSb(filePath);
            Console.WriteLine(b);
        }

        // Display the byte array in a readable format.
        public static string PrintByteArrayStr(byte[] array)
        {
            string s = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                s += $"{array[i]:X2}";
                if ((i % 4) == 3) s += ' ';
            }
            return s;
        }

        public static string GetSha2HashStr(string filePath)
        {
            using (SHA256 sha = SHA256.Create())
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    return PrintByteArrayStr(sha.ComputeHash(fs));
                }
            }
        }

        // Display the byte array in a readable format.
        public static string PrintByteArraySb(byte[] array)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append($"{array[i]:X2}");
                if ((i % 4) == 3) stringBuilder.Append(' ');
            }
            return stringBuilder.ToString();
        }

        public static string GetSha2HashSb(string filePath)
        {
            using (SHA256 sha = SHA256.Create())
            {
                using (FileStream fs = File.OpenRead(filePath))
                {
                    return PrintByteArraySb(sha.ComputeHash(fs));
                }
            }
        }
    }
}
