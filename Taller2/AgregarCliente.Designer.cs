namespace Taller2
{
    partial class AgregarCliente
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
            this.crearClienteButton = new System.Windows.Forms.Button();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.ciudadText = new System.Windows.Forms.TextBox();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.paisText = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.paisLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crearClienteButton
            // 
            this.crearClienteButton.Location = new System.Drawing.Point(335, 298);
            this.crearClienteButton.Name = "crearClienteButton";
            this.crearClienteButton.Size = new System.Drawing.Size(90, 35);
            this.crearClienteButton.TabIndex = 0;
            this.crearClienteButton.Text = "Crear Cliente";
            this.crearClienteButton.UseVisualStyleBackColor = true;
            this.crearClienteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(67, 148);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(100, 20);
            this.nombreText.TabIndex = 1;
            // 
            // ciudadText
            // 
            this.ciudadText.Location = new System.Drawing.Point(195, 148);
            this.ciudadText.Name = "ciudadText";
            this.ciudadText.Size = new System.Drawing.Size(100, 20);
            this.ciudadText.TabIndex = 2;
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(325, 148);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(100, 20);
            this.codigoText.TabIndex = 3;
            // 
            // paisText
            // 
            this.paisText.Location = new System.Drawing.Point(181, 220);
            this.paisText.Name = "paisText";
            this.paisText.Size = new System.Drawing.Size(100, 20);
            this.paisText.TabIndex = 4;
            this.paisText.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Extranjero";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ciudad";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(377, 132);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 9;
            this.codigoLabel.Text = "Codigo";
            // 
            // paisLabel
            // 
            this.paisLabel.AutoSize = true;
            this.paisLabel.Location = new System.Drawing.Point(217, 204);
            this.paisLabel.Name = "paisLabel";
            this.paisLabel.Size = new System.Drawing.Size(27, 13);
            this.paisLabel.TabIndex = 10;
            this.paisLabel.Text = "Pais";
            this.paisLabel.Visible = false;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paisLabel);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.paisText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.ciudadText);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.crearClienteButton);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crearClienteButton;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.TextBox ciudadText;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox paisText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label paisLabel;
    }
}