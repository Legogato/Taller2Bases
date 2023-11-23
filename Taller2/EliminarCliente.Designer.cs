namespace Taller2
{
    partial class EliminarCliente
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
            this.textBoxEliminarProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEliminarProducto = new System.Windows.Forms.ComboBox();
            this.BotonEliminarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEliminarProducto
            // 
            this.textBoxEliminarProducto.Location = new System.Drawing.Point(60, 266);
            this.textBoxEliminarProducto.Name = "textBoxEliminarProducto";
            this.textBoxEliminarProducto.Size = new System.Drawing.Size(200, 20);
            this.textBoxEliminarProducto.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // comboBoxEliminarProducto
            // 
            this.comboBoxEliminarProducto.FormattingEnabled = true;
            this.comboBoxEliminarProducto.Location = new System.Drawing.Point(63, 165);
            this.comboBoxEliminarProducto.Name = "comboBoxEliminarProducto";
            this.comboBoxEliminarProducto.Size = new System.Drawing.Size(197, 21);
            this.comboBoxEliminarProducto.TabIndex = 11;
            this.comboBoxEliminarProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxEliminarProducto_SelectedIndexChanged);
            // 
            // BotonEliminarCliente
            // 
            this.BotonEliminarCliente.Location = new System.Drawing.Point(63, 329);
            this.BotonEliminarCliente.Name = "BotonEliminarCliente";
            this.BotonEliminarCliente.Size = new System.Drawing.Size(197, 44);
            this.BotonEliminarCliente.TabIndex = 10;
            this.BotonEliminarCliente.Text = "Eliminar";
            this.BotonEliminarCliente.UseVisualStyleBackColor = true;
            this.BotonEliminarCliente.Click += new System.EventHandler(this.BotonEliminarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo";
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(345, 57);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(395, 337);
            this.dataGridViewProducto.TabIndex = 8;
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEliminarProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEliminarProducto);
            this.Controls.Add(this.BotonEliminarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProducto);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEliminarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEliminarProducto;
        private System.Windows.Forms.Button BotonEliminarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProducto;
    }
}