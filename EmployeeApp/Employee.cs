using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee : IComparable<Employee>
    {
        delegate int Сomparative(Employee other);

        PersonalInformation personalInfo;
        float salary;
        Сomparative comparative;

        public Employee(float salary, PersonalInformation personalInfo)
        {
            this.salary = salary;
            this.personalInfo = personalInfo;
        }

        int IComparable<Employee>.CompareTo(Employee other)
        {
            return comparative(other);
        }

        int CompareByPersonalInformation(Employee other)
        {
            if (this.personalInfo.GetHashCode() > other.personalInfo.GetHashCode())
                return 1;
            else
               if (this.personalInfo.GetHashCode() < other.personalInfo.GetHashCode())
                return -1;
            else
                return 0;
        }

        int CompareBySalary(Employee other)
        {
            if (this.salary > other.salary)
                return 1;
            else
                if (this.salary < other.salary)
                return -1;
            else
                return 0;
        }

        public static List<Employee> SortBySalary(List<Employee> list)
        {
            foreach (Employee e in list)
                e.comparative = e.CompareBySalary;
            list.Sort();
            return list;
        }
        //

        public static List<Employee> SortByByPersonalInformation(List<Employee> list)
        {
            foreach (Employee e in list)
                e.comparative = e.CompareByPersonalInformation;
            list.Sort();
            return list;
        }

        public override string ToString()
        {
            return personalInfo.ToString() + " с зарплатой: " + salary;
        }

        public static void PrintList(List<Employee> list)
        {
            foreach (Employee e in list)
                Console.WriteLine(e.ToString());
        }
    }
}
