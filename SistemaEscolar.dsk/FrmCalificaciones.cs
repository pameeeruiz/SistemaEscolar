using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscolar.Entities;
using SistemaEscolar.Business;
using SistemaEscolar.Data;

namespace SistemaEscolar.dsk
{
    public partial class FrmCalificaciones : Form
    {
        private Context context = new Context();

        private List<Evaluaciones> _evaluaciones;
        private List<CalificacionesXCurso> _calificaciones;
        private Cursos _cursoActual;
        public FrmCalificaciones(Cursos cursoActual)
        {
            InitializeComponent();
            _cursoActual = cursoActual;
        }

        private void FrmCalificaciones_Load(object sender, EventArgs e)
        {
            lblcursos.Text =
        $"{_cursoActual.Curso} - {_cursoActual.Aulas} - {_cursoActual.Horarios} - {_cursoActual.Periodo}";

            LoadData();

        }

        private void LoadData()
        {
            _evaluaciones = context.GetEvaluaciones(_cursoActual.id_curso_horario);

            _calificaciones = context.GetCalificacionesXCurso(_cursoActual.id_curso_horario);

            dgvCalificaciones.DataSource = null;
            dgvCalificaciones.DataSource = _calificaciones;

            ConfigurarGrid();
            CargarCombo();
        }


        private void ConfigurarGrid()
        {
            dgvCalificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvCalificaciones.Columns["id_inscripcion"] != null)
                dgvCalificaciones.Columns["id_inscripcion"].Visible = false;

            if (dgvCalificaciones.Columns["Alumno"] != null)
                dgvCalificaciones.Columns["Alumno"].ReadOnly = true;

            if (dgvCalificaciones.Columns["Final"] != null)
                dgvCalificaciones.Columns["Final"].ReadOnly = true;

            // ocultar porcentajes
            if (dgvCalificaciones.Columns["pParcial1"] != null)
                dgvCalificaciones.Columns["pParcial1"].Visible = false;

            if (dgvCalificaciones.Columns["pParcial2"] != null)
                dgvCalificaciones.Columns["pParcial2"].Visible = false;

            if (dgvCalificaciones.Columns["pParcial3"] != null)
                dgvCalificaciones.Columns["pParcial3"].Visible = false;

            if (dgvCalificaciones.Columns["pOrdinario"] != null)
                dgvCalificaciones.Columns["pOrdinario"].Visible = false;
        }


        private void CargarCombo()
        {
            cmbEvaluaciones.DataSource = null;
            cmbEvaluaciones.DataSource = _evaluaciones;

            cmbEvaluaciones.DisplayMember = "Evaluacion";
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (cmbEvaluaciones.SelectedIndex < 0) return;

            string columna = cmbEvaluaciones.Text.Replace(" ", "");

            foreach (DataGridViewColumn col in dgvCalificaciones.Columns)
            {
                col.ReadOnly = true;
            }

            if (dgvCalificaciones.Columns[columna] != null)
            {
                dgvCalificaciones.Columns[columna].ReadOnly = false;
                dgvCalificaciones.CurrentCell = dgvCalificaciones.Rows[0].Cells[columna];
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEvaluaciones.SelectedIndex < 0) return;

            int idEvaluacion = Convert.ToInt32(cmbEvaluaciones.SelectedValue);
            string columna = cmbEvaluaciones.Text.Replace(" ", "");

            foreach (DataGridViewRow row in dgvCalificaciones.Rows)
            {
                if (row.Cells["id_inscripcion"].Value == null)
                    continue;

                int idInscripcion = Convert.ToInt32(row.Cells["id_inscripcion"].Value);

                decimal calificacion = 0;

                if (row.Cells[columna].Value != null)
                {
                    decimal.TryParse(row.Cells[columna].Value.ToString(), out calificacion);
                }

                context.ActualizarCalificacion(
                    idInscripcion,
                    idEvaluacion,
                    calificacion
                );
            }

            LoadData();
        }
    }

}
