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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            string consultaEliminar = "SELECT codigo, nombre FROM producto WHERE activo = 1";
            DataTable dtEliminar = ConnectMySQL.Instance.SelectQuery(consultaEliminar);
            for (int i = 0; i < dtEliminar.Rows.Count; i++)
            {
                comboBoxEliminarProducto.Items.Add(dtEliminar.Rows[i]["codigo"]);
                
            }
        }
        private void comboBoxEliminarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            string consulta = "SELECT nombre, precio, stock FROM producto WHERE codigo = @codigo";
            string[] parameter2 = { "@codigo", comboBoxEliminarProducto.Text };
            DataTable dt = ConnectMySQL.Instance.SelectQuery(consulta, parameter2);
            dataGridViewProducto.DataSource = dt;
        }


        private void BotonEliminarProducto_Click_1(object sender, EventArgs e)
        {
            if (comboBoxEliminarProducto.Text == "")
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            string consulta = "UPDATE producto SET activo = 0 WHERE codigo = @codigo";
            MySqlParameter[] parameter = {
                new MySqlParameter("@codigo", comboBoxEliminarProducto.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(consulta, parameter);
            MessageBox.Show("El producto se eliminó con exito");


            ConnectMySQL.Instance.CloseConnection();

            this.Close();

        }
    }
}
