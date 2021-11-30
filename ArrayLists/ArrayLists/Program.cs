using System;
using System.Collections.Generic;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a one-dimensional Array of strings
            string[] arrayStrings = new string[5];

            //Filling the array
            arrayStrings[0] = "string index 0";
            arrayStrings[1] = "string index 1";
            arrayStrings[2] = "string index 2";
            arrayStrings[3] = "string index 3";
            arrayStrings[4] = "string index 4";

            //Ask the user to select an index 
            Console.WriteLine("\n\n\tEnter integer between 0-4");

            //Convert string to int
            int index = Convert.ToInt32(Console.ReadLine());

            try
            {
                //display the string at that index on the screen.
                Console.WriteLine("\n\tthe string to the index: " + index+ "  is: \""+ arrayStrings[index]+"\"");

            }
            catch
            {
                //Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("\n\tYou dont enter a number between 0-4");
            }
            Console.ReadLine();


            //Create and filling a one-dimensional Array of integers
            int[] arrayInt = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };

            //Ask the user to select an index 
            Console.WriteLine("\n\n\tEnter integer between 0-8");

            //Convert string to int
            int index2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //display the integer at that index on the screen.
                Console.WriteLine("\n\the integer to the index: "+ index2 + "  is: "+ arrayInt[index2]);

            }
            catch
            {
                //Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("\n\tYou dont enter a number between 0-8");
            }
            Console.ReadLine();


            //Create a list of strings
            List<string> stringList = new List<string>();

            //Filling the List
            stringList.Add("string 1");
            stringList.Add("string 2");
            stringList.Add("string 3");
            stringList.Add("string 4");
            stringList.Add("string 5");
            stringList.Add("string 6");

            //Ask the user to select an index of the list
            Console.WriteLine("\n\n\tEnter integer between 0-5");

            //Convert string to int
            int index3 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //display the integer at that index on the screen.
                Console.WriteLine("\n\tThe string into the List to the index: " + index3 + "  is: \"" + stringList[index3]+"\"");

            }
            catch
            {
                //Add in a message that displays when the user selects an index that doesn’t exist.
                Console.WriteLine("\n\tYou dont enter a number between 0-5");
            }
            Console.ReadLine();




        }
    }
}
