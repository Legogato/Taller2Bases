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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            AgregarProductos agregarProductos = new AgregarProductos();
            agregarProductos.Show();

        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {

            ActualizarProductos actualizar = new ActualizarProductos();
            actualizar.Show();

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto eliminarProducto = new EliminarProducto();
            eliminarProducto.Show();

        }
    }
}
