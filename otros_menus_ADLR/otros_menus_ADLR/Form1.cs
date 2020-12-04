using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otros_menus_ADLR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Maximum = 0;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                    toolStripProgressBar1.Maximum = 100000;
                    toolStripProgressBar1.Step = 1;

                    for (int j = 0; j < 100000; j++)
                    {
                        Caluculate(j);
                        toolStripProgressBar1.PerformStep();
                    }
                }
                toolStripStatusLabel1.Text = "Imagen seleccionada";
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
