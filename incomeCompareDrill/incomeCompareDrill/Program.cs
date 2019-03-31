using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        Console.ReadLine();

        Console.WriteLine("Enter Hour Rate For Person 1: ");
        string hourlyRate_1 = Console.ReadLine();
        Console.WriteLine("Enter Hours Worked Per Week For Person 1: ");
        string hoursWorked_1 = Console.ReadLine();

        Console.WriteLine("Enter Hour Rate For Person 2: ");
        string hourlyRate_2 = Console.ReadLine();
        Console.WriteLine("Enter Hours Worked Per Week For Person 2: ");
        string hoursWorked_2 = Console.ReadLine();

        double person_1_salary = (Convert.ToDouble(hoursWorked_1) * 52) * Convert.ToDouble(hourlyRate_1);
        double person_2_salary = (Convert.ToDouble(hoursWorked_2) * 52) * Convert.ToDouble(hourlyRate_2);

        Console.WriteLine("Annual salary of Person 1: ");
        Console.WriteLine(person_1_salary);
        Console.ReadLine();

        Console.WriteLine("Annual salary of Person 2: ");
        Console.WriteLine(person_2_salary);
        Console.ReadLine();

        Boolean salaryCompareResults = person_1_salary >= person_2_salary;

        Console.WriteLine("Does Person 1 make more money than Person 2?: ");
        Console.WriteLine(salaryCompareResults);
        Console.ReadLine();
    }
}

