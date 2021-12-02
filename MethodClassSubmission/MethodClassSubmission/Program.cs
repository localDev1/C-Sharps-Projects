using System;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class Rara.
            Rara method = new Rara();

            //Call the method in the class, passing in two numbers.
            method.raraMethod(10, 15);

            //Call the method in the class, specifying the parameters by name.
            method.raraMethod(x: 15, y: 200);

            Console.ReadLine();
        }
    }
}
