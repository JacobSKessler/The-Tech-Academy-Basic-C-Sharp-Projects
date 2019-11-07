using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your age as a whole positive number.");
            int age;
            bool isNum = Int32.TryParse(Console.ReadLine(), out age);


            try
            {
                
                if (age == 0 && isNum == true) { throw new BabyException(); }
                else if (age < 0 && isNum == true) { throw new UnbornException(); }
                else if (isNum == false) { throw new Exception(); }
                else 
                { 
                    Console.WriteLine("You were born in {0} years old!", DateTime.Today.Year - age); 
                    Console.ReadLine(); 
                }
                
            }
            catch (BabyException)
            {
                Console.WriteLine("New borns can't use computers!");
                Console.ReadLine();
                return;
            }
            catch (UnbornException)
            {
                Console.WriteLine("You haven't even been born yet!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occured");
                Console.ReadLine();
                return;
            }

            
        }
    }
}
