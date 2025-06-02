using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    static class RepositorioMesa
    {
        public static BindingList<Mesa> Mesas { get; private set; } = new BindingList<Mesa>();
       
        static RepositorioMesa()
        {
            Mesa mesa1 = new Mesa(1);
            Mesa mesa2 = new Mesa(2);
            Mesa mesa3 = new Mesa(3);
            Mesa mesa4 = new Mesa(4);
            Mesas.Add(mesa1);
            Mesas.Add(mesa2);
            Mesas.Add(mesa3);
            Mesas.Add(mesa4);
        }
        
    }
}
