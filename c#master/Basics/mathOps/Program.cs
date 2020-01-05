using System;

namespace mathOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secNumber = 10;
            int thirdNumber = 15;
            string seperator =  "----------------------";

            int additionTotal = firstNumber + secNumber;
            int subtractionTotal = firstNumber - secNumber;
            int multipTotal = firstNumber * secNumber;
            double divisionTotal = (double)firstNumber / (double)secNumber;
            double modulusTotal = (double)firstNumber % (double)secNumber;

            System.Console.WriteLine("addition " + additionTotal);
            System.Console.WriteLine("subtraction " + subtractionTotal);
            System.Console.WriteLine("multiplication " + multipTotal);
                // division operations will not work correctly with int values
            System.Console.WriteLine("division " + divisionTotal);
            System.Console.WriteLine("Remainder " + modulusTotal);

                System.Console.WriteLine(seperator);

            int equation = firstNumber * (secNumber - thirdNumber);
            System.Console.WriteLine(equation);
            
            double testEquation = ((3/7) + Math.Pow(5,2)) / (3 + (4/3));
            System.Console.WriteLine(testEquation);
            System.Console.WriteLine(seperator);

            System.Console.WriteLine(firstNumber);
                int randomNumber = 4;
                randomNumber++;     // randomNumber + 1
                // ++ and -- are as expected increments and decrements
                // also there is -=    *=     /=    %= which do as expected

                firstNumber += secNumber;  // firstNumber + secNumber
            System.Console.WriteLine(firstNumber);  // firstNumber becomes 15 

            System.Console.WriteLine(seperator);
        //===================================================================================
            // Comparison operators ------>         <, >, ==, !=, >=, <=
            int newNumber = 8;
            int otherNum = 4;

            System.Console.Write(newNumber > otherNum);  
            System.Console.Write(" 8 > 4 \n");
            // can also be done as bool isFirstNumGreaterThanSecondNum = newNumber > otherNum ----outputs---> true
            System.Console.Write(newNumber < otherNum);  
            System.Console.Write(" 8 < 4 \n");
            // can also be done as bool isFirstNumSmallerThanSecondNum = newNumber < otherNum ----outputs---> false
            System.Console.Write(newNumber == otherNum); 
            System.Console.Write(" 8 == 4  \n");
            System.Console.Write(newNumber != otherNum); 
            System.Console.Write(" 8 != 4 \n");

        System.Console.WriteLine(seperator);

        string name = "Dave";
        // for strings......
        System.Console.WriteLine(name.Length);
        System.Console.WriteLine(name.Length == "Samuel".Length);
        System.Console.WriteLine(seperator);

        //==============================================================================
        int number = 10;
        bool lessThan = number < 20;
        bool greaterThan = number > 5;
        bool isInRange = lessThan && greaterThan;
        // &&  || operators function as expected in this language

        System.Console.WriteLine(lessThan);
        System.Console.WriteLine(greaterThan);
        System.Console.WriteLine(isInRange);
        
        System.Console.WriteLine(seperator);
        string username = "prettyboy66";

        bool conditionsTrue = ((int)username[0] >= 65 && (int)username[0] <= 90) || (username.Length > 6);
        System.Console.WriteLine(conditionsTrue);
        System.Console.WriteLine(seperator);

        bool secondaryValidation = (username != "admin") 
        // conditions are : username doesnt equal admin.....first letter is not a number or capital letter
        //....within a range of 6-14 chars
        && (username.Length >= 6 && username.Length <= 14) 
        && (int)username[0] >= 97 && (int)username[0] <= 122
        &&  !((int)username[0] >= 48 && (int)username[0] <= 57);

        System.Console.WriteLine(secondaryValidation);
        }
    }
}
