using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio6_maquina_refrescos
{
    public partial class Form1 : Form
    {
        public double gastos = 0;
        public double dinero_ingresado = 0;
        public double cambio = 0;

        public Form1()
        {
            InitializeComponent();
            listBox2.Items.Add("1.Elegir los productos deseados.");
            listBox2.Items.Add("2.Ingresar el dinero para pagar.");
            listBox2.Items.Add("3.Una vez introducido el dinero, " +
                "pulsar 'Pagar'.");
            listBox2.Items.Add("4.Recoger su cambio.");
            listBox2.Items.Add("5.Para realizar otra compra, " +
                "pulsar 'Realizar otra compra'.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double precio = 1.00;

            listBox1.Items.Add("Agua");
            
            gastos = gastos + precio;
            textBox2.Text = Convert.ToString(gastos + "€");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            double precio = 1.30;
            listBox1.Items.Add("CocaCola");

            gastos = gastos + precio;
            textBox2.Text = Convert.ToString(gastos + "€");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            double precio = 1.50;
            listBox1.Items.Add("Fanta Naranja");

            gastos = gastos + precio;
            textBox2.Text = Convert.ToString(gastos + "€");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            double precio = 1.50;
            listBox1.Items.Add("Fanta limón");

            gastos = gastos + precio;
            textBox2.Text = Convert.ToString(gastos + "€");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            double precio = 1.20;
            listBox1.Items.Add("Pepsi");

            gastos = gastos + precio;
            textBox2.Text = Convert.ToString(gastos);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dinero_ingresado = Convert.ToDouble(textBox1.Text);

            if(gastos == dinero_ingresado)
            {
                textBox3.Text = Convert.ToString(cambio + "€");
                textBox4.Visible = true;
                textBox4.Text = ("Gracias,por realizar su comprar.");
            } else if(gastos < dinero_ingresado)
            {
                if (dinero_ingresado > 20)
                {
                    MessageBox.Show("No se admite billetes mayores de 20€.");
                }
                else
                {
                    cambio = dinero_ingresado - gastos;
                    textBox3.Text = Convert.ToString(cambio + "€");
                    textBox4.Visible = true;
                    textBox4.Text = ("Gracias,por realizar su comprar y no se olvide de recoger su cambio.");
                }
                
            }
            else if(gastos > dinero_ingresado)
            {
                cambio = gastos - dinero_ingresado;
                MessageBox.Show("Perdón le falta por ingresar: " + cambio + "€");
                cambio = 0;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gastos = 0;
            cambio = 0;
            dinero_ingresado = 0;
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
