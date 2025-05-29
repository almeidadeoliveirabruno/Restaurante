namespace Restaurante
{
    partial class CadastroItem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PrecoText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PrecotextBox = new System.Windows.Forms.TextBox();
            this.AlcoolcheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 95);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cadastro Itens";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(569, 155);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(197, 72);
            this.Nome.TabIndex = 19;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1429, 155);
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
            this.TipoComBox.Location = new System.Drawing.Point(1605, 148);
            this.TipoComBox.Name = "TipoComBox";
            this.TipoComBox.Size = new System.Drawing.Size(300, 79);
            this.TipoComBox.TabIndex = 21;
            this.TipoComBox.SelectedIndexChanged += new System.EventHandler(this.TipoComBox_SelectedIndexChanged);
            this.TipoComBox.Click += new System.EventHandler(this.TipoComBox_Click);
            this.TipoComBox.Leave += new System.EventHandler(this.TipoCombox_Validacao);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(772, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 79);
            this.textBox1.TabIndex = 22;
            // 
            // PrecoText
            // 
            this.PrecoText.AutoSize = true;
            this.PrecoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecoText.Location = new System.Drawing.Point(571, 306);
            this.PrecoText.Name = "PrecoText";
            this.PrecoText.Size = new System.Drawing.Size(195, 72);
            this.PrecoText.TabIndex = 23;
            this.PrecoText.Text = "Preço";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PrecotextBox
            // 
            this.PrecotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecotextBox.Location = new System.Drawing.Point(772, 299);
            this.PrecotextBox.Name = "PrecotextBox";
            this.PrecotextBox.Size = new System.Drawing.Size(320, 79);
            this.PrecotextBox.TabIndex = 24;
            // 
            // AlcoolcheckBox
            // 
            this.AlcoolcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlcoolcheckBox.Location = new System.Drawing.Point(1238, 301);
            this.AlcoolcheckBox.Name = "AlcoolcheckBox";
            this.AlcoolcheckBox.Size = new System.Drawing.Size(420, 75);
            this.AlcoolcheckBox.TabIndex = 25;
            this.AlcoolcheckBox.Text = "Álcool";
            this.AlcoolcheckBox.UseVisualStyleBackColor = true;
            this.AlcoolcheckBox.Visible = false;
            // 
            // label3
            // 
            this.label3.AccessibleName = "TempoEstimado";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1098, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 72);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tempo Estimado";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1605, 299);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 79);
            this.textBox2.TabIndex = 27;
            // 
            // CadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 1055);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AlcoolcheckBox);
            this.Controls.Add(this.PrecotextBox);
            this.Controls.Add(this.PrecoText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TipoComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroItem";
            this.Text = "CadastroPedido";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TipoComBox, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.PrecoText, 0);
            this.Controls.SetChildIndex(this.PrecotextBox, 0);
            this.Controls.SetChildIndex(this.AlcoolcheckBox, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipoComBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PrecoText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PrecotextBox;
        private System.Windows.Forms.CheckBox AlcoolcheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}