using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_diseno_mejorado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            firts1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            firts1.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firts1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            second1.BringToFront();
        }

        private void second1_Load(object sender, EventArgs e)
        {

        }
    }
}
