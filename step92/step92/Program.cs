using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step92
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("What is your package weight?");
            double pWeight = Convert.ToDouble(Console.ReadLine());
            if (pWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            else
            {
                Console.WriteLine("Enter package width");
                double size = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter package height");
                size = size + Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter package length");
                size = size + Convert.ToDouble(Console.ReadLine());

                if (size > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }
                else
                {
                    string price = Convert.ToString(Math.Round( size * pWeight / 100 , 2));
                    Console.WriteLine("Your estimated total for shipping this package is: " + price);
                    
                }
            }
        }
    }
}
