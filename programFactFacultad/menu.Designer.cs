namespace programFactFacultad
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.botonVendedores = new System.Windows.Forms.Button();
            this.botonClientes = new System.Windows.Forms.Button();
            this.botonProductos = new System.Windows.Forms.Button();
            this.botonFacturacion = new System.Windows.Forms.Button();
            this.botonInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonVendedores
            // 
            this.botonVendedores.Image = ((System.Drawing.Image)(resources.GetObject("botonVendedores.Image")));
            this.botonVendedores.Location = new System.Drawing.Point(12, 12);
            this.botonVendedores.Name = "botonVendedores";
            this.botonVendedores.Size = new System.Drawing.Size(133, 96);
            this.botonVendedores.TabIndex = 0;
            this.botonVendedores.Text = "\nvendedores";
            this.botonVendedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonVendedores.UseVisualStyleBackColor = true;
            this.botonVendedores.Click += new System.EventHandler(this.botonVendedores_Click);
            // 
            // botonClientes
            // 
            this.botonClientes.Image = ((System.Drawing.Image)(resources.GetObject("botonClientes.Image")));
            this.botonClientes.Location = new System.Drawing.Point(161, 12);
            this.botonClientes.Name = "botonClientes";
            this.botonClientes.Size = new System.Drawing.Size(131, 96);
            this.botonClientes.TabIndex = 1;
            this.botonClientes.Text = "clientes";
            this.botonClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonClientes.UseVisualStyleBackColor = true;
            // 
            // botonProductos
            // 
            this.botonProductos.Image = ((System.Drawing.Image)(resources.GetObject("botonProductos.Image")));
            this.botonProductos.Location = new System.Drawing.Point(12, 132);
            this.botonProductos.Name = "botonProductos";
            this.botonProductos.Size = new System.Drawing.Size(133, 102);
            this.botonProductos.TabIndex = 2;
            this.botonProductos.Text = "\npoductos";
            this.botonProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonProductos.UseVisualStyleBackColor = true;
            // 
            // botonFacturacion
            // 
            this.botonFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("botonFacturacion.Image")));
            this.botonFacturacion.Location = new System.Drawing.Point(161, 132);
            this.botonFacturacion.Name = "botonFacturacion";
            this.botonFacturacion.Size = new System.Drawing.Size(131, 102);
            this.botonFacturacion.TabIndex = 3;
            this.botonFacturacion.Text = "Facturacion";
            this.botonFacturacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonFacturacion.UseVisualStyleBackColor = true;
            // 
            // botonInformes
            // 
            this.botonInformes.Image = ((System.Drawing.Image)(resources.GetObject("botonInformes.Image")));
            this.botonInformes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonInformes.Location = new System.Drawing.Point(113, 240);
            this.botonInformes.Name = "botonInformes";
            this.botonInformes.Size = new System.Drawing.Size(84, 57);
            this.botonInformes.TabIndex = 4;
            this.botonInformes.Text = "Informes\r\n";
            this.botonInformes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonInformes.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 305);
            this.Controls.Add(this.botonInformes);
            this.Controls.Add(this.botonFacturacion);
            this.Controls.Add(this.botonProductos);
            this.Controls.Add(this.botonClientes);
            this.Controls.Add(this.botonVendedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menu";
            this.Text = "Menú";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVendedores;
        private System.Windows.Forms.Button botonClientes;
        private System.Windows.Forms.Button botonProductos;
        private System.Windows.Forms.Button botonFacturacion;
        private System.Windows.Forms.Button botonInformes;
    }
}

