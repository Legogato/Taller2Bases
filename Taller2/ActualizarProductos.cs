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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Taller2
{
    public partial class ActualizarProductos : Form
    {
        public ActualizarProductos()
        {
            InitializeComponent();
        }

        private void ActualizarProductos_Load(object sender, EventArgs e)
        {

            //Combo box

            string query = "SELECT codigo FROM producto WHERE activo = 1";
            DataTable dt = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["codigo"]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre, stock, precio FROM producto WHERE Codigo = @Codigo";
            string[] parametros = { "@Codigo", comboBox1.Text};

            DataTable resultados = ConnectMySQL.Instance.SelectQuery(consulta, parametros);

            string nombre = resultados.Rows[0]["nombre"].ToString();
            string stock = resultados.Rows[0]["stock"].ToString();
            string precio = resultados.Rows[0]["precio"].ToString();

            textBoxNombre.Text = nombre;
            textBoxStock.Text = stock;
            textBoxPrecio.Text = precio;

        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" )
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            if (!int.TryParse(textBoxPrecio.Text, out int resultado))
            {
                MessageBox.Show("Ingrese un precio valido");
                return;
            }
            string consulta = "UPDATE producto SET precio = @nuevoPrecio WHERE codigo = @Codigo";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@nuevoPrecio", textBoxPrecio.Text),
                new MySqlParameter("@Codigo", comboBox1.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(consulta, parameters);
            MessageBox.Show("El precio se actualizó con exito");

        }
    }
}