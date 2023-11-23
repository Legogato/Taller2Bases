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
    public partial class EstadisticasProductos : Form
    {
        public EstadisticasProductos()
        {
            InitializeComponent();
        }

        private void EstadisticasProductos_Load(object sender, EventArgs e)
        {
            string consulta1 = "SELECT nombre ,codigo, precio, stock FROM producto";
            DataTable dt1 = ConnectMySQL.Instance.SelectQuery(consulta1);
            dataGridViewExtranjeros.DataSource = dt1;

            string consulta2 = "SELECT nombre ,codigo, precio, stock FROM producto";
            DataTable dt2 = ConnectMySQL.Instance.SelectQuery(consulta2);
            dataGridViewNacionales.DataSource = dt2;

            string consulta3 = "SELECT nombre ,codigo, precio, stock FROM producto";
            DataTable dt3 = ConnectMySQL.Instance.SelectQuery(consulta3);
            dataGridViewActuales.DataSource = dt3;

            textBoxExtranjero.Text = "3";
            textBoxNacional.Text = "3";
        }
    }
}
