using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            string signo;
            int resultado;

            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion a realizar: ");
            signo = Console.ReadLine();

            Console.WriteLine("Ingrese un numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (signo == "+")
            {
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }

            if (signo == "-")
            {
                resultado = numero1 - numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }

            if (signo == "*")
            {
                resultado = numero1 * numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }

            if (signo == "/" && numero2 == 0)
            {
                Console.WriteLine("No es posible dividir por cero");
            }

            if (signo == "/")
            {
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }




            Console.ReadKey();


        }
    }
}
