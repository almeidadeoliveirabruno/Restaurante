using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public static class RepositorioEmpregado
    {
        public static List<Empregado> Funcionarios { get; private set; } = new List<Empregado>();
        static RepositorioEmpregado()
        {
            Adicionar(new Empregado(
               nome: "João da Silva",
               cpf: "123.456.789-00",
               telefone: "21999990000",
               endereco: "Rua A, 123",
               datanascimento: new DateTime(1990, 5, 10),
               especialidade: "Grelhados",
               email: "joao.silva@example.com"
           ));

            Adicionar(new Empregado(
                nome: "Maria Oliveira",
                cpf: "987.654.321-00",
                telefone: "21988880000",
                endereco: "Av. B, 456",
                datanascimento: new DateTime(1985, 10, 22),
                especialidade: "Massas",
                email: "maria.oliveira@example.com"
            ));

            Adicionar(new Empregado(
                nome: "Carlos Souza",
                cpf: "456.123.789-00",
                telefone: "21977770000",
                endereco: "Travessa C, 789",
                datanascimento: new DateTime(1995, 3, 18),
                especialidade: "Sushis",
                email: "carlos.souza@example.com"
            ));

            Adicionar(new Empregado(
                nome: "Ana Costa",
                cpf: "321.987.654-00",
                telefone: "21966660000",
                endereco: "Rua D, 101",
                datanascimento: new DateTime(2000, 1, 5),
                especialidade: "Doces",
                email: "ana.costa@example.com"
            ));

            Adicionar(new Empregado(
                nome: "Pedro Santos",
                cpf: "159.753.486-00",
                telefone: "21955550000",
                endereco: "Alameda E, 202",
                datanascimento: new DateTime(1988, 7, 30),
                especialidade: "Pizzas",
                email: "pedro.santos@example.com"
            ));
        }
        
        public static bool Adicionar(Empregado f)
        {
            if (VerificaSeFuncionarioExiste(f.Cpf))
            {
                return false; 
            }
            Funcionarios.Add(f);
            return true;
        }

        public static bool VerificaSeFuncionarioExiste(string cpf)
        {
            if (Funcionarios.Any(funcionario => funcionario.Cpf == cpf))
            {
                return true; 
            }
            return false;
        }

        public static List<Empregado> ObterTodos() => Funcionarios;

    }
}
