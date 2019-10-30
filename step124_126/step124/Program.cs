using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step124
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();

            quittable.Quit();

            Employee example = new Employee { FirstName = "Sample", LastName = "Student" };
            example.SayName2();
            Console.ReadLine();
        }
    }
}
