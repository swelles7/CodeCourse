using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] display;
            display = new int[8, 8]; // this is creating the array for the field we'll be displaying. It'll be 8 wide and 8 high.
            int[,] backend;
            backend = new int[8, 8]; // this is creating the array for the backend where we'll be storing the location of ships.




            String input = System.IO.File.ReadAllText(@"./TextFile1.txt");
            int i = 0, j = 0;
            int[,] result = new int[8, 8];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    result[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
                }
            Console.WriteLine(result[0, 1]);
            
        
            /*System.IO.StreamReader file = new System.IO.StreamReader("./TextFile1.txt");
            string line;
                while ((line = file.ReadLine()) != null)
            {
                int[] textdisplay = new int[line.Length];
                for (int i = 0; i < line.Length; i++)
                {
                    textdisplay[i] = Convert.ToInt32(line[i].ToString());
                }

                Console.WriteLine(textdisplay);
            }*/
               
            


            /*string textdisplay = System.IO.File.ReadAllText(@"./TextFile1.txt");
            int[] grid = new int[textdisplay.Length];
            Console.Write(grid);
            */


            string guessOne = "";
            string guessTwo = ""; // empty strings to hold guesses
            int intGuess;
            int intGuessTwo; // these'll be used to scrub the input (which is always a string) into real ints
            bool keepLooping = true;
            bool keepLoopingTwo = true;
            bool gameLoop = true;
            string exit = "";

            int hits = 0;
            int win = 1;
            Random shipgen = new Random();
            int shipx = shipgen.Next(6) + 2;
            Random direction = new Random();
            int directionchoice;
            int shipscreated = 0;



            while ((gameLoop))
            {

                while (shipscreated < 3) //ship creator
                {
                    directionchoice = direction.Next(4);
                    int x = shipgen.Next(5) + 2;
                    int y = shipgen.Next(5) + 2;

                    switch (directionchoice)
                    {
                        case 0:
                            if (backend[x + 1, y] != 1)
                            {
                                backend[x, y] = 1;
                                backend[x + 1, y] = 1;
                                shipscreated++;
                            }
                            break;
                        case 1:
                            if (backend[x, y + 1] != 1)
                            {
                                backend[x, y] = 1;
                                backend[x, y + 1] = 1;
                                shipscreated++;
                            }
                            break;
                        case 2:

                            if (backend[x - 1, y] != 1)
                            {
                                backend[x, y] = 1;
                                backend[x - 1, y] = 1;
                                shipscreated++;
                            }
                            break;
                        case 3:

                            if (backend[x, y - 1] != 1)
                            {
                                backend[x, y] = 1;
                                backend[x, y - 1] = 1;
                                shipscreated++;
                            }
                            break;
                    }
                }
                for (int a = 0; a < 8; a++) //displays the cheat board
                {
                    for (int b = 0; b < 8; b++)
                    {
                        Console.Write(backend[b, a]);
                    }
                    Console.Write("\n");
                }
                Console.ReadLine();
                Console.WriteLine("This is your board!");

                while (keepLooping)
                {

                    for (int a = 0; a < 8; a++)
                    {

                        for (int b = 0; b < 8; b++)
                        {
                            if (display[b, a] == 1)
                            { Console.Write("X"); }
                            else if (display[b, a] == 3)
                            {
                                Console.Write("O");
                            }
                            else
                            {
                                Console.Write(".");
                            }
                        }
                        Console.Write("\n");
                    }
                    keepLoopingTwo = true;
                    Console.WriteLine("Enter your first coordinate 1-8");
                    guessOne = Console.ReadLine();

                    if (int.TryParse(guessOne, out intGuess) && (intGuess <= 8) && (intGuess >= 1))
                    {
                        keepLooping = false;
                        while (keepLoopingTwo)
                        {
                            Console.WriteLine("Enter your second coordinate 1-8");
                            guessTwo = Console.ReadLine();

                            if (int.TryParse(guessTwo, out intGuessTwo) && (intGuessTwo <= 8) && (intGuessTwo >= 1))
                            {
                                keepLoopingTwo = false;

                                if (backend[intGuess - 1, intGuessTwo - 1] == 1)
                                {
                                    Console.WriteLine("Hit!");
                                    display[intGuess - 1, intGuessTwo - 1] = 1;
                                    hits++;
                                    if (hits == win)
                                    {
                                        Console.WriteLine("You Win! Hit 'enter' to play again, or type 'exit' to quit.");
                                        exit = Console.ReadLine();
                                        display = new int[8, 8];
                                        hits = 0;
                                        if (exit.ToLower() == "exit")
                                        {
                                            keepLooping = false;
                                            gameLoop = false;
                                            break;
                                        }
                                        else
                                        {
                                            keepLooping = true;
                                            break;
                                        }
                                    }
                                    keepLooping = true;
                                }
                                else
                                {
                                    display[intGuess - 1, intGuessTwo - 1] = 3;
                                    Console.WriteLine("You suck.");
                                    keepLooping = true;

                                }

                            }
                        }
                    }
                }
            }
        }
    }
}

                    
                
            
        
    

