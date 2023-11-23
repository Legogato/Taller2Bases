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

        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            //Busca el cliente

            string consultaClienteVenta = "SELECT codigo, nombre FROM cliente WHERE activo = 1";
            DataTable dtCliente = ConnectMySQL.Instance.SelectQuery(consultaClienteVenta);
            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                comboBoxNombreCliente.Items.Add(dtCliente.Rows[i]["codigo"] + " Nombre: " + dtCliente.Rows[i]["nombre"]);
            }

            //Busca el producto

            string consultaProductoVenta = "SELECT codigo, nombre, stock FROM producto WHERE activo = 1";
            DataTable dtProducto = ConnectMySQL.Instance.SelectQuery(consultaProductoVenta);
            for (int i = 0; i < dtProducto.Rows.Count; i++)
            {
                comboBoxProductoVenta.Items.Add(dtProducto.Rows[i]["codigo"] + " Nombre: " + dtProducto.Rows[i]["nombre"]);
            }
            
            

        }

        private void botonVenta_Click(object sender, EventArgs e)
        {

            //Consigue el stock y el precio

            string consulta = "SELECT stock, precio FROM producto WHERE codigo = @Codigo";
            string[] parametros = { "@Codigo", comboBoxProductoVenta.Text };

            DataTable resultados = ConnectMySQL.Instance.SelectQuery(consulta, parametros);

            string stokAux = resultados.Rows[0]["stock"].ToString();
            string precioAUX = resultados.Rows[0]["precio"].ToString();
            int stock = int.Parse(stokAux);
            int precio = int.Parse(precioAUX);

            //Consigue el codigo del cliente

            string consulta2 = "SELECT codigo FROM cliente WHERE codigo = @Codigo";
            string[] parametros2 = { "@Codigo", comboBoxNombreCliente.Text };

            DataTable resultados2 = ConnectMySQL.Instance.SelectQuery(consulta2, parametros2);

            string codigoAux = resultados2.Rows[0]["codigo"].ToString();
            int codigo = int.Parse(codigoAux);

            //validaciones

            numericUpDownCantidad.Maximum = stock;

            dateTimePicker1.MaxDate = System.DateTime.Now;

            string query = "INSERT INTO Venta(fecha, monto, Clientecodigo) VALUES (@fecha, @monto, @Clientecodigo);";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@fecha", "2002-02-01"),
                new MySqlParameter("@monto", precio*numericUpDownCantidad.Value),
                new MySqlParameter("@Clientecodigo", codigo)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("La venta se agregó con exito");
        }

        private void comboBoxProductoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
