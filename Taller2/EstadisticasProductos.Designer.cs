namespace Taller2
{
    partial class EstadisticasProductos
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
            this.dataGridViewActuales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewNacionales = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewExtranjeros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNacional = new System.Windows.Forms.TextBox();
            this.textBoxExtranjero = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNacionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtranjeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActuales
            // 
            this.dataGridViewActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActuales.Location = new System.Drawing.Point(184, 31);
            this.dataGridViewActuales.Name = "dataGridViewActuales";
            this.dataGridViewActuales.Size = new System.Drawing.Size(447, 150);
            this.dataGridViewActuales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos actuales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ventas nacionales";
            // 
            // dataGridViewNacionales
            // 
            this.dataGridViewNacionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNacionales.Location = new System.Drawing.Point(184, 200);
            this.dataGridViewNacionales.Name = "dataGridViewNacionales";
            this.dataGridViewNacionales.Size = new System.Drawing.Size(447, 150);
            this.dataGridViewNacionales.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ventas extranjero";
            // 
            // dataGridViewExtranjeros
            // 
            this.dataGridViewExtranjeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtranjeros.Location = new System.Drawing.Point(184, 372);
            this.dataGridViewExtranjeros.Name = "dataGridViewExtranjeros";
            this.dataGridViewExtranjeros.Size = new System.Drawing.Size(447, 150);
            this.dataGridViewExtranjeros.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de productos vendidos este año en el pais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(637, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad de productos vendidos el año pasado en el extranjero";
            // 
            // textBoxNacional
            // 
            this.textBoxNacional.Enabled = false;
            this.textBoxNacional.Location = new System.Drawing.Point(741, 88);
            this.textBoxNacional.Name = "textBoxNacional";
            this.textBoxNacional.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacional.TabIndex = 8;
            this.textBoxNacional.TextChanged += new System.EventHandler(this.textBoxNacional_TextChanged);
            // 
            // textBoxExtranjero
            // 
            this.textBoxExtranjero.Enabled = false;
            this.textBoxExtranjero.Location = new System.Drawing.Point(741, 226);
            this.textBoxExtranjero.Name = "textBoxExtranjero";
            this.textBoxExtranjero.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtranjero.TabIndex = 9;
            // 
            // EstadisticasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 534);
            this.Controls.Add(this.textBoxExtranjero);
            this.Controls.Add(this.textBoxNacional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewExtranjeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewNacionales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewActuales);
            this.Name = "EstadisticasProductos";
            this.Text = "EstadisticasProductos";
            this.Load += new System.EventHandler(this.EstadisticasProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNacionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtranjeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActuales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewNacionales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewExtranjeros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNacional;
        private System.Windows.Forms.TextBox textBoxExtranjero;
    }
}