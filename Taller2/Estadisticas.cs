using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void botonListaClientes_Click(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.Show();
        }

        private void botonListadoProductos_Click(object sender, EventArgs e)
        {
            EstadisticasProductos estadisticasProductos = new EstadisticasProductos();
            estadisticasProductos.Show();
        }

        private void botonVentas_Click(object sender, EventArgs e)
        {
            MostrarVentas mostrarVentas = new MostrarVentas();  
            mostrarVentas.Show();
        }
    }
}
