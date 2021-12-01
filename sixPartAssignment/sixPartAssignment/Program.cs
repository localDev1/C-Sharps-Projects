using System;
using System.Collections.Generic;

namespace sixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //CONSOLE APP PART ONE ASSIGNMENT

            //Creates one-dimensional array of strings.
            string[] stringArray = { "string 1 ", "string 2 ", "string 3 ", "string 4 ", "string 5 " };

            //Ask the user to input some text.
            Console.WriteLine("\n\n\tEnter a text to be added to the strings ");
            string newString = Console.ReadLine();

            //A loop that iterates through each string in the array and adds the user's text input to the end of each string
            for (int i =0; i< stringArray.Length; i++) 
            {
                stringArray[i] += newString;
            }

            //a loop that prints off each string in the array on a separate line.
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine("\t"+stringArray[i]);
            }

            Console.ReadLine();

            //CONSOLE APP PART TWO ASSIGNMENT
            //An infinite loop.
            for (int j=0; j<10; j++) 
            {
                //Fix the infinite loop so that it will execute properly. (incrementing the value j)
                Console.WriteLine("Infinite Loop without incrementing the value j");
            }
            Console.ReadLine();


            //CONSOLE APP PART THREE ASSIGNMENT

            int f = 0;
            //A loop using a “<” operator.
            Console.WriteLine("\n\tA loop using a “<” operator.\n");
            while (f< 10)
            {

                Console.WriteLine("\tf value is: " + f);
                f += 1;
            }
            Console.ReadLine();

            //A loop using a “<=” operator.
            Console.WriteLine("\n\tA loop using a “<=” operator.\n");
            f = 0;
            while (f <= 10)
            {

                Console.WriteLine("\tf value is: " + f);
                f += 1;
            }
            Console.ReadLine();

            //CONSOLE APP PART FOUR ASSIGNMENT

            //A list of strings where each item in the list is unique.
            List<string> listString = new List<string>() { "Mexico", "Portland", "Chiapas", "World", "Oregon", "CDMX" };
            bool match = true;
            do
            {
                //Ask the user to input text to search for in the list.
                Console.WriteLine("\n\tEnter the city where you live");
                string cityUser = Console.ReadLine();

                //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
                foreach (string cityArray in listString)
                {
                    if (cityArray == cityUser)
                    {
                        Console.WriteLine("\n\tThe index of the city is: " + listString.IndexOf(cityArray));
                        match = false;
                    }
                }
                //check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
                if (match) 
                {
                    Console.WriteLine("\n\tTheir city is not on the list");
                }

            }
            while (match);


            Console.ReadLine();

            //CONSOLE APP PART FIVE ASSIGNMENT

            //A list of strings that has at least two identical strings in the list.
            List<string> listString2 = new List<string>()  {"mole", "pollo", "pescado", "verdura","mole","pollo","pan" };

            //Ask the user to select text to search for in the list.
            Console.WriteLine("\n\tEnter your favorite food");
            string food = Console.ReadLine();

            List<int> listIndex = new List<int>();

            //a loop that iterates through the list and then displays the indices of the items matching the user-selected text.
            for (int p=0; p< listString2.Count; p++) 
            {
                if (listString2[p] == food)
                    {
                        listIndex.Add(p);
                    }
            }
            //tells the user their input is not on the list.
            if (listIndex.Count <= 0) 
            {
                Console.WriteLine("The food choosed is not in the list");
            }
            else 
            {
                for (int r=0; r<listIndex.Count; r++) 
                {
                    Console.WriteLine("\n\tThe index of the food selected is : " + listIndex[r]);
                }
            }

            Console.ReadLine();

            //CONSOLE APP PART SIX SUBMISSION ASSIGNMENT
            Console.WriteLine("\n\n\tSIX SUBMISSION ASSIGNMENT\n");
            List<string> compareList = new List<string>();
            //Create a foreach loop that evaluates each item in the list
            foreach (string comida in listString2)
            {
                //displays a message showing the string and whether or not it has already appeared in the list.
                if (compareList.Contains(comida))
                {
                    Console.WriteLine("\t" + comida + " Has already appeared in the list.");                    
                }

                else { 

                Console.WriteLine("\t" + comida + " No it has appeared in the list.");
                    compareList.Add(comida);
                }
            }

            Console.ReadLine();
        }
    }
}
