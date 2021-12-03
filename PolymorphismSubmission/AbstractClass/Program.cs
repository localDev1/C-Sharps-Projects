using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object of type IQuittable using Polymorphism
            IQuittable employee = new Employee();

           //Call the Quit() method on the object employee.
            employee.Quit();

            Console.ReadLine();

        }
    }
}
