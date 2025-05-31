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
            if (!VerificarSeExiste(itens.Nome))
            {
                Itens.Add(itens);
            }
            
        }
        public static bool VerificarSeExiste(string nome)
        {
            return Itens.Any(i => i.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public static List<IItens> ObterTodosPedidos()
        {
            return Itens;
        }
        public static IItens ObterPedidoPorId(int id)
        {
            return Itens.FirstOrDefault(i => i.Id == id);
        }
        public static void RemoverPedido(int id)
        {
            var pedido = ObterPedidoPorId(id);
            if (pedido != null)
            {
                Itens.Remove(pedido);
            }
        }
       
    }
}
