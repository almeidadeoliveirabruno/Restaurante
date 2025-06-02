using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Restaurante.Models
{
    public class Cliente : Pessoa
    {
        public int ClienteID { get; private set; }
        static int geradorClienteId { get; set; } = 1;
        public List <Pedidos> HistoricoPedidos { get; set; } = new List<Pedidos>();
       
        public string IdentificadorCombox
        {
            get
            {
                return $"{Nome} - {Cpf}";
            }
        }

        public Cliente( string nome, string cpf, string telefone, string endereco, string email, DateTime dataNascimento)
         : base(nome, cpf, telefone, endereco, dataNascimento,email)
        {
            ClienteID = geradorClienteId;
            geradorClienteId++;
        }

        public void AdicionarPedido(Pedidos pedido)
        {
            HistoricoPedidos.Add(pedido);
        }
    }
}
