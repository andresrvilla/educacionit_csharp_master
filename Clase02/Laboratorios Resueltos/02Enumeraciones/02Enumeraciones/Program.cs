using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02Enumeraciones
{
    class Program
    {
        enum State { Off, On }
        enum Color
        {
            Red = 1,
            Green = 2,
            Blue = 4,
            Black = 0,
            White = Red | Green | Blue
        }
        static void Main(string[] args)
        {
            Color c = Color.Black;
            Console.WriteLine((int)c);// 0
            Console.WriteLine(c.ToString()); // Black
            Console.WriteLine(c); // Black
            Console.ReadKey();
            Color x = Color.White;
            Console.WriteLine((int)x);// 7 suma los valores de los colores
            Console.WriteLine(x.ToString()); // White
            Console.ReadKey();
            State y = State.On;
            Console.WriteLine((int)y);// 1
            Console.WriteLine(y.ToString()); // On
            Console.ReadKey();
        }
    }

}
