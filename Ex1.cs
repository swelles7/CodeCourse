using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string answer;
            bool keepLooping = true;

            while(keepLooping)
            {
                Console.WriteLine("Please enter a number");
                answer = Console.ReadLine();
                if (int.TryParse(answer, out number))
                {
                    //number = Convert.ToInt16(answer);
                    Console.WriteLine("Thanks");
                    keepLooping = false;
                }
                   
            }
        }
    }
}
