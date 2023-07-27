using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActividadProyecto
{
    public partial class FormPrincipal : Form
    {
        private static FormAlumnos _formVistaDatos;
        private static FormEliminar _formEliminar;
        private static FormBuscar _formBuscar;
        private static FormActualizar _formActualizar;
        private static FormMontos _formMontos;


        public FormPrincipal()
        {
            InitializeComponent();

        }



        private Form activeForm=null; //utilizar varios formularios
        private void openChildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill; 
            
            PanelHijo.Controls.Add(childform);
            PanelHijo.Tag = childform; 
            childform.BringToFront();
            childform.Show();
                
        }

        
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (_formVistaDatos == null || _formVistaDatos.IsDisposed)
            {
                _formVistaDatos = new FormAlumnos();
                openChildForm(new FormAlumnos());
            }
            else
            {
                _formVistaDatos.Activate();
                openChildForm(new FormAlumnos());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAnadir_Click(object sender, EventArgs e)
        {

            openChildForm(new FormAnadir());
        }

        private void btoInicio_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void btoInicio_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            if (_formActualizar == null || _formActualizar.IsDisposed)
            {
                _formActualizar = new FormActualizar();
                openChildForm(new FormActualizar());
            }
            else
            {
                _formActualizar.Activate();
                openChildForm(new FormActualizar());
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnincio_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm != this)
                {
                    frm.Visible = false;
                }
            }

            this.Show();
        }

        private void PanelHijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (_formEliminar == null || _formEliminar.IsDisposed)
            {
                _formEliminar = new FormEliminar();
                openChildForm(new FormEliminar());
            }
            else
            {
                _formEliminar.Activate();
                openChildForm(new FormEliminar());
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (_formBuscar == null || _formBuscar.IsDisposed)
            {
                _formBuscar = new FormBuscar();
                openChildForm(new FormBuscar());
            }
            else
            {
                _formBuscar.Activate();
                openChildForm(new FormBuscar());
            }
        }

        private void ButtonMontos_Click(object sender, EventArgs e)
        {
            if (_formMontos == null || _formMontos.IsDisposed)
            {
                _formMontos = new FormMontos();
                openChildForm(new FormMontos());
            }
            else
            {
                _formMontos.Activate();
                openChildForm(new FormMontos());
            }
        }

        private void buttoncurso_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCursos());
        }
    }
}
