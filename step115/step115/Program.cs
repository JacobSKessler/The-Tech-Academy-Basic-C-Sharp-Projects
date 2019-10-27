using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number, then if you want enter a second whole number or just enter nothing");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2;
            string inputString = Console.ReadLine();

            //checks in second input is an int value and if it is assigns it to input2
            int.TryParse(inputString, out input2);

            int result = Class1.TimesFive(input1, input2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
