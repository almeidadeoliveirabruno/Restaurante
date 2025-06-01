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
            Adicionar(new Mesa());
            Adicionar(new Mesa());
            Adicionar(new Mesa());
        }
        public static void Adicionar(Mesa mesa)
        {
            if (Mesas.Count <= 9)
            {
                Mesas.Add(mesa);
            }
        }
            

        public static void remover(Mesa mesa)
        {
            if (Mesas.Count > 0)
            {
                Mesas.RemoveAt(Mesas.Count - 1);
            }
        }
    }
}
