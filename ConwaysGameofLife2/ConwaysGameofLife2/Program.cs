using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameofLife2
{
    class Program
    {
        static bool [,] CreateGrid()
        {
            bool[,] grid = new bool[40, 40];
            Random rnd = new Random();
            for (int i =0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    
                    if(rnd.Next(2)>0)
                    {
                        grid[i, j] = true;
                    }
                    else
                    {
                        grid[i, j] = false;
                    }
                }
                                
            }
            return grid;
        }

        static void Draw(bool[,] grid)
        {
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if(grid[i,j])
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
               Console.Write("\n");
            }
        
        }

        static bool[,] NextGeneration(bool[,] grid)
        {
            
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    int neighbors = NumNeighbors(i, j, grid);
                    if (grid[i, j])
                    {
                        if(neighbors < 2)
                        {
                            grid[i, j] = false;
                        }
                        else if (neighbors == 2 || neighbors == 3)
                        {
                            grid[i, j] = true;
                        }
                        else
                        {
                            grid[i, j] = false;
                        }
                        
                    }
                    else if(neighbors == 3)
                    {
                        grid[i, j] = true;
                    }

                    
                }
            }
            return grid;
        }

        static int NumNeighbors(int x, int y, bool[,] grid)
        {
            int lowx = 0;
            int highx = 0;
            int lowy = 0;
            int highy = 0;
            int neighbors = 0;

            if (x > 0)
            {
                lowx = x - 1;
            }
            else
            {
                lowx = x;
            }
            if(x < 39)
            {
                highx = x + 1;
            }
            else
            {
                highx = x;
            }
            if (y > 0)
            {
               lowy = y - 1;
            }
            else
            {
                lowy = y;
            }
            if (y < 39)
            {
                highy = y + 1;
            }
            else
            {
                highy = y;
            }
            for (int i = lowx; i <= highx; i++)
            {
                for(int j = lowy; j <= highy; j++)
                {
                    if (grid[i, j])
                    {
                        neighbors++;
                    }
                }
                
            }
            if (grid[x, y])
            {
                neighbors--;
            }
            return neighbors;


        }

        static void Main(string[] args)
        {
            bool[,] grid = CreateGrid(); //Creating and storing a 2x2 array grid
            Draw(grid); //Draw the original grid

            while(true)
            {
                bool[,] newgrid = NextGeneration(grid);
                Console.Clear();
                Draw(newgrid);

                System.Threading.Thread.Sleep(500); 
               

            }
        }
    }
}
