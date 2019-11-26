using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step75
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI true or false?");
            Boolean dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            short tickets = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualified?");

            Boolean qualified = ( age > 15 && dui == false && tickets < 3);

            Console.WriteLine(qualified);

        }
    }
}
