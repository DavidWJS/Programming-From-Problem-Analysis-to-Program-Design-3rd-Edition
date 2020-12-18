using System;
using static System.Console;

namespace _2_MilesConversion
{
    class _2_MilesConversion
    {
        static void Main(string[] args)
        {
            double miles = 4.5;
            double feet;
            double kilometers;

            feet = 5280 * miles;
            kilometers = feet * 0.0003048;
            WriteLine("{0:f2}", miles + " mi");
            WriteLine("{0} mi = {1:f0} ft", miles, feet);
            WriteLine("{0} ft = {1:f0} km", feet, kilometers);
            ReadKey();
        }
    }
}
