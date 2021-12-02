using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission
{
   
    public class Divide
    {
        //create a void method that outputs an integer. The method divide the data passed to it by 2.
        public void Division(int x) 
        {
           int y = x / 2;
            Console.WriteLine("\n\tThe result of dividing  " + x + " by " + 2 + " is " + y);
            
        }

        //Create a method with output parameters, overloading the method Division.
        public void Division(int x, out int y)
        {
            y = x /10;
        }
    }
}
