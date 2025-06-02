using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
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
                mesa.VerificaMesasOcupadas();
                Button btn = new Button();
                btn.Text = $"Mesa {mesa.Numero}";
                btn.Width = 150;
                btn.Height = 180;
                btn.Tag = mesa;
                btn.BackColor = mesa.Ocupada ? Color.LightCoral : Color.LightGreen;
                flowLayoutPanelMesas.Controls.Add(btn);
            }
        }

     

    }
}
