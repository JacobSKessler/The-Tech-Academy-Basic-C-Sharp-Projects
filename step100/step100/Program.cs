using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step100
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] sentance = { "this", "is", "an", "array" };
            Console.WriteLine("please enter a number between 0 and 3");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index <= sentance.Length && index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("you are outside the array");
            }

            int[] numArray = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine("please enter a number between 0 and 9");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(index);

            List<string> intList = new List<string>();
            intList.Add("one");
            intList.Add("two");
            intList.Add("three");

            Console.WriteLine("pick a number between 0 and 2");
            Console.WriteLine(intList[Convert.ToInt32(Console.ReadLine())]);

        }
    }
}
