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
        public static int GeradorId { get; set; } = 1;
        public int Capacidade { get; set; }
        public bool Ocupada { get; set; }
        public Mesa( int capacidade, bool ocupada)
        {
            Id = GeradorId;
            GeradorId++;
            Capacidade = capacidade;
            Ocupada = ocupada;
        }
    }
}
