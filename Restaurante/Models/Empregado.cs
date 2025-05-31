using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Empregado: Pessoa
    {
        public int IdEmpregado { get; private set; }
        static int GeradorEmpregadoId { get; set; } = 1;
        public string Especialidade { get; private set; }
        public int TrabalhoEmNPedidos { get; private set; }

        public Empregado(string nome, string cpf, string telefone, string endereco, DateTime datanascimento, string especialidade, string email) : base(nome, cpf, telefone, endereco, datanascimento, email)
        {
            Especialidade = especialidade;
            IdEmpregado = GeradorEmpregadoId;
            GeradorEmpregadoId++;
        }

        

        
    }
}
