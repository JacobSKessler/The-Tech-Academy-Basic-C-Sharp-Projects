using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step106
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2,34,55,22,13,23 };



            try
            {
                for(int i = 0; i < nums.Count; i++)
                {
                    Console.WriteLine("provide a whole number for division");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(nums[i] / input);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please don't divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please enter an intiger");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("feel free to run the program again");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
