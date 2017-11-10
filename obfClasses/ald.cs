using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ao_id_extractor.obfClasses
{
    public struct ald : IComparable, IComparable<ald>, IEquatable<ald>, ISerializable
    {
        public const long a = 10000L;

        public const long b = 10000000L;

        public const long c = 600000000L;

        public const long d = 36000000000L;

        public const long e = 864000000000L;

        public static readonly ald f = new ald(9223372036854775807L);

        public static readonly ald g = new ald(-9223372036854775808L);

        public static readonly ald h = new ald(0L);

        public static readonly ald i = new ald(1L);

        public static readonly ald j = new ald(10000L);

        public static readonly ald k = new ald(10000000L);

        public static readonly ald l = new ald(600000000L);

        public static readonly ald m = new ald(36000000000L);

        public static readonly ald n = new ald(864000000000L);

        public readonly long o;

        public long K()
        {
            return this.o / 864000000000L;
        }

        public long L()
        {
            return this.o % 864000000000L / 36000000000L;
        }

        public long M()
        {
            return this.o % 36000000000L / 600000000L;
        }

        public long N()
        {
            return this.o % 600000000L / 10000000L;
        }

        public long P()
        {
            return this.o % 10000000L / 10000L;
        }

        public double Q()
        {
            return (double)this.o / 864000000000.0;
        }

        public double R()
        {
            return (double)this.o / 36000000000.0;
        }

        public double S()
        {
            return (double)this.o / 600000000.0;
        }

        public double T()
        {
            return (double)this.o / 10000000.0;
        }

        public double U()
        {
            return (double)this.o / 10000.0;
        }

        public ald(long A_0)
        {
            this = default(ald);
            this.o = A_0;
        }

        public ald(int A_0, int A_1, int A_2, int A_3, int A_4)
        {
            this = default(ald);
            this.o = 864000000000L * (long)A_0 + 36000000000L * (long)A_1 + 600000000L * (long)A_2 + 10000000L * (long)A_3 + 10000L * (long)A_4;
        }

        public bool v()
        {
            return this.o < 0L;
        }

        public bool w()
        {
            return this.o <= 0L;
        }

        public static ald K(long A_0)
        {
            return new ald(A_0);
        }

        public static ald P(int A_0)
        {
            return new ald((long)A_0 * 864000000000L);
        }

        public static ald N(int A_0)
        {
            return new ald((long)A_0 * 36000000000L);
        }

        public static ald M(int A_0)
        {
            return new ald((long)A_0 * 600000000L);
        }

        public static ald L(int A_0)
        {
            return new ald((long)A_0 * 10000000L);
        }

        public static ald K(int A_0)
        {
            return new ald((long)A_0 * 10000L);
        }

        public static ald P(double A_0)
        {
            return new ald((long)(A_0 * 864000000000.0 + 0.5));
        }

        public static ald N(double A_0)
        {
            return new ald((long)(A_0 * 36000000000.0 + 0.5));
        }

        public static ald M(double A_0)
        {
            return new ald((long)(A_0 * 600000000.0 + 0.5));
        }

        public static ald K(of A_0)
        {
            return new ald((long)A_0.i * 10000000L + 1L >> 12);
        }

        public static ald L(double A_0)
        {
            return new ald((long)(A_0 * 10000000.0 + 0.5));
        }

        public static ald K(double A_0)
        {
            return new ald((long)(A_0 * 10000.0 + 0.5));
        }

        public static ald K(TimeSpan A_0)
        {
            return new ald(A_0.Ticks);
        }

        public static ald W(ald A_0, ald A_1)
        {
            if (ald.U(A_0, A_1))
            {
                return A_0;
            }
            return A_1;
        }

        public static ald V(ald A_0, ald A_1)
        {
            if (ald.T(A_0, A_1))
            {
                return A_0;
            }
            return A_1;
        }

        public static ald M(ald A_0)
        {
            if (A_0.o >= 0L)
            {
                return A_0;
            }
            return ald.K(A_0);
        }

        public ald X()
        {
            if (this.o < 0L)
            {
                return new ald(-this.o);
            }
            return new ald(this.o);
        }

        public static bool U(ald A_0, ald A_1)
        {
            return A_0.o < A_1.o;
        }

        public static bool T(ald A_0, ald A_1)
        {
            return A_0.o > A_1.o;
        }

        public static bool S(ald A_0, ald A_1)
        {
            return A_0.o == A_1.o;
        }

        public static bool R(ald A_0, ald A_1)
        {
            return A_0.o != A_1.o;
        }

        public static bool Q(ald A_0, ald A_1)
        {
            return A_0.o <= A_1.o;
        }

        public static bool P(ald A_0, ald A_1)
        {
            return A_0.o >= A_1.o;
        }

        public static ald N(ald A_0, ald A_1)
        {
            return new ald(A_0.o + A_1.o);
        }

        public static ald M(ald A_0, ald A_1)
        {
            return new ald(A_0.o - A_1.o);
        }

        public static float L(ald A_0, ald A_1)
        {
            return (float)A_0.o / (float)A_1.o;
        }

        public static ald L(ald A_0, float A_1)
        {
            return new ald((long)((float)A_0.o / A_1));
        }

        public static ald K(ald A_0, float A_1)
        {
            return new ald((long)((float)A_0.o * A_1));
        }

        public static ald K(float A_0, ald A_1)
        {
            return new ald((long)(A_0 * (float)A_1.o));
        }

        public static ald L(ald A_0)
        {
            return new ald(A_0.o);
        }

        public static ald K(ald A_0)
        {
            return new ald(-A_0.o);
        }

        public static ald K(ald A_0, of A_1)
        {
            return new ald(A_0.o * (long)A_1.i >> 12);
        }

        public static ald K(of A_0, ald A_1)
        {
            return new ald(A_1.o * (long)A_0.i >> 12);
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is ald))
            {
                throw new ArgumentException();
            }
            ald ald = (ald)obj;
            if (this.o > ald.o)
            {
                return 1;
            }
            if (this.o == ald.o)
            {
                return 0;
            }
            return -1;
        }

        public int CompareTo(ald xOther)
        {
            if (this.o > xOther.o)
            {
                return 1;
            }
            if (this.o == xOther.o)
            {
                return 0;
            }
            return -1;
        }

        public override bool Equals(object value)
        {
            if (value != null && value is ald)
            {
                return ((GameTimeStamp)value).Ticks == this.o;
            }
            throw new ArgumentException();
        }

        public static float K(ald A_0, ald A_1)
        {
            float num = (float)A_0.T();
            if (num <= 0f)
            {
                return 1f;
            }
            float num2 = (float)A_1.T();
            return Math.Max(0f, Math.Min(1f, 1f - num2 / num));
        }

        public bool Equals(ald other)
        {
            return other.o == this.o;
        }

        public override int GetHashCode()
        {
            return (int)this.o;
        }

        public override string ToString()
        {
            return this.o.ToString();
        }

        public string y()
        {
            if (this.o < 600000000L)
            {
                return string.Format("{0:0}.{1:000}s", this.N(), this.P());
            }
            if (this.o < 36000000000L)
            {
                return string.Format("{0:0}:{1:00}.{2:000}", this.M(), this.N(), this.P());
            }
            return string.Format("{0:0}:{1:00}:{2:00}.{3:000}", new object[]
            {
            this.L() + this.K() * 24L,
            this.M(),
            this.N(),
            this.P()
            });
        }

        private ald(SerializationInfo A_0, StreamingContext A_1)
        {
            if (A_0 == null)
            {
                throw new ArgumentNullException("info");
            }
            bool flag = false;
            long num = 0L;
            SerializationInfoEnumerator enumerator = A_0.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Name == "ticks")
                {
                    num = Convert.ToInt64(enumerator.Value, CultureInfo.InvariantCulture);
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                this.o = num;
                return;
            }
            throw new SerializationException("Serialization: Missing GameTimeStamp Data");
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }
            info.AddValue("ticks", this.o);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)ald.k).GetObjectData(info, context);
        }
    }
}