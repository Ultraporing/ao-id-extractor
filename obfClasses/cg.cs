using System;
using System.Runtime.CompilerServices;

namespace ao_id_extractor.obfClasses
{
    public class cg
    {
        public enum aa
        {
            a,
            b,
            c,
            d
        }

        [CompilerGenerated]
        private cg.aa a;

        [CompilerGenerated]
        private uint b;

        [CompilerGenerated]
        private string c;

        [CompilerGenerated]
        private uint d;

        [CompilerGenerated]
        private string e;

        [CompilerGenerated]
        public cg.aa F()
        {
            return this.a;
        }

        [CompilerGenerated]
        private void F(cg.aa A_0)
        {
            this.a = A_0;
        }

        [CompilerGenerated]
        public uint G()
        {
            return this.b;
        }

        [CompilerGenerated]
        private void G(uint A_0)
        {
            this.b = A_0;
        }

        [CompilerGenerated]
        public string H()
        {
            return this.c;
        }

        [CompilerGenerated]
        private void G(string A_0)
        {
            this.c = A_0;
        }

        [CompilerGenerated]
        public uint I()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void F(uint A_0)
        {
            this.d = A_0;
        }

        [CompilerGenerated]
        public string J()
        {
            return this.e;
        }

        [CompilerGenerated]
        private void F(string A_0)
        {
            this.e = A_0;
        }

        public bool K()
        {
            return this.I() != 0u;
        }

        public cg(cg.aa A_0, string A_1, string A_2)
        {
            this.F(A_0);
            this.G(A_1);
            if (!string.IsNullOrEmpty(A_1))
            {
                this.G(ce.A(A_1));
            }
            this.F(A_2);
            this.F(ce.A(A_2));
        }
    }
}