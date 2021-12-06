using System;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter the numbber current day of the week.
            Console.WriteLine("\n\n\tEnter the number current day of the week");


            try
            {
                //Assign the value to a variable of that enum data type you just created.
                int dayUser = Convert.ToInt32(Console.ReadLine());

                //Parsing the integer to enum DaysOfWeek
                DaysOfWeek day = (DaysOfWeek)dayUser;
                Console.Write("The current Day is :" + day);

            }
            catch 
            {
                //if an error occurs to converting 
                Console.Write("Please enter an actual day of the week");
            }

            Console.ReadLine();


        }
    }
}
