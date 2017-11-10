using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ao_id_extractor.obfClasses
{
    [Serializable]
    public struct GameTimeStamp : IComparable, IComparable<GameTimeStamp>, IEquatable<GameTimeStamp>, ISerializable
    {
        public delegate GameTimeStamp a();

        public static readonly GameTimeStamp MaxValue;

        public static readonly GameTimeStamp MinValue;

        public static readonly GameTimeStamp Zero;

        public readonly long Ticks;

        [ThreadStatic]
        private static GameTimeStamp.a pTimeSource;

        public static GameTimeStamp.a TimeSource
        {
            get
            {
                return GameTimeStamp.pTimeSource;
            }
            set
            {
                GameTimeStamp.pTimeSource = value;
            }
        }

        public static GameTimeStamp Now
        {
            get
            {
                if (GameTimeStamp.TimeSource == null)
                {
                    return GameTimeStamp.F();
                }
                return GameTimeStamp.TimeSource();
            }
        }

        public static GameTimeStamp Today
        {
            get
            {
                GameTimeStamp a_ = GameTimeStamp.Now;
                return GameTimeStamp.A(a_, a_.j());
            }
        }

        public static ald Time
        {
            get
            {
                return GameTimeStamp.Now.j();
            }
        }

        public static GameTimeStamp NextFullHour
        {
            get
            {
                return GameTimeStamp.B(GameTimeStamp.Now);
            }
        }

        public static GameTimeStamp NextDayStart
        {
            get
            {
                return GameTimeStamp.A(GameTimeStamp.Now);
            }
        }

        static GameTimeStamp()
        {
            GameTimeStamp.MaxValue = new GameTimeStamp(9223372036854775807L);
            GameTimeStamp.MinValue = new GameTimeStamp(-9223372036854775808L);
            GameTimeStamp.Zero = new GameTimeStamp(0L);
            GameTimeStamp.TimeSource = new GameTimeStamp.a(GameTimeStamp.F);
        }

        public GameTimeStamp(long A_0)
        {
            this = default(GameTimeStamp);
            this.Ticks = A_0;
        }

        public GameTimeStamp(string A_0)
        {
            this = default(GameTimeStamp);
            long ticks;
            if (long.TryParse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture.NumberFormat, out ticks))
            {
                this.Ticks = ticks;
            }
        }

        public static GameTimeStamp F()
        {
            return new GameTimeStamp(DateTime.UtcNow.Ticks);
        }

        public static GameTimeStamp B(GameTimeStamp A_0)
        {
            long num = A_0.Ticks % 36000000000L;
            long num2 = A_0.Ticks - num;
            num2 += 36000000000L;
            return new GameTimeStamp(num2);
        }

        public static GameTimeStamp A(GameTimeStamp A_0)
        {
            long num = A_0.Ticks % 864000000000L;
            long num2 = A_0.Ticks - num;
            num2 += 864000000000L;
            return new GameTimeStamp(num2);
        }

        public static bool I(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return A_0.Ticks < A_1.Ticks;
        }

        public static bool H(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return A_0.Ticks > A_1.Ticks;
        }

        public static bool G(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return A_0.Ticks == A_1.Ticks;
        }

        public static bool F(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return A_0.Ticks != A_1.Ticks;
        }

        public static bool E(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return A_0.Ticks <= A_1.Ticks;
        }

        public static bool D(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return A_0.Ticks >= A_1.Ticks;
        }

        public static GameTimeStamp B(GameTimeStamp A_0, ald A_1)
        {
            return new GameTimeStamp(A_0.Ticks + A_1.o);
        }

        public static GameTimeStamp A(GameTimeStamp A_0, ald A_1)
        {
            return new GameTimeStamp(A_0.Ticks - A_1.o);
        }

        public static ald C(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            return new ald(A_0.Ticks - A_1.Ticks);
        }

        public static GameTimeStamp B(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            if (GameTimeStamp.I(A_0, A_1))
            {
                return A_0;
            }
            return A_1;
        }

        public static GameTimeStamp A(GameTimeStamp A_0, GameTimeStamp A_1)
        {
            if (GameTimeStamp.H(A_0, A_1))
            {
                return A_0;
            }
            return A_1;
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is GameTimeStamp))
            {
                throw new ArgumentException();
            }
            GameTimeStamp gameTimeStamp = (GameTimeStamp)obj;
            if (this.Ticks > gameTimeStamp.Ticks)
            {
                return 1;
            }
            if (this.Ticks == gameTimeStamp.Ticks)
            {
                return 0;
            }
            return -1;
        }

        public int CompareTo(GameTimeStamp xOther)
        {
            if (this.Ticks > xOther.Ticks)
            {
                return 1;
            }
            if (this.Ticks == xOther.Ticks)
            {
                return 0;
            }
            return -1;
        }

        public override bool Equals(object value)
        {
            if (value != null && value is GameTimeStamp)
            {
                return ((GameTimeStamp)value).Ticks == this.Ticks;
            }
            throw new ArgumentException();
        }

        public bool Equals(GameTimeStamp other)
        {
            return other.Ticks == this.Ticks;
        }

        public override int GetHashCode()
        {
            return (int)this.Ticks;
        }

        public override string ToString()
        {
            return this.Ticks.ToString();
        }

        public string h()
        {
            return new ald(this.Ticks).y();
        }

        public DateTime i()
        {
            return new DateTime(Math.Max(this.Ticks, 0L));
        }

        public ald j()
        {
            return new ald(this.Ticks % 864000000000L);
        }

        public GameTimeStamp k()
        {
            return new GameTimeStamp(this.Ticks - this.Ticks % 864000000000L);
        }

        public static GameTimeStamp A(DateTime A_0)
        {
            return new GameTimeStamp(A_0.Ticks);
        }

        private GameTimeStamp(SerializationInfo A_0, StreamingContext A_1)
        {
            if (A_0 == null)
            {
                throw new ArgumentNullException("info");
            }
            bool flag = false;
            long ticks = 0L;
            SerializationInfoEnumerator enumerator = A_0.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Name == "Ticks")
                {
                    ticks = Convert.ToInt64(enumerator.Value, CultureInfo.InvariantCulture);
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                this.Ticks = ticks;
                return;
            }
            throw new SerializationException("Serialization: Missing GameTimeStamp Data");
        }

        void ISerializable.GetObjectData(SerializationInfo A_0, StreamingContext A_1)
        {
            if (A_0 == null)
            {
                throw new ArgumentNullException("info");
            }
            A_0.AddValue("Ticks", this.Ticks);
        }
    }
}
