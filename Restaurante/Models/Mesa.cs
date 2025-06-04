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

            // Verifica se há pedidos realizados para esta mesa
            foreach (var pedido in RepositorioPedidos.PedidosRealizados)
            {
                //percorrendo pedido por pedido
              
                if (pedido.Mesa.Numero == this.Numero)
                {
                    //compara se a mesa percorrida é a mesma que a mesa atual
                    //se for, verifica o status do pedido
                    if (pedido.status == Pedido.StatusPedido.EmAndamento || pedido.status == Pedido.StatusPedido.Entregue)
                    {
                        Ocupada = true;
                        break;
                    }
                }
            }
        }

    }
}
