using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioPedidos
    {
        static List<IItens> Itens { get; set; } = new List<IItens>() ;
        public static void AdicionarPedido(IItens itens)
        {
            Itens.Add(itens);
        }
    }
}
