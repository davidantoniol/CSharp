using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaContextualTooltips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.AutoPopDelay = 5000;

            toolTip1.ShowAlways = true;
            toolTip1.IsBalloon = true;

            toolTip1.AutomaticDelay = 800;
            toolTip1.AutoPopDelay = 800;
            toolTip1.InitialDelay = 122;

            toolTip1.ToolTipIcon = (ToolTipIcon)2;

            toolTip1.SetToolTip(this.label1, "My label1");
            toolTip1.SetToolTip(this.textBox1, "My textBox1");
            toolTip1.SetToolTip(this.button1, "My button1");
        }
    }
}
