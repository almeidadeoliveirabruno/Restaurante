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
            FuncaoListBox.Items.Add("Cozinheiro");
            FuncaoListBox.Items.Add("Garçom");
            FuncaoListBox.Items.Add("Gerente");
            FuncaoListBox.SelectedIndex = 0; // Seleciona o primeiro item
        }

        private void CadastroCozinheiro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CamposNumericosApenas(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox texbox)
            {
                // Permite apenas números e o caractere de controle (Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Impede a entrada de caracteres inválidos
                }
            }
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

            else if (RepositorioEmpregado.VerificaSeFuncionarioExiste(CPFInput.Text))
            {
                MessageBox.Show("O cpf já existe.");
                CPFInput.Focus();
            }
            else
            {
                RepositorioEmpregado.Adicionar(new Empregado(
                    nome: NomeInput.Text,
                    cpf: CPFInput.Text,
                    telefone: TelefoneInput.Text,
                    endereco: EnderecoInput.Text,
                    datanascimento: DateTime.Now, 
                    especialidade: FuncaoListBox.SelectedItem?.ToString() ?? "Não especificado",
                    email: EmailInput.Text
                ));
                MessageBox.Show("Empregado cadastrado com sucesso!");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CPFInput_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
