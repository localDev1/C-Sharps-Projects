using System;
using System.Runtime;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user to enter the numbber current day of the week.
            Console.WriteLine("\n\n\tEnter the current day of the week");


            try
            {
                //Assign the value to a variable of that enum data type you just created.
                string dayUser = Console.ReadLine();

                //Parsing the integer to enum DaysOfWeek
                DiasSemana day = (DiasSemana)Enum.Parse(typeof(DiasSemana), dayUser);
                Console.Write("\n\tThe current Day is : " + day);

            }
            catch 
            {
                //if an error occurs to converting 
                Console.Write("\n\n\t Please enter an actual day of the week");
            }

            Console.ReadLine();


        }

        
    }
}
