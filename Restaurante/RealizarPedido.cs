using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class RealizarPedido : FormBase
    {
        public List<Pratos> ListaPratosAtual = new List<Pratos>();
        public List<Bebidas> ListaBebidasAtual = new List<Bebidas>();

        public RealizarPedido()
        {
            InitializeComponent();
        }

        private void RealizarPedidocs_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            ClientesComBox.DataSource = RepositorioCliente.Clientes;
            ClientesComBox.DisplayMember = "IdentificadorCombox";
            ClientesComBox.ValueMember = "ClienteID";
            MesaCombox.DataSource = RepositorioMesa.Mesas;
            MesaCombox.DisplayMember = "Numero";
            comboBoxGarcom.DataSource = RepositorioCozinheiros.Cozinheiros;
            comboBoxGarcom.DisplayMember = "Nome";
            comboBoxGarcom.ValueMember = "IdCozinheiro";
        }

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
                var item = new PratoPedidoControl(pedido.Nome, pedido.Preco, pedido.Id, pedido.CaminhoImagem);
                item.Margin = new Padding(13);
                item.AoAtualizarQuantidadeComida = AtualizarPedidoComida;
                flowLayoutPanelComidas.Controls.Add(item);
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            total += ListaPratosAtual.Sum(p => p.Preco * p.Quantidade);
            total += ListaBebidasAtual.Sum(b => b.Preco * b.Quantidade);

            TotalCusto.Text = $"Total: R$ {total:F2}";
        }

        private void AtualizarPedidoComida(int id, int quantidade)
        {
            if (quantidade <= 0)
            {
                ListaPratosAtual.RemoveAll(c => c.Id == id);
            }
            else
            {
                var comidaExistente = ListaPratosAtual.FirstOrDefault(c => c.Id == id);
                if (comidaExistente != null)
                {
                    comidaExistente.Quantidade = quantidade;
                }
                //se não tiver na lista atual procura no repositorio
                else
                {
                    var comida = RepositorioPratos.Pratos.FirstOrDefault(c => c.Id == id);
                    if (comida != null)
                    {
                        var clone = comida.Clone();
                        clone.Quantidade = quantidade;
                        ListaPratosAtual.Add(clone);
                    }
                }
            }

            CalcularTotal();
        }

        private void AtualizarPedidoBebida(int id, int quantidade)
        {
            if (quantidade <= 0)
            {
                ListaBebidasAtual.RemoveAll(b => b.Id == id);
            }
            else
            {
                var bebidaExistente = ListaBebidasAtual.FirstOrDefault(b => b.Id == id);
                if (bebidaExistente != null)
                {
                    bebidaExistente.Quantidade = quantidade;
                }
                //se não tiver na lista atual procura no repositorio
                else
                {
                    var bebida = RepositorioBebidas.Bebidas.FirstOrDefault(b => b.Id == id);
                    if (bebida != null)
                    {
                        var clone = bebida.Clone();
                        clone.Quantidade = quantidade;
                        ListaBebidasAtual.Add(clone);
                    }
                }
            }

            CalcularTotal();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (ListaBebidasAtual.Count == 0 && ListaPratosAtual.Count == 0)
            {
                MessageBox.Show("Nenhum item foi adicionado ao pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ClientesComBox.SelectedItem == null)
            {
                MessageBox.Show("Selecione um cliente antes de finalizar o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MesaCombox.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma mesa antes de finalizar o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxGarcom.SelectedItem == null)
            {
                MessageBox.Show("Selecione um garçom antes de finalizar o pedido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var garcomSelecionado = (Cozinheiro)comboBoxGarcom.SelectedItem;

            var clienteSelecionado = (Cliente)ClientesComBox.SelectedItem;
            if (clienteSelecionado.Idade < 18 && ListaBebidasAtual.Any(b => b.Alcool == true))
            {
                MessageBox.Show($"O cliente {clienteSelecionado.Nome} é menor de idade e não pode consumir álcool.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialogResult = MessageBox.Show("Deseja finalizar o pedido?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Mesa mesaSelecionada = (Mesa)MesaCombox.SelectedItem;

                var pratosCopia = ListaPratosAtual.Select(p => p.Clone()).ToList();
                var bebidasCopia = ListaBebidasAtual.Select(b => b.Clone()).ToList();

                Pedido pedidos = new Pedido(clienteSelecionado, pratosCopia, bebidasCopia, mesaSelecionada, garcomSelecionado);
                pedidos.CalcularPrecoTotal();
                RepositorioPedidos.AdicionarPedidos(pedidos);

                MessageBox.Show("Pedido realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListaPratosAtual.Clear();
                ListaBebidasAtual.Clear();
                CarregarPedidos();
                TotalCusto.Text = "Total: R$ 0,00";
            }
        }

        private void VisualizarPedidoButton_Click(object sender, EventArgs e)
        {
            VisualizarPedidos visualizarPedidos = new VisualizarPedidos();
            visualizarPedidos.Show();
        }
    }
}
