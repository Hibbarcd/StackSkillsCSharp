using System;

namespace colorizedText
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.BackgroundColor = ConsoleColor.Green;
            //assigns color only after it is declared, so if done at end of program, has no effect
                Console.WriteLine("The turtle has made it to water");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The circle of live is viscious");

            Console.Write("Marche ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("Au ");
            Console.ResetColor();
            Console.Write("Creve!\n");
            //resets to default
        }
    }
}
