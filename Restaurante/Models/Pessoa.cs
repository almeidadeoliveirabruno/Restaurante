﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public abstract class Pessoa
    {
        protected string nome; 
        protected string cpf;
        protected string telefone;
        protected string endereco;
        protected DateTime dataNascimento;
        protected string email;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Idade 
        {
            get
            {
                var hoje = DateTime.Today;
                int idade = hoje.Year - dataNascimento.Year;
                if (dataNascimento.Date > hoje.AddYears(-idade)) 
                    idade--; 
                return idade;
            }
        }

        public Pessoa(string nome,string cpf, string telefone, string endereco, DateTime datanascimento, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.endereco = endereco;
            this.dataNascimento = datanascimento;
            this.email = email;
        }
    }
}
