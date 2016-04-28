using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] firstarray = new int[3] { 1, 2, 3 };
            ArrayHelper newarray = new ArrayHelper();

            bool looping = true;
            while (looping)
            {

            newarray.Add((Convert.ToInt16(Console.ReadLine())));
            
            for (int i = 0; i < newarray.Length(); i++)
            {
                Console.WriteLine(newarray.IntegerArray[i]);
            }
                        }
        }
    }
    class ArrayHelper
    {
        public int[] IntegerArray = new int[] { 1, 2, 3 };
        public void Add(int number)
        {
            int[] temparray = new int[IntegerArray.Length+1];
            for (int i = 0; i < IntegerArray.Length; i++)
            {
                temparray[i] = IntegerArray[i];

            }
            int nextnumber = number;
            temparray[temparray.Length - 1] = nextnumber;
            IntegerArray = temparray;
            

        }
        public int Length()
        {
            return IntegerArray.Length;
        }
        
    }
}
