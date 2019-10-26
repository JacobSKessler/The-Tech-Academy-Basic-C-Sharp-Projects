using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What whole number do you want to do math with?");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Class1.AddFive(input));
            Console.WriteLine(Class1.SubFive(input));
            Console.WriteLine(Class1.TimesFive(input));
            Console.ReadLine();
        }
    }
}
