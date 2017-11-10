using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public static class n8
    {
        public static string a = "EN-US";

        public static string b = n8.a;

        public static string c = n8.b;

        public static Dictionary<string, string> d = new Dictionary<string, string>();

        public static bool e = false;

        public static List<string> f = new List<string>();

        public static List<string> g = new List<string>
    {
        "EN-US",
        "DE-DE",
        "FR-FR",
        "RU-RU",
        "PL-PL",
        "ES-ES",
        "PT-BR"
    };

        [CompilerGenerated]
        private static Comparison<string> h;

        public static List<string> A(string A_0, string A_1, bool A_2)
        {
            return n8.A(ne.B(A_0), A_1, A_2);
        }

        public static List<string> A(Stream A_0, string A_1, bool A_2)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            n8.c = n8.g[0];
            if (n8.g.Contains(A_1))
            {
                n8.c = A_1;
            }
            bool flag = n8.c != n8.a && global::ao_id_extractor.obfClasses.a.l;
            n8.d.Clear();
            n8.f.Clear();
            List<string> list = new List<string>();
            using (XmlReader xmlReader = XmlReader.Create(A_0))
            {
                while (xmlReader.ReadToFollowing("tu"))
                {
                    xmlReader.MoveToAttribute("tuid");
                    string value = xmlReader.Value;
                    string text = value.Trim();
                    xmlReader.MoveToElement();
                    string value2 = "";
                    XmlReader xmlReader2 = xmlReader.ReadSubtree();
                    while (xmlReader2.ReadToFollowing("tuv"))
                    {
                        xmlReader.MoveToAttribute("xml:lang");
                        string value3 = xmlReader.Value;
                        if (flag && value3 == n8.a)
                        {
                            if (xmlReader.ReadToFollowing("seg"))
                            {
                                value2 = xmlReader.ReadString().Trim();
                            }
                        }
                        else if (value3 == n8.c)
                        {
                            if (!xmlReader.ReadToFollowing("seg"))
                            {
                                break;
                            }
                            string text2 = xmlReader.ReadString().Trim();
                            if (text.Length != 0)
                            {
                                try
                                {
                                    if (text2.Length > 0)
                                    {
                                        n8.d.Add(text, text2);
                                    }
                                    else if (flag)
                                    {
                                        n8.d.Add(text, value2);
                                    }
                                    else
                                    {
                                        n8.d.Add(text, string.Empty);
                                    }
                                    break;
                                }
                                catch (ArgumentException)
                                {
                                    ae6.A("Localization Tag '" + text + "' has duplicate entries!");
                                    if (A_2)
                                    {
                                        list.Add(text);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    if (flag && !n8.d.ContainsKey(text) && !string.IsNullOrEmpty(value2))
                    {
                        n8.d.Add(text, value2);
                    }
                }
                n8.e = true;
            }
            if (A_2)
            {
                n8.f = new List<string>(n8.d.Keys);
                List<string> arg_217_0 = n8.f;
                if (n8.h == null)
                {
                    n8.h = new Comparison<string>(n8.A);
                }
                arg_217_0.Sort(n8.h);
            }
            stopwatch.Stop();
            return list;
        }

        public static bool D(string A_0)
        {
            string text;
            return !string.IsNullOrEmpty(A_0) && n8.d.TryGetValue(A_0, out text);
        }

        public static string C(string A_0)
        {
            if (string.IsNullOrEmpty(A_0))
            {
                return string.Empty;
            }
            string text;
            if (!n8.d.TryGetValue(A_0, out text))
            {
                return A_0;
            }
            if (text.Length == 0)
            {
                ae6.A("Localization Tag '" + A_0 + "' is empty!");
                return "LOCA: NT!";
            }
            return text;
        }

        public static string A(string A_0, params object[] A_1)
        {
            if (string.IsNullOrEmpty(A_0))
            {
                return string.Empty;
            }
            string text;
            if (!n8.d.TryGetValue(A_0, out text))
            {
                return A_0;
            }
            if (text.Length == 0)
            {
                ae6.A("Localization Tag '" + A_0 + "' is empty!");
                return "LOCA: NT!";
            }
            try
            {
                text = string.Format(text, A_1);
                return text;
            }
            catch (Exception)
            {
            }
            ae6.A("Localization Tag '" + A_0 + "' has invalid parameters: " + text);
            return "LOCA: PE!";
        }

        public static string A(Enum A_0)
        {
            string a_ = "@" + A_0.GetType().Name.ToUpper() + "_" + A_0.ToString().ToUpper();
            return n8.C(a_);
        }

        public static string B(string A_0)
        {
            if (!string.IsNullOrEmpty(A_0) && A_0.StartsWith("@"))
            {
                return n8.C(A_0);
            }
            return A_0;
        }

        public static string A()
        {
            return "https://albiononline.com/" + n8.c.Substring(0, 2).ToLower() + "/";
        }

        public static string A(string A_0)
        {
            return n8.A() + A_0.TrimStart(new char[]
            {
            '/'
            });
        }

        [CompilerGenerated]
        private static int A(string A_0, string A_1)
        {
            return A_0.CompareTo(A_1);
        }
    }
}