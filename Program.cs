using System;

namespace TipCalculator
{
    class Program
    {
        static void Main()
        {
            double billTotal = 0;
            double tipPercentage = 0;
            double tip = 0;
            double finalBillAmount = 0;

            Console.WriteLine("How much is your bill?");

            billTotal = Utility.GetNumberFromUser();

            Console.WriteLine("How much would you like to tip? Please enter a percent between 1 and 100.");

            tipPercentage = Utility.GetPercentFromUser();

            tip = tipPercentage / 100 * billTotal;

            finalBillAmount = billTotal + tip;

            Console.WriteLine($"Your tip amount is: {tip:C}.");

            Console.WriteLine($"Your final bill amount is: {finalBillAmount:C}");

        }
    }
}
