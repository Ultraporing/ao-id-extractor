using System;
using System.Globalization;

namespace ao_id_extractor.obfClasses
{
    public struct oe : IComparable<oe>, IEquatable<oe>
    {
        public const long a = 10000L;

        public const long b = 5000L;

        private const long c = 9223372036854775807L;

        private const long d = -9223372036854775808L;

        public const long e = 922337203685477L;

        public const long f = -922337203685477L;

        public static readonly oe g = default(oe);

        public static readonly oe h = new oe(10000L);

        public static readonly oe i = new oe(9223372036854775807L);

        public static readonly oe j = new oe(-9223372036854775808L);

        public static readonly oe k = new oe(1L);

        public readonly long l;

        public long H()
        {
            return this.l / 10000L;
        }

        public long I()
        {
            return this.l % 10000L;
        }

        public double J()
        {
            return this.K() - (double)this.H();
        }

        public double K()
        {
            return (double)this.l / 10000.0;
        }

        private oe(long A_0)
        {
            this = default(oe);
            this.l = A_0;
        }

        public static oe E(double A_0)
        {
            if (A_0 > 922337203685477.0)
            {
                A_0 = 922337203685477.0;
            }
            if (A_0 < -922337203685477.0)
            {
                A_0 = -922337203685477.0;
            }
            return new oe((long)Math.Round(A_0 * 10000.0));
        }

        public static oe F(long A_0)
        {
            if (A_0 > 922337203685477L)
            {
                A_0 = 922337203685477L;
            }
            if (A_0 < -922337203685477L)
            {
                A_0 = -922337203685477L;
            }
            return new oe(A_0 * 10000L);
        }

        public static bool F(string A_0, out oe A_1)
        {
            long num;
            if (long.TryParse(A_0, NumberStyles.Any, CultureInfo.CurrentCulture, out num) && num >= -922337203685477L && num <= 922337203685477L)
            {
                A_1 = oe.F(num);
                return true;
            }
            A_1 = oe.g;
            return false;
        }

        public static bool E(string A_0, out oe A_1)
        {
            long num;
            if (long.TryParse(A_0, NumberStyles.Any, CultureInfo.CurrentCulture, out num) && num >= -9223372036854775808L && num <= 9223372036854775807L)
            {
                A_1 = oe.E(num);
                return true;
            }
            A_1 = oe.g;
            return false;
        }

        public static oe E(long A_0)
        {
            return new oe(A_0);
        }

        public static oe G()
        {
            return oe.i;
        }

        public static oe F()
        {
            return oe.j;
        }

        public static oe E()
        {
            return oe.g;
        }

        public long M()
        {
            if (this.I() != 5000L)
            {
                if (this.l >= 0L)
                {
                    if (this.I() > 5000L)
                    {
                        return this.H() + 1L;
                    }
                }
                else if (this.I() < -5000L)
                {
                    return this.H() - 1L;
                }
                return this.H();
            }
            if (this.H() % 2L == 0L)
            {
                return this.H();
            }
            return this.H() + 1L;
        }

        public oe N()
        {
            return oe.F(this.M());
        }

        public long O()
        {
            if (this.I() > 0L)
            {
                return this.H() + 1L;
            }
            return this.H();
        }

        public oe P()
        {
            return new oe(this.O() * 10000L);
        }

        public oe Q()
        {
            return new oe(this.H() * 10000L);
        }

        public override int GetHashCode()
        {
            return this.l.GetHashCode();
        }

        public int CompareTo(oe other)
        {
            if (this.l == other.l)
            {
                return 0;
            }
            if (this.l > other.l)
            {
                return 1;
            }
            return -1;
        }

        public bool Equals(oe other)
        {
            return other.l == this.l;
        }

        public override bool Equals(object obj)
        {
            return obj is oe && ((oe)obj).l == this.l;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1:0000}", this.H(), Math.Abs(this.I()));
        }

        public static oe Q(oe A_0, oe A_1)
        {
            long num = A_0.l + A_1.l;
            if (A_0.l > 0L && A_1.l > 0L && num < 0L)
            {
                return oe.i;
            }
            if (A_0.l < 0L && A_1.l < 0L && num > 0L)
            {
                return oe.j;
            }
            return new oe(num);
        }

        public static oe P(oe A_0, oe A_1)
        {
            return oe.Q(A_0, oe.F(A_1));
        }

        public static oe F(oe A_0)
        {
            if (A_0.l == -9223372036854775808L)
            {
                return oe.i;
            }
            return new oe(-A_0.l);
        }

        public static oe O(oe A_0, oe A_1)
        {
            long num = A_0.l * A_1.l;
            if (A_0.l == 0L || num / A_0.l == A_1.l)
            {
                return new oe(A_0.l * A_1.l / 10000L);
            }
            if ((A_0.l > 0L && A_1.l > 0L) || (A_0.l < 0L && A_1.l < 0L))
            {
                return oe.i;
            }
            return oe.j;
        }

        public static oe E(oe A_0, int A_1)
        {
            return oe.O(A_0, oe.F((long)A_1));
        }

        public static oe E(int A_0, oe A_1)
        {
            return oe.O(A_1, oe.F((long)A_0));
        }

        public static oe E(oe A_0, long A_1)
        {
            return oe.O(A_0, oe.F(A_1));
        }

        public static oe E(long A_0, oe A_1)
        {
            return oe.O(A_1, oe.F(A_0));
        }

        public static oe N(oe A_0, oe A_1)
        {
            if (A_1.l == 0L)
            {
                return oe.i;
            }
            if (A_0.l <= 9223372036854775807L && A_0.l >= -9223372036854775808L)
            {
                return new oe(A_0.l * 10000L / A_1.l);
            }
            if (A_1.l > 100000000L)
            {
                return new oe(A_0.l / A_1.H());
            }
            return oe.g;
        }

        public static bool M(oe A_0, oe A_1)
        {
            return A_0.l == A_1.l;
        }

        public static bool K(oe A_0, oe A_1)
        {
            return A_0.l != A_1.l;
        }

        public static bool J(oe A_0, oe A_1)
        {
            return A_0.l > A_1.l;
        }

        public static bool I(oe A_0, oe A_1)
        {
            return A_0.l < A_1.l;
        }

        public static bool H(oe A_0, oe A_1)
        {
            return A_0.l >= A_1.l;
        }

        public static bool G(oe A_0, oe A_1)
        {
            return A_0.l <= A_1.l;
        }

        public static oe F(oe A_0, oe A_1)
        {
            if (A_0.l < A_1.l)
            {
                return A_0;
            }
            return A_1;
        }

        public static oe E(oe A_0, oe A_1)
        {
            if (A_0.l > A_1.l)
            {
                return A_0;
            }
            return A_1;
        }

        public static oe E(oe A_0, oe A_1, oe A_2)
        {
            return oe.F(A_2, oe.E(A_0, A_1));
        }

        public static oe E(oe A_0)
        {
            if (A_0.l < 0L)
            {
                return oe.E(-A_0.l);
            }
            return A_0;
        }
    }
}