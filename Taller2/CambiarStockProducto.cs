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
    public partial class CambiarStockProducto : Form
    {
        public CambiarStockProducto()
        {
            InitializeComponent();
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            if (!int.TryParse(textBoxStock.Text, out int resultado))
            {
                MessageBox.Show("Ingrese un stock valido");
                return;
            }
            int stockActual = int.Parse(textBoxStockActual.Text);
            int stockAnterior = int.Parse(textBoxStock.Text);
            string consulta = "UPDATE producto SET stock = @nuevoStock WHERE codigo = @Codigo";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@nuevoStock", stockAnterior+stockActual),
                new MySqlParameter("@Codigo", comboBox1.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(consulta, parameters);
            MessageBox.Show("El stock se actualizó con exito");
            this.Close();
        
        }
        

        private void textBoxStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre, stock, precio FROM producto WHERE Codigo = @Codigo";
            string[] parametros = { "@Codigo", comboBox1.Text };

            DataTable resultados = ConnectMySQL.Instance.SelectQuery(consulta, parametros);

            string nombre = resultados.Rows[0]["nombre"].ToString();
            string stock = resultados.Rows[0]["stock"].ToString();
            string precio = resultados.Rows[0]["precio"].ToString();

            textBoxNombre.Text = nombre;
            textBoxStockActual.Text = stock;
            textBoxPrecio.Text = precio;
        }

        private void CambiarStockProducto_Load(object sender, EventArgs e)
        {
            string query = "SELECT codigo FROM producto WHERE activo = 1";
            DataTable dt = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["codigo"]);
            }
        }
    }
}
