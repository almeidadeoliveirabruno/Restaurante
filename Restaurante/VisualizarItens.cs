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
    public partial class VisualizarItens : FormBase
    {
        public VisualizarItens()
        {
            InitializeComponent();
            CarregarItens();
        }

        private void CarregarItens()
        {
            dataGridBebidas.DataSource = null;
            dataGridBebidas.DataSource = (RepositorioBebidas.Bebidas);
            dataGridBebidas.ReadOnly = false;
            dataGridBebidas.Columns["Id"].DisplayIndex = 0;
            dataGridBebidas.Columns["Quantidade"].Visible = false;
            dataGridBebidas.Columns["CaminhoImagem"].Visible = false;
            dataGridBebidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridBebidas.Columns["Id"].ReadOnly = true;



            dataGridCellValidating.ReadOnly = false;
            dataGridCellValidating.DataSource = null;
            dataGridCellValidating.DataSource = (RepositorioPratos.Pratos);
            dataGridCellValidating.Columns["Quantidade"].Visible = true;
            dataGridCellValidating.Columns["CaminhoImagem"].Visible = false;
            dataGridCellValidating.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCellValidating.Columns["Id"].ReadOnly = true;
            dataGridCellValidating.Columns["Quantidade"].Visible = false;


            comBoxBebida.DataSource = RepositorioBebidas.Bebidas;
            comBoxBebida.DisplayMember = "Id";  // O que aparece na ComboBox
            comBoxBebida.ValueMember = "Id";      // O valor associado ao item selecionado

            comboBoxComida.DataSource = RepositorioPratos.Pratos;
            comboBoxComida.DisplayMember = "Id";  // O que aparece na ComboBox
            comboBoxComida.ValueMember = "Id";      // O valor associado ao item selecionado
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroItens cadastroItem = new CadastroItens();
            cadastroItem.Show();
            this.Close();
        }
        private void Bebidas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var columnName = dataGridBebidas.Columns[e.ColumnIndex].Name;

            if (columnName == "Nome")
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("O nome da bebida não pode estar vazio.");
                    e.Cancel = true;
                }
            }
            else if (columnName == "Preco")
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal preco) || preco <= 0)
                {
                    MessageBox.Show("O preço da bebida deve ser um número maior que zero.");
                    e.Cancel = true;
                }
            }
        }

        private void DataGridComida_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var columnName = dataGridCellValidating.Columns[e.ColumnIndex].Name;

            if (columnName == "Nome")
            {
                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("O nome do prato não pode estar vazio.");
                    e.Cancel = true;
                }
            }
            else if (columnName == "Preco")
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal preco) || preco <= 0)
                {
                    MessageBox.Show("O preço do prato deve ser um número maior que zero.");
                    e.Cancel = true;
                }
            }
            else if (columnName == "TempoPreparo")
            {
                if (!TimeSpan.TryParse(e.FormattedValue.ToString(), out TimeSpan tempo) || tempo.TotalMinutes <= 0)
                {
                    MessageBox.Show("O tempo de preparo deve ser um valor no formato hh:mm:ss e maior que zero.");
                    e.Cancel = true;
                }
            }
        }

        private void btnBebidaRemover_Click(object sender, EventArgs e)
        {
            if (comBoxBebida.SelectedValue == null)
            {
                MessageBox.Show("Selecione uma bebida para remover.");
                return;
            }
            else if (comBoxBebida.SelectedValue is int idBebida)
            {
                if (RepositorioBebidas.RemoverBebida(idBebida))
                {
                    MessageBox.Show("Bebida removida com sucesso!");
                    CarregarItens();
                    return;
                }
                MessageBox.Show("Erro Pedido não encontrado.");
            }
        }

        private void btnComidaRemover_Click(object sender, EventArgs e)
        {
            if (comboBoxComida.SelectedValue == null)
            {
                MessageBox.Show("Selecione um prato para remover.");
                return;
            }
            else if (comboBoxComida.SelectedValue is int idPrato)
            {
                if (RepositorioPratos.RemoverPrato(idPrato))
                {
                    MessageBox.Show("Prato removido com sucesso!");
                    CarregarItens();
                }
                else
                {
                    MessageBox.Show("Erro ao remover o prato.Prato não encontrado.");
                }
            }
        }
    }
}
