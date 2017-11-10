using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ao_id_extractor.obfClasses
{
    public class ne
    {
        public static byte[] a;

        public static byte[] b;

        public static Func<string, Stream> c;

        [CompilerGenerated]
        private static Func<string, Stream> d;

        static ne()
        {
            ne.a = new byte[]
            {
            48,
            239,
            114,
            71,
            66,
            242,
            4,
            50
            };
            ne.b = new byte[]
            {
            14,
            166,
            220,
            137,
            219,
            237,
            220,
            79
            };
            if (ne.d == null)
            {
                ne.d = new Func<string, Stream>(ne.A);
            }
            ne.c = ne.d;
        }

        public static Stream B(string A_0)
        {
            Stream stream = ne.c(A_0);
            if (stream != null)
            {
                return stream;
            }
            string text = Path.Combine(Path.GetDirectoryName(A_0), Path.GetFileNameWithoutExtension(A_0)) + ".bin";
            if (File.Exists(text))
            {
                DES dES = new DESCryptoServiceProvider();
                stream = ne.c(text);
                CryptoStream stream2 = new CryptoStream(stream, dES.CreateDecryptor(ne.a, ne.b), CryptoStreamMode.Read);
                return new GZipStream(stream2, CompressionMode.Decompress);
            }
            ae6.A(false, string.Concat(new string[]
            {
            "File not found ",
            A_0,
            "(or ",
            text,
            ")"
            }));
            return null;
        }

        [CompilerGenerated]
        private static Stream A(string A_0)
        {
            if (File.Exists(A_0))
            {
                return new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            return null;
        }
    }
}