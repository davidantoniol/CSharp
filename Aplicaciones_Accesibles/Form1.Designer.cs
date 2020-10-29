namespace Aplicaciones_Accesibles
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
            if (disposing && components != null)
            {
                components.Dispose();
            }
            Microsoft.Win32.SystemEvents.UserPreferenceChanged
               -= new Microsoft.Win32.UserPreferenceChangedEventHandler(
               this.UserPreferenceChanged);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Nombre_del_cliente = new System.Windows.Forms.TextBox();
            this.coberturas = new System.Windows.Forms.CheckedListBox();
            this.ingredientesetiqueta = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orden = new System.Windows.Forms.Button();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.pizzagrande = new System.Windows.Forms.RadioButton();
            this.pequeñapizza = new System.Windows.Forms.RadioButton();
            this.logo = new System.Windows.Forms.PictureBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.theMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sizeOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.theMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre_del_cliente
            // 
            this.Nombre_del_cliente.AccessibleDescription = "Nombre del cliente";
            this.Nombre_del_cliente.AccessibleName = "Nombre del cliente";
            this.Nombre_del_cliente.Location = new System.Drawing.Point(537, 183);
            this.Nombre_del_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre_del_cliente.Name = "Nombre_del_cliente";
            this.Nombre_del_cliente.Size = new System.Drawing.Size(289, 30);
            this.Nombre_del_cliente.TabIndex = 3;
            // 
            // coberturas
            // 
            this.coberturas.AccessibleDescription = "Coberturas disponibles";
            this.coberturas.AccessibleName = "Coberturas disponibles";
            this.coberturas.FormattingEnabled = true;
            this.coberturas.Items.AddRange(new object[] {
            "Jaime",
            "Paulo",
            "Salva"});
            this.coberturas.Location = new System.Drawing.Point(537, 270);
            this.coberturas.Margin = new System.Windows.Forms.Padding(4);
            this.coberturas.Name = "coberturas";
            this.coberturas.Size = new System.Drawing.Size(287, 139);
            this.coberturas.TabIndex = 6;
            // 
            // ingredientesetiqueta
            // 
            this.ingredientesetiqueta.AccessibleDescription = "Etiqueta de ingredientes";
            this.ingredientesetiqueta.AccessibleName = "Etiqueta de ingredientes";
            this.ingredientesetiqueta.AutoSize = true;
            this.ingredientesetiqueta.Location = new System.Drawing.Point(532, 238);
            this.ingredientesetiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingredientesetiqueta.Name = "ingredientesetiqueta";
            this.ingredientesetiqueta.Size = new System.Drawing.Size(277, 25);
            this.ingredientesetiqueta.TabIndex = 5;
            this.ingredientesetiqueta.Text = "&Condimentos($0.75 cada uno)";
            // 
            // customerLabel
            // 
            this.customerLabel.AccessibleDescription = "Etiqueta de nombre del cliente";
            this.customerLabel.AccessibleName = "Etiqueta de nombre del cliente";
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(436, 183);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(81, 25);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "&Nombre";
            // 
            // orden
            // 
            this.orden.AccessibleDescription = "Total del pedido";
            this.orden.AccessibleName = "Total del pedido";
            this.orden.Location = new System.Drawing.Point(535, 454);
            this.orden.Margin = new System.Windows.Forms.Padding(4);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(139, 46);
            this.orden.TabIndex = 7;
            this.orden.Text = "&Pedir";
            this.orden.UseVisualStyleBackColor = true;
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Opciones de tamaño de pizza";
            this.sizeOptions.AccessibleName = "Opciones de tamaño de pizza";
            this.sizeOptions.Controls.Add(this.pizzagrande);
            this.sizeOptions.Controls.Add(this.pequeñapizza);
            this.sizeOptions.Location = new System.Drawing.Point(86, 238);
            this.sizeOptions.Margin = new System.Windows.Forms.Padding(4);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Padding = new System.Windows.Forms.Padding(4);
            this.sizeOptions.Size = new System.Drawing.Size(292, 171);
            this.sizeOptions.TabIndex = 4;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Tamaño de la pizza";
            // 
            // pizzagrande
            // 
            this.pizzagrande.AccessibleDescription = "Pizza grande";
            this.pizzagrande.AccessibleName = "Pizza grande";
            this.pizzagrande.AutoSize = true;
            this.pizzagrande.Location = new System.Drawing.Point(0, 71);
            this.pizzagrande.Margin = new System.Windows.Forms.Padding(4);
            this.pizzagrande.Name = "pizzagrande";
            this.pizzagrande.Size = new System.Drawing.Size(167, 29);
            this.pizzagrande.TabIndex = 1;
            this.pizzagrande.Text = "&Grande $10.00";
            this.pizzagrande.UseVisualStyleBackColor = true;
            // 
            // pequeñapizza
            // 
            this.pequeñapizza.AccessibleDescription = "Pizza pequeña";
            this.pequeñapizza.AccessibleName = "Pizza pequeña";
            this.pequeñapizza.AutoSize = true;
            this.pequeñapizza.Checked = true;
            this.pequeñapizza.Location = new System.Drawing.Point(0, 34);
            this.pequeñapizza.Margin = new System.Windows.Forms.Padding(4);
            this.pequeñapizza.Name = "pequeñapizza";
            this.pequeñapizza.Size = new System.Drawing.Size(175, 29);
            this.pequeñapizza.TabIndex = 0;
            this.pequeñapizza.TabStop = true;
            this.pequeñapizza.Text = "&Pequeño $ 6.00";
            this.pequeñapizza.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "Una porción de pizza";
            this.logo.AccessibleName = "Logo de la compañia";
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(86, 54);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(104, 101);
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Nombre de empresa";
            this.companyLabel.AccessibleName = "Nombre de empresa";
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(256, 47);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(570, 108);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Buena pizza";
            // 
            // cancelar
            // 
            this.cancelar.AccessibleDescription = "Cancelar el pedido";
            this.cancelar.AccessibleName = "Cancelar el pedido";
            this.cancelar.Location = new System.Drawing.Point(243, 454);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(134, 45);
            this.cancelar.TabIndex = 8;
            this.cancelar.Text = "&Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // theMainMenu
            // 
            this.theMainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.theMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.theMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCommands});
            this.theMainMenu.Location = new System.Drawing.Point(0, 0);
            this.theMainMenu.Name = "theMainMenu";
            this.theMainMenu.Size = new System.Drawing.Size(1067, 33);
            this.theMainMenu.TabIndex = 10;
            this.theMainMenu.Text = "menuStrip1";
            // 
            // fileCommands
            // 
            this.fileCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitApp});
            this.fileCommands.Name = "fileCommands";
            this.fileCommands.Size = new System.Drawing.Size(54, 29);
            this.fileCommands.Text = "&File";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(141, 34);
            this.exitApp.Text = "E&xit";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Formulario de pedido";
            this.AccessibleName = "Formulario de pedido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.sizeOptions);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.ingredientesetiqueta);
            this.Controls.Add(this.coberturas);
            this.Controls.Add(this.Nombre_del_cliente);
            this.Controls.Add(this.theMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.theMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Formulario de pedido de pizza";
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.theMainMenu.ResumeLayout(false);
            this.theMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre_del_cliente;
        private System.Windows.Forms.CheckedListBox coberturas;
        private System.Windows.Forms.Label ingredientesetiqueta;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.RadioButton pizzagrande;
        private System.Windows.Forms.RadioButton pequeñapizza;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.MenuStrip theMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileCommands;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

