namespace Restaurante
{
    partial class VisualizarItens
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
            this.Cadastrar = new System.Windows.Forms.Button();
            this.dataGridBebidas = new System.Windows.Forms.DataGridView();
            this.dataGridCellValidating = new System.Windows.Forms.DataGridView();
            this.Bebidas = new System.Windows.Forms.Label();
            this.Comidas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxBebida = new System.Windows.Forms.ComboBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBoxComida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCellValidating)).BeginInit();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(1497, 840);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(350, 150);
            this.Cadastrar.TabIndex = 31;
            this.Cadastrar.Text = "Cadastrar ";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // dataGridBebidas
            // 
            this.dataGridBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridBebidas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridBebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBebidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridBebidas.Location = new System.Drawing.Point(431, 138);
            this.dataGridBebidas.Name = "dataGridBebidas";
            this.dataGridBebidas.RowHeadersWidth = 51;
            this.dataGridBebidas.RowTemplate.Height = 24;
            this.dataGridBebidas.Size = new System.Drawing.Size(1000, 200);
            this.dataGridBebidas.TabIndex = 32;
            this.dataGridBebidas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Bebidas_CellValidating);
            // 
            // dataGridCellValidating
            // 
            this.dataGridCellValidating.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridCellValidating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCellValidating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCellValidating.Location = new System.Drawing.Point(414, 616);
            this.dataGridCellValidating.Name = "dataGridCellValidating";
            this.dataGridCellValidating.RowHeadersWidth = 51;
            this.dataGridCellValidating.Size = new System.Drawing.Size(1000, 200);
            this.dataGridCellValidating.TabIndex = 33;
            this.dataGridCellValidating.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridComida_CellValidating);
            // 
            // Bebidas
            // 
            this.Bebidas.AutoSize = true;
            this.Bebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bebidas.Location = new System.Drawing.Point(419, 73);
            this.Bebidas.Name = "Bebidas";
            this.Bebidas.Size = new System.Drawing.Size(252, 69);
            this.Bebidas.TabIndex = 34;
            this.Bebidas.Text = "Bebidas";
            // 
            // Comidas
            // 
            this.Comidas.AutoSize = true;
            this.Comidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comidas.Location = new System.Drawing.Point(423, 535);
            this.Comidas.Name = "Comidas";
            this.Comidas.Size = new System.Drawing.Size(272, 69);
            this.Comidas.TabIndex = 35;
            this.Comidas.Text = "Comidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1425, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "Remover Bebida (Id)";
            // 
            // comBoxBebida
            // 
            this.comBoxBebida.FormattingEnabled = true;
            this.comBoxBebida.Location = new System.Drawing.Point(1437, 207);
            this.comBoxBebida.Name = "comBoxBebida";
            this.comBoxBebida.Size = new System.Drawing.Size(181, 24);
            this.comBoxBebida.Sorted = true;
            this.comBoxBebida.TabIndex = 37;
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(1629, 188);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(200, 60);
            this.btnRemover.TabIndex = 38;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnBebidaRemover_Click);
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1633, 666);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 60);
            this.button6.TabIndex = 41;
            this.button6.Text = "Remover";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnComidaRemover_Click);
            // 
            // comboBoxComida
            // 
            this.comboBoxComida.FormattingEnabled = true;
            this.comboBoxComida.Location = new System.Drawing.Point(1441, 685);
            this.comboBoxComida.Name = "comboBoxComida";
            this.comboBoxComida.Size = new System.Drawing.Size(181, 24);
            this.comboBoxComida.Sorted = true;
            this.comboBoxComida.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1429, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "Remover Comida (Id)";
            // 
            // VisualizarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBoxComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.comBoxBebida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comidas);
            this.Controls.Add(this.Bebidas);
            this.Controls.Add(this.dataGridCellValidating);
            this.Controls.Add(this.dataGridBebidas);
            this.Controls.Add(this.Cadastrar);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VisualizarItens";
            this.Text = "VisualizarItens";
            this.Controls.SetChildIndex(this.Cadastrar, 0);
            this.Controls.SetChildIndex(this.dataGridBebidas, 0);
            this.Controls.SetChildIndex(this.dataGridCellValidating, 0);
            this.Controls.SetChildIndex(this.Bebidas, 0);
            this.Controls.SetChildIndex(this.Comidas, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.comBoxBebida, 0);
            this.Controls.SetChildIndex(this.btnRemover, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBoxComida, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCellValidating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.DataGridView dataGridBebidas;
        private System.Windows.Forms.DataGridView dataGridCellValidating;
        private System.Windows.Forms.Label Bebidas;
        private System.Windows.Forms.Label Comidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxBebida;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBoxComida;
        private System.Windows.Forms.Label label2;
    }
}