using System;
using static System.Console;

namespace _3_ChangeReturn
{
    class _3_ChangeReturn
    {
        static void Main(string[] args)
        {
            const int change = 92;
            int quarters;
            int dimes;
            int nickels;
            int pennies;
           
            quarters = change / 25;
            dimes = (change % 25) / 10;
            nickels = ((change % 25) % 10) / 5;
            pennies = (((change % 25) % 10) % 5);

            WriteLine("Your change is: {0,-8:f0}", "." + change);
            WriteLine("Quarters:{0,3}", quarters);
            WriteLine("Dimes:{0,6}", dimes);
            WriteLine("Nickels:{0,4}", nickels);
            WriteLine("Pennies:{0,4}", pennies);
            ReadKey();
        }
    }
}
