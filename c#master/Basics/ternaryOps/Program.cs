using System;

namespace ternaryOps
{
    class Program
    {
        static void Main(string[] args)
        {
            // expression ? true side : false side ;
            string incomingTempUsername = "prettyboy666";
            string seperator = "============================";


            string username = incomingTempUsername.Length > 11 ? incomingTempUsername : "defaultUser";
            Console.BackgroundColor = username.Length > 11 ? ConsoleColor.Red : ConsoleColor.Green;
            
            System.Console.WriteLine(username);
                        
                Console.ResetColor();

            System.Console.WriteLine(seperator);


        }
    }
}
