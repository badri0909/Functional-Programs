using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientRemainder
    {
        ///<summary>
        /// UC1- Finding the Quotient and Remainder of a number.
        ///</summary>
        public static void FindQuotientAndRemainder()
        {
            int x, y;
            Console.WriteLine("Enter value of x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of y");
            y = Convert.ToInt32(Console.ReadLine());

            int quotient = x / y;
            int remainder = x % y;

            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}