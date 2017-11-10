using System.Xml;

namespace ao_id_extractor.obfClasses
{
    public abstract class ep
    {
        private float a;

        private float b;

        private bool c;

        public float t()
        {
            return this.a;
        }

        protected void p(float A_0)
        {
            this.a = A_0;
        }

        public float u()
        {
            return this.b;
        }

        protected void q(float A_0)
        {
            this.b = A_0;
        }

        public bool v()
        {
            return this.c;
        }

        protected void p(bool A_0)
        {
            this.c = A_0;
        }

        public ep()
        {
            this.p(true);
        }

        public virtual void da(XmlElement A_0)
        {
            this.p(al5.A(A_0, "chance", 1f));
            this.q(al5.A(A_0, "weight", 1f));
            this.p(al5.A(A_0, "cangetmodified", this.c));
        }
    }
}