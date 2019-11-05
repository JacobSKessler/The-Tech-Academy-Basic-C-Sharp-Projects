using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace step154
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for number
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            //log number
            using (StreamWriter file = new StreamWriter(@"C:\Users\kessl\OneDrive\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\logs\154log.txt", true))
            {
                file.WriteLine(input);
            }
            Console.WriteLine("\n" + "Whole log reads:");
            //print back log
            string[] lines = File.ReadAllLines(@"C:\Users\kessl\OneDrive\Desktop\The-Tech-Academy-Basic-C-Sharp-Projects\logs\154log.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.Read();
        }
    }
}
