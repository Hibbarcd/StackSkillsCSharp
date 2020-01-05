using System;

namespace nestedConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 6;
            int c = 9;
            string sorted = string.Empty;
            // should be 3 conditionals if doing this completely, checking each var for size comparison

            if ((a < b) && (a < c)) {
                sorted = a + " ";
                if (b < c ) {
                    sorted = sorted + b + " " + c;
                }
                else {sorted = sorted + " " + c + " " + b;
                };
            }
            System.Console.WriteLine(sorted);
        }
    }
}
