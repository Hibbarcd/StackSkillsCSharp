using System;

namespace typeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            string word = "5";
            //if word is a string, cannot be created as an int var
            char y = 'y';
            float pi = 3.14F;

            float integer = number;
            System.Console.WriteLine(integer);
            //type change is automatic
            //cannot convert float into an int the same way because of loss of info during shift but type casting works
            int floating = (int)pi;
            System.Console.WriteLine(floating);
            // value of pi loses its numbers after decimal point in this situation

            int convertedString = Convert.ToInt32(word) + 5;
            System.Console.WriteLine(convertedString);

            int parsedString = int.Parse(word);
            System.Console.WriteLine(parsedString);
            
        }
    }
}
