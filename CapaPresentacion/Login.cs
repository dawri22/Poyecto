using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rpta = "";

            rpta = NDatos.iniciarsesion(txtusuario.Text, txtcontrasena.Text);
            
            if(rpta.Equals("general"))
            {
                Visita visita = new Visita();
                visita.Show();
                this.Hide();
            }
            else if(rpta.Equals("admin"))
            {
                Admin admin = new Admin();
                Login login = new Login();
                login.Close();
                admin.Show();

            }
            else if (rpta.Equals("no"))
            {
                MessageBox.Show("Usuario y/o Contrasena incorrecta");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucultar()
        {
            txtcontrasena.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ucultar();
        }
    }
}
