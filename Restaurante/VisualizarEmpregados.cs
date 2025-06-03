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
    public partial class VisualizarEmpregados : FormBase
    {
        public VisualizarEmpregados()
        {
            InitializeComponent();
            dataGridView1.DataSource = null; // limpa a origem anterior
            dataGridView1.DataSource = (RepositorioCozinheiros.Cozinheiros);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["Cpf"].ReadOnly= true; 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns["Nome"].DisplayIndex = 1;


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            string novoValor = e.FormattedValue.ToString().Trim();

            switch (columnName)
            {
                case "Nome":  
                    if (string.IsNullOrWhiteSpace(novoValor))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Por favor, preencha o campo de nome.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case "Email":
                    if (!novoValor.Contains("@"))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Por favor, preencha o campo de email com um email válido.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case "Telefone":
                    if (novoValor.Length < 10 || !novoValor.All(char.IsDigit))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Por favor, preencha o campo de telefone com pelo menos 10 dígitos numéricos.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case "Salario":
                    if (!decimal.TryParse(novoValor, out decimal salario) || salario < 0)
                    {
                        e.Cancel = true;
                        MessageBox.Show("O campo Salário deve conter um número positivo válido.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case "DataNascimento":
                    if (!DateTime.TryParse(novoValor, out DateTime dataNascimento))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Data de nascimento inválida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dataNascimento > DateTime.Today)
                    {
                        e.Cancel = true;
                        MessageBox.Show("A data de nascimento não pode ser no futuro.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

            }
        }

        private void VisualizarEmpregados_Load(object sender, EventArgs e)
        {
            ComBoxCozinheiro.DataSource = RepositorioCozinheiros.Cozinheiros;
            ComBoxCozinheiro.DisplayMember = "CozinheiroID"; // O que aparece na ComboBox
            ComBoxCozinheiro.ValueMember = "IdCozinheiro"; // O valor associado ao item selecionado
        }
    }
}