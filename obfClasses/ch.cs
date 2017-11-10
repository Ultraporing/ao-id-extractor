using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public class ch
    {
        [CompilerGenerated]
        private cg a;

        [CompilerGenerated]
        private cg b;

        [CompilerGenerated]
        private cg c;

        [CompilerGenerated]
        private cg d;

        [CompilerGenerated]
        private cg e;

        [CompilerGenerated]
        private cg f;

        [CompilerGenerated]
        private cg g;

        [CompilerGenerated]
        private cg h;

        public cg PCharType
        {
            get;
            private set;
        }

        [CompilerGenerated]
        public cg H()
        {
            return this.b;
        }

        [CompilerGenerated]
        private void N(cg A_0)
        {
            this.b = A_0;
        }

        [CompilerGenerated]
        public cg I()
        {
            return this.c;
        }

        [CompilerGenerated]
        private void M(cg A_0)
        {
            this.c = A_0;
        }

        [CompilerGenerated]
        public cg J()
        {
            return this.d;
        }

        [CompilerGenerated]
        private void L(cg A_0)
        {
            this.d = A_0;
        }

        [CompilerGenerated]
        public cg K()
        {
            return this.e;
        }

        [CompilerGenerated]
        private void K(cg A_0)
        {
            this.e = A_0;
        }

        [CompilerGenerated]
        public cg L()
        {
            return this.f;
        }

        [CompilerGenerated]
        private void J(cg A_0)
        {
            this.f = A_0;
        }

        [CompilerGenerated]
        public cg M()
        {
            return this.g;
        }

        [CompilerGenerated]
        private void I(cg A_0)
        {
            this.g = A_0;
        }

        [CompilerGenerated]
        public cg N()
        {
            return this.h;
        }

        [CompilerGenerated]
        private void H(cg A_0)
        {
            this.h = A_0;
        }

        public static ch I(XmlElement A_0)
        {
            ch ch = new ch();
            foreach (XmlNode xmlNode in A_0.ChildNodes)
            {
                XmlElement xmlElement = xmlNode as XmlElement;
                string name;
                if (xmlElement != null && (name = xmlElement.Name) != null)
                {
                    if (al6.c == null)
                    {
                        al6.c = new Dictionary<string, int>(8)
                    {
                        {
                            "CharType",
                            0
                        },
                        {
                            "Gender",
                            1
                        },
                        {
                            "MobFaction",
                            2
                        },
                        {
                            "MobType",
                            3
                        },
                        {
                            "Size",
                            4
                        },
                        {
                            "ArmorType",
                            5
                        },
                        {
                            "WeaponType",
                            6
                        },
                        {
                            "MountType",
                            7
                        }
                    };
                    }
                    int num;
                    if (al6.c.TryGetValue(name, out num))
                    {
                        switch (num)
                        {
                            case 0:
                                ch.PCharType = new cg(cg.aa.c, "Char_Type", al5.A(xmlElement, "name", ""));
                                break;
                            case 1:
                                ch.N(new cg(cg.aa.c, "Gender", al5.A(xmlElement, "name", "")));
                                break;
                            case 2:
                                ch.M(new cg(cg.aa.c, "Mob_Faction", al5.A(xmlElement, "name", "")));
                                break;
                            case 3:
                                ch.L(new cg(cg.aa.c, "Mob_Type", al5.A(xmlElement, "name", "")));
                                break;
                            case 4:
                                ch.K(new cg(cg.aa.c, "Size", al5.A(xmlElement, "name", "")));
                                break;
                            case 5:
                                ch.J(new cg(cg.aa.c, "Armor_Type", al5.A(xmlElement, "name", "")));
                                break;
                            case 6:
                                ch.I(new cg(cg.aa.c, "Weapon_Type", al5.A(xmlElement, "name", "")));
                                break;
                            case 7:
                                ch.H(new cg(cg.aa.c, "Mount_Type", al5.A(xmlElement, "name", "")));
                                break;
                        }
                    }
                }
            }
            return ch;
        }

        public static string H(XmlElement A_0)
        {
            List<XmlElement> list = al5.D(A_0, "AudioInfo");
            if (list != null && list.Count > 0)
            {
                if (list.Count > 1)
                {
                    ae6.A("Too many MobAudio Tags defined in Mob: " + al5.A(A_0, "uniquename", A_0.Name) + " First is used.");
                }
                string text = al5.A(list[0], "name", "");
                if (!string.IsNullOrEmpty(text))
                {
                    return text;
                }
            }
            return string.Empty;
        }

        public static ch H(hn A_0, string A_1)
        {
            ch result = new ch();
            if (!string.IsNullOrEmpty(A_1) && A_0.A8().an.ContainsKey(A_1))
            {
                result = A_0.A8().an[A_1];
            }
            return result;
        }
    }
}