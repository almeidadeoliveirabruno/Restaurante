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
            
            foreach (var pedido in RepositorioPedidos.PedidosRealizados)
            {
              
                if (pedido.Mesa.Numero == this.Numero)
                {
                    
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
