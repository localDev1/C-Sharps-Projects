using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of at least 10 employees.
            List<Employees> listEmployees = new List<Employees>();

            //Each employee should have a first and last name, as well as an Id
            Employees emp1 = new Employees();
            emp1.FirstName = "Fernando";
            emp1.LastName = "Perez";
            emp1.Id = 1;

            Employees emp2 = new Employees();
            emp2.FirstName = "Carlos";
            emp2.LastName = "Santizo";
            emp2.Id = 2;

            Employees emp3 = new Employees();
            emp3.FirstName = "Andrew";
            emp3.LastName = "Rosend";
            emp3.Id = 3;

            Employees emp4 = new Employees();
            emp4.FirstName = "Joe";
            emp4.LastName = "Smith";
            emp4.Id = 4;

            Employees emp5 = new Employees();
            emp5.FirstName = "Engels";
            emp5.LastName = "Martinez";
            emp5.Id = 5;

            Employees emp6 = new Employees();
            emp6.FirstName = "Joe";
            emp6.LastName = "Rodriguez";
            emp6.Id = 6;

            Employees emp7 = new Employees();
            emp7.FirstName = "Manuel";
            emp7.LastName = "Bejarano";
            emp7.Id = 7;

            Employees emp8 = new Employees();
            emp8.FirstName = "Joe";
            emp8.LastName = "Rodriguez";
            emp8.Id = 8;

            Employees emp9 = new Employees();
            emp9.FirstName = "Karim";
            emp9.LastName = "Bollas";
            emp9.Id = 9;

            Employees emp10 = new Employees();
            emp10.FirstName = "Cesar";
            emp10.LastName = "Tapia";
            emp10.Id = 10;

            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);
            listEmployees.Add(emp5);
            listEmployees.Add(emp6);
            listEmployees.Add(emp7);
            listEmployees.Add(emp8);
            listEmployees.Add(emp9);
            listEmployees.Add(emp10);


            List<Employees> newList = new List<Employees>();
            Console.WriteLine("\n\n\tUsing Foreach Loop ");

            //Using a foreach loop, create a new list of all employees with the first name “Joe”.
            foreach (Employees empl in listEmployees) 
            {
                if (empl.FirstName == "Joe") 
                {
                    newList.Add(empl);
                }
            }

            
            //Printing the list
            foreach(Employees emple in newList)
            {
                Console.WriteLine("\n\tJoe " + emple.LastName + " Id = " + emple.Id);
            }

            Console.WriteLine("\n\n\n\n\tUsing Lambda Expression (same as above): ");

            List<Employees> ListLambda = listEmployees.Where(name => name.FirstName == "Joe").ToList();

            //Printing the list
            foreach (Employees emple in ListLambda)
            {
                Console.WriteLine("\n\tJoe " + emple.LastName + " Id = " + emple.Id);
            }

            //Making a list of all employees with an Id number greater than 5 Using Lambda Expression
            List<Employees> empLambda = listEmployees.Where(x => x.Id > 5).ToList();

            //Using Lambda Expression 
            Console.WriteLine("\n\n\n\n\tUsing Lambda Expression: ");


            //Printing the list
            foreach (Employees emple in empLambda)
            {
                Console.WriteLine("\n\tThe Names with the Id greater than 5 are : " +emple.FirstName + " "+ emple.LastName + " Id = " + emple.Id);
            }

            Console.ReadLine();
        }
    }
}
