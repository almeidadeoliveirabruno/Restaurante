using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Models
{
    static class RepositorioPedidos
    {
        public static BindingList<Pedido> PedidosRealizados { get; set; } = new BindingList<Pedido>() ;
        
        public static void AdicionarPedidos(Pedido pedido)
        {
            PedidosRealizados.Add(pedido);
        }




    }
}
