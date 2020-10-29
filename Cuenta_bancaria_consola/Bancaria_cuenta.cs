using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_bancaria_consola
{
    class Bancaria_cuenta
    {
        private int numCuenta;
        private String nombre;
        private double saldo;
        private double tipo_interes;

        public int NumCuenta { get => numCuenta; set => numCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Tipo_interes { get => tipo_interes; set => tipo_interes = value; }

        public Bancaria_cuenta()
        {
            NumCuenta = numCuenta;
            Nombre = nombre;
            Saldo = saldo;
            Tipo_interes = tipo_interes;
            NumCuenta = numCuenta;
            Nombre = nombre;
            Saldo = saldo;
            Tipo_interes = tipo_interes;
        }

        public virtual void Estado_cuenta()
        {
            Console.WriteLine("Numero de cuenta: *******************");
            Console.WriteLine("Propietario: " + this.Nombre);
            Console.WriteLine("Saldo disponible: " + this.Saldo+"€");
            Console.WriteLine("Tipo de interes que tiene " + this.Tipo_interes +"%");
        }
    }
}
