using System;

namespace ao_id_extractor.obfClasses
{
    public struct of : IComparable<of>, IEquatable<of>
    {
        public const int a = 12;

        private const int b = 4096;

        private const int c = 2048;

        private const int d = 32;

        private const int e = -2147483648;

        private const int f = 2147483647;

        public const int g = 4095;

        public const int h = -4096;

        public int i;

        public static of D()
        {
            return new of(0);
        }

        public static of C()
        {
            return new of(4096);
        }

        public static of B()
        {
            return new of(-2147483648);
        }

        public static of A()
        {
            return new of(2147483647);
        }

        public static of B(int A_0)
        {
            return new of(A_0);
        }

        public static of A(int A_0)
        {
            return new of(A_0 << 12);
        }

        public static of A(float A_0)
        {
            if (A_0 > 0f)
            {
                return new of((int)((double)(A_0 * 4096f) + 0.5));
            }
            return new of((int)((double)(A_0 * 4096f) - 0.5));
        }

        private of(int A_0)
        {
            this.i = A_0;
        }

        public int E()
        {
            if (this.i > 0)
            {
                return this.i >> 12;
            }
            return this.i + 4095 >> 12;
        }

        public float F()
        {
            return (float)this.G();
        }

        public double G()
        {
            return 1.0 * (double)this.i / 4096.0;
        }

        public static of D(of A_0)
        {
            if (!of.D(A_0, of.D()))
            {
                return A_0;
            }
            return of.B(A_0);
        }

        public int CompareTo(of other)
        {
            return this.i.CompareTo(other.i);
        }

        public bool Equals(of other)
        {
            return this.i.Equals(other.i);
        }

        public override bool Equals(object other)
        {
            return other is of && this.Equals((of)other);
        }

        public override int GetHashCode()
        {
            return this.i.GetHashCode();
        }

        public static of C(of A_0)
        {
            return A_0;
        }

        public static of B(of A_0)
        {
            return new of(-A_0.i);
        }

        public static of L(of A_0, of A_1)
        {
            return new of(A_0.i + A_1.i);
        }

        public static of K(int A_0, of A_1)
        {
            return new of(of.A(A_0).i + A_1.i);
        }

        public static of L(of A_0, int A_1)
        {
            return new of(A_0.i + of.A(A_1).i);
        }

        public static of K(float A_0, of A_1)
        {
            return new of(of.A(A_0).i + A_1.i);
        }

        public static of K(of A_0, float A_1)
        {
            return new of(A_0.i + of.A(A_1).i);
        }

        public static of K(of A_0, of A_1)
        {
            return new of(A_0.i - A_1.i);
        }

        public static of J(int A_0, of A_1)
        {
            return new of(of.A(A_0).i - A_1.i);
        }

        public static of K(of A_0, int A_1)
        {
            return new of(A_0.i - of.A(A_1).i);
        }

        public static of J(float A_0, of A_1)
        {
            return new of(of.A(A_0).i - A_1.i);
        }

        public static of J(of A_0, float A_1)
        {
            return new of(A_0.i - of.A(A_1).i);
        }

        public static of J(of A_0, of A_1)
        {
            long num = (long)A_0.i * (long)A_1.i + 2048L >> 12;
            return new of((int)num);
        }

        public static of J(of A_0, int A_1)
        {
            return of.J(A_0, of.A(A_1));
        }

        public static of H(int A_0, of A_1)
        {
            return of.J(of.A(A_0), A_1);
        }

        public static of H(of A_0, float A_1)
        {
            return of.J(A_0, of.A(A_1));
        }

        public static of H(float A_0, of A_1)
        {
            return of.J(of.A(A_0), A_1);
        }

        public static of H(of A_0, of A_1)
        {
            if (A_0.i > 0)
            {
                return new of((int)((((long)A_0.i << 12) + 2048L) / (long)A_1.i));
            }
            return new of((int)(((long)((long)A_0.i << 12) - 2048L) / (long)A_1.i));
        }

        public static of H(of A_0, int A_1)
        {
            return of.H(A_0, of.A(A_1));
        }

        public static of G(int A_0, of A_1)
        {
            return of.H(of.A(A_0), A_1);
        }

        public static of G(of A_0, float A_1)
        {
            return of.H(A_0, of.A(A_1));
        }

