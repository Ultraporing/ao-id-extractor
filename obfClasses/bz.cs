using System;
using System.Runtime.CompilerServices;

namespace ao_id_extractor.obfClasses
{
    public class bz : IEquatable<bz>
    {
        public oe a = oe.g;

        public int b = 1;

        public oe c = oe.g;

        [CompilerGenerated]
        private bx d;

        [CompilerGenerated]
        public bx E()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void E(bx A_0)
        {
            this.d = A_0;
        }

        public bz(bz A_0)
        {
            this.E(A_0.E());
            this.a = A_0.a;
            this.b = A_0.b;
            this.c = A_0.c;
        }

        public bz(bx A_0)
        {
            this.E(A_0);
        }

        public bool Equals(bz pOther)
        {
            return this.E() == pOther.E() && oe.M(this.a, pOther.a) && this.b == pOther.b && oe.M(this.c, pOther.c);
        }

        public static bz E(bx A_0, int A_1)
        {
            if (A_0 == null)
            {
                return null;
            }
            bz bz = new bz(A_0);
            bz.b = A_1;
            by by = A_0 as by;
            if (by != null)
            {
                bz.a = by.Fs();
            }
            cv cv = A_0 as cv;
            if (cv != null)
            {
                bz.c = cv.A(cv);
            }
            return bz;
        }
    }
}