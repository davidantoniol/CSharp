using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7_ajedrez
{
    class Program
    {
        static void Main(string[] args){
            int fila_alf = 1;
            int columna_alf = 3;

            do
            {
                if (fila_alf > 8 || fila_alf < 1)
                {
                    Console.WriteLine("Por favor la fila del Alfil sera valida si esta entre 1 y 8.");
                }
                Console.Write("Fila del Alfil: ");
                fila_alf = System.Convert.ToInt32(Console.ReadLine());
            } while (fila_alf > 8 || fila_alf < 1);
            do
            {
                if (columna_alf > 8 || columna_alf < 1)
                {
                    Console.WriteLine("Por favor la columna del Alfil sera valida si esta entre 1 y 8.");
                }
                Console.Write("Columna del Alfil: ");
                columna_alf = System.Convert.ToInt32(Console.ReadLine());
            } while (columna_alf > 8 || columna_alf < 1);

            for (int row = 1; row <= 8; row++)
            {
                for (int colums = 1; colums <= 8; colums++)
                {
                    if ((row - colums == fila_alf - columna_alf) || (row + colums == fila_alf + columna_alf))
                    {
                        Console.Write(" * ");
                    }
                    else if ((row + colums) % 2 == 0)
                    {
                        Console.Write(" B ");
                    }
                    else
                    {
                        Console.Write(" N ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
