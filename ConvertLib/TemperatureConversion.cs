using System;

namespace ConvertLib
{
    class TemperatureConversion
    {
        static double CtoF(double c)
        {
            double f = (c * (9m/5m)) + 32;
            return f;
        }

        static double FtoC(double f)
        {
            double c = (c -32) * (9m/5m);
            return c;
        }
    }
}
