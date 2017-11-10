using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ao_id_extractor.obfClasses
{
    public static class og
    {
        public static of C(this oa A_0)
        {
            return of.B(A_0.Next(4097));
        }

        public static of A(this oa A_0, of A_1, of A_2)
        {
            return of.L(A_1, of.J(A_0.C(), of.K(A_2, A_1)));
        }

        public static double A(this oa A_0, double A_1, double A_2)
        {
            return A_1 + A_0.NextDouble() * (A_2 - A_1);
        }

        public static ald A(this oa A_0, ald A_1, ald A_2)
        {
            return ald.K(A_1.o + (long)(A_0.NextDouble() * (double)(A_2.o - A_1.o)));
        }

        public static TimeSpan A(this oa A_0, TimeSpan A_1, TimeSpan A_2)
        {
            return TimeSpan.FromTicks(A_1.Ticks + (long)(A_0.NextDouble() * (double)(A_2.Ticks - A_1.Ticks)));
        }

        public static akz B(this oa A_0)
        {
            return new om(1f, (float)A_0.A(0.0, 6.2831853071795862)).c();
        }

        public static od A(this oa A_0)
        {
            return new jt(of.C(), A_0.A(of.D(), js.b)).c();
        }

        public static int B(this oa A_0, float A_1)
        {
            double num = (double)A_1 - Math.Floor((double)A_1);
            if (A_1 < 0f)
            {
                num = 1.0 - num;
            }
            if (A_0.NextDouble() > num)
            {
                return (int)Math.Floor((double)A_1);
            }
            return (int)Math.Ceiling((double)A_1);
        }

        public static bool A(this oa A_0, float A_1)
        {
            if (A_1 <= 0f)
            {
                return false;
            }
            if (A_1 >= 1f)
            {
                return true;
            }
            float num = (float)A_0.A(0.0, 1.0);
            return num <= A_1;
        }
    }
}
