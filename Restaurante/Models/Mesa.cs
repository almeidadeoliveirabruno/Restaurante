using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Mesa
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public bool Ocupada { get; set; }
        public Mesa(int id, int numero, int capacidade, bool ocupada)
        {
            Id = id;
            Numero = numero;
            Capacidade = capacidade;
            Ocupada = ocupada;
        }
    }
}
