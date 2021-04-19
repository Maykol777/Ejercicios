using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 2)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("Este numero es impar");
            }
            Console.ReadLine();
        }
    }
}
