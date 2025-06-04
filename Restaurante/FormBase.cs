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
    public partial class FormBase: Form
    {
        public FormBase()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            VisualizarEmpregados mostrarClientes = new VisualizarEmpregados();
            mostrarClientes.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisualizarCozinheiros visualizarEmpregados = new VisualizarCozinheiros();
            visualizarEmpregados.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VisualizarItens visualizarPedido = new VisualizarItens();
            visualizarPedido.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisualizarMesa visualizarMesa = new VisualizarMesa();
            visualizarMesa.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RealizarPedido realizarPedido = new RealizarPedido();
            realizarPedido.Show();
            this.Close();
        }
    }
}
