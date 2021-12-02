using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSubmission
{
    class Math
    {
        //creating a method that takes two integers as parameters. One of them optional.
        public int Math_Operation(int number1, int number2 = 2) 
        {
             int number = number1 * number2;
            return number;

        }
    }
}
