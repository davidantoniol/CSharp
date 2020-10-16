using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9_controlexcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            double resultado = 0;
            

            Console.WriteLine("Programa donde vamos a realizar la divion de dos numeros.");
            try
            {
                Console.Write("Por favor introduce el primer valor: ");
                valor1 = System.Convert.ToInt32(System.Console.ReadLine());

                Console.Write("Por favor introduce el segundo valor: ");
                valor2 = System.Convert.ToInt32(System.Console.ReadLine());

                resultado = valor1 / valor2;
                Console.WriteLine("El resultado de {0}/{1} = {2}", valor1, valor2, resultado);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("La division entre {0} y 0 no se puede realizar.", valor1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("El valor introducido es demasiado grande.");
            }
            catch (FormatException)
            {
                Console.WriteLine("El valor introducido no es valido, intentelo la proxima vez con numero entero.");
            }
            Console.ReadKey();
        }
    }
}
