using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _01Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasePoly x = new ClasePoly();
            x.Poly(42);
            x.Poly("abcd");
            x.Poly(12.345678901234m);
            x.Poly(new Point(23, 45));
            Console.ReadKey();
        }
    }
}
