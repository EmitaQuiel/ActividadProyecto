using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ActividadProyecto
{
    public partial class FormAnadir : Form
    {
        
        public FormAnadir()
        {
            InitializeComponent();
            
        }

        public string cedula { get; set; }
        public struct Datos
        {
           public string cedula, nombre, tipoid, genero, apellido, carrera, numtlf, email, sede, monto;
            
        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=actividadproyecto;UID=root;PASSWORDS=;";
        MySqlConnection conexionsql = new MySqlConnection(conexion);
        
        
        private void guna2Button1_Click(object sender, EventArgs e)
       {
            
            conexionsql.Open();
            string insertar = " INSERT INTO estudiantes(cedula,nombre,apellido,numtlf,tipoid,email,genero,carrera,sede)values(@cedula,@nombre,@apellido,@numtlf,@tipoid,@email,@genero,@carrera,@sede)";
            MySqlCommand cmd = new MySqlCommand(insertar,conexionsql);
            
            cmd.Parameters.AddWithValue("@cedula", txtcedula.Text);
            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@apellido", txtapellido1.Text);
            cmd.Parameters.AddWithValue("@numtlf", txttelefono.Text);
            cmd.Parameters.AddWithValue("@tipoid", comboid.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@sede", combosede.Text);
            if (chkmasculino.Checked)
            {
                cmd.Parameters.AddWithValue("@genero", chkmasculino.Text);
            }

            if (chkfemenino.Checked)
            {
                cmd.Parameters.AddWithValue("@genero", chkfemenino.Text);
            }

            if (chkcomunicacion.Checked)
            {
                cmd.Parameters.AddWithValue("@carrera", chkcomunicacion.Text);
            }

            if (chkIng.Checked)
            {
                cmd.Parameters.AddWithValue("@carrera", chkIng.Text);
            }

            if (chkPsicologia.Checked)
            {
                cmd.Parameters.AddWithValue("@carrera", chkPsicologia.Text);
            }

            if (chkedu.Checked)
            {
                cmd.Parameters.AddWithValue("@carrera", chkedu.Text);
            }

            FormBuscar objbuscar = new FormBuscar(txtcedula.Text);
            

            cmd.ExecuteNonQuery();          

            Datos info = new Datos();
            cedula = txtcedula.Text;
            info.cedula = txtcedula.Text;
            info.nombre = txtnombre.Text;
            info.tipoid = comboid.SelectedItem.ToString();
            info.genero = (chkmasculino.Checked) ? "Masculino" : ((chkfemenino.Checked) ? "Femenino" : "");
            info.apellido = txtapellido1.Text;
            info.carrera = (chkPsicologia.Checked) ? "Psicología" : ((chkIng.Checked) ? "Ingeniería" : ((chkedu.Checked) ? "Educación" : ((chkcomunicacion.Checked) ? "Comunicacion": "")));
            info.numtlf = txttelefono.Text;
            info.email = txtemail.Text;
            info.sede = combosede.SelectedItem.ToString();

            string identificador = txtcedula.Text;
            FormAlumnos obj = new FormAlumnos(info);
            FormIngenieria objing = new FormIngenieria(identificador);

            FormEliminar formEliminar = new FormEliminar(identificador);
            formEliminar.TopLevel = false;
            formEliminar.FormBorderStyle = FormBorderStyle.None;
            formEliminar.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(formEliminar);
            this.Parent.Tag = formEliminar;
            

            Class2.ListaEstudiantes.Add(info);

            if (chkedu.Checked)
            {
                
                formmaterias formmaterias = new formmaterias(identificador);
                formmaterias.TopLevel = false;
                formmaterias.FormBorderStyle = FormBorderStyle.None;
                formmaterias.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(formmaterias);
                this.Parent.Tag = formmaterias;
                formmaterias.BringToFront();
                formmaterias.Show();
            }
            if (chkIng.Checked)
            {
                FormIngenieria forming = new FormIngenieria(identificador);
                forming.TopLevel = false;
                forming.FormBorderStyle = FormBorderStyle.None;
                forming.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(forming);
                this.Parent.Tag = forming;
                forming.BringToFront();
                forming.Show();
            }

            if (chkPsicologia.Checked)
            {
                FormPsicologia Formpsicologiacs = new FormPsicologia(identificador);
                Formpsicologiacs.TopLevel = false;
                Formpsicologiacs.FormBorderStyle = FormBorderStyle.None;
                Formpsicologiacs.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(Formpsicologiacs);
                this.Parent.Tag = Formpsicologiacs;
                Formpsicologiacs.BringToFront();
                Formpsicologiacs.Show();
            }
            if (chkcomunicacion.Checked)
            {
                FormComunicacion formComunicacion = new FormComunicacion(identificador);
                formComunicacion.TopLevel = false;
                formComunicacion.FormBorderStyle = FormBorderStyle.None;
                formComunicacion.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(formComunicacion);
                this.Parent.Tag = formComunicacion;
                formComunicacion.BringToFront();
                formComunicacion.Show();
            }

        }

        private void chkmasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmasculino.Checked)
            {
                chkfemenino.Checked = false;
            }
            
        }
        private void chkfemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfemenino.Checked)
            {
                chkmasculino.Checked = false;
            }
        }

        private void chkPsicologia_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPsicologia.Checked)
            {
                chkedu.Checked = false;
                chkIng.Checked = false;
                chkcomunicacion.Checked = false;
            }
        }

        private void chkIng_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIng.Checked)
            {
                chkedu.Checked = false;
                chkPsicologia.Checked = false;
                chkcomunicacion.Checked = false;
            }
        }

        private void chkedu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkedu.Checked)
            {
                chkIng.Checked = false;
                chkPsicologia.Checked = false;
                chkcomunicacion.Checked = false;
            }

        }

        private void FormAnadir_Closed (object sender, FormClosedEventArgs e)
        {
            conexionsql.Close();
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAnadir_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcomunicacion.Checked)
            {
                chkIng.Checked = false;
                chkPsicologia.Checked = false;
                chkedu.Checked = false;
            }
        }
    }
}
