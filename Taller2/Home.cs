using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del segundo formulario
            Productos productos = new Productos();

            // Mostrar el segundo formulario
            productos.Show();
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
             Clientes clientes = new Clientes();

            clientes.Show();
        }
    }
}
