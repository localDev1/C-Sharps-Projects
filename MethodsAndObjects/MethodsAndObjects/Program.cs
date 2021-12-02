using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initialize an Employee object
            Employee employee = new Employee();

            //initializing an Employee object with a first name of “Sample” and a last name of “Student”.
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Calling the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}
