using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    static class Utility
    {
        public static double GetNumberFromUser()
        {
           
            try
            {
                double total = Convert.ToDouble(Console.ReadLine());
                if (total > 0 )
                {
                    return total;
                }
                else
                {
                    return GetNumberFromUser();
                }
               

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number");

            }
            return GetNumberFromUser();
        }
        public static double GetPercentFromUser()
        {

            try
            {
                double total = Convert.ToDouble(Console.ReadLine());
                if (total > 0 && total <= 100)
                {
                    return total;
                }
                else
                {
                    return GetPercentFromUser();
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid percent");

            }
            return GetPercentFromUser();
        }
    }
}
