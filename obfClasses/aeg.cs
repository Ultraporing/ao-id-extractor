using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class aeg
    {
        public class aa
        {
            public string a = string.Empty;

            public int b;

            public int c = 1;

            public int d = 1;

            public bool e = true;
        }

        private bool a;

        [CompilerGenerated]
        private float b;

        [CompilerGenerated]
        private oe c;

        [CompilerGenerated]
        private oe d;

        [CompilerGenerated]
        private oe e;

        [CompilerGenerated]
        private List<aeg.aa> f;

        [CompilerGenerated]
        private int g;

        [CompilerGenerated]
        private bool h;

        [CompilerGenerated]
        private bool i;

        [CompilerGenerated]
        private bool j;

        [CompilerGenerated]
        private int k;

        [CompilerGenerated]
        private bool l;

        [CompilerGenerated]
        public float L()
        {
            return this.b;
        }

        [CompilerGenerated]
        private void L(float A_0)
        {
            this.b = A_0;
        }

        [CompilerGenerated]
        public oe M()
        {
            return this.c;
        }

        [CompilerGenerated]
        private void N(oe A_0)
        {
            this.c = A_0;
        }

        [CompilerGenerated]
        public oe N()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void M(oe A_0)
        {
            this.d = A_0;
        }

        [CompilerGenerated]
        public oe O()
        {
            return this.e;
        }

        [CompilerGenerated]
        private void L(oe A_0)
        {
            this.e = A_0;
        }

        [CompilerGenerated]
        public List<aeg.aa> P()
        {
            return this.f;
        }

        [CompilerGenerated]
        private void L(List<aeg.aa> A_0)
        {
            this.f = A_0;
        }

        [CompilerGenerated]
        public int Q()
        {
            return this.g;
        }

        [CompilerGenerated]
        private void M(int A_0)
        {
            this.g = A_0;
        }

        [CompilerGenerated]
        public bool R()
        {
            return this.h;
        }

        [CompilerGenerated]
        private void O(bool A_0)
        {
            this.h = A_0;
        }

        [CompilerGenerated]
        public bool S()
        {
            return this.i;
        }

        [CompilerGenerated]
        private void N(bool A_0)
        {
            this.i = A_0;
        }

        [CompilerGenerated]
        public bool T()
        {
            return this.j;
        }

        [CompilerGenerated]
        private void M(bool A_0)
        {
            this.j = A_0;
        }

        [CompilerGenerated]
        public int U()
        {
            return this.k;
        }

        [CompilerGenerated]
        private void L(int A_0)
        {
            this.k = A_0;
        }

        [CompilerGenerated]
        public bool V()
        {
            return this.l;
        }

        [CompilerGenerated]
        private void L(bool A_0)
        {
            this.l = A_0;
        }

        public virtual bool L(XmlElement A_0)
        {
            this.N(al5.B(A_0, "silver", oe.g));
            this.M(al5.B(A_0, "gold", oe.g));
            this.L(al5.A(A_0, "time", 0f));
            this.M(al5.B(A_0, "amountcrafted", 1));
            this.O(al5.A(A_0, "forcesinglecraft", false));
            this.N(al5.A(A_0, "payonlywithgold", false));
            this.M(al5.A(A_0, "swaptransaction", true));
            this.L(al5.B(A_0, "craftingfocus", 0));
            this.L(al5.B(A_0, "silverinrvpercentage", oe.j));
            if (oe.K(this.O(), oe.j))
            {
                this.a = true;
                this.L(oe.O(this.O(), oe.E(0.0099999997764825821)));
                this.N(oe.g);
            }
            XmlNodeList elementsByTagName = A_0.GetElementsByTagName("craftresource");
            this.L(new List<aeg.aa>(elementsByTagName.Count));
            foreach (XmlNode xmlNode in elementsByTagName)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                if (xmlElement != null)
                {
                    aeg.aa a = new aeg.aa
                    {
                        a = al5.H(xmlElement, "uniquename"),
                        b = al5.B(xmlElement, "enchantmentlevel", 0),
                        c = al5.B(xmlElement, "count", 0),
                        d = al5.B(xmlElement, "maxreturnamount", 2147483647),
                        e = al5.A(xmlElement, "usedinrepair", true)
                    };
                    a.d = Math.Min(a.d, a.c);
                    this.P().Add(a);
                }
            }
            this.L(false);
            for (int i = 0; i < this.P().Count; i++)
            {
                aeg.aa a2 = this.P()[i];
                if (a2.d > 0)
                {
                    this.L(true);
                    break;
                }
            }
            if (this.U() > 0 && !this.V())
            {
                this.L(0);
            }
            return true;
        }

        public int L(string A_0)
        {
            foreach (aeg.aa current in this.P())
            {
                if (current.a == A_0)
                {
                    return current.c;
                }
            }
            return 0;
        }

        public void L(oe A_0, hn A_1)
        {
            if (!this.a)
            {
                return;
            }
            oe a_ = A_1.Ass().io(A_0);
            oe a_2 = A_1.Ass().im(a_);
            if (this.O().l == 10000L)
            {
                this.N(a_2);
            }
            else if (this.O().l == 0L)
            {
                this.N(oe.g);
            }
            else
            {
                this.N(oe.O(a_2, this.O()));
            }
            this.N(this.M().N());
        }
    }
}