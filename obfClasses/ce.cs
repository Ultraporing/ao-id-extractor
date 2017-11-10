using System;
using System.Text;

namespace ao_id_extractor.obfClasses
{
    public class ce
    {
        private const uint a = 16777619u;

        private const uint b = 2166136261u;

        private static byte c;

        private static uint d;

        static ce()
        {
            ce.A(32);
        }

        public static byte A()
        {
            return ce.c;
        }

        public static void A(byte A_0)
        {
            ce.c = A_0;
            ce.d = (1u << (int)ce.c) - 1u;
        }

        public static uint A(string A_0)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(A_0.ToLower());
            uint num = 2166136261u;
            for (int i = 0; i < bytes.Length; i++)
            {
                num *= 16777619u;
                num ^= (uint)bytes[i];
            }
            if (ce.c == 32)
            {
                return num;
            }
            return num >> (int)ce.c ^ (num & ce.d);
        }
    }
}