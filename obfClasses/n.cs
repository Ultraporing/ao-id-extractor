using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Schema;

namespace ao_id_extractor.obfClasses
{
    public abstract class n
    {
        [CompilerGenerated]
        private byte[] a;

        [CompilerGenerated]
        private ValidationEventHandler b;

        [CompilerGenerated]
        public byte[] Ke()
        {
            return this.a;
        }

        [CompilerGenerated]
        private void Ib(byte[] A_0)
        {
            this.a = A_0;
        }

        private static void Ib(object A_0, ValidationEventArgs A_1)
        {
            if (A_1.Severity == XmlSeverityType.Warning)
            {
                return;
            }
            if (A_1.Severity == XmlSeverityType.Error)
            {
                ae6.A(A_1.Message);
            }
        }

        [CompilerGenerated]
        public ValidationEventHandler Kf()
        {
            return this.b;
        }

        [CompilerGenerated]
        public void Ib(ValidationEventHandler A_0)
        {
            this.b = A_0;
        }

        protected n()
        {
            this.Ib(new ValidationEventHandler(n.Ib));
        }

        public bool Im(string A_0)
        {
            return this.Ic(A_0, false);
        }

        public bool Ic(string A_0, bool A_1)
        {
            return this.Ib(A_0, null, A_1);
        }

        public bool Id(string A_0, string A_1)
        {
            return this.Ib(A_0, A_1, false);
        }

        public bool Ib(string A_0, string A_1, bool A_2)
        {
            bool result;
            using (Stream stream = ne.B(A_0))
            {
                if (stream == null)
                {
                    Console.WriteLine("ERROR: File Not Found: " + A_0);
                    result = false;
                    return result;
                }
                MD5 mD = MD5.Create();
                this.Ib(mD.ComputeHash(stream));
            }
            using (Stream stream2 = ne.B(A_0))
            {
                result = this.Ib(stream2, A_1, A_2);
            }
            return result;
        }

        public bool Ib(Stream A_0, string A_1, bool A_2)
        {
            bool result;
            using (StreamReader streamReader = new StreamReader(A_0))
            {
                if (streamReader.Peek() == 65279)
                {
                    streamReader.Read();
                }
                XmlDocument xmlDocument = new XmlDocument();
                try
                {
                    xmlDocument.Load(streamReader);
                }
                catch (XmlException a_)
                {
                    throw new Exception("Unable to parse XML", a_);
                }
                if (!string.IsNullOrEmpty(A_1))
                {
                    xmlDocument.Schemas.Add("", A_1);
                    xmlDocument.Validate(this.Kf());
                }
                if (A_2)
                {
                    result = this.Ct(xmlDocument.DocumentElement);
                }
                else
                {
                    result = this.Bk(xmlDocument.DocumentElement);
                }
            }
            return result;
        }

        protected abstract bool Bk(XmlElement A_0);

        protected virtual bool Ct(XmlElement A_0)
        {
            return true;
        }
    }
}