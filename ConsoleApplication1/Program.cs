using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Base
    {
        public int num1 { get; set; }
    }

    class Derived : Base
    {
        public int num2 { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d1;
            //Upcasting
            //Base b1 = d1;

            Base b2 = new Base();
            //Downcasting
            d1 = (Derived)b2;
        }
    }
}
