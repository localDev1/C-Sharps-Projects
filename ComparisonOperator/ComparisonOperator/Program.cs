using System;

namespace ComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing String to the screen
            Console.WriteLine("\n\n\t\t\tAnonymous Income Comparison Program");

            //printing String ( “Person 1”) to the screen
            Console.WriteLine("\n\n\tPerson 1");

            //details from user input:

            //Introduce the Hourly Rate in decimal because we must calculate salary
            Console.WriteLine("\n\tHourly Rate?");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());

            //Introduce Hours worked per week like string converting to integer
            Console.WriteLine("\n\tHours worked per week?");
            decimal hoursWeek1 = Convert.ToDecimal(Console.ReadLine());

            //Calculating Annual Salary
            decimal annualSalary1 = hourlyRate1 * hoursWeek1 * 52;

            //printing String ( “Person 1”) to the screen
            Console.WriteLine("\n\n\tPerson 2");

            //Introduce the Hourly Rate in decimal because we must calculate salary
            Console.WriteLine("\n\tHourly Rate?");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());

            //Introduce Hours worked per week like string converting to integer
            Console.WriteLine("\n\tHours worked per week?");
            decimal hoursWeek2 = Convert.ToDecimal(Console.ReadLine());

            //Calculating Annual Salary
            decimal annualSalary2 = hourlyRate2 * hoursWeek2 * 52;

            //print to the screen “Annual salary of Person 1 and 2:” and display the exact salary below it.
            Console.WriteLine("\n\tAnnual salary of Person 1: \n" + annualSalary1);
            Console.WriteLine("\n\tAnnual salary of Person 2: \n" + annualSalary2);
            
            //comparing annual Salaries
            bool comparasion = annualSalary1 > annualSalary2;
            Console.WriteLine("\n\tDoes Person 1 make more money than Person 2? \n" + comparasion);
            
            Console.ReadLine();
        }
    }
}
