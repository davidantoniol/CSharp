using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_bancaria_consola
{
    class Cuenta_ahorros : Bancaria_cuenta
    {
        
        private double cuota_mantenimiento;

        public Cuenta_ahorros()
        {
            Cuota_mantenimiento = cuota_mantenimiento;
            Cuota_mantenimiento = cuota_mantenimiento;
        }

        public double Cuota_mantenimiento { get => cuota_mantenimiento; set => cuota_mantenimiento = value; }

        public override void Estado_cuenta()
        {
            Console.WriteLine("Numero de cuenta: *******************");
            Console.WriteLine("Propietario: " + this.Nombre);
            Console.WriteLine("Saldo disponible: " + this.Saldo + "€");
            Console.WriteLine("Tipo de interes que tiene " + this.Tipo_interes + "%");
            Console.WriteLine("Cuota por mantenimiento: " + this.Cuota_mantenimiento);
        }
    }
}
