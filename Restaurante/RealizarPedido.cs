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
    public partial class RealizarPedido : FormBase
    {
        private Dictionary<int, int> pedidoAtualBebida = new Dictionary<int, int>();
        private Dictionary<int, int> pedidoAtualComida = new Dictionary<int, int>();
        public List<Pratos> ListaPratos = new List<Pratos>();
        public List<Bebidas> ListaBebidas = new List<Bebidas>();

        public RealizarPedido()
        {
            InitializeComponent();
        }

        // ---------------------------
        // Eventos do Ciclo de Vida
        // ---------------------------
        private void RealizarPedidocs_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            ClientesComBox.DataSource = RepositorioCliente.Clientes;
            ClientesComBox.DisplayMember = "IdentificadorCombox";
            ClientesComBox.ValueMember = "ClienteID";
            MesaCombox.DataSource = RepositorioMesa.Mesas;
            MesaCombox.DisplayMember = "Numero";
        }

        // ---------------------------
        // Métodos Auxiliares
        // ---------------------------
        private void CarregarPedidos()
        {
            flowLayoutPanelBebidas.Controls.Clear();
            foreach (var pedido in RepositorioBebidas.Bebidas)
            {
                var item = new BebidaPedidoControl(pedido.Nome, pedido.Preco, pedido.Id, pedido.CaminhoImagem);
                item.Margin = new Padding(13);
                item.AoAtualizarQuantidadeBebida = AtualizarPedidoBebida;
                flowLayoutPanelBebidas.Controls.Add(item);
            }

            flowLayoutPanelComidas.Controls.Clear();
            foreach (var pedido in RepositorioPratos.Pratos)
            {
                var item = new ComidaPedidoControl(pedido.Nome, pedido.Preco, pedido.Id, pedido.CaminhoImagem);
                item.Margin = new Padding(13);
                item.AoAtualizarQuantidadeComida = AtualizarPedidoComida;
                flowLayoutPanelComidas.Controls.Add(item);
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

        // ---------------------------
        // Atualizações de Pedido
        // ---------------------------
        private void AtualizarPedidoComida(int id, int quantidade)
        {
            if (quantidade <= 0)
            {
                pedidoAtualComida.Remove(id);
                ListaPratos.RemoveAll(c => c.Id == id);
            }
            else
            {
                pedidoAtualComida[id] = quantidade;

                if (!ListaPratos.Any(c => c.Id == id))
                {
                    var comida = RepositorioPratos.Pratos.FirstOrDefault(c => c.Id == id);
                    if (comida != null)
                    {
                        var clone = comida.Clone();  // <-- Clonando aqui
                        clone.Quantidade = quantidade; // Define a quantidade inicial no clone
                        ListaPratos.Add(clone);
                    }
                }
                else
                {
                    var comidaExistente = ListaPratos.FirstOrDefault(c => c.Id == id);
                    if (comidaExistente != null)
                    {
                        comidaExistente.Quantidade = quantidade;
                    }
                }
            }

            CalcularTotal();
        }

        private void AtualizarPedidoBebida(int id, int quantidade)
        {
            if (quantidade <= 0)
            {
                pedidoAtualBebida.Remove(id);
                ListaBebidas.RemoveAll(b => b.Id == id);
            }
            else
            {
                pedidoAtualBebida[id] = quantidade;

                if (!ListaBebidas.Any(b => b.Id == id))
                {
                    var bebida = RepositorioBebidas.Bebidas.FirstOrDefault(b => b.Id == id);
                    if (bebida != null)
                    {
                        var clone = bebida.Clone();
                        clone.Quantidade = quantidade; // Define a quantidade inicial
                        ListaBebidas.Add(clone);
                        Console.WriteLine($"{clone.Nome} e {clone.Quantidade}");
                    }
                }
                else
                {
                    var bebidaExistente = ListaBebidas.FirstOrDefault(b => b.Id == id);
                    if (bebidaExistente != null)
                    {
                        bebidaExistente.Quantidade = quantidade;
                    }
                }
            }

            CalcularTotal();
        }

        // ---------------------------
        // Eventos de Botão
        // ---------------------------
        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (pedidoAtualBebida.Count == 0 && pedidoAtualComida.Count == 0)
            {
                MessageBox.Show("Nenhum item foi adicionado ao pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientesComBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente antes de finalizar o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } if (MesaCombox.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma mesa antes de finalizar o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var clienteSelecionado = (Cliente)ClientesComBox.SelectedItem;
            if (clienteSelecionado.Idade < 18 && ListaBebidas.Any(b => b.Alcool == true))
            {
                MessageBox.Show($"O cliente {clienteSelecionado.Nome} é menor de idade e não pode consumir álcool.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialogResult = MessageBox.Show("Deseja finalizar o pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               

                Mesa mesaSelecionada = (Mesa)MesaCombox.SelectedItem;

                //
                var pratosCopia = ListaPratos.Select(p => p.Clone()).ToList();
                var bebidasCopia = ListaBebidas.Select(b => b.Clone()).ToList();

                Pedido pedidos = new Pedido(clienteSelecionado, pratosCopia, bebidasCopia, mesaSelecionada);
                pedidos.CalcularPrecoTotal();
                RepositorioPedidos.AdicionarPedidos(pedidos);

                MessageBox.Show("Pedido realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                // Reset
                pedidoAtualBebida.Clear();
                pedidoAtualComida.Clear();
                ListaPratos.Clear();
                ListaBebidas.Clear();
                CarregarPedidos();
                TotalCusto.Text = "Total: R$ 0,00";
               
            }
        }

        private void VisualizarPedidoButton_Click(object sender, EventArgs e)
        {
            VisualizarPedidos visualizarPedidos = new VisualizarPedidos();
            visualizarPedidos.Show();

        }

        // ---------------------------
        // Eventos Visuais (não usados)
        // ---------------------------
        private void label1_Click(object sender, EventArgs e)
        {
            // Pode ser removido se não estiver em uso
        }
    }
}
