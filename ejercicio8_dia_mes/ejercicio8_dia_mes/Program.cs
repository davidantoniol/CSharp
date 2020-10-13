using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8_dia_mes
{
    class Program{
        static void Main(string[] args){
            int month = 0;
            int year = 0;
            int days = 0;

            Console.Write("Introduce el mes para saber cuantos dias tiene: ");
            month = System.Convert.ToInt32(System.Console.ReadLine());

            Console.Write("Ahora introduce el año para calcular los dias: ");
            year = System.Convert.ToInt32(System.Console.ReadLine());

            switch (month){
                case 1:
                    days = 31;
                    Console.WriteLine("El mes de Enero del año {0} tiene {1} dias.", year, days);
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
                        days = 29;
                        Console.WriteLine("El mes de Febrero del año {0} tiene {1} dias.", year, days);
                    }
                    else
                    {
                        days = 28;
                        Console.WriteLine("El mes de Febrero del año {0} tiene {1} dias.", month, year, days);
                    }
                        break;
                case 3:
                    days = 31;
                    Console.WriteLine("El mes de Marzo del año {0} tiene {1} dias.",year, days);
                    break;
                case 4:
                    days = 30;
                    Console.WriteLine("El mes de Abril del año {0} tiene {1} dias.",year, days);
                    break;
                case 5:
                    days = 31;
                    Console.WriteLine("El mes de Mayo del año {0} tiene {1} dias.",year, days);
                    break;
                case 6:
                    days = 30;
                    Console.WriteLine("El mes de Junio del año {0} tiene {1} dias.",year, days);
                    break;
                case 7:
                    days = 31;
                    Console.WriteLine("El mes de Julio del año {0} tiene {1} dias.",year, days);
                    break;
                case 8:
                    days = 31;
                    Console.WriteLine("El mes de Agoto del año {0} tiene {1} dias.", year, days);
                    break;
                case 9:
                    days = 30;
                    Console.WriteLine("El mes de Septiembre del año {0} tiene {1} dias.", year, days);
                    break;
                case 10:
                    days = 31;
                    Console.WriteLine("El mes de Octubre del año {0} tiene {1} dias.", year, days);
                    break;
                case 11:
                    days = 30;
                    Console.WriteLine("El mes de Nobriembre  del año {0} tiene {1} dias.", year, days);
                    break;
                case 12:
                    days = 31;
                    Console.WriteLine("El mes de Diciembre del año {0} tiene {1} dias.",year, days);
                    break;
            }
            Console.ReadKey();
        }
    }
}
