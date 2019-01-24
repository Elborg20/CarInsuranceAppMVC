using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "hheelllooo wwwwOoorrrllldd";
            Console.WriteLine("Initial String: " + myStr);
            var unique = new HashSet<char>(myStr);
            Console.Write("New String after removing duplicates: ");
            foreach (char c in unique)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Console.WriteLine(StringHelper.ReverseString(s));
            Console.WriteLine(StringHelper.ReverseString("amanaplanacanalpanama"));
            Console.ReadLine();
        }
    }
}
