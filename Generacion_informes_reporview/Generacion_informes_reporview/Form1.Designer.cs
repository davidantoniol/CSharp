namespace Generacion_informes_reporview
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ARTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosDataSet = new Generacion_informes_reporview.pedidosDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ARTICULOSTableAdapter = new Generacion_informes_reporview.pedidosDataSetTableAdapters.ARTICULOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ARTICULOSBindingSource
            // 
            this.ARTICULOSBindingSource.DataMember = "ARTICULOS";
            this.ARTICULOSBindingSource.DataSource = this.pedidosDataSet;
            // 
            // pedidosDataSet
            // 
            this.pedidosDataSet.DataSetName = "pedidosDataSet";
            this.pedidosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ARTICULOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Generacion_informes_reporview.Inventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // ARTICULOSTableAdapter
            // 
            this.ARTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ARTICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ARTICULOSBindingSource;
        private pedidosDataSet pedidosDataSet;
        private pedidosDataSetTableAdapters.ARTICULOSTableAdapter ARTICULOSTableAdapter;
    }
}

