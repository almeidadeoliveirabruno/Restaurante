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
    public partial class CadastroEmpregados: FormBase
    {
        public CadastroEmpregados()
        {
            InitializeComponent();
        }

        private void CadastroCozinheiro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Focus
        private void Input_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = Color.LightYellow;
            }
        }
        private void Input_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BackColor = Color.White;
            }
        }

        #endregion

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
                //// Aqui você pode adicionar a lógica para cadastrar o cliente
                //var empregado = new Empregado(
                //    nome: NomeInput.Text,
                //    cpf: CPFInput.Text,
                //    telefone: TelefoneInput.Text,
                //    endereco: EnderecoInput.Text,
                //    email: EmailInput.Text,
                //    dataNascimento: dateTimePicker1.Value // ou outra data que você queira usar
                //);
                //RepositorioEmpregado.Adicionar(empregado);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                NomeInput.Clear();
                CPFInput.Clear();
                TelefoneInput.Clear();
                EnderecoInput.Clear();
                EmailInput.Clear();
            }
        }

        private void VisualizarClientes_Click(object sender, EventArgs e)
        {
            VisualizarEmpregados visualizarEmpregados = new VisualizarEmpregados();
            visualizarEmpregados.Show();
            if (!(this is Form1))
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
