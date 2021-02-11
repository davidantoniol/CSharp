using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BotonSakir
{
    public partial class ButtonSalir: UserControl
    {
        ToolTip toolTip1 = new ToolTip();
        public ButtonSalir()
        {
            InitializeComponent();
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;

            this.toolTip1.ShowAlways = true;
            this.toolTip1.IsBalloon = true;

            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 800;
            this.toolTip1.InitialDelay = 122;

            this.toolTip1.SetToolTip(this.pictureBox1, "Salir.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            String openPDFFile = @"C:\Users\adavi\Desktop\BotonSakir\Resources\icons8_shutdown_40px_1.png";
            
            pictureBox1.Image = Image.FromFile(openPDFFile);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            String openPDFFile = @"C:\Users\adavi\Desktop\BotonSakir\Resources\icons8_shutdown_40px.png";
            
            pictureBox1.Image = Image.FromFile(openPDFFile);
        }
    }
}
