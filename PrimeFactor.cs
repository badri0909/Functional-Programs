using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PrimeFactor
    {
        ///<summary>
        /// UC1- Prime Factors a number.
        ///</summary>
        public static void primefactor()
        {
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
        }
    }
}