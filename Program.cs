// Creating A Quiz Game as a begineer:
using System;
namespace MyWorld
{
    class CBT
    {
        static void Main(string[]args)
        {
            // Customizations:
            Console.Title = "Quiz-Game";
            Console.WindowHeight = 35;
            Console.WindowWidth = 60;
            
            // Conversation:
            Console.WriteLine("Hello, Sir..");
            Console.WriteLine("Would you like to tell your name sir!");
            string usrName = Console.ReadLine();
            Console.WriteLine("Okay " + usrName + ", Lets Get Started...");

            // Main Game:
            Console.Write("\nWhat is the solution of this Equation ?\n19 X 8 - 12 = ");
            int usrResponse = Convert.ToInt32(Console.ReadLine());

            // Checking:
            if (usrResponse == 140)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Its Correct!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Its Incorrect!");
            }

            // Ending:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tThank You for Playing the Game!\n ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Now, You can press ENTER to [EXIT] ");
            Console.ReadKey();
        }
    }
}