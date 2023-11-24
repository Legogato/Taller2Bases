using MySqlX.XDevAPI;
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
            //Ventas nacionales en los ultimos 2 años
            string consulta1 = "SELECT DISTINCT p.Nombre FROM Producto p " +
                "JOIN detallesventa dv ON p.Codigo = dv.CodigoProducto " +
                "JOIN Venta v ON dv.IDVenta = v.IDVenta " +
                "JOIN Cliente c ON v.CodigoCliente = c.Codigo " +
                "WHERE c.tipo = 'Nacional' AND YEAR(V.Fecha) >= YEAR(sysdate()) - 2";

            DataTable dt1 = ConnectMySQL.Instance.SelectQuery(consulta1);
            dataGridViewNacionales.DataSource = dt1;
            //ventas extranjeras en los ultimos 5 años
            string consulta2 = "SELECT DISTINCT p.Nombre FROM Producto p " +
                "JOIN detallesventa dv ON p.Codigo = dv.CodigoProducto " +
                "JOIN Venta v ON dv.IDVenta = v.IDVenta " +
                "JOIN Cliente c ON v.CodigoCliente = c.Codigo " +
                "WHERE c.tipo = 'Extranjero' AND YEAR(v.Fecha) >= YEAR(sysdate()) - 5";
            DataTable dt2 = ConnectMySQL.Instance.SelectQuery(consulta2);
            dataGridViewExtranjeros.DataSource = dt2;
            //Todos los productos
            string consulta3 = "SELECT nombre ,codigo, precio, stock FROM producto WHERE activo = 1";
            DataTable dt3 = ConnectMySQL.Instance.SelectQuery(consulta3);
            dataGridViewActuales.DataSource = dt3;

            //Cantidad de productos vendidos este año en el pais
            string consulta4 = "select SUM(dv.Cantidad) as cantidad " +
                "from detallesventa dv, cliente c, venta v where c.tipo = \"Nacional\" " +
                "and dv.IDVenta = v.IDVenta and v.CodigoCliente = c.codigo and " +
                "YEAR(V.Fecha) = YEAR(sysdate())";
            DataTable dt4 = ConnectMySQL.Instance.SelectQuery(consulta4);
            textBoxNacional.Text = dt4.Rows[0]["cantidad"].ToString();

            //Cantidad de prodcutos vendidos en el extranjero el año pasado
            string consulta5 = "select SUM(dv.Cantidad) as cantidad " +
                "from detallesventa dv, cliente c, venta v where c.tipo = \"Extranjero\" " +
                "and dv.IDVenta = v.IDVenta and v.CodigoCliente = c.codigo and " +
                "YEAR(V.Fecha) = YEAR(sysdate())-1";
            DataTable dt5 = ConnectMySQL.Instance.SelectQuery(consulta5);
            textBoxExtranjero.Text = dt5.Rows[0]["cantidad"].ToString();

        }

        private void textBoxNacional_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
