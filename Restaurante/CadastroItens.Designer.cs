namespace Restaurante
{
    partial class CadastroItens
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoComBox = new System.Windows.Forms.ComboBox();
            this.NomeInput = new System.Windows.Forms.TextBox();
            this.PrecoText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PrecoInput = new System.Windows.Forms.TextBox();
            this.AlcoolcheckBox = new System.Windows.Forms.CheckBox();
            this.TempoEstimadoText = new System.Windows.Forms.Label();
            this.TempoEstimadoInput = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSelecionarImagem = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 95);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastro Itens";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(453, 155);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(197, 72);
            this.Nome.TabIndex = 19;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1353, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 72);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo";
            // 
            // TipoComBox
            // 
            this.TipoComBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TipoComBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TipoComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoComBox.FormattingEnabled = true;
            this.TipoComBox.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.TipoComBox.Location = new System.Drawing.Point(1511, 148);
            this.TipoComBox.Name = "TipoComBox";
            this.TipoComBox.Size = new System.Drawing.Size(320, 79);
            this.TipoComBox.TabIndex = 21;
            this.TipoComBox.SelectedIndexChanged += new System.EventHandler(this.TipoComBox_SelectedIndexChanged);
            this.TipoComBox.Click += new System.EventHandler(this.TipoComBox_Click);
            this.TipoComBox.Leave += new System.EventHandler(this.TipoCombox_Validacao);
            // 
            // NomeInput
            // 
            this.NomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInput.Location = new System.Drawing.Point(675, 148);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.Size = new System.Drawing.Size(650, 79);
            this.NomeInput.TabIndex = 22;
            // 
            // PrecoText
            // 
            this.PrecoText.AutoSize = true;
            this.PrecoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoText.Location = new System.Drawing.Point(455, 306);
            this.PrecoText.Name = "PrecoText";
            this.PrecoText.Size = new System.Drawing.Size(195, 72);
            this.PrecoText.TabIndex = 23;
            this.PrecoText.Text = "Preço";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PrecoInput
            // 
            this.PrecoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoInput.Location = new System.Drawing.Point(675, 303);
            this.PrecoInput.Name = "PrecoInput";
            this.PrecoInput.Size = new System.Drawing.Size(270, 79);
            this.PrecoInput.TabIndex = 24;
            this.PrecoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DinheiroTextBox_KeyPress);
            // 
            // AlcoolcheckBox
            // 
            this.AlcoolcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoolcheckBox.Location = new System.Drawing.Point(469, 469);
            this.AlcoolcheckBox.Name = "AlcoolcheckBox";
            this.AlcoolcheckBox.Size = new System.Drawing.Size(420, 75);
            this.AlcoolcheckBox.TabIndex = 25;
            this.AlcoolcheckBox.Text = "Álcool";
            this.AlcoolcheckBox.UseVisualStyleBackColor = true;
            this.AlcoolcheckBox.Visible = false;
            // 
            // TempoEstimadoText
            // 
            this.TempoEstimadoText.AccessibleName = "TempoEstimado";
            this.TempoEstimadoText.AutoSize = true;
            this.TempoEstimadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoEstimadoText.Location = new System.Drawing.Point(453, 476);
            this.TempoEstimadoText.Name = "TempoEstimadoText";
            this.TempoEstimadoText.Size = new System.Drawing.Size(785, 72);
            this.TempoEstimadoText.TabIndex = 26;
            this.TempoEstimadoText.Text = "Tempo Estimado (minutos)";
            this.TempoEstimadoText.Visible = false;
            this.TempoEstimadoText.Click += new System.EventHandler(this.TempoEstimadoText_Click);
            // 
            // TempoEstimadoInput
            // 
            this.TempoEstimadoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempoEstimadoInput.Location = new System.Drawing.Point(1272, 469);
            this.TempoEstimadoInput.Name = "TempoEstimadoInput";
            this.TempoEstimadoInput.Size = new System.Drawing.Size(320, 79);
            this.TempoEstimadoInput.TabIndex = 27;
            this.TempoEstimadoInput.Visible = false;
            this.TempoEstimadoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TempoEstimadoInput_KeyPress);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(539, 823);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(350, 150);
            this.Cadastrar.TabIndex = 28;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1080, 821);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(350, 150);
            this.button6.TabIndex = 29;
            this.button6.Text = "Visualizar Itens";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.AccessibleName = "btnSelecionarImagem";
            this.btnSelecionarImagem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelecionarImagem.Location = new System.Drawing.Point(1626, 599);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(155, 155);
            this.btnSelecionarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSelecionarImagem.TabIndex = 30;
            this.btnSelecionarImagem.TabStop = false;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F);
            this.label3.Location = new System.Drawing.Point(453, 643);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1002, 71);
            this.label3.TabIndex = 31;
            this.label3.Text = "Selecione Uma Imagem 125x125px";
            // 
            // CadastroItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.TempoEstimadoInput);
            this.Controls.Add(this.TempoEstimadoText);
            this.Controls.Add(this.AlcoolcheckBox);
            this.Controls.Add(this.PrecoInput);
            this.Controls.Add(this.PrecoText);
            this.Controls.Add(this.NomeInput);
            this.Controls.Add(this.TipoComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroItens";
            this.Text = "CadastroPedido";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TipoComBox, 0);
            this.Controls.SetChildIndex(this.NomeInput, 0);
            this.Controls.SetChildIndex(this.PrecoText, 0);
            this.Controls.SetChildIndex(this.PrecoInput, 0);
            this.Controls.SetChildIndex(this.AlcoolcheckBox, 0);
            this.Controls.SetChildIndex(this.TempoEstimadoText, 0);
            this.Controls.SetChildIndex(this.TempoEstimadoInput, 0);
            this.Controls.SetChildIndex(this.Cadastrar, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.btnSelecionarImagem, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnSelecionarImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoComBox;
        private System.Windows.Forms.TextBox NomeInput;
        private System.Windows.Forms.Label PrecoText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PrecoInput;
        private System.Windows.Forms.CheckBox AlcoolcheckBox;
        private System.Windows.Forms.Label TempoEstimadoText;
        private System.Windows.Forms.TextBox TempoEstimadoInput;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox btnSelecionarImagem;
        private System.Windows.Forms.Label label3;
    }
}