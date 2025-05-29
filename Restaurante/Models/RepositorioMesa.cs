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
            Adicionar(new Mesa(4, false));
            Adicionar(new Mesa(2, false));
            Adicionar(new Mesa(6, false));
            Adicionar(new Mesa(8, false));
            Adicionar(new Mesa(4, false));
        }
        public static bool Adicionar(Mesa mesa)
        {
            if (mesa.Capacidade <= 0)
            {
                return false;
            }
            else
            {
                Mesas.Add(mesa);
                return true;
            }
        }
    }
}
