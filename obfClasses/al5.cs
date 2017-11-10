using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class al5
    {
        public static void A<a>(XmlDocument A_0, XmlElement A_1, string A_2, a A_3)
        {
            al5.A(A_0, A_1, A_2, A_3.ToString());
        }

        public static a A<a>(XmlElement A_0, string A_1, a A_2)
        {
            a result;
            try
            {
                Type typeFromHandle = typeof(a);
                if (alg.a)
                {
                    typeFromHandle.GetCustomAttributes(typeof(ObfuscationAttribute), false);
                }
                result = (a)((object)Enum.Parse(typeFromHandle, al5.A(A_0, A_1, A_2.ToString()), true));
            }
            catch (Exception)
            {
                result = A_2;
            }
            return result;
        }

        // al5
        public static string A(XmlElement A_0, string A_1, string A_2)
        {
            if (A_0.HasAttribute(A_1))
            {
                return A_0.Attributes[A_1].InnerText;
            }
            return A_2;
        }

        // al5
        public static float A(XmlElement A_0, string A_1, float A_2)
        {
            if (A_0.HasAttribute(A_1))
            {
                return al5.A(A_0.Attributes[A_1].InnerText, A_2);
            }
            return A_2;
        }

        // al5
        public static float A(string A_0, float A_1)
        {
            float result;
            if (float.TryParse(A_0, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out result))
            {
                return result;
            }
            return A_1;
        }

        // al5
        public static bool A(XmlElement A_0, string A_1, bool A_2)
        {
            if (A_0.HasAttribute(A_1))
            {
                return al5.A(A_0.Attributes[A_1].InnerText);
            }
            return A_2;
        }

        // al5
        public static bool A(string A_0)
        {
            return A_0 == "true" || A_0 == "True" || A_0 == "TRUE" || A_0 == "yes" || A_0 == "1";
        }

        // al5
        private static float A(string A_0, int A_1, float A_2)
        {
            string[] array = A_0.Split(new char[]
            {
        '.'
            }, StringSplitOptions.RemoveEmptyEntries);
            string s = string.Empty;
            int num;
            if (array.Length == 2)
            {
                if (array[1].Length > A_1)
                {
                    array[1] = array[1].Substring(0, A_1);
                }
                num = array[1].Length;
                s = array[0] + array[1];
            }
            else
            {
                if (array.Length != 1)
                {
                    return A_2;
                }
                s = array[0];
                num = 0;
            }
            int num2;
            if (!int.TryParse(s, out num2))
            {
                return A_2;
            }
            int num3 = 1;
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    num3 *= 10;
                }
            }
            return (float)num2 / (float)num3;
        }

        // al5
        public static void A(string A_0, ref int A_1, ref int A_2)
        {
            string[] array = A_0.Split(new string[]
            {
        " "
            }, StringSplitOptions.RemoveEmptyEntries);
            A_1 = int.Parse(array[0], CultureInfo.InvariantCulture.NumberFormat);
            A_2 = int.Parse(array[1], CultureInfo.InvariantCulture.NumberFormat);
        }

        // al5
        public static int A(string A_0, int A_1)
        {
            int result;
            if (int.TryParse(A_0, NumberStyles.Integer, CultureInfo.InvariantCulture.NumberFormat, out result))
            {
                return result;
            }
            return A_1;
        }

        // al5
        public static void A(XmlElement A_0, string A_1, ref oe[] A_2)
        {
            foreach (object current in A_0)
            {
                XmlElement xmlElement = current as XmlElement;
                if (xmlElement != null)
                {
                    int num = al5.B(xmlElement, "tier", -1);
                    if (num >= 0 && num <= 8)
                    {
                        oe oe = al5.B(xmlElement, A_1, oe.j);
                        A_2[num] = oe;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
            }
        }

        // al5
        public static void A(XmlElement A_0, string A_1, ref oe[] A_2, oe A_3)
        {
            foreach (object current in A_0)
            {
                XmlElement xmlElement = current as XmlElement;
                if (xmlElement != null)
                {
                    int num = al5.B(xmlElement, "tier", -1);
                    if (num > 0 && num <= 8)
                    {
                        oe oe = al5.C(xmlElement, A_1, A_3);
                        A_2[num - 1] = oe;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
            }
        }

        // al5
        public static void A(XmlDocument A_0, XmlElement A_1, string A_2, string A_3)
        {
            A_1.Attributes.Append(A_0.CreateAttribute(A_2)).InnerText = A_3;
        }

        // al5
        public static int B(XmlElement A_0, string A_1, int A_2)
        {
            if (A_0.HasAttribute(A_1))
            {
                return al5.A(A_0.Attributes[A_1].InnerText, A_2);
            }
            return A_2;
        }

        // al5
        public static ald B(XmlElement A_0, string A_1, ald A_2)
        {
            float num;
            if (A_0.HasAttribute(A_1) && float.TryParse(A_0.Attributes[A_1].InnerText, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out num))
            {
                return ald.N((double)num);
            }
            return A_2;
        }

        // al5
        public static void B(XmlDocument A_0, XmlElement A_1, string A_2, oe A_3)
        {
            al5.A(A_0, A_1, A_2, A_3.H().ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        // al5
        public static oe B(XmlElement A_0, string A_1, oe A_2)
        {
            if (A_0.HasAttribute(A_1))
            {
                return oe.F(long.Parse(A_0.Attributes[A_1].InnerText, CultureInfo.InvariantCulture.NumberFormat));
            }
            return A_2;
        }

        // al5
        public static void B(XmlElement A_0, string A_1, ref oe[] A_2)
        {
            al5.A(A_0, A_1, ref A_2, oe.j);
        }

        // al5
        public static void B(XmlElement A_0, string A_1)
        {
            XmlElement xmlElement = al5.C(A_0, A_1);
            if (xmlElement != null)
            {
                A_0.RemoveChild(xmlElement);
            }
        }

        // al5
        public static ald C(XmlElement A_0, string A_1, ald A_2)
        {
            float num;
            if (A_0.HasAttribute(A_1) && float.TryParse(A_0.Attributes[A_1].InnerText, NumberStyles.Float, CultureInfo.InvariantCulture.NumberFormat, out num))
            {
                return ald.M((double)num);
            }
            return A_2;
        }

        // al5
        public static void C(XmlDocument A_0, XmlElement A_1, string A_2, oe A_3)
        {
            al5.A(A_0, A_1, A_2, A_3.K().ToString(CultureInfo.InvariantCulture.NumberFormat));
        }

        // al5
        public static oe C(XmlElement A_0, string A_1, oe A_2)
        {
            if (A_0.HasAttribute(A_1))
            {
                return oe.E(double.Parse(A_0.Attributes[A_1].InnerText, CultureInfo.InvariantCulture.NumberFormat));
            }
            return A_2;
        }

        // al5
        public static void C(XmlElement A_0, string A_1, ref oe[] A_2)
        {
            foreach (object current in A_0)
            {
                XmlElement xmlElement = current as XmlElement;
                if (xmlElement != null)
                {
                    int num = al5.B(xmlElement, "tier", -1);
                    if (num > 0 && num <= 8)
                    {
                        oe oe = al5.C(xmlElement, A_1, oe.j);
                        A_2[num - 1] = oe;
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
            }
        }

        // al5
        public static XmlElement C(XmlElement A_0, string A_1)
        {
            List<XmlElement> list = al5.D(A_0, A_1);
            if (list != null && list.Count > 0)
            {
                return list[0];
            }
            return null;
        }

        // al5
        public static List<XmlElement> D(XmlElement A_0, string A_1)
        {
            List<XmlElement> list = null;
            foreach (object current in A_0)
            {
                XmlElement xmlElement = current as XmlElement;
                if (xmlElement != null && xmlElement.Name == A_1)
                {
                    if (list == null)
                    {
                        list = new List<XmlElement>();
                    }
                    list.Add(xmlElement);
                }
            }
            return list;
        }

        // al5
        public static string H(XmlElement A_0, string A_1)
        {
            return al5.A(A_0, A_1, string.Empty);
        }

        // al5
        public static bool I(XmlElement A_0, string A_1)
        {
            return A_0.HasAttribute(A_1);
        }
    }

}