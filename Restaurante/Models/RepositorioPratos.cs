using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioPratos
    {
        private static List<Pratos> pratos = new List<Pratos>();
        public static void AdicionarPrato(Pratos prato)
        {
            pratos.Add(prato);
        }
        public static bool VerificarSeExiste(string nome)
        {
            return pratos.Any(i => i.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public static List<Pratos> ObterTodosPratos()
        {
            return pratos;
        }
        public static Pratos ObterPratoPorId(int id)
        {
            return pratos.FirstOrDefault(p => p.Id == id);
        }
        public static void RemoverPrato(int id)
        {
            var prato = ObterPratoPorId(id);
            if (prato != null)
            {
                pratos.Remove(prato);
            }
        }
    }
}
