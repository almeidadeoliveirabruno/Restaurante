using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Empregado : Pessoa
    {
        public int IdEmpregado { get; private set; }
        static int GeradorEmpregadoId { get; set; } = 1;
        public string FuncaoEmpregado { get; set; }
        //public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }


        public Empregado(string nome, string cpf, string telefone, string endereco, DateTime datanascimento, string funcaoEmpregado, string email, decimal salario) : base(nome, cpf, telefone, endereco, datanascimento, email)
        {
            FuncaoEmpregado = funcaoEmpregado;
            IdEmpregado = GeradorEmpregadoId;
            Salario = salario;
            GeradorEmpregadoId++;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
            DataNascimento = datanascimento;

        }




    }
}