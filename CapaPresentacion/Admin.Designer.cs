namespace CapaPresentacion
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txttipousuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarEdificios = new System.Windows.Forms.Button();
            this.txtaulas = new System.Windows.Forms.TextBox();
            this.txtedificios = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pbimagen = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbedificio = new System.Windows.Forms.ComboBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.btneliminar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-5, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 633);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGuardarUsuario);
            this.tabPage1.Controls.Add(this.txttipousuario);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtfechanacimiento);
            this.tabPage1.Controls.Add(this.txtcontrasena);
            this.tabPage1.Controls.Add(this.txtusuario);
            this.tabPage1.Controls.Add(this.txtapellido);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registar Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(340, 352);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(105, 39);
            this.btnGuardarUsuario.TabIndex = 12;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // txttipousuario
            // 
            this.txttipousuario.Location = new System.Drawing.Point(130, 308);
            this.txttipousuario.Name = "txttipousuario";
            this.txttipousuario.Size = new System.Drawing.Size(100, 22);
            this.txttipousuario.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de usuario";
            // 
            // dtfechanacimiento
            // 
            this.dtfechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfechanacimiento.Location = new System.Drawing.Point(130, 149);
            this.dtfechanacimiento.Name = "dtfechanacimiento";
            this.dtfechanacimiento.Size = new System.Drawing.Size(100, 22);
            this.dtfechanacimiento.TabIndex = 9;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(130, 257);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(100, 22);
            this.txtcontrasena.TabIndex = 8;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(130, 199);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 22);
            this.txtusuario.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(130, 104);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 22);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(130, 59);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contrasena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarEdificios);
            this.tabPage2.Controls.Add(this.txtaulas);
            this.tabPage2.Controls.Add(this.txtedificios);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Edificio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEdificios
            // 
            this.btnGuardarEdificios.Location = new System.Drawing.Point(289, 306);
            this.btnGuardarEdificios.Name = "btnGuardarEdificios";
            this.btnGuardarEdificios.Size = new System.Drawing.Size(99, 36);
            this.btnGuardarEdificios.TabIndex = 4;
            this.btnGuardarEdificios.Text = "Guardar";
            this.btnGuardarEdificios.UseVisualStyleBackColor = true;
            this.btnGuardarEdificios.Click += new System.EventHandler(this.btnGuardarEdificios_Click);
            // 
            // txtaulas
            // 
            this.txtaulas.Location = new System.Drawing.Point(122, 135);
            this.txtaulas.Name = "txtaulas";
            this.txtaulas.Size = new System.Drawing.Size(100, 22);
            this.txtaulas.TabIndex = 3;
            // 
            // txtedificios
            // 
            this.txtedificios.Location = new System.Drawing.Point(122, 74);
            this.txtedificios.Name = "txtedificios";
            this.txtedificios.Size = new System.Drawing.Size(100, 22);
            this.txtedificios.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Aulas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Edificios";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btneliminar);
            this.tabPage3.Controls.Add(this.pbimagen);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cbedificio);
            this.tabPage3.Controls.Add(this.lbltotal);
            this.tabPage3.Controls.Add(this.datalistado);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1176, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consulta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbimagen
            // 
            this.pbimagen.Location = new System.Drawing.Point(836, 167);
            this.pbimagen.Name = "pbimagen";
            this.pbimagen.Size = new System.Drawing.Size(316, 363);
            this.pbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimagen.TabIndex = 5;
            this.pbimagen.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Seleccione el edificio";
            // 
            // cbedificio
            // 
            this.cbedificio.FormattingEnabled = true;
            this.cbedificio.Location = new System.Drawing.Point(154, 34);
            this.cbedificio.Name = "cbedificio";
            this.cbedificio.Size = new System.Drawing.Size(121, 24);
            this.cbedificio.TabIndex = 2;
            this.cbedificio.SelectedIndexChanged += new System.EventHandler(this.cbedificio_SelectedIndexChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(496, 63);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 16);
            this.lbltotal.TabIndex = 1;
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(13, 82);
            this.datalistado.Name = "datalistado";
            this.datalistado.ReadOnly = true;
            this.datalistado.RowHeadersWidth = 51;
            this.datalistado.RowTemplate.Height = 24;
            this.datalistado.Size = new System.Drawing.Size(788, 494);
            this.datalistado.TabIndex = 0;
            this.datalistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(968, 553);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.TextBox txttipousuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtfechanacimiento;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarEdificios;
        private System.Windows.Forms.TextBox txtaulas;
        private System.Windows.Forms.TextBox txtedificios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbedificio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbimagen;
        private System.Windows.Forms.Button btneliminar;
    }
}