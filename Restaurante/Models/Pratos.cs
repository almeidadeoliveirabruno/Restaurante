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
        static int GeradorPratoId { get; set; } = 0;
        private TimeSpan TempoPreparo { get; set; }
        public Pratos(string nome, decimal preco, int minutos)
        {
            Nome = nome;
            Preco = preco;
            Id = GeradorPratoId;
            GeradorPratoId++;
            TempoPreparo = TimeSpan.FromMinutes(minutos);
        }
    }
}
