using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.About;
using MySql.Data.MySqlClient;

namespace ActividadProyecto
{
    public partial class FormActualizar : Form
    {
        public FormActualizar()
        {
            InitializeComponent();
            AgregarFilasEstudiantes();
            dtgvistaalum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvistaalum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvistaalum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvistaalum.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }
        
        public FormActualizar(FormAnadir.Datos info)
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
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=actividadproyecto;UID=root;PASSWORDS=;";
        MySqlConnection conexionsql = new MySqlConnection(conexion);

        private void FormActualizar_Load(object sender, EventArgs e)
        {
            AgregarFilasEstudiantes();
        }
        public DataTable llenar_grid()
        {

            DataTable tabla = new DataTable();
            string llenar = "SELECT * FROM estudiantes";
            MySqlCommand cmd = new MySqlCommand(llenar, conexionsql);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(cmd);
            MySqlDataAdapter buscar = new MySqlDataAdapter("SELECT * FROM estudiantes", conexionsql);
            dataadapter.Fill(tabla);

            return tabla;
        }
        public void AgregarFilasEstudiantes()
        {
          //  dtgvistaalum.Rows.Clear(); // Limpiar filas existentes
           /* foreach (var estudiante in Class2.ListaEstudiantes)
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
            }*/
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
        
        private void FormActualizar_Load_1(object sender, EventArgs e)
        {
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
        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combosede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtgvistaalum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvistaalum.Rows[e.RowIndex];
            }
            
        }
        private void ButtonActualizar_Click(object sender, EventArgs e)
        {

            int rowIndex = dtgvistaalum.CurrentCell.RowIndex;
            string cedula = dtgvistaalum.Rows[rowIndex].Cells[0].Value.ToString();

            string nombre = txtactnombre.Text;
            string apellido = txtactapellido.Text;
            string numtlf = txtacttelefono.Text;
            string email = txtactemail.Text;
            string tipoid = comboactid.SelectedItem.ToString();
            

            string query = "UPDATE estudiantes SET nombre=@nombre, apellido=@apellido, numtlf=@numtlf, email=@email, " +
                "tipoid=@tipoid WHERE cedula=@cedula";

            MySqlCommand cmd = new MySqlCommand(query, conexionsql);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@numtlf", numtlf);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@tipoid", tipoid);           
            cmd.Parameters.AddWithValue("@cedula", cedula);

            conexionsql.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();            
            AgregarFilasEstudiantes(); // Actualizar datos en el DataGridView
            _ = cmd.ExecuteNonQuery();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Los datos han sido actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarFilasEstudiantes();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexionsql.Close();

            txtactnombre.Text = "";
            txtactapellido.Text = "";
            txtacttelefono.Text = "";
            txtactemail.Text = "";
            comboactid.Items.Clear();
            comboactsede.Items.Clear();


        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormActualizar_Closed(object sender, FormClosedEventArgs e)
        {
            conexionsql.Close();
        }
    }
}
