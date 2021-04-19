using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El Primer numero es par: " + num1);
            }
            else
            {
                Console.WriteLine("El Primer numero es impar: " + num1);
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine("El Segundo numero es par: " + num2);
            }
            else
            {
                Console.WriteLine("El Segundo numero es impar: " + num2);
            }

            if (num3 % 2 == 0)
            {
                Console.WriteLine("El Tercer numero es par: " + num3);
            }
            else
            {
                Console.WriteLine("El Tercer numero es impar: " + num3);
            }

            Console.ReadLine();
        }
    }
}
