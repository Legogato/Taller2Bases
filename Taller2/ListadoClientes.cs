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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            string consulta1 = "SELECT codigo ,nombre, pais, ciudad, tipo FROM cliente WHERE tipo = \"Extranjero\"";
            DataTable dt1 = ConnectMySQL.Instance.SelectQuery(consulta1);
            dataGridViewExtranjeros.DataSource = dt1;

            string consulta2 = "SELECT codigo ,nombre, pais, ciudad, tipo FROM cliente WHERE tipo = \"Nacional\"";
            DataTable dt2 = ConnectMySQL.Instance.SelectQuery(consulta2);
            dataGridViewNacionales.DataSource = dt2;

            string consulta3 = "SELECT codigo ,nombre, pais, ciudad, tipo FROM cliente";
            DataTable dt3 = ConnectMySQL.Instance.SelectQuery(consulta3);
            dataGridViewTodos.DataSource = dt3;
        }
    }
}
