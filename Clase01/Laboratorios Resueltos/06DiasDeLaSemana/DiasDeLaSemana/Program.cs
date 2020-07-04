using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiasDeLaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            //Según el número de día de la semana, muestra su nombre
            int num;
            string linea;

            Console.WriteLine();
            Console.WriteLine("DIAS DE LA SEMANA");

            Console.WriteLine();
            Console.Write("Ingrese un numero del 1 al 7 :");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            switch (num)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día DOMINGO");
            break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día LUNES");
            break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día MARTES");
            break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día MIERCOLES");
            break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día JUEVES");
            break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día VIERNES");
            break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso corresponde al día SABADO");
            break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("El numero que ingreso esta fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
