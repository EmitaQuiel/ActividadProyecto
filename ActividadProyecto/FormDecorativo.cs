using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ActividadProyecto
{
    public partial class Formdecorativo : Form
    {
        public Formdecorativo()
        {
            InitializeComponent();
        }
        
        
        private void FormMontos_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form FormAnadir = new FormAnadir();
            FormAnadir.TopLevel = false;
            FormAnadir.FormBorderStyle = FormBorderStyle.None;
            FormAnadir.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(FormAnadir);
            this.Parent.Tag = FormAnadir;
            FormAnadir.BringToFront();
            FormAnadir.Show();
        }
    }
}
