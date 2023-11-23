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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void BotonEliminarCliente_Click(object sender, EventArgs e)
        {
            string consulta = "UPDATE producto SET activo = 0 WHERE codigo = @codigo";
            MySqlParameter[] parameter = {
                new MySqlParameter("@codigo", comboBoxEliminarProducto.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(consulta, parameter);
            MessageBox.Show("El producto se eliminó con exito");
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            string consultaEliminar = "SELECT codigo FROM producto WHERE activo = 1";
            DataTable dtEliminar = ConnectMySQL.Instance.SelectQuery(consultaEliminar);
            for (int i = 0; i < dtEliminar.Rows.Count; i++)
            {
                comboBoxEliminarProducto.Items.Add(dtEliminar.Rows[i]["codigo"]);
            }
        }

        private void comboBoxEliminarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = "SELECT nombre FROM producto WHERE codigo = @codigo";
            string[] parameter = { "@codigo", comboBoxEliminarProducto.Text };
            string nombre = ConnectMySQL.Instance.SelectQueryScalar(consulta, parameter);
            textBoxEliminarProducto.Text = nombre;

            consulta = "SELECT stock, precio FROM producto WHERE codigo = @codigo";
            string[] parameter2 = { "@codigo", comboBoxEliminarProducto.Text };
            DataTable dt = ConnectMySQL.Instance.SelectQuery(consulta, parameter2);
            dataGridViewProducto.DataSource = dt;
        }
    }
}
