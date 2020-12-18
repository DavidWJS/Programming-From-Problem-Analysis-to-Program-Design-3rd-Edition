using System;
using static System.Console;

namespace _4_Take_HomePay
{
    class _4_Take_HomePay
    {
        static void Main(string[] args)
        {
            int monthlySales = 161432;
            string employeeName = "Joshua Montain";

            Double grossPay = monthlySales * .07;
            Double federalTax = grossPay * .18;
            Double retirement = grossPay * .1;
            Double socialSecurity = grossPay * .06;
            Double totalDeductions = socialSecurity + retirement + federalTax;
            Double takeHomePay = grossPay - totalDeductions;

            Write(employeeName + "'s Monthly Sale amount is: {0,14:c}", monthlySales);
            Write("\nGross Pay: {0,44:c}", grossPay);
            Write("\nFed Tax: {0,46:c}", federalTax);
            Write("\nRetirement: {0,43:c}", retirement);
            Write("\nSocial Security: {0,38:c}", socialSecurity);
            Write("\nTotal Deductions: {0,37:c}", totalDeductions);
            Write("\nMaking " + employeeName + "'s take home pay: {0,16:c}", takeHomePay);
            Write("\n");
            ReadKey();
        }
    }
}