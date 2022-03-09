using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
        ///<summary>
        /// UC1- Finidng Largest among the entered numbers.
        ///</summary>
        public static void FindLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter 1st Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num1= " + num1 + " num2= " + num2 + " num3= " + num3);

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is Largest ");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is Largest ");
            }
            else
            {
                Console.WriteLine("num3 is Largest");
            }
        }
    }
}