using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2_sumar
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            try
            {
                valor1 = int.Parse(textBox1.Text);
                valor2 = int.Parse(textBox2.Text);
                resultado = valor1 + valor2;
                label1.Visible = true;
                label1.Text = string.Format("El resultado es: " + resultado.ToString());
            }
            catch (FormatException)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Ha surguido un error comprube que los datos son correctos.");
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
