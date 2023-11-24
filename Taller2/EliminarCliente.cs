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
    public partial class EliminarCliente : Form
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void BotonEliminarCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxEliminarCliente.Text == "")
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }
            string consulta = "UPDATE cliente SET activo = 0 WHERE codigo = @codigo";
            MySqlParameter[] parameter = {
                new MySqlParameter("@codigo", comboBoxEliminarCliente.Text)
            };
            ConnectMySQL.Instance.ExecuteQuery(consulta, parameter);
            MessageBox.Show("El Cliente se eliminó con exito");
            this.Close();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            string consultaEliminar = "SELECT codigo, nombre FROM cliente WHERE activo = 1";
            DataTable dtEliminar = ConnectMySQL.Instance.SelectQuery(consultaEliminar);
            for (int i = 0; i < dtEliminar.Rows.Count; i++)
            {
                comboBoxEliminarCliente.Items.Add(dtEliminar.Rows[i]["codigo"]);

            }
        }

        private void comboBoxEliminarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            string consulta = "SELECT nombre, pais, ciudad, tipo FROM cliente WHERE codigo = @codigo";
            string[] parameter2 = { "@codigo", comboBoxEliminarCliente.Text };
            DataTable dt = ConnectMySQL.Instance.SelectQuery(consulta, parameter2);
            dataGridViewCliente.DataSource = dt;
        }
    }
}
