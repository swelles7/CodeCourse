using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputnumber;
            int number1;
            int m;

            

            Console.WriteLine("Please enter a number - I'm going to turn it into a Roman Numeral");
            inputnumber = Console.ReadLine();
            if(int.TryParse(inputnumber, out number1))
            {

                if (number1 > 1000) ;
                {
                    for (int a = number1; a > 1000; a = a - 1000)
                    {
                        Console.WriteLine("M");

                    }
                }
                Console.ReadLine();
            }



                    }
    }
}
