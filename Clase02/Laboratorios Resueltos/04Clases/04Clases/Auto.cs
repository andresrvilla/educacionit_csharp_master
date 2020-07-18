using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04Clases
{
    class Auto
    {
        protected double _velocidad = 0; // Se accede dentro de la clase Auto y en las clases derivadas
        private string _marca;
        private string _modelo;
        private string _color;

        // Propiedad Velocidad (solo lectura)
        public double Velocidad
        {
            get { return _velocidad; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        // Constructor
        public Auto(string marca, string modelo, string color)
        {
            _marca = marca;
            _modelo = modelo;
            _color = color;
        }

        // Método Acelerar
        public void Acelerar(double cantidad)
        {
            Console.WriteLine("--> Incrementando veloc. en {0} km/h", cantidad);
            _velocidad += cantidad;
        }
        // Método Girar
        public void Girar(double cantidad)
        {
            Console.WriteLine("--> Girando {0} grados", cantidad);
        }
        // Método Frenar
        public void Frenar(double cantidad)
        {
            Console.WriteLine("--> Reduciendo veloc. en {0} km/h", cantidad);
            _velocidad -= cantidad;
        }
        // Método Estacionar
        public void Estacionar()
        {
            Console.WriteLine("-->Estacionando auto");
            _velocidad = 0;
        }


    }
}
