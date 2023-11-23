namespace Taller2
{
    partial class ListadoClientes
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
            this.dataGridViewNacionales = new System.Windows.Forms.DataGridView();
            this.dataGridViewExtranjeros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTodos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNacionales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtranjeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNacionales
            // 
            this.dataGridViewNacionales.AllowUserToAddRows = false;
            this.dataGridViewNacionales.AllowUserToDeleteRows = false;
            this.dataGridViewNacionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNacionales.Location = new System.Drawing.Point(290, 27);
            this.dataGridViewNacionales.Name = "dataGridViewNacionales";
            this.dataGridViewNacionales.ReadOnly = true;
            this.dataGridViewNacionales.Size = new System.Drawing.Size(520, 138);
            this.dataGridViewNacionales.TabIndex = 0;
            // 
            // dataGridViewExtranjeros
            // 
            this.dataGridViewExtranjeros.AllowUserToAddRows = false;
            this.dataGridViewExtranjeros.AllowUserToDeleteRows = false;
            this.dataGridViewExtranjeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExtranjeros.Location = new System.Drawing.Point(290, 204);
            this.dataGridViewExtranjeros.Name = "dataGridViewExtranjeros";
            this.dataGridViewExtranjeros.ReadOnly = true;
            this.dataGridViewExtranjeros.Size = new System.Drawing.Size(520, 141);
            this.dataGridViewExtranjeros.TabIndex = 1;
            // 
            // dataGridViewTodos
            // 
            this.dataGridViewTodos.AllowUserToAddRows = false;
            this.dataGridViewTodos.AllowUserToDeleteRows = false;
            this.dataGridViewTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodos.Location = new System.Drawing.Point(290, 382);
            this.dataGridViewTodos.Name = "dataGridViewTodos";
            this.dataGridViewTodos.ReadOnly = true;
            this.dataGridViewTodos.Size = new System.Drawing.Size(520, 136);
            this.dataGridViewTodos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clientes Nacionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clientes Extranjeros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Todos los clientes";
            // 
            // ListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTodos);
            this.Controls.Add(this.dataGridViewExtranjeros);
            this.Controls.Add(this.dataGridViewNacionales);
            this.Name = "ListadoClientes";
            this.Text = "ListadoClientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNacionales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExtranjeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNacionales;
        private System.Windows.Forms.DataGridView dataGridViewExtranjeros;
        private System.Windows.Forms.DataGridView dataGridViewTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}