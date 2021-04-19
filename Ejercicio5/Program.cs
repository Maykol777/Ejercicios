using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cuantas notas quiere promediar");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1 - 2 notas");
            Console.WriteLine("2 - 4 notas");
            Console.WriteLine("3 - 6 notas");
            Console.WriteLine("4 - 8 notas");

            int seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("Ingrese la primera nota");
                Double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota");
                Double nota2 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2) / 2;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
            }
            if (seleccion == 2)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("Ingrese la primera nota");
                Double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota");
                Double nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la tercera nota");
                Double nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cuarta nota");
                Double nota4 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
            }

            if (seleccion == 3)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("Ingrese la primera nota");
                Double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota");
                Double nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la tercera nota");
                Double nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cuarta nota");
                Double nota4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la quinta nota");
                Double nota5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la sexta nota");
                Double nota6 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
            }

            if (seleccion == 4)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("Ingrese la primera nota");
                Double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota");
                Double nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la tercera nota");
                Double nota3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cuarta nota");
                Double nota4 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la quinta nota");
                Double nota5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la sexta nota");
                Double nota6 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la Septima nota");
                Double nota7 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la octava nota");
                Double nota8 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6 + nota7 + nota8) / 8;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
            }
            Console.ReadLine();
        }
    }
}
