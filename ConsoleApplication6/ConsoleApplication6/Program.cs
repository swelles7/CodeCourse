using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        /*static string RomanNumeral( x, int y)
        {
            Console.WriteLine(result)
            return result
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number - I will change it to a Roman Numeral");
            string answer = Console.ReadLine();
            int number = Convert.ToInt16(answer);

            while (number >= 1000)
            {
                Console.Write("C");
                number -= 1000;
            }
            while (number >= 500)
            {
                Console.Write("D");
                number -= 500;
            }
            while (number >= 100)
            {
                Console.Write("M");
                number -= 100;
            }
            Console.ReadLine();
        }
    }
}
