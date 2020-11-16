namespace conectar_bd_mysql_asistente
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
            this.agendaDataSet = new conectar_bd_mysql_asistente.agendaDataSet();
            this.agendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosTableAdapter = new conectar_bd_mysql_asistente.agendaDataSetTableAdapters.contactosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcontactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poblacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDataSetBindingSource
            // 
            this.agendaDataSetBindingSource.DataSource = this.agendaDataSet;
            this.agendaDataSetBindingSource.Position = 0;
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "contactos";
            this.contactosBindingSource.DataSource = this.agendaDataSetBindingSource;
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontactoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.poblacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcontactoDataGridViewTextBoxColumn
            // 
            this.idcontactoDataGridViewTextBoxColumn.DataPropertyName = "id_contacto";
            this.idcontactoDataGridViewTextBoxColumn.HeaderText = "id_contacto";
            this.idcontactoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idcontactoDataGridViewTextBoxColumn.Name = "idcontactoDataGridViewTextBoxColumn";
            this.idcontactoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Width = 150;
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            this.cpDataGridViewTextBoxColumn.Width = 150;
            // 
            // poblacionDataGridViewTextBoxColumn
            // 
            this.poblacionDataGridViewTextBoxColumn.DataPropertyName = "poblacion";
            this.poblacionDataGridViewTextBoxColumn.HeaderText = "poblacion";
            this.poblacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.poblacionDataGridViewTextBoxColumn.Name = "poblacionDataGridViewTextBoxColumn";
            this.poblacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource agendaDataSetBindingSource;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private agendaDataSetTableAdapters.contactosTableAdapter contactosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poblacionDataGridViewTextBoxColumn;
    }
}

