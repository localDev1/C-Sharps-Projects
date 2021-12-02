using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class Divide.
            Divide division = new Divide();


            //The user enter a number
            Console.WriteLine("\n\n\tEnter a number :");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //Display the output to the screen. The user number divided by two.
            division.Division(userNumber);            

            //Using the overload method with output parameter
            int f = 0;
            division.Division(userNumber, out f);

            Console.WriteLine("\n\n\t Using a method Overloading wiht out parameters. \n\t The Result of dividing " + userNumber + " by 10 is " + f);  
            
            //Using a static class
            StaticClass.Question();

            Console.ReadLine();
        }
    }
}
