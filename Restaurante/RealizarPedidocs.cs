using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class RealizarPedidocs: FormBase
    {
        public RealizarPedidocs()
        {
            InitializeComponent();
        }

        private Dictionary<int, int> pedidoAtualBebida = new Dictionary<int, int>();
        private Dictionary<int, int> pedidoAtualComida = new Dictionary<int, int>();
        public List<Pratos> ListaComidas = new List<Pratos>();
        public List< Bebidas> ListaBebidas = new List<Bebidas>();
        private void AtualizarPedidoComida(int id, int quantidade)
        {
            if (quantidade <= 0)
            {
                if (pedidoAtualComida.ContainsKey(id))
                    pedidoAtualComida.Remove(id);
                CalcularTotal();
            }
            else
            {
                pedidoAtualComida[id] = quantidade;
                CalcularTotal();
            }
            // Só pra debug, mostrar o pedido atualizado no console
            Console.WriteLine("Pedido Atual:");
            foreach (var item in pedidoAtualComida)
            {
                Console.WriteLine($"Produto: {item.Key}, Quantidade: {item.Value}");
            }
        }


        private void AtualizarPedidoBebida(int id, int quantidade)
        {
            if (quantidade <= 0)
            {
                if (pedidoAtualBebida.ContainsKey(id))
                    pedidoAtualBebida.Remove(id);
                CalcularTotal();
            }
            else
            {
                pedidoAtualBebida[id] = quantidade;
                CalcularTotal();
            }

            // Só pra debug, mostrar o pedido atualizado no console
            Console.WriteLine("Pedido Atual:");
            foreach (var item in pedidoAtualBebida)
            {
                Console.WriteLine($"Produto: {item.Key}, Quantidade: {item.Value}");
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in pedidoAtualBebida)
            {
                var bebida = RepositorioBebidas.Bebidas.FirstOrDefault(b => b.Id == item.Key);
                if (bebida != null)
                {
                    total += bebida.Preco * item.Value;
                }
            }
            foreach (var item in pedidoAtualComida)
            {
                var comida = RepositorioPratos.Pratos.FirstOrDefault(c => c.Id == item.Key);
                if (comida != null)
                {
                    total += comida.Preco * item.Value;
                }
            }
            TotalCusto.Text = $"Total: R$ {total:F2}";
        }


        private void CarregarPedidosBebidas()
        {
            flowLayoutPanelBebidas.Controls.Clear(); 

            foreach (var pedido in RepositorioBebidas.Bebidas)
            {
                var item = new BebidaPedidoControl(pedido.Nome, pedido.Preco, pedido.Id);
                item.Margin = new Padding(13); // espaçamento externo
                flowLayoutPanelBebidas.Controls.Add(item);
                item.AoAtualizarQuantidadeBebida = AtualizarPedidoBebida;
            }

            flowLayoutPanelComidas.Controls.Clear();
            foreach (var pedido in RepositorioPratos.Pratos)
            {
                var item = new ComidaPedidoControl(pedido.Nome, pedido.Preco, pedido.Id, pedido.CaminhoImagem);
                item.Margin = new Padding(13); // espaçamento externo
                flowLayoutPanelComidas.Controls.Add(item);
                item.AoAtualizarQuantidadeComida = AtualizarPedidoComida;
            }
        }

        private void RealizarPedidocs_Load(object sender, EventArgs e)
        {
            CarregarPedidosBebidas();
        }

    }
}
