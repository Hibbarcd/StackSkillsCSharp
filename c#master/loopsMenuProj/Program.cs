using System;

namespace loopsMenuProj
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int choice = 0;
            bool newChoice = false;
            string[] fruits = new string[10];
            fruits[0] = "Lemon";
            fruits[3] = "Soursop";

            while(!newChoice) 
            {
            Console.WriteLine("1. Add New Item" +
            "\n2. Edit Item" +
            "\n3. Remove Item" +
            "\n4. View ALL Items" +
            "\n5. Exit" +
            "\nYour Choice: ");
            System.Console.WriteLine();
            choice = Convert.ToInt32(Console.ReadLine());

            switch(choice) {
                    //Add new
                    case 1:
                        AddFruits(fruits);
                        break;
                    //Edit 
                    case 2:
                        int chosenFruit = EditFruits(fruits);
                        break;
                    // Remove 
                    case 3:
                        chosenFruit = RemoveFruit(fruits);
                        break;
                    // view ALL
                    case 4:
                        ViewAll(fruits);
                        break;
                    // exit
                    case 5:
                    newChoice = true;
                    break;

                default:
                    Console.WriteLine("invalid choice, please choose again: ");
                    break;
            }
            }
        }

        private static void ViewAll(string[] fruits)
        {
            Console.WriteLine("\nCurrent Fruits: ");
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] != null)
                {
                    Console.WriteLine($" {i + 1} {fruits[i]}");
                    System.Console.WriteLine();
                }
            }
        }

        private static int RemoveFruit(string[] fruits)
        {
            int chosenFruit;
            Console.WriteLine("\nWhich fruit do you want removed? (1-10): ");
            chosenFruit = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{fruits[chosenFruit - 1]} was removed");
            Console.ResetColor();
            fruits[chosenFruit - 1] = null;
            // to remove null spaces and allow fruits to fall into proper array alignment:
            string[] tempArray = new string[fruits.Length];
            int tempArrayIndex = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] != null)
                {
                    tempArray[tempArrayIndex] = fruits[i];
                    tempArrayIndex++;
                }
            }

            Array.Copy(tempArray, fruits, tempArray.Length);
            System.Console.WriteLine();
            return chosenFruit;
        }

        private static int EditFruits(string[] fruits)
        {
            int chosenFruit = 0;
            Console.WriteLine("\nWhich fruit do you want to edit? (1-10): ");
            chosenFruit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fruit substitute: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{fruits[chosenFruit - 1]}");
            Console.ResetColor();
            System.Console.Write(": ");

            fruits[chosenFruit - 1] = Console.ReadLine();
            Console.WriteLine();
            return chosenFruit;
        }

        private static void AddFruits(string[] fruits)
        {
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == null)
                {
                    Console.WriteLine("Please add new fruit: ");
                    fruits[i] = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"{fruits[i]} was added");
                    Console.ResetColor();
                    break;
                }

            }
        }
    }
}
