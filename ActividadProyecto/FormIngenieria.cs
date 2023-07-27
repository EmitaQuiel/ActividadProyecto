using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.About;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using Org.BouncyCastle.Asn1.Microsoft;

namespace ActividadProyecto
{
    public partial class FormIngenieria : Form
    {
        public FormIngenieria()
        {
            InitializeComponent();

        }

        private string identificadorvariable;
        private int montototal = 0;
        private string materiassql;

        public struct Datos2
        {
            public int marcasing;
        }

        public struct DatosCheckIng
        {
            public string checking;
        }
        public FormIngenieria(string identificador)
            : this()
        {
            this.identificadorvariable = identificador;
          
        }
   
     
        public void guna2Button2_Click(object sender, EventArgs e)
        {
           
            Datos2 materiasing;
            materiasing.marcasing = 0;
           
            DatosCheckIng materiaschecking;
            materiaschecking = new DatosCheckIng();
            
            if (chkingsistemas.Checked)
            {
                montototal+= 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Introduccion a la Ingeniera de Sistemas\n";
                materiaschecking.checking += "• Introduccion a la Ingeniera de Sistemas\n";
            }

            if (chklogica.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Logica y algoritmos\n";
                materiaschecking.checking += "• Logica y algoritmos\n";
            }

            if (chkmatrl.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Matematica I\n";
                materiaschecking.checking += "• Matematica I\n";
            }

            if (chkinformatica.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Introduccion a la informatica\n";
                materiaschecking.checking += "• Introduccion a la informatica\n";
            }

            if (chkinglesl.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Ingles I\n";
                materiaschecking.checking += "• Ingles I\n";
            }
            
            if (chkecobasica.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Administracion y Economia Basicas\n";
                materiaschecking.checking += "• Administracion y Economia Basicas\n";
            }

            if (chkmatell.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Matematica II\n";
                materiaschecking.checking += "• Matematica II\n";
            }

            if (chkprogral.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Programacion I\n";
                materiaschecking.checking += "• Programacion I\n";
            }

            if (chkinglesll.Checked)
            {
                montototal += 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Ingles II\n";
                materiaschecking.checking += "• Ingles II\n";
            }

            if (chkestadistica.Checked)
            {
                montototal+= 25000;
                materiasing.marcasing += 25000;
                materiassql += "• Estadistica I\n";
                materiaschecking.checking += "• Estadistica I\n";
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

            FormMontos objingenieria = new FormMontos(materiasing);
            Class2.ListaIngenieria.Add(materiasing);

            FormCursos objchecking = new FormCursos(materiaschecking);
            Class2.ListaCheckIngenieria.Add(materiaschecking);

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
        
        private void Forming_Load(object sender, EventArgs e)
        {            
        }

        private void FormIngenieria_Closed(object sender, FormClosedEventArgs e)
        {
            conexionsql.Close();
            this.Hide();
        }
        
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
