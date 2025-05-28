using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var clienteTeste = new Cliente(
            nome: "Maria Oliveira Teixeira Paula",
            cpf: "98765432100",
            telefone: "21988887777",
            endereco: "Rua das Flores, 456, Rio De Janeiro, Brasil, Volta Redonda, Qualquer coisa",
            email: "maria@teste.com",
            dataNascimento: new DateTime(1985, 3, 10)
        );

            RepositorioCliente.Adicionar(clienteTeste);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeInput.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de nome.");
                NomeInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(CPFInput.Text) || CPFInput.Text.Length != 11)
            {
                MessageBox.Show("Por favor, preencha o campo de CPF com 11 dígitos.");
                CPFInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(EmailInput.Text) || !EmailInput.Text.Contains("@"))
            {
                MessageBox.Show("Por favor, preencha o campo de email com um email válido.");
                EmailInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(TelefoneInput.Text) || TelefoneInput.Text.Length < 10)
            {
                MessageBox.Show("Por favor, preencha o campo de telefone com pelo menos 10 dígitos.");
                TelefoneInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(EnderecoInput.Text))
            {
                MessageBox.Show("Por favor, preencha o campo de endereço.");
                EnderecoInput.Focus();
            }
           
            else if (RepositorioCliente.VerificaSeClienteExiste(CPFInput.Text))
            {
                MessageBox.Show("O cpf já exista.");
                CPFInput.Focus();
            }
            else
            {
                // Aqui você pode adicionar a lógica para cadastrar o cliente
                var cliente = new Cliente(
                    nome: NomeInput.Text,
                    cpf: CPFInput.Text,
                    telefone: TelefoneInput.Text,
                    endereco: EnderecoInput.Text,
                    email: EmailInput.Text,
                    dataNascimento: dateTimePicker1.Value // ou outra data que você queira usar
                );
                RepositorioCliente.Adicionar(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                NomeInput.Clear();
                CPFInput.Clear();
                TelefoneInput.Clear();
                EnderecoInput.Clear();
                EmailInput.Clear();
            }
        }

        #region Destaque Inputs
        private void NomeInput_Enter(object sender, EventArgs e)
        {
            NomeInput.BackColor = Color.LightYellow;
        }
        private void NomeInput_Leave_1(object sender, EventArgs e)
        {
            NomeInput.BackColor = Color.White;
        }
        private void CPFInput_Enter(object sender, EventArgs e)
        {
            CPFInput.BackColor = Color.LightYellow;
        }
        private void CPFInput_Leave(object sender, EventArgs e)
        {
            CPFInput.BackColor = Color.White;
        }
        private void TelefoneInput_Enter(object sender, EventArgs e)
        {
            TelefoneInput.BackColor = Color.LightYellow;
        }
        private void TelefoneInput_Leave(object sender, EventArgs e)
        {
            TelefoneInput.BackColor = Color.White;
        }
        private void EnderecoInput_Enter(object sender, EventArgs e)
        {
            EnderecoInput.BackColor = Color.LightYellow;
        }
        private void EnderecoInput_Leave(object sender, EventArgs e)
        {
            EnderecoInput.BackColor = Color.White;
        }
        private void EmailInput_Enter(object sender, EventArgs e)
        {
            EmailInput.BackColor = Color.LightYellow;
        }
        private void EmailInput_Leave(object sender, EventArgs e)
        {
            EmailInput.BackColor = Color.White;
        }
        #endregion



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VisualizarClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes mostrarClientes = new MostrarClientes();
            mostrarClientes.Show(); // abre o form como janela independente
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nome.Text = "Teste";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void button2_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
