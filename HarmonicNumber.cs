using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        ///<summary>
        /// UC1- the Finding Harmonic numbers.
        ///</summary>
        public static void HarNum()
        {
            int i, n;
            double d = 0.0;

            Console.WriteLine("Enter the value of n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                d += 1 / (float)i;
            }
            Console.WriteLine("\nSum of series upto {0} terms : {1} ", n, d);
        }
    }
}