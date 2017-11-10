using System;
using System.Collections.Generic;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class ci
    {
        public struct SoundEventEntry
        {
            public cg WwiseEvent
            {
                get;
                set;
            }

            public bool BPlayImpact
            {
                get;
                set;
            }

            public cg OverrideImpactType
            {
                get;
                set;
            }
        }

        public Dictionary<string, ci.SoundEventEntry> a = new Dictionary<string, ci.SoundEventEntry>();

        public static ci C(XmlElement A_0)
        {
            ci ci = new ci();
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                if (xmlElement != null)
                {
                    ci.SoundEventEntry value = ci.B(xmlElement);
                    ci.a.Add(xmlElement.Name, value);
                }
            }
            return ci;
        }

        public static ci.SoundEventEntry B(XmlElement A_0)
        {
            ci.SoundEventEntry result = default(ci.SoundEventEntry);
            result.BPlayImpact = false;
            if (al5.I(A_0, "name"))
            {
                result.WwiseEvent = new cg(cg.aa.a, null, al5.A(A_0, "name", ""));
                XmlNodeList childNodes = A_0.ChildNodes;
                foreach (object current in childNodes)
                {
                    XmlElement xmlElement = (XmlElement)current;
                    if (xmlElement.Name == "ImpactType")
                    {
                        result.BPlayImpact = true;
                        if (al5.I(xmlElement, "override"))
                        {
                            result.OverrideImpactType = new cg(cg.aa.c, "Impact_Type", al5.A(A_0, "overide", ""));
                        }
                    }
                }
            }
            return result;
        }

        public static ci b(hn A_0, string A_1)
        {
            ci result = new ci();
            if (!string.IsNullOrEmpty(A_1) && A_0.A8().ao.ContainsKey(A_1))
            {
                result = A_0.A8().ao[A_1];
            }
            return result;
        }
    }
}