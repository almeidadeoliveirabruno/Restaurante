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
    public partial class VisualizarMesa: FormBase
    {
        public VisualizarMesa()
        {
            InitializeComponent();
            ExibirMesasDinamicamente();

        }
        private void ExibirMesasDinamicamente()
        {
            flowLayoutPanelMesas.Controls.Clear();

            foreach (var mesa in RepositorioMesa.Mesas)
            {
                Button btn = new Button();
                btn.Text = $"Mesa {mesa.Id}";
                btn.Width = 150;
                btn.Height = 180;
                btn.Tag = mesa;
                btn.BackColor = mesa.Ocupada ? Color.LightCoral : Color.LightGreen;
                btn.Click += BtnMesa_Click;

                flowLayoutPanelMesas.Controls.Add(btn);
            }
        }

        private void BtnMesa_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Mesa mesa = btn.Tag as Mesa;

            mesa.Ocupada = !mesa.Ocupada;
            btn.BackColor = mesa.Ocupada ? Color.LightCoral : Color.LightGreen;
        }

        private void PainelMesas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
