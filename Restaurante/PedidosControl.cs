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
    public partial class PedidosControl : UserControl
    {
        public PedidosControl(Pedido pedido)
        {
            InitializeComponent();
            CarregarPedidos(pedido);
        }

      

        public void CarregarPedidos(Pedido pedido)
        {
          
           foreach (var item in pedido.ItensBebidas)
           {
               if (pedido.ItensBebidas.Count > 0)
               {
                   lblBebida.Text += $"{item.Nome} : ({item.Quantidade})\n";
               }
               if (pedido.ItensPratos.Count > 0)
                {
                    lblComida.Text += $"{item.Nome} : ({item.Quantidade})\n";
                }
               
            }
            lblMesa.Text = $"Mesa: {pedido.Mesa.Numero}";
            lblId.Text = $"ID: {pedido.Id}";
            lblNome.Text = $"Cliente: {pedido.Cliente.Nome}";
            lblprecoTotal.Text = $"Preço Total: R$ {pedido.PrecoTotal:F2}";
            pedido.CalcularTempo();
            lblTempoEstimado.Text = $"Hora da Entrega Estimada: {pedido.DataHoraEntrega:HH:mm}";
        }
    }
}
