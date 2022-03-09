using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class NumberSwap
    {
        ///<summary>
        /// UC1- Swapping the given numbers.
        ///</summary>
        public static void SwapTwoNUmbers()
        {
            int a = 9, b = 18;
            Console.WriteLine("Before swap a= " + a + "b= " + b);

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("After swap a= " + a + "b= " + b);
        }
    }
}