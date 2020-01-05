using System;

namespace elseIfAdv
{
    class Program
    {
        static void Main(string[] args)
        {
        double x = 1;
        double y = 3;
        double radius = 4;
        double distance = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
            if ( distance <= radius) {
                System.Console.WriteLine($"The point ({x},{y}) is within the circle");
            }
            else {System.Console.WriteLine($"the point ({x},{y}) is not within the circle");}
        
        }
    }
}
