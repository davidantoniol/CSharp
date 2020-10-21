using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio4_costedeenvio
{
    public partial class Form1 : Form
    {
        private double precio_correo_normal = 10;
        private double precio_paqueteria_normal = 15;
        private double precio_paqueteria_urgente = 25;
        private double precio_notificacion_email = 5;
        private double precio_notificacion_telefono = 7.50;
        private double precio_notificacion_fax = 12.50;
        private double gastos_total_envio = 0;

        public void set_gastos_total_envio(double precio)
        {
            if(precio != 0)
            {
                gastos_total_envio = gastos_total_envio + precio;
            }
            else
            {
                gastos_total_envio = precio;
            }
        }
        public double get_gastos_total_envio()
        {
            return gastos_total_envio;
        }
        public double get_precio_correo_normal()
        {
            return precio_correo_normal;
        }
        public double get_precio_paqueteria_normal()
        {
            return precio_paqueteria_normal;
        }
        public double get_precio_paqueteria_urgente()
        {
            return precio_paqueteria_urgente;
        }
        public double get_precio_notificacion_email()
        {
            return precio_notificacion_email;
        }
        public double get_precio_notificacion_telefono()
        {
            return precio_notificacion_telefono;
        }
        public double get_precio_notificacion_fax()
        {
            return precio_notificacion_fax;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                set_gastos_total_envio(get_precio_notificacion_email());
            }
            if(checkBox2.Checked == true)
            {
                set_gastos_total_envio(get_precio_notificacion_telefono());
            }
            if(checkBox3.Checked == true)
            {
                set_gastos_total_envio(get_precio_notificacion_fax());
            }
            if(radioButton1.Checked == true)
            {
                set_gastos_total_envio(get_precio_correo_normal());
            }else if(radioButton2.Checked == true)
            {
                set_gastos_total_envio(get_precio_paqueteria_normal());
            }
            else
            {
                set_gastos_total_envio(get_precio_paqueteria_urgente());
            }
            textBox1.Text = Convert.ToString(get_gastos_total_envio());
            set_gastos_total_envio(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            set_gastos_total_envio(0);
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox1.Text = Convert.ToString(" ");
            MessageBox.Show("El envio se ha aceptado. Gracias!!!!");
        }
    }
}
