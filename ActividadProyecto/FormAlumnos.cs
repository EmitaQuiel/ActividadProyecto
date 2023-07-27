using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActividadProyecto
{
    
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
            AgregarFilasEstudiantes();
            dtgvistaalum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvistaalum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvistaalum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvistaalum.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=actividadproyecto;UID=root;PASSWORDS=;";
        MySqlConnection conexionsql = new MySqlConnection(conexion);
        public DataTable llenar_grid()
        {
            
            DataTable tabla = new DataTable();
            string llenar = "select * from estudiantes";
            MySqlCommand cmd = new MySqlCommand(llenar, conexionsql);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(cmd);
            dataadapter.Fill(tabla);

            return tabla;

        }
        public FormAlumnos(FormAnadir.Datos info)
        {
            InitializeComponent();

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgvistaalum);
            row.Cells[0].Value = info.cedula;
            row.Cells[1].Value = info.nombre;
            row.Cells[2].Value = info.apellido;
            row.Cells[3].Value = info.numtlf;
            row.Cells[4].Value = info.tipoid;
            row.Cells[5].Value = info.email;
            row.Cells[6].Value = info.genero;
            row.Cells[7].Value = info.carrera;
            row.Cells[8].Value = info.sede;

            dtgvistaalum.Rows.Add(row);

            FormPrincipal vistadatos = new FormPrincipal();
            
        }

        private void FormVistaDatos_Load(object sender, EventArgs e)
        {
            AgregarFilasEstudiantes();
            ContarCedulas();
            DataTable tabla = llenar_grid();
            dtgvistaalum.AutoGenerateColumns = false;
            dtgvistaalum.Columns[0].DataPropertyName = "cedula";
            dtgvistaalum.Columns[1].DataPropertyName = "nombre";
            dtgvistaalum.Columns[2].DataPropertyName = "apellido";
            dtgvistaalum.Columns[3].DataPropertyName = "numtlf";
            dtgvistaalum.Columns[4].DataPropertyName = "tipoid";
            dtgvistaalum.Columns[5].DataPropertyName = "email";
            dtgvistaalum.Columns[6].DataPropertyName = "genero";
            dtgvistaalum.Columns[7].DataPropertyName = "carrera";
            dtgvistaalum.Columns[8].DataPropertyName = "sede";
            dtgvistaalum.DataSource = tabla;
        }

        private void ContarCedulas()
        {
            int conteo = 0;
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM estudiantes", conexionsql))
            {
                conexionsql.Open();
                conteo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            conexionsql.Close();
            txtconteo.Text = conteo.ToString();
        }

        public void AgregarFilasEstudiantes()
        {
            dtgvistaalum.Rows.Clear(); // Limpiar filas existentes
            foreach (var estudiante in Class2.ListaEstudiantes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgvistaalum);
                row.Cells[0].Value = estudiante.cedula;
                row.Cells[1].Value = estudiante.nombre;
                row.Cells[2].Value = estudiante.apellido;
                row.Cells[3].Value = estudiante.numtlf;
                row.Cells[4].Value = estudiante.tipoid;
                row.Cells[5].Value = estudiante.email;
                row.Cells[6].Value = estudiante.genero;
                row.Cells[7].Value = estudiante.carrera;
                row.Cells[8].Value = estudiante.sede;
                dtgvistaalum.Rows.Add(row);
            }
        }

        public void AgregarFilaEstudiante(FormAnadir.Datos info)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgvistaalum);
            row.Cells[0].Value = info.cedula;
            row.Cells[1].Value = info.nombre;
            row.Cells[2].Value = info.apellido;
            row.Cells[3].Value = info.numtlf;
            row.Cells[4].Value = info.tipoid;
            row.Cells[5].Value = info.email;
            row.Cells[6].Value = info.genero;
            row.Cells[7].Value = info.carrera;
            row.Cells[8].Value = info.sede;

            dtgvistaalum.Rows.Add(row);
        }

        private void FormAlumnos_Closed(object sender, FormClosedEventArgs e)
        {
            conexionsql.Close();
        }

        private void dtgvistaalum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtconteo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
