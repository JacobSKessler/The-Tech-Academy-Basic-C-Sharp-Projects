using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step94
{
    class Program
    {
        static void Main()
        {
            Boolean guess = false;
            Boolean fun = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 5");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 3)
                {
                    guess = true;
                    Console.WriteLine("You guessed right");

                }
                else
                {
                    Console.WriteLine("Wrong, try again");
                }
            }
            while (!guess);

            while (fun)
            {
                Console.WriteLine("do you enjoy repitition? (y/n)");
                char rep = Convert.ToChar(Console.ReadLine());
                if (rep == 'n')
                {
                    fun = false;
                }
            }
        }
    }
}
