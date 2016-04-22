using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Roman Numeral");
            string answer = Console.ReadLine();
            int number = Convert.ToInt16(answer);

            if (number > 10)
            {
                Console.Write("X");
                number -= 10;
             }
            if (number >= 5)
            {
                Console.Write("v");
                number -= 5;
            }
        }
    }
}
