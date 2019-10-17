using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

//2. Takes an input from the user, adds 25 to it, and prints the result to the console.

//3. Takes an input from the user, divides it by 12.5, and prints the result to the console.

//4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.

//5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).

namespace step66
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 * 50);

            Console.WriteLine("Input a number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 + 25);

            Console.WriteLine("Input a number");
            float num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3 / 12.5);

            Console.WriteLine("Input a number");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Boolean isGreater = num4 > 50;
            Console.WriteLine(isGreater);

            Console.WriteLine("Input a number");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num5 % 7);

            Console.ReadLine();



        }
    }
}
