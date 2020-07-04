using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompraEnRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcula el total de la compra de cada ítem
            byte CantBebida, CantHamburguesa, CantPapas;
            double APagar;
            string linea;

            const double PrecioB = 0.8;
            const double PrecioH = 2;
            const double PrecioP = 1.2;

            Console.Write("CANTIDAD DE HAMBURGUESAS :"); 
            linea = Console.ReadLine();
            CantHamburguesa = byte.Parse(linea);

            Console.Write("CANTIDAD DE PAPAS :"); 
            linea = Console.ReadLine();
            CantPapas = byte.Parse(linea);

            Console.Write("CANTIDAD DE BEBIDAS :"); 
            linea = Console.ReadLine();
            CantBebida = byte.Parse(linea);
            Console.WriteLine();

            APagar = (CantHamburguesa * PrecioH) + (CantPapas * PrecioP) + (CantBebida * PrecioB);
            Console.WriteLine("VALOR A PAGAR: " + APagar);

            Console.Write("Pulse una Tecla:");
            Console.ReadKey();

        }
    }
}
