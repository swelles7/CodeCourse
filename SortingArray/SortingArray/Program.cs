using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[] { 2, 6, 3, 7, 1, 4, 8, 0, 3, 5 };
            int MaxValue = someArray.Max();

            string input;
            int i = 0;
            int counter = 0;
            int number;
            int[] UserArray = new int[10];
            int anotherinputnumber;


            Console.WriteLine("Enter 10 numbers one at a time.");
            while (counter < 10)
            {
                input = Console.ReadLine();
                counter++;
                if (int.TryParse(input, out number))
                {
                    UserArray[i] = number;
                    i++;
                }
            }

            int UserMaxValue = UserArray.Max();
            Console.WriteLine(UserMaxValue);

            {

                Console.WriteLine("Enter another number");
                string anotherinput = Console.ReadLine();
                if (int.TryParse(anotherinput, out anotherinputnumber)) ;



                for (i = 0; i < UserArray.Length; i++)
                {
                    while (anotherinputnumber != UserArray[i])
                    {
                        if (anotherinputnumber == UserArray[i])
                        {

                            Console.WriteLine("Yes that number is part of the Array - you idiot");
                            Console.ReadLine();
                        }




                        else
                        {
                            Console.WriteLine("No that is not part of the Array but I'm doing nothing with it");
                            Console.ReadLine();

                        }
                    }

                    Console.WriteLine("We're done");
                }
            }
        }
    } }



