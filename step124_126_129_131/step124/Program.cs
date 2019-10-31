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
            IQuittable quittable = new Employee<string>();

            
            Employee<int> example = new Employee<int> { FirstName = "Sample", LastName = "Student", things = new List<int> { 1, 2, 5} };
            Employee<string> example3 = new Employee<string> { FirstName = "Sample", LastName = "Student", things = new List<string> { "four", "six"} };

            for (int i = 0; i < example.things.Count; i++)
            {
                Console.WriteLine(example.things[i]);
            }
            for (int i = 0; i < example3.things.Count; i++)
            {
                Console.WriteLine(example3.things[i]);
            }


            example.SayName2();
            Console.ReadLine();

            quittable.Quit();

        }
    }
}
