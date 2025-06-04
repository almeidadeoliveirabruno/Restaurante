using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    
    public class Cozinheiro : Pessoa
    {
        public int IdCozinheiro { get; private set; }
        static int GeradorEmpregadoId { get; set; } = 1;
        public decimal Salario { get; set; }


        public Cozinheiro(string nome, string cpf, string telefone, string endereco, DateTime datanascimento, string email, decimal salario) : base(nome, cpf, telefone, endereco, datanascimento, email)
        {
            IdCozinheiro = GeradorEmpregadoId;
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