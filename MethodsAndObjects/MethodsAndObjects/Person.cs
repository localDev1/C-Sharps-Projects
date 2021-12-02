using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    public class Person
    {
        //two properties, each of data type string. One called FirstName, the other LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //method called SayName() that takes no parameters and simply writes the person's full name to the console 
        public void SayName() 
        {
            if (FirstName != "" && LastName != "")
            {
                Console.WriteLine("\n\n\tName : " + FirstName + " " + LastName);
            }
            else 
            {
                Console.WriteLine("\n\n\tEnter a FirstName and a LastName: ");
            }
            
        }
    }
}
