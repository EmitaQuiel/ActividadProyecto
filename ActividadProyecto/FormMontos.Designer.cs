﻿namespace ActividadProyecto
{
    partial class FormMontos
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
            this.DGVCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
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
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(143, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 90);
            this.label4.TabIndex = 19;
            this.label4.Text = "Montos de los Estudiantes \r\ningresados\r\n";
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(139)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvistaalum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvistaalum.ColumnHeadersHeight = 50;
            this.dtgvistaalum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVCedula,
            this.DGVNombre,
            this.DGVCarrera,
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
            this.dtgvistaalum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvistaalum.Location = new System.Drawing.Point(137, 183);
            this.dtgvistaalum.Name = "dtgvistaalum";
            this.dtgvistaalum.ReadOnly = true;
            this.dtgvistaalum.RowHeadersVisible = false;
            this.dtgvistaalum.RowTemplate.Height = 40;
            this.dtgvistaalum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvistaalum.Size = new System.Drawing.Size(862, 363);
            this.dtgvistaalum.TabIndex = 21;
            this.dtgvistaalum.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvistaalum.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvistaalum.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvistaalum.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(139)))), ((int)(((byte)(163)))));
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
            // DGVCarrera
            // 
            this.DGVCarrera.HeaderText = "Carrera";
            this.DGVCarrera.Name = "DGVCarrera";
            this.DGVCarrera.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.dtgvistaalum;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox2.Image = global::ActividadProyecto.Properties.Resources._3d_casual_life_young_man_shopping_online;
            this.guna2PictureBox2.Location = new System.Drawing.Point(303, 581);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(544, 212);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 106;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.guna2PictureBox1.Image = global::ActividadProyecto.Properties.Resources._3d_casual_life_credit_cards_1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-33, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(213, 142);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 105;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormMontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1164, 839);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.dtgvistaalum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMontos";
            this.Text = "FormMontos";
            this.Load += new System.EventHandler(this.FormMontos_Load_1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}