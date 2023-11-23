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
            this.comboBoxEliminarCliente = new System.Windows.Forms.ComboBox();
            this.BotonEliminarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEliminarCliente
            // 
            this.comboBoxEliminarCliente.FormattingEnabled = true;
            this.comboBoxEliminarCliente.Location = new System.Drawing.Point(272, 107);
            this.comboBoxEliminarCliente.Name = "comboBoxEliminarCliente";
            this.comboBoxEliminarCliente.Size = new System.Drawing.Size(197, 21);
            this.comboBoxEliminarCliente.TabIndex = 11;
            this.comboBoxEliminarCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxEliminarProducto_SelectedIndexChanged);
            // 
            // BotonEliminarCliente
            // 
            this.BotonEliminarCliente.Location = new System.Drawing.Point(272, 290);
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
            this.label1.Location = new System.Drawing.Point(355, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo";
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(176, 144);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.Size = new System.Drawing.Size(375, 70);
            this.dataGridViewCliente.TabIndex = 8;
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEliminarCliente);
            this.Controls.Add(this.BotonEliminarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCliente);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxEliminarCliente;
        private System.Windows.Forms.Button BotonEliminarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
    }
}