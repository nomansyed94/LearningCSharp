using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number between 1-10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid.");
                Console.ReadLine();
            }
        }
    }
}
