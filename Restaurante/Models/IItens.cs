using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public interface IItens
    {
        string Nome { get; set; }
        int Id { get; set; }
        decimal Preco { get; set; }
        int Quantidade { get; set; }
        string CaminhoImagem { get; set; }
    }
}
