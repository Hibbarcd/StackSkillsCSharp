using System;

namespace formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string seperator = "========================";
            string fruit = "Strawberry";
            string juice = "Juice";
            int dollarSigns = 10000;

            System.Console.WriteLine("{0,10}",fruit);
            System.Console.WriteLine("{0,10}",juice);
            System.Console.WriteLine(seperator);
    //output is Strawberry
    //               juice because strawberry is 10 chars, juice is 5. {0,10} signifies end of "juice" must be at place 10
            System.Console.WriteLine("{0,15}",fruit);
            System.Console.WriteLine("{0,10}",juice);
            System.Console.WriteLine(seperator);

            // string interpolation will also work for this
            System.Console.WriteLine($"{fruit,13}");
            System.Console.WriteLine($"{juice,15}");
            System.Console.WriteLine(seperator);

            System.Console.WriteLine($"{dollarSigns,14:C}");
            // :C provides a dollar sign stuck to front of value
            System.Console.WriteLine(seperator);
            
            string header = "Protein Intake Week 1:";
            // string sep = "======================"; one way to get exact length is to count char length of header...
            string sepOptimized = new string('=', header.Length);
            //better way to do it is based on string.Length property
            double day1 = 45.3423;
            double day2 = 75.3923;
            double day3 = 55.3493;
            double day4 = 47.349;
            double day5 = 73.3493;
            double day6 = 55.3493;
            double day7 = 95.3923;
            double total = day1 + day2 + day3 + day4 + day5 + day6 + day7;

                    System.Console.Write("|");
            System.Console.Write(header);
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write(sepOptimized);
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day1, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day2, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day3, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day4, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day5, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day6, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"{day7, 22}");
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write(sepOptimized);
                    System.Console.Write("|\n");
                    System.Console.Write("|");
            System.Console.Write($"Total:{total, 16}");
                    System.Console.Write("|");

        }
    }
}
