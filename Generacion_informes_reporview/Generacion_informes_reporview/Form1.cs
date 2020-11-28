using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generacion_informes_reporview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pedidosDataSet.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.ARTICULOSTableAdapter.Fill(this.pedidosDataSet.ARTICULOS);

            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();
        }
    }
}
