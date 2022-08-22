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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            mostrardatos();
            cargarcomboedificio();
           
        }


        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Proyecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cargarcomboedificio()
        {
            this.cbedificio.DataSource = NDatos.mostrardatocomboedificio();
            this.cbedificio.DisplayMember = "Edificio";
            this.cbedificio.ValueMember = "Idedificio";
        }



        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                rpta = NDatos.insertardatousuario(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(), this.dtfechanacimiento.Value, this.txtusuario.Text.Trim().ToUpper(), this.txtcontrasena.Text.Trim().ToUpper(), this.txttipousuario.Text.Trim().ToUpper());

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("se inserto el Usuario satisfactoriamente");
                    

                }
                else
                {
                    this.mensajeerror(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            limpiar();
        }

        private void btnGuardarEdificios_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";

                rpta = NDatos.insertardatoedificios(this.txtedificios.Text.Trim().ToUpper(), this.txtaulas.Text.Trim().ToUpper());

                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("se inserto el Edificio satisfactoriamente");


                }
                else
                {
                    this.mensajeerror(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            limpiar();
            cargarcomboedificio();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(datalistado.Rows[e.RowIndex].Cells["idestudiantes"].FormattedValue);
            Bitmap bm;
            bm = NDatos.mostarimagen(id);
            pbimagen.Image = bm;
        }

        private void limpiar()
        {
            this.txtnombre.Text = String.Empty;
            this.txtapellido.Text = String.Empty;
            this.txtcontrasena.Text = String.Empty;
            this.txttipousuario.Text = String.Empty;
            this.txtusuario.Text = String.Empty;
            this.txtaulas.Text = String.Empty;
            this.txtedificios.Text = String.Empty;
        }

        private void mostrardatos()
        {
            this.datalistado.DataSource = NDatos.mostrardato();
            this.lbltotal.Text = "la cantidad total de visitantes es :" + Convert.ToString(datalistado.Rows.Count - 1);
        }

        private void mostrareificio()
        {
            this.datalistado.DataSource = NDatos.mostraredificio(cbedificio.Text);
            this.lbltotal.Text = "la cantidad total de visitantes es este edificio son:" + Convert.ToString(datalistado.Rows.Count - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mostrareificio();
        }

        private void cbedificio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
