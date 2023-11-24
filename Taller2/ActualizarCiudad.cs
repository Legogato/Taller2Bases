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
    public partial class ActualizarCiudad : Form
    {
        public ActualizarCiudad()
        {
            InitializeComponent();
        }

        private void ActualizarCiudad_Load(object sender, EventArgs e)
        {
            //Combo box

            string consulta = "SELECT codigo FROM cliente WHERE activo = 1 and tipo = \"Extranjero\"";
            DataTable dt = ConnectMySQL.Instance.SelectQuery(consulta);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxActualizarCiudad.Items.Add(dt.Rows[i]["codigo"]);
            }
        }

        private void comboBoxActualizarCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string consulta = "SELECT nombre, ciudad, tipo FROM cliente WHERE codigo = @Codigo";
                string[] parametros = { "@Codigo", comboBoxActualizarCiudad.Text };

                DataTable resultados = ConnectMySQL.Instance.SelectQuery(consulta, parametros);

                string nombre = resultados.Rows[0]["nombre"].ToString();
                string ciudad = resultados.Rows[0]["ciudad"].ToString();
                string tipo = resultados.Rows[0]["tipo"].ToString();

                textBoxNombre.Text = nombre;
                textBoxTipo.Text = tipo;
                textBoxCiudad.Text = ciudad;

        }

        private void botonActualizarCiudad_Click(object sender, EventArgs e)
        {
            if (comboBoxActualizarCiudad.Text == "")
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }
            if (int.TryParse(textBoxCiudad.Text, out int ciudad) || string.IsNullOrWhiteSpace(textBoxCiudad.Text))
            {
                MessageBox.Show("Ingrese una ciudad valida");
                return;
            }
            string consulta = "UPDATE cliente SET ciudad = @nuevaCiudad WHERE codigo = @Codigo";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@nuevaCiudad", textBoxCiudad.Text),
                new MySqlParameter("@Codigo", comboBoxActualizarCiudad.Text)
            };

            ConnectMySQL.Instance.ExecuteQuery(consulta, parameters);
            MessageBox.Show("La ciudad se actualizó con exito");
            this.Close();
        }
    }
}
