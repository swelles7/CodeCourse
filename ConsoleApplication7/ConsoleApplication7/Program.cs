using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static string Encrypt(string message)
        {
            string result = "";
            char[] charArray;
            charArray = message.ToCharArray();

            for (int i=0; i < charArray.Length; i++)
            {
                charArray[i]++;
                result += charArray[i];
            }
            Console.WriteLine(result);
            return result;
        }
        static string UnEncrypt(string message)
        {
            string result = "";
            char[] charArray;
            charArray = message.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i]--;
                result += charArray[i];
            }
            return result;
        }


        static void Main(string[] args)
        {
            string[] messages = new string[50];
            int messageID = 0;
            string choice = "";

            while (messageID < 50)
            {
                Console.WriteLine("Hello, would you like to: \n\nA) Save a message \nB) Retrieve a message\nC) Exit");
                choice = Console.ReadLine().ToLower();
                //Save a message
                if (choice == "a")
                {
                    Console.WriteLine("Enter your message");
                    choice = Console.ReadLine();
                    messages[++messageID] = Encrypt(choice);
                    Console.WriteLine("Your message has been saves as Message ID" + messageID + "\n");
                }
                //Retrieve a message
                if (choice == "b")
                {
                    Console.WriteLine("Choose message ID:");
                    string unscrambledmessage = UnEncrypt(messages[Convert.ToInt16(Console.ReadLine())]);
                    Console.WriteLine(unscrambledmessage);
                    Console.ReadLine();                   
                }
                //Exit
                if (choice == "C")
                {
                    messageID = 55;
                }
            }
        }
    }
}
