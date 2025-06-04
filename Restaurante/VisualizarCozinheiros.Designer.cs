namespace Restaurante
{
    partial class VisualizarCozinheiros
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
            this.components = new System.ComponentModel.Container();
            this.repositorioEmpregadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repositorioEmpregadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioEmpregadoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Cozinheiros = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.ComBoxCozinheiro = new System.Windows.Forms.ComboBox();
            this.llblRemoverCozinheiro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositorioEmpregadoBindingSource
            // 
            this.repositorioEmpregadoBindingSource.DataSource = typeof(Restaurante.Models.RepositorioCozinheiros);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(473, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 428);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // repositorioEmpregadoBindingSource1
            // 
            this.repositorioEmpregadoBindingSource1.DataSource = typeof(Restaurante.Models.RepositorioCozinheiros);
            // 
            // repositorioEmpregadoBindingSource2
            // 
            this.repositorioEmpregadoBindingSource2.DataSource = typeof(Restaurante.Models.RepositorioCozinheiros);
            // 
            // Cozinheiros
            // 
            this.Cozinheiros.AutoSize = true;
            this.Cozinheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cozinheiros.Location = new System.Drawing.Point(461, 78);
            this.Cozinheiros.Name = "Cozinheiros";
            this.Cozinheiros.Size = new System.Drawing.Size(355, 69);
            this.Cozinheiros.TabIndex = 19;
            this.Cozinheiros.Text = "Cozinheiros";
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(800, 821);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(936, 100);
            this.Cadastrar.TabIndex = 29;
            this.Cadastrar.Text = "Cadastrar Novos Cozinheiros";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.BackColor = System.Drawing.Color.Red;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(1670, 377);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(180, 75);
            this.btnRemover.TabIndex = 44;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // ComBoxCozinheiro
            // 
            this.ComBoxCozinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.ComBoxCozinheiro.FormattingEnabled = true;
            this.ComBoxCozinheiro.Location = new System.Drawing.Point(1467, 377);
            this.ComBoxCozinheiro.Name = "ComBoxCozinheiro";
            this.ComBoxCozinheiro.Size = new System.Drawing.Size(181, 50);
            this.ComBoxCozinheiro.Sorted = true;
            this.ComBoxCozinheiro.TabIndex = 43;
            // 
            // llblRemoverCozinheiro
            // 
            this.llblRemoverCozinheiro.AutoSize = true;
            this.llblRemoverCozinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.llblRemoverCozinheiro.Location = new System.Drawing.Point(1460, 289);
            this.llblRemoverCozinheiro.Name = "llblRemoverCozinheiro";
            this.llblRemoverCozinheiro.Size = new System.Drawing.Size(445, 42);
            this.llblRemoverCozinheiro.TabIndex = 42;
            this.llblRemoverCozinheiro.Text = "Remover Cozinheiro (Id)";
            // 
            // VisualizarCozinheiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.ComBoxCozinheiro);
            this.Controls.Add(this.llblRemoverCozinheiro);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Cozinheiros);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "VisualizarCozinheiros";
            this.Text = "VisualizarEmpregados";
            this.Load += new System.EventHandler(this.VisualizarEmpregados_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.Cozinheiros, 0);
            this.Controls.SetChildIndex(this.Cadastrar, 0);
            this.Controls.SetChildIndex(this.llblRemoverCozinheiro, 0);
            this.Controls.SetChildIndex(this.ComBoxCozinheiro, 0);
            this.Controls.SetChildIndex(this.btnRemover, 0);
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioEmpregadoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource repositorioEmpregadoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource repositorioEmpregadoBindingSource1;
        private System.Windows.Forms.BindingSource repositorioEmpregadoBindingSource2;
        private System.Windows.Forms.Label Cozinheiros;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ComboBox ComBoxCozinheiro;
        private System.Windows.Forms.Label llblRemoverCozinheiro;
    }
}