using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primero numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("El numero mayor es " + n1);
            }
            else
                Console.WriteLine("El numero mayor es " + n2);

            for (int contador = n1; contador <= n2; contador += 1)
            {
                Console.WriteLine(contador);
            }

            Console.ReadLine();
        }
    }
}
