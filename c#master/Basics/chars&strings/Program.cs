using System;

namespace chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char theCharacterX = 'x';
            //must be single quotes and one char only long
            char thePlusSign = '\u002b';
            //ascii table to generate + sign via altering 0000 into 002b
            //unicode table has even more symbols to choose from
            char oomlaut = '\u00f6';
            System.Console.WriteLine(oomlaut);
            char testChar = '\u022A';
            System.Console.WriteLine(testChar);

            //string manipulations
            string username = "admin";
            //print out the a char only, c# indexes at 0 like JS
            System.Console.WriteLine(username[0]);
            //change char at a specific set point...but it doesn't work like this....strings are imutable

            // string username[0] = "b";
            // System.Console.WriteLine(username[0]);
        }
    }
}
