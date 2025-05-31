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
    public partial class CadastroItem: FormBase
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void TipoCombox_Validacao(object sender, EventArgs e)
        {
            if (!TipoComBox.Items.Contains(TipoComBox.Text))
            {
                MessageBox.Show("Escolha uma opção válida da lista!");
                TipoComBox.Text = string.Empty;
                TipoComBox.Focus();
            }
        }
        private void TipoComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoComBox.Text == "Bebida")
            {
                AlcoolcheckBox.Visible = true;
                TempoEstimadoInput.Visible = false;
                TempoEstimadoText.Visible = false;
            }
            else if (TipoComBox.Text == "Comida")
            {
                AlcoolcheckBox.Visible = false;
                TempoEstimadoText.Visible = true;
                TempoEstimadoInput.Visible = true;
            }
            else
            {
                AlcoolcheckBox.Visible = false;
                TempoEstimadoText.Visible = false;
                TempoEstimadoInput.Visible = false;
            }
        }

        private void TipoComBox_Click(object sender, EventArgs e)
        {
           
        }

        private void DinheiroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Permite apenas números, vírgula e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

            // Evita múltiplas vírgulas
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        
    }

        private void TempoEstimadoText_Click(object sender, EventArgs e)
        {

        }

        private void TempoEstimadoInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox texbox)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Impede a entrada de caracteres inválidos
                }
            }
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomeInput.Text)) { 
                MessageBox.Show("Preencha o campo Nome.");
                NomeInput.Focus();
            } else if (string.IsNullOrWhiteSpace(PrecoInput.Text))
            {
                MessageBox.Show("Preencha o campo Preço.");
                PrecoInput.Focus();
            }
            else if (string.IsNullOrWhiteSpace(TipoComBox.Text))
            {
                MessageBox.Show("Selecione um tipo de item.");
                TipoComBox.Focus();
            }
            else if (TipoComBox.Text == "Comida" && string.IsNullOrWhiteSpace(TempoEstimadoInput.Text))
            {
                MessageBox.Show("Preencha o campo Tempo Estimado.");
                TempoEstimadoInput.Focus();
            } 
            else
            {
                try {
                    decimal valor = Decimal.Parse(PrecoInput.Text) ;
                }
                catch (FormatException)
                {
                    MessageBox.Show("O campo Preço deve conter apenas números.");
                    PrecoInput.Focus();
                    return;
                }


                if (TipoComBox.Text == "Bebida"){
                    if (RepositorioBebidas.VerificarseExiste(NomeInput.Text))
                    {
                        MessageBox.Show("Já existe uma bebida com esse nome.");
                        NomeInput.Focus();
                        return;
                    }
                    RepositorioBebidas.AdicionarBebida(new Bebidas(
                        NomeInput.Text,
                        Decimal.Parse(PrecoInput.Text),
                        AlcoolcheckBox.Checked
                    ));
                    MessageBox.Show("Item cadastrado com sucesso!");
                    NomeInput.Clear();
                    PrecoInput.Clear();
                    TempoEstimadoInput.Clear();
                }

                else if (TipoComBox.Text == "Comida")
                {
                    if (RepositorioPratos.VerificarSeExiste(NomeInput.Text))
                    {
                        MessageBox.Show("Já existe uma comida com esse nome.");
                        NomeInput.Focus();
                        return;
                    }
                    RepositorioPratos.AdicionarPrato(new Pratos(
                        NomeInput.Text,
                        Decimal.Parse(PrecoInput.Text),
                        int.Parse(TempoEstimadoInput.Text)
                    ));
                    MessageBox.Show("Item cadastrado com sucesso!");
                    NomeInput.Clear();
                    PrecoInput.Clear();
                    TempoEstimadoInput.Clear();
                }
                else
                {
                    MessageBox.Show("Tipo de item inválido.");
                }
                if (TipoComBox.Text == "Comida")
                {
                    
                }
            }

        }
    }
}
