using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_contextual
{
    public partial class Form1 : Form
    {
        int contador1 = 0;
        int contador2 = 0;
        Color colorUtil;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Color seleccionar_Color()
        {
            return colorUtil;
        }

        ColorDialog objColor = new ColorDialog();
        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objColor.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objColor.Color;
                button1.BackColor = seleccionar_Color();
            }
        }

        private void palabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objColor.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objColor.Color;
                button1.ForeColor = seleccionar_Color();
            }
        }

        private void tamañoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agrandarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (contador1 < 2)
            {
                button1.Height *= 2;
                button1.Width *= 2;
            }
            else
            {
                MessageBox.Show("No se puede agrandar más el botón");
            }
            contador1++;
        }

        private void encogerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contador2 < 2)
            {
                button1.Height /= 2;
                button1.Width /= 2;
            }
            else
            {
                MessageBox.Show("No se puede encoger más el botón");
            }
            contador2++;
        }

        private void fondoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if (objColor.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objColor.Color;
                button1.BackColor = seleccionar_Color();
            }
        }

        private void letraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (objColor.ShowDialog() == DialogResult.OK)
            {
                colorUtil = objColor.Color;
                button1.ForeColor = seleccionar_Color();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
