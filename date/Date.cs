using System;
using static System.Console;
namespace Date
{
    class Date
    {
        static void Main(string[] args)
        {
            // create an object of the class name version 1
            Date1 aDate1 = new Date1();
            aDate1.Month = Input("Month");
            aDate1.Day = Input("Day");
            aDate1.Year = Input("Year");

            WriteLine("\n\tFirst Test");
            WriteLine(aDate1);

            // create an object of the class name version 2
            Date1 secondDate1 = new Date1();
            secondDate1.Month = 04;
            secondDate1.Day = 04;
            secondDate1.Year = 1997;
            WriteLine("\n\tSecond Test");
            WriteLine(secondDate1);

            //create an object of the class data version 3
            WriteLine("\n\tThird Test");
            Date1 anotherDate1 = new Date1(04, 04, 1997);
            WriteLine("Date: " + anotherDate1.ToString());
            //create an object of the class data version 4
            WriteLine("\n\tFourth Test");
            Date1 lastOne = new Date1("April", 04, 1997);
            WriteLine(lastOne.ReturnLongDate());

            ReadKey();
        }
        static int Input(string whichOne)
        {
            string inValue;
            Write("Enter a number representing the {0}:  ", whichOne);
            inValue = ReadLine();
            return (int.Parse(inValue));
        }
    }
}