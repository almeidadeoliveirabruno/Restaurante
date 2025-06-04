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
    public partial class VisualizarEmpregados: FormBase
    {
        public VisualizarEmpregados()
        {
            InitializeComponent();
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = (RepositorioCliente.Clientes);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["CPF"].ReadOnly = true;
            dataGridView1.Columns["ClienteId"].DisplayIndex = 0;
            dataGridView1.Columns["Nome"].DisplayIndex = 1;
            dataGridView1.Columns["Cpf"].DisplayIndex = 2;
            dataGridView1.Columns["Telefone"].DisplayIndex = 3;
            dataGridView1.Columns["IdentificadorCombox"].Visible= false;
            dataGridView1.Columns["Endereco"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;
            string value = e.FormattedValue.ToString();

            //verifica se o valor é nulo ou vazio
            if (columnName == "Nome" && string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("O campo Nome não pode estar vazio.");
                e.Cancel = true;
            }

            //verifica se o CPF é válido
            if (columnName == "CPF")
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 11 || !value.All(char.IsDigit))
                {
                    MessageBox.Show("CPF inválido. Deve conter 11 dígitos numéricos.");
                    e.Cancel = true;
                }
                else if (RepositorioCliente.Clientes.Any(c => c.Cpf == value && c != (Cliente)dataGridView1.Rows[e.RowIndex].DataBoundItem))
                {
                    MessageBox.Show("CPF já existe para outro cliente.");
                    e.Cancel = true;
                }
            }

            //verifica se o email é válido
            if (columnName == "Email")
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                {
                    MessageBox.Show("Email inválido.");
                    e.Cancel = true;
                }
            }

            //verifica se o telefone é válido
            if (columnName == "Telefone")
            {
                if (value.Length < 10 || !value.All(char.IsDigit))
                {
                    MessageBox.Show("Telefone deve conter pelo menos 10 dígitos numéricos.");
                    e.Cancel = true;
                }
            }

            //verifica se o endereço é válido
            if (columnName == "Endereco" && string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Endereço não pode estar vazio.");
                e.Cancel = true;
            }

            //verifica se a data de nascimento é válida
            if (columnName == "DataNascimento") { 
                if (!DateTime.TryParse(value, out DateTime dataNascimento))
                {
                    e.Cancel = true;
                    MessageBox.Show("Data de nascimento inválida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dataNascimento > DateTime.Today)
                {
                    e.Cancel = true;
                    MessageBox.Show("A data de nascimento não pode ser no futuro.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastroClientes = new CadastroCliente();
            cadastroClientes.Show();
            this.Close();
        }

        private void MostrarClientes_Load(object sender, EventArgs e)
        {
            
            ComBoxCliente.DataSource = RepositorioCliente.Clientes;
            ComBoxCliente.DisplayMember = "ClienteId";  
            ComBoxCliente.ValueMember = "ClienteId";      
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (ComBoxCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente para remover.");
                return;
            }
            else if (ComBoxCliente.SelectedValue is int idCliente)
            {
                if (RepositorioCliente.Remover(idCliente))
                {
                    MessageBox.Show("Cliente removido com sucesso!");
                    return;
                }
                MessageBox.Show("Erro Cliente não encontrado.");
            }
        }
    }
}
