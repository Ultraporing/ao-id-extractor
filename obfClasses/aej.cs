using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class aej : n
    {
        [Flags]
        public enum Placeability : byte
        {
            Nowhere = 0,
            Indoor = 1,
            Outdoor = 2,
            Dungeons = 4,
            Everywhere = 7
        }

        protected Dictionary<string, cu> b8 = new Dictionary<string, cu>();

        protected Dictionary<int, bx> b9 = new Dictionary<int, bx>();

        protected Dictionary<string, bx> ca = new Dictionary<string, bx>();

        protected Dictionary<string, bx> cb = new Dictionary<string, bx>();

        protected Dictionary<string, cu> cc = new Dictionary<string, cu>();

        protected Dictionary<string, HashSet<string>> cd = new Dictionary<string, HashSet<string>>();

        protected HashSet<string> ce = new HashSet<string>();

        [CompilerGenerated]
        private List<string> cf;

        [CompilerGenerated]
        public List<string> Ib()
        {
            return this.cf;
        }

        [CompilerGenerated]
        private void Ib(List<string> A_0)
        {
            this.cf = A_0;
        }

        public ICollection<cu> Ic()
        {
            return this.b8.Values;
        }

        public ICollection<bx> Id()
        {
            return this.ca.Values;
        }

        public ICollection<bx> Ie()
        {
            return this.cb.Values;
        }

        public ICollection<cu> Iff()
        {
            return this.cc.Values;
        }

        public ICollection<string> Ig()
        {
            return this.b8.Keys;
        }

        public HashSet<string> Ih()
        {
            return this.ce;
        }

        public Dictionary<string, HashSet<string>> Ii()
        {
            return this.cd;
        }

        public cu Ib(string A_0)
        {
            if (string.IsNullOrEmpty(A_0))
            {
                return null;
            }
            cu result = null;
            this.b8.TryGetValue(A_0, out result);
            return result;
        }

        public bx Ic(string A_0)
        {
            bx result;
            if (this.ca.TryGetValue(A_0, out result))
            {
                return result;
            }
            return null;
        }

        public bx Ib(int A_0)
        {
            bx result;
            if (this.b9.TryGetValue(A_0, out result))
            {
                return result;
            }
            return null;
        }

        public bx Ib(string A_0, int A_1)
        {
            if (string.IsNullOrEmpty(A_0) || A_1 < 0 || A_1 > 3)
            {
                return null;
            }
            cu cu;
            if (this.b8.TryGetValue(A_0, out cu))
            {
                return cu.E()[A_1];
            }
            return null;
        }

        public bx Id(string A_0)
        {
            if (string.IsNullOrEmpty(A_0))
            {
                return null;
            }
            bx result = null;
            this.ca.TryGetValue(A_0, out result);
            return result;
        }

        public static bool Ib(bx A_0)
        {
            return A_0.Ab && !A_0.J.EndsWith("_PROTOTYPE");
        }

        public e5 Ic(int A_0)
        {
            return this.Ib(A_0) as e5;
        }

        public e5 Ic(string A_0, int A_1)
        {
            return this.Ib(A_0, A_1) as e5;
        }

        public b0 Id(int A_0)
        {
            return this.Ib(A_0) as b0;
        }

        public b0 Id(string A_0, int A_1)
        {
            return this.Ib(A_0, A_1) as b0;
        }

        public e7 Ie(int A_0)
        {
            return this.Ib(A_0) as e7;
        }

        public e7 Ie(string A_0, int A_1)
        {
            return this.Ib(A_0, A_1) as e7;
        }

        public dr Iff(int A_0)
        {
            return this.Ib(A_0) as dr;
        }

        public dr Iff(string A_0, int A_1)
        {
            return this.Ib(A_0, A_1) as dr;
        }

        public dp Ig(int A_0)
        {
            return this.Ib(A_0) as dp;
        }

        public dp Ig(string A_0, int A_1)
        {
            return this.Ib(A_0, A_1) as dp;
        }

        public void Ij()
        {
            foreach (cu current in this.b8.Values)
            {
                bx bx = current.F();
                string key = bx.P.ToLower();
                string item = bx.Q.ToLower();
                if (this.cd.ContainsKey(key))
                {
                    this.cd[key].Add(item);
                }
                else
                {
                    HashSet<string> hashSet = new HashSet<string>();
                    hashSet.Add(item);
                    this.cd.Add(key, hashSet);
                }
                if (bx.P == "resources")
                {
                    this.ce.Add(bx.D);
                }
            }
        }

        public void Ib(hn A_0)
        {
            List<cu> list = new List<cu>(A_0.Ao().b8.Values);
            foreach (cu current in list)
            {
                if (current.F() is cv)
                {
                    this.Ib(current);
                    this.Ic(current);
                }
            }
            foreach (cu current2 in this.b8.Values)
            {
                current2.D(A_0);
            }
        }

        protected void Ib(cu A_0)
        {
            if (A_0.D().EndsWith(cv.ao) || A_0.D().EndsWith(cv.ap))
            {
                return;
            }
            string key = cv.B(A_0.D());
            cu cu = null;
            if (this.b8.TryGetValue(key, out cu))
            {
                bx[] array = cu.E();
                for (int i = 0; i < array.Length; i++)
                {
                    bx bx = array[i];
                    cv cv = bx as cv;
                    if (cv != null)
                    {
                        cv.D6();
                    }
                }
                return;
            }
            cu = cu.E(A_0);
            bx[] array2 = cu.E();
            for (int j = 0; j < array2.Length; j++)
            {
                bx a_ = array2[j];
                this.Ic(a_);
            }
            this.b8.ContainsKey(cu.D());
            this.b8[cu.D()] = cu;
        }

        protected void Ic(cu A_0)
        {
            if (A_0.D().EndsWith(cv.ao) || A_0.D().EndsWith(cv.ap))
            {
                return;
            }
            string key = cv.A(A_0.D());
            cu cu = null;
            if (this.b8.TryGetValue(key, out cu))
            {
                bx[] array = cu.E();
                for (int i = 0; i < array.Length; i++)
                {
                    bx bx = array[i];
                    cv cv = bx as cv;
                    if (cv != null)
                    {
                        cv.D6();
                    }
                }
                return;
            }
            cu = cu.D(A_0);
            bx[] array2 = cu.E();
            for (int j = 0; j < array2.Length; j++)
            {
                bx a_ = array2[j];
                this.Ic(a_);
            }
            this.b8.ContainsKey(cu.D());
            this.b8[cu.D()] = cu;
        }

        protected override bool Bk(XmlElement A_0)
        {
            bx.D1();
            return this.Ib(A_0, false);
        }

        protected override bool Ct(XmlElement A_0)
        {
            return this.Ib(A_0, true);
        }

        private bool Ib(XmlElement A_0, bool A_1)
        {
            if (A_0.Name != "items")
            {
                throw new Exception("[ItemData] LoadDataFromXml: XmlTag 'items' not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                if (xmlElement != null)
                {
                    cu cu = null;
                    string text = al5.H(xmlElement, "uniquename");
                    if (A_1 && this.b8.TryGetValue(text, out cu))
                    {
                        cu.D(xmlElement);
                        if (text != cu.D())
                        {
                            this.b8.Remove(text);
                            this.b8.ContainsKey(cu.D());
                            this.b8[cu.D()] = cu;
                        }
                        bx[] array = cu.E();
                        for (int i = 0; i < array.Length; i++)
                        {
                            bx bx = array[i];
                            if (bx != null)
                            {
                                if (!this.b9.ContainsKey(bx.C) || this.b9[bx.C] != bx)
                                {
                                    this.b9[bx.C] = bx;
                                }
                                if (!this.ca.ContainsKey(bx.D) || this.ca[bx.D] != bx)
                                {
                                    this.ca[bx.D] = bx;
                                }
                            }
                        }
                    }
                    else
                    {
                        cu = new cu();
                        cu.D(xmlElement);
                        this.b8.ContainsKey(cu.D());
                        this.b8[cu.D()] = cu;
                        bx[] array2 = cu.E();
                        for (int j = 0; j < array2.Length; j++)
                        {
                            bx a_ = array2[j];
                            this.Ic(a_);
                        }
                    }
                }
            }
            this.Ij();
            this.Ib(new List<string>(this.cc.Keys));
            this.Ib().Sort();
            return true;
        }

        protected void Ic(bx A_0)
        {
            if (A_0 == null)
            {
                return;
            }
            this.b9.ContainsKey(A_0.C);
            this.b9[A_0.C] = A_0;
            this.ca.ContainsKey(A_0.D);
            this.ca[A_0.D] = A_0;
            if (aej.Ib(A_0))
            {
                this.cb.ContainsKey(A_0.D);
                this.cb[A_0.D] = A_0;
                if (!this.cc.ContainsKey(A_0.J))
                {
                    cu cu = A_0.I;
                    this.cc.Add(cu.D(), cu);
                    return;
                }
            }
            else
            {
                if (this.cb.ContainsKey(A_0.D))
                {
                    this.cb.Remove(A_0.D);
                }
                if (this.cc.ContainsKey(A_0.J))
                {
                    this.cc.Remove(A_0.J);
                }
            }
        }

        public e5 Ib(hv A_0, int A_1, int A_2)
        {
            e5 e = null;
            foreach (cu current in this.b8.Values)
            {
                for (int i = 0; i < 4; i++)
                {
                    e5 e2 = current.E()[i] as e5;
                    if (e2 != null && e2.Bo == EquipmentSlot.MainHand && e2.d6(A_0.g()) && A_0.e(A_1, e2.f, A_2) && (e == null || e2.f < e.f || (e2.f == e.f && e2.h < e.h)))
                    {
                        e = e2;
                    }
                }
            }
            return e;
        }
    }
}
