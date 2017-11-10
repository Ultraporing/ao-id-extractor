using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ao_id_extractor.obfClasses
{

    public struct od : IEquatable<od>
    {
        private static readonly od a = new od(0f, 0f);

        private static readonly od b = new od(1f, 0f);

        private static readonly od c = new od(0f, 1f);

        private static readonly od d = new od(1f, 1f);

        [CompilerGenerated]
        private of e;

        [CompilerGenerated]
        private of f;

        public static od D()
        {
            return od.a;
        }

        public static od C()
        {
            return od.b;
        }

        public static od B()
        {
            return od.c;
        }

        public static od A()
        {
            return od.d;
        }

        [CompilerGenerated]
        public of G()
        {
            return this.e;
        }

        [CompilerGenerated]
        public void A(of A_0)
        {
            this.e = A_0;
        }

        [CompilerGenerated]
        public of H()
        {
            return this.f;
        }

        [CompilerGenerated]
        public void B(of A_0)
        {
            this.f = A_0;
        }

        public od(of A_0, of A_1)
        {
            this = default(od);
            this.A(A_0);
            this.B(A_1);
        }

        public od(float A_0, float A_1)
        {
            this = default(od);
            this.A(of.A(A_0));
            this.B(of.A(A_1));
        }

        public static od D(od A_0, od A_1)
        {
            return new od(of.L(A_0.G(), A_1.G()), of.L(A_0.H(), A_1.H()));
        }

        public static od C(od A_0, od A_1)
        {
            return new od(of.K(A_0.G(), A_1.G()), of.K(A_0.H(), A_1.H()));
        }

        public static od A(od A_0)
        {
            return new od(of.B(A_0.G()), of.B(A_0.H()));
        }

        public static od B(od A_0, float A_1)
        {
            return new od(of.H(A_0.G(), A_1), of.H(A_0.H(), A_1));
        }

        public static od B(od A_0, of A_1)
        {
            return new od(of.J(A_0.G(), A_1), of.J(A_0.H(), A_1));
        }

        public static od A(float A_0, od A_1)
        {
            return new od(of.H(A_1.G(), A_0), of.H(A_1.H(), A_0));
        }

        public static od A(of A_0, od A_1)
        {
            return new od(of.J(A_1.G(), A_0), of.J(A_1.H(), A_0));
        }

        public static od A(od A_0, float A_1)
        {
            return new od(of.G(A_0.G(), A_1), of.G(A_0.H(), A_1));
        }

        public static od A(od A_0, of A_1)
        {
            return new od(of.H(A_0.G(), A_1), of.H(A_0.H(), A_1));
        }

        public static bool B(od A_0, od A_1)
        {
            return of.F(A_0.G(), A_1.G()) && of.F(A_0.H(), A_1.H());
        }

        public static bool A(od A_0, od A_1)
        {
            return of.E(A_0.G(), A_1.G()) || of.E(A_0.H(), A_1.H());
        }

        public of B(od A_0)
        {
            return of.L(of.J(this.G(), A_0.G()), of.J(this.H(), A_0.H()));
        }

        public of[] I()
        {
            return new of[]
            {
            this.G(),
            this.H()
            };
        }

        public float[] J()
        {
            return new float[]
            {
            this.G().F(),
            this.H().F()
            };
        }

        public static od A(float[] A_0)
        {
            if (A_0.Length == 2)
            {
                return new od(A_0[0], A_0[1]);
            }
            return od.D();
        }

        public of K()
        {
            return of.L(of.J(this.G(), this.G()), of.J(this.H(), this.H()));
        }

        public of L()
        {
            return of.A(this.K());
        }

        public bool C(od A_0, of A_1)
        {
            return of.D(of.D(of.K(A_0.G(), this.G())), A_1) && of.D(of.D(of.K(A_0.H(), this.H())), A_1);
        }

        public void M()
        {
            of of = this.L();
            if (of.D(of, 0))
            {
                this.A(of.H(this.G(), of));
                this.B(of.H(this.H(), of));
            }
        }

        public od N()
        {
            od result = new od(this.G(), this.H());
            result.M();
            return result;
        }

        public bool Equals(od other)
        {
            return of.F(this.G(), other.G()) && of.F(this.H(), other.H());
        }

        public override bool Equals(object other)
        {
            return other is od && this.Equals((od)other);
        }

        public override int GetHashCode()
        {
            return this.G().GetHashCode() ^ this.H().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture.NumberFormat, "{0:F},{1:F}", new object[]
            {
            this.G(),
            this.H()
            });
        }

        public akz O()
        {
            return new akz(this.G().F(), this.H().F());
        }

        public static od A(od A_0, od A_1, float A_2)
        {
            return od.D(A_0, od.A(A_2, od.C(A_1, A_0)));
        }
    }
}