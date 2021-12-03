using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsSubmission
{
    public class Employee:Person,IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("\n\n\t The name is :" + fisrtName +" "+ lastName);
        }

        //Implementig the method inside the Iquattable Interface
        public void Quit() 
        {
            //Change the name 
            fisrtName = "Fernando";
            lastName = "Perez Roblero";
            Console.WriteLine("\n\n\t The new name is :" + fisrtName + " " + lastName);
        }

        //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property
        public static string operator ==(Employee person1, Employee person2) 
        {
            if (person1.Id == person2.Id)
                return "Yes, are equal!";
            else
                return "No, are not equal!";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static string operator !=(Employee person1, Employee person2)
        {
            if (person1.Id != person2.Id)
                return "Are NOT equal!";
            else
                return "Are equal!";
        }


    }
}
