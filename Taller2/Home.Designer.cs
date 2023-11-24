namespace Taller2
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonProductos = new System.Windows.Forms.Button();
            this.BotonClientes = new System.Windows.Forms.Button();
            this.botonVentas = new System.Windows.Forms.Button();
            this.botonEstadisticas = new System.Windows.Forms.Button();
            this.botonCambiarStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonProductos
            // 
            this.botonProductos.Location = new System.Drawing.Point(56, 77);
            this.botonProductos.Name = "botonProductos";
            this.botonProductos.Size = new System.Drawing.Size(177, 80);
            this.botonProductos.TabIndex = 0;
            this.botonProductos.Text = "Modificar Productos";
            this.botonProductos.UseVisualStyleBackColor = true;
            this.botonProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonClientes
            // 
            this.BotonClientes.Location = new System.Drawing.Point(56, 186);
            this.BotonClientes.Name = "BotonClientes";
            this.BotonClientes.Size = new System.Drawing.Size(177, 80);
            this.BotonClientes.TabIndex = 1;
            this.BotonClientes.Text = "Modificar Clientes";
            this.BotonClientes.UseVisualStyleBackColor = true;
            this.BotonClientes.Click += new System.EventHandler(this.BotonClientes_Click);
            // 
            // botonVentas
            // 
            this.botonVentas.Location = new System.Drawing.Point(56, 298);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(177, 80);
            this.botonVentas.TabIndex = 2;
            this.botonVentas.Text = "Ventas";
            this.botonVentas.UseVisualStyleBackColor = true;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // botonEstadisticas
            // 
            this.botonEstadisticas.Location = new System.Drawing.Point(565, 298);
            this.botonEstadisticas.Name = "botonEstadisticas";
            this.botonEstadisticas.Size = new System.Drawing.Size(177, 80);
            this.botonEstadisticas.TabIndex = 3;
            this.botonEstadisticas.Text = "Estadisticas";
            this.botonEstadisticas.UseVisualStyleBackColor = true;
            this.botonEstadisticas.Click += new System.EventHandler(this.botonEstadisticas_Click);
            // 
            // botonCambiarStock
            // 
            this.botonCambiarStock.Location = new System.Drawing.Point(565, 186);
            this.botonCambiarStock.Name = "botonCambiarStock";
            this.botonCambiarStock.Size = new System.Drawing.Size(177, 80);
            this.botonCambiarStock.TabIndex = 4;
            this.botonCambiarStock.Text = "Cambiar Stock de un producto";
            this.botonCambiarStock.UseVisualStyleBackColor = true;
            this.botonCambiarStock.Click += new System.EventHandler(this.botonCambiarStock_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCambiarStock);
            this.Controls.Add(this.botonEstadisticas);
            this.Controls.Add(this.botonVentas);
            this.Controls.Add(this.BotonClientes);
            this.Controls.Add(this.botonProductos);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonProductos;
        private System.Windows.Forms.Button BotonClientes;
        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonEstadisticas;
        private System.Windows.Forms.Button botonCambiarStock;
    }
}