using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Visita : Form
    {
        public Visita()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            this.txtnombre.Text = String.Empty;
            this.txtapellido.Text = String.Empty;
            this.txtcarrera.Text = String.Empty;
            this.txtcorreo.Text = String.Empty;
            this.txtvisita.Text = String.Empty;
            this.txtlugar.Text = String.Empty;
            this.pbimagen = null;
        }
        private void cargarcomboedificio()
        {
            this.cbedificio.DataSource = NDatos.mostrardatocomboedificio();
            this.cbedificio.DisplayMember = "Edificio";
            this.cbedificio.ValueMember = "Idedificio";
        }

        private void cargarcomboaula()
        {
            this.cbaulas.DataSource = NDatos.mostrardatocomboaula();
            this.cbaulas.DisplayMember = "Aulas";
            this.cbaulas.ValueMember = "Idedificio";
        }

        private void Visita_Load(object sender, EventArgs e)
        {
            cargarcomboedificio();
            cargarcomboaula();
        }

        private void btnguardarvisitas_Click(object sender, EventArgs e)
        {
            string rpta = "";
            MemoryStream ms = new MemoryStream();
            pbimagen.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();
            
            rpta = NDatos.insertardatoestudiante(txtnombre.Text, txtapellido.Text ,txtcarrera.Text ,txtcorreo.Text, cbedificio.Text, cbaulas.Text, dthoraentrada.Value, dthorasalida.Value, txtvisita.Text, aByte ,txtlugar.Text);

            if (rpta.Equals("OK"))
            {
                MessageBox.Show("datos insertados");
                
            }
            else
            {
                MessageBox.Show("No insertados");
            }
            limpiar();

        }

        private void seleccionfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagenes|*.jpg; *.png";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Title = "Seleccionar Imagen";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbimagen.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
