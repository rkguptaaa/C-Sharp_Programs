using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_ByRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(factorial_Recursion(num));
            Console.ReadLine();
        }
        public static int factorial_Recursion(int number)
        {
            if (number == 1)
            { return 1; }
            else
            {
                return number * factorial_Recursion(number - 1);
            }
        }
    }
}
