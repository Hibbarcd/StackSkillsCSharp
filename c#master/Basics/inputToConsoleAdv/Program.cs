using System;

namespace inputToConsoleAdv
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Console.Write("How old are you?");
        //         int age = int.Parse(Console.ReadLine());
        //         string strAge = Console.ReadLine();

        //    System.Console.WriteLine($"My age is {age + 1}");
        //    System.Console.WriteLine($"My age is {strAge + 1}");

           Console.Write("Input drive name: ");
                string driveInitial = Console.ReadLine();
                string drive = driveInitial.ToUpper();
            Console.Write("Input the folder path: ");
                string path = Console.ReadLine();
            Console.Write("Input the file name: ");
                string file = Console.ReadLine();
            System.Console.WriteLine($"{drive}:\\{path}\\{file}.exe");


        }
    }
}
