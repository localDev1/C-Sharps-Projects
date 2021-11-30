using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t Welcome to Package Express. Please follow the instructions below.\n\n");


            Console.WriteLine("\tPlease enter the package weight: \n");
            //Enter the weight and convert the string to int
            int weight = Convert.ToInt32(Console.ReadLine());

            //Verify the weight, If the weight is greater than 50, display an error message
            if (weight > 50)
            {
                Console.WriteLine("\n\tPackage too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }

            else
            {

                Console.WriteLine("\tPlease enter the package width: \n");
                //Enter the width and convert the string to int
                int width = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\tPlease enter the package height: \n");
                //Enter the height and convert the string to int
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\tPlease enter the package length: \n");
                //Enter the length and convert the string to int
                int length = Convert.ToInt32(Console.ReadLine());

                //Calculating dimension total
                int totalDimension = width + height + length;

                //Verify the dimension, If the dimension total is greater than 50, display an error message
                if (totalDimension > 50)
                {
                    Console.WriteLine("\n\tPackage too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    //calculation the quote. Multiplying the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100
                    int quote = ((width * height * length) * weight) / 100;

                    //Display the quote to the user as a dollar amount.
                    Console.WriteLine("\tYour estimated total for shipping this package is: " +"$"+quote+ "\nThank you!");
                    Console.ReadLine();

                }
            }
        }
    }
}
