using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class hw : n
    {
        private HashSet<string> bl = new HashSet<string>();

        private Dictionary<string, hv> bm = new Dictionary<string, hv>();

        private Dictionary<int, hv> bn = new Dictionary<int, hv>();

        private Dictionary<string, hx> bo = new Dictionary<string, hx>();

        private Dictionary<int, hx> bp = new Dictionary<int, hx>();

        private Dictionary<string, List<hv>> bq = new Dictionary<string, List<hv>>();

        private Dictionary<string, List<bx>> br = new Dictionary<string, List<bx>>();

        [CompilerGenerated]
        private List<string> bs;

        [CompilerGenerated]
        private static Predicate<string> bt;

        public ICollection<string> ib()
        {
            return this.bo.Keys;
        }

        public ICollection<string> ic()
        {
            return this.bm.Keys;
        }

        public HashSet<string> id()
        {
            return this.bl;
        }

        public Dictionary<string, hv> ie()
        {
            return this.bm;
        }

        public Dictionary<int, hv> @if()
        {
            return this.bn;
        }

        public Dictionary<string, hx> ig()
        {
            return this.bo;
        }

        public Dictionary<int, hx> ih()
        {
            return this.bp;
        }

        [CompilerGenerated]
        public List<string> ii()
        {
            return this.bs;
        }

        [CompilerGenerated]
        private void ib(List<string> A_0)
        {
            this.bs = A_0;
        }

        public hv ic(string A_0)
        {
            if (A_0 == null)
            {
                return null;
            }
            hv result;
            if (this.bm.TryGetValue(A_0, out result))
            {
                return result;
            }
            return null;
        }

        public hv ib(int A_0)
        {
            hv result;
            if (this.bn.TryGetValue(A_0, out result))
            {
                return result;
            }
            return null;
        }

        public hx id(string A_0)
        {
            if (A_0 == null)
            {
                return null;
            }
            hx result;
            if (this.bo.TryGetValue(A_0, out result))
            {
                return result;
            }
            return null;
        }

        public hx ic(int A_0)
        {
            hx result;
            if (this.bp.TryGetValue(A_0, out result))
            {
                return result;
            }
            return null;
        }

        public List<hv> ie(string A_0)
        {
            List<hv> result = null;
            this.bq.TryGetValue(A_0, out result);
            return result;
        }

        public List<bx> @if(string A_0)
        {
            List<bx> result = null;
            this.br.TryGetValue(A_0, out result);
            return result;
        }

        public List<string> ij()
        {
            List<string> arg_28_0 = new List<string>(this.ic());
            if (hw.bt == null)
            {
                hw.bt = new Predicate<string>(hw.ib);
            }
            return arg_28_0.FindAll(hw.bt);
        }

        public bx ib(string A_0, int A_1)
        {
            hx hx = this.id(A_0);
            if (hx != null)
            {
                List<bx> list = this.@if(hx.d());
                if (list != null)
                {
                    foreach (bx current in list)
                    {
                        if (current.U == A_0 && current.F == A_1)
                        {
                            return current;
                        }
                    }
                }
            }
            return null;
        }

        protected override bool Bk(XmlElement A_0)
        {
            if (A_0.Name != "AO-Resources")
            {
                throw new AlbionException("[ResourceData] LoadDataFromXml: XmlTag AO-Resources not found! Invalid Xml File?");
            }
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (!(name == "Harvestables"))
                    {
                        if (name == "Resources")
                        {
                            this.ib(xmlElement);
                        }
                    }
                    else
                    {
                        this.ic(xmlElement);
                    }
                }
            }
            this.ib(new List<string>(this.bo.Keys));
            this.ii().Sort();
            return true;
        }

        private void ic(XmlElement A_0)
        {
            hv.e();
            this.bl.Clear();
            foreach (XmlElement xmlElement in A_0.GetElementsByTagName("Harvestable"))
            {
                string text = al5.a(xmlElement, "name", "");
                if (string.IsNullOrEmpty(text))
                {
                    throw new AlbionException("[GameData] couldn't parse Harvestable element " + xmlElement.Name);
                }
                string a_ = al5.a(xmlElement, "resource", "");
                if (string.IsNullOrEmpty(text))
                {
                    throw new AlbionException("[GameData] couldn't parse Harvestable element " + xmlElement.Name);
                }
                hv hv = new hv(text, a_);
                hv.e(xmlElement);
                this.bm[text] = hv;
                this.bn[hv.h()] = hv;
                if (!text.Contains("SILVERCOINS") && !text.Contains("ESSENCE"))
                {
                    this.bl.Add(text);
                }
                this.bl.Add("MOBCAMP");
            }
        }

        private void ib(XmlElement A_0)
        {
            hx.c();
            foreach (XmlElement a_ in A_0.GetElementsByTagName("Resource"))
            {
                hx hx = new hx();
                hx.c(a_);
                this.bo[hx.d()] = hx;
                this.bp[hx.e()] = hx;
            }
        }

        public void ic(hn A_0)
        {
            this.bq.Clear();
            foreach (hv current in this.bm.Values)
            {
                if (!string.IsNullOrEmpty(current.g()))
                {
                    string key = current.g();
                    if (!this.bq.ContainsKey(key))
                    {
                        this.bq.Add(key, new List<hv>());
                    }
                    this.bq[key].Add(current);
                    if (current.i() != null && current.i().Length > 0)
                    {
                        List<bx> list = new List<bx>();
                        hv.b[] array = current.i();
                        for (int i = 0; i < array.Length; i++)
                        {
                            hv.b b = array[i];
                            if (b != null && !string.IsNullOrEmpty(b.ae()))
                            {
                                cu cu = A_0.Ao().ib(b.ae());
                                if (cu != null)
                                {
                                    list.Add(cu.F());
                                }
                            }
                        }
                        if (list.Count > 0)
                        {
                            List<bx> list2;
                            if (this.br.TryGetValue(key, out list2))
                            {
                                list2.AddRange(list);
                            }
                            else
                            {
                                this.br.Add(key, list);
                            }
                        }
                    }
                }
            }
            this.ib(A_0);
        }

        private void ib(hn A_0)
        {
            Dictionary<int, Dictionary<int, List<int>>> dictionary = new Dictionary<int, Dictionary<int, List<int>>>();
            foreach (KeyValuePair<string, e0> current in A_0.At().ib())
            {
                if (current.Value.el() != null && current.Value.el().p() != null)
                {
                    foreach (ep current2 in current.Value.el().p())
                    {
                        if (current2 is eq)
                        {
                            hv hv = this.ic(((eq)current2).o());
                            Dictionary<int, List<int>> dictionary2 = new Dictionary<int, List<int>>();
                            if (dictionary.TryGetValue(hv.h(), out dictionary2))
                            {
                                List<int> list = new List<int>();
                                if (dictionary2.TryGetValue(((eq)current2).p(), out list))
                                {
                                    list.Add(current.Value.er());
                                }
                                else
                                {
                                    list = new List<int>();
                                    list.Add(current.Value.er());
                                    dictionary2.Add(((eq)current2).p(), list);
                                }
                            }
                            else
                            {
                                dictionary2 = new Dictionary<int, List<int>>();
                                List<int> list2 = new List<int>();
                                list2.Add(current.Value.er());
                                dictionary2.Add(((eq)current2).p(), list2);
                                dictionary.Add(hv.h(), dictionary2);
                            }
                        }
                    }
                }
            }
            foreach (KeyValuePair<int, Dictionary<int, List<int>>> current3 in dictionary)
            {
                foreach (KeyValuePair<int, List<int>> current4 in current3.Value)
                {
                    if (current4.Value.Count == 1)
                    {
                        hv hv2 = this.ib(current3.Key);
                        hv2.i()[current4.Key - 1].af(current4.Value[0]);
                    }
                }
            }
        }

        [CompilerGenerated]
        private static bool ib(string A_0)
        {
            return !A_0.Contains("SILVERCOINS") && !A_0.Contains("ESSENCE");
        }
    }
}