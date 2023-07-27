namespace ActividadProyecto
{
    partial class FormBuscar
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
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvistaalum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(145, 664);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 45);
            this.label4.TabIndex = 19;
            this.label4.Text = "BUSCAR";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
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
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvistaalum.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvistaalum.EnableHeadersVisualStyles = false;
            this.dtgvistaalum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dtgvistaalum.Location = new System.Drawing.Point(112, 177);
            this.dtgvistaalum.Name = "dtgvistaalum";
            this.dtgvistaalum.ReadOnly = true;
            this.dtgvistaalum.RowHeadersVisible = false;
            this.dtgvistaalum.RowTemplate.Height = 40;
            this.dtgvistaalum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvistaalum.Size = new System.Drawing.Size(963, 403);
            this.dtgvistaalum.TabIndex = 21;
            this.dtgvistaalum.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
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
            this.dtgvistaalum.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.dtgvistaalum.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgvistaalum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvistaalum_CellContentClick);
            // 
            // DGVCedula
            // 
            this.DGVCedula.HeaderText = "Cedula";
            this.DGVCedula.Name = "DGVCedula";
            this.DGVCedula.ReadOnly = true;
            // 
            // DGVNombre
            // 
            this.DGVNombre.HeaderText = "Nombre";
            this.DGVNombre.Name = "DGVNombre";
            this.DGVNombre.ReadOnly = true;
            // 
            // DGVApellido
            // 
            this.DGVApellido.HeaderText = "Apellido";
            this.DGVApellido.Name = "DGVApellido";
            this.DGVApellido.ReadOnly = true;
            // 
            // DGVTelefono
            // 
            this.DGVTelefono.HeaderText = "Telefono";
            this.DGVTelefono.Name = "DGVTelefono";
            this.DGVTelefono.ReadOnly = true;
            // 
            // DGVTipoid
            // 
            this.DGVTipoid.HeaderText = "Tipo ID";
            this.DGVTipoid.Name = "DGVTipoid";
            this.DGVTipoid.ReadOnly = true;
            // 
            // DGVEmail
            // 
            this.DGVEmail.HeaderText = "Email";
            this.DGVEmail.Name = "DGVEmail";
            this.DGVEmail.ReadOnly = true;
            // 
            // DGVGenero
            // 
            this.DGVGenero.HeaderText = "Genero";
            this.DGVGenero.Name = "DGVGenero";
            this.DGVGenero.ReadOnly = true;
            // 
            // DGVCarrera
            // 
            this.DGVCarrera.HeaderText = "Carrera";
            this.DGVCarrera.Name = "DGVCarrera";
            this.DGVCarrera.ReadOnly = true;
            // 
            // DGVSede
            // 
            this.DGVSede.HeaderText = "Sede";
            this.DGVSede.Name = "DGVSede";
            this.DGVSede.ReadOnly = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.txtbuscar.BorderRadius = 15;
            this.txtbuscar.BorderThickness = 0;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.Parent = this.txtbuscar;
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.FocusedState.Parent = this.txtbuscar;
            this.txtbuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.HoverState.Parent = this.txtbuscar;
            this.txtbuscar.Location = new System.Drawing.Point(339, 666);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(5);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.ShadowDecoration.Parent = this.txtbuscar;
            this.txtbuscar.Size = new System.Drawing.Size(205, 43);
            this.txtbuscar.TabIndex = 52;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(162, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(340, 52);
            this.label10.TabIndex = 90;
            this.label10.Text = "Area de Busqueda";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(47)))));
            this.guna2TextBox2.BorderRadius = 22;
            this.guna2TextBox2.BorderThickness = 0;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(161)))), ((int)(((byte)(129)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(112, 631);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(505, 117);
            this.guna2TextBox2.TabIndex = 91;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this.dtgvistaalum;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(172, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 27);
            this.label1.TabIndex = 93;
            this.label1.Text = "Debe de buscar con la cedula del estudiante\r\n";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox2.Image = global::ActividadProyecto.Properties.Resources.business_3d_woman_recruiter_leaning_on_browser_window_with_man_showing_v_sign_inside;
            this.guna2PictureBox2.Location = new System.Drawing.Point(664, 595);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(423, 232);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 92;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox1.Image = global::ActividadProyecto.Properties.Resources._3d_casual_life_looking_for_an_employee_online;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(149, 136);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 89;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1164, 839);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dtgvistaalum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2TextBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvistaalum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvistaalum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVTipoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVSede;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label1;
    }
}