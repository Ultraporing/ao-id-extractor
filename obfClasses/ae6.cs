using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ao_id_extractor.obfClasses
{
    public class ae6
    {
        public delegate void aa(string A_0, object A_1, ae6.Level A_2);

        public enum Level
        {
            Info,
            Warning,
            Error
        }

        public static bool a;

        public static bool b;

        [CompilerGenerated]
        private static ae6.aa c;

        [CompilerGenerated]
        public static ae6.aa B()
        {
            return ae6.c;
        }

        [CompilerGenerated]
        public static void A(ae6.aa A_0)
        {
            ae6.c = A_0;
        }

        static ae6()
        {
            ae6.a = false;
            ae6.b = true;
            ae6.A();
        }

        private static void A(string A_0, object A_1, ae6.Level A_2)
        {
        }

        public static void A()
        {
            ae6.A(new ae6.aa(ae6.A));
        }

        [Conditional("DEBUG"), Conditional("UNITY_EDITOR")]
        public static void A(bool A_0)
        {
            if (!A_0)
            {
                StackTrace stackTrace = new StackTrace(true);
                ae6.B()("ASSERTion failed! Stacktrace: " + stackTrace.ToString(), null, ae6.Level.Error);
                try
                {
                    throw new Exception("ASSERTion failed! Stacktrace: " + stackTrace.ToString());
                }
                catch (Exception)
                {
                }
            }
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEBUG")]
        public static void C(bool A_0, string A_1)
        {
            if (!A_0)
            {
                StackTrace stackTrace = new StackTrace(true);
                ae6.B()("ASSERTion failed! Message: " + A_1 + " Stacktrace: " + stackTrace.ToString(), null, ae6.Level.Error);
                try
                {
                    throw new Exception("ASSERTion failed! Message: " + A_1 + " Stacktrace: " + stackTrace.ToString());
                }
                catch (Exception)
                {
                }
            }
        }

        [Conditional("DEBUG"), Conditional("UNITY_EDITOR")]
        public static void A(bool A_0, params string[] A_1)
        {
            string str = string.Concat(A_1);
            if (!A_0)
            {
                StackTrace stackTrace = new StackTrace(true);
                ae6.B()("ASSERTion failed! Message: " + str + " Stacktrace: " + stackTrace.ToString(), null, ae6.Level.Error);
                try
                {
                    throw new Exception("ASSERTion failed! Message: " + str + " Stacktrace: " + stackTrace.ToString());
                }
                catch (Exception)
                {
                }
            }
        }

        [Conditional("UNITY_EDITOR"), Conditional("DEBUG")]
        public static void B(bool A_0, string A_1)
        {
        }

        [Conditional("UNITY_EDITOR"), Conditional("ALBIONSERVER")]
        public static void E(string A_0)
        {
            if (ae6.a)
            {
                return;
            }
            ae6.B()(A_0, null, ae6.Level.Info);
        }

        [Conditional("UNITY_EDITOR"), Conditional("ALBIONSERVER")]
        public static void B(object A_0)
        {
            if (ae6.a)
            {
                return;
            }
            ae6.B()(A_0.ToString(), null, ae6.Level.Info);
        }

        [Conditional("UNITY_EDITOR"), Conditional("ALBIONSERVER")]
        public static void D(string A_0)
        {
            ae6.B()(A_0, null, ae6.Level.Info);
        }

        [Conditional("ALBIONSERVER"), Conditional("UNITY_EDITOR")]
        public static void C(string A_0, object A_1)
        {
            ae6.B()(A_0, A_1, ae6.Level.Info);
        }

        [Conditional("UNITY_EDITOR"), Conditional("ALBIONSERVER")]
        public static void C(string A_0)
        {
            ae6.B()(A_0, null, ae6.Level.Warning);
        }

        [Conditional("ALBIONSERVER"), Conditional("UNITY_EDITOR")]
        public static void B(string A_0, object A_1)
        {
            ae6.B()(A_0, A_1, ae6.Level.Warning);
        }

        [Conditional("UNITY_EDITOR"), Conditional("ALBIONSERVER")]
        public static void B(string A_0, params object[] A_1)
        {
            ae6.B()(string.Format(A_0, A_1), null, ae6.Level.Warning);
        }

        [Conditional("ALBIONSERVER"), Conditional("UNITY_EDITOR")]
        public static void B(object A_0, string A_1, params object[] A_2)
        {
            ae6.B()(string.Format(A_1, A_2), A_0, ae6.Level.Warning);
        }

        public static void B(string A_0)
        {
            if (ae6.b)
            {
                StackTrace stackTrace = new StackTrace(true);
                ae6.B()(A_0 + " Stacktrace: " + stackTrace.ToString(), null, ae6.Level.Error);
            }
        }

        public static void A(string A_0)
        {
            if (ae6.b)
            {
                ae6.B()(A_0, null, ae6.Level.Error);
            }
        }

        public static void A(string A_0, object A_1)
        {
            if (ae6.b)
            {
                ae6.B()(A_0, A_1, ae6.Level.Error);
            }
        }

        public static void A(string A_0, params object[] A_1)
        {
            if (ae6.b)
            {
                ae6.B()(string.Format(A_0, A_1), null, ae6.Level.Error);
            }
        }

        public static void A(object A_0, string A_1, params object[] A_2)
        {
            if (ae6.b)
            {
                ae6.B()(string.Format(A_1, A_2), A_0, ae6.Level.Error);
            }
        }

        public static void A(bool A_0, string A_1)
        {
            if (ae6.b && !A_0)
            {
                ae6.B()(A_1, null, ae6.Level.Error);
            }
        }

        public static void A(Exception A_0)
        {
            if (ae6.b)
            {
                ae6.B()(A_0.ToString(), null, ae6.Level.Error);
            }
        }

        public static Dictionary<string, object> A(object A_0)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>(A_0.GetType().GetProperties().Length);
            PropertyInfo[] properties = A_0.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object value = propertyInfo.GetValue(A_0, null);
                list.Add(new Dictionary<string, object>
            {
                {
                    "PropertyName",
                    propertyInfo.Name
                },
                {
                    "PropertyValue",
                    (value != null) ? value.ToString() : "null"
                }
            });
            }
            return new Dictionary<string, object>
        {
            {
                "Object2Dictionary",
                list
            }
        };
        }
    }
}