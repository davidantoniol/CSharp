using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaContextualHelpProvider
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label helpLabel;
        public Form1()
        {
            InitializeComponent();
           
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.helpLabel = new System.Windows.Forms.Label();

            // Help Label
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helpLabel.Location = new System.Drawing.Point(8, 80);
            this.helpLabel.Size = new System.Drawing.Size(272, 72);
            this.helpLabel.Text = "Ayuda.";

            this.helpProvider1.SetShowHelp(this.textBox2, true);
            this.helpProvider1.SetHelpString(this.textBox2, "Texbox2");

            this.helpProvider1.SetShowHelp(this.label2, true);
            this.helpProvider1.SetHelpString(this.label2, "Label2");

            this.helpProvider1.SetShowHelp(this.button2, true);
            this.helpProvider1.SetHelpString(this.button2, "button2");

            
            this.helpProvider1.HelpNamespace = "mspaint.chm";

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                    this.textBox2,this.label2,this.button2});
   
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Text = "Help Provider Demostration";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
