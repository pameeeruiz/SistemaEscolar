namespace SistemaEscolar.dsk
{
    partial class FrmCalificaciones
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
            lblcursos = new Label();
            dgvCalificaciones = new DataGridView();
            cmbEvaluaciones = new ComboBox();
            btnCapturar = new Button();
            btnGuardar = new Button();
            btnRecargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // lblcursos
            // 
            lblcursos.AutoSize = true;
            lblcursos.Location = new Point(73, 42);
            lblcursos.Name = "lblcursos";
            lblcursos.Size = new Size(50, 20);
            lblcursos.TabIndex = 0;
            lblcursos.Text = "label1";
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificaciones.Location = new Point(33, 196);
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.RowHeadersWidth = 51;
            dgvCalificaciones.Size = new Size(482, 227);
            dgvCalificaciones.TabIndex = 1;
            // 
            // cmbEvaluaciones
            // 
            cmbEvaluaciones.FormattingEnabled = true;
            cmbEvaluaciones.Location = new Point(196, 42);
            cmbEvaluaciones.Name = "cmbEvaluaciones";
            cmbEvaluaciones.Size = new Size(166, 28);
            cmbEvaluaciones.TabIndex = 2;
            // 
            // btnCapturar
            // 
            btnCapturar.Location = new Point(44, 103);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(138, 68);
            btnCapturar.TabIndex = 3;
            btnCapturar.Text = "Capturar";
            btnCapturar.UseVisualStyleBackColor = true;
            btnCapturar.Click += btnCapturar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(214, 103);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(138, 68);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(377, 103);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(138, 68);
            btnRecargar.TabIndex = 5;
            btnRecargar.Text = "Recargar Todo";
            btnRecargar.UseVisualStyleBackColor = true;
            // 
            // FrmCalificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 450);
            Controls.Add(btnRecargar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCapturar);
            Controls.Add(cmbEvaluaciones);
            Controls.Add(dgvCalificaciones);
            Controls.Add(lblcursos);
            Name = "FrmCalificaciones";
            Text = "FrmCalificaciones";
            Load += FrmCalificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcursos;
        private DataGridView dgvCalificaciones;
        private ComboBox cmbEvaluaciones;
        private Button btnCapturar;
        private Button btnGuardar;
        private Button btnRecargar;
    }
}