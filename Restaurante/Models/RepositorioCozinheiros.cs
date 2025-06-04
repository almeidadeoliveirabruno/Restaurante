using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public static class RepositorioCozinheiros
    {
        public static BindingList<Cozinheiro> Cozinheiros { get; private set; } = new BindingList<Cozinheiro>();
        static RepositorioCozinheiros()
        {
            Adicionar(new Cozinheiro(
    nome: "João da Silva",
    cpf: "12345678900",
    telefone: "21999990000",
    endereco: "Rua A, 123",
    datanascimento: new DateTime(1990, 5, 10),
    email: "joao.silva@example.com",
    salario: 3000.00m
));

            Adicionar(new Cozinheiro(
                nome: "Maria Oliveira",
                cpf: "98765432100",
                telefone: "21988880000",
                endereco: "Av. B, 456",
                datanascimento: new DateTime(1985, 10, 22),
                email: "maria.oliveira@example.com",
                salario: 2000.00m
            ));
            Adicionar(new Cozinheiro(
                nome: "Carlos Pereira",
                cpf: "45678912300",
                telefone: "21977770000",
                endereco: "Rua C, 789",
                datanascimento: new DateTime(1992, 3, 15),
                email: "Carlos.Pereira@Algodiferentedeexample.com",
                salario: 2500.00m));
        }

        public static bool Adicionar(Cozinheiro f)
        {
            if (VerificaSeFuncionarioExiste(f.Cpf))
            {
                return false; 
            }
            Cozinheiros.Add(f);
            return true;
        }

        public static bool VerificaSeFuncionarioExiste(string cpf)
        {
            if (Cozinheiros.Any(funcionario => funcionario.Cpf == cpf))
            {
                return true; 
            }
            return false;
        }

        public static void Remover(int id)
        {
            var empregado = Cozinheiros.FirstOrDefault(e => e.IdCozinheiro == id);
            if (empregado != null)
            {
                Cozinheiros.Remove(empregado);
            }
        }

    }
}
