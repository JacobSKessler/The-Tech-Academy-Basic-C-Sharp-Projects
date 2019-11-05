using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            Console.WriteLine("please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            TimeSpan time = new TimeSpan(num, 0, 0);
            Console.WriteLine(date + time);
            Console.ReadLine();
        }
    }
}
