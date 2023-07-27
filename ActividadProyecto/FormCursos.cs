using DevExpress.Utils.About;
using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ActividadProyecto
{
    public partial class FormCursos : Form
    {
        public FormCursos()
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
        public FormCursos(FormAnadir.Datos info, FormIngenieria.DatosCheckIng materiaschecking, FormPsicologia.DatosCheckPsicologia materiaspsicocheck, formmaterias.DatosCheckEducacion materiascheckeducacion, FormComunicacion.DatosChekComunicacion materiascheckcomunicacion)
        {
            InitializeComponent();
            
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgvistaalum);
            row.Cells[0].Value = info.cedula;
            row.Cells[1].Value = info.nombre;
            row.Cells[2].Value = info.carrera;
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
                    row.Cells[carreraIndex].Value = materiaschecking.checking.Replace("\n", Environment.NewLine);
                }
                else if (carrera == "Educación")
                {
                    row.Cells[carreraIndex].Value = materiascheckeducacion.checkeducacion.Replace("\n", Environment.NewLine);
                }
                else if (carrera == "Psicología")
                {
                    row.Cells[carreraIndex].Value = materiaspsicocheck.checkpsicologia.Replace("\n", Environment.NewLine);
                }
                else if (carrera == "Comunicacion")
                {
                    row.Cells[carreraIndex].Value = materiascheckcomunicacion.marcascheckcomunicacion.Replace("\n", Environment.NewLine); //agrega una nueva linea en el datagrid
                }
            }
            dtgvistaalum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvistaalum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvistaalum.Rows.Add(row);

        }

        private void FormCursos_Load(object sender, EventArgs e)
        {
            AgregarFilasEstudiantes();
            
            DataTable tabla = llenar_grid();
            dtgvistaalum.AutoGenerateColumns = false;
            dtgvistaalum.Columns[0].DataPropertyName = "cedula";
            dtgvistaalum.Columns[1].DataPropertyName = "nombre";            
            dtgvistaalum.Columns[2].DataPropertyName = "carrera";
            dtgvistaalum.Columns[3].DataPropertyName = "materias";
            dtgvistaalum.DataSource = tabla;
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
                row.Cells[2].Value = Class2.ListaEstudiantes[i].carrera;
                switch (Class2.ListaEstudiantes[i].carrera)
                {
                    case "Ingeniería":
                        row.Cells[3].Value = Class2.ListaCheckIngenieria[idxIngenieria].checking.Replace("\n", Environment.NewLine);
                        idxIngenieria++;
                        break;
                    case "Educación":
                        row.Cells[3].Value = Class2.ListaCheckEducacion[idxEducacion].checkeducacion.Replace("\n", Environment.NewLine);
                        idxEducacion++;
                        break;
                    case "Psicología":
                        row.Cells[3].Value = Class2.ListaCheckPsicologia[idxPsicologia].checkpsicologia.Replace("\n", Environment.NewLine);
                        idxPsicologia++;
                        break;
                    case "Comunicacion":
                        row.Cells[3].Value = Class2.ListaCheckcomunicacion[idxComunicacion].marcascheckcomunicacion.Replace("\n", Environment.NewLine);
                        idxComunicacion++;
                        break;
                    default:
                        row.Cells[3].Value = "Carrera no reconocida";
                        break;
                }
                dtgvistaalum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dtgvistaalum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dtgvistaalum.Rows.Add(row);
            }
        }

        public void AgregarFilasEstudiantes(FormAnadir.Datos info, FormIngenieria.DatosCheckIng materiaschecking, FormPsicologia.DatosCheckPsicologia materiaspsicocheck,formmaterias.DatosCheckEducacion materiascheckeducacion,FormComunicacion.DatosChekComunicacion materiascheckcomunicacion)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dtgvistaalum);
            row.Cells[0].Value = info.cedula;
            row.Cells[1].Value = info.nombre;
            row.Cells[2].Value = info.carrera;
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
                    row.Cells[carreraIndex].Value = materiaschecking.checking.Replace("\n", Environment.NewLine);
                }
                else if (carrera == "Educación")
                {
                    row.Cells[carreraIndex].Value = materiascheckeducacion.checkeducacion.Replace("\n", Environment.NewLine);
                }
                else if (carrera == "Psicología")
                {
                    row.Cells[carreraIndex].Value = materiaspsicocheck.checkpsicologia.Replace("\n", Environment.NewLine);
                }
                else if (carrera == "Comunicacion")
                {
                    row.Cells[carreraIndex].Value = materiascheckcomunicacion.marcascheckcomunicacion.Replace("\n", Environment.NewLine);
                }
            }
            dtgvistaalum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvistaalum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dtgvistaalum.Rows.Add(row);
        }

        private void FormAlumnos_Closed(object sender, FormClosedEventArgs e)
        {
            conexionsql.Close();
        }
        public FormCursos(FormIngenieria.DatosCheckIng materiaschecking)
        {

        }
        public FormCursos(FormPsicologia.DatosCheckPsicologia materiaspsicocheck)
        {

        }
        public FormCursos(formmaterias.DatosCheckEducacion materiascheckeducacion)
        {

        }
        public FormCursos(FormComunicacion.DatosChekComunicacion materiascheckcomunicacion)
        {

        }
        

        
    }
}
