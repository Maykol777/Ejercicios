using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El primer numero es par " + num1);
            }
            else
            {
                Console.WriteLine("El primer numero es impar " + num1);
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine("El segundo numero es par " + num2);
            }
            else
            {
                Console.WriteLine("El segundo numero es impar " + num2);
            }
            Console.ReadLine();
        }
    }
}
