using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioBebidas
    {
        static public BindingList<Bebidas> Bebidas { get; set; } = new BindingList<Bebidas>();
        
        static RepositorioBebidas()
        {
            // Adiciona bebidas iniciais ao repositório
            Bebidas.Add(new Bebidas("Coca-Cola", 5.00m, false, "Resources\\Restaurante-Bebida-CocaCola.png"));
            Bebidas.Add(new Bebidas("Cerveja", 8.00m, true, "Resources\\Restaurante-Bebida-Cerveja.png"));
            Bebidas.Add(new Bebidas("Suco de Laranja", 6.00m, false, "Resources\\Restaurante-Bebida-SucoLaranja.png"));
            Bebidas.Add(new Bebidas("Vinho Tinto", 50.00m, true, "Resources\\Restaurante-Bebida-VinhoTinto.png"));
            Bebidas.Add(new Bebidas("Água Mineral", 3.00m, false, "Resources\\Restaurante-Bebida-AguaMineral.png"));
            Bebidas.Add(new Bebidas("Refrigerante Diet", 5.50m, false, "Resources\\Restaurante-Bebida-ColaColaZero.png"));
            Bebidas.Add(new Bebidas("Whisky", 100.00m, true, "Resources\\Restaurante-Bebida-Whisky.png"));
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
