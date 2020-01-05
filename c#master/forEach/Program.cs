using System;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 4, 5, 7};

            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
            foreach (var item in array)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
