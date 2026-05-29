namespace SistemaEscolar.dsk
{
    partial class FrmAlumnos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            cmbCarrera = new ComboBox();
            cmbEstatus = new ComboBox();
            btnNuevo = new Button();
            btnBuscar = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 72);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Matrícula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 115);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = " Nombre:   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 160);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 52);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Carrera:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 133);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Estatus:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(130, 69);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(182, 27);
            txtMatricula.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(130, 157);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(182, 27);
            txtCorreo.TabIndex = 7;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(430, 75);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(200, 28);
            cmbCarrera.TabIndex = 8;
            // 
            // cmbEstatus
            // 
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Location = new Point(430, 160);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(200, 28);
            cmbEstatus.TabIndex = 9;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(33, 290);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(118, 76);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(155, 290);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 76);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(276, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 76);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(397, 289);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 76);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(518, 290);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 76);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(639, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 76);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(btnNuevo);
            Controls.Add(cmbEstatus);
            Controls.Add(cmbCarrera);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtMatricula);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAlumnos";
            Text = "FrmAlumnos";
            Load += FrmAlumnos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private ComboBox cmbCarrera;
        private ComboBox cmbEstatus;
        private Button btnNuevo;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}