using System;

namespace consoleManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test title";
            Console.CursorVisible = false;
            //no visible curson in terminal window 
            Console.CursorSize = 100;
            //makes cursor equal to 100px
            // Console.SetCursorPosition(50,35);
            // first value dictates where cursor is from left, 2nd one is from top down x spaces
            System.Console.ReadLine();
            Console.WriteLine("test concluded");

        //==============================================================================================
        // Console.SetWindowSize(20,20);
        // or....
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
        Console.SetBufferSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
        Console.SetWindowPosition(Console.LargestWindowWidth,Console.LargestWindowHeight);

        //Largest window positiom = Buffer - window size

        // Console.SetBufferSize(60,30);
        // Console.SetWindowSize(50,20 );
        
        //Largest value for Position is 10,10
        // Console.SetWindowPosition(10,10);
//===============================================================================
        // Console.WindowHeight = 60;
        // Console.WindowWidth = 30;

        // Console.BufferHeight = 70;
        // Console.BufferWidth = 40;

        
        // Console.WindowLeft = 10;
        // Console.WindowTop = 10;

        }
    }
}
