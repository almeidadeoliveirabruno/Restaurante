﻿using Restaurante.Models;
using System;

namespace Restaurante
{
    partial class CadastroCliente
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VisualizarClientes = new System.Windows.Forms.Button();
            this.repositorioClienteBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositorioClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // NomeInput
            // 
            this.NomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeInput.Location = new System.Drawing.Point(961, 107);
            this.NomeInput.Name = "NomeInput";
            this.NomeInput.Size = new System.Drawing.Size(888, 75);
            this.NomeInput.TabIndex = 1;
            this.NomeInput.Enter += new System.EventHandler(this.NomeInput_Enter);
            this.NomeInput.Leave += new System.EventHandler(this.NomeInput_Leave_1);
            // 
            // CPFInput
            // 
            this.CPFInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFInput.Location = new System.Drawing.Point(958, 343);
            this.CPFInput.Name = "CPFInput";
            this.CPFInput.Size = new System.Drawing.Size(891, 75);
            this.CPFInput.TabIndex = 2;
            this.CPFInput.Enter += new System.EventHandler(this.CPFInput_Enter);
            this.CPFInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.CPFInput.Leave += new System.EventHandler(this.CPFInput_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1503, 227);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(349, 75);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(634, 113);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(189, 69);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(634, 349);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(150, 69);
            this.CPF.TabIndex = 5;
            this.CPF.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(570, 69);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de Nascimento";
            // 
            // Endereco
            // 
            this.Endereco.AutoSize = true;
            this.Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endereco.Location = new System.Drawing.Point(634, 703);
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(285, 69);
            this.Endereco.TabIndex = 7;
            this.Endereco.Text = "Endereço";
            // 
            // EnderecoInput
            // 
            this.EnderecoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnderecoInput.Location = new System.Drawing.Point(964, 697);
            this.EnderecoInput.Name = "EnderecoInput";
            this.EnderecoInput.Size = new System.Drawing.Size(891, 75);
            this.EnderecoInput.TabIndex = 8;
            this.EnderecoInput.Enter += new System.EventHandler(this.EnderecoInput_Enter);
            this.EnderecoInput.Leave += new System.EventHandler(this.EnderecoInput_Leave);
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(634, 585);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(263, 69);
            this.Telefone.TabIndex = 9;
            this.Telefone.Text = "Telefone";
            // 
            // TelefoneInput
            // 
            this.TelefoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneInput.Location = new System.Drawing.Point(964, 579);
            this.TelefoneInput.Name = "TelefoneInput";
            this.TelefoneInput.Size = new System.Drawing.Size(888, 75);
            this.TelefoneInput.TabIndex = 10;
            this.TelefoneInput.Enter += new System.EventHandler(this.TelefoneInput_Enter);
            this.TelefoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.TelefoneInput.Leave += new System.EventHandler(this.TelefoneInput_Leave);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(634, 467);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(181, 69);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(961, 461);
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.Size = new System.Drawing.Size(888, 75);
            this.EmailInput.TabIndex = 12;
            this.EmailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            this.EmailInput.Enter += new System.EventHandler(this.EmailInput_Enter);
            this.EmailInput.Leave += new System.EventHandler(this.EmailInput_Leave);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(1499, 811);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(350, 150);
            this.Cadastrar.TabIndex = 13;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = false;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(3, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(395, 140);
            this.button5.TabIndex = 21;
            this.button5.Text = "Pedidos";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(3, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(395, 140);
            this.button4.TabIndex = 20;
            this.button4.Text = "Itens";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 817);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(395, 140);
            this.button3.TabIndex = 19;
            this.button3.Text = "Mesas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 140);
            this.button2.TabIndex = 18;
            this.button2.Text = "Garçons";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 140);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // VisualizarClientes
            // 
            this.VisualizarClientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VisualizarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisualizarClientes.Location = new System.Drawing.Point(629, 811);
            this.VisualizarClientes.Name = "VisualizarClientes";
            this.VisualizarClientes.Size = new System.Drawing.Size(350, 150);
            this.VisualizarClientes.TabIndex = 16;
            this.VisualizarClientes.Text = "Visualizar Clientes";
            this.VisualizarClientes.UseVisualStyleBackColor = false;
            this.VisualizarClientes.Click += new System.EventHandler(this.VisualizarClientes_Click);
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
            this.ClientSize = new System.Drawing.Size(1909, 1019);
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
            this.Name = "Form1";
            this.Text = "8";
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
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorioClienteBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource repositorioClienteBindingSource3;
        private System.Windows.Forms.Button VisualizarClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

