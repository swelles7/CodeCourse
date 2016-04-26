using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;
            int numberguess = 0;
            int guessID = 0;
            int computerguess;
            Random rnd = new Random();
            computerguess = rnd.Next(1, 100);
            Console.WriteLine(computerguess);

            Console.WriteLine("Let's play a guessing game. Guess a number");
            
            
            while (numberguess != computerguess)
            {
                guess = Console.ReadLine();

                if (int.TryParse(guess, out numberguess))
                {

                    if (numberguess > computerguess)
                    {
                        Console.WriteLine("Lower. Try Again");
                        guessID++;
                    }
                    if (numberguess < computerguess)
                    {
                        Console.WriteLine("Higher. Try Again");
                        guessID++;
                    }
                }
            }
                    if(numberguess == computerguess)
                {
                    Console.WriteLine("Congrats! You got it.");
                    guessID++;
                    Console.WriteLine("It only took you " + guessID + " guesses!");
                 }
            Console.ReadLine();
            }
        }
    }

