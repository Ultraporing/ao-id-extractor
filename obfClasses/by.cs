using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class by : bx
    {
        [CompilerGenerated]
        private new oe am;

        [CompilerGenerated]
        private new oe an;

        [CompilerGenerated]
        public oe Fs()
        {
            return this.am;
        }

        [CompilerGenerated]
        protected void D2(oe A_0)
        {
            this.am = A_0;
        }

        [CompilerGenerated]
        public oe Ft()
        {
            return this.an;
        }

        [CompilerGenerated]
        protected void D3(oe A_0)
        {
            this.an = A_0;
        }

        public by(cu A_0) : base(A_0)
        {
            base.N = true;
            this.D2(oe.h);
        }

        public override ItemContainerErrorCode B3(bz A_0, bz A_1)
        {
            ItemContainerErrorCode itemContainerErrorCode = base.B3(A_0, A_1);
            if (itemContainerErrorCode != ItemContainerErrorCode.Ok)
            {
                return itemContainerErrorCode;
            }
            if (this.D4(A_1.a) != this.D4(A_0.a))
            {
                return ItemContainerErrorCode.MergeDurabilityMisMatch;
            }
            return ItemContainerErrorCode.Ok;
        }

        public override bool B4(XmlElement A_0)
        {
            base.B4(A_0);
            this.D2(al5.C(A_0, "durability", this.Fs()));
            // TODO: Doublecheck that shit
            // base.K;
            return true;
        }

        protected void A(hn A_0)
        {
            oe a_ = A_0.Ass().jo().i();
            this.D3(oe.O(this.Fs(), a_));
            this.D3(oe.P(this.Ft(), oe.k));
        }

        public int D4(oe A_0)
        {
            return i0.I(A_0, this.Fs());
        }

        public bool D5(oe A_0)
        {
            return by.A(A_0, this.Ft());
        }

        public override void B5(hn A_0)
        {
            base.B5(A_0);
            this.A(A_0);
        }

        public static bool A(oe A_0, oe A_1)
        {
            return oe.G(A_0, A_1);
        }

        public static Dictionary<string, short> A(string A_0, short A_1)
        {
            if (A_0 == null)
            {
                A_0 = string.Empty;
            }
            return new Dictionary<string, short>(1)
        {
            {
                A_0,
                A_1
            }
        };
        }

        public static void A(Dictionary<string, short> A_0, short A_1)
        {
            by.B(A_0, null, A_1);
        }

        public static void B(Dictionary<string, short> A_0, Dictionary<string, short> A_1, short A_2)
        {
            if (A_0 == null)
            {
                return;
            }
            int num = 0;
            foreach (short current in A_0.Values)
            {
                num += (int)current;
                if (num > (int)A_2)
                {
                    break;
                }
            }
            if ((int)A_2 == num)
            {
                by.A(A_0, A_1);
                return;
            }
            by.A(A_0, A_1, A_2);
        }

        public static void A(Dictionary<string, short> A_0, Dictionary<string, short> A_1)
        {
            if (A_0 == null)
            {
                return;
            }
            if (A_1 != null)
            {
                foreach (KeyValuePair<string, short> current in A_0)
                {
                    string key = current.Key;
                    short num = 0;
                    if (A_1.TryGetValue(key, out num))
                    {
                        num += current.Value;
                        A_1[key] = num;
                    }
                    else
                    {
                        A_1.Add(key, current.Value);
                    }
                }
            }
            A_0.Clear();
        }

        public static void A(Dictionary<string, short> A_0, Dictionary<string, short> A_1, short A_2)
        {
            if (A_0 == null)
            {
                return;
            }
            int num = (int)A_2;
            List<string> list = new List<string>(A_0.Keys);
            for (int i = 0; i < list.Count; i++)
            {
                if (num <= 0)
                {
                    return;
                }
                string key = list[i];
                short num2 = A_0[key];
                short num3 = (short)Math.Min((int)num2, num);
                if (A_1 != null)
                {
                    short num4 = 0;
                    if (A_1.TryGetValue(key, out num4))
                    {
                        int num5 = (int)(num4 + num3);
                        if (num5 <= 32767)
                        {
                            num4 += num3;
                        }
                        else
                        {
                            num4 = 32767;
                        }
                        A_1[key] = num4;
                    }
                    else
                    {
                        A_1.Add(key, num3);
                    }
                }
                if (num3 == num2)
                {
                    A_0.Remove(key);
                }
                else
                {
                    // TODO: Forced Cast, check if it works!
                    A_0[key] = (short)(num2 - num3);
                }
                num -= (int)num3;
            }
        }
    }
}