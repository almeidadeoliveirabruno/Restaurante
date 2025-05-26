using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Pedidos
    {
        public int Id { get; private set; }
        public DateTime DataHoraPedido { get; private set; }
        public string Status { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<IItens> Pedido { get; private set; } = new List<IItens>();
    }
}
