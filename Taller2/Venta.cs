using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Venta : Form
    {
        int precio;
        int stock;
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = System.DateTime.Now;

            //Busca el cliente

            string consultaClienteVenta = "SELECT codigo, nombre FROM cliente WHERE activo = 1";
            DataTable dtCliente = ConnectMySQL.Instance.SelectQuery(consultaClienteVenta);
            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                comboBoxNombreCliente.Items.Add(dtCliente.Rows[i]["codigo"]);
            }

            //Busca el producto

            string consultaProductoVenta = "SELECT codigo, nombre, stock FROM producto WHERE activo = 1";
            DataTable dtProducto = ConnectMySQL.Instance.SelectQuery(consultaProductoVenta);
            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                comboBoxProductoVenta.Items.Add(dtProducto.Rows[i]["codigo"]);
            }
            
            
        }

        private void botonVenta_Click(object sender, EventArgs e)
        {

            numericUpDownCantidad.Maximum = this.stock;

            //ingresa la venta

            string query = "INSERT INTO Venta (Fecha, CodigoCliente, MontoTotal) VALUES (@fecha, @CodigoCliente, @Montototal);";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@fecha", dateTimePicker1.Value),
                new MySqlParameter("@CodigoCliente",comboBoxNombreCliente.Text),
                new MySqlParameter("@Montototal", this.precio*numericUpDownCantidad.Value)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("La venta se agregó con exito");

            //Consulta para obtener la ID

            string consultaID = "SELECT LAST_INSERT_ID()+1 AS IDVenta";
            DataTable resultados = ConnectMySQL.Instance.SelectQuery(consultaID);
            string IDVenta = resultados.Rows[0]["IDVenta"].ToString();

            //Agrega a el detallesVenta

            string query2 = "INSERT INTO detallesventa (IDVenta, CodigoProducto, Cantidad, PrecioUnitarioProducto) VALUES (@IDVenta, @CodigoProducto, @Cantidad, @PrecioUnitarioProducto);";
            MySqlParameter[] parameters2 =
            {
                new MySqlParameter("@IDVenta", IDVenta),
                new MySqlParameter("@CodigoProducto", comboBoxProductoVenta.Text),
                new MySqlParameter("@Cantidad", numericUpDownCantidad.Value),
                new MySqlParameter("@PrecioUnitarioProducto", precio),
            };

            ConnectMySQL.Instance.ExecuteQuery(query2, parameters2);
        }

        private void comboBoxProductoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Consigue el stock y el precio

            string consulta = "SELECT stock, precio FROM producto WHERE codigo = @Codigo";
            string[] parametros = { "@Codigo", comboBoxProductoVenta.Text };

            DataTable resultados = ConnectMySQL.Instance.SelectQuery(consulta, parametros);

            string stockAux = resultados.Rows[0]["stock"].ToString();
            string precioAUX = resultados.Rows[0]["precio"].ToString();
            int stock = int.Parse(stockAux);
            int precio = int.Parse(precioAUX);

            setPrecio(precio);
            setStock(stock);
            
        }

        private void setPrecio(int precio)
        {
            this.precio = precio;
        }

        private void setStock(int stock)
        {
            this.stock = stock;
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Consigue el codigo del cliente

            string consulta2 = "SELECT codigo FROM cliente WHERE codigo = @Codigo";
            string[] parametros2 = { "@Codigo", comboBoxNombreCliente.Text };

            DataTable resultados2 = ConnectMySQL.Instance.SelectQuery(consulta2, parametros2);

            string codigoCliente = resultados2.Rows[0]["codigo"].ToString();

        }
    }
}
