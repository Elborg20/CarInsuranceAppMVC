using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 8, 7, 2, 4, 6, 7, 4 };
            int sum = 0;
            Int64 sum1 = 0;
            foreach (int x in array)
            {
                if (x / 2 != ((x + 1) / 2))
                {
                    sum += x;
                }
            }

            foreach (int x in array)
            {
                Int64 y = Convert.ToInt64(x);
                sum1 += y;
            }
            Console.WriteLine("The sum of the odd numbers in the array is: " + sum);
            Console.WriteLine("The sum of all the numbers in the array is: " + sum1);
            Console.ReadLine();
            
        }
    }   
}
