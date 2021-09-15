using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleIfExample();
            //SwitchExample();
            //AndOrExample();

            var startNumber = GetNumberFromUser("Enter start number");
            var endNumber = GetNumberFromUser("Enter end number");

            ForExample(startNumber, endNumber);


        }

        private static int GetNumberFromUser(string question)
        {
            Console.WriteLine(question);
            bool isResultValid = false;
            int result = 0;
            while (!isResultValid)
            {
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    isResultValid = true;
                }
                else
                {
                    Console.WriteLine("Please enter valid number");
                }
            }

            return result;
        }

        private static void ForExample(int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
                Console.WriteLine($"Current number {i}, sum so far {sum}");
            }

            Console.WriteLine($"sum of all numbers between {start} and {end} equals {sum}");
        }
        private static void SimpleIfExample()
        {
            Console.WriteLine("I've heard you are making LARPS. Enter your name:");
            var name = Console.ReadLine();
            if (name == "Dextir")
            {
                Console.WriteLine("Ahhh, Again \"Dexter's Games\"");
            }
            else if (name == "Charles")
            {
                Console.WriteLine("Oh no, I don't earn that much to buy costume");
            }
            else
            {
                Console.WriteLine("Ok, lets go LARPING!!!!!");
            }
        }

        private static void SwitchExample()
        {
            Console.WriteLine("What is your favourite color?");
            var color = Console.ReadLine();
            switch (color.ToUpperInvariant().Trim())
            {
                case "RED":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Red is beautiful");
                    break;
                case "BLUE":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Blue is like the sky");
                    break;
                case "GREEN":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You love forests?");
                    break;
                default:
                    Console.WriteLine("Sorry, I dont know that color");
                    break;
            }
        }

        private static void AndOrExample()
        {
            Console.WriteLine("Please enter a number more than 1 but less than 4");
            var stringNumber = Console.ReadLine().ToUpperInvariant();
            if (int.TryParse(stringNumber, out int intNumber) || stringNumber == "TWO" || stringNumber == "THREE")
            {
                if (stringNumber == "TWO")
                {
                    intNumber = 2;
                }
                if (stringNumber == "THREE")
                {
                    intNumber = 3;
                }
                if (intNumber > 1 && intNumber < 4)
                {
                    Console.WriteLine("Your IQ is more than 20!");
                }
                else
                {
                    Console.WriteLine("Your IQ is less than 20...");
                }
            }
            else
            {
                Console.WriteLine("Common! I have asked for a number!");
            }
        }
    }
}
