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

            //Converting string to int
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 24) 
            {
                //Converting int to datatime 
                DateTime hours = new DateTime(1975, 3, 23, x, 59, 59);

                Console.WriteLine("\n\n\tThe user hour is : " + hours.Hour);
            }

            else 
            {
                Console.WriteLine("you dont introduce a number less 24");
            }
            Console.ReadLine();
        }
    }
}
