using System.Threading;
using System;

namespace loopsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // int counter = 0;

            // while(counter < 10) {
            //     System.Console.WriteLine("I am learning about loops");
            //     counter++;
            int min = 20;
            int max = 30;
            bool isInRange = false;

            while (!isInRange) {
                System.Console.WriteLine("Input number between 20 and 30");
                    int number = Convert.ToInt32(Console.ReadLine());
                if( number < min || number > max) {
                    Console.WriteLine("input value is not within the range needed");
                    isInRange = false;
                    //Thread.Sleep pauses the output, in this case for 2 seconds
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else{
                    Console.WriteLine($"The input value {number} is in the required range");
                    break;
                    }

                }
               // Do while loops will always run once, because it checks the code that runs agains the condition at the end
                // do{}
                // while();
            

        }
    }
}
