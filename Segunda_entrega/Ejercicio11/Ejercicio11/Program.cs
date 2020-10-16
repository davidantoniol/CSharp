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
            int[] valores = {54,12,653,3,1,87,4};
            int maximo = valores[0];
            int minimo = valores[0];

            for(int i = 0; i < valores.Length; i++)
            {
                if(valores[i] > maximo)
                {
                    maximo = valores[i];
                }else if (valores[i] < minimo)
                {
                    minimo = valores[i];
                }
            }

            Console.WriteLine("El maximo en la cadena es: " + maximo);
            Console.WriteLine("El minimo en la cadena es: " + minimo);
            Console.ReadKey();
        }
    }
}
