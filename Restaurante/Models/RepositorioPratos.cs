using Restaurante.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurante.Models
{
    static class RepositorioPratos
    {
        public static List<Pratos> Pratos = new List<Pratos>();
        
        
        static RepositorioPratos()
        {
            var pratoTeste = new Pratos(
       nome: "Feijoada",
       preco: 45.00m,
       minutos: 60,
       caminhoImagem: Path.Combine("Resources", "Restaurante-Comida-Feijoada.png")
   );
            AdicionarPrato(pratoTeste);

            var pratoTeste2 = new Pratos(
                nome: "Pizza Margherita",
                preco: 30.00m,
                minutos: 30,
                caminhoImagem: Path.Combine("Resources", "Restaurante-Comida-Pizza.png")
            );
            AdicionarPrato(pratoTeste2);

            var pratoTeste3 = new Pratos(
                nome: "Hambúrguer",
                preco: 25.00m,
                minutos: 20,
                caminhoImagem: Path.Combine("Resources", "Hamburguer125125.png")
            );
            AdicionarPrato(pratoTeste3);

        }
        public static void AdicionarPrato(Pratos prato)
        {
            Pratos.Add(prato);
        }
        public static bool VerificarSeExiste(string nome)
        {
            return Pratos.Any(i => i.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
       
        public static Pratos ObterPratoPorId(int id)
        {
            return Pratos.FirstOrDefault(p => p.Id == id);
        }
        public static bool RemoverPrato(int id)
        {
         var prato = Pratos.FirstOrDefault(p => p.Id == id);
            if (prato != null)
            {
                    Pratos.Remove(prato);
                    return true; // Retorna true se o prato foi removido com sucesso
           }
            else
                {
                    return false; // Retorna false se o prato n for removido porque n foi encontrado
            }
            }
    }
}
