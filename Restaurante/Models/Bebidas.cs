using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Bebidas : IItens
    {
        public string Nome { get; set; }
        public Boolean Alcool { get;  set; }
        public int Id { get; set; }
        public decimal Preco { get;  set; }
        public int Quantidade { get; set; } = 0;
        static int GeradorBebidaId { get;  set; } = 1;

        public Bebidas(string nome, decimal preco, Boolean alcool)
        {
            Nome = nome;
            Preco = preco;
            Alcool = alcool;
            Id = GeradorBebidaId;
            GeradorBebidaId++;
        }
    }

}
