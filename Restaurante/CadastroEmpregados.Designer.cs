namespace Restaurante
{
    partial class CadastroEmpregados
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
            this.VisualizarClientes = new System.Windows.Forms.Button();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.TelefoneInput = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.EnderecoInput = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CPFInput = new System.Windows.Forms.TextBox();
            this.NomeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FuncaoListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SalarioInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VisualizarClientes
            // 
            this.VisualizarClientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VisualizarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizarClientes.Location = new System.Drawing.Point(1601, 489);
            this.VisualizarClientes.Name = "VisualizarClientes";
            this.VisualizarClientes.Size = new System.Drawing.Size(350, 150);
            this.VisualizarClientes.TabIndex = 31;
            this.VisualizarClientes.Text = "Visualizar Funcionarios";
            this.VisualizarClientes.UseVisualStyleBackColor = false;
            this.VisualizarClientes.Click += new System.EventHandler(this.VisualizarClientes_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(1601, 237);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(350, 150);
            this.Cadastrar.TabIndex = 30;
            this.Cadastrar.Text = "Cadastrar ";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(913, 467);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(650, 75);
            this.EmailInput.TabIndex = 29;
            this.EmailInput.Enter += new System.EventHandler(this.Input_Enter);
            this.EmailInput.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(586, 473);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(181, 69);
            this.Email.TabIndex = 28;
            this.Email.Text = "Email";
            // 
            // TelefoneInput
            // 
            this.TelefoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneInput.Location = new System.Drawing.Point(916, 585);
            this.TelefoneInput.Name = "TelefoneInput";
            this.TelefoneInput.Size = new System.Drawing.Size(650, 75);
            this.TelefoneInput.TabIndex = 27;
            this.TelefoneInput.Enter += new System.EventHandler(this.Input_Enter);
            this.TelefoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamposNumericosApenas);
            this.TelefoneInput.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(586, 591);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(263, 69);
            this.Telefone.TabIndex = 26;
            this.Telefone.Text = "Telefone";
            // 
            // EnderecoInput
            // 
            this.EnderecoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoInput.Location = new System.Drawing.Point(916, 703);
            this.EnderecoInput.Name = "EnderecoInput";
            this.EnderecoInput.Size = new System.Drawing.Size(650, 75);
            this.EnderecoInput.TabIndex = 25;
            this.EnderecoInput.Enter += new System.EventHandler(this.Input_Enter);
            this.EnderecoInput.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(586, 709);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(285, 69);
            this.Endereco.TabIndex = 24;
            this.Endereco.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 69);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data de Nascimento";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(586, 355);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(150, 69);
            this.CPF.TabIndex = 22;
            this.CPF.Text = "CPF";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(586, 119);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(189, 69);
            this.Nome.TabIndex = 21;
            this.Nome.Text = "Nome";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1211, 237);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(349, 75);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // CPFInput
            // 
            this.CPFInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFInput.Location = new System.Drawing.Point(910, 349);
            this.CPFInput.Name = "CPFInput";
            this.CPFInput.Size = new System.Drawing.Size(650, 75);
            this.CPFInput.TabIndex = 19;
            this.CPFInput.Enter += new System.EventHandler(this.Input_Enter);
            this.CPFInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CamposNumericosApenas);
            this.CPFInput.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // NomeInput
            // 
            this.NomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInput.Location = new System.Drawing.Point(913, 113);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.Size = new System.Drawing.Size(650, 75);
            this.NomeInput.TabIndex = 18;
            this.NomeInput.Enter += new System.EventHandler(this.Input_Enter);
            this.NomeInput.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 95);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cadastro Funcionários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(586, 833);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 69);
            this.label3.TabIndex = 32;
            this.label3.Text = "Função";
            // 
            // FuncaoListBox
            // 
            this.FuncaoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncaoListBox.FormattingEnabled = true;
            this.FuncaoListBox.ItemHeight = 46;
            this.FuncaoListBox.Items.AddRange(new object[] {
            "Garçom",
            "Chef",
            "Cozinheiro",
            "Caixa",
            "Gerente"});
            this.FuncaoListBox.Location = new System.Drawing.Point(913, 852);
            this.FuncaoListBox.Name = "FuncaoListBox";
            this.FuncaoListBox.ScrollAlwaysVisible = true;
            this.FuncaoListBox.Size = new System.Drawing.Size(280, 50);
            this.FuncaoListBox.TabIndex = 33;
            this.FuncaoListBox.Enter += new System.EventHandler(this.Input_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1269, 827);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 69);
            this.label4.TabIndex = 34;
            this.label4.Text = "Salário";
            // 
            // SalarioInput
            // 
            this.SalarioInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioInput.Location = new System.Drawing.Point(1557, 821);
            this.SalarioInput.Name = "SalarioInput";
            this.SalarioInput.Size = new System.Drawing.Size(280, 75);
            this.SalarioInput.TabIndex = 35;
            this.SalarioInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SalarioInput.Enter += new System.EventHandler(this.Input_Enter);
            this.SalarioInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacaoDinheiro);
            this.SalarioInput.Leave += new System.EventHandler(this.Input_Leave);
            // 
            // CadastroEmpregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 1055);
            this.Controls.Add(this.SalarioInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FuncaoListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisualizarClientes);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.TelefoneInput);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.EnderecoInput);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CPFInput);
            this.Controls.Add(this.NomeInput);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroEmpregados";
            this.Text = "CadastroCozinheiro";
            this.Load += new System.EventHandler(this.CadastroCozinheiro_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.NomeInput, 0);
            this.Controls.SetChildIndex(this.CPFInput, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.Nome, 0);
            this.Controls.SetChildIndex(this.CPF, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Endereco, 0);
            this.Controls.SetChildIndex(this.EnderecoInput, 0);
            this.Controls.SetChildIndex(this.Telefone, 0);
            this.Controls.SetChildIndex(this.TelefoneInput, 0);
            this.Controls.SetChildIndex(this.Email, 0);
            this.Controls.SetChildIndex(this.EmailInput, 0);
            this.Controls.SetChildIndex(this.Cadastrar, 0);
            this.Controls.SetChildIndex(this.VisualizarClientes, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.FuncaoListBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.SalarioInput, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisualizarClientes;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox TelefoneInput;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox EnderecoInput;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CPFInput;
        private System.Windows.Forms.TextBox NomeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox FuncaoListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalarioInput;
    }
}