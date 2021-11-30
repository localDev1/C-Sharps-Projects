using System;

namespace doAndWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool follow = true;

            //The while statement will only be executed if the variable is true from the beginning.
            while (follow)
            {
                //Enter a number between 0 - 3
                Console.WriteLine("\n\n\tEnter a number (0-3)");
                //convert the string to int
                number = Convert.ToInt32(Console.ReadLine());

                //switch statement to select the correct case
                switch (number)
                {
                    case 0:
                        Console.WriteLine("\tThe number is 0");
                        break;
                    case 1:
                        Console.WriteLine("\tThe number is 1");
                        break;
                    case 2:
                        Console.WriteLine("\tThe number is 2");
                        break;
                    case 3:
                        Console.WriteLine("\tThe number is 3");
                        break;
                    default:
                        Console.WriteLine("\tuhhhhh, don't entered a number between 0 and 3");
                        break;

                }
                //if you want keep in the program you must type true or false. Otherwise an error will appear
                Console.WriteLine("\n\tDo you want to follow (true/false)");
                try
                {
                    follow = Convert.ToBoolean(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You dont typed true or false......");
                }
            }


            //do while statement. allways will be executed once
            do
            {

                Console.WriteLine("\n\twill only run it once!!!");
                Console.ReadLine();

            } while (follow);//If you are here, is because the follow is false.

          





        }
    }
}
