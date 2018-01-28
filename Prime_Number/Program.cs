using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= num; j++)
            {
                int k = 0;
                for (int i = 1; i <= j ; i++)
                {
                    if (j % i == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                {
                    Console.WriteLine("PM"+ j);

                }
            }
            Console.ReadLine();
        }
    }
}
