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
            MostrarClientes mostrarClientes = new MostrarClientes();
            mostrarClientes.Show();
            if (!(this is TelaPrincipal))
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroEmpregados cadastroCozinheiro = new CadastroEmpregados();
            cadastroCozinheiro.Show();
            if (!(this is TelaPrincipal))
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastroItem cadastroPedido = new CadastroItem();
            cadastroPedido.Show();
            if (!(this is TelaPrincipal))
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VisualizarMesa visualizarMesa = new VisualizarMesa();
            visualizarMesa.Show();
            if (!(this is TelaPrincipal))
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
