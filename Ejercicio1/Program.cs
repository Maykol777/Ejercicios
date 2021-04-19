using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una nota del 1 al 7");
            int nota = 0;
            nota = int.Parse(Console.ReadLine());
            if (nota < 1)
            {
                Console.WriteLine("La nota esta fuera de rango");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("La nota esta fuera de rango");
            }
            else if (nota >= 1 && nota <= 7)
            {
                Console.WriteLine("La no es correcta");
            }
        }
    }
}
