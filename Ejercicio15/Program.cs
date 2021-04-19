using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {

            int Resultado;

            Console.WriteLine("Ingresa tu nombre");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            int edad1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro nombre");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingresa otra edad");
            int edad2 = int.Parse(Console.ReadLine());

            if (edad1 > edad2)
            {
                Console.WriteLine("El nombre con la edad mayor es: " + nombre1);
                Resultado = edad1 - edad2;
                Console.WriteLine("Y la diferencia entre sus edades son: " + Resultado);
            }
            else
            {
                Console.WriteLine("El nombre con la edad menor es: " + nombre1);
            }
            if (edad1 < edad2)
            {
                Console.WriteLine("El nombre con la edad mayor es: " + nombre2);
                Resultado = edad2 - edad1;
                Console.WriteLine("Y la diferencia entre sus edades son: " + Resultado);
            }
            else
            {
                Console.WriteLine("El nombre con la edad menor es: " + nombre2);

            }


            Console.ReadLine();
        }
    }
}
