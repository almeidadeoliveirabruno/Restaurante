using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioPratos
    {
        public static List<Pratos> Pratos = new List<Pratos>();
        static RepositorioPratos()
        {
            // Adicionando um prato de exemplo
            var pratoTeste = new Pratos(
                nome: "Feijoada",
                preco: 45.00m,
                minutos: 60
            );
            AdicionarPrato(pratoTeste);
        }
        public static void AdicionarPrato(Pratos prato)
        {
            Pratos.Add(prato);
        }
        public static bool VerificarSeExiste(string nome)
        {
            return Pratos.Any(i => i.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public static List<Pratos> ObterTodosPratos()
        {
            return Pratos;
        }
        public static Pratos ObterPratoPorId(int id)
        {
            return Pratos.FirstOrDefault(p => p.Id == id);
        }
        public static void RemoverPrato(int id)
        {
            var prato = ObterPratoPorId(id);
            if (prato != null)
            {
                Pratos.Remove(prato);
            }
        }
    }
}
