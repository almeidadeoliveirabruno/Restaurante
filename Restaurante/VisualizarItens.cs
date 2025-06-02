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
    public partial class VisualizarItens: FormBase
    {
        public VisualizarItens()
        {
            InitializeComponent();
            dataGridView1.DataSource = null; // limpa a origem anterior
            dataGridView1.DataSource = (RepositorioBebidas.Bebidas);
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["Quantidade"].Visible = false;
            dataGridView1.Columns["CaminhoImagem"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView2.ReadOnly = true;
            dataGridView2.DataSource = null; // limpa a origem anterior
            dataGridView2.DataSource = (RepositorioPratos.Pratos);
            dataGridView2.Columns["Quantidade"].Visible = true;
            dataGridView2.Columns["CaminhoImagem"].Visible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroItens cadastroItem = new CadastroItens();
            cadastroItem.Show();
            this.Close();
        }


    }
}
