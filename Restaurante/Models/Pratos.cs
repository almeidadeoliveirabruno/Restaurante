using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Pratos:IItens
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        static int GeradorPratoId { get; set; } = 1;
        public TimeSpan TempoPreparo { get; set; }
        public int Quantidade { get; set; } = 0;
        public string CaminhoImagem { get; set; }
        public Pratos(string nome, decimal preco, int minutos, string caminhoImagem)
        {
            Nome = nome;
            Preco = preco;
            Id = GeradorPratoId;
            GeradorPratoId++;
            CaminhoImagem = caminhoImagem;
            TempoPreparo = TimeSpan.FromMinutes(minutos);
        }

        public Pratos(int id, string nome, decimal preco, int minutos, string caminhoImagem)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            CaminhoImagem = caminhoImagem;
            TempoPreparo = TimeSpan.FromMinutes(minutos);
        }

        // Impedir cópia por referencia
        public Pratos Clone()
        {
            var clone = new Pratos(this.Id,this.Nome, this.Preco, (int)this.TempoPreparo.TotalMinutes, this.CaminhoImagem);
            clone.Quantidade = this.Quantidade;
            return clone;
        }

    }
}
