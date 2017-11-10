using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public abstract class bx
    {
        protected static int c = 0;

        protected static string d = "descvariable";

        protected static int e = bx.d.Length;

        protected static string[] f = new string[0];

        [CompilerGenerated]
        private int g;

        [CompilerGenerated]
        private string h;

        [CompilerGenerated]
        private int i;

        [CompilerGenerated]
        private float j;

        [CompilerGenerated]
        private int k;

        [CompilerGenerated]
        private cu l;

        [CompilerGenerated]
        private aeg m;

        [CompilerGenerated]
        private aeg[] n;

        [CompilerGenerated]
        private b1 o;

        [CompilerGenerated]
        private bool p;

        [CompilerGenerated]
        private short q;

        [CompilerGenerated]
        private string r;

        [CompilerGenerated]
        private string s;

        [CompilerGenerated]
        private string t;

        [CompilerGenerated]
        private string u;

        [CompilerGenerated]
        private string v;

        [CompilerGenerated]
        private string w;

        [CompilerGenerated]
        private oe x;

        [CompilerGenerated]
        private oe y;

        [CompilerGenerated]
        private oe z;

        [CompilerGenerated]
        private oe aa;

        [CompilerGenerated]
        private oe ab;

        [CompilerGenerated]
        private string ac;

        [CompilerGenerated]
        private bool ad;

        [CompilerGenerated]
        private bool ae;

        [CompilerGenerated]
        private oe af;

        [CompilerGenerated]
        private oe ag;

        [CompilerGenerated]
        private oe ah;

        [CompilerGenerated]
        private string ai;

        [CompilerGenerated]
        private string aj;

        [CompilerGenerated]
        private ch ak;

        [CompilerGenerated]
        private ci al;

        [CompilerGenerated]
        private string am;

        [CompilerGenerated]
        private string an;

        [CompilerGenerated]
        private string ao;

        [CompilerGenerated]
        private List<string> ap;

        [CompilerGenerated]
        private string[] aq;

        public int C
        {
            get;
            protected set;
        }

        public string D
        {
            get;
            protected set;
        }

        public string E
        {
            get
            {
                return n8.A(this.Am, this.Gz());
            }
        }

        public int F
        {
            get;
            private set;
        }

        public float G
        {
            get;
            private set;
        }

        public int H
        {
            get;
            private set;
        }

        public cu I
        {
            get;
            protected set;
        }

        public string J
        {
            get
            {
                return this.I.D();
            }
        }

        public aeg K
        {
            get;
            private set;
        }

        public aeg[] L
        {
            get;
            private set;
        }

        public b1 M
        {
            get;
            private set;
        }

        public bool N
        {
            get;
            protected set;
        }

        public short O
        {
            get;
            protected set;
        }

        public string P
        {
            get;
            private set;
        }

        public string Q
        {
            get;
            private set;
        }

        public string R
        {
            get;
            private set;
        }

        public string S
        {
            get;
            private set;
        }

        public string T
        {
            get;
            private set;
        }

        public string U
        {
            get;
            private set;
        }

        public oe V
        {
            get;
            protected set;
        }

        public oe W
        {
            get;
            protected set;
        }

        public oe X
        {
            get;
            protected set;
        }

        public oe Y
        {
            get;
            protected set;
        }

        public oe Z
        {
            get;
            private set;
        }

        public string Aa
        {
            get;
            private set;
        }

        public bool Ab
        {
            get;
            protected set;
        }

        public bool Ac
        {
            get;
            protected set;
        }

        public oe Ad
        {
            get;
            private set;
        }

        public oe Ae
        {
            get;
            private set;
        }

        public oe Af
        {
            get;
            private set;
        }

        public string Ag
        {
            get
            {
                return n8.A(this.An, this.Gz());
            }
        }

        public string Ah
        {
            get;
            private set;
        }

        public string Ai
        {
            get;
            protected set;
        }

        public ch Aj
        {
            get;
            protected set;
        }

        public ci Ak
        {
            get;
            private set;
        }

        public string Al
        {
            get;
            protected set;
        }

        protected string Am
        {
            get;
            set;
        }

        protected string An
        {
            get;
            set;
        }

        protected List<string> Ao
        {
            get;
            set;
        }

        protected string[] Ap
        {
            get;
            set;
        }

        public bx(cu A_0)
        {
            this.C = -2147483648;
            this.I = A_0;
            this.V = oe.j;
            this.W = oe.j;
            this.Af = oe.j;
            this.X = oe.j;
            this.Y = oe.j;
            this.N = false;
            this.O = 999;
            this.Z = oe.g;
            this.Aa = string.Empty;
            this.Ac = false;
            this.Ad = oe.h;
            this.Ae = oe.h;
            this.Ah = null;
            this.Ai = null;
            this.Ao = null;
            this.Ab = true;
            this.Al = string.Empty;
        }

        public virtual bx Df()
        {
            bx bx = (bx)base.MemberwiseClone();
            bx.c = bx.c++;
            return bx;
        }

        public static void D1()
        {
            bx.c = 0;
        }

        public bool D3(XmlElement A_0)
        {
            if (this.C < 0)
            {
                this.C = bx.c++;
            }
            return this.Dg(A_0) && this.B4(A_0);
        }

        protected virtual bool Dg(XmlElement A_0)
        {
            this.Am = bx.B(this.J);
            this.An = bx.A(this.J);
            this.F = al5.B(A_0, "tier", 1);
            this.U = al5.H(A_0, "resourcetype");
            this.P = al5.H(A_0, "shopcategory");
            this.Q = al5.H(A_0, "shopsubcategory1");
            this.R = al5.H(A_0, "shopsubcategory2");
            this.S = al5.A(A_0, "uicraftsoundstart", string.Empty);
            this.T = al5.A(A_0, "uicraftsoundfinish", string.Empty);
            return true;
        }

        public virtual bool B4(XmlElement A_0)
        {
            this.H = al5.B(A_0, "enchantmentlevel", this.H);
            this.D = cu.D(this.I, this.H);
            this.Am = al5.A(A_0, "namelocatag", this.Am);
            this.An = al5.A(A_0, "descriptionlocatag", this.An);
            this.D4(A_0);
            this.O = (short)al5.B(A_0, "maxstacksize", (int)this.O);
            this.N = al5.A(A_0, "salvageable", this.N);
            this.G = al5.A(A_0, "weight", this.G);
            this.Z = al5.B(A_0, "nutrition", this.Z);
            this.Aa = al5.A(A_0, "foodcategory", this.Aa);
            this.Ac = al5.A(A_0, "unlockedtocraft", this.Ac);
            this.Ad = al5.C(A_0, "gatherfamegainfactor", this.Ad);
            this.Ae = al5.C(A_0, "craftfamegainfactor", this.Ae);
            this.Ab = al5.A(A_0, "showinmarketplace", this.Ab);
            this.Af = al5.C(A_0, "famevalue", this.Af);
            this.V = al5.C(A_0, "resourcevalue", this.V);
            this.W = al5.C(A_0, "itemvalue", this.W);
            this.Ah = al5.A(A_0, "uiatlas", this.Ah);
            if (this.Ai == null)
            {
                if (this.J[0] == 'T' && this.J[2] == '_')
                {
                    this.Ai = this.J.Substring(3);
                }
                else
                {
                    this.Ai = this.J;
                }
            }
            this.Ai = al5.A(A_0, "uisprite", this.Ai);
            this.B(A_0);
            this.A(A_0);
            string text = ch.H(A_0);
            if (!string.IsNullOrEmpty(text))
            {
                this.Al = text;
            }
            return this.H >= 0 && this.H <= 3;
        }

        private void B(XmlElement A_0)
        {
            List<XmlElement> list = al5.D(A_0, "craftingrequirements");
            if (list != null && list.Count > 0)
            {
                List<aeg> list2 = new List<aeg>();
                foreach (XmlElement current in list)
                {
                    XmlElement a_ = current;
                    aeg aeg = new aeg();
                    aeg.L(a_);
                    list2.Add(aeg);
                }
                this.L = list2.ToArray();
                if (this.L.Length > 0)
                {
                    this.K = this.L[0];
                }
            }
            if (this.L == null)
            {
                this.L = new aeg[0];
            }
        }

        private void A(XmlElement A_0)
        {
            List<XmlElement> list = al5.D(A_0, "upgraderequirements");
            if (list != null && list.Count > 0)
            {
                this.M = new b1();
                this.M.F(list[0]);
            }
        }

        public virtual ItemContainerErrorCode B3(bz A_0, bz A_1)
        {
            if (A_0 == null || A_1 == null || A_0.E() == null || A_1.E() == null)
            {
                return ItemContainerErrorCode.InternalError;
            }
            if (A_0.E().i != A_1.E().i)
            {
                return ItemContainerErrorCode.MergeItemGroupMismatch;
            }
            if (A_0.E().C != A_1.E().C)
            {
                return ItemContainerErrorCode.MergeEnchantmentLevelMismatch;
            }
            return ItemContainerErrorCode.Ok;
        }

        public string Gw()
        {
            return this.Am;
        }

        public string Gx()
        {
            return this.An;
        }

        public List<string> Gy()
        {
            return this.Ao;
        }

        protected void D4(XmlElement A_0)
        {
            this.Ap = bx.f;
            for (int i = 0; i < A_0.Attributes.Count; i++)
            {
                XmlAttribute xmlAttribute = A_0.Attributes[i];
                if (xmlAttribute.Name.StartsWith("descvariable"))
                {
                    int num = -1;
                    string text = xmlAttribute.Name.Substring(bx.e);
                    if (int.TryParse(text, out num) && num >= 0)
                    {
                        if (this.Ao == null)
                        {
                            this.Ao = new List<string>();
                        }
                        while (this.Ao.Count <= num)
                        {
                            this.Ao.Add(string.Empty);
                        }
                        this.Ao[num] = xmlAttribute.Value;
                    }
                }
            }
            if (this.Ao != null)
            {
                this.Ao.TrimExcess();
                this.Ap = new string[this.Ao.Count];
                for (int j = 0; j < this.Ap.Length; j++)
                {
                    this.Ap[j] = string.Empty;
                }
            }
        }

        protected static string B(string A_0)
        {
            return "@ITEMS_" + A_0;
        }

        protected static string A(string A_0)
        {
            return "@ITEMS_" + A_0 + "_DESC";
        }

        public string[] Gz()
        {
            if (this.Ao != null)
            {
                for (int i = 0; i < this.Ao.Count; i++)
                {
                    this.Ap[i] = n8.C(this.Ao[i]);
                }
            }
            return this.Ap;
        }

        public virtual void B5(hn A_0)
        {
            this.V = this.D2(A_0);
            this.W = this.D1(A_0);
            this.Af = this.D3(A_0);
            this.X = this.D4(A_0);
            this.Y = this.D5(A_0);
            this.Aj = ch.H(A_0, this.Al);
            this.Ak = ci.b(A_0, this.Al);
        }

        public oe D1(hn A_0)
        {
            if (oe.M(this.W, oe.j))
            {
                this.W = this.Df(A_0);
            }
            return this.W;
        }

        public oe D2(hn A_0)
        {
            if (oe.M(this.V, oe.j))
            {
                this.V = this.D6(A_0);
            }
            return this.V;
        }

        public oe D3(hn A_0)
        {
            if (oe.M(this.Af, oe.j))
            {
                this.Af = this.D7(A_0);
            }
            return this.Af;
        }

        public oe D4(hn A_0)
        {
            if (oe.M(this.X, oe.j))
            {
                this.X = this.B(A_0).N();
            }
            return this.X;
        }

        public oe D5(hn A_0)
        {
            if (oe.M(this.Y, oe.j))
            {
                this.Y = this.A(A_0).N();
            }
            return this.Y;
        }

        public oe D6(hn A_0)
        {
            if (this.V.l < 0L)
            {
                this.V = this.D6(A_0, new HashSet<string>());
            }
            return this.V;
        }

        private oe D7(hn A_0, HashSet<string> A_1)
        {
            if (this.V.l < 0L)
            {
                this.V = this.D6(A_0, A_1);
            }
            return this.V;
        }

        private oe D6(hn A_0, HashSet<string> A_1)
        {
            hx hx = A_0.Ax().id(this.U);
            if (hx != null)
            {
                return hx.D(this.F);
            }
            oe oe = oe.g;
            if (this.K != null)
            {
                A_1.Add(this.D);
                foreach (aeg.aa current in this.K.P())
                {
                    bx bx = A_0.Ao().Ib(current.a, current.b);
                    if (bx != null)
                    {
                        if (A_1.Contains(bx.d))
                        {
                            throw new Exception("cyclic dependency in craft requirements, current item '" + bx.d + "'");
                        }
                        oe oe2 = oe.E(bx.D7(A_0, A_1), current.c);
                        if (this.K.Q() != 1)
                        {
                            oe2 = oe.N(oe2, oe.F((long)this.K.Q()));
                        }
                        oe = oe.Q(oe, oe2);
                    }
                }
                A_1.Remove(this.D);
            }
            return oe;
        }

        private oe Df(hn A_0)
        {
            if (this.W.l < 0L)
            {
                this.W = this.D4(A_0, new HashSet<string>());
            }
            return this.W;
        }

        private oe D5(hn A_0, HashSet<string> A_1)
        {
            if (this.W.l < 0L)
            {
                this.W = this.D4(A_0, A_1);
            }
            return this.W;
        }

        private oe D4(hn A_0, HashSet<string> A_1)
        {
            hx hx = A_0.Ax().id(this.U);
            if (hx != null)
            {
                oe a_ = this.D6(A_0);
                return A_0.Ass().io(a_);
            }
            oe oe = oe.g;
            if (this.K != null)
            {
                A_1.Add(this.D);
                oe = oe.O(this.K.M(), A_0.Ass().jj());
                foreach (aeg.aa current in this.K.P())
                {
                    bx bx = A_0.Ao().Ib(current.a, current.b);
                    if (bx != null)
                    {
                        if (A_1.Contains(bx.d))
                        {
                            throw new Exception("cyclic dependency in craft requirements, current item '" + bx.d + "'");
                        }
                        oe oe2 = oe.E(bx.D5(A_0, A_1), current.c);
                        if (this.K.Q() != 1)
                        {
                            oe2 = oe.N(oe2, oe.F((long)this.K.Q()));
                        }
                        oe = oe.Q(oe, oe2);
                    }
                }
                A_1.Remove(this.D);
            }
            return oe;
        }

        public oe D7(hn A_0)
        {
            if (this.Af.l < 0L)
            {
                this.Af = this.D2(A_0, new HashSet<string>());
            }
            return this.Af;
        }

        private oe D3(hn A_0, HashSet<string> A_1)
        {
            if (this.Af.l < 0L)
            {
                this.Af = this.D2(A_0, A_1);
            }
            return this.Af;
        }

        private oe D2(hn A_0, HashSet<string> A_1)
        {
            hx hx = A_0.Ax().id(this.U);
            if (hx != null)
            {
                return hx.E(this.F);
            }
            oe oe = oe.g;
            if (this.K != null)
            {
                A_1.Add(this.D);
                foreach (aeg.aa current in this.K.P())
                {
                    bx bx = A_0.Ao().Ib(current.a, current.b);
                    if (bx != null)
                    {
                        if (A_1.Contains(bx.d))
                        {
                            throw new Exception("cyclic dependency in craft requirements, current item '" + bx.d + "'");
                        }
                        oe oe2 = oe.E(bx.D3(A_0, A_1), current.c);
                        if (this.K.Q() != 1)
                        {
                            oe2 = oe.N(oe2, oe.F((long)this.K.Q()));
                        }
                        oe = oe.Q(oe, oe2);
                    }
                }
                A_1.Remove(this.D);
            }
            return oe;
        }

        private oe B(hn A_0)
        {
            if (this.X.l < 0L)
            {
                this.X = this.Df(A_0, new HashSet<string>());
            }
            return this.X;
        }

        private oe D1(hn A_0, HashSet<string> A_1)
        {
            if (this.X.l < 0L)
            {
                this.X = this.Df(A_0, A_1);
            }
            return this.X;
        }

        private oe Df(hn A_0, HashSet<string> A_1)
        {
            hx hx = A_0.Ax().id(this.U);
            if (hx != null)
            {
                oe a_ = this.Df(A_0);
                oe a_2 = A_0.Ass().jo().w(this.F);
                return oe.O(a_, a_2);
            }
            oe oe1 = oe.g;
            if (this.K != null)
            {
                A_1.Add(this.D);
                foreach (aeg.aa current in this.K.P())
                {
                    bx bx = A_0.Ao().Ib(current.a, current.b);
                    if (bx != null)
                    {
                        if (A_1.Contains(bx.d))
                        {
                            throw new Exception("cyclic dependency in craft requirements, current item '" + bx.d + "'");
                        }
                        oe oe2 = oe.E(bx.D1(A_0, A_1), current.c);
                        if (this.K.Q() != 1)
                        {
                            oe2 = oe.N(oe2, oe.F((long)this.K.Q()));
                        }
                        oe1 = oe.Q(oe1, oe2);
                    }
                }
                A_1.Remove(this.D);
            }
            return oe1;
        }

        private oe A(hn A_0)
        {
            if (this.Y.l < 0L)
            {
                this.Y = this.A(A_0, new HashSet<string>());
            }
            return this.Y;
        }

        private oe B(hn A_0, HashSet<string> A_1)
        {
            if (this.Y.l < 0L)
            {
                this.Y = this.A(A_0, A_1);
            }
            return this.Y;
        }

        private oe A(hn A_0, HashSet<string> A_1)
        {
            hx hx = A_0.Ax().id(this.U);
            if (hx != null)
            {
                oe a_ = this.Df(A_0);
                return A_0.Ass().ip(a_);
            }
            oe oe1 = oe.g;
            if (this.K != null)
            {
                A_1.Add(this.D);
                foreach (aeg.aa current in this.K.P())
                {
                    bx bx = A_0.Ao().Ib(current.a, current.b);
                    if (bx != null)
                    {
                        if (A_1.Contains(bx.d))
                        {
                            throw new Exception("cyclic dependency in craft requirements, current item '" + bx.d + "'");
                        }
                        oe oe2 = oe.E(bx.B(A_0, A_1), current.c);
                        if (this.K.Q() != 1)
                        {
                            oe2 = oe.N(oe2, oe.F((long)this.K.Q()));
                        }
                        oe1 = oe.Q(oe1, oe2);
                    }
                }
                A_1.Remove(this.D);
            }
            return oe1;
        }
    }
}