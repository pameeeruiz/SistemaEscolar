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
        private Entities.Cursos _cursoActual;

        // Constructor por defecto añadido para compatibilidad con llamadas sin parámetro.
        public FrmCalificaciones()
        {
            InitializeComponent();
            // Valores por defecto seguros para evitar NRE y permitir abrir el formulario desde llamadas antiguas.
            _cursoActual = new Entities.Cursos
            {
                id_curso = 0,
                id_curso_horario = 0,
                Curso = "(Sin curso)",
                Aula = "",
                Horarios = "",
                Periodo = ""
            };
        }

        public FrmCalificaciones(Entities.Cursos cursoActual)
        {
            InitializeComponent();
            _cursoActual = cursoActual ?? new Entities.Cursos
            {
                id_curso = 0,
                id_curso_horario = 0,
                Curso = "(Sin curso)",
                Aula = "",
                Horarios = "",
                Periodo = ""
            };
        }

        private void FrmCalificaciones_Load(object sender, EventArgs e)
        {
            lblcursos.Text =
        $"{_cursoActual.Curso} - {_cursoActual.Aula} - {_cursoActual.Horarios} - {_cursoActual.Periodo}";

            LoadData();
        }

        private void LoadData()
        {
            // Obtener evaluaciones por id_curso_horario (configuración de parciales)
            _evaluaciones = context.GetEvaluaciones(_cursoActual.id_curso_horario);

            // Obtener calificaciones agrupadas por id_inscripcion: sp espera id_curso -> pasamos id_curso
            _calificaciones = context.GetCalificacionesXCurso(_cursoActual.id_curso);

            dgvCalificaciones.DataSource = null;
            dgvCalificaciones.DataSource = _calificaciones ?? new List<CalificacionesXCurso>();

            ConfigurarGrid();
            CargarCombo();
            ConfigurarEncabezados();
        }

        private void ConfigurarEncabezados()
        {
            SetHeader("Parcial1", "Parcial 1");
            SetHeader("Parcial2", "Parcial 2");
            SetHeader("Parcial3", "Parcial 3");
            SetHeader("Ordinario", "Ordinario");
        }

        private void SetHeader(string columna, string evaluacion)
        {
            if (!dgvCalificaciones.Columns.Contains(columna)) return;
            if (_evaluaciones == null) return;

            var eval = _evaluaciones
                .FirstOrDefault(e => e.Evaluacion?.Trim() == evaluacion);

            string porcentaje = eval != null
                ? (eval.Porcentaje * 100).ToString() + "%"
                : "0%";

            dgvCalificaciones.Columns[columna].HeaderText =
                $"{evaluacion}\n{porcentaje}";
        }


        private void ConfigurarGrid()
        {
            dgvCalificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvCalificaciones.Columns.Contains("id_inscripcion"))
                dgvCalificaciones.Columns["id_inscripcion"].Visible = false;

            if (dgvCalificaciones.Columns.Contains("Alumno"))
                dgvCalificaciones.Columns["Alumno"].ReadOnly = true;

            if (dgvCalificaciones.Columns.Contains("Final"))
                dgvCalificaciones.Columns["Final"].ReadOnly = true;

            // ocultar porcentajes
            string[] ocultas = { "pParcial1", "pParcial2", "pParcial3", "pOrdinario" };

            foreach (var col in ocultas)
            {
                if (dgvCalificaciones.Columns.Contains(col))
                    dgvCalificaciones.Columns[col].Visible = false;
            }
        }


        private void CargarCombo()
        {
            cmbEvaluaciones.DataSource = null;
            if (_evaluaciones == null)
                _evaluaciones = new List<Evaluaciones>();

            cmbEvaluaciones.DataSource = _evaluaciones;

            cmbEvaluaciones.DisplayMember = "Evaluacion";
            cmbEvaluaciones.ValueMember = "id_evaluacion";
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (cmbEvaluaciones.SelectedIndex < 0) return;

            string columna = ObtenerColumna(cmbEvaluaciones.Text);

            if (string.IsNullOrEmpty(columna)) return;

            foreach (DataGridViewColumn col in dgvCalificaciones.Columns)
                col.ReadOnly = true;

            if (dgvCalificaciones.Columns.Contains(columna))
            {
                dgvCalificaciones.Columns[columna].ReadOnly = false;
                if (dgvCalificaciones.Rows.Count > 0)
                    dgvCalificaciones.CurrentCell =
                        dgvCalificaciones.Rows[0].Cells[columna];
            }
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                if (cmbEvaluaciones.SelectedIndex < 0) return;

            int idEvaluacion = Convert.ToInt32(cmbEvaluaciones.SelectedValue);
            string columna = ObtenerColumna(cmbEvaluaciones.Text);

            if (string.IsNullOrEmpty(columna)) return;

            foreach (DataGridViewRow row in dgvCalificaciones.Rows)
            {
                if (row.IsNewRow) continue;
                if (!dgvCalificaciones.Columns.Contains(columna)) continue;
                if (row.Cells["id_inscripcion"].Value == null) continue;

                int idInscripcion = Convert.ToInt32(row.Cells["id_inscripcion"].Value);

                decimal calificacion = 0;

                var valor = row.Cells[columna].Value;

                if (valor != null && valor != DBNull.Value && valor.ToString() != "")
                {
                    decimal.TryParse(valor.ToString(), out calificacion);
                }

                // Llama al contexto para insertar/actualizar la calificación
                context.ActualizarCalificacion(
                    idInscripcion,
                    idEvaluacion,
                    calificacion
                );
            }

            LoadData();
        }


        private string ObtenerColumna(string evaluacion)
        {
            switch (evaluacion)
            {
                case "Parcial 1": return "Parcial1";
                case "Parcial 2": return "Parcial2";
                case "Parcial 3": return "Parcial3";
                case "Ordinario": return "Ordinario";
                default: return "";
            }
        }
    }

}
