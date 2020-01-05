using System;

namespace inputToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you?");
        //    int age = Console.Read();
           char age = (char)Console.Read();
        // this will display only the first char used as an input
           System.Console.WriteLine("My age is " + age);
           // this returns the unicode value  of the char used as an input
        }
    }
}
