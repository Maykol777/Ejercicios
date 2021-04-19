using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double Resultado;
            Double ResultadoT;
            double cuot1;

            Console.WriteLine("Ingrese el monto a solicitar");
            double mont = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de cuotas");
            int cuot = int.Parse(Console.ReadLine());

            if (cuot >= 1 && cuot <= 12)
            {
                Resultado = (mont * 10) / 100;
                ResultadoT = Resultado + mont;
                cuot1 = ResultadoT / cuot;
                Console.WriteLine("Su monto total a pagar es: " + ResultadoT + " Y su valor por cuota es: " + cuot1);
            }
            if (cuot >= 13 && cuot <= 30)
            {
                Resultado = (mont * 25) / 100;
                ResultadoT = Resultado + mont;
                cuot1 = ResultadoT / cuot;
                Console.WriteLine("Su monto total a pagar es: " + ResultadoT + " Y su valor por cuota es: " + cuot1);
            }
            if (cuot >= 31 && cuot <= 40)
            {
                Resultado = (mont * 35) / 100;
                ResultadoT = Resultado + mont;
                cuot1 = ResultadoT / cuot;
                Console.WriteLine("Su monto total a pagar es: " + ResultadoT + " Y su valor por cuota es: " + cuot1);
            }
            if (cuot >= 41)
            {
                Resultado = (mont * 50) / 100;
                ResultadoT = Resultado + mont;
                cuot1 = ResultadoT / cuot;
                Console.WriteLine("Su monto total a pagar es: " + ResultadoT + " Y su valor por cuota es: " + cuot1);
            }
            Console.ReadLine();
        }
    }
}
