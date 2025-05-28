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
    public partial class FormBase: Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarClientes mostrarClientes = new MostrarClientes();
            mostrarClientes.Show();
            if (!(this is Form1))
            {
                this.Close();
            }
            else
            {
                this.Hide();
            }
            
        }
    }
}
