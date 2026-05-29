using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar.dsk
{
    partial class FrmInscripciones
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
            label1 = new Label();
            lblCurso = new Label();
            cmbAlumnos = new ComboBox();
            btnAgregar = new Button();
            dgvAlumnos = new DataGridView();
            btnNuevoAlumno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 69);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Alumnos:";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurso.Location = new Point(61, 23);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(96, 32);
            lblCurso.TabIndex = 1;
            lblCurso.Text = "curso";
            // 
            // cmbAlumnos
            // 
            cmbAlumnos.FormattingEnabled = true;
            cmbAlumnos.Location = new Point(156, 66);
            cmbAlumnos.Name = "cmbAlumnos";
            cmbAlumnos.Size = new Size(300, 28);
            cmbAlumnos.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(470, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 36);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(43, 118);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(860, 380);
            dgvAlumnos.TabIndex = 4;
            // 
            // btnNuevoAlumno
            // 
            btnNuevoAlumno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevoAlumno.Location = new Point(743, 510);
            btnNuevoAlumno.Name = "btnNuevoAlumno";
            btnNuevoAlumno.Size = new Size(160, 40);
            btnNuevoAlumno.TabIndex = 5;
            btnNuevoAlumno.Text = "Nuevo Alumno";
            btnNuevoAlumno.UseVisualStyleBackColor = true;
            btnNuevoAlumno.Click += btnNuevoAlumno_Click;
            // 
            // FrmInscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 580);
            Controls.Add(btnNuevoAlumno);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnAgregar);
            Controls.Add(cmbAlumnos);
            Controls.Add(lblCurso);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInscripciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripciones";
            Load += FrmInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCurso;
        private ComboBox cmbAlumnos;
        private Button btnAgregar;
        private DataGridView dgvAlumnos;
        private Button btnNuevoAlumno;
    }
}