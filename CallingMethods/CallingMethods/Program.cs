using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking the user what number want to do the math operations on
            Console.WriteLine("\n\n\tEnter a Integer number want to do a math operations");

            //Converting string to int
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //Calling the Method ByTen in the Class MathOperations
            Console.WriteLine("\n\tTen times the number " + userNumber + " is " + MathOperations.ByTen(userNumber));

            //Calling the Method ByTen in the Class MathOperations
            Console.WriteLine("\n\tSquare the number " + userNumber + " is " + MathOperations.SquareNumber(userNumber));

            //Calling the Method ByTen in the Class MathOperations
            Console.WriteLine("\n\tDouble the number " + userNumber + " is " + MathOperations.DoubleNumber(userNumber));

            Console.ReadLine();

        }
    }
}
