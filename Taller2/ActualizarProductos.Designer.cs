namespace Taller2
{
    partial class ActualizarProductos
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.Label();
            this.stockText = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(336, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(100, 220);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textoNombre
            // 
            this.textoNombre.AutoSize = true;
            this.textoNombre.Location = new System.Drawing.Point(142, 204);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(44, 13);
            this.textoNombre.TabIndex = 3;
            this.textoNombre.Text = "Nombre";
            this.textoNombre.Click += new System.EventHandler(this.textoNombre_Click);
            // 
            // stockText
            // 
            this.stockText.AutoSize = true;
            this.stockText.Location = new System.Drawing.Point(615, 204);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(35, 13);
            this.stockText.TabIndex = 5;
            this.stockText.Text = "Stock";
            this.stockText.Click += new System.EventHandler(this.stockText_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Enabled = false;
            this.textBoxStock.Location = new System.Drawing.Point(569, 220);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(121, 20);
            this.textBoxStock.TabIndex = 4;
            this.textBoxStock.TextChanged += new System.EventHandler(this.textBoxStock_TextChanged);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(336, 220);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecio.TabIndex = 6;
            this.textBoxPrecio.TextChanged += new System.EventHandler(this.textBoxPrecio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seleccionar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(336, 305);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(121, 52);
            this.botonActualizar.TabIndex = 9;
            this.botonActualizar.Text = "Actualizar precio";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // ActualizarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBox1);
            this.Name = "ActualizarProductos";
            this.Text = "ActualizarProductos";
            this.Load += new System.EventHandler(this.ActualizarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label textoNombre;
        private System.Windows.Forms.Label stockText;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonActualizar;
    }
}