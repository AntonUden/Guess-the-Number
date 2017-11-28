using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int attempts = 0;
            int max = 1000;
            bool win = false;
            int number = random.Next(max);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Guess The Number");
            Console.WriteLine("0 - " + max);
            Console.Title = attempts + " Attempts";
            while (!win)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                try
                {
                    int guess = int.Parse(Console.ReadLine());
                    attempts++;
                    Console.Title = attempts + " Attempts";
                    if (guess > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nope, it´s smaller. Try Again");
                    }
                    else if (guess < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nope, it´s larger. Try Again");
                    }
                    else if (guess == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You win, the number was " + number);
                        win = true;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error invalid input. Try again");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}