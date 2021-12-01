using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class MathOperations
    {
        //value squared of a number
        public static int SquareNumber (int number) 
        {
            return number *= number;
        }

        //value  Double of a number
        public static int DoubleNumber (int number) 
        {
            return number *= 2;
        }

        //Value by Ten of a number
        public static int ByTen (int number)
        {
            return number *= 10;
        }
    }
}
