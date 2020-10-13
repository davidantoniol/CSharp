using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_numeros_sietes
{
    class Program{
        public static void con_foreach(String valor1){
            char abuscar = '7';
            int cantidad_7 = 0;

            foreach (char c in valor1)
            {
                if (abuscar == c)
                {
                    cantidad_7++;

                }
            }
            Console.WriteLine("La canatidad de 7 que hay es: {0}", cantidad_7);
        }
        public static void con_dowhile(String valor1){
            int iterador = 0;
            int valor2 = 0;
            int cantidad_7 = 0;
            String abuscar = "7";
            String cadena = "";
            

            valor2 = valor1.Length;

            do{
                char caracter = valor1[iterador];
                cadena = cadena + caracter;

                if (cadena.Contains(abuscar))
                {
                    cantidad_7++;
                    cadena = "";
                }
                iterador++;
            } while (iterador < valor2);

            Console.WriteLine("La canatidad de 7 que hay es: {0}", cantidad_7);
        }
        static void Main(string[] args)
        {
            String valor1 = "";

            Console.Write("Introduce los numeros enteros que desee: ");
            valor1 = System.Console.ReadLine();

            Console.WriteLine("Hemos buscado la cantidad de 7 con un bucle Foreach.");
            con_foreach(valor1);

            Console.WriteLine("Hemos buscado la cantidad de 7 con un bucle do while.");
            con_dowhile(valor1);

            Console.ReadLine();
        }
    }
}
