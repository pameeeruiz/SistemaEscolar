namespace SistemaEscolar.dsk
{
    partial class FrmMgtCursocs
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
            txtCurso = new TextBox();
            txtCreditos = new TextBox();
            cmbCarrera = new ComboBox();
            cmbAula = new ComboBox();
            cmbDocente = new ComboBox();
            cmbHorario = new ComboBox();
            cmbPeriodo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(133, 97);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(155, 27);
            txtCurso.TabIndex = 0;
            // 
            // txtCreditos
            // 
            txtCreditos.Location = new Point(133, 183);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(155, 27);
            txtCreditos.TabIndex = 1;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(361, 213);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(141, 28);
            cmbCarrera.TabIndex = 2;
            // 
            // cmbAula
            // 
            cmbAula.FormattingEnabled = true;
            cmbAula.Location = new Point(528, 78);
            cmbAula.Name = "cmbAula";
            cmbAula.Size = new Size(135, 28);
            cmbAula.TabIndex = 3;
            // 
            // cmbDocente
            // 
            cmbDocente.FormattingEnabled = true;
            cmbDocente.Location = new Point(367, 78);
            cmbDocente.Name = "cmbDocente";
            cmbDocente.Size = new Size(135, 28);
            cmbDocente.TabIndex = 4;
           
            // 
            // cmbHorario
            // 
            cmbHorario.FormattingEnabled = true;
            cmbHorario.Location = new Point(528, 213);
            cmbHorario.Name = "cmbHorario";
            cmbHorario.Size = new Size(135, 28);
            cmbHorario.TabIndex = 5;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(429, 149);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(166, 28);
            cmbPeriodo.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(133, 316);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(175, 68);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(382, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 68);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 104);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 9;
            label1.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 183);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 10;
            label2.Text = "Creditos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 190);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 11;
            label3.Text = "Carrera:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 55);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 12;
            label4.Text = "Docente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 55);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 13;
            label5.Text = "Aula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(560, 190);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 14;
            label6.Text = "Horario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 126);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 15;
            label7.Text = "Periodo:";
            // 
            // FrmMgtCursocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 421);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbPeriodo);
            Controls.Add(cmbHorario);
            Controls.Add(cmbDocente);
            Controls.Add(cmbAula);
            Controls.Add(cmbCarrera);
            Controls.Add(txtCreditos);
            Controls.Add(txtCurso);
            Name = "FrmMgtCursocs";
            Text = "FrmMgtCursocs";
            Load += FrmMgtCursocs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurso;
        private TextBox txtCreditos;
        private ComboBox cmbCarrera;
        private ComboBox cmbAula;
        private ComboBox cmbDocente;
        private ComboBox cmbHorario;
        private ComboBox cmbPeriodo;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}