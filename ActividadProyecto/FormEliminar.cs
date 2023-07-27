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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
            AgregarFilasEstudiantes();
            dtgvistaalum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvistaalum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvistaalum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvistaalum.DefaultCellStyle.Padding = new Padding(0, 12, 0, 12);
        }

        public FormEliminar(FormAnadir.Datos info, FormIngenieria.Datos2 materiasing, formmaterias.Datos3 materiaseducacion, FormPsicologia.Datos4 materiapsico, FormComunicacion.Datos5 materiascomunicacion)
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
            string carrera = info.carrera;
            int carreraIndex = -1;
            switch (carrera)
            {
                case "Ingeniería":
                    carreraIndex = 3;
                    break;
                case "Educación":
                    carreraIndex = 4;
                    break;
                case "Psicología":
                    carreraIndex = 5;
                    break;
                case "Comunicacion":
                    carreraIndex = 6;
                    break;
                default:
                    break;
            }

            if (carreraIndex != -1)
            {
                if (carrera == "Ingeniería")
                {
                    row.Cells[carreraIndex].Value = materiasing.marcasing;
                }
                else if (carrera == "Educación")
                {
                    row.Cells[carreraIndex].Value = materiaseducacion.marcaseducacion;
                }
                else if (carrera == "Psicología")
                {
                    row.Cells[carreraIndex].Value = materiapsico.marcaspsico;
                }
                else if (carrera == "Comunicacion")
                {
                    row.Cells[carreraIndex].Value = materiascomunicacion.marcascomunicacion;
                }
            }
            dtgvistaalum.Rows.Add(row);
            FormPrincipal vistadatos = new FormPrincipal();
        }
        
        public FormEliminar(string identificador)
            :this ()
        {
            this.variableidentificador = identificador;            
        }
        

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=actividadproyecto;UID=root;PASSWORDS=;";
        MySqlConnection conexionsql = new MySqlConnection(conexion);
        private string variableidentificador;

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            AgregarFilasEstudiantes();
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
            dtgvistaalum.Columns[9].DataPropertyName = "montos";
            dtgvistaalum.DataSource = tabla;
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
            dtgvistaalum.Rows.Clear();
            int idxIngenieria = 0;
            int idxEducacion = 0;
            int idxPsicologia = 0;
            int idxComunicacion = 0;

            for (int i = 0; i < Class2.ListaEstudiantes.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgvistaalum);
                row.Cells[0].Value = Class2.ListaEstudiantes[i].cedula;
                row.Cells[1].Value = Class2.ListaEstudiantes[i].nombre;
                row.Cells[2].Value = Class2.ListaEstudiantes[i].apellido;
                row.Cells[3].Value = Class2.ListaEstudiantes[i].numtlf;
                row.Cells[4].Value = Class2.ListaEstudiantes[i].tipoid;
                row.Cells[5].Value = Class2.ListaEstudiantes[i].email;
                row.Cells[6].Value = Class2.ListaEstudiantes[i].genero;
                row.Cells[7].Value = Class2.ListaEstudiantes[i].carrera;
                row.Cells[8].Value = Class2.ListaEstudiantes[i].sede;
                switch (Class2.ListaEstudiantes[i].carrera)
                {
                    case "Ingeniería":
                        row.Cells[9].Value = Class2.ListaIngenieria[idxIngenieria].marcasing;
                        idxIngenieria++;
                        break;
                    case "Educación":
                        row.Cells[9].Value = Class2.ListaEducacion[idxEducacion].marcaseducacion;
                        idxEducacion++;
                        break;
                    case "Psicología":
                        row.Cells[9].Value = Class2.ListaPsicologia[idxPsicologia].marcaspsico;
                        idxPsicologia++;
                        break;
                    case "Comunicacion":
                        row.Cells[9].Value = Class2.ListaComunicacion[idxComunicacion].marcascomunicacion;
                        idxComunicacion++;
                        break;
                    default:
                        row.Cells[9].Value = "Carrera no reconocida";
                        break;

                }
                dtgvistaalum.Rows.Add(row);

            }
        }

        public void AgregarFilaEstudiante(FormAnadir.Datos info, FormIngenieria.Datos2 materiasing, formmaterias.Datos3 materiaseducacion, FormPsicologia.Datos4 materiapsico, FormComunicacion.Datos5 materiascomunicacion)
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
            string carrera = info.carrera;
            int carreraIndex = -1;
            switch (carrera)
            {
                case "Ingeniería":
                    carreraIndex = 3;
                    break;
                case "Educación":
                    carreraIndex = 4;
                    break;
                case "Psicología":
                    carreraIndex = 5;
                    break;
                case "Comunicacion":
                    carreraIndex = 6;
                    break;
                default:
                    break;
            }

            if (carreraIndex != -1)
            {
                if (carrera == "Ingeniería")
                {
                    row.Cells[carreraIndex].Value = materiasing.marcasing;
                }
                else if (carrera == "Educación")
                {
                    row.Cells[carreraIndex].Value = materiaseducacion.marcaseducacion;
                }
                else if (carrera == "Psicología")
                {
                    row.Cells[carreraIndex].Value = materiapsico.marcaspsico;
                }
                else if (carrera == "Comunicacion")
                {
                    row.Cells[carreraIndex].Value = materiascomunicacion.marcascomunicacion;
                }
            }
            dtgvistaalum.Rows.Add(row);

        }
        
        private void dtgvistaalum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonEliminar_Click_1(object sender, EventArgs e)
        {
            if (dtgvistaalum.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvistaalum.SelectedRows[0];

                string id = row.Cells[0].Value.ToString();

                MySqlConnection conexionsql = new MySqlConnection(conexion);
                string eliminar = "DELETE FROM estudiantes WHERE cedula=@id";
                MySqlCommand cmd = new MySqlCommand(eliminar, conexionsql);
                cmd.Parameters.AddWithValue("@id", id);
                conexionsql.Open();
                cmd.ExecuteNonQuery();
                conexionsql.Close();

                dtgvistaalum.Rows.Remove(row);
            }

        }
        private void FormEliminar_Closed(object sender, FormClosedEventArgs e)
        {
            conexionsql.Close();
        }
    }
}
