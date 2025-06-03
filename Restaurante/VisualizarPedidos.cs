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
            foreach (var pedido in RepositorioPedidos.PedidosRealizados)
            {
                Console.WriteLine($"A quantidade de pratos é {pedido.ItensPratos.Count}");
                Console.WriteLine($"A quantidade de bEBIDAS é {pedido.ItensPratos.Count}");
                var item = new PedidosControl(pedido);
                item.Margin = new Padding(13);
                flowLayoutPedidos.Controls.Add(item);
            }
        }
    }
}
