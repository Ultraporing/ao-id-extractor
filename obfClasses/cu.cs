using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class cu
    {
        public static string a = "@";

        protected bx[] b = new bx[4];

        [CompilerGenerated]
        private string c;

        [CompilerGenerated]
        private bx d;

        [CompilerGenerated]
        public string D()
        {
            return this.c;
        }

        [CompilerGenerated]
        protected void D(string A_0)
        {
            this.c = A_0;
        }

        public bx[] E()
        {
            return this.b;
        }

        [CompilerGenerated]
        public bx F()
        {
            return this.d;
        }

        [CompilerGenerated]
        protected void D(bx A_0)
        {
            this.d = A_0;
        }

        public virtual bool D(XmlElement A_0)
        {
            this.D(al5.H(A_0, "uniquename"));
            if (this.F() == null)
            {
                this.D(this.E(A_0));
            }
            if (this.F() == null)
            {
                return false;
            }
            if (!this.F().D3(A_0))
            {
                return false;
            }
            this.b[this.F().H] = this.F();
            return this.D(A_0, this.F());
        }

        protected bx E(XmlElement A_0)
        {
            string name;
            switch (name = A_0.Name)
            {
                case "simpleitem":
                    return new b0(this);
                case "furnitureitem":
                    return new e7(this);
                case "equipmentitem":
                    return new e5(this);
                case "weapon":
                    return new e5(this);
                case "mount":
                    return new e6(this);
                case "farmableitem":
                    return new dr(this);
                case "consumableitem":
                    return new dp(this);
                case "journalitem":
                    return new cv(this);
            }
            return null;
        }

        public bx D(int A_0)
        {
            if (A_0 < 0 || A_0 > 3)
            {
                return null;
            }
            return this.b[A_0];
        }

        protected bool D(XmlElement A_0, bx A_1)
        {
            XmlNodeList elementsByTagName = A_0.GetElementsByTagName("enchantments");
            if (elementsByTagName != null && elementsByTagName.Count > 0)
            {
                foreach (object current in elementsByTagName[0])
                {
                    XmlElement xmlElement = current as XmlElement;
                    if (xmlElement != null)
                    {
                        int num = al5.B(xmlElement, "enchantmentlevel", 0);
                        bx bx;
                        if (this.b[num] != null)
                        {
                            bx = this.b[num];
                            bx.D3(A_0);
                        }
                        else
                        {
                            bx = A_1.Df();
                            this.b[num] = bx;
                        }
                        if (!bx.B4(xmlElement))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return true;
        }

        public void D(hn A_0)
        {
            for (int i = 0; i < this.b.Length; i++)
            {
                bx bx = this.b[i];
                if (bx != null)
                {
                    bx.B5(A_0);
                }
            }
        }

        public static string D(cu A_0, int A_1)
        {
            if (A_1 == 0)
            {
                return A_0.D();
            }
            return A_0.D() + cu.a + A_1.ToString();
        }

        public static cu E(cu A_0)
        {
            cv cv1 = A_0.F() as cv;
            if (cv1 == null)
            {
                return null;
            }
            cu cu1 = new cu();
            cu1.D(cv.B(cv1.D));
            for (int i = 0; i < 4; i++)
            {
                cv cv2 = A_0.b[i] as cv;
                if (cv2 != null)
                {
                    cu1.b[i] = cv.B(cv2, cu1);
                }
            }
            cu1.D(cu1.b[cv1.H]);
            return cu1;
        }

        public static cu D(cu A_0)
        {
            cv cv1 = A_0.F() as cv;
            if (cv1 == null)
            {
                return null;
            }
            cu cu1 = new cu();
            cu1.D(cv.A(cv1.D));
            for (int i = 0; i < 4; i++)
            {
                cv cv2 = A_0.b[i] as cv;
                if (cv2 != null)
                {
                    cu1.b[i] = cv.A(cv2, cu1);
                }
            }
            cu1.D(cu1.b[cv1.H]);
            return cu1;
        }
    }
}