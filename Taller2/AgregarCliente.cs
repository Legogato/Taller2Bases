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
    
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Cliente(ciudad, nombre, pais, tipo) VALUES (@ciudad, @nombre, @pais, @tipo);";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ciudad", ciudadText.Text),
                new MySqlParameter("@nombre", nombreText.Text),
                new MySqlParameter("@pais", paisText.Text),
                new MySqlParameter("@tipo", VerificarNacionalidad())
            };

            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("El Cliente se agrego con exito");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            paisText.Visible = checkBox1.Checked;
            paisText.ResetText();
            paisLabel.Visible = checkBox1.Checked;
            codigoLabel.Visible = !checkBox1.Checked;
            codigoText.Visible = !checkBox1.Checked;
            codigoText.ResetText();
        }

        private string VerificarNacionalidad()
        {
            if(checkBox1.Checked == true)
            {
                return "Extranjero";
            }
            return "Nacional";
        }
  
    }
}
