using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class flipCoin
    {
        ///<summary>
        /// UC1- Flipping a Coin.
        ///</summary>
        public static void flipTheCoin()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercent;
            double TailPercent;

            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 1)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if (number == 0)
                    {
                        Tail = 1;
                        TailCount += Tail;
                    }

                    Console.WriteLine(number);
                }

                Console.WriteLine("--------------");

                HeadPercent = HeadCount * 100 / flipCoin;
                TailPercent = TailCount * 100 / flipCoin;

                Console.WriteLine("Head Percentage : " + HeadPercent);
                Console.WriteLine("Tail Percentage : " + TailPercent);
            }
            else
            {
                Console.WriteLine("Please enter a positive number");
            }
        }
    }
}