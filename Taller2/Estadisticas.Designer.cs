namespace Taller2
{
    partial class Estadisticas
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
            this.botonListaClientes = new System.Windows.Forms.Button();
            this.botonListadoProductos = new System.Windows.Forms.Button();
            this.botonVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonListaClientes
            // 
            this.botonListaClientes.Location = new System.Drawing.Point(141, 194);
            this.botonListaClientes.Name = "botonListaClientes";
            this.botonListaClientes.Size = new System.Drawing.Size(130, 55);
            this.botonListaClientes.TabIndex = 0;
            this.botonListaClientes.Text = "Ver listado de clientes";
            this.botonListaClientes.UseVisualStyleBackColor = true;
            this.botonListaClientes.Click += new System.EventHandler(this.botonListaClientes_Click);
            // 
            // botonListadoProductos
            // 
            this.botonListadoProductos.Location = new System.Drawing.Point(333, 194);
            this.botonListadoProductos.Name = "botonListadoProductos";
            this.botonListadoProductos.Size = new System.Drawing.Size(130, 55);
            this.botonListadoProductos.TabIndex = 1;
            this.botonListadoProductos.Text = "Listados Productos";
            this.botonListadoProductos.UseVisualStyleBackColor = true;
            this.botonListadoProductos.Click += new System.EventHandler(this.botonListadoProductos_Click);
            // 
            // botonVentas
            // 
            this.botonVentas.Location = new System.Drawing.Point(536, 194);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(130, 55);
            this.botonVentas.TabIndex = 2;
            this.botonVentas.Text = "Ver ventas";
            this.botonVentas.UseVisualStyleBackColor = true;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonVentas);
            this.Controls.Add(this.botonListadoProductos);
            this.Controls.Add(this.botonListaClientes);
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonListaClientes;
        private System.Windows.Forms.Button botonListadoProductos;
        private System.Windows.Forms.Button botonVentas;
    }
}