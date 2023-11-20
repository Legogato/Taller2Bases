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
    public partial class ActualizarProductos : Form
    {
        public ActualizarProductos()
        {
            InitializeComponent();
        }

        private void ActualizarProductos_Load(object sender, EventArgs e){

            //faltan cosas aca
            
            string query = "SELECT nombre  FROM producto";
            DataTable dt = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["nombre"]);
            }

            string consulta = "SELECT * FROM producto";
            DataTable tabla = ConnectMySQL.Instance.SelectQuery(consulta);
            TablaProductos.DataSource = tabla;
        }

        private void TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
