using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class hx
    {
        private oe[] a = new oe[8];

        private oe[] b = new oe[8];

        private static int c;

        private string d;

        private int e;

        public string D()
        {
            return this.d;
        }

        private void C(string A_0)
        {
            this.d = A_0;
        }

        public int E()
        {
            return this.e;
        }

        private void C(int A_0)
        {
            this.e = A_0;
        }

        public static void C()
        {
            hx.c = 0;
        }

        public hx()
        {
            this.C(hx.c++);
        }

        public oe D(int A_0)
        {
            return this.a[A_0 - 1];
        }

        public oe E(int A_0)
        {
            return this.b[A_0 - 1];
        }

        public void C(XmlElement A_0)
        {
            this.C(al5.A(A_0, "name", string.Empty));
            if (string.IsNullOrEmpty(this.D()))
            {
                throw new Exception("[GameData] couldn't parse Resource element " + A_0.Name);
            }
            foreach (XmlElement a_ in A_0.GetElementsByTagName("ResourceTier"))
            {
                int num = al5.B(a_, "value", 0);
                int num2 = num - 1;
                this.a[num2] = al5.c(a_, "resourcevalue", oe.j);
                this.b[num2] = al5.c(a_, "famevalue", oe.j);
            }
        }
    }
}