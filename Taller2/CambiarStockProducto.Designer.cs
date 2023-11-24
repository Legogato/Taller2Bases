namespace Taller2
{
    partial class CambiarStockProducto
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
            this.botonActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.stockText = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxStockActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonActualizar
            // 
            this.botonActualizar.Location = new System.Drawing.Point(341, 290);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(121, 52);
            this.botonActualizar.TabIndex = 18;
            this.botonActualizar.Text = "Actualizar stock";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Seleccionar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Precio";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(341, 205);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(121, 20);
            this.textBoxStock.TabIndex = 15;
            this.textBoxStock.TextChanged += new System.EventHandler(this.textBoxStock_TextChanged);
            // 
            // stockText
            // 
            this.stockText.AutoSize = true;
            this.stockText.Location = new System.Drawing.Point(362, 189);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(73, 13);
            this.stockText.TabIndex = 14;
            this.stockText.Text = "Agregar stock";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(570, 205);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecio.TabIndex = 13;
            // 
            // textoNombre
            // 
            this.textoNombre.AutoSize = true;
            this.textoNombre.Location = new System.Drawing.Point(147, 189);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(44, 13);
            this.textoNombre.TabIndex = 12;
            this.textoNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(105, 205);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxStockActual
            // 
            this.textBoxStockActual.Enabled = false;
            this.textBoxStockActual.Location = new System.Drawing.Point(341, 252);
            this.textBoxStockActual.Name = "textBoxStockActual";
            this.textBoxStockActual.Size = new System.Drawing.Size(121, 20);
            this.textBoxStockActual.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stock Actual";
            // 
            // CambiarStockProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxStockActual);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBox1);
            this.Name = "CambiarStockProducto";
            this.Text = "CambiarStockProducto";
            this.Load += new System.EventHandler(this.CambiarStockProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label stockText;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label textoNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxStockActual;
        private System.Windows.Forms.Label label3;
    }
}