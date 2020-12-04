namespace menu_contextual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrandarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encogerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip2;
            this.button1.Location = new System.Drawing.Point(149, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mi Botón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tamañoToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(147, 68);
            // 
            // tamañoToolStripMenuItem
            // 
            this.tamañoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrandarToolStripMenuItem,
            this.encogerToolStripMenuItem});
            this.tamañoToolStripMenuItem.Name = "tamañoToolStripMenuItem";
            this.tamañoToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
            this.tamañoToolStripMenuItem.Text = "Tamaño";
            this.tamañoToolStripMenuItem.Click += new System.EventHandler(this.tamañoToolStripMenuItem_Click);
            // 
            // agrandarToolStripMenuItem
            // 
            this.agrandarToolStripMenuItem.Name = "agrandarToolStripMenuItem";
            this.agrandarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agrandarToolStripMenuItem.Text = "Agrandar";
            this.agrandarToolStripMenuItem.Click += new System.EventHandler(this.agrandarToolStripMenuItem_Click_1);
            // 
            // encogerToolStripMenuItem
            // 
            this.encogerToolStripMenuItem.Name = "encogerToolStripMenuItem";
            this.encogerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.encogerToolStripMenuItem.Text = "Encoger";
            this.encogerToolStripMenuItem.Click += new System.EventHandler(this.encogerToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fondoToolStripMenuItem,
            this.letraToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(146, 32);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // fondoToolStripMenuItem
            // 
            this.fondoToolStripMenuItem.Name = "fondoToolStripMenuItem";
            this.fondoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.fondoToolStripMenuItem.Text = "Fondo";
            this.fondoToolStripMenuItem.Click += new System.EventHandler(this.fondoToolStripMenuItem_Click_2);
            // 
            // letraToolStripMenuItem
            // 
            this.letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            this.letraToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.letraToolStripMenuItem.Text = "Letra";
            this.letraToolStripMenuItem.Click += new System.EventHandler(this.letraToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Creacion de menús contextuales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tamañoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrandarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encogerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fondoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

