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
            Password password = new Password("producto");

            // Mostrar el segundo formulario
            password.Show();
        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            Password password = new Password("cliente");

            // Mostrar el segundo formulario
            password.Show();
        }
    }
}
