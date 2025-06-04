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
using System.Windows.Forms.VisualStyles;
using static Restaurante.Models.Pedido;

namespace Restaurante
{
    public partial class PedidosControl : UserControl
    {
        Pedido _pedido;
        public PedidosControl(Pedido pedido)
        {
            InitializeComponent();
            _pedido = pedido;
            CarregarPedidos(_pedido);
        }

        public void CarregarPedidos(Pedido pedido)
        {
            lblBebida.Text = "";  // Limpa o texto antes de adicionar
            foreach (var item in pedido.ItensBebidas)
            {
                lblBebida.Text += $"{item.Nome} : ({item.Quantidade}){Environment.NewLine}";
            }

            lblComida.Text = "";  // Limpa o texto antes de adicionar
            foreach (var item in pedido.ItensPratos)
            {
                lblComida.Text += $"{item.Nome} : ({item.Quantidade}){Environment.NewLine}";
            }
            lblGarcom.Text = $"Garçom: {pedido.Cozinheiro.Nome}";

            lblMesa.Text = $"Mesa: {pedido.Mesa.Numero}";
            lblId.Text = $"ID: {pedido.Id}";
            lblNome.Text = $"Cliente: {pedido.Cliente.Nome}";
            lblprecoTotal.Text = $"Preço Total: R$ {pedido.PrecoTotal:F2}";
            pedido.CalcularTempo();
            lblTempoEstimado.Text = $"Hora da Entrega Estimada: {pedido.DataHoraEntrega:HH:mm}";
            button1.Text = $"Status: {pedido.status}";
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            TrocarStatusEAtualizar();
        }
        private void TrocarStatusEAtualizar()
        {
            StatusPedido proximoStatus;
            Color corBotao;

            switch (_pedido.status)
            {
                case StatusPedido.EmAndamento:
                    proximoStatus = StatusPedido.Entregue;
                    corBotao = Color.YellowGreen;
                    break;
                case StatusPedido.Entregue:
                    proximoStatus = StatusPedido.Pago;
                    corBotao = Color.LightBlue;
                    break;
                case StatusPedido.Pago:
                    proximoStatus = StatusPedido.Cancelado;
                    corBotao = Color.LightGray;
                    break;
                case StatusPedido.Cancelado:
                    proximoStatus = StatusPedido.EmAndamento;
                    corBotao = Color.Orange;
                    break;
                default:
                    proximoStatus = StatusPedido.EmAndamento;
                    corBotao = Color.Orange;
                    break;
            }

            _pedido.status = proximoStatus;
            button1.Text = $"Status: {_pedido.status}";
            button1.BackColor = corBotao;
        }
    }
}
