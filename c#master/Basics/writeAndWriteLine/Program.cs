using System;

namespace writeAndWriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string seperator = "---------------------------------------";

            Console.Write("I am ");
            //cursor stays on the same line when this is used unless \n is used afterward
            Console.Write(" testing ");
            Console.Write(" Console.write\n ");

            System.Console.WriteLine(seperator);

            System.Console.WriteLine("I am ");
            // \n used with WriteLine provides a free space after the output
            System.Console.WriteLine(" testing ");
            System.Console.WriteLine("Console.WriteLine");
            System.Console.WriteLine(seperator);

            Console.Write("1.Option 1" +
            "\n2.Option 2" +
            "\n3.Option 3" +
            "\n4.Exit" +
            "\nYour Choice: ");
            System.Console.WriteLine(seperator);

            string exeFile = "word.exe";
            string pathToExe = "\"C:\\Program Files\\MicrosoftWord\\";
            System.Console.WriteLine(pathToExe + exeFile);
            //outputs only single slash, since \ is an escape character....exe \n is for new line, \" will display "
            System.Console.WriteLine(@"""C:\Program Files\MicrosoftWord\");
            // the " acts as an escape character in this case
            System.Console.WriteLine("C:\\Program Files\\\"Microsoft Programs\"\\'Visual Studio'");


        }
    }
}
