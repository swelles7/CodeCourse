using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Calculator
{
    class Program

    {
        static int GetNumber(string firstnumber)
        { Console.WriteLine("Give me the first number you'd like to add?");
            firstnumber = Console.ReadLine();
            if (int.TryParse(firstnumber, out number1))
                return number1;
}
        static int AddTogether(int x, int y)
        {
            int addresult = x + y;
            Console.WriteLine(addresult);
            return addresult;
             
        }
      static int SubtractTogether(int x, int y)
        {
            int subresult = x - y;
            Console.WriteLine(subresult);
            return subresult;

        }

        
        static void Main(string[] args)
        

        {
            string intent;
            string firstnumber;
            string secondnumber;
            int number1;
            int number2;
            int result;
            bool keepLooping;

            Console.WriteLine("What would you like to do?");
            intent = Console.ReadLine();

            if (intent == "Add")
            {
                Console.WriteLine("Give me the first number you'd like to add?");
                firstnumber = Console.ReadLine();
                if (int.TryParse(firstnumber, out number1))
                {
                    Console.WriteLine("Give me the second number you'd like to add?");
                    secondnumber = Console.ReadLine();
                    if (int.TryParse(secondnumber, out number2))
                    {
                        AddTogether(number1, number2);
                    }

                }
            }
            
              if (intent == "Subtract")
                {
                    Console.WriteLine("Give me the first number you'd like to subtract?");
                    firstnumber = Console.ReadLine();
                    if (int.TryParse(firstnumber, out number1))
                    {
                        Console.WriteLine("Give me the second number you'd like to subtract?");
                        secondnumber = Console.ReadLine();
                        if (int.TryParse(secondnumber, out number2))
                        {
                            SubtractTogether(number1, number2);
                        Console.ReadLine();
                           
                        }


                    }

                }



            }
        }
    }



