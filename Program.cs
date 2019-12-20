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
        static void Main(string[] args)
        {
            WriteLine("{0, 20} {1, 15:P0}", "Tax Percentage:", TAX_PERCENT);
            WriteLine("{0, 20} {1, 15:P0}", "Low Tip Percentage:", LOW_TIP_PERCENT);
            WriteLine("{0, 20} {1, 15:P0}", "High Tip Percentage:", HIGH_TIP_PERCENT);
        }
    }
}
