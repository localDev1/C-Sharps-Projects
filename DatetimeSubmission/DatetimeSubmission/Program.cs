using System;

namespace DatetimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Printing the current date and time to the console.
            Console.WriteLine("\n\n\tHello World!, We are in the day : " + DateTime.Now);

            //Asking the user a number
            Console.WriteLine("\n\n\tEnter a number less 24");

            //Converting string to double
            double x = Convert.ToDouble(Console.ReadLine());

            //Creating datatime variable
            DateTime hours = DateTime.Now;

            //Adding hours to datatime variable
            hours = hours.AddHours(x);

            Console.WriteLine("\n\n\tThe user hour is : " + hours);
                           
            Console.ReadLine();
        }
    }
}
