using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public static class RepositorioCliente
    {
            public static List<Cliente> Clientes { get; private set; } = new List<Cliente>();
            
            static RepositorioCliente()
        {
            var clienteTeste = new Cliente(
            nome: "Maria Oliveira Teixeira Paula",
            cpf: "98765432100",
            telefone: "21988887777",
            endereco: "Rua das Flores, 456, Rio De Janeiro, Brasil, Volta Redonda, Qualquer coisa",
            email: "maria@teste.com",
            dataNascimento: new DateTime(1985, 3, 10));
            Adicionar(clienteTeste);
        }
            public static bool Adicionar(Cliente c)
            {
                if (VerificaSeClienteExiste( c.Cpf))
                {
                    return false; // Já existe cliente com esse CPF
                }
                Clientes.Add(c);
                return true;
            }

            public static bool VerificaSeClienteExiste(string cpf)
            {
                if (Clientes.Any(cliente => cliente.Cpf == cpf))
                {
                    return true; // Já existe cliente com esse CPF
                }
            return false;
        }

        public static List<Cliente> ObterTodos() => Clientes;

    }
}
