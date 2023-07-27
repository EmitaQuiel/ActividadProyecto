namespace ActividadProyecto
{
    partial class FormEliminar
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
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvistaalum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvistaalum
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvistaalum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvistaalum.BackgroundColor = System.Drawing.Color.White;
            this.dtgvistaalum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvistaalum.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvistaalum.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(139)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
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
            this.DGVSede,
            this.Monto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvistaalum.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvistaalum.EnableHeadersVisualStyles = false;
            this.dtgvistaalum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dtgvistaalum.Location = new System.Drawing.Point(62, 154);
            this.dtgvistaalum.Name = "dtgvistaalum";
            this.dtgvistaalum.ReadOnly = true;
            this.dtgvistaalum.RowHeadersVisible = false;
            this.dtgvistaalum.RowTemplate.Height = 40;
            this.dtgvistaalum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvistaalum.Size = new System.Drawing.Size(1046, 476);
            this.dtgvistaalum.TabIndex = 21;
            this.dtgvistaalum.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(139)))), ((int)(((byte)(195)))));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvistaalum.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvistaalum.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvistaalum.ThemeStyle.ReadOnly = true;
            this.dtgvistaalum.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtgvistaalum.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvistaalum.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvistaalum.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvistaalum.ThemeStyle.RowsStyle.Height = 40;
            this.dtgvistaalum.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvistaalum.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(113, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 52);
            this.label10.TabIndex = 105;
            this.label10.Text = "Area de Eliminar";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dtgvistaalum;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox1.Image = global::ActividadProyecto.Properties.Resources.casual_life_3d_closed_white_garbage_bin;
            this.guna2PictureBox1.Location = new System.Drawing.Point(28, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(123, 114);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 104;
            this.guna2PictureBox1.TabStop = false;
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Animated = true;
            this.ButtonEliminar.BorderRadius = 10;
            this.ButtonEliminar.CheckedState.Parent = this.ButtonEliminar;
            this.ButtonEliminar.CustomImages.Parent = this.ButtonEliminar;
            this.ButtonEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(130)))));
            this.ButtonEliminar.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold);
            this.ButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminar.HoverState.Parent = this.ButtonEliminar;
            this.ButtonEliminar.Image = global::ActividadProyecto.Properties.Resources.icons8_remove_50;
            this.ButtonEliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonEliminar.ImageSize = new System.Drawing.Size(30, 30);
            this.ButtonEliminar.Location = new System.Drawing.Point(414, 702);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.ShadowDecoration.Parent = this.ButtonEliminar;
            this.ButtonEliminar.Size = new System.Drawing.Size(303, 63);
            this.ButtonEliminar.TabIndex = 103;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click_1);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox2.Image = global::ActividadProyecto.Properties.Resources._3d_casual_life_notebook_with_pencil_highlighter_pen_and_papers;
            this.guna2PictureBox2.Location = new System.Drawing.Point(896, 613);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(242, 248);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 106;
            this.guna2PictureBox2.TabStop = false;
            // 
            // FormEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1164, 839);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.dtgvistaalum);
            this.Controls.Add(this.guna2PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEliminar";
            this.Text = "FormEliminar";
            this.Load += new System.EventHandler(this.FormEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvistaalum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private Guna.UI2.WinForms.Guna2Button ButtonEliminar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}