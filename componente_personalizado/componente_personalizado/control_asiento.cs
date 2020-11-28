using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componente_personalizado
{
    public partial class control_asiento : UserControl
    {
        int contador = 0;
        public control_asiento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                contador = 1;
            }
            else if (contador == 2)
            {
                contador = 1;
            }
            else if (contador == 1)
            {
                contador = 2;
            }
            if (contador == 1)
            {
                pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("asientos");
                label1.Text = "O";
            }
            else if (contador == 2)
            {
                pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("asiento1");
                label1.Text = "D";
            }
        }
    }
}
