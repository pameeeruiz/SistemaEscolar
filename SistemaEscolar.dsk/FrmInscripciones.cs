using SistemaEscolar.Business;
using SistemaEscolar.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.dsk
{
    public partial class FrmInscripciones : Form
    {

        Context db = new Context();

        Cursos cursoSeleccionado;

        List<AlumnosInscritos> listaInscritos =
            new List<AlumnosInscritos>();

        List<Alumnos> listaAlumnos =
            new List<Alumnos>();
        public FrmInscripciones(Cursos curso)
        {
            InitializeComponent();
            cursoSeleccionado = curso;
        }

        private void FrmInscripciones_Load(object sender, EventArgs e)
        {
            lblCurso.Text = cursoSeleccionado.Curso;

            CargarInscritos();

            CargarCombo();

            dgvAlumnos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlumnos.ReadOnly = true;

            dgvAlumnos.MultiSelect = false;
        }

        private void CargarInscritos()
        {
            listaInscritos =
                db.GetAlumnosInscritos(
                    cursoSeleccionado.id_curso_horario
                );

            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = listaInscritos;

            dgvAlumnos.Columns["id_alumno"].Visible = false;
            dgvAlumnos.Columns["id_carrera"].Visible = false;
            dgvAlumnos.Columns["id_inscripcion"].Visible = false;
            dgvAlumnos.Columns["id_curso_horario"].Visible = false;
        }

        private void CargarCombo()
        {
            listaAlumnos = db.GetAlumnos();

            var alumnosDisponibles =
                listaAlumnos.Where(a =>
                    a.id_carrera == cursoSeleccionado.id_carrera
                    &&
                    !listaInscritos.Any(i =>
                        i.id_alumno == a.id_alumno
                    )
                ).ToList();

            cmbAlumnos.DataSource = null;
            cmbAlumnos.DataSource = alumnosDisponibles;

            cmbAlumnos.DisplayMember = "nombre";
            cmbAlumnos.ValueMember = "id_alumno";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbAlumnos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un alumno");
                return;
            }

            int idAlumno =
                Convert.ToInt32(cmbAlumnos.SelectedValue);

            db.InscribirAlumno(
                idAlumno,
                cursoSeleccionado.id_curso_horario
            );

            MessageBox.Show("Alumno inscrito correctamente");

            CargarInscritos();

            CargarCombo();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            FrmAlumnos frm = new FrmAlumnos();

            frm.ShowDialog();

            CargarCombo();
        }
    }
}

