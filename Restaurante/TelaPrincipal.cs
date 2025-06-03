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
    public partial class TelaPrincipal: Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void Iniciar_Click(object sender, EventArgs e)
        {
            var realizarPedidos = new RealizarPedido();
            realizarPedidos.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
