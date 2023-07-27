using DevExpress.XtraTab.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActividadProyecto
{
    public partial class formmaterias : Form
    {
        private string identificadorvariable;
        private int montototal = 0;
        private string materiassql;
        public formmaterias()
        {
            InitializeComponent();

        }

        public formmaterias(string identificador)
            : this()
        {
            identificadorvariable = identificador;
        }

        public struct Datos3
        {
            public int marcaseducacion;
        }
        public struct DatosCheckEducacion
        {
            public string checkeducacion;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Datos3 materiaseducacion;
            materiaseducacion.marcaseducacion = 0;

            DatosCheckEducacion materiascheckeducacion;
            materiascheckeducacion = new DatosCheckEducacion();


            if (chkoral.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Comunicación Oral Y Escrita\n";
                materiascheckeducacion.checkeducacion += "• Comunicación Oral Y Escrita\n";
            }

            if (chkpedagogia.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Introducción A La Pedagogía\n";
                materiascheckeducacion.checkeducacion += "• Introducción A La Pedagogía\n";
            }

            if (chklenguaje.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Lenguaje Y Comunicación I\n";
                materiascheckeducacion.checkeducacion += "• Lenguaje Y Comunicación I\n";
            }

            if (chkespanola.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Sintaxis Española\n";
                materiascheckeducacion.checkeducacion += "• Sintaxis Española\n";
            }

            if (chkinvestigacion.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Metodología De La Investigación\n";
                materiascheckeducacion.checkeducacion += "• Metodología De La Investigación\n";
            }

            if (chklenguajell.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Lenguaje Y Comunicación II\n";
                materiascheckeducacion.checkeducacion += "• Lenguaje Y Comunicación II\n";
            }

            if (chkteoria.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Teoría Literaria\n";
                materiascheckeducacion.checkeducacion += "• Teoría Literaria\n";
            }

            if (chkcomunicacion.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Lenguaje Y Comunicación III\n";
                materiascheckeducacion.checkeducacion += "• Lenguaje Y Comunicación III\n";
            }

            if (chkcosta.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Literatura Costarricense I\n";
                materiascheckeducacion.checkeducacion += "• Literatura Costarricense I\n";
            }

            if (chkhispa.Checked)
            {
                montototal += 25000;
                materiaseducacion.marcaseducacion += 25000;
                materiassql += "• Literatura Hispanoamericana I\n";
                materiascheckeducacion.checkeducacion += "• Literatura Hispanoamericana I\n";
            }

            FormMontos objedu = new FormMontos(materiaseducacion);
            Class2.ListaEducacion.Add(materiaseducacion);

            FormCursos objcheckeducacion = new FormCursos(materiascheckeducacion);
            Class2.ListaCheckEducacion.Add(materiascheckeducacion);

            Form Formdecorativo = new Formdecorativo();
            Formdecorativo.TopLevel = false;
            Formdecorativo.FormBorderStyle = FormBorderStyle.None;
            Formdecorativo.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(Formdecorativo);
            this.Parent.Tag = Formdecorativo;
            Formdecorativo.BringToFront();
            Formdecorativo.Show();

            if (!string.IsNullOrEmpty(identificadorvariable))
            {
                try
                {
                    conexionsql.Open();
                    string insertar = "UPDATE estudiantes SET montos = @montos, materias = @materias WHERE cedula = @cedula";
                    MySqlCommand cmd = new MySqlCommand(insertar, conexionsql);
                    cmd.Parameters.AddWithValue("@montos", montototal);
                    cmd.Parameters.AddWithValue("@cedula", identificadorvariable);
                    cmd.Parameters.AddWithValue("@materias", materiassql);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el monto en la base de datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=actividadproyecto;UID=root;PASSWORDS=;";
        MySqlConnection conexionsql = new MySqlConnection(conexion);
        private void formmaterias_Load(object sender, EventArgs e)
        {

        }
        private void formmaterias_Closed(object sender, EventArgs e)
        {
            conexionsql.Close();
            this.Hide();
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
