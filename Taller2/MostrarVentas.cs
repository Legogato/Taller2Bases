using MySql.Data.MySqlClient;
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
    public partial class MostrarVentas : Form
    {
        public MostrarVentas()
        {
            InitializeComponent();
        }

        private void botonVenta_Click(object sender, EventArgs e)
        {

        }

        private void MostrarVentas_Load(object sender, EventArgs e)
        {
            string consultaClienteVenta = "SELECT distinct codigoCliente FROM Venta";
            DataTable dtCliente = ConnectMySQL.Instance.SelectQuery(consultaClienteVenta);
            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                comboBoxNombreCliente.Items.Add(dtCliente.Rows[i]["codigoCliente"]);
            }
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consultaFecha = "SELECT distinct Fecha FROM Venta";
     
            DataTable dtCliente = ConnectMySQL.Instance.SelectQuery(consultaFecha);
            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                comboBoxFechas.Items.Add(dtCliente.Rows[i]["fecha"]);
            }

        }

        private void comboBoxFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
