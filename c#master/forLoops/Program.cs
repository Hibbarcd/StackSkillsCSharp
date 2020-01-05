using System;

namespace forLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = 1;

            // while(number < 10) {
            //     Console.Write(number);
            //     number++;
            // }
            // for ( int i = 1; i<=10; i++ ) {
            //     System.Console.WriteLine(i);
            // }

            int[] numbers = { 4, 5, 8, 12 };
            // always use < instead of <= because it keeps array data in bounds
            for (int i = 0; i < numbers.Length; i++)
            {
               Console.WriteLine(numbers[i]);
            }
        }
    }
}
