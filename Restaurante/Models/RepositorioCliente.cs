using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public static class RepositorioCliente
    {
            public static BindingList<Cliente> Clientes { get; private set; } = new BindingList<Cliente>();
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
            var clienteTeste2 = new Cliente(
                nome: "João da Silva Souza",
                cpf: "12345678900",
                telefone: "21999998888",
                endereco: "Avenida Brasil, 123, Rio De Janeiro, Brasil, Volta Redonda, Qualquer coisa",
                email: "JoãoTeste@unifoa.edu.br",
                dataNascimento: new DateTime(1990, 5, 15));
            Adicionar(clienteTeste2);
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

            public static bool Remover(int id)
            {
                var cliente = RepositorioCliente.Clientes.FirstOrDefault(c => c.ClienteID == id);
                if (cliente != null)
                {
                    Clientes.Remove(cliente);
                return true; // Retorna true se o cliente foi removido com sucesso
                }
                else
                {
                    return false; // Retorna false se o cliente não foi encontrado
            }
            }

    }
}
