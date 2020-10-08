using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operardosvalores{
    class Program{
        static void Main(string[] args){
            int valor1 = 2;
            int valor2 = 10;

            

            Console.Write("La suma de " + valor1 + " + " + valor2 + " es: ");
            Console.WriteLine(valor1 + valor2);

            Console.Write("La resta de " + valor2 + " - " + valor1 + " es: ");
            Console.WriteLine(valor2 - valor1);

            Console.Write("El producto de " + valor1 + " * " + valor2 + " es: ");
            Console.WriteLine(valor1*valor2);

            Console.Write("El modulo de " + valor2 + " % " + valor1 + " es: ");
            Console.WriteLine( valor2%valor1);
            Console.ReadLine();
            
        }
    }
}
