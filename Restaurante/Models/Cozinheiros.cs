using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Cozinheiros: Pessoa
    {
        public int IdCozinheiro { get; private set; }
        static int GeradorCozinheiroId { get; set; } = 0;
        public string Especialidade { get; private set; }
        public int TrabalhoEmNPedidos { get; private set; }

        public Cozinheiros(string nome, string cpf, string telefone, string endereco, DateTime datanascimento, string especialidade) : base(nome, cpf, telefone, endereco, datanascimento)
        {
            Especialidade = especialidade;
            IdCozinheiro = GeradorCozinheiroId;
            GeradorCozinheiroId++;
        }

        

        
    }
}
