namespace SistemaEscolar.dsk
{
    partial class Cursos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgCursos = new DataGridView();
            btnInscripciones = new Button();
            btnSalir = new Button();
            btnAgregarCursos = new Button();
            btnEditarCursos = new Button();
            btnActualizarCursos = new Button();
            btnCalificaciones = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCursos).BeginInit();
            SuspendLayout();
            // 
            // dtgCursos
            // 
            dtgCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCursos.Cursor = Cursors.No;
            dtgCursos.Location = new Point(12, 95);
            dtgCursos.Name = "dtgCursos";
            dtgCursos.RowHeadersWidth = 51;
            dtgCursos.Size = new Size(995, 322);
            dtgCursos.TabIndex = 0;
            // 
            // btnInscripciones
            // 
            btnInscripciones.Location = new Point(112, 12);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(191, 69);
            btnInscripciones.TabIndex = 1;
            btnInscripciones.Text = "Inscripciones";
            btnInscripciones.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(621, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(191, 69);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarCursos
            // 
            btnAgregarCursos.Location = new Point(50, 432);
            btnAgregarCursos.Name = "btnAgregarCursos";
            btnAgregarCursos.Size = new Size(113, 48);
            btnAgregarCursos.TabIndex = 4;
            btnAgregarCursos.Text = "Agregar Cursos";
            btnAgregarCursos.UseVisualStyleBackColor = true;
            btnAgregarCursos.Click += button4_Click;
            // 
            // btnEditarCursos
            // 
            btnEditarCursos.Location = new Point(239, 432);
            btnEditarCursos.Name = "btnEditarCursos";
            btnEditarCursos.Size = new Size(113, 48);
            btnEditarCursos.TabIndex = 5;
            btnEditarCursos.Text = "Editar Cursos";
            btnEditarCursos.UseVisualStyleBackColor = true;
            btnEditarCursos.Click += btnEditarCursos_Click;
            // 
            // btnActualizarCursos
            // 
            btnActualizarCursos.Location = new Point(453, 432);
            btnActualizarCursos.Name = "btnActualizarCursos";
            btnActualizarCursos.Size = new Size(113, 48);
            btnActualizarCursos.TabIndex = 6;
            btnActualizarCursos.Text = "Actualizar Cursos";
            btnActualizarCursos.UseVisualStyleBackColor = true;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.Location = new Point(364, 12);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(191, 69);
            btnCalificaciones.TabIndex = 7;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = true;
            // 
            // Cursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 588);
            Controls.Add(btnCalificaciones);
            Controls.Add(btnActualizarCursos);
            Controls.Add(btnEditarCursos);
            Controls.Add(btnAgregarCursos);
            Controls.Add(btnSalir);
            Controls.Add(btnInscripciones);
            Controls.Add(dtgCursos);
            Name = "Cursos";
            Text = "Form1";
            Load += Cursos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgCursos;
        private Button btnInscripciones;
        private Button btnSalir;
        private Button button2;
        private Button button3;
        private Button btnAgregarCursos;
        private Button btnEditarCursos;
        private Button btnActualizarCursos;
        private Button btnCalificaciones;
    }
}
