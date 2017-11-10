using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class b1
    {
        public class aa
        {
            public string a = string.Empty;

            public int b;

            public int c = 1;
        }

        [CompilerGenerated]
        private float a;

        [CompilerGenerated]
        private oe b;

        [CompilerGenerated]
        private oe c;

        [CompilerGenerated]
        private List<b1.aa> d;

        [CompilerGenerated]
        private bool e;

        [CompilerGenerated]
        public float F()
        {
            return this.a;
        }

        [CompilerGenerated]
        private void F(float A_0)
        {
            this.a = A_0;
        }

        [CompilerGenerated]
        public oe G()
        {
            return this.b;
        }

        [CompilerGenerated]
        private void G(oe A_0)
        {
            this.b = A_0;
        }

        [CompilerGenerated]
        public oe H()
        {
            return this.c;
        }

        [CompilerGenerated]
        private void F(oe A_0)
        {
            this.c = A_0;
        }

        [CompilerGenerated]
        public List<b1.aa> I()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void F(List<b1.aa> A_0)
        {
            this.d = A_0;
        }

        [CompilerGenerated]
        public bool J()
        {
            return this.e;
        }

        [CompilerGenerated]
        private void F(bool A_0)
        {
            this.e = A_0;
        }

        public virtual bool F(XmlElement A_0)
        {
            this.G(al5.B(A_0, "silver", oe.g));
            this.F(al5.B(A_0, "gold", oe.g));
            this.F(al5.A(A_0, "time", 0f));
            this.F(al5.A(A_0, "swaptransaction", true));
            XmlNodeList elementsByTagName = A_0.GetElementsByTagName("upgraderesource");
            this.F(new List<b1.aa>(elementsByTagName.Count));
            foreach (XmlNode xmlNode in elementsByTagName)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                if (xmlElement != null)
                {
                    b1.aa item = new b1.aa
                    {
                        a = al5.H(xmlElement, "uniquename"),
                        b = al5.B(xmlElement, "enchantmentlevel", 0),
                        c = al5.B(xmlElement, "count", 0)
                    };
                    this.I().Add(item);
                }
            }
            return true;
        }

        public int F(string A_0)
        {
            foreach (b1.aa current in this.I())
            {
                if (current.a == A_0)
                {
                    return current.c;
                }
            }
            return 0;
        }
    }
}