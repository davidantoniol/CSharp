using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_adivino
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            Boolean salida = false;
            var random = new Random();
            int valor2 = random.Next(0,20);
            int iterador = 0;

            Console.WriteLine("Bienvenido al programa donde tienes que adivinar un numero del 0 al 20.");
            Console.WriteLine("Buena Suerte!!!");
            Console.WriteLine();
            while (salida == false){
                Console.Write("Introduce el numero: ");
                valor1 = Convert.ToInt32(Console.ReadLine());

                if (iterador >= 0)
                {
                    if (valor1 == valor2)
                    {
                        salida = true;
                        Console.WriteLine("Enhorabuena has acertado!!!!!");
                    }
                    else if (iterador == 4)
                    {
                        salida = true;
                        Console.WriteLine("Lo sentimos has agotado las opotunidades.");
                        Console.WriteLine("El valor era {0}", valor2);
                    }
                    else if (valor1 > valor2)
                    {
                        Console.WriteLine("El valor es menor que {0}", valor1);
                    }
                    else if (valor1 < valor2)
                    {
                        Console.WriteLine("El valor es mayor que {0}", valor1);
                    }
                }
                iterador++;
                valor1 = 0;
            }
            Console.ReadLine();
        }
    }
}
