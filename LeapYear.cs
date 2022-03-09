using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        ///<summary>
        /// UC1- Finding Leap Year.
        ///</summary>
        public static void leapyear()
        {
            Console.WriteLine("Enter a Year");
            int year = int.Parse(Console.ReadLine());
            if (year.ToString().Length < 4)
            {
                Console.WriteLine("Enter a valid 4 digit year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("The Given Year {0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("The Given Year {0} is not a Leap Year", year);
            }
        }
    }
}