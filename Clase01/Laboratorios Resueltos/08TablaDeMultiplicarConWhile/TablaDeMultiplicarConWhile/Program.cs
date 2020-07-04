using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TablaDeMultiplicarConWhile
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

            I = 1;
            while ((I <= 12))
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
                I++;
            }
            Console.Write("Pulse una Tecla:");
            Console.ReadKey();

        }
    }
}
