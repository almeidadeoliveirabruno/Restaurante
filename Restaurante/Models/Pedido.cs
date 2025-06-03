using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Pedido
    {
        public enum StatusPedido
        {
            EmAndamento,
            Entregue,
            Pago,
            Cancelado
        }
        public int Id { get; set; }
        static int GeradorPedidoId = 1;
        public DateTime DataHoraPedido { get; set; } = DateTime.Now;
        public DateTime DataHoraEntrega { get; set; }
        public StatusPedido status { get; set; } = StatusPedido.EmAndamento;   
        public decimal PrecoTotal { get; set; }
        public Cliente Cliente { get; set; } 
        public List<Pratos> ItensPratos { get; set; } = new List<Pratos>();
        public List<Bebidas> ItensBebidas { get; set; } = new List<Bebidas>();
        public Mesa Mesa { get; set; }
        public Pedido(Cliente cliente, List<Pratos> prato, List<Bebidas> bebida, Mesa mesa)
        {
            Id = GeradorPedidoId++;
            Cliente = cliente;
            if (prato != null)
            {
                ItensPratos = prato;
            }
            if (bebida != null)
            {
                ItensBebidas = bebida;
            }
            Mesa = mesa;
        }
        public void CalcularPrecoTotal()
        {
            PrecoTotal = ItensPratos.Sum(p => p.Preco * p.Quantidade) + ItensBebidas.Sum(b => b.Preco * b.Quantidade);
        }
        public void CalcularTempo()
        {
            if (ItensPratos.Count > 0)
            {
                TimeSpan tempoPratos = ItensPratos.Max(p => p.TempoPreparo);
                DataHoraEntrega = DataHoraPedido.Add(tempoPratos);
            }
            DataHoraEntrega = DataHoraPedido;
        }
    }

  
}
