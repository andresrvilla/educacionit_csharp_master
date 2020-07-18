using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03Estructuras
{
    class Program
    {
        public struct Point
        {
            public int x, y;
            public Point(int x, int y) //Constructor
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Point p = new Point(2, 5);
            Point p2;
            p.x += 100;
            int px = p.x; // px = 102
            p2 = p;
            p2.x += 100;
            Console.WriteLine(px); // 102
            Console.WriteLine(p2.x); // 202
            Console.ReadKey();
        }

    }
}
