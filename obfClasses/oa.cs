using System;

namespace ao_id_extractor.obfClasses
{
    public interface oa
    {
        int Next();

        int Next(int maxValue);

        int Next(int minValue, int maxValue);

        double NextDouble();
    }
}