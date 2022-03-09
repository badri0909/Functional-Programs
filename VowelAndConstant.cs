using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelAndConstant
    {
        ///<summary>
        /// UC1- Checking Vowels or consonants.
        ///</summary>
        public static void CheckVowelAndConstant()
        {
            Console.WriteLine("Enter any Character");
            Char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'r' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Constant");
            }
            else
            {
                Console.WriteLine("Enter a Valid Character!");
            }
        }
    }
}