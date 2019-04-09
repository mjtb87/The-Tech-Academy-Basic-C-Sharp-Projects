using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace class_drill_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> joes = new List<Employee>();
            List<Employee> employees = new List<Employee>();

            Employee employee_1 = new Employee() { FirstName = "George", LastName = "Carlin", Id = 1, IsWorking = true };
            Employee employee_2 = new Employee() { FirstName = "George", LastName = "Lucas", Id = 2, IsWorking = true };
            Employee employee_3 = new Employee() { FirstName = "Joe", LastName = "Jones", Id = 3, IsWorking = true };
            Employee employee_4 = new Employee() { FirstName = "Joe", LastName = "Smith", Id = 4, IsWorking = true };
            Employee employee_5 = new Employee() { FirstName = "Bernie", LastName = "Mac", Id = 5, IsWorking = true };
            Employee employee_6 = new Employee() { FirstName = "Eddie", LastName = "Murphy", Id = 6, IsWorking = true };
            Employee employee_7 = new Employee() { FirstName = "Bernie", LastName = "Sanders", Id = 7, IsWorking = true };
            Employee employee_8 = new Employee() { FirstName = "Bill", LastName = "Hicks", Id = 8, IsWorking = true };
            Employee employee_9 = new Employee() { FirstName = "Morgan", LastName = "Freeman", Id = 9, IsWorking = true };
            Employee employee_10 = new Employee() { FirstName = "Jenny", LastName = "Lewis", Id = 10, IsWorking = true };

            employees.Add(employee_1);
            employees.Add(employee_2);
            employees.Add(employee_3);
            employees.Add(employee_4);
            employees.Add(employee_5);
            employees.Add(employee_6);
            employees.Add(employee_7);
            employees.Add(employee_8);
            employees.Add(employee_9);
            employees.Add(employee_10);
     
            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joes.Add(emp);
                }
            }

            List<Employee> joesTwo = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> IdsOverFive = employees.Where(x => x.Id > 5).ToList();


            Console.WriteLine(joesTwo[0].FirstName);
            Console.WriteLine(joes[0].FirstName);
            Console.WriteLine(IdsOverFive[0].FirstName);
            Console.ReadKey();
        }
    }
}
