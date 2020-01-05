using System.Runtime.Intrinsics.X86;
using System.Collections.Specialized;
using System.Text;
using System;

namespace elseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // int firstNum = 5;
            // int secondNum = 6;

            // if ( firstNum > secondNum) {
            //     System.Console.WriteLine($" {firstNum} is larger than {secondNum}");
            // }
            // else if ( firstNum == secondNum ) {
            //     System.Console.WriteLine($" {firstNum} is equal to {secondNum}");
            // }
            // else {System.Console.WriteLine($" {firstNum} is not larger than {secondNum}");}

            int enemyDead = 100;
            // way to designate string without value yet to be input by user
            // string playerName = string.Empty;

            System.Console.WriteLine("Input Player Name");
            string playerName = Console.ReadLine();

            double xp = (.6 * enemyDead);


            if (enemyDead == 100) {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{playerName} has vanquished {enemyDead} enemies, and gains {xp}xp!!");
                Console.ResetColor();
            }
            else if (enemyDead >= 75) {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"{playerName} has vanquished {enemyDead} enemies, and gains {xp}xp!!");
                Console.ResetColor();
            }
            else {
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"You have failed, {playerName}!");
                Console.ResetColor();
                }

            }
         }
    }

