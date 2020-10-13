using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4_comprobar_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;

            Console.Write("Por favor introduce un numero entero: ");
            valor1 = System.Convert.ToInt32(System.Console.ReadLine());

            Console.Write("Por favor introduce otro numero entero: ");
            valor2 = System.Convert.ToInt32(System.Console.ReadLine());

            if ((valor1 % 2 == 0) && (valor2 % 2 == 0))
            {
                Console.WriteLine("Tanto el valor {0} y el valor {1} son pares", valor1, valor2);
            }
            else if (valor1 % 2 == 0) 
            {
                Console.WriteLine("El unico valor par, es el numero {0}",valor1);
            }
            else if (valor2 % 2 == 0)
            {
                Console.WriteLine("El unico valor par, es el numero {0}", valor2);
            }
            Console.ReadLine();
        }
    }
}
