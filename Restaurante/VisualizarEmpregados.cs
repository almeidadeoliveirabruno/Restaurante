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
            dataGridView1.DataSource = null; // limpa a origem anterior
            dataGridView1.DataSource = (RepositorioEmpregado.Empregados);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
    }
}
