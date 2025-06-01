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
        public static String caminhoImagem = "D:\\Cursos\\C#\\Restaurante\\Restaurante\\Resources\\Hamburguer125125.png";
        static RepositorioPratos()
        {
            // Adicionando um prato de exemplo
            var pratoTeste = new Pratos(
                nome: "Feijoada",
                preco: 45.00m,
                minutos: 60,
                caminhoImagem: caminhoImagem
            );
            AdicionarPrato(pratoTeste);
            var pratoTeste2 = new Pratos(
                nome: "Pizza Margherita",
                preco: 30.00m,
                minutos: 30,
                caminhoImagem: caminhoImagem
            );
            AdicionarPrato(pratoTeste2);
            var pratoTeste3 = new Pratos(
                nome: "Hambúrguer",
                preco: 25.00m,
                minutos: 20,
                caminhoImagem: caminhoImagem
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
