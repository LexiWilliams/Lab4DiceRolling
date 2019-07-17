using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4DiceRolling
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Circus Casino.");
            string roll = "";

            
                if (roll != "y" && roll != "n")
                {
                    Console.WriteLine("Would you like to roll the dice? y/n");
                    roll = Console.ReadLine().ToLower();
                }

            
            bool rollDice = true;
            while (rollDice)
            {
                string rollAgain = "";
                if (roll == "y")
                {
                    int sides = CountSides("How many sides should each die have?");

                    int num1 = GenerateRandomNumber(sides);
                    int num2 = GenerateRandomNumber(sides);

                    Console.WriteLine($"Die 1: {num1} Die 2: {num2}");
                }
                else
                {
                    Console.WriteLine("Goodbye.");
                }

                bool repeat = true;
                while (repeat)
                {
                    Console.WriteLine("Would you like to roll again?");
                    rollAgain = Console.ReadLine().ToLower();

                    if (rollAgain == "y")
                    {
                        rollDice = true;
                        repeat = false;
                    }
                    else if (rollAgain != "y" && rollAgain != "n")
                    {
                        Console.WriteLine("Input was not understood.");
                        repeat = true;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye.");
                        repeat = false;
                        rollDice = false;
                    }
                }
            }

        }
        public static int GenerateRandomNumber(int sides)
        {
            return random.Next(1, (sides + 1));
        }

        public static int CountSides(string message)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int sides))
                {
                    repeat = false;
                    return sides;
                }
                else
                {
                    repeat = true;
                }
            }
            return CountSides(message);

        }

    }
}

