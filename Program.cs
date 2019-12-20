using System;
using static System.Console;

namespace tip_calc_methods
{
    class Program
    {
        // declare class-level constants
        const double TAX_PERCENT = .09,
                     LOW_TIP_PERCENT = .15,
                     HIGH_TIP_PERCENT = .2;
        // declare class-level static variables (no objects yet)
        // note that this sacrifices efficiency for legibility
        static double billPreTax,
                      taxAmount,
                      billPostTax,
                      lowTip,
                      highTip,
                      billTotalWithLowTip,
                      billTotalWithHighTip;
        static void Main(string[] args)
        {
            WriteLine("{0, 20} {1, 15:P0}", "Tax Percentage:", TAX_PERCENT);
            WriteLine("{0, 20} {1, 15:P0}", "Low Tip Percentage:", LOW_TIP_PERCENT);
            WriteLine("{0, 20} {1, 15:P0}", "High Tip Percentage:", HIGH_TIP_PERCENT);
            billPreTax = ReadDouble("Please enter bill amount (pre-tax):");
        }

        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0}{1} ", "Invalid input!\n", label);
                userInput = ReadLine();
            }
            return number;
        }
    }
}