        public static of G(float A_0, of A_1)
        {
            return of.H(of.A(A_0), A_1);
        }

        public static of G(of A_0, of A_1)
        {
            return of.K(A_0, of.J(A_1, of.H(A_0, A_1).E()));
        }

        public static bool F(of A_0, of A_1)
        {
            return A_0.i == A_1.i;
        }

        public static bool G(of A_0, int A_1)
        {
            return A_0.i == of.A(A_1).i;
        }

        public static bool F(int A_0, of A_1)
        {
            return of.A(A_0).i == A_1.i;
        }

        public static bool F(of A_0, float A_1)
        {
            return A_0.i == of.A(A_1).i;
        }

        public static bool F(float A_0, of A_1)
        {
            return of.A(A_0).i == A_1.i;
        }

        public static bool E(of A_0, of A_1)
        {
            return A_0.i != A_1.i;
        }

        public static bool F(of A_0, int A_1)
        {
            return A_0.i != of.A(A_1).i;
        }

        public static bool E(int A_0, of A_1)
        {
            return of.A(A_0).i != A_1.i;
        }

        public static bool E(of A_0, float A_1)
        {
            return A_0.i != of.A(A_1).i;
        }

        public static bool E(float A_0, of A_1)
        {
            return of.A(A_0).i != A_1.i;
        }

        public static bool D(of A_0, of A_1)
        {
            return A_0.i < A_1.i;
        }

        public static bool E(of A_0, int A_1)
        {
            return A_0.i < of.A(A_1).i;
        }

        public static bool D(int A_0, of A_1)
        {
            return of.A(A_0).i < A_1.i;
        }

        public static bool D(of A_0, float A_1)
        {
            return A_0.i < of.A(A_1).i;
        }

        public static bool D(float A_0, of A_1)
        {
            return of.A(A_0).i < A_1.i;
        }

        public static bool C(of A_0, of A_1)
        {
            return A_0.i > A_1.i;
        }

        public static bool D(of A_0, int A_1)
        {
            return A_0.i > of.A(A_1).i;
        }

        public static bool C(int A_0, of A_1)
        {
            return of.A(A_0).i > A_1.i;
        }

        public static bool C(of A_0, float A_1)
        {
            return A_0.i > of.A(A_1).i;
        }

        public static bool C(float A_0, of A_1)
        {
            return of.A(A_0).i > A_1.i;
        }

        public static bool B(of A_0, of A_1)
        {
            return A_0.i <= A_1.i;
        }

        public static bool C(of A_0, int A_1)
        {
            return A_0.i <= of.A(A_1).i;
        }

        public static bool B(int A_0, of A_1)
        {
            return of.A(A_0).i <= A_1.i;
        }

        public static bool B(of A_0, float A_1)
        {
            return A_0.i <= of.A(A_1).i;
        }

        public static bool B(float A_0, of A_1)
        {
            return of.A(A_0).i <= A_1.i;
        }

        public static bool A(of A_0, of A_1)
        {
            return A_0.i >= A_1.i;
        }

        public static bool B(of A_0, int A_1)
        {
            return A_0.i >= of.A(A_1).i;
        }

        public static bool A(int A_0, of A_1)
        {
            return of.A(A_0).i >= A_1.i;
        }

        public static bool A(of A_0, float A_1)
        {
            return A_0.i >= of.A(A_1).i;
        }

        public static bool A(float A_0, of A_1)
        {
            return of.A(A_0).i >= A_1.i;
        }

        public static of A(of A_0, int A_1)
        {
            if (A_0.i < 0)
            {
                throw new ArithmeticException("Input Error");
            }
            if (A_0.i == 0)
            {
                return of.D();
            }
            of of1 = of.L(A_0, new of(2048));
            for (int i = 0; i < A_1; i++)
            {
                of1 = new of(of.L(of1, of.H(A_0, of1)).i >> 1);
            }
            if (of1.i < 0)
            {
                throw new ArithmeticException("Overflow");
            }
            return of1;
        }

        public static of A(of A_0)
        {
            int a_ = 8;
            if (A_0.i > 409600)
            {
                a_ = 12;
            }
            if (A_0.i > 4096000)
            {
                a_ = 16;
            }
            return of.A(A_0, a_);
        }

        public override string ToString()
        {
            return this.F().ToString();
        }
    }
}