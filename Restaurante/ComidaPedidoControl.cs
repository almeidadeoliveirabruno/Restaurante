using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class ComidaPedidoControl: UserControl
    {
        public ComidaPedidoControl()
        {
            InitializeComponent();
        }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public string CaminhoImagem { get; set; }
        public int Id { get; set; }
        public int Quantidade { get; set; } = 0;
        public Action<int, int> AoAtualizarQuantidadeComida; // envia nome e quantidade
        public ComidaPedidoControl(string nomeProduto, decimal preco, int id, string caminhoImagem)
        {
            InitializeComponent();
            NomeProduto = nomeProduto;
            picImage.Image = caminhoImagem != null ? Image.FromFile(caminhoImagem) : null; // Carrega a imagem se o caminho não for nulo
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
            AoAtualizarQuantidadeComida?.Invoke(Id, Quantidade); // Notifica a atualização da quantidade
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (Quantidade > 0)
            {
                Quantidade--;
                lblQuantidade.Text = Quantidade.ToString();
                AoAtualizarQuantidadeComida?.Invoke(Id, Quantidade); // Notifica a atualização da quantidade
            }
        }

    }
}
