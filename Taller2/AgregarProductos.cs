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
  
            //Verificar nombre del produto 
            if (int.TryParse(textBoxNombre.Text, out int nombre) || string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre valido");
                return;
            }
            //verificar stock y precio
            if(!int.TryParse(textBoxStock.Text, out int resultado) || !int.TryParse(textBoxPrecio.Text, out int resultado2)){
                MessageBox.Show("Ingrese valores numericos");
                return;
            }
     
            string query = "INSERT INTO Producto(stock, nombre, precio, activo) VALUES ( @stock, @nombre, @precio, @activo)";
            MySqlParameter[] parameters =
            {
               
                new MySqlParameter("@stock", textBoxStock.Text),
                new MySqlParameter("@nombre", textBoxNombre.Text),
                new MySqlParameter("@precio", textBoxPrecio.Text),
                new MySqlParameter("@activo", 1)
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("El producto se agrego con exito");
            ConnectMySQL.Instance.CloseConnection();
            this.Close();          
        }

    }
}
