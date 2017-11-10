using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class e7 : by, dq
    {
        public new abstract class a
        {
            public abstract bool dh(XmlElement A_0);
        }

        public new class b : e7.a
        {
            [CompilerGenerated]
            private oe a;

            [CompilerGenerated]
            private int b;

            [CompilerGenerated]
            public oe O()
            {
                return this.a;
            }

            [CompilerGenerated]
            private void O(oe A_0)
            {
                this.a = A_0;
            }

            [CompilerGenerated]
            public int P()
            {
                return this.b;
            }

            [CompilerGenerated]
            private void O(int A_0)
            {
                this.b = A_0;
            }

            public override bool Dh(XmlElement A_0)
            {
                this.O(al5.C(A_0, "repaircostfactor", oe.h));
                this.O(al5.B(A_0, "maxtier", 2147483647));
                return true;
            }
        }

        public new class c : e7.a
        {
            [CompilerGenerated]
            private int c;

            [CompilerGenerated]
            private float d;

            [CompilerGenerated]
            private string[] e;

            [CompilerGenerated]
            public int o()
            {
                return this.c;
            }

            [CompilerGenerated]
            private void o(int A_0)
            {
                this.c = A_0;
            }

            [CompilerGenerated]
            public float p()
            {
                return this.d;
            }

            [CompilerGenerated]
            private void o(float A_0)
            {
                this.d = A_0;
            }

            public bool q()
            {
                return this.r().Length == 0;
            }

            [CompilerGenerated]
            public string[] r()
            {
                return this.e;
            }

            [CompilerGenerated]
            private void o(string[] A_0)
            {
                this.e = A_0;
            }

            public override bool dh(XmlElement A_0)
            {
                this.o(al5.b(A_0, "capacity", 10));
                this.o(al5.a(A_0, "weightlimit", float.NaN));
                XmlNodeList elementsByTagName = A_0.GetElementsByTagName("alloweditem");
                this.o(new string[elementsByTagName.Count]);
                for (int i = 0; i < elementsByTagName.Count; i++)
                {
                    XmlElement a_ = (XmlElement)elementsByTagName[i];
                    this.r()[i] = al5.h(a_, "name");
                }
                return true;
            }
        }

        public new class d : e7.a
        {
            [CompilerGenerated]
            private string g;

            [CompilerGenerated]
            private float h;

            [CompilerGenerated]
            private int i;

            [CompilerGenerated]
            private ald j;

            [CompilerGenerated]
            private string k;

            [CompilerGenerated]
            private string l;

            [CompilerGenerated]
            private string m;

            [CompilerGenerated]
            private int[] n;

            [CompilerGenerated]
            public string o()
            {
                return this.g;
            }

            [CompilerGenerated]
            private void r(string A_0)
            {
                this.g = A_0;
            }

            [CompilerGenerated]
            public float p()
            {
                return this.h;
            }

            [CompilerGenerated]
            private void o(float A_0)
            {
                this.h = A_0;
            }

            [CompilerGenerated]
            public int q()
            {
                return this.i;
            }

            [CompilerGenerated]
            private void o(int A_0)
            {
                this.i = A_0;
            }

            [CompilerGenerated]
            public ald r()
            {
                return this.j;
            }

            [CompilerGenerated]
            private void o(ald A_0)
            {
                this.j = A_0;
            }

            [CompilerGenerated]
            public string s()
            {
                return this.k;
            }

            [CompilerGenerated]
            private void q(string A_0)
            {
                this.k = A_0;
            }

            [CompilerGenerated]
            public string t()
            {
                return this.l;
            }

            [CompilerGenerated]
            private void p(string A_0)
            {
                this.l = A_0;
            }

            [CompilerGenerated]
            public string u()
            {
                return this.m;
            }

            [CompilerGenerated]
            private void o(string A_0)
            {
                this.m = A_0;
            }

            [CompilerGenerated]
            public int[] v()
            {
                return this.n;
            }

            [CompilerGenerated]
            private void o(int[] A_0)
            {
                this.n = A_0;
            }

            public override bool dh(XmlElement A_0)
            {
                this.o(al5.b(A_0, "charges", 1));
                this.o(ald.l((double)al5.a(A_0, "rechargetimeseconds", 60f)));
                this.r(al5.h(A_0, "buffspell"));
                this.o(al5.a(A_0, "abilitypower", 100f));
                this.q(al5.h(A_0, "usebuttontext"));
                this.p(al5.h(A_0, "nextchargereadytext"));
                this.o(al5.h(A_0, "chargesreadytext"));
                List<int> list = new List<int>();
                foreach (XmlElement a_ in A_0.GetElementsByTagName("Charge"))
                {
                    string text = al5.a(a_, "level", "0");
                    int num;
                    int num2;
                    if (text.Contains("-"))
                    {
                        string[] array = text.Split(new char[]
                        {
                        '-'
                        }, StringSplitOptions.RemoveEmptyEntries);
                        num = int.Parse(array[0], CultureInfo.InvariantCulture.NumberFormat);
                        num2 = int.Parse(array[1], CultureInfo.InvariantCulture.NumberFormat);
                    }
                    else
                    {
                        num2 = (num = int.Parse(text, CultureInfo.InvariantCulture.NumberFormat));
                    }
                    while (list.Count < num2 + 1)
                    {
                        list.Add(0);
                    }
                    int value = al5.b(a_, "gfxstate", 0);
                    for (int i = num; i <= num2; i++)
                    {
                        list[i] = value;
                    }
                }
                this.o(list.ToArray());
                return true;
            }
        }

        public new class e : e7.a
        {
            public override bool dh(XmlElement A_0)
            {
                return true;
            }
        }

        private static string cu = "default";

        [CompilerGenerated]
        private aej.Placeability cv;

        [CompilerGenerated]
        private bool cw;

        [CompilerGenerated]
        private oe cx;

        [CompilerGenerated]
        private oe cy;

        [CompilerGenerated]
        private List<aeh> cz;

        [CompilerGenerated]
        private bool c0;

        [CompilerGenerated]
        private int dp;

        [CompilerGenerated]
        private string dq;

        [CompilerGenerated]
        private co.FurnitureType dr;

        [CompilerGenerated]
        private co.LaborerType ds;

        [CompilerGenerated]
        private int dt;

        [CompilerGenerated]
        private oe du;

        [CompilerGenerated]
        private Preset dv;

        [CompilerGenerated]
        private string dw;

        [CompilerGenerated]
        private e7.a dx;

        [CompilerGenerated]
        public aej.Placeability d1()
        {
            return this.cv;
        }

        [CompilerGenerated]
        private void a(aej.Placeability A_0)
        {
            this.cv = A_0;
        }

        [CompilerGenerated]
        public bool C2()
        {
            return this.cw;
        }

        [CompilerGenerated]
        private void b(bool A_0)
        {
            this.cw = A_0;
        }

        [CompilerGenerated]
        public oe d2()
        {
            return this.cx;
        }

        [CompilerGenerated]
        private void df(oe A_0)
        {
            this.cx = A_0;
        }

        [CompilerGenerated]
        public oe d3()
        {
            return this.cy;
        }

        [CompilerGenerated]
        private void b(oe A_0)
        {
            this.cy = A_0;
        }

        [CompilerGenerated]
        public List<aeh> d4()
        {
            return this.cz;
        }

        [CompilerGenerated]
        private void a(List<aeh> A_0)
        {
            this.cz = A_0;
        }

        [CompilerGenerated]
        public bool d5()
        {
            return this.c0;
        }

        [CompilerGenerated]
        private void a(bool A_0)
        {
            this.c0 = A_0;
        }

        [CompilerGenerated]
        public int d6()
        {
            return this.dp;
        }

        [CompilerGenerated]
        private void b(int A_0)
        {
            this.dp = A_0;
        }

        [CompilerGenerated]
        public string C1()
        {
            return this.dq;
        }

        [CompilerGenerated]
        private void b(string A_0)
        {
            this.dq = A_0;
        }

        [CompilerGenerated]
        public co.FurnitureType d7()
        {
            return this.dr;
        }

        [CompilerGenerated]
        private void a(co.FurnitureType A_0)
        {
            this.dr = A_0;
        }

        [CompilerGenerated]
        public co.LaborerType d8()
        {
            return this.ds;
        }

        [CompilerGenerated]
        private void a(co.LaborerType A_0)
        {
            this.ds = A_0;
        }

        [CompilerGenerated]
        public int d9()
        {
            return this.dt;
        }

        [CompilerGenerated]
        private void a(int A_0)
        {
            this.dt = A_0;
        }

        [CompilerGenerated]
        public oe ea()
        {
            return this.du;
        }

        [CompilerGenerated]
        private void a(oe A_0)
        {
            this.du = A_0;
        }

        [CompilerGenerated]
        public Preset eb()
        {
            return this.dv;
        }

        [CompilerGenerated]
        private void a(Preset A_0)
        {
            this.dv = A_0;
        }

        [CompilerGenerated]
        public string ec()
        {
            return this.dw;
        }

        [CompilerGenerated]
        private void a(string A_0)
        {
            this.dw = A_0;
        }

        [CompilerGenerated]
        public e7.a ed()
        {
            return this.dx;
        }

        [CompilerGenerated]
        private void a(e7.a A_0)
        {
            this.dx = A_0;
        }

        public e7.c ee()
        {
            return this.ed() as e7.c;
        }

        public e7.d ef()
        {
            return this.ed() as e7.d;
        }

        public e7.b eg()
        {
            return this.ed() as e7.b;
        }

        public e7.e eh()
        {
            return this.ed() as e7.e;
        }

        public e7(cu A_0) : base(A_0)
        {
            this.b(0);
            this.df(oe.g);
            this.b(oe.h);
            this.b(e7.cu);
            this.a(co.FurnitureType.None);
            this.a(co.LaborerType.None);
            this.a(1);
            this.a(oe.g);
            this.a(Preset.Closed);
            this.a(false);
            this.a(aej.Placeability.Nowhere);
        }

        public override bool b4(XmlElement A_0)
        {
            base.b4(A_0);
            this.a(al5.a(A_0, "tile", base.d));
            this.b(al5.b(A_0, "residencyslots", this.d6()));
            this.df(al5.c(A_0, "durabilitylossperdayfactor", this.d2()));
            this.b(al5.c(A_0, "durabilitylossperusefactor", this.d3()));
            this.b(al5.a(A_0, "animationid", this.C1()));
            this.a(al5.a<co.FurnitureType>(A_0, "labourerfurnituretype", this.d7()));
            this.a(al5.a<co.LaborerType>(A_0, "labourersaffected", this.d8()));
            this.a(al5.b(A_0, "labourersperfurnitureitem", this.d9()));
            this.a(al5.c(A_0, "labourerhappiness", this.ea()));
            this.a(al5.a<Preset>(A_0, "accessrightspreset", this.eb()));
            this.a(al5.a(A_0, "customizewithguildlogo", this.d5()));
            bool flag = al5.a(A_0, "placeableindoors", (byte)(this.d1() & aej.Placeability.Indoor) != 0);
            bool flag2 = al5.a(A_0, "placeableoutdoors", (byte)(this.d1() & aej.Placeability.Outdoor) != 0);
            bool flag3 = al5.a(A_0, "placeableindungeons", (byte)(this.d1() & aej.Placeability.Dungeons) != 0);
            this.b(al5.a(A_0, "placeableonlyonislands", false));
            this.a(aej.Placeability.Nowhere);
            if (flag)
            {
                this.a(this.d1() | aej.Placeability.Indoor);
            }
            if (flag2)
            {
                this.a(this.d1() | aej.Placeability.Outdoor);
            }
            if (flag3)
            {
                this.a(this.d1() | aej.Placeability.Dungeons);
            }
            List<XmlElement> list = al5.d(A_0, "container");
            if (list != null && list.Count > 0)
            {
                foreach (XmlElement current in list)
                {
                    XmlElement xmlElement = current;
                    if (xmlElement != null)
                    {
                        this.a(new e7.c());
                        this.ed().dh(xmlElement);
                    }
                }
            }
            List<XmlElement> list2 = al5.d(A_0, "buffprovider");
            if (list2 != null && list2.Count > 0)
            {
                foreach (XmlElement current2 in list2)
                {
                    XmlElement xmlElement2 = current2;
                    if (xmlElement2 != null)
                    {
                        this.a(new e7.d());
                        this.ed().dh(xmlElement2);
                    }
                }
            }
            List<XmlElement> list3 = al5.d(A_0, "repairkit");
            if (list3 != null && list3.Count > 0)
            {
                foreach (XmlElement current3 in list3)
                {
                    XmlElement xmlElement3 = current3;
                    if (xmlElement3 != null)
                    {
                        this.a(new e7.b());
                        this.ed().dh(xmlElement3);
                    }
                }
            }
            List<XmlElement> list4 = al5.d(A_0, "cheatprovider");
            if (list4 != null && list4.Count > 0)
            {
                foreach (XmlElement current4 in list4)
                {
                    XmlElement xmlElement4 = current4;
                    if (xmlElement4 != null)
                    {
                        this.a(new e7.e());
                        this.ed().dh(xmlElement4);
                    }
                }
            }
            return true;
        }

        public override void b5(hn A_0)
        {
            base.b5(A_0);
            base.d2(oe.o(base.fs(), A_0.@as().jo().n(base.f)));
            this.df(oe.o(this.d2(), A_0.@as().jo().u(base.f)));
            this.b(oe.o(this.d3(), A_0.@as().jo().v(base.f)));
            base.a(A_0);
        }

        public aej.Placeability C3()
        {
            return this.d1();
        }

        public bool C4()
        {
            return true;
        }

        public string C5()
        {
            return base.d;
        }

        public oe C6()
        {
            return oe.g;
        }
    }
}