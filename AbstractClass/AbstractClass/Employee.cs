using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee:Person
    {
        public override void SayName()
        {
            Console.WriteLine("\n\n\t The name is :" + fisrtName +" "+ lastName);
        }
    }
}
