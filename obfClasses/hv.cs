using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class hv
    {
        public class aa
        {
            [CompilerGenerated]
            private float a;

            [CompilerGenerated]
            private float b;

            [CompilerGenerated]
            private float c;

            [CompilerGenerated]
            private int d;

            [CompilerGenerated]
            private int e;

            public aa(float A_0, float A_1, float A_2, int A_3, int A_4)
            {
                this.H(A_0);
                this.G(A_1);
                this.F(A_2);
                this.G(A_3);
                this.F(A_4);
            }

            [CompilerGenerated]
            public float F()
            {
                return this.a;
            }

            [CompilerGenerated]
            private void H(float A_0)
            {
                this.a = A_0;
            }

            [CompilerGenerated]
            public float G()
            {
                return this.b;
            }

            [CompilerGenerated]
            private void G(float A_0)
            {
                this.b = A_0;
            }

            [CompilerGenerated]
            public float H()
            {
                return this.c;
            }

            [CompilerGenerated]
            private void F(float A_0)
            {
                this.c = A_0;
            }

            [CompilerGenerated]
            public int I()
            {
                return this.d;
            }

            [CompilerGenerated]
            private void G(int A_0)
            {
                this.d = A_0;
            }

            [CompilerGenerated]
            public int J()
            {
                return this.e;
            }

            [CompilerGenerated]
            private void F(int A_0)
            {
                this.e = A_0;
            }
        }

        public class bb
        {
            public sealed class aa
            {
                [CompilerGenerated]
                private string a;

                [CompilerGenerated]
                private ew b;

                [CompilerGenerated]
                private float c;

                [CompilerGenerated]
                public string D()
                {
                    return this.a;
                }

                [CompilerGenerated]
                private void D(string A_0)
                {
                    this.a = A_0;
                }

                [CompilerGenerated]
                public ew E()
                {
                    return this.b;
                }

                [CompilerGenerated]
                private void D(ew A_0)
                {
                    this.b = A_0;
                }

                [CompilerGenerated]
                public float F()
                {
                    return this.c;
                }

                [CompilerGenerated]
                private void D(float A_0)
                {
                    this.c = A_0;
                }

                public aa(string A_0, ew A_1, float A_2)
                {
                    this.D(A_0);
                    this.D(A_1);
                    this.D(A_2);
                }
            }

            [CompilerGenerated]
            private string a;

            [CompilerGenerated]
            private int b;

            [CompilerGenerated]
            private string c;

            [CompilerGenerated]
            private int d;

            [CompilerGenerated]
            private float e;

            [CompilerGenerated]
            private float f;

            [CompilerGenerated]
            private bool g;

            [CompilerGenerated]
            private float h;

            [CompilerGenerated]
            private string i;

            [CompilerGenerated]
            private string j;

            [CompilerGenerated]
            private float k;

            [CompilerGenerated]
            private float l;

            [CompilerGenerated]
            private int m;

            [CompilerGenerated]
            private float n;

            [CompilerGenerated]
            private float[] o;

            [CompilerGenerated]
            private ald p;

            [CompilerGenerated]
            private hv.bb.aa[] q;

            [CompilerGenerated]
            private int r;

            [CompilerGenerated]
            private bool s;

            [CompilerGenerated]
            private hv.aa[] t;

            [CompilerGenerated]
            private GuildRole? u;

            [CompilerGenerated]
            private ew v;

            [CompilerGenerated]
            private float w;

            public bb(string A_0, int A_1, string A_2, int A_3, float A_4, float A_5, bool A_6, float A_7, string A_8, string A_9, float A_10, float A_11, hv.aa[] A_12, int A_13, hv.bb.aa[] A_14, bool A_15, GuildRole? A_16, ew A_17, float A_18)
            {
                this.Af(string.Concat(new object[]
                {
                "T",
                A_1,
                "_",
                A_0
                }));
                this.Ae(A_1);
                this.Ae(A_2);
                this.Ad(A_3);
                this.Ai(A_4);
                this.Ah(A_5);
                this.Ad(A_6);
                this.Ag(A_7);
                this.Ad(A_8);
                this.Ac(A_9);
                this.Af(A_10);
                this.Ae(A_11);
                this.Ac(A_12);
                this.Ac(A_13);
                this.Ac(A_14);
                this.Af((float)-1);
                this.Ac(A_15);
                this.Ad(0f);
                this.Ac(ald.h);
                this.Ac(new float[this.A0().Length]);
                for (int i = 0; i < this.A0().Length; i++)
                {
                    if (!this.Aq() && !this.Az() && i < this.A0().Length - 1)
                    {
                        this.Ac(ald.N(this.Au(), ald.L((double)(this.Ah() * ((A_12[i].G() + A_12[i].H()) / 2f)))));
                    }
                    this.Ad(this.Ass() + A_12[i].F());
                    this.At()[i] = this.Ass();
                }
                if (this.Ah() <= 0f)
                {
                    this.Ac(ald.f);
                }
                this.Ac(A_16);
                this.Ac(A_17);
                this.Ac(A_18);
            }

            [CompilerGenerated]
            public string Ac()
            {
                return this.a;
            }

            [CompilerGenerated]
            private void Af(string A_0)
            {
                this.a = A_0;
            }

            [CompilerGenerated]
            public int Ad()
            {
                return this.b;
            }

            [CompilerGenerated]
            private void Ae(int A_0)
            {
                this.b = A_0;
            }

            [CompilerGenerated]
            public string Ae()
            {
                return this.c;
            }

            [CompilerGenerated]
            private void Ae(string A_0)
            {
                this.c = A_0;
            }

            public bool Af()
            {
                return this.Ae() == "SILVERCOINS";
            }

            [CompilerGenerated]
            public int Ag()
            {
                return this.d;
            }

            [CompilerGenerated]
            private void Ad(int A_0)
            {
                this.d = A_0;
            }

            [CompilerGenerated]
            public float Ah()
            {
                return this.e;
            }

            [CompilerGenerated]
            private void Ai(float A_0)
            {
                this.e = A_0;
            }

            [CompilerGenerated]
            public float Ai()
            {
                return this.f;
            }

            [CompilerGenerated]
            private void Ah(float A_0)
            {
                this.f = A_0;
            }

            [CompilerGenerated]
            public bool Aj()
            {
                return this.g;
            }

            [CompilerGenerated]
            private void Ad(bool A_0)
            {
                this.g = A_0;
            }

            [CompilerGenerated]
            public float Ak()
            {
                return this.h;
            }

            [CompilerGenerated]
            private void Ag(float A_0)
            {
                this.h = A_0;
            }

            public int Al()
            {
                return this.A0().Length - 1;
            }

            [CompilerGenerated]
            public string Am()
            {
                return this.i;
            }

            [CompilerGenerated]
            private void Ad(string A_0)
            {
                this.i = A_0;
            }

            [CompilerGenerated]
            public string An()
            {
                return this.j;
            }

            [CompilerGenerated]
            private void Ac(string A_0)
            {
                this.j = A_0;
            }

            [CompilerGenerated]
            public float Ao()
            {
                return this.k;
            }

            [CompilerGenerated]
            private void Af(float A_0)
            {
                this.k = A_0;
            }

            [CompilerGenerated]
            public float Ap()
            {
                return this.l;
            }

            [CompilerGenerated]
            private void Ae(float A_0)
            {
                this.l = A_0;
            }

            public bool Aq()
            {
                return this.Ao() > 0f;
            }

            [CompilerGenerated]
            public int Ar()
            {
                return this.m;
            }

            [CompilerGenerated]
            private void Ac(int A_0)
            {
                this.m = A_0;
            }

            [CompilerGenerated]
            public float Ass()
            {
                return this.n;
            }

            [CompilerGenerated]
            private void Ad(float A_0)
            {
                this.n = A_0;
            }

            [CompilerGenerated]
            public float[] At()
            {
                return this.o;
            }

            [CompilerGenerated]
            private void Ac(float[] A_0)
            {
                this.o = A_0;
            }

            [CompilerGenerated]
            public ald Au()
            {
                return this.p;
            }

            [CompilerGenerated]
            private void Ac(ald A_0)
            {
                this.p = A_0;
            }

            [CompilerGenerated]
            public hv.bb.aa[] Av()
            {
                return this.q;
            }

            [CompilerGenerated]
            private void Ac(hv.bb.aa[] A_0)
            {
                this.q = A_0;
            }

            public int Aw()
            {
                return this.Av().Length;
            }

            [CompilerGenerated]
            public int Ax()
            {
                return this.r;
            }

            [CompilerGenerated]
            public void Af(int A_0)
            {
                this.r = A_0;
            }

            [CompilerGenerated]
            public bool Ay()
            {
                return this.s;
            }

            [CompilerGenerated]
            private void Ac(bool A_0)
            {
                this.s = A_0;
            }

            public bool Az()
            {
                return this.Aq() || !string.IsNullOrEmpty(this.Am());
            }

            [CompilerGenerated]
            public hv.aa[] A0()
            {
                return this.t;
            }

            [CompilerGenerated]
            private void Ac(hv.aa[] A_0)
            {
                this.t = A_0;
            }

            [CompilerGenerated]
            public GuildRole? A1()
            {
                return this.u;
            }

            [CompilerGenerated]
            private void Ac(GuildRole? A_0)
            {
                this.u = A_0;
            }

            [CompilerGenerated]
            public ew A2()
            {
                return this.v;
            }

            [CompilerGenerated]
            private void Ac(ew A_0)
            {
                this.v = A_0;
            }

            [CompilerGenerated]
            public float A3()
            {
                return this.w;
            }

            [CompilerGenerated]
            private void Ac(float A_0)
            {
                this.w = A_0;
            }
        }

        private Hashtable a = new Hashtable();

        private static int b;

        [CompilerGenerated]
        private string c;

        [CompilerGenerated]
        private string d;

        [CompilerGenerated]
        private int e;

        [CompilerGenerated]
        private hv.bb[] f;

        [CompilerGenerated]
        public string F()
        {
            return this.c;
        }

        [CompilerGenerated]
        private void F(string A_0)
        {
            this.c = A_0;
        }

        [CompilerGenerated]
        public string G()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void E(string A_0)
        {
            this.d = A_0;
        }

        [CompilerGenerated]
        public int H()
        {
            return this.e;
        }

        [CompilerGenerated]
        private void E(int A_0)
        {
            this.e = A_0;
        }

        [CompilerGenerated]
        public hv.bb[] I()
        {
            return this.f;
        }

        [CompilerGenerated]
        private void E(hv.bb[] A_0)
        {
            this.f = A_0;
        }

        public static void E()
        {
            hv.b = 0;
        }

        public hv(string A_0, string A_1)
        {
            this.E(hv.b++);
            this.F(A_0);
            this.E(A_1);
            this.E(new hv.bb[8]);
        }

        public bool E(int A_0, int A_1, int A_2)
        {
            return A_0 >= 1 && A_0 <= this.I().Length && this.I()[A_0 - 1] != null && (!this.I()[A_0 - 1].Aj() || ((A_1 >= A_0 || (A_1 + 1 >= A_0 && A_2 == 0)) && this.G(A_0, A_1) >= 0f));
        }

        public long E(int A_0, int A_1)
        {
            hv.bb b = this.I()[A_0];
            if (A_1 >= b.A0().Length)
            {
                return 0L;
            }
            int num = Math.Min(A_1, b.Ag());
            int num2 = A_1 - num;
            long num3 = 0L;
            for (int i = A_1; i > num2; i--)
            {
                num3 += (long)b.A0()[i].F();
            }
            return num3;
        }

        public long F(int A_0, int A_1)
        {
            hv.bb b = this.I()[A_0];
            if (A_1 >= b.A0().Length)
            {
                return 0L;
            }
            long num = 0L;
            for (int i = A_1; i > 0; i--)
            {
                num += (long)b.A0()[i].F();
            }
            return num;
        }

        public float G(int A_0, int A_1)
        {
            if (A_0 < 1 || A_0 > this.I().Length || this.I()[A_0 - 1] == null)
            {
                return -1f;
            }
            float num;
            if (A_1 == 0)
            {
                if (this.I()[A_0 - 1].Aj())
                {
                    return -1f;
                }
                num = this.I()[A_0 - 1].Ak();
            }
            else
            {
                int num2 = A_1 - A_0;
                if (!this.a.ContainsKey(num2))
                {
                    return -1f;
                }
                num = (float)this.a[num2];
            }
            return this.I()[A_0 - 1].Ai() * num;
        }

        private static ew E(XmlElement A_0, out float A_1)
        {
            ew ew = null;
            A_1 = 0f;
            XmlNodeList elementsByTagName = A_0.GetElementsByTagName("Loot");
            if (elementsByTagName.Count > 0)
            {
                XmlElement xmlElement = elementsByTagName[0] as XmlElement;
                if (xmlElement != null)
                {
                    ew = new ew();
                    ew.da(xmlElement);
                    A_1 = al5.A(xmlElement, "itemdropquality", A_1);
                }
            }
            return ew;
        }

        public void E(XmlElement A_0)
        {
            foreach (XmlElement xmlElement in A_0.GetElementsByTagName("ToolModifier"))
            {
                foreach (XmlElement a_ in xmlElement.GetElementsByTagName("Modifier"))
                {
                    this.a.Add(al5.B(a_, "tierdifference", 0), al5.A(a_, "timefactor", 1f));
                }
            }
            foreach (XmlElement xmlElement2 in A_0.GetElementsByTagName("Tier"))
            {
                int num = al5.B(xmlElement2, "tier", 0);
                XmlNodeList elementsByTagName = xmlElement2.GetElementsByTagName("Charge");
                List<hv.aa> list = new List<hv.aa>(elementsByTagName.Count);
                foreach (XmlElement a_2 in elementsByTagName)
                {
                    string text = al5.A(a_2, "level", "0");
                    int num2;
                    int num3;
                    if (text.Contains("-"))
                    {
                        string[] array = text.Split(new char[]
                        {
                        '-'
                        }, StringSplitOptions.RemoveEmptyEntries);
                        num2 = int.Parse(array[0], CultureInfo.InvariantCulture.NumberFormat);
                        num3 = int.Parse(array[1], CultureInfo.InvariantCulture.NumberFormat);
                    }
                    else
                    {
                        num3 = (num2 = int.Parse(text, CultureInfo.InvariantCulture.NumberFormat));
                    }
                    while (list.Count < num3 + 1)
                    {
                        list.Add(null);
                    }
                    hv.aa value = new hv.aa(al5.A(a_2, "yield", 0f), al5.A(a_2, "respawnfactormin", 1f), al5.A(a_2, "respawnfactormax", 1f), al5.B(a_2, "gfxstate", 0), al5.B(a_2, "respawncharges", 1));
                    for (int i = num2; i <= num3; i++)
                    {
                        list[i] = value;
                    }
                }
                XmlNodeList elementsByTagName2 = xmlElement2.GetElementsByTagName("RareState");
                List<hv.bb.aa> list2 = new List<hv.bb.aa>(elementsByTagName2.Count);
                foreach (XmlElement xmlElement3 in elementsByTagName2)
                {
                    if (xmlElement3 != null)
                    {
                        al5.B(xmlElement3, "state", -2147483648);
                        string a_3 = al5.A(xmlElement3, "item", null);
                        float a_5;
                        ew a_4 = hv.E(xmlElement3, out a_5);
                        list2.Add(new hv.bb.aa(a_3, a_4, a_5));
                    }
                }
                float a_7;
                ew a_6 = hv.E(xmlElement2, out a_7);
                GuildRole? a_8;
                try
                {
                    string value2 = al5.A(xmlElement2, "territoryrankcontraint", "");
                    if (string.IsNullOrEmpty(value2))
                    {
                        a_8 = null;
                    }
                    else
                    {
                        a_8 = new GuildRole?((GuildRole)Enum.Parse(typeof(GuildRole), value2, true));
                    }
                }
                catch (Exception)
                {
                    a_8 = null;
                }
                string text2 = al5.A(xmlElement2, "tile", null);
                string a_9 = al5.A(xmlElement2, "tilepremium", text2);
                hv.bb b = new hv.bb(this.F(), num, al5.A(xmlElement2, "item", "T1_ROCK"), al5.B(xmlElement2, "maxchargesperharvest", 1), al5.A(xmlElement2, "respawntimeseconds", 30f), al5.A(xmlElement2, "harvesttimeseconds", 30f), al5.A(xmlElement2, "requirestool", true), al5.A(xmlElement2, "notooltimefactor", 1f), text2, a_9, al5.A(xmlElement2, "decaytimeseconds", 0f), al5.A(xmlElement2, "decaytimewhenexhaustedseconds", 0f), list.ToArray(), al5.B(xmlElement2, "startcharges", 1), list2.ToArray(), al5.A(xmlElement2, "isscaled", true), a_8, a_6, a_7);
                this.I()[num - 1] = b;
            }
        }
    }
}