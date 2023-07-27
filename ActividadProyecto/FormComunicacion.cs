using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActividadProyecto
{
    public partial class FormComunicacion : Form
    {
        public FormComunicacion()
        {
            InitializeComponent();
        }
        private string identificadorvariable;
        private int montototal = 0;
        private string materiassql;

        public struct Datos5
        {
            public int marcascomunicacion;
        }
        public struct DatosChekComunicacion
        {
            public string marcascheckcomunicacion;
        }
        public FormComunicacion(string identificador)
            : this()
        {
            this.identificadorvariable = identificador;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Datos5 materiascomunicacion;
            materiascomunicacion.marcascomunicacion = 0;

            DatosChekComunicacion materiascheckcomunicacion;
            materiascheckcomunicacion=new DatosChekComunicacion();

            if (chkintrocomunicacion.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Introduccion a la Comunicacion\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Introduccion a la Comunicacion\n";
            }

            if (chkperiodismo.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Introduccion al Periodismo\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Introduccion al Periodismo\n";
            }

            if (chkpublicidad.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Introduccion a la Publicacion\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Introduccion a la Publicacion\n";
            }

            if (chkaudiovisual.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Introducción a la Comunicación Audiovisual y Multimedial\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Introducción a la Comunicación Audiovisual y Multimedial\n";
            }

            if (chkproduccionverbal.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Producción verbal\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Producción verbal\n";
            }

            if (chkrelacionespublicas.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Introducción a las Relaciones Públicas\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Introducción a las Relaciones Públicas\n";
            }

            if (chkfotografia.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Fotografía\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Fotografía\n";
            }

            if (chkbasicaaudio.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Producción básica de audio\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Producción básica de audio\n";
            }

            if (chktelevision.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Introducción a la producción de televisión y vídeo\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Introducción a la producción de televisión y vídeo\n";
            }

            if (chkgrafica.Checked)
            {
                montototal += 25000;
                materiascomunicacion.marcascomunicacion += 25000;
                materiassql += "• Comunicación gráfica\n";
                materiascheckcomunicacion.marcascheckcomunicacion += "• Comunicación gráfica\n";
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

            FormMontos objcomunicacion = new FormMontos(materiascomunicacion);
            Class2.ListaComunicacion.Add(materiascomunicacion);

            FormCursos objcheckcomunicacion = new FormCursos(materiascheckcomunicacion);
            Class2.ListaCheckcomunicacion.Add(materiascheckcomunicacion);

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
        
        private void FormComunicacion_Closed(object sender, EventArgs e)
        {
            conexionsql.Close();
            this.Hide();
        }
        private void FormComunicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
