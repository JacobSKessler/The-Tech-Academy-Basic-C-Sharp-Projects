using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 4 words one after another");
            string[] words = new string[4] {"1","2","3","4" };
            for (int i = 0; i < 4; i++)
            {
                words[i] = words[i] + Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            {
               Console.WriteLine(words[i]);
            }
            //fix was adding in i<=20 rather than i==i
            for (int i = 0; i <= 20; i++) 
            {
                Console.WriteLine(Convert.ToString(i));
            }

            List<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");

            bool isThere = false;

            while (isThere == false)
            {
                Console.WriteLine("search for one two or three");
                string input = Console.ReadLine();

                for (int i = 0; i < strList.Count; i++)
                {
                    if (strList[i] == input)
                    {
                        isThere = true;
                        string index = Convert.ToString(i);
                        Console.WriteLine(input + " is in index " + index);
                    }
                }
                if (isThere == false)
                {
                    Console.WriteLine("input was bad");
                }
            }

            isThere = false;
            strList.Add("one");
            strList.Add("two");
            while (isThere == false)
            {
                Console.WriteLine("search for one two or three");
                string input = Console.ReadLine();

                for (int i = 0; i < strList.Count; i++)
                {
                    if (strList[i] == input)
                    {
                        isThere = true;
                        string index = Convert.ToString(i);
                        Console.WriteLine(input + " is in index " + index);
                    }
                }
                if (isThere == false)
                {
                    Console.WriteLine("input was bad");
                }
            }

            List<string> strings = new List<string>();
            strings.Add("hello world");
            strings.Add("hello world");
            List<string> strings2 = new List<string>();




            foreach (string str in strings)
            {
                

                if (strings2.Contains(str))
                {
                    Console.WriteLine(str);
                    Console.WriteLine("not first time on list");
                }
                else
                {
                    Console.WriteLine(str);
                    Console.WriteLine("first time on list");
                    strings2.Add(str);
                }



            }
        }
    }
}
