using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { fName = "Joe", lName = "Smith", id = 0 });
            employees.Add(new Employee { fName = "Joe", lName = "Shoemaker", id = 1 });
            employees.Add(new Employee { fName = "Steve", lName = "Smith", id = 2 });
            employees.Add(new Employee { fName = "Gary", lName = "Smith", id = 3 });
            employees.Add(new Employee { fName = "Ash", lName = "Smith", id = 4 });
            employees.Add(new Employee { fName = "Max", lName = "Smith", id = 5 });
            employees.Add(new Employee { fName = "Kris", lName = "Smith", id = 6 });
            employees.Add(new Employee { fName = "Cris", lName = "Smith", id = 7 });
            employees.Add(new Employee { fName = "Lance", lName = "Smith", id = 8 });
            employees.Add(new Employee { fName = "Sarah", lName = "Smith", id = 9 });

            List<Employee> newList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.fName == "Joe")
                {
                    newList.Add(employee);
                }
            }

            List<Employee> newList2 = employees.Where(x => x.fName == "Joe").ToList();


            List<Employee> newList3 = employees.Where(x => x.id > 5).ToList();

        }
    }
}
