namespace Restaurante
{
    partial class MostrarClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.ComBoxCliente = new System.Windows.Forms.ComboBox();
            this.llblRemoverCliente = new System.Windows.Forms.Label();
            this.Cozinheiros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 428);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(797, 861);
            this.Cadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(936, 100);
            this.Cadastrar.TabIndex = 16;
            this.Cadastrar.Text = "Cadastrar Novos Clientes";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(1553, 393);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(180, 75);
            this.btnRemover.TabIndex = 41;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // ComBoxCliente
            // 
            this.ComBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ComBoxCliente.FormattingEnabled = true;
            this.ComBoxCliente.Location = new System.Drawing.Point(1366, 406);
            this.ComBoxCliente.Name = "ComBoxCliente";
            this.ComBoxCliente.Size = new System.Drawing.Size(181, 50);
            this.ComBoxCliente.Sorted = true;
            this.ComBoxCliente.TabIndex = 40;
            // 
            // llblRemoverCliente
            // 
            this.llblRemoverCliente.AutoSize = true;
            this.llblRemoverCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.llblRemoverCliente.Location = new System.Drawing.Point(1354, 316);
            this.llblRemoverCliente.Name = "llblRemoverCliente";
            this.llblRemoverCliente.Size = new System.Drawing.Size(379, 42);
            this.llblRemoverCliente.TabIndex = 39;
            this.llblRemoverCliente.Text = "Remover Cliente (Id)";
            // 
            // Cozinheiros
            // 
            this.Cozinheiros.AutoSize = true;
            this.Cozinheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cozinheiros.Location = new System.Drawing.Point(456, 40);
            this.Cozinheiros.Name = "Cozinheiros";
            this.Cozinheiros.Size = new System.Drawing.Size(253, 69);
            this.Cozinheiros.TabIndex = 42;
            this.Cozinheiros.Text = "Clientes";
            // 
            // MostrarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.Cozinheiros);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.ComBoxCliente);
            this.Controls.Add(this.llblRemoverCliente);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MostrarClientes";
            this.Text = "MostrarClientes";
            this.Load += new System.EventHandler(this.MostrarClientes_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.Cadastrar, 0);
            this.Controls.SetChildIndex(this.llblRemoverCliente, 0);
            this.Controls.SetChildIndex(this.ComBoxCliente, 0);
            this.Controls.SetChildIndex(this.btnRemover, 0);
            this.Controls.SetChildIndex(this.Cozinheiros, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox ComBoxCliente;
        private System.Windows.Forms.Label llblRemoverCliente;
        private System.Windows.Forms.Label Cozinheiros;
    }
}