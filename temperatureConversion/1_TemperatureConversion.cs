using System;
using static System.Console;

namespace _1_TemperatureConversion
{
    class _1_TemperatureConversion
    {
        static void Main(string[] args)
        {
            double celsius = 0;
            double fahrenheit;

            fahrenheit = (9.0 / 5.0 * celsius) + 32.0;

            WriteLine("\t Temperature Conversion App");
            WriteLine("\tDegrees in Celsius:{0,8}", celsius);
            WriteLine("\tDegrees in Fahrenheit:{0,7:f1}", fahrenheit);
            ReadKey();
        }
    }
}