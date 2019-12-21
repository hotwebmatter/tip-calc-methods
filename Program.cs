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
            billPreTax = ReadDouble("Please enter bill amount (pre-tax):");
            CalculateTax();
            CalculateLowTip();
            CalculateHighTip();
            WriteLine(DisplayResults());
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

        static void CalculateTax()
        {
            taxAmount = billPreTax * TAX_PERCENT;
            billPostTax = billPreTax + taxAmount;
        }
        static void CalculateLowTip()
        {
            // per spec, though tip is generally calculated pre-tax
            lowTip = billPostTax * LOW_TIP_PERCENT;
            billTotalWithLowTip = billPostTax + lowTip;
        }
        static void CalculateHighTip()
        {
            // per spec, though tip is generally calculated pre-tax
            highTip = billPostTax * HIGH_TIP_PERCENT;
            billTotalWithHighTip = billPostTax + highTip;
        }
        static string DisplayResults()
        {
            string result = String.Format("\n****** Tip Calculator Constants ******\n");
            result += String.Format("* {0, 20}{1, 14:P0} *\n", "Tax Percentage:", TAX_PERCENT);
            result += String.Format("* {0, 20}{1, 14:P0} *\n", "Low Tip Percentage:", LOW_TIP_PERCENT);
            result += String.Format("* {0, 20}{1, 14:P0} *\n", "High Tip Percentage:", HIGH_TIP_PERCENT);
            result += String.Format("**************************************\n\n");
            result += String.Format("****** Tip Calculator Variables ******\n");
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "Bill Total Pre-Tax:", billPreTax);
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "Tax Amount:", taxAmount);
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "Bill Total Post-Tax:", billPostTax);
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "Low Tip:", lowTip);
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "Total (Low Tip):", billTotalWithLowTip);
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "High Tip:", highTip);
            result += String.Format("* {0, 20}{1, 14:C2} *\n", "Total (High Tip):", billTotalWithHighTip);
            result += String.Format("**************************************\n");
            return result;
        }
    }
}
