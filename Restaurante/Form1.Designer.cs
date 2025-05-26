using Restaurante.Models;
using System;

namespace Restaurante
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeInput = new System.Windows.Forms.TextBox();
            this.CPFInput = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Endereco = new System.Windows.Forms.Label();
            this.EnderecoInput = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.TelefoneInput = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.EmailInput = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioClienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.repositorioClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Cliente";
            // 
            // NomeInput
            // 
            this.NomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInput.Location = new System.Drawing.Point(586, 156);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.Size = new System.Drawing.Size(387, 45);
            this.NomeInput.TabIndex = 1;
            this.NomeInput.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            this.NomeInput.Enter += new System.EventHandler(this.NomeInput_Enter);
            this.NomeInput.Leave += new System.EventHandler(this.NomeInput_Leave_1);
            // 
            // CPFInput
            // 
            this.CPFInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFInput.Location = new System.Drawing.Point(586, 234);
            this.CPFInput.Name = "CPFInput";
            this.CPFInput.Size = new System.Drawing.Size(387, 45);
            this.CPFInput.TabIndex = 2;
            this.CPFInput.TextChanged += new System.EventHandler(this.CPF_TextChanged);
            this.CPFInput.Enter += new System.EventHandler(this.CPFInput_Enter);
            this.CPFInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.CPFInput.Leave += new System.EventHandler(this.CPFInput_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1424, 156);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 41);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(402, 156);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(97, 36);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(402, 234);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(77, 36);
            this.CPF.TabIndex = 5;
            this.CPF.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1055, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Nascimento";
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(402, 305);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(151, 36);
            this.Endereco.TabIndex = 7;
            this.Endereco.Text = "Endereço";
            this.Endereco.Click += new System.EventHandler(this.label3_Click);
            // 
            // EnderecoInput
            // 
            this.EnderecoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoInput.Location = new System.Drawing.Point(586, 305);
            this.EnderecoInput.Multiline = true;
            this.EnderecoInput.Name = "EnderecoInput";
            this.EnderecoInput.Size = new System.Drawing.Size(387, 179);
            this.EnderecoInput.TabIndex = 8;
            this.EnderecoInput.Enter += new System.EventHandler(this.EnderecoInput_Enter);
            this.EnderecoInput.Leave += new System.EventHandler(this.EnderecoInput_Leave);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(1055, 230);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(138, 36);
            this.Telefone.TabIndex = 9;
            this.Telefone.Text = "Telefone";
            // 
            // TelefoneInput
            // 
            this.TelefoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneInput.Location = new System.Drawing.Point(1246, 230);
            this.TelefoneInput.Name = "TelefoneInput";
            this.TelefoneInput.Size = new System.Drawing.Size(387, 45);
            this.TelefoneInput.TabIndex = 10;
            this.TelefoneInput.Enter += new System.EventHandler(this.TelefoneInput_Enter);
            this.TelefoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.TelefoneInput.Leave += new System.EventHandler(this.TelefoneInput_Leave);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(1055, 310);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(93, 36);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(1246, 310);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(387, 45);
            this.EmailInput.TabIndex = 12;
            this.EmailInput.Enter += new System.EventHandler(this.EmailInput_Enter);
            this.EmailInput.Leave += new System.EventHandler(this.EmailInput_Leave);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(1061, 419);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(225, 65);
            this.Cadastrar.TabIndex = 13;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 127);
            this.dataGridView1.TabIndex = 14;
            // 
            // repositorioClienteBindingSource3
            // 
            this.repositorioClienteBindingSource3.DataSource = typeof(Restaurante.Models.RepositorioCliente);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Restaurante.Models.Cliente);
            // 
            // repositorioClienteBindingSource
            // 
            this.repositorioClienteBindingSource.DataSource = typeof(Restaurante.Models.RepositorioCliente);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 608);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeInput;
        private System.Windows.Forms.TextBox CPFInput;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Endereco;
        private System.Windows.Forms.TextBox EnderecoInput;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.TextBox TelefoneInput;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailInput;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.BindingSource repositorioClienteBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource repositorioClienteBindingSource1;
        private System.Windows.Forms.BindingSource repositorioClienteBindingSource2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource repositorioClienteBindingSource3;
    }
}

