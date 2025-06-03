using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Cozinheiro : Pessoa
    {
        public int IdEmpregado { get; private set; }
        static int GeradorEmpregadoId { get; set; } = 1;
        public decimal Salario { get; set; }
        public int NumeroPedidosAtendendo { get; private set; } = 0;


        public Cozinheiro(string nome, string cpf, string telefone, string endereco, DateTime datanascimento, string email, decimal salario) : base(nome, cpf, telefone, endereco, datanascimento, email)
        {
            IdEmpregado = GeradorEmpregadoId;
            Salario = salario;
            GeradorEmpregadoId++;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
            DataNascimento = datanascimento;

        }

        public void AumentoNumeroPedidos()
        {
            NumeroPedidosAtendendo++;
        }

        public void DiminuiNumeroPedidos()
        {
            if (NumeroPedidosAtendendo > 0)
            {
                NumeroPedidosAtendendo--;
            }
        }



    }
}