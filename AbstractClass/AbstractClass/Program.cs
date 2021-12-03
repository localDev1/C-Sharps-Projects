using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an Employee object
            Employee employee = new Employee();

            //Initializing variables
            Console.WriteLine("\n\n\tInitializing variables");
            employee.fisrtName = "Sample";
            employee.lastName = "Student";

            //Call the SayName() method on the object employee.
            employee.SayName();

            Console.ReadLine();

        }
    }
}
