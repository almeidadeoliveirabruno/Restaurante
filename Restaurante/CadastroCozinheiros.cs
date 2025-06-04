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
    public partial class CadastroCozinheiros: FormBase
    {
        public CadastroCozinheiros()
        {
            InitializeComponent();
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

            else if (RepositorioCozinheiros.VerificaSeFuncionarioExiste(CPFInput.Text))
            {
                MessageBox.Show("O cpf já existe.");
                CPFInput.Focus();
            } 
            else
            {
                try
                {
                     Decimal.Parse(SalarioInput.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("O campo Salário deve conter apenas números.");
                    SalarioInput.Focus();
                    return;
                }
                RepositorioCozinheiros.Adicionar(new Cozinheiro(
                    nome: NomeInput.Text,
                    cpf: CPFInput.Text,
                    telefone: TelefoneInput.Text,
                    endereco: EnderecoInput.Text,
                    datanascimento: DateTime.Now,
                    email: EmailInput.Text,
                    salario: Decimal.Parse(SalarioInput.Text)
                ));
                MessageBox.Show("Empregado cadastrado com sucesso!");
                NomeInput.Clear();
                CPFInput.Clear();
                TelefoneInput.Clear();
                EnderecoInput.Clear();
                EmailInput.Clear();
                SalarioInput.Clear();
            }
        }

        private void VisualizarClientes_Click(object sender, EventArgs e)
        {
            VisualizarCozinheiros visualizarEmpregados = new VisualizarCozinheiros();
            visualizarEmpregados.Show();
            this.Close();
        }

       

        private void ValidacaoDinheiro(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite apenas números, vírgula e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Evita múltiplas vírgulas
            if (e.KeyChar == ',' && txt.Text.Contains(","))
            {
                e.Handled = true;
            }
        }
    }
}
