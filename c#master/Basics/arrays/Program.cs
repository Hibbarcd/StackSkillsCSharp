using System.Globalization;
using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 5, 6, 3, 2 };
            // or to create an array a different way....
                System.Console.WriteLine(numbers[2]);

             //declare seperation string for ease of viewing   
            string seperator = "----------------------------------------";
                //alternate method is to use string seperator = new string("-",40) which repeats - 40x

            int[] numbersExampleTwo = new int[5];
            //this array has 5 values of default type int...and theyre all 0 because they havent been set otherwise
                System.Console.WriteLine(numbersExampleTwo[2]);
            //reassigning values in this array to something else 
                numbersExampleTwo[2] = 15;
                numbersExampleTwo[3] = 20;
                System.Console.WriteLine(numbersExampleTwo[3]);


            string[] stringArrayExample = { "apple", "pear", "orange", "cumquot"};
                System.Console.WriteLine(stringArrayExample);

            string[] stringArrayTwo = new string[5];
                stringArrayTwo[0] = "lime";
                stringArrayTwo[1] = "lemon";
                stringArrayTwo[2] = "melon";
                stringArrayTwo[3] = "dragonfruit";
                stringArrayTwo[4] = "soursop";

                System.Console.WriteLine(stringArrayTwo[3]);
                // to get a specific char from a specifc element of the array...
                System.Console.WriteLine(stringArrayExample[2][3]);
                System.Console.WriteLine(seperator);
               
                string fruitJuice = "Strawberry juIce";
                    Console.WriteLine(fruitJuice.Contains("f"));
                    System.Console.WriteLine(seperator);
                //does the string contain a specific value?
                    System.Console.WriteLine(fruitJuice.IndexOf("r"));
                    System.Console.WriteLine(seperator);

                //points to where in the array a specific value is found, if not found value output is -1
                    System.Console.WriteLine(fruitJuice.LastIndexOf("r"));
                    System.Console.WriteLine(seperator);

                //points to last point in string that contains this value
                fruitJuice = fruitJuice.ToLower();
                //reassign string to all lower case
                    System.Console.WriteLine(fruitJuice);
                    System.Console.WriteLine(seperator);

                bool containStraw = fruitJuice.Contains("straw");
                    System.Console.WriteLine(containStraw);
                    System.Console.WriteLine(seperator);

                int bigNumber = 432565643;
                // must convert into string to search index of value of an int
                    System.Console.WriteLine(bigNumber.ToString().Contains("5"));
                    System.Console.WriteLine(bigNumber.ToString().IndexOf("5"));
                    System.Console.WriteLine(bigNumber.ToString().LastIndexOf("5"));
                    System.Console.WriteLine(seperator);

                string iAmLearning = "I am learning ";
                string course = "c# mastercourse";
                string concatenated = iAmLearning + course;

                System.Console.WriteLine(concatenated + bigNumber);
                //adding a number var to a string doesn't require use of ToString()
                System.Console.WriteLine(iAmLearning + course);

        }
    }
}
