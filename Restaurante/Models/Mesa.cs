using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Mesa
    {
        public int Numero { get; set; }
        public bool Ocupada { get; set; } = false;

        public Mesa(int numero)
        {
            Numero = numero;
        }
        public void VerificaMesasOcupadas()
        {
            Ocupada = false;
            // Vamos olhar todos os pedidos realizados
            foreach (var pedido in RepositorioPedidos.PedidosRealizados)
            {
                // Verifica se o pedido pertence a esta mesa
                if (pedido.Mesa.Numero == this.Numero)
                {
                    // Verifica se o pedido está em andamento ou entregue
                    if (pedido.status == Pedidos.StatusPedido.EmAndamento || pedido.status == Pedidos.StatusPedido.Entregue)
                    {
                        // Se sim, a mesa está ocupada
                        Ocupada = true;
                        break;
                    }
                }
            }
        }

    }
}
