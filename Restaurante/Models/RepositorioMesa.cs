using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioMesa
    {
        public static List<Mesa> Mesas { get; private set; } = new List<Mesa>();
        static RepositorioMesa()
        {
            Adicionar(new Mesa());
            Adicionar(new Mesa());
            Adicionar(new Mesa());
        }
        public static void Adicionar(Mesa mesa)
        {
            Mesas.Add(mesa);
        }
    }
}
