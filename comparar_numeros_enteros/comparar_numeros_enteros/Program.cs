using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparar_numeros_enteros{
    class Program{
        static void Main(string[] args){
            int valor1 = 0;
            int valor2 = 0;

            Console.WriteLine("Programa que compara dos numeros enteros.");

            Console.Write("Por favor introduce un numero entero: ");
            valor1 = System.Convert.ToInt32(System.Console.ReadLine());

            Console.Write("Por faavor introduce otro numero entero: ");
            valor2 = System.Convert.ToInt32(System.Console.ReadLine());

            if(valor1 > valor2){
                Console.WriteLine("El valor mas grande que ha introducido es " + valor1);
            }else if(valor2 > valor1){
                Console.WriteLine("El valor mas grande que ha introducido es " + valor2);
            }
            Console.ReadLine();
        }
    }
}
