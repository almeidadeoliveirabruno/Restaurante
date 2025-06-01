using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioBebidas
    {
        static public List<Bebidas> Bebidas { get; set; } = new List<Bebidas>();
        static RepositorioBebidas()
        {
            // Adiciona bebidas iniciais ao repositório
            Bebidas.Add(new Bebidas("Coca-Cola", 5.00m, false));
            Bebidas.Add(new Bebidas("Cerveja", 8.00m, true));
            Bebidas.Add(new Bebidas("Suco de Laranja", 6.00m, false));
            Bebidas.Add(new Bebidas("Vinho Tinto", 50.00m, true));
        }
        static public void AdicionarBebida(Bebidas bebida)
        {
            if (!VerificarseExiste(bebida.Nome))
            {
                Bebidas.Add(bebida);
            }
        }
        static public bool VerificarseExiste(string nome)
        {
            //Verifica se ja existe,ignorando caixa alta e baixa
            return Bebidas.Any(b => b.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        static public void RemoverBebida(int id)
        {
            var bebida = Bebidas.FirstOrDefault(b => b.Id == id);
            if (bebida != null)
            {
                Bebidas.Remove(bebida);
            }
        }

    }
}
