using System;

namespace colorizedTextAdv
{
    class Program
    {
        static void Main(string[] args)
        {   


            string header = "Protein Intake Week 1:";
            string sepOptimized = new string('=', header.Length);

            // string sep = "======================"; one way to get exact length is to count char length of header...
            //better way to do it is based on string.Length property
            double day1 = 45.3423;
            double day2 = 75.3923;
            double day3 = 55.3493;
            double day4 = 47.349;
            double day5 = 73.3493;
            double day6 = 55.3493;
            double day7 = 95.3923;
            double total = day1 + day2 + day3 + day4 + day5 + day6 + day7;
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
             // alternate methoid is to assign color to a variable for use later
             // ConsoleColor sepColor = Console.Color.DarkRed;
             
                Console.Write("|");
            Console.Write(sepOptimized);
            Console.Write("|\n");
                Console.Write("|");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write(header);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write(sepOptimized);
                    Console.Write("|\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("|");
            Console.Write($"{day1, 22:N2}");
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write($"{day2, 22:N2}");
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write($"{day3, 22:N2}");
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write($"{day4, 22:N2}");
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write($"{day5, 22:N2}");
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write($"{day6, 22:N2}");
                    Console.Write("|\n");
                    Console.Write("|");
            Console.Write($"{day7, 22:N2}");
                    Console.Write("|\n");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("|");
            Console.Write(sepOptimized);
                    Console.Write("|\n");
                    Console.Write("|");
                Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write($"Total:{total, 16:N2}");
                Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("|\n");
                    Console.Write("|");
                    System.Console.Write(sepOptimized);
                    Console.Write("|");
// Set window size to only big enough to show table values
        Console.SetWindowSize(25,15);
        Console.BufferWidth = 25;
//Await keystroke to exit program
        Console.WriteLine("Press any key to exit...");
              Console.ReadLine();  
        }
    }
}
