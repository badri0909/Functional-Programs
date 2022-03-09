using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class OddEven
    {
        ///<summary>
        /// UC1- Finding the number is even or odd.
        ///</summary>
        public static void OddorEven()
        {
            Console.WriteLine("Enter a Number");
            int i;
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}
