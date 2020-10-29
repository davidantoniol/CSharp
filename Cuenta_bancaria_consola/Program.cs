using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_bancaria_consola 
{
    class Program
    {
        static void Main(string[] args)
        {
            Bancaria_cuenta cuenta1 = new Bancaria_cuenta();
            Cuenta_ahorros cuenta_ahorros = new Cuenta_ahorros();

            cuenta1.Nombre = ("Antonio Perez Rodriguez");
            cuenta1.NumCuenta = (645454332);
            cuenta1.Saldo = (1875.0);
            cuenta1.Tipo_interes =(4.5);
            cuenta1.Estado_cuenta();

            Console.WriteLine();


            cuenta_ahorros.Nombre = "María Jesus Gomez Lopez";
            cuenta_ahorros.NumCuenta = (32435435);
            cuenta_ahorros.Saldo = (10578.0);
            cuenta_ahorros.Tipo_interes = (6.8);
            cuenta_ahorros.Cuota_mantenimiento = (3);
            cuenta_ahorros.Estado_cuenta();
            Console.ReadKey();
        }
    }
}
