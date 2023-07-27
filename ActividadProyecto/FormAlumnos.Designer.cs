namespace ActividadProyecto
{
    partial class FormAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvistaalum = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DGVCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVTipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtconteo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvistaalum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(174, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 104);
            this.label4.TabIndex = 19;
            this.label4.Text = "Historial de Estudiantes \r\nMatriculados";
            // 
            // dtgvistaalum
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dtgvistaalum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvistaalum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvistaalum.BackgroundColor = System.Drawing.Color.White;
            this.dtgvistaalum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvistaalum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvistaalum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvistaalum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvistaalum.ColumnHeadersHeight = 50;
            this.dtgvistaalum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCedula,
            this.DGVNombre,
            this.DGVApellido,
            this.DGVTelefono,
            this.DGVTipoid,
            this.DGVEmail,
            this.DGVGenero,
            this.DGVCarrera,
            this.DGVSede});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvistaalum.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvistaalum.EnableHeadersVisualStyles = false;
            this.dtgvistaalum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dtgvistaalum.Location = new System.Drawing.Point(79, 202);
            this.dtgvistaalum.Name = "dtgvistaalum";
            this.dtgvistaalum.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvistaalum.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvistaalum.RowHeadersVisible = false;
            this.dtgvistaalum.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgvistaalum.RowTemplate.Height = 40;
            this.dtgvistaalum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvistaalum.Size = new System.Drawing.Size(1014, 420);
            this.dtgvistaalum.TabIndex = 20;
            this.dtgvistaalum.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(123)))), ((int)(((byte)(139)))));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvistaalum.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvistaalum.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvistaalum.ThemeStyle.ReadOnly = true;
            this.dtgvistaalum.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgvistaalum.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvistaalum.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvistaalum.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgvistaalum.ThemeStyle.RowsStyle.Height = 40;
            this.dtgvistaalum.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dtgvistaalum.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvistaalum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvistaalum_CellContentClick);
            // 
            // DGVCedula
            // 
            this.DGVCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVCedula.HeaderText = "Cedula";
            this.DGVCedula.MinimumWidth = 100;
            this.DGVCedula.Name = "DGVCedula";
            this.DGVCedula.ReadOnly = true;
            // 
            // DGVNombre
            // 
            this.DGVNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVNombre.HeaderText = "Nombre";
            this.DGVNombre.MinimumWidth = 100;
            this.DGVNombre.Name = "DGVNombre";
            this.DGVNombre.ReadOnly = true;
            // 
            // DGVApellido
            // 
            this.DGVApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVApellido.HeaderText = "Apellido";
            this.DGVApellido.MinimumWidth = 100;
            this.DGVApellido.Name = "DGVApellido";
            this.DGVApellido.ReadOnly = true;
            // 
            // DGVTelefono
            // 
            this.DGVTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVTelefono.HeaderText = "Telefono";
            this.DGVTelefono.MinimumWidth = 100;
            this.DGVTelefono.Name = "DGVTelefono";
            this.DGVTelefono.ReadOnly = true;
            // 
            // DGVTipoid
            // 
            this.DGVTipoid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVTipoid.HeaderText = "Tipo ID";
            this.DGVTipoid.MinimumWidth = 100;
            this.DGVTipoid.Name = "DGVTipoid";
            this.DGVTipoid.ReadOnly = true;
            // 
            // DGVEmail
            // 
            this.DGVEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVEmail.HeaderText = "Email";
            this.DGVEmail.MinimumWidth = 100;
            this.DGVEmail.Name = "DGVEmail";
            this.DGVEmail.ReadOnly = true;
            // 
            // DGVGenero
            // 
            this.DGVGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVGenero.HeaderText = "Genero";
            this.DGVGenero.MinimumWidth = 100;
            this.DGVGenero.Name = "DGVGenero";
            this.DGVGenero.ReadOnly = true;
            // 
            // DGVCarrera
            // 
            this.DGVCarrera.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVCarrera.HeaderText = "Carrera";
            this.DGVCarrera.MinimumWidth = 100;
            this.DGVCarrera.Name = "DGVCarrera";
            this.DGVCarrera.ReadOnly = true;
            // 
            // DGVSede
            // 
            this.DGVSede.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DGVSede.HeaderText = "Sede";
            this.DGVSede.MinimumWidth = 100;
            this.DGVSede.Name = "DGVSede";
            this.DGVSede.ReadOnly = true;
            // 
            // txtconteo
            // 
            this.txtconteo.BackColor = System.Drawing.Color.White;
            this.txtconteo.BorderRadius = 15;
            this.txtconteo.BorderThickness = 0;
            this.txtconteo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtconteo.DefaultText = "";
            this.txtconteo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtconteo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtconteo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconteo.DisabledState.Parent = this.txtconteo;
            this.txtconteo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtconteo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconteo.FocusedState.Parent = this.txtconteo;
            this.txtconteo.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconteo.ForeColor = System.Drawing.Color.Black;
            this.txtconteo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtconteo.HoverState.Parent = this.txtconteo;
            this.txtconteo.Location = new System.Drawing.Point(277, 718);
            this.txtconteo.Margin = new System.Windows.Forms.Padding(5);
            this.txtconteo.Name = "txtconteo";
            this.txtconteo.PasswordChar = '\0';
            this.txtconteo.PlaceholderText = "";
            this.txtconteo.ReadOnly = true;
            this.txtconteo.SelectedText = "";
            this.txtconteo.ShadowDecoration.Parent = this.txtconteo;
            this.txtconteo.Size = new System.Drawing.Size(205, 43);
            this.txtconteo.TabIndex = 72;
            this.txtconteo.TextChanged += new System.EventHandler(this.txtconteo_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dtgvistaalum;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(85, 681);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 80);
            this.label1.TabIndex = 89;
            this.label1.Text = "Cantidad de Estudiantes \r\nMatriculados";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.guna2TextBox4.BorderRadius = 22;
            this.guna2TextBox4.BorderThickness = 0;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Location = new System.Drawing.Point(79, 658);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.ReadOnly = true;
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(423, 150);
            this.guna2TextBox4.TabIndex = 91;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox5.Image = global::ActividadProyecto.Properties.Resources._3d_casual_life_looking_through_resumes__1_;
            this.guna2PictureBox5.Location = new System.Drawing.Point(26, 12);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.ShadowDecoration.Parent = this.guna2PictureBox5;
            this.guna2PictureBox5.Size = new System.Drawing.Size(142, 139);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 88;
            this.guna2PictureBox5.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox1.Image = global::ActividadProyecto.Properties.Resources.casual_life_3d_young_man_surrounded_by_gadgets_taking_notes;
            this.guna2PictureBox1.Location = new System.Drawing.Point(371, 637);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(790, 190);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 92;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1164, 839);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.txtconteo);
            this.Controls.Add(this.dtgvistaalum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox4);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlumnos";
            this.Text = "FormVistaDatos";
            this.Load += new System.EventHandler(this.FormVistaDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvistaalum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvistaalum;
        private Guna.UI2.WinForms.Guna2TextBox txtconteo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVSede;
    }
}