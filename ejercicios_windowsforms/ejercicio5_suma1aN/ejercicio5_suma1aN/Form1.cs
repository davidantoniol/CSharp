using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5_suma1aN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = 1;
            int valor2 = 0;
            int resultado = 0;

            valor2 = Convert.ToInt32(numericUpDown1.Value);

            for(int i = 1;i <= valor2; i++)
            {
                if(i == 1)
                {
                    resultado = valor1;
                }
                else
                {
                    resultado = resultado + i;
                } 

                if(checkBox1.Checked == true)
                {
                    listBox1.Items.Add("Sumando: " + i + " Suma parcial: " + resultado);
                }
            }
            listBox1.Items.Add("La suma TOTAL es: " + resultado);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
