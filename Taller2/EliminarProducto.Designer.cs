namespace Taller2
{
    partial class EliminarProducto
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
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonEliminarProducto = new System.Windows.Forms.Button();
            this.comboBoxEliminarProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(354, 52);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(395, 337);
            this.dataGridViewProducto.TabIndex = 0;
            this.dataGridViewProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducto_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BotonEliminarProducto
            // 
            this.BotonEliminarProducto.Location = new System.Drawing.Point(72, 328);
            this.BotonEliminarProducto.Name = "BotonEliminarProducto";
            this.BotonEliminarProducto.Size = new System.Drawing.Size(197, 44);
            this.BotonEliminarProducto.TabIndex = 2;
            this.BotonEliminarProducto.Text = "Eliminar";
            this.BotonEliminarProducto.UseVisualStyleBackColor = true;
            this.BotonEliminarProducto.Click += new System.EventHandler(this.BotonEliminarProducto_Click_1);
            // 
            // comboBoxEliminarProducto
            // 
            this.comboBoxEliminarProducto.FormattingEnabled = true;
            this.comboBoxEliminarProducto.Location = new System.Drawing.Point(72, 160);
            this.comboBoxEliminarProducto.Name = "comboBoxEliminarProducto";
            this.comboBoxEliminarProducto.Size = new System.Drawing.Size(197, 21);
            this.comboBoxEliminarProducto.TabIndex = 3;
            this.comboBoxEliminarProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxEliminarProducto_SelectedIndexChanged);
            // 
<<<<<<< Updated upstream
=======
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxEliminarProducto
            // 
            this.textBoxEliminarProducto.Location = new System.Drawing.Point(69, 261);
            this.textBoxEliminarProducto.Name = "textBoxEliminarProducto";
            this.textBoxEliminarProducto.Size = new System.Drawing.Size(200, 20);
            this.textBoxEliminarProducto.TabIndex = 7;
            this.textBoxEliminarProducto.TextChanged += new System.EventHandler(this.textBoxEliminarProducto_TextChanged);
            // 
>>>>>>> Stashed changes
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEliminarProducto);
            this.Controls.Add(this.BotonEliminarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProducto);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.Load += new System.EventHandler(this.EliminarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonEliminarProducto;
        private System.Windows.Forms.ComboBox comboBoxEliminarProducto;
    }
}