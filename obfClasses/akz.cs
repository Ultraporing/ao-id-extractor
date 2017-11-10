using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ao_id_extractor.obfClasses
{
    public struct akz
    {
        private static readonly akz a = new akz(0f, 0f);

        private static readonly akz b = new akz(1f, 0f);

        private static readonly akz c = new akz(0f, 1f);

        private static readonly akz d = new akz(1f, 1f);

        [CompilerGenerated]
        private float e;

        [CompilerGenerated]
        private float f;

        public static akz D()
        {
            return akz.a;
        }

        public static akz C()
        {
            return akz.b;
        }

        public static akz B()
        {
            return akz.c;
        }

        public static akz A()
        {
            return akz.d;
        }

        [CompilerGenerated]
        public float G()
        {
            return this.e;
        }

        [CompilerGenerated]
        public void A(float A_0)
        {
            this.e = A_0;
        }

        [CompilerGenerated]
        public float H()
        {
            return this.f;
        }

        [CompilerGenerated]
        public void B(float A_0)
        {
            this.f = A_0;
        }

        public akz(float A_0, float A_1)
        {
            this = default(akz);
            this.A(A_0);
            this.B(A_1);
        }

        public override bool Equals(object pOther)
        {
            if (!(pOther is akz))
            {
                return false;
            }
            akz akz = (akz)pOther;
            return this.G() == akz.G() && this.H() == akz.H();
        }

        public static akz D(akz A_0, akz A_1)
        {
            return new akz(A_0.G() + A_1.G(), A_0.H() + A_1.H());
        }

        public static akz C(akz A_0, akz A_1)
        {
            return new akz(A_0.G() - A_1.G(), A_0.H() - A_1.H());
        }

        public static akz A(akz A_0)
        {
            return new akz(-A_0.G(), -A_0.H());
        }

        public static akz B(akz A_0, float A_1)
        {
            return new akz(A_0.G() * A_1, A_0.H() * A_1);
        }

        public static akz A(float A_0, akz A_1)
        {
            return new akz(A_1.G() * A_0, A_1.H() * A_0);
        }

        public static akz A(akz A_0, float A_1)
        {
            return new akz(A_0.G() / A_1, A_0.H() / A_1);
        }

        public static bool B(akz A_0, akz A_1)
        {
            return A_0.G() == A_1.G() && A_0.H() == A_1.H();
        }

        public static bool A(akz A_0, akz A_1)
        {
            return A_0.G() != A_1.G() || A_0.H() != A_1.H();
        }

        public float B(akz A_0)
        {
            return this.G() * A_0.G() + this.H() * A_0.H();
        }

        public float[] I()
        {
            return new float[]
            {
            this.G(),
            this.H()
            };
        }

        public static akz A(float[] A_0)
        {
            if (A_0.Length == 2)
            {
                return new akz(A_0[0], A_0[1]);
            }
            return akz.D();
        }

        public static akz A(string A_0)
        {
            string[] array = A_0.Split(new char[]
            {
            ','
            });
            float a_;
            float a_2;
            if (array.Length == 2 && float.TryParse(array[0], NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out a_) && float.TryParse(array[1], NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out a_2))
            {
                return new akz(a_, a_2);
            }
            return akz.D();
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture.NumberFormat, "{0:F},{1:F}", new object[]
            {
            this.G(),
            this.H()
            });
        }

        public float J()
        {
            return this.G() * this.G() + this.H() * this.H();
        }

        public float K()
        {
            return (float)Math.Sqrt((double)this.J());
        }

        public bool C(akz A_0, float A_1)
        {
            return Math.Abs(A_0.G() - this.G()) < A_1 && Math.Abs(A_0.H() - this.H()) < A_1;
        }

        public void L()
        {
            float num = this.K();
            if (num > 0f)
            {
                this.A(this.G() / num);
                this.B(this.H() / num);
            }
        }

        public akz M()
        {
            akz result = new akz(this.G(), this.H());
            result.L();
            return result;
        }

        public override int GetHashCode()
        {
            return this.G().GetHashCode() ^ this.H().GetHashCode();
        }

        public static akz A(akz A_0, akz A_1, float A_2)
        {
            return akz.D(A_0, akz.A(A_2, akz.C(A_1, A_0)));
        }
    }
}