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
    public partial class MostrarClientes: FormBase
    {
        public MostrarClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = null; // limpa a origem anterior
            dataGridView1.DataSource = (RepositorioCliente.Clientes);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns["Nome"].Width = 400;
            dataGridView1.Columns["CPF"].Width = 150;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
