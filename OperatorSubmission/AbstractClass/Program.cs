using System;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating two objects Employee
            Employee person1 = new Employee() { Id = 10 };
            
            Employee person2 = new Employee() { Id = 10 };
            


            //Using the overload "==" operator  
            string igual = person1 == person2;

            Console.WriteLine("\n\n\t"+ igual);

            Console.ReadLine();

        }
    }
}
