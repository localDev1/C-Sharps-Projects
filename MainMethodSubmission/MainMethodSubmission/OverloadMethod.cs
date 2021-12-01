using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodSubmission
{
    class OverloadMethod
    {
        //Return value square of a number
        public int ConvertMethod(int number) 
        {
            
            return number *= number;
        }

        //Converting a decimal number to Integer to get the double value
        public int ConvertMethod(decimal number) 
        {
            int numberConvert = (Convert.ToInt32(number))*2;
            
            return numberConvert;
        }

        //Converting a string to Integer to get the square value
        public int ConvertMethod(string str, out string message)
        {
            message = "";
            int numberConvert = 0;
            //trying to convert a string in integer
            try
            {
                numberConvert = (Convert.ToInt32(str)) * 10;
            }
            catch (Exception e)             
            {
                message = e.Message;
            }            

            return numberConvert;
        }




    }
}
