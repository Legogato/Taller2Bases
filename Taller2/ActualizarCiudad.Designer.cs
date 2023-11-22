namespace Taller2
{
    partial class ActualizarCiudad
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
            this.botonActualizarCiudad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.stockText = new System.Windows.Forms.Label();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxActualizarCiudad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botonActualizarCiudad
            // 
            this.botonActualizarCiudad.Location = new System.Drawing.Point(341, 290);
            this.botonActualizarCiudad.Name = "botonActualizarCiudad";
            this.botonActualizarCiudad.Size = new System.Drawing.Size(121, 52);
            this.botonActualizarCiudad.TabIndex = 18;
            this.botonActualizarCiudad.Text = "Actualizar ciudad";
            this.botonActualizarCiudad.UseVisualStyleBackColor = true;
            this.botonActualizarCiudad.Click += new System.EventHandler(this.botonActualizarCiudad_Click);
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
            this.label1.Location = new System.Drawing.Point(388, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(341, 205);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(121, 20);
            this.textBoxCiudad.TabIndex = 15;
            // 
            // stockText
            // 
            this.stockText.AutoSize = true;
            this.stockText.Location = new System.Drawing.Point(620, 189);
            this.stockText.Name = "stockText";
            this.stockText.Size = new System.Drawing.Size(28, 13);
            this.stockText.TabIndex = 14;
            this.stockText.Text = "Tipo";
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Enabled = false;
            this.textBoxTipo.Location = new System.Drawing.Point(574, 205);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(121, 20);
            this.textBoxTipo.TabIndex = 13;
            // 
            // textoNombre
            // 
            this.textoNombre.AutoSize = true;
            this.textoNombre.Location = new System.Drawing.Point(142, 189);
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
            // comboBoxActualizarCiudad
            // 
            this.comboBoxActualizarCiudad.FormattingEnabled = true;
            this.comboBoxActualizarCiudad.Location = new System.Drawing.Point(341, 124);
            this.comboBoxActualizarCiudad.Name = "comboBoxActualizarCiudad";
            this.comboBoxActualizarCiudad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxActualizarCiudad.TabIndex = 10;
            this.comboBoxActualizarCiudad.SelectedIndexChanged += new System.EventHandler(this.comboBoxActualizarCiudad_SelectedIndexChanged);
            // 
            // ActualizarCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonActualizarCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.stockText);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.comboBoxActualizarCiudad);
            this.Name = "ActualizarCiudad";
            this.Text = "ActualizarCiudad";
            this.Load += new System.EventHandler(this.ActualizarCiudad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonActualizarCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label stockText;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label textoNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxActualizarCiudad;
    }
}