using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step97
{
    class Program
    {
        static void Main(string[] args)
        {
            string part1 = "this ";
            string part2 = "is a ";
            string part3 = "string";
            String whole = part1 + part2 + part3;
            string upper = whole.ToUpper();
            Console.WriteLine(upper);

            StringBuilder sb = new StringBuilder();
            sb.Append("A paragrath is at least 3 sentances long.");
            sb.Append("  This blurb has 3 related sentances.");
            sb.Append("  That makes this a paragraph!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
