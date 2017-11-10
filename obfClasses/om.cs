using System;

namespace ao_id_extractor.obfClasses
{
    public class om
    {
        public float a;

        public float b;

        public om(float A_0, float A_1)
        {
            this.a = A_0;
            this.b = A_1;
        }

        public static om C(akz A_0)
        {
            return om.C(A_0.G(), A_0.H());
        }

        public static om C(float A_0, float A_1)
        {
            return new om((float)Math.Sqrt((double)(A_0 * A_0 + A_1 * A_1)), (float)Math.Atan2((double)A_1, (double)A_0));
        }

        public akz c()
        {
            return new akz(this.a * (float)Math.Cos((double)this.b), this.a * (float)Math.Sin((double)this.b));
        }
    }
}