using System.Runtime.CompilerServices;
using System;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = Convert.ToInt32(Console.ReadLine()); 

            // switch(number) 
            // {
            //     case 1:
            //     System.Console.WriteLine($"The number is {number}");
            //     break;

            //     case 2:
            //     System.Console.WriteLine($"The number is {number}");
            //     break;

            //     case 3:
            //     System.Console.WriteLine($"The number is {number}");
            //     break;

            //     default:
            //     System.Console.WriteLine($"The number {number} doesn't match any given cases");
            //     break;


            System.Console.WriteLine("1.Add new item " +
            "\n2.Edit item " + 
            "\n3.Delete item " +
            "\n4.Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice) 
            {
                case 1:
                System.Console.WriteLine($"Performing add new item");
                break;

                case 2:
                System.Console.WriteLine($"Performing edit to item");
                break;

                case 3:
                System.Console.WriteLine($"Performing deletion of item");
                break;

                case 4:
                System.Console.WriteLine($"Exiting.....");
                Environment.Exit(0);
                break;

                default:
                System.Console.WriteLine($"Choice number invalid");
                break;
            }
        }
    }
}
