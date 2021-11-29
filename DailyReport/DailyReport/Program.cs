using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program must start by printing “The Tech Academy.”
            Console.WriteLine("\n\n\t\t\tThe Tech Academy");

            //The next line must be “Student Daily Report.”
            Console.WriteLine("\n\n\t\t\tStudent Daily Report");

            //The DR must contain the following questions:

            //Introduce the name like string
            Console.WriteLine("\n\tWhat is your name?");
            string yourName = Console.ReadLine();

            //Introduce the course name like string
            Console.WriteLine("\n\tWhat course are you on?");
            string course = Console.ReadLine();

            //Convert a String in Integer
            Console.WriteLine("\n\tWhat page number?");
            int page = Convert.ToInt32(Console.ReadLine());

            //Convert a String in Boolean 
            Console.WriteLine("\n\tDo you need help with anything? Please answer \"true\" or \"false\".");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //Introduce the experiences like string
            Console.WriteLine("\n\tWere there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();


            //Introduce the feedback like string
            Console.WriteLine("\n\tIs there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Convert a string to byte
            Console.WriteLine("\n\tHow many hours did you study today?");
            byte hours = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("\n\tThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
