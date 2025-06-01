using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurante.Models;

namespace Restaurante
{
    public partial class BebidaPedidoControl: UserControl
    {
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public string CaminhoImagem { get; set; }
        public int Id { get; set; } 
        public int Quantidade { get; set; } = 0;
        public Action<int, int> AoAtualizarQuantidadeBebida; // envia nome e quantidade
        //public BebidaPedidoControl()
        //{
        //    InitializeComponent();
        //}

        public BebidaPedidoControl(string nomeProduto, decimal preco,int id)
        {
            InitializeComponent();
            NomeProduto = nomeProduto;
            Preco = preco;

            lblNome.Text = nomeProduto;
            lblPreco.Text = $"R$ {preco:F2}";
            lblQuantidade.Text = Quantidade.ToString();
            Id = id;

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            Quantidade++;
            lblQuantidade.Text = Quantidade.ToString();
            AoAtualizarQuantidadeBebida.Invoke(Id, Quantidade); // Notifica a atualização da quantidade
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (Quantidade > 0)
            {
                Quantidade--;
                lblQuantidade.Text = Quantidade.ToString();
                AoAtualizarQuantidadeBebida.Invoke(Id, Quantidade); // Notifica a atualização da quantidade
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
