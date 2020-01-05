using System;

namespace conditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string seperator = "--------------";

            int firstNum = 4;
            int secondNum = 5;
            if ( firstNum < secondNum) 
            {
                System.Console.WriteLine("4 is less than 5");
            }
            else
            {
                System.Console.WriteLine("4 is larger than 5");
            }
            System.Console.WriteLine("after an IF will execute regardless");
            System.Console.WriteLine(seperator);

            System.Console.WriteLine("Input username: ");
            string tempUsername = Console.ReadLine();

            System.Console.WriteLine("Input password");
            string tempPassword = Console.ReadLine();

            System.Console.WriteLine(tempPassword);

            if ( tempUsername.Length >= 6 && tempUsername.Length < 14 ) {
                string username = tempUsername;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(username);
            Console.ResetColor();

            if (tempPassword.Length >= 6 && tempPassword.Length <=12) {
                string password = tempPassword;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine(password);
                Console.ResetColor();
            }
            else { Console.BackgroundColor = ConsoleColor.Red; 
            System.Console.WriteLine(tempPassword);
            }
            }
        }
    }
}
