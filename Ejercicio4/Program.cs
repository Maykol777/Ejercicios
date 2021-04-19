using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Velocidad;
            int Distancia;
            int Tiempo = 6;

            Console.WriteLine("Ingrese la distancia que desea recorrer: ");
            Distancia = int.Parse(Console.ReadLine());

            Velocidad = Distancia / Tiempo;

            Console.WriteLine("Usted se desplazara a esta velocidad: " + Velocidad + (" Km" + "En estas horas: " + Tiempo + " Horas"));


            if (Velocidad > 100)
            {
                Console.WriteLine("El vehiculo se va a desplazar a gran velocidad");
            }
            else
            {
                Console.WriteLine("El vehiculo se desplazara a una velocidad moderada");
            }
            Console.ReadLine();
        }
    }
}
