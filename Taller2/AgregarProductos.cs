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
using Taller2;

namespace Taller2
{
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Producto(codigo, stock, nombre, precio) VALUES (@codigo, @stock, @nombre, @precio)";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@codigo", textBox4.Text),
                new MySqlParameter("@stock", textBox5.Text),
                new MySqlParameter("@nombre", textBox6.Text),
                new MySqlParameter("@precio", textBox7.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("El producto se agrego con exito");
            this.Close();          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
