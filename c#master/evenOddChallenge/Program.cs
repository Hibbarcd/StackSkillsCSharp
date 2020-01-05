using System;

namespace evenOddChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 2 == 0) {
                System.Console.WriteLine($"Input of {x} is Odd");
            }
            else {System.Console.WriteLine($"Input of {x} is Even");}

            string seperator = "-------------";
            System.Console.WriteLine(seperator);

            string result = x % 2 == 0 ? "Input is Even" : "Input is odd";
            System.Console.WriteLine(result);
            System.Console.WriteLine(seperator);

            System.Console.WriteLine("input number");
            int divisibleNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(divisibleNumber);

            if (divisibleNumber % 2 == 0) {
                System.Console.WriteLine($" {divisibleNumber} can be divided by 2");
            }
            if ( divisibleNumber % 3 == 0) {
                System.Console.WriteLine($" {divisibleNumber} can be divided by 3");
            }
            if ( divisibleNumber % 4 == 0) {
                System.Console.WriteLine($" {divisibleNumber} can be divided by 4");
            }
            System.Console.WriteLine(seperator);

            // check to see if 3rd digit of int is equal to 3
            if (divisibleNumber.ToString()[divisibleNumber.ToString().Length - 3] == '3') {
                System.Console.WriteLine("Input is valid");
                if (divisibleNumber.ToString().Length >= 3) {
                    System.Console.WriteLine($"Input of {divisibleNumber} is invalid, too few digits");
                }
            }
            else {System.Console.WriteLine("input is invalid");}
            System.Console.WriteLine(seperator);

            int testInt = 5;

            if ( testInt > divisibleNumber) {
                divisibleNumber = testInt;
                System.Console.WriteLine(testInt);
            }
            else {divisibleNumber = divisibleNumber.ToString().Length + testInt;
            System.Console.WriteLine(divisibleNumber);
            }

        }
    }
}
