using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(340f, new PersonalInformation("Иванов И.А.", new DateTime(2000, 3, 21))));
            employees.Add(new Employee(510f, new PersonalInformation("Сидоров П.А.", new DateTime(1993, 4, 27))));
            employees.Add(new Employee(320f, new PersonalInformation("Петров К.А.", new DateTime(1995, 10, 12))));
            employees.Add(new Employee(535f, new PersonalInformation("Митяев С.А.", new DateTime(1993, 10, 12))));

            Employee.SortBySalary(employees);

            Console.WriteLine("Отсортировано по зарплате");
            Employee.PrintList(employees);

            Employee.SortByByPersonalInformation(employees);

            Console.WriteLine("Отсортировано по личной информации");
            Employee.PrintList(employees);

            Console.ReadKey();
        }
    }
}
