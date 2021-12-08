using System;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a const variable.
            const string wel = "Hello everyone!";           

            Console.WriteLine("\n\n\t"+wel);

            Console.WriteLine("\n\n\tEnter your First name:");
            //Using the keyword "var"
            var fname = "";
            fname = Console.ReadLine();
           
            Console.WriteLine("\n\n\tEnter your Last Name");
            //Using the keyword "var"
            var lname = "";
            lname = Console.ReadLine();


            ChainConstructor chain = new ChainConstructor();
            Console.WriteLine("\n\n\t Using the first Constructor the result is :" + chain.firstName + " " + chain.lastName);

            ChainConstructor chain1 = new ChainConstructor(fname, lname);
            Console.WriteLine("\n\n\t Using the Second Constructor the result is :" + chain1.firstName + " " + chain1.lastName);


            Console.ReadLine();

        }
    }
}
