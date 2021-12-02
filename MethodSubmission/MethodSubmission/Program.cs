using System;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class Math
            Math math = new Math();

            //Ask the user to input two numbers. Need not enter anything for the second number.
            Console.WriteLine("\n\n\tEnter two number, the second is opcional");
            Console.WriteLine("\n\tFirst Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\tSecond Number (optional) : ");

            //if it does not have a second number, there will be an error of convertion.
            try
            {
                int number2 = Convert.ToInt32(Console.ReadLine());
               
                Console.Write("\n\tThe result multiplying " + number1 + " by " +number2 +" is " + math.Math_Operation(number1, number2));

                 
            }
            catch 
            {
                Console.Write("\n\tThe result of multiplying " + number1 + " by " + 2 + " is " + math.Math_Operation(number1));
            }


            Console.ReadLine();
        }
    }
}
