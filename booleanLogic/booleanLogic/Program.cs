using System;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOOLEAN LOGIC SUBMISSION ASSIGNMENT

           
            //Introduce the age and converting a string to Integer
            Console.WriteLine("\n\tWhat is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //Enter if you have had a DUI
           
            Console.WriteLine("\n\tHave you ever had a DUI? (true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
          
                       
            //Enter the number speeding tickets
            Console.WriteLine("\n\tHow many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            
            //qualification rules to determine if the applicant qualifies for car insurance:
            bool qualified = (age > 15 && dui == false && tickets <=3);

            Console.WriteLine("\n\tQualified?\n  " +qualified);

           
            Console.ReadLine();
        }
    }
}
