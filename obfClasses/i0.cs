using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class i0
    {
        public class aa : IComparable<i0.aa>
        {
            [CompilerGenerated]
            private int a;

            [CompilerGenerated]
            private string b;

            [CompilerGenerated]
            private afm c;

            [CompilerGenerated]
            private afm d;

            [CompilerGenerated]
            private bool e;

            [CompilerGenerated]
            private float f;

            [CompilerGenerated]
            public int G()
            {
                return this.a;
            }

            [CompilerGenerated]
            private void G(int A_0)
            {
                this.a = A_0;
            }

            [CompilerGenerated]
            public string H()
            {
                return this.b;
            }

            [CompilerGenerated]
            private void G(string A_0)
            {
                this.b = A_0;
            }

            [CompilerGenerated]
            public afm I()
            {
                return this.c;
            }

            [CompilerGenerated]
            private void H(afm A_0)
            {
                this.c = A_0;
            }

            [CompilerGenerated]
            public afm J()
            {
                return this.d;
            }

            [CompilerGenerated]
            private void G(afm A_0)
            {
                this.d = A_0;
            }

            [CompilerGenerated]
            public bool K()
            {
                return this.e;
            }

            [CompilerGenerated]
            private void G(bool A_0)
            {
                this.e = A_0;
            }

            [CompilerGenerated]
            public float L()
            {
                return this.f;
            }

            [CompilerGenerated]
            private void G(float A_0)
            {
                this.f = A_0;
            }

            public aa(int A_0, string A_1, afm A_2, afm A_3, bool A_4, float A_5)
            {
                this.G(A_0);
                this.G(A_1);
                this.H(A_2);
                this.G(A_3);
                this.G(A_4);
                this.G(A_5);
            }

            public int CompareTo(i0.aa other)
            {
                return this.G().CompareTo(other.G());
            }
        }

        private struct bb : IComparable
        {
            public readonly oe a;

            public readonly oe b;

            public bb(oe A_0, oe A_1)
            {
                this.a = A_0;
                this.b = A_1;
            }

            public int CompareTo(object obj)
            {
                if (!(obj is i0.bb))
                {
                    throw new ArgumentException();
                }
                i0.bb b = (i0.bb)obj;
                return this.a.CompareTo(b.a);
            }
        }

        public enum FurnitureDurabilityLossPlace
        {
            Indoors,
            Outdoors,
            Dungeons,
            PlayerIsland,
            GuildIsland,
            GuildTerritory,
            Num,
            Invalid = 6
        }

        public class cc
        {
            public oe[] a = new oe[8];

            public oe[] b = new oe[8];

            public oe[] c = new oe[8];

            public oe[] d = new oe[8];

            public oe[] e = new oe[8];
        }

        public enum dd
        {
            a,
            b,
            c,
            d
        }

        public static readonly int a = 100;

        public static readonly int b = 99;

        private oe[] c = new oe[8];

        private oe[] d = new oe[8];

        private oe[] e = new oe[8];

        private oe[] f = new oe[8];

        private oe[] g = new oe[8];

        private oe[] h = new oe[8];

        private oe[] i = new oe[8];

        private oe[] j = new oe[8];

        private oe[] k = new oe[8];

        private oe[] l = new oe[8];

        private oe[] m = new oe[9];

        private oe[] n = new oe[8];

        private oe[] o = new oe[8];

        private oe[] p = new oe[8];

        private oe[] q = new oe[8];

        private oe[] r = new oe[8];

        private oe[] s = new oe[8];

        private bool[] t = new bool[6];

        private i0.cc[] u;

        private oe v;

        private oe w;

        private oe x;

        private oe y;

        private oe[] z = new oe[8];

        private oe[] aaa = new oe[8];

        private oe ab;

        private oe ac;

        private oe ad;

        private oe ae;

        private oe af;

        [CompilerGenerated]
        private oe ag;

        [CompilerGenerated]
        private oe ah;

        [CompilerGenerated]
        private oe ai;

        [CompilerGenerated]
        private oe aj;

        [CompilerGenerated]
        private oe ak;

        [CompilerGenerated]
        private List<i0.aa> al;

        [CompilerGenerated]
        private afm am;

        [CompilerGenerated]
        private byte an;

        [CompilerGenerated]
        public oe I()
        {
            return this.ag;
        }

        [CompilerGenerated]
        private void N(oe A_0)
        {
            this.ag = A_0;
        }

        [CompilerGenerated]
        public oe J()
        {
            return this.ah;
        }

        [CompilerGenerated]
        private void M(oe A_0)
        {
            this.ah = A_0;
        }

        [CompilerGenerated]
        public oe K()
        {
            return this.ai;
        }

        [CompilerGenerated]
        private void L(oe A_0)
        {
            this.ai = A_0;
        }

        [CompilerGenerated]
        public oe L()
        {
            return this.aj;
        }

        [CompilerGenerated]
        private void K(oe A_0)
        {
            this.aj = A_0;
        }

        [CompilerGenerated]
        public oe M()
        {
            return this.ak;
        }

        [CompilerGenerated]
        private void J(oe A_0)
        {
            this.ak = A_0;
        }

        [CompilerGenerated]
        public List<i0.aa> N()
        {
            return this.al;
        }

        [CompilerGenerated]
        private void I(List<i0.aa> A_0)
        {
            this.al = A_0;
        }

        [CompilerGenerated]
        public afm O()
        {
            return this.am;
        }

        [CompilerGenerated]
        private void I(afm A_0)
        {
            this.am = A_0;
        }

        [CompilerGenerated]
        public byte P()
        {
            return this.an;
        }

        [CompilerGenerated]
        private void I(byte A_0)
        {
            this.an = A_0;
        }

        public i0()
        {
            this.I(new List<i0.aa>());
            this.u = new i0.cc[Enum.GetValues(typeof(i0.dd)).Length];
            for (int i = 0; i < this.u.Length; i++)
            {
                this.u[i] = new i0.cc();
            }
        }

        public oe I(int A_0)
        {
            return this.c[A_0 - 1];
        }

        public oe J(int A_0)
        {
            return this.d[A_0 - 1];
        }

        public oe K(int A_0)
        {
            return this.e[A_0 - 1];
        }

        public oe L(int A_0)
        {
            return this.f[A_0 - 1];
        }

        public oe M(int A_0)
        {
            return this.g[A_0 - 1];
        }

        public oe N(int A_0)
        {
            return this.i[A_0 - 1];
        }

        public oe O(int A_0)
        {
            return this.j[A_0 - 1];
        }

        public oe P(int A_0)
        {
            return this.k[A_0 - 1];
        }

        public oe Q(int A_0)
        {
            return this.l[A_0 - 1];
        }

        public oe R(int A_0)
        {
            return this.m[A_0];
        }

        public oe S(int A_0)
        {
            return this.n[A_0 - 1];
        }

        public oe T(int A_0)
        {
            return this.o[A_0 - 1];
        }

        public oe U(int A_0)
        {
            return this.q[A_0 - 1];
        }

        public oe V(int A_0)
        {
            return this.r[A_0 - 1];
        }

        public oe W(int A_0)
        {
            return this.s[A_0 - 1];
        }

        public oe I(i0.dd A_0, int A_1, Random A_2)
        {
            oe oe = this.u[(int)A_0].b[A_1 - 1];
            oe oe2 = this.u[(int)A_0].c[A_1 - 1];
            if (oe.M(oe, oe2))
            {
                return oe;
            }
            oe a_ = oe.E(A_2.NextDouble());
            oe a_2 = oe.P(oe2, oe);
            return oe.Q(oe.O(a_2, a_), oe);
        }

        public oe I(i0.dd A_0, int A_1)
        {
            return this.u[(int)A_0].d[A_1 - 1];
        }

        public oe J(i0.dd A_0, int A_1)
        {
            return this.u[(int)A_0].a[A_1 - 1];
        }

        public oe K(i0.dd A_0, int A_1)
        {
            return this.u[(int)A_0].e[A_1 - 1];
        }

        public oe I(bp A_0, oe A_1)
        {
            double num = A_1.K() / A_0.dq().k();
            num = Math.Min(1.0, num);
            double num2 = 1.0 - num;
            return oe.E(num2 * (double)A_0.ec());
        }

        private oe M(oe A_0, oe A_1)
        {
            if (A_0.l == 0L)
            {
                return oe.g;
            }
            oe result = oe.O(A_0, A_1).p();
            if (result.l == 0L)
            {
                return oe.h;
            }
            return result;
        }

        private oe L(oe A_0, oe A_1)
        {
            if (A_1.l == 0L)
            {
                return oe.g;
            }
            oe oe1 = oe.N(A_0, A_1);
            oe a_ = oe.O(oe1, this.v);
            oe a_2 = oe.O(oe.P(oe.h, oe1), this.w);
            return oe.Q(a_, a_2);
        }

        public oe I(by A_0, oe A_1, afe A_2)
        {
            if (this.x.l == 0L)
            {
                return oe.g;
            }
            oe a_ = this.l(A_1, A_0.Fs());
            oe a_2 = oe.O(a_, this.x);
            oe a_3 = A_2.im(A_0.W);
            return this.M(a_3, a_2);
        }

        public oe I(by A_0, oe A_1)
        {
            if (this.x.l == 0L)
            {
                return oe.g;
            }
            oe a_ = this.l(A_1, A_0.Fs());
            oe a_2 = oe.O(a_, this.x);
            oe a_3 = A_0.K.N();
            return this.M(a_3, a_2);
        }

        public oe J(by A_0, oe A_1, afe A_2)
        {
            oe oe = this.l(A_1, A_0.Fs());
            oe a_ = oe;
            oe a_2 = A_2.iq(A_0.W);
            return this.M(a_2, a_);
        }

        public oe K(by A_0, oe A_1, afe A_2)
        {
            oe oe = this.l(A_1, A_0.Fs());
            oe a_ = oe;
            oe a_2 = A_0.Y;
            return this.M(a_2, a_);
        }

        public oe L(by A_0, oe A_1, afe A_2)
        {
            oe oe = this.l(A_1, A_0.Fs());
            oe a_ = oe;
            oe a_2 = A_0.X;
            return this.M(a_2, a_);
        }

        public oe M(by A_0, oe A_1, afe A_2)
        {
            oe oe = this.l(A_1, A_0.Fs());
            oe a_ = oe;
            oe a_2 = A_0.W;
            return this.M(a_2, a_);
        }

        public oe J(float A_0)
        {
            return oe.O(oe.E((double)A_0), this.y);
        }

        private oe K(oe A_0, oe A_1)
        {
            if (A_0.l == 0L)
            {
                return oe.g;
            }
            oe result = oe.O(A_0, A_1).p();
            if (result.l == 0L)
            {
                return oe.h;
            }
            return result;
        }

        public float I(float A_0, oe A_1)
        {
            return A_0 * (float)A_1.k();
        }

        public oe N(oe A_0, oe A_1)
        {
            return oe.O(A_0, A_1);
        }

        public int I(int A_0, oe A_1, ob A_2)
        {
            float a_ = this.I((float)A_0, A_1);
            return A_2.b(a_);
        }

        public oe I(oe A_0, oe A_1, ob A_2)
        {
            if (A_0.l == 0L)
            {
                return oe.g;
            }
            int num = A_2.b((float)this.N(A_0, A_1).K());
            return oe.F((long)num);
        }

        private oe J(oe A_0, oe A_1)
        {
            if (A_1.l == 0L)
            {
                return oe.g;
            }
            oe oe1 = oe.N(A_0, A_1);
            oe a_ = oe.O(oe1, this.ac);
            oe a_2 = oe.O(oe.P(oe.h, oe1), this.ab);
            return oe.Q(a_, a_2);
        }

        public oe J(by A_0, oe A_1)
        {
            int num = A_0.F - 1;
            if (num < 0 || num >= 8)
            {
                return oe.g;
            }
            oe a_ = this.j(A_1, A_0.Fs());
            return oe.O(a_, this.z[num]);
        }

        public oe I(b0 A_0)
        {
            int num = A_0.f - 1;
            if (num < 0 || num >= 8)
            {
                return oe.g;
            }
            return this.z[num];
        }

        public oe K(by A_0, oe A_1)
        {
            int num = A_0.F - 1;
            if (num < 0 || num >= 8)
            {
                return oe.g;
            }
            oe a_ = this.j(A_1, A_0.Fs());
            return oe.O(a_, this.aaa[num]);
        }

        public oe J(b0 A_0)
        {
            int num = A_0.f - 1;
            if (num < 0 || num >= 8)
            {
                return oe.g;
            }
            return this.aaa[num];
        }

        public oe K(float A_0)
        {
            return oe.O(oe.E((double)A_0), this.ad);
        }

        public oe L(float A_0)
        {
            return oe.O(oe.E((double)A_0), this.ad);
        }

        public oe M(float A_0)
        {
            return oe.O(oe.E((double)A_0), this.af);
        }

        public oe I(e5 A_0, afe A_1)
        {
            oe a_ = this.ae;
            oe a_2 = A_1.im(A_0.w);
            if (a_2.l == 0L || a_.l == 0L)
            {
                return oe.g;
            }
            return oe.O(a_2, a_).p();
        }

        public oe I(bx A_0, int A_1, int A_2)
        {
            if (A_0 != null)
            {
                return oe.O(oe.E(A_0.V, A_1), this.o(A_0.F));
            }
            return oe.g;
        }

        public bool I(i0.FurnitureDurabilityLossPlace A_0)
        {
            return A_0 >= i0.FurnitureDurabilityLossPlace.Indoors && A_0 < i0.FurnitureDurabilityLossPlace.Num && this.t[(int)A_0];
        }

        public i0.FurnitureDurabilityLossPlace I(no A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
        {
            if (A_1)
            {
                return i0.FurnitureDurabilityLossPlace.Indoors;
            }
            if (A_0.ba())
            {
                return i0.FurnitureDurabilityLossPlace.Dungeons;
            }
            if (A_3)
            {
                return i0.FurnitureDurabilityLossPlace.PlayerIsland;
            }
            if (A_2)
            {
                return i0.FurnitureDurabilityLossPlace.GuildIsland;
            }
            if (A_4 && A_5)
            {
                return i0.FurnitureDurabilityLossPlace.GuildTerritory;
            }
            return i0.FurnitureDurabilityLossPlace.Outdoors;
        }

        public bool J(no A_0, bool A_1, bool A_2, bool A_3, bool A_4, bool A_5)
        {
            i0.FurnitureDurabilityLossPlace a_ = this.I(A_0, A_1, A_2, A_3, A_4, A_5);
            return this.I(a_);
        }

        public static int I(aeb A_0)
        {
            return i0.I(A_0.aa(), A_0.o());
        }

        public static int I(oe A_0, oe A_1)
        {
            if (A_0.l == 0L || A_1.l == 0L)
            {
                return 0;
            }
            oe a_ = oe.N(A_0, A_1);
            if (a_.l == 0L)
            {
                return 1;
            }
            return i0.I(a_);
        }

        public static int I(oe A_0)
        {
            return i0.I((float)A_0.K());
        }

        public static int I(float A_0)
        {
            if (A_0 == 1f)
            {
                return i0.a;
            }
            float num = A_0 * (float)i0.a;
            if (num >= (float)i0.b && num < (float)i0.a)
            {
                return i0.b;
            }
            return (int)Math.Ceiling((double)num);
        }

        public bool Y(XmlElement A_0)
        {
            if (A_0.Name != "DurabilityData")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (al6.k == null)
                    {
                        al6.k = new Dictionary<string, int>(11)
                    {
                        {
                            "ItemBrokenState",
                            0
                        },
                        {
                            "Durability",
                            1
                        },
                        {
                            "DurabilityIndicators",
                            2
                        },
                        {
                            "DurabilityLoss",
                            3
                        },
                        {
                            "ItemLoss",
                            4
                        },
                        {
                            "Repair",
                            5
                        },
                        {
                            "Salvage",
                            6
                        },
                        {
                            "RerollQuality",
                            7
                        },
                        {
                            "ShowItemWarning",
                            8
                        },
                        {
                            "MinCraftDurability",
                            9
                        },
                        {
                            "MinDurabilityDecay",
                            10
                        }
                    };
                    }
                    int num;
                    if (al6.k.TryGetValue(name, out num))
                    {
                        switch (num)
                        {
                            case 0:
                                if (!this.X(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 1:
                                if (!this.S(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 2:
                                if (!this.W(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 3:
                                if (!this.Q(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 4:
                                if (!this.O(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 5:
                                if (!this.N(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 6:
                                if (!this.L(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 7:
                                if (!this.J(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 8:
                                if (!this.V(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 9:
                                if (!this.U(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                            case 10:
                                if (!this.T(xmlElement))
                                {
                                    bool result = false;
                                    return result;
                                }
                                break;
                        }
                    }
                }
            }
            return true;
        }

        private bool X(XmlElement A_0)
        {
            if (A_0.Name != "ItemBrokenState")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'ItemBrokenState' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            this.N(al5.C(A_0, "percentunder", oe.j));
            return true;
        }

        private bool W(XmlElement A_0)
        {
            if (A_0.Name != "DurabilityIndicators")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'DurabilityIndicators' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            this.I(al5.A(A_0, "trashhudcolor", afm.e()));
            this.I((byte)al5.B(A_0, "hudalpha", 0));
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null && name == "DurabilityIndicator")
                {
                    int a_ = al5.B(xmlElement, "percentageaboveorequal", 0);
                    string a_2 = al5.h(xmlElement, "spritename");
                    afm a_3 = al5.A(xmlElement, "hudcolor", afm.e());
                    afm a_4 = al5.A(xmlElement, "iconcolor", afm.e());
                    bool a_5 = al5.A(xmlElement, "hidehud", false);
                    float a_6 = al5.A(xmlElement, "itempowerreduction", 0f);
                    i0.aa item = new i0.aa(a_, a_2, a_3, a_4, a_5, a_6);
                    this.N().Add(item);
                }
            }
            this.N().Sort();
            return true;
        }

        private bool V(XmlElement A_0)
        {
            if (A_0.Name != "ShowItemWarning")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'ShowItemWarning' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            this.M(al5.C(A_0, "percentunder", oe.j));
            return this.J().l >= 0L;
        }

        private bool U(XmlElement A_0)
        {
            if (A_0.Name != "MinCraftDurability")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'MinCraftDurability' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            this.L(al5.C(A_0, "minpercent", oe.j));
            return this.K().l >= 0L;
        }

        private bool T(XmlElement A_0)
        {
            if (A_0.Name != "MinDurabilityDecay")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'MinDurabilityDecay' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            this.K(al5.C(A_0, "minpercent", oe.j));
            return this.L().l >= 0L;
        }

        private bool S(XmlElement A_0)
        {
            if (A_0.Name != "Durability")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'Durability' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (al6.l == null)
                    {
                        al6.l = new Dictionary<string, int>(7)
                    {
                        {
                            "Tools",
                            0
                        },
                        {
                            "Weapons",
                            1
                        },
                        {
                            "Armors",
                            2
                        },
                        {
                            "Mounts",
                            3
                        },
                        {
                            "Buildings",
                            4
                        },
                        {
                            "FurnitureItems",
                            5
                        },
                        {
                            "ConstructionSite",
                            6
                        }
                    };
                    }
                    int num;
                    if (al6.l.TryGetValue(name, out num))
                    {
                        switch (num)
                        {
                            case 0:
                                al5.C(xmlElement, "durability", ref this.c);
                                break;
                            case 1:
                                al5.C(xmlElement, "durability", ref this.d);
                                break;
                            case 2:
                                al5.C(xmlElement, "durability", ref this.e);
                                break;
                            case 3:
                                al5.C(xmlElement, "durability", ref this.f);
                                break;
                            case 4:
                                al5.C(xmlElement, "durability", ref this.g);
                                break;
                            case 5:
                                al5.C(xmlElement, "durability", ref this.i);
                                break;
                            case 6:
                                this.R(xmlElement);
                                break;
                        }
                    }
                }
            }
            return true;
        }

        private bool R(XmlElement A_0)
        {
            if (A_0.Name != "ConstructionSite")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'ConstructionSite' under XmlTag 'Durability' not found! Invalid Xml File?");
            }
            this.j(al5.B(A_0, "mindurability", oe.j));
            return true;
        }

        private bool Q(XmlElement A_0)
        {
            if (A_0.Name != "DurabilityLoss")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'DurabilityLoss' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (al6.m == null)
                    {
                        al6.m = new Dictionary<string, int>(10)
                    {
                        {
                            "ToolUse",
                            0
                        },
                        {
                            "Attack",
                            1
                        },
                        {
                            "UseSpell",
                            2
                        },
                        {
                            "ArmorOnReceiveAttack",
                            3
                        },
                        {
                            "ArmorOnReceiveSpell",
                            4
                        },
                        {
                            "PerTimeBuilding",
                            5
                        },
                        {
                            "PerTimeFurnitureObject",
                            6
                        },
                        {
                            "PerUseFurnitureObject",
                            7
                        },
                        {
                            "BuildingOnCraftedItem",
                            8
                        },
                        {
                            "FurnitureObjectPerPlace",
                            9
                        }
                    };
                    }
                    int num;
                    if (al6.m.TryGetValue(name, out num))
                    {
                        switch (num)
                        {
                            case 0:
                                al5.C(xmlElement, "durabilityloss", ref this.j);
                                break;
                            case 1:
                                al5.C(xmlElement, "durabilityloss", ref this.k);
                                break;
                            case 2:
                                al5.C(xmlElement, "durabilityloss", ref this.l);
                                break;
                            case 3:
                                al5.A(xmlElement, "durabilityloss", ref this.m);
                                break;
                            case 4:
                                al5.C(xmlElement, "durabilityloss", ref this.n);
                                break;
                            case 5:
                                al5.C(xmlElement, "durabilityloss", ref this.o);
                                break;
                            case 6:
                                al5.C(xmlElement, "durabilityloss", ref this.q);
                                break;
                            case 7:
                                al5.C(xmlElement, "durabilityloss", ref this.r);
                                break;
                            case 8:
                                al5.C(xmlElement, "itemvaluefactor", ref this.s);
                                break;
                            case 9:
                                this.P(xmlElement);
                                break;
                        }
                    }
                }
            }
            return true;
        }

        private void P(XmlElement A_0)
        {
            foreach (object current in A_0)
            {
                XmlElement xmlElement = current as XmlElement;
                if (xmlElement != null)
                {
                    bool flag = al5.A(xmlElement, "decay", false);
                    i0.FurnitureDurabilityLossPlace furnitureDurabilityLossPlace = al5.A<i0.FurnitureDurabilityLossPlace>(xmlElement, "type", i0.FurnitureDurabilityLossPlace.Num);
                    if (furnitureDurabilityLossPlace != i0.FurnitureDurabilityLossPlace.Num)
                    {
                        this.t[(int)furnitureDurabilityLossPlace] = flag;
                    }
                }
            }
        }

        private bool O(XmlElement A_0)
        {
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (!(name == "AliveToDead"))
                    {
                        if (!(name == "AliveToKO"))
                        {
                            if (name == "KOToDead")
                            {
                                this.I(this.u[2], xmlElement);
                            }
                        }
                        else
                        {
                            this.I(this.u[1], xmlElement);
                        }
                    }
                    else
                    {
                        this.I(this.u[0], xmlElement);
                    }
                }
            }
            return true;
        }

        private bool I(i0.cc A_0, XmlElement A_1)
        {
            foreach (XmlNode xmlNode in A_1.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (!(name == "DurabilityLoss"))
                    {
                        if (!(name == "Destroyed"))
                        {
                            if (name == "StackLoss")
                            {
                                al5.B(xmlElement, "percentage", ref A_0.e);
                            }
                        }
                        else
                        {
                            al5.B(xmlElement, "percentage", ref A_0.a);
                        }
                    }
                    else
                    {
                        al5.B(xmlElement, "minpercent", ref A_0.b);
                        al5.B(xmlElement, "maxpercent", ref A_0.c);
                        al5.A(xmlElement, "minimumpercentremaining", ref A_0.d, oe.g);
                    }
                }
            }
            return true;
        }

        private bool N(XmlElement A_0)
        {
            if (A_0.Name != "Repair")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'Repair' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null && name == "Items")
                {
                    this.M(xmlElement);
                }
            }
            return true;
        }

        private bool M(XmlElement A_0)
        {
            if (A_0.Name != "Items")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'Items' under XmlTag 'DurabilityData/Repair' not found! Invalid Xml File?");
            }
            this.v = oe.j;
            this.w = oe.j;
            this.x = oe.j;
            this.y = oe.j;
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                if (xmlElement != null && xmlElement.Name == "CostFactors")
                {
                    this.v = al5.C(xmlElement, "lower", oe.j);
                    this.w = al5.C(xmlElement, "upper", oe.j);
                }
                else if (xmlElement != null && xmlElement.Name == "Modifier")
                {
                    this.x = al5.C(xmlElement, "silver", oe.j);
                }
                else if (xmlElement != null && xmlElement.Name == "Time")
                {
                    this.y = al5.C(xmlElement, "crafttimefactor", oe.j);
                }
            }
            return true;
        }

        private bool L(XmlElement A_0)
        {
            if (A_0.Name != "Salvage")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'Repair' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null && name == "Items")
                {
                    this.K(xmlElement);
                }
            }
            return true;
        }

        private bool K(XmlElement A_0)
        {
            if (A_0.Name != "Items")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'Items' under XmlTag 'DurabilityData/Salvage' not found! Invalid Xml File?");
            }
            this.ab = oe.j;
            this.ac = oe.j;
            this.ad = oe.j;
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (!(name == "RewardFactors"))
                    {
                        if (!(name == "Time"))
                        {
                            if (name == "GainFactors")
                            {
                                al5.B(xmlElement, "resource", ref this.z);
                                al5.B(xmlElement, "silver", ref this.aaa);
                            }
                        }
                        else
                        {
                            this.ad = al5.C(xmlElement, "crafttimefactor", oe.j);
                        }
                    }
                    else
                    {
                        this.ab = al5.C(xmlElement, "lower", oe.j);
                        this.ac = al5.C(xmlElement, "upper", oe.j);
                    }
                }
            }
            return true;
        }

        private bool J(XmlElement A_0)
        {
            if (A_0.Name != "RerollQuality")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'RerollQuality' under XmlTag 'DurabilityData' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null && name == "Items")
                {
                    this.I(xmlElement);
                }
            }
            return true;
        }

        private bool I(XmlElement A_0)
        {
            if (A_0.Name != "Items")
            {
                throw new Exception("[DurabilityInfo] LoadDataFromXml: XmlTag 'Items' under XmlTag 'DurabilityData/RerollQuality' not found! Invalid Xml File?");
            }
            this.ae = oe.j;
            this.af = oe.j;
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (!(name == "CostModifier"))
                    {
                        if (name == "Time")
                        {
                            this.af = al5.C(xmlElement, "crafttimefactor", oe.j);
                        }
                    }
                    else
                    {
                        this.ae = al5.C(xmlElement, "silver", oe.j);
                    }
                }
            }
            return true;
        }
    }
}