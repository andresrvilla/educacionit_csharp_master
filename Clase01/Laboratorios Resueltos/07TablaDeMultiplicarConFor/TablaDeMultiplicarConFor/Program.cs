using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TablaDeMultiplicarConFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muestra la tabla de multiplicar de un número
            byte NUM, I;
            int RESUL;
            string linea;

            Console.Write("DIGITE NÚMERO:"); 
            linea = Console.ReadLine();
            NUM = byte.Parse(linea);

            for (I = 1; I <= 12; I++)
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
            }

            Console.Write("Pulse una Tecla:");
            Console.ReadKey();
        }
    }
}
