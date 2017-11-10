using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class a
    {
        public static string aa = "";

        public static string b = "";

        public static bool c = false;

        public static bool d = false;

        public static string e = "";

        public static bool f = false;

        public static bool g = false;

        public static bool h = false;

        public static bool i = false;

        public static bool j = true;

        public static bool k = false;

        public static bool l = true;

        public static bool m = true;

        public static int n = -1;

        public static bool o = false;

        public static bool p = true;

        public static bool q = false;

        public static bool r = false;

        public static bool s = false;

        public static string Macro0;

        public static string Macro1;

        public static string Macro2;

        public static string Macro3;

        public static string Macro4;

        public static string Macro5;

        public static string Macro6;

        public static string Macro7;

        public static string Macro8;

        public static string Macro9;

        public static void A()
        {
            try
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                if (folderPath.Length > 0)
                {
                    string text = Path.Combine(folderPath, "Albion");
                    if (!Directory.Exists(text))
                    {
                        Directory.CreateDirectory(text);
                    }
                    text = Path.Combine(text, "settings.xml");
                    if (File.Exists(text))
                    {
                        StreamReader streamReader;
                        try
                        {
                            streamReader = new StreamReader(text);
                        }
                        catch (Exception)
                        {
                            ae6.A("Error loading settings!");
                            return;
                        }
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.LoadXml(streamReader.ReadToEnd());
                        if (xmlDocument.DocumentElement.Name != "settings")
                        {
                            throw new Exception("invalid file format for settings");
                        }
                        XmlNodeList elementsByTagName = xmlDocument.DocumentElement.GetElementsByTagName("setting");
                        Type typeFromHandle = typeof(a);
                        FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.Public);
                        foreach (XmlElement a_ in elementsByTagName)
                        {
                            string text2 = al5.H(a_, "name");
                            string value = al5.H(a_, "value");
                            FieldInfo[] array = fields;
                            for (int i = 0; i < array.Length; i++)
                            {
                                FieldInfo fieldInfo = array[i];
                                try
                                {
                                    if (fieldInfo.Name == text2)
                                    {
                                        if (fieldInfo.FieldType == typeof(string))
                                        {
                                            fieldInfo.SetValue(typeFromHandle, value);
                                        }
                                        else if (fieldInfo.FieldType == typeof(bool))
                                        {
                                            bool flag = bool.Parse(value);
                                            fieldInfo.SetValue(typeFromHandle, flag);
                                        }
                                        else if (fieldInfo.FieldType == typeof(int))
                                        {
                                            int num = int.Parse(value);
                                            fieldInfo.SetValue(typeFromHandle, num);
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    ae6.A("error parsing settings value");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ae6.A(string.Concat(new string[]
                {
                ex.ToString(),
                " ",
                ex.Message,
                " ",
                ex.StackTrace.ToString()
                }));
            }
        }
    }
}