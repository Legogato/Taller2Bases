namespace Taller2
{
    partial class Clientes
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
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.botonActualizarCliente = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.Location = new System.Drawing.Point(62, 171);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(149, 81);
            this.AgregarCliente.TabIndex = 0;
            this.AgregarCliente.Text = "Agregar Cliente";
            this.AgregarCliente.UseVisualStyleBackColor = true;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // botonActualizarCliente
            // 
            this.botonActualizarCliente.Location = new System.Drawing.Point(309, 171);
            this.botonActualizarCliente.Name = "botonActualizarCliente";
            this.botonActualizarCliente.Size = new System.Drawing.Size(146, 81);
            this.botonActualizarCliente.TabIndex = 1;
            this.botonActualizarCliente.Text = "Actualizar Ciudad";
            this.botonActualizarCliente.UseVisualStyleBackColor = true;
            this.botonActualizarCliente.Click += new System.EventHandler(this.botonActualizarCliente_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(537, 171);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(146, 81);
            this.botonEliminar.TabIndex = 2;
            this.botonEliminar.Text = "Eliminar Cliente";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonActualizarCliente);
            this.Controls.Add(this.AgregarCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.Button botonActualizarCliente;
        private System.Windows.Forms.Button botonEliminar;
    }
}