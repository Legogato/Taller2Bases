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
            //string consulta1 = "SELECT nombre ,codigo, precio, stock FROM producto";
            string consulta1 = "SELECT DISTINCT p.Nombre FROM Producto p " +
                "JOIN detallesventa dv ON p.Codigo = dv.CodigoProducto " +
                "JOIN Venta v ON dv.IDVenta = v.IDVenta " +
                "JOIN Cliente c ON v.CodigoCliente = c.Codigo " +
                "WHERE c.tipo = 'Nacional' AND YEAR(V.Fecha) >= YEAR(sysdate()) - 2";

            DataTable dt1 = ConnectMySQL.Instance.SelectQuery(consulta1);
            dataGridViewNacionales.DataSource = dt1;

            string consulta2 = "SELECT DISTINCT p.Nombre FROM Producto p " +
                "JOIN detallesventa dv ON p.Codigo = dv.CodigoProducto " +
                "JOIN Venta v ON dv.IDVenta = v.IDVenta " +
                "JOIN Cliente c ON v.CodigoCliente = c.Codigo " +
                "WHERE c.tipo = 'Extranjero' AND YEAR(v.Fecha) >= YEAR(sysdate()) - 5";
            DataTable dt2 = ConnectMySQL.Instance.SelectQuery(consulta2);
            dataGridViewExtranjeros.DataSource = dt2;

            string consulta3 = "SELECT nombre ,codigo, precio, stock FROM producto";
            DataTable dt3 = ConnectMySQL.Instance.SelectQuery(consulta3);
            dataGridViewActuales.DataSource = dt3;


            string consulta4 = "SELECT DISTINCT p.Nombre FROM Producto p " +
                "JOIN detallesventa dv ON p.Codigo = dv.CodigoProducto " +
                "JOIN Venta v ON dv.IDVenta = v.IDVenta " +
                "JOIN Cliente c ON v.CodigoCliente = c.Codigo " +
                "WHERE c.tipo = 'Extranjero' AND YEAR(v.Fecha) >= YEAR(sysdate()) - 5";
            textBoxExtranjero.Text = "3";
            textBoxNacional.Text = "3";
        }

        private void textBoxNacional_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
