using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class e5 : by, doo
    {
        protected string bo;

        private List<string>[] bp;

        private static string[] bq;

        private static List<g7>[] br;

        private static List<aeh>[] bs;

        private static List<string>[] bt;

        [CompilerGenerated]
        private EquipmentSlot bu;

        [CompilerGenerated]
        private ItemPowerProgressionType bv;

        [CompilerGenerated]
        private bool bw;

        [CompilerGenerated]
        private bool bx;

        [CompilerGenerated]
        private bool by;

        [CompilerGenerated]
        private string bz;

        [CompilerGenerated]
        private string b0;

        [CompilerGenerated]
        private bool b1;

        [CompilerGenerated]
        private int b2;

        [CompilerGenerated]
        private new int b3;

        [CompilerGenerated]
        private new string b4;

        [CompilerGenerated]
        private new string b5;

        [CompilerGenerated]
        private string b6;

        [CompilerGenerated]
        private afm b7;

        [CompilerGenerated]
        private List<it> b8;

        [CompilerGenerated]
        private List<string> b9;

        [CompilerGenerated]
        private AttackType ca;

        [CompilerGenerated]
        private float cb;

        [CompilerGenerated]
        private List<g7>[] cc;

        [CompilerGenerated]
        private List<aeh>[] cd;

        [CompilerGenerated]
        private Dictionary<string, string> ce;

        [CompilerGenerated]
        private int cf;

        [CompilerGenerated]
        private List<string> cg;

        [CompilerGenerated]
        private oe ch;

        [CompilerGenerated]
        private oe ci;

        [CompilerGenerated]
        private oe cj;

        [CompilerGenerated]
        private oe ck;

        [CompilerGenerated]
        private int cl;

        [CompilerGenerated]
        private float cm;

        [CompilerGenerated]
        private float cn;

        [CompilerGenerated]
        private float co;

        [CompilerGenerated]
        private Dictionary<string, el> cp;

        [CompilerGenerated]
        private string cq;

        [CompilerGenerated]
        private string cr;

        [CompilerGenerated]
        private iq cs;

        [CompilerGenerated]
        private string ct;

        [CompilerGenerated]
        private float[] c1;

        [CompilerGenerated]
        private HashSet<string> c2;

        public EquipmentSlot Bo
        {
            get;
            private set;
        }

        public ItemPowerProgressionType Bp
        {
            get;
            private set;
        }

        public bool Bq
        {
            get;
            private set;
        }

        public bool Br
        {
            get;
            private set;
        }

        public bool Bs
        {
            get;
            private set;
        }

        public string Bt
        {
            get;
            private set;
        }

        public string Bu
        {
            get;
            private set;
        }

        public bool Bv
        {
            get;
            private set;
        }

        public int Bw
        {
            get;
            private set;
        }

        public int Bx
        {
            get;
            private set;
        }

        public string By
        {
            get;
            private set;
        }

        public string Bz
        {
            get;
            private set;
        }

        public string B0
        {
            get;
            private set;
        }

        public afm B1
        {
            get;
            private set;
        }

        public List<it> B2
        {
            get;
            private set;
        }

        public new List<string> B3
        {
            get;
            private set;
        }

        public new AttackType B4
        {
            get;
            private set;
        }

        public new float B5
        {
            get;
            private set;
        }

        public List<g7>[] B6
        {
            get;
            private set;
        }

        public List<aeh>[] B7
        {
            get;
            private set;
        }

        public Dictionary<string, string> B8
        {
            get;
            private set;
        }

        public int B9
        {
            get;
            private set;
        }

        public List<string> Ca
        {
            get;
            private set;
        }

        public oe Cb
        {
            get;
            private set;
        }

        public oe Cc
        {
            get;
            private set;
        }

        public oe Cd
        {
            get;
            private set;
        }

        public oe Ce
        {
            get;
            private set;
        }

        public int Cf
        {
            get;
            private set;
        }

        public float Cg
        {
            get;
            private set;
        }

        public float Ch
        {
            get;
            private set;
        }

        public float Ci
        {
            get;
            private set;
        }

        public Dictionary<string, el> Cj
        {
            get;
            private set;
        }

        public string Ck
        {
            get;
            private set;
        }

        public string Cl
        {
            get;
            private set;
        }

        public iq Cm
        {
            get;
            private set;
        }

        public string Cn
        {
            get;
            private set;
        }

        public float Co
        {
            get
            {
                return this.A(PlayerAttribute.AbilityPower);
            }
        }

        public float Cp
        {
            get
            {
                return this.A(PlayerAttribute.ItemPower);
            }
        }

        public string Cq
        {
            get
            {
                if (string.IsNullOrEmpty(this.bo))
                {
                    return base.J;
                }
                return this.bo;
            }
        }

        protected float[] Cr
        {
            get;
            private set;
        }

        protected HashSet<string> Cs
        {
            get;
            private set;
        }

        public float A(PlayerAttribute A_0)
        {
            return this.Cr[(int)A_0];
        }

        static e5()
        {
            e5.br = new List<g7>[0];
            e5.bs = new List<aeh>[0];
            e5.bt = new List<string>[0];
            e5.bq = Enum.GetNames(typeof(ItemPowerProgressionType));
            for (int i = 0; i < e5.bq.Length; i++)
            {
                e5.bq[i] = e5.bq[i].ToLower();
            }
        }

        public e5(cu A_0) : base(A_0)
        {
            this.Bo = EquipmentSlot.Armor;
            this.Bp = ItemPowerProgressionType.None;
            this.Bq = false;
            this.B4 = AttackType.None;
            this.B5 = 0f;
            this.Bv = false;
            this.B9 = 1;
            this.Cb = oe.j;
            this.Cc = oe.j;
            this.Cd = oe.j;
            this.Ce = oe.j;
            this.bo = string.Empty;
            this.Br = false;
            this.Bs = false;
            this.By = string.Empty;
            this.Bz = string.Empty;
            this.B0 = "RightArm_3";
            this.B1 = afm.e();
            this.cs = null;
            this.Bw = 0;
            this.Bx = 0;
            this.Bt = string.Empty;
            this.Bu = string.Empty;
            this.Cr = new float[57];
            this.Cr[53] = 100f;
            this.Cr[55] = 100f;
            this.Cf = 0;
            this.Cg = 0f;
            this.Ch = 0f;
            this.Ci = 1f;
            this.Ck = string.Empty;
            this.Cl = string.Empty;
            this.Cn = string.Empty;
            this.B2 = null;
            this.B3 = null;
            this.B6 = e5.br;
            this.B7 = e5.bs;
            this.bp = e5.bt;
        }

        public override bx Df()
        {
            e5 e = base.Df() as e5;
            e.Cr = (e.Cr.Clone() as float[]);
            return e;
        }

        public bool Fp()
        {
            return this.Cs != null && this.Cs.Count > 0;
        }

        public bool D6(string A_0)
        {
            return this.Cs != null && this.Cs.Contains(A_0);
        }

        public bool Fq()
        {
            return this.B9 > 1;
        }

        public bool D2(int A_0)
        {
            return this.B9 >= A_0;
        }

        public int D3(int A_0)
        {
            if (this.D2(A_0))
            {
                return A_0;
            }
            for (int i = A_0 - 1; i > 1; i--)
            {
                if (this.D2(i))
                {
                    return i;
                }
            }
            return 1;
        }

        protected override bool Dg(XmlElement A_0)
        {
            if (!base.Dg(A_0))
            {
                return false;
            }
            this.Bo = al5.A<EquipmentSlot>(A_0, "slottype", this.Bo);
            try
            {
                string text = al5.A(A_0, "itempowerprogressiontype", this.Bo.ToString());
                text = text.ToLowerInvariant();
                if (Array.IndexOf<string>(e5.bq, text) >= 0)
                {
                    this.Bp = (ItemPowerProgressionType)Enum.Parse(typeof(ItemPowerProgressionType), text, true);
                }
                else
                {
                    this.Bp = ItemPowerProgressionType.None;
                }
            }
            catch (Exception)
            {
                this.Bp = ItemPowerProgressionType.None;
            }
            return true;
        }

        public override bool B4(XmlElement A_0)
        {
            if (!base.B4(A_0))
            {
                return false;
            }
            this.Bq = al5.A(A_0, "twohanded", this.Bq);
            this.B4 = al5.A<AttackType>(A_0, "attacktype", this.B4);
            this.B5 = al5.A(A_0, "attackbuildingdamage", this.B5);
            this.Bv = (this.B5 > 0f);
            this.B9 = al5.B(A_0, "maxqualitylevel", this.B9);
            this.Cb = al5.C(A_0, "durabilityloss_attack", this.Cb);
            this.Cc = al5.C(A_0, "durabilityloss_spelluse", this.Cc);
            this.Cd = al5.C(A_0, "durabilityloss_receivedattack", this.Cd);
            this.Ce = al5.C(A_0, "durabilityloss_receivedspell", this.Ce);
            this.bo = al5.A(A_0, "mesh", this.bo);
            this.Br = al5.A(A_0, "unlockedtoequip", this.Br);
            this.Bs = al5.A(A_0, "unequipincombat", this.Bs);
            this.By = al5.A(A_0, "mainhandanimationtype", this.By);
            this.By = this.By.ToLowerInvariant();
            if (this.By == "none")
            {
                this.By = string.Empty;
            }
            this.Bz = al5.A(A_0, "offhandanimationtype", this.Bz);
            this.Bz = this.Bz.ToLowerInvariant();
            if (this.Bz == "none")
            {
                this.Bz = string.Empty;
            }
            this.B0 = al5.A(A_0, "fxbonename", this.B0);
            this.B1 = al5.A(A_0, "fxboneoffset", this.B1);
            List<XmlElement> list = al5.D(A_0, "canharvest");
            if (list != null && list.Count > 0)
            {
                this.Cs = new HashSet<string>();
                foreach (XmlNode current in list)
                {
                    XmlElement xmlElement = current as XmlElement;
                    if (xmlElement != null)
                    {
                        string item = al5.A(xmlElement, "resourcetype", "");
                        this.Cs.Add(item);
                    }
                }
            }
            this.bw = al5.b(A_0, "activespellslots", this.bw);
            this.bx = al5.b(A_0, "passivespellslots", this.bx);
            this.bt = al5.a(A_0, "facestate", this.bt);
            this.bu = al5.a(A_0, "beardstate", this.bu);
            this.cf = al5.b(A_0, "requiredaccesslevel", this.cf);
            this.cr[0] = al5.a(A_0, "hitpointsmax", this.cr[0]);
            this.cr[1] = al5.a(A_0, "hitpointsmaxbonus", this.cr[1]);
            this.cr[2] = al5.a(A_0, "hitpointsregeneration", this.cr[2]);
            this.cr[3] = al5.a(A_0, "hitpointsregenerationbonus", this.cr[3]);
            this.cr[4] = al5.a(A_0, "energymax", this.cr[4]);
            this.cr[5] = al5.a(A_0, "energymaxbonus", this.cr[5]);
            this.cr[6] = al5.a(A_0, "energyregeneration", this.cr[6]);
            this.cr[7] = al5.a(A_0, "energyregenerationbonus", this.cr[7]);
            this.cr[12] = al5.a(A_0, "movespeed", this.cr[12]);
            this.cr[13] = al5.a(A_0, "movespeedbonus", this.cr[13]);
            this.cr[14] = al5.a(A_0, "maxload", this.cr[14]);
            this.cr[15] = al5.a(A_0, "maxloadbonus", this.cr[15]);
            this.cr[16] = al5.a(A_0, "attackdamage", this.cr[16]);
            this.cr[17] = al5.a(A_0, "physicalattackdamagebonus", this.cr[17]);
            this.cr[18] = al5.a(A_0, "magicattackdamagebonus", this.cr[18]);
            this.cr[19] = al5.a(A_0, "attackrangebonus", this.cr[19]);
            this.cr[20] = al5.a(A_0, "attackspeedbonus", this.cr[20]);
            this.cr[21] = al5.a(A_0, "physicalspelldamagebonus", this.cr[21]);
            this.cr[22] = al5.a(A_0, "magicspelldamagebonus", this.cr[22]);
            this.cr[28] = al5.a(A_0, "healbonus", this.cr[28]);
            this.cr[29] = al5.a(A_0, "healmodifier", this.cr[29]);
            this.cr[30] = al5.a(A_0, "energycostreduction", this.cr[30]);
            this.cr[23] = al5.a(A_0, "magiccasttimereduction", this.cr[23]);
            this.cr[24] = 1f / (1f - this.cr[23]) - 1f;
            this.cr[25] = al5.a(A_0, "magiccooldownreduction", this.cr[25]);
            this.cr[26] = 1f / (1f - this.cr[25]) - 1f;
            this.cr[27] = al5.a(A_0, "magiccastingresilience", this.cr[27]);
            this.cr[31] = al5.a(A_0, "physicalarmor", this.cr[31]);
            this.cr[32] = al5.a(A_0, "magicresistance", this.cr[32]);
            this.cr[33] = al5.a(A_0, "crowdcontrolresistance", this.cr[33]);
            this.cr[37] = al5.a(A_0, "focusfireprotectionpeneration", this.cr[37]);
            this.cr[41] = al5.a(A_0, "gatheringyield", this.cr[41]);
            this.cr[53] = al5.a(A_0, "abilitypower", this.cr[53]);
            this.cr[54] = al5.a(A_0, "abilitypowerbonus", this.cr[54]);
            this.cr[55] = al5.a(A_0, "itempower", this.cr[55]);
            this.cr[56] = al5.a(A_0, "threatbonus", this.cr[56]);
            this.cr[45] = al5.a(A_0, "bonusccdurationvsplayers", this.cr[45]);
            this.cr[49] = al5.a(A_0, "bonusccdurationvsmobs", this.cr[49]);
            this.cr[44] = al5.a(A_0, "bonusccrvsplayers", this.cr[44]);
            this.cr[48] = al5.a(A_0, "bonusccrvsmobs", this.cr[48]);
            this.cr[42] = al5.a(A_0, "bonusdamagevsplayers", this.cr[42]);
            this.cr[46] = al5.a(A_0, "bonusdamagevsmobs", this.cr[46]);
            this.cr[43] = al5.a(A_0, "bonusdefensevsplayers", this.cr[43]);
            this.cr[47] = al5.a(A_0, "bonusdefensevsmobs", this.cr[47]);
            this.cg = al5.a(A_0, "attackrange", this.cg);
            this.ch = al5.a(A_0, "attackspeed", this.ch);
            this.ci = al5.a(A_0, "attackdamagetimefactor", this.ci);
            string text = ir.q(A_0);
            if (!string.IsNullOrEmpty(text))
            {
                this.ck = text;
            }
            string text2 = el.a(A_0);
            if (!string.IsNullOrEmpty(text2))
            {
                this.cl = text2;
            }
            string text3 = iq.c(A_0);
            if (!string.IsNullOrEmpty(text3))
            {
                this.cn = text3;
            }
            List<it> list2 = it.i(A_0);
            if (list2 != null && list2.Count > 0)
            {
                this.b2 = list2;
            }
            List<string> list3 = null;
            List<XmlElement> list4 = al5.d(A_0, "meleehitvfx");
            if (list4 != null && list4.Count > 0)
            {
                list3 = new List<string>();
                foreach (XmlNode current2 in list4)
                {
                    list3.Add(al5.a(current2 as XmlElement, "prefab", "Prefabs/Vfx/MeleeHit/MeleeHit"));
                }
            }
            if (list3 != null)
            {
                this.b3 = list3;
            }
            this.a(A_0);
            return true;
        }

        private void a(XmlElement A_0)
        {
            List<XmlElement> list = al5.d(A_0, "craftingspelllist");
            if (list != null && list.Count > 0)
            {
                int num = Math.Max(this.bw, this.bx);
                this.bp = new List<string>[num];
                for (int i = 0; i < this.bp.Length; i++)
                {
                    this.bp[i] = new List<string>();
                }
                XmlElement xmlElement = list[0];
                foreach (XmlNode xmlNode in xmlElement.ChildNodes)
                {
                    XmlElement xmlElement2 = xmlNode as XmlElement;
                    if (xmlElement2 != null)
                    {
                        string text = al5.h(xmlElement2, "uniquename");
                        string value = al5.h(xmlElement2, "tag");
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (this.b8 == null)
                            {
                                this.b8 = new Dictionary<string, string>();
                            }
                            if (!this.b8.ContainsKey(text))
                            {
                                this.b8.Add(text, value);
                            }
                        }
                        string text2 = al5.a(xmlElement2, "slots", "all");
                        if (text2 == "all" && this.bp.Length > 0)
                        {
                            for (int j = 0; j < this.bp.Length; j++)
                            {
                                this.bp[j].Add(text);
                            }
                        }
                        else
                        {
                            string[] array = text2.Split(new char[]
                            {
                            ','
                            }, StringSplitOptions.RemoveEmptyEntries);
                            for (int k = 0; k < array.Length; k++)
                            {
                                int num2;
                                if (int.TryParse(array[k], NumberStyles.Integer, CultureInfo.InvariantCulture.NumberFormat, out num2) && num2 > 0 && num2 <= this.bp.Length)
                                {
                                    this.bp[num2 - 1].Add(text);
                                }
                                else
                                {
                                    if (this.ca == null)
                                    {
                                        this.ca = new List<string>();
                                    }
                                    this.ca.Add(text);
                                }
                            }
                        }
                    }
                }
            }
        }

        public override void b5(hn A_0)
        {
            base.b5(A_0);
            iq a_ = new iq();
            if (!string.IsNullOrEmpty(this.cn) && A_0.ba().bx.ContainsKey(this.cn))
            {
                a_ = A_0.ba().bx[this.cn];
            }
            this.cm = a_;
            Dictionary<string, el> a_2 = new Dictionary<string, el>();
            if (!string.IsNullOrEmpty(this.cl) && A_0.a9().al.ContainsKey(this.cl))
            {
                a_2 = A_0.a9().al[this.cl];
            }
            this.cj = a_2;
            if (this.b2 != null)
            {
                foreach (it current in this.b2)
                {
                    current.i(A_0);
                }
            }
            if (this.bo == EquipmentSlot.MainHand)
            {
                if (this.Fp())
                {
                    base.d2(oe.o(base.fs(), A_0.@as().jo().i(base.f)));
                }
                else
                {
                    base.d2(oe.o(base.fs(), A_0.@as().jo().j(base.f)));
                }
            }
            else if (this.bo == EquipmentSlot.Mount)
            {
                base.d2(oe.o(base.fs(), A_0.@as().jo().l(base.f)));
            }
            else
            {
                base.d2(oe.o(base.fs(), A_0.@as().jo().k(base.f)));
            }
            base.a(A_0);
            if (this.cs != null)
            {
                foreach (string current2 in this.cs)
                {
                    A_0.ax().id(current2);
                }
            }
            if (this.bw > 0)
            {
                this.b6 = new List<g7>[this.bw];
                for (int i = 0; i < this.bw; i++)
                {
                    this.b6[i] = new List<g7>();
                }
            }
            else
            {
                this.b6 = global::e5.br;
            }
            if (this.bx > 0)
            {
                this.b7 = new List<aeh>[this.bx];
                for (int j = 0; j < this.bx; j++)
                {
                    this.b7[j] = new List<aeh>();
                }
            }
            else
            {
                this.b7 = global::e5.bs;
            }
            for (int k = 0; k < Math.Max(this.bw, this.bx); k++)
            {
                if (k < this.bp.Length)
                {
                    foreach (string current3 in this.bp[k])
                    {
                        g6 g = A_0.ap().ib(current3);
                        if (g != null)
                        {
                            if (g is g7)
                            {
                                if (k < this.bw)
                                {
                                    this.b6[k].Add((g7)g);
                                }
                            }
                            else if (k < this.bx)
                            {
                                this.b7[k].Add((aeh)g);
                            }
                        }
                    }
                }
            }
            if (!hn.an())
            {
                this.bp = null;
            }
            this.ca = null;
        }

        public List<string>[] fr()
        {
            return this.bp;
        }

        public float a(afe A_0, oe A_1)
        {
            float num = (float)(A_1.k() / base.fs().k()) * 100f;
            float result = 0f;
            foreach (i0.a current in A_0.jo().n())
            {
                if (num < (float)current.g())
                {
                    break;
                }
                result = current.l();
            }
            return result;
        }

        public float a(float A_0, PlayerAttribute A_1, alw A_2)
        {
            if (A_2 != null && A_2.aq().bh() > 0f && A_0 > A_2.aq().bh() && this.bo != EquipmentSlot.Mount && this.bo != EquipmentSlot.Bag && A_1 != PlayerAttribute.MaxLoad && A_1 != PlayerAttribute.MaxLoadBonus)
            {
                float num = A_2.aq().bi();
                float num2 = A_2.aq().bh();
                A_0 = Math.Min(A_0, num2) + Math.Max((A_0 - num2) * num, 0f);
            }
            return A_0;
        }

        public float d1(PlayerAttribute A_0, afe A_1, alw A_2, afd A_3, List<aeh> A_4, int A_5, oe A_6, float A_7, float A_8, float A_9)
        {
            float num = 0f;
            num += this.A(A_0);
            float num2 = this.cp + A_7 - this.a(A_1, A_6) + A_1.it(A_5);
            num2 = this.a(num2, A_0, A_2);
            num = te.a(A_0, num, A_1, A_3, num2, this.bp);
            if (A_4 != null && A_4.Count > 0)
            {
                if (A_0 == PlayerAttribute.MaxLoad || A_0 == PlayerAttribute.MaxLoadBonus)
                {
                    float a_ = this.d1(PlayerAttribute.AbilityPower, A_1, null, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
                    num += this.a(A_0, A_1, A_4, a_);
                }
                else if (A_0 == PlayerAttribute.AbilityPower)
                {
                    num += this.a(A_0, A_1, A_4, this.co);
                }
                else
                {
                    float a_2 = this.d1(PlayerAttribute.AbilityPower, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
                    num += this.a(A_0, A_1, A_4, a_2);
                }
            }
            return num;
        }

        public float a(PlayerAttribute A_0, afe A_1, List<aeh> A_2, float A_3)
        {
            float num = 0f;
            if (A_2 != null)
            {
                foreach (aeh current in A_2)
                {
                    if (current != null)
                    {
                        foreach (bs current2 in current.j4())
                        {
                            if (current2 is aei && ((aei)current2).ic() == A_0)
                            {
                                num += ((aei)current2).ib();
                            }
                        }
                    }
                }
            }
            return te.a(A_0, num, A_1, A_3, false);
        }

        public override ItemContainerErrorCode b3(bz A_0, bz A_1)
        {
            ItemContainerErrorCode itemContainerErrorCode = base.b3(A_0, A_1);
            if (itemContainerErrorCode != ItemContainerErrorCode.Ok)
            {
                return itemContainerErrorCode;
            }
            if (A_1.b != A_0.b)
            {
                return ItemContainerErrorCode.MergeQualityLevelMismatch;
            }
            return ItemContainerErrorCode.Ok;
        }
    }
}