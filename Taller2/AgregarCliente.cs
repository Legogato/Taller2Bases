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
            //Verificar nombre del Cliente y ciudad
            if (int.TryParse(nombreText.Text, out int nombre) || string.IsNullOrWhiteSpace(nombreText.Text) ||
                int.TryParse(ciudadText.Text, out int ciudad) || string.IsNullOrWhiteSpace(ciudadText.Text))
            {
                MessageBox.Show("Verifique que el nombre y la ciudad estén correctos");
                return;
            }
            //Verificar pais si es extranjero y codigo si es nacional
            if (checkBox1.Checked)
            {
                if (int.TryParse(paisText.Text, out int pais) || string.IsNullOrWhiteSpace(paisText.Text))
                {
                    MessageBox.Show("Verifique que el pais esté correcto");
                    return;
                }
            }
            else
            {
                if (!int.TryParse(codigoText.Text, out int codigo))
                {
                    MessageBox.Show("Ingrese valores numericos para el codigo");
                    return;
                }
            }

            string query = "INSERT INTO Cliente(ciudad, nombre, pais, tipo, activo) VALUES (@ciudad, @nombre, @pais, @tipo, @activo);";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ciudad", ciudadText.Text),
                new MySqlParameter("@nombre", nombreText.Text),
                new MySqlParameter("@pais", VerficarPais()),
                new MySqlParameter("@tipo", VerificarNacionalidad()),
                new MySqlParameter("@activo", 1)
            };


            ConnectMySQL.Instance.ExecuteQuery(query, parameters);
            MessageBox.Show("El Cliente se agrego con exito");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            paisText.Enabled = checkBox1.Checked;
            paisText.ResetText();
            codigoText.Enabled = !checkBox1.Checked;
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

        private string VerficarPais()
        {
            if (checkBox1.Checked == true)
            {
                return paisText.Text;
            }
            return "Chile";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void paisText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
