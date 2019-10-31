using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step134
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week");
                string input = Console.ReadLine();
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input, true);
            }
            catch 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            
        }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
