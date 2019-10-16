using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step57
{
    class Program
    {
        static void Main()
        {
            //header
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            //get data
            Console.WriteLine("What course are you on?");
            String courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            short pgNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            Boolean needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            String goodFeels = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            String feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            Byte studyHrs = Convert.ToByte(Console.ReadLine());
            //thank student
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!” This would be the end of the program.");
        }
    }
}
