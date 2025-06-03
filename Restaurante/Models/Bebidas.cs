using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Bebidas : IItens
    {
        public string Nome { get; set; }
        public Boolean Alcool { get;  set; }
        public int Id { get;  set; }
        public decimal Preco { get;  set; }
        public int Quantidade { get; set; } = 0;
        public string CaminhoImagem { get; set; }
        static int GeradorBebidaId { get;  set; } = 1;

        public Bebidas(string nome, decimal preco, Boolean alcool, string caminhoImagem)
        {
            Nome = nome;
            Preco = preco;
            Alcool = alcool;
            Id = GeradorBebidaId;
            GeradorBebidaId++;
            CaminhoImagem = caminhoImagem;
        }

        private Bebidas(int id, string nome, decimal preco,bool alcool, string caminhoImagem)
        {
            Id = id;
            Nome = nome;
            Alcool = alcool;
            Preco = preco;
            CaminhoImagem = caminhoImagem;
        }

        public Bebidas Clone()
        {
            var clone = new Bebidas(this.Id,this.Nome, this.Preco,this.Alcool, this.CaminhoImagem);
            clone.Quantidade = this.Quantidade;
            return clone;
        }
    }

}
