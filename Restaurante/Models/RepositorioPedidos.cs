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
        public static List<Pedidos> PedidosRealizados { get; set; } = new List<Pedidos>() ;
        
        public static void AdicionarPedidos(Pedidos pedido)
        {
            PedidosRealizados.Add(pedido);
        }




    }
}
