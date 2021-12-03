using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
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
    }
}
