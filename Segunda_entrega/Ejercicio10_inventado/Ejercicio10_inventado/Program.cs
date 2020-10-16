using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_inventado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 42, 14, 67, 54, 34, 79, 64 };
            int suma = 0;
            double media = 0;

            for(int i = 0;i < valores.Length; i++)
            {
                suma = suma + valores[i];
            }

            media = suma / valores.Length;

            Console.WriteLine("La media es: {0}", media);
            Console.ReadKey();
        }
    }
}
