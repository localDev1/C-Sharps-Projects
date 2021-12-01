using System;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class and call the one method
            OverloadMethod methods = new OverloadMethod();
            
            //Using the first case (integer to integer)
            int result = methods.ConvertMethod(7);

            //Display the result to the screen.
            Console.WriteLine("\n\n\tThe result passing a integer is (square): " + result);


            //Using the second case (decimal to integer)
            result = methods.ConvertMethod(7.77m);

            //Display the result to the screen.
            Console.WriteLine("\n\tThe result passing a decimal is (double): " + result);


            //Using the third case (string to integer)
            string message = "";
            //result = methods.ConvertMethod("15",out message);
            result = methods.ConvertMethod("fer", out message);
            if (message == "")
            {
                //Display the result to the screen.
                Console.WriteLine("\n\tThe result passing a string is (by Ten): " + result);
            }
            else 
            {
                Console.WriteLine("\n\tIt was not possible to convert the string to an integer");
            }


            Console.ReadLine();


        }
    }
}
