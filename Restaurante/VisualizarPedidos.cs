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
    public partial class VisualizarPedidos: Form
    {
        public VisualizarPedidos()
        {
            InitializeComponent();
        }

        private void VisualizarPedidos_Load(object sender, EventArgs e)
        {
            flowLayoutPedidos.Controls.Clear();
            foreach (var pedido in RepositorioBebidas.Bebidas)
            {
                var item = new BebidaPedidoControl(pedido.Nome, pedido.Preco, pedido.Id, pedido.CaminhoImagem);
                item.Margin = new Padding(13);
                //flowLayoutPanelBebidas.Controls.Add(item);
            }
        }
    }
}
