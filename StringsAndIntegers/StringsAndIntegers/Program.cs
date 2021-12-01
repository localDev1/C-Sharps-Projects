using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE APP STRINGS AND INTEGERS SUBMISSION ASSIGNMENT
            //Create a list of integers
            List<int> listInt = new List<int>() {1,2,4,6,7,8,9,10,15,14,18,1,9,20,50,100,500};                     

            int division = 0;

            try
            {
                //Asking the user for a number
                Console.WriteLine("\n\n\tEnter a number : ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                //A loop that takes each integer in the list, divides it by the number the user entered
                foreach (int number in listInt)
                {

                    division = number / userNumber;
                    //displays the result to the screen.
                    Console.WriteLine("The result of dividing " + number + "   by " + userNumber + "  is: " + division);
                    
                }
            }
            //catching the error to divide by zero
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\n\tPlease, dont divide by zero");
            }
            //catching the error to enter a string like a number
            catch (FormatException e) 
            {
                Console.WriteLine("\n\tType the correct format");
            }
            //catching anywhere error
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                Console.WriteLine("\n\tThe program has emerged from the try/catch block and continue on with program execution");
                Console.ReadLine();
            }

           


        }
    }
}
