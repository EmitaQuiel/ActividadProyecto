using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActividadProyecto
{
    public partial class FormPsicologia : Form
    {
        private string identificadorvariable;
        private int montototal = 0;
        private string materiassql;

        public FormPsicologia()
        {
            InitializeComponent();
        }

        public FormPsicologia(string identificador)
            :this()
        {
            identificadorvariable = identificador;
        }

        public struct Datos4
        {
            public int marcaspsico;
        }

        public struct DatosCheckPsicologia
        {
            public string checkpsicologia;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Datos4 materiapsico;
            materiapsico.marcaspsico = 0;

            DatosCheckPsicologia materiaspsicocheck;
            materiaspsicocheck = new DatosCheckPsicologia();

            if (chkcultura.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Teoria de la Cultura para Psicologia\n";
                materiaspsicocheck.checkpsicologia += "• Teoria de la Cultura para Psicologia\n";
            }

            if (chkpriscobasicos.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Proceso Psicologicos Basicos\n";
                materiaspsicocheck.checkpsicologia += "• Proceso Psicologicos Basicos\n";
            }

            if (chkteorias.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Teorías y Sistemas de Psicología II\n";
                materiaspsicocheck.checkpsicologia += "• Teorías y Sistemas de Psicología II\n";
            }

            if (chkdesarrollo.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Psicología del Desarrollo Humano I\n";
                materiaspsicocheck.checkpsicologia += "• Psicología del Desarrollo Humano I\n";
            }

            if (chkpsicosocial.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Teoría Psicosocial I\n";
                materiaspsicocheck.checkpsicologia += "• Teoría Psicosocial I\n";
            }

            if (chkbiologo.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Bases biológicas de la conducta I\n";
                materiaspsicocheck.checkpsicologia += "• Bases biológicas de la conducta I\n";
            }

            if (chkdesall.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Psicología del Desarrollo Humano II\n";
                materiaspsicocheck.checkpsicologia += "• Psicología del Desarrollo Humano II\n";
            }

            if (chkpsicoll.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Teoría Psicosocial II\n";
                materiaspsicocheck.checkpsicologia += "• Teoría Psicosocial II\n";
            }

            if (chkpsicoedu.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Teoría Psicoeducativa\n";
                materiaspsicocheck.checkpsicologia += "• Teoría Psicoeducativa\n";
            }

            if (chknorma.Checked)
            {
                montototal += 25000;
                materiapsico.marcaspsico += 25000;
                materiassql += "• Normalidad, patología y diagnóstico I\n";
                materiaspsicocheck.checkpsicologia += "• Normalidad, patología y diagnóstico I\n";
            }

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

            FormMontos objpsicologia = new FormMontos(materiapsico);
            Class2.ListaPsicologia.Add(materiapsico);

            FormCursos objcheckpsicologia = new FormCursos(materiaspsicocheck);
            Class2.ListaCheckPsicologia.Add(materiaspsicocheck);

            Form Formdecorativo = new Formdecorativo();
            Formdecorativo.TopLevel = false;
            Formdecorativo.FormBorderStyle = FormBorderStyle.None;
            Formdecorativo.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(Formdecorativo);
            this.Parent.Tag = Formdecorativo;
            Formdecorativo.BringToFront();
            Formdecorativo.Show();
        }

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=actividadproyecto;UID=root;PASSWORDS=;";
        MySqlConnection conexionsql = new MySqlConnection(conexion);

        private void FormPsicologia_Load(object sender, EventArgs e)
        {

        }
        private void FormPsicologia_Closed(object sender, EventArgs e)
        {
            conexionsql.Close();
            this.Hide();
        }
    }
}
