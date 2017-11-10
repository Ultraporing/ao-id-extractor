using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class cv : by
    {
        public new class aa
        {
            public oe a;

            public int b;

            public string c;

            public int d;

            public bx e;

            public int f;

            public oe g;
        }

        public new static string ao = "_EMPTY";

        public new static string ap = "_FULL";

        protected cv aq;

        [CompilerGenerated]
        private oe ar;

        [CompilerGenerated]
        private float Ass;

        [CompilerGenerated]
        private List<s> at;

        [CompilerGenerated]
        private List<cv.aa> au;

        [CompilerGenerated]
        private int av;

        [CompilerGenerated]
        private static Comparison<cv.aa> aw;

        [CompilerGenerated]
        public oe D1()
        {
            return this.ar;
        }

        [CompilerGenerated]
        private void A(oe A_0)
        {
            this.ar = A_0;
        }

        [CompilerGenerated]
        public float D2()
        {
            return this.Ass;
        }

        [CompilerGenerated]
        private void A(float A_0)
        {
            this.Ass = A_0;
        }

        [CompilerGenerated]
        public List<s> D3()
        {
            return this.at;
        }

        [CompilerGenerated]
        private void A(List<s> A_0)
        {
            this.at = A_0;
        }

        [CompilerGenerated]
        public List<cv.aa> D4()
        {
            return this.au;
        }

        [CompilerGenerated]
        private void A(List<cv.aa> A_0)
        {
            this.au = A_0;
        }

        [CompilerGenerated]
        public int D5()
        {
            return this.av;
        }

        [CompilerGenerated]
        private void A(int A_0)
        {
            this.av = A_0;
        }

        public cv(cu A_0) : base(A_0)
        {
            this.A(oe.g);
            this.A(-1f);
            base.Ab = false;
        }

        public static cv B(cv A_0, cu A_1)
        {
            cv cv = new cv(A_1);
            cv.c = bx.c++;
            cv.aq = A_0;
            cv.d = A_0.D7();
            cv.D6();
            cv.Ab = true;
            return cv;
        }

        public static cv A(cv A_0, cu A_1)
        {
            cv cv = new cv(A_1);
            cv.c = bx.c++;
            cv.aq = A_0;
            cv.d = A_0.D9();
            cv.D6();
            cv.Ab = true;
            return cv;
        }

        public static oe A(cv A_0)
        {
            if (A_0.D.EndsWith(cv.ap))
            {
                return A_0.D1();
            }
            if (A_0.D.EndsWith(cv.ao))
            {
                return oe.g;
            }
            return oe.h;
        }

        public void D6()
        {
            cv cv = this.aq;
            string a_ = base.D;
            cu a_2 = base.I;
            int a_3 = base.C;
            if (this.aq != null)
            {
                cv.A<cv>(this.aq, this);
            }
            base.C = a_3;
            this.aq = cv;
            base.D = a_;
            base.I = a_2;
            base.Am = bx.B(base.D);
            base.An = bx.B(base.D);
            base.Ai = cv.Ai;
            if (base.J.EndsWith(cv.ap))
            {
                base.Ai += cv.ap;
                return;
            }
            if (base.J.EndsWith(cv.ao))
            {
                base.Ai += cv.ao;
            }
        }

        private static void A<a>(a A_0, a A_1)
        {
            for (Type type = typeof(a); type != null; type = type.BaseType)
            {
                cv.A<a>(type, A_0, A_1);
            }
        }

        private static void A<a>(Type A_0, a A_1, a A_2)
        {
            FieldInfo[] fields = A_0.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            FieldInfo[] array = fields;
            for (int i = 0; i < array.Length; i++)
            {
                FieldInfo fieldInfo = array[i];
                fieldInfo.SetValue(A_2, fieldInfo.GetValue(A_1));
            }
        }

        public string D7()
        {
            string a_ = base.D;
            if (this.aq != null)
            {
                a_ = this.aq.D;
            }
            return cv.B(a_);
        }

        public new static string B(string A_0)
        {
            int num = A_0.IndexOf(cu.a);
            if (num >= 0)
            {
                return A_0.Insert(num, cv.ao);
            }
            return A_0 + cv.ao;
        }

        public string D8()
        {
            if (this.aq != null)
            {
                return this.aq.D;
            }
            return base.D;
        }

        public string D9()
        {
            string a_ = base.D;
            if (this.aq != null)
            {
                a_ = this.aq.D;
            }
            return cv.A(a_);
        }

        public new static string A(string A_0)
        {
            int num = A_0.IndexOf(cu.a);
            if (num >= 0)
            {
                return A_0.Insert(num, cv.ap);
            }
            return A_0 + cv.ap;
        }

        public cv.aa A(oa A_0)
        {
            if (this.D4() != null)
            {
                float num = (float)A_0.A(0.0, (double)this.D5());
                float num2 = 0f;
                foreach (cv.aa current in this.D4())
                {
                    num2 += (float)current.b;
                    if (num <= num2)
                    {
                        return current;
                    }
                }
            }
            return null;
        }

        public override bool B4(XmlElement A_0)
        {
            base.B4(A_0);
            this.A(al5.B(A_0, "maxfame", this.D1()));
            this.A(al5.A(A_0, "baselootamount", this.D2()));
            this.B(A_0);
            this.A(A_0);
            return true;
        }

        private void B(XmlElement A_0)
        {
            List<XmlElement> list = al5.D(A_0, "famefillingmissions");
            if (list == null || list.Count == 0)
            {
                return;
            }
            XmlElement xmlElement = list[0];
            if (xmlElement == null)
            {
                return;
            }
            this.A(new List<s>(xmlElement.ChildNodes.Count));
            foreach (object current in xmlElement)
            {
                XmlElement xmlElement2 = current as XmlElement;
                if (xmlElement2 != null)
                {
                    s s1 = s.Bo(xmlElement2.Name, this);
                    s1.Bl(xmlElement2);
                    this.D3().Add(s1);
                }
            }
        }

        private void A(XmlElement A_0)
        {
            List<XmlElement> list = al5.D(A_0, "lootlist");
            if (list == null || list.Count == 0)
            {
                return;
            }
            XmlElement xmlElement = list[0];
            if (xmlElement == null)
            {
                return;
            }
            this.A(0);
            this.A(new List<cv.aa>(xmlElement.ChildNodes.Count));
            foreach (object current in xmlElement)
            {
                XmlElement xmlElement2 = current as XmlElement;
                if (xmlElement2 != null)
                {
                    cv.aa a = new cv.aa
                    {
                        b = al5.B(xmlElement2, "weight", 0),
                        a = al5.C(xmlElement2, "labourerfame", oe.g),
                        c = al5.A(xmlElement2, "itemname", null),
                        d = al5.B(xmlElement2, "itemenchantmentlevel", 0),
                        f = al5.B(xmlElement2, "itemamount", 0),
                        g = al5.C(xmlElement2, "silveramount", oe.g)
                    };
                    this.D4().Add(a);
                    this.A(this.D5() + a.b);
                }
            }
            List<cv.aa> arg_14F_0 = this.D4();
            if (cv.aw == null)
            {
                cv.aw = new Comparison<cv.aa>(cv.A);
            }
            arg_14F_0.Sort(cv.aw);
        }

        public override void B5(hn A_0)
        {
            base.B5(A_0);
            if (this.D4() != null)
            {
                foreach (cv.aa current in this.D4())
                {
                    if (!string.IsNullOrEmpty(current.c))
                    {
                        current.e = A_0.Ao().Ib(current.c, current.d);
                    }
                }
            }
        }

        public override ItemContainerErrorCode B3(bz A_0, bz A_1)
        {
            ItemContainerErrorCode itemContainerErrorCode = base.B3(A_0, A_1);
            if (itemContainerErrorCode != ItemContainerErrorCode.Ok)
            {
                return itemContainerErrorCode;
            }
            if (A_0.c.l != 0L && A_0.c.l < this.D1().l)
            {
                return ItemContainerErrorCode.MergeFameOnlyFullOrEmpty;
            }
            if (oe.K(A_1.c, A_0.c))
            {
                return ItemContainerErrorCode.MergeFameMismatch;
            }
            return ItemContainerErrorCode.Ok;
        }

        [CompilerGenerated]
        private static int A(cv.aa A_0, cv.aa A_1)
        {
            return A_0.b.CompareTo(A_1.b);
        }
    }
}