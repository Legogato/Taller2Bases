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
    public partial class Password : Form
    {
        string password = "123";
        string nombreClase;
 
        public Password(string nombreClase)
        {
            InitializeComponent();
            this.nombreClase = nombreClase;
        }


        private void passwordButton_Click(object sender, EventArgs e)
        {
            if(password == passwordBox.Text)
            {
                this.Close();
                if (nombreClase == "producto")
                {
                    Productos productos = new Productos();
                    productos.Show();
                }
                else if (nombreClase == "cliente")
                {
                    Clientes clientes = new Clientes();
                    clientes.Show();
                }
                
                       
            }
            else{
                MessageBox.Show("Contraseña Incorrecta");
                passwordBox.ResetText();
            }
        }

 
    }
}
