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
    public partial class CadastroItem: FormBase
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void TipoCombox_Validacao(object sender, EventArgs e)
        {
            if (!TipoComBox.Items.Contains(TipoComBox.Text))
            {
                MessageBox.Show("Escolha uma opção válida da lista!");
                TipoComBox.Text = string.Empty;
                TipoComBox.Focus();
            }
        }
        private void TipoComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoComBox.Text == "Bebida")
            {
                AlcoolcheckBox.Visible = true;
            }
            else if (TipoComBox.Text == "Prato")
            {
                AlcoolcheckBox.Visible = false;
            }
            else
            {
                AlcoolcheckBox.Visible = false;
            }
        }

        private void TipoComBox_Click(object sender, EventArgs e)
        {
           
        }
    }
}
