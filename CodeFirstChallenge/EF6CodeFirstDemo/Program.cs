using System;

namespace CodeFirstChallenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                bool load = true;
               
                while (load)
                {
                    
                    var student = new Student();

                    Console.WriteLine("\n\n\tEnter a First Name of Student: ");
                    student.FName = Console.ReadLine();
                    Console.WriteLine("\n\tEnter a Last Name of Student: ");
                    student.LName = Console.ReadLine();
                    ctx.Students.Add(student);
                    Console.WriteLine("\n\tDo want load another student (true/false)");
                    load = Convert.ToBoolean(Console.ReadLine());     
                    if (load)
                    {
                        Console.Clear();
                    }
                    
                }

                ctx.SaveChanges();
                

            }
            Console.WriteLine("\n\tThe Database was created and the students were uploaded....");
            Console.ReadLine();
        }
    }
}