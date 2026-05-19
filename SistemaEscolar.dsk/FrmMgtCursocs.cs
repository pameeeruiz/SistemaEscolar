using SistemaEscolar.Business;
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



namespace SistemaEscolar.dsk
{
    public partial class FrmMgtCursocs : Form
    {
        private string _modo; // "Agregar" o "Editar"
        private Entities.Cursos _cursoActual; // Para almacenar el curso que    

        public FrmMgtCursocs()
        {
            InitializeComponent();
            _modo = "Agregar";
            _cursoActual = new Entities.Cursos();
        }

        public FrmMgtCursocs(Entities.Cursos cursoActual)
        {
            InitializeComponent();
            _modo = "Editar";
            _cursoActual = cursoActual;
        }

        private void FrmMgtCursocs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            Context context = new Context();
            List<Carreras> carreras = context.getCarreras();
            ControllersHelper.LlenarCombo(cmbCarrera, carreras, "nombre", "id_carrera");
            List<Docentes> docentes = context.getDocentes();
            ControllersHelper.LlenarCombo(cmbDocente, docentes, "nombre", "id_docente");

            List<Aulas> aulas = context.getAulas();
            ControllersHelper.LlenarCombo(cmbAula, aulas, "nombre", "id_aula");
            List<Horarios> horarios = context.getHorarios();
            ControllersHelper.LlenarCombo(cmbHorario,
                horarios.Select(
                    h => new
                    {
                        idhorario = h.id_horario,
                        horario = h.dia_semana +
                        " " + h.hora_inicio.ToString() +
                        "-" + h.hora_fin.ToString()
                    }
                ).ToList(), "horario", "idhorario");
            List<Periodos> periodos = context.getPeriodos();
            ControllersHelper.LlenarCombo(cmbPeriodo,
                periodos.Select(
                    p => new
                    {
                        idperiodo = p.id_periodo,
                        periodo = p.id_periodo +
                        " " + p.nombre +
                        " " + p.fecha_inicio.ToString("yyyy-MM-dd") +
                       " - " + p.fecha_fin.ToString("yyyy-MM-dd")
                    }
                ).ToList(), "periodo", "idperiodo");

            if (_modo == "Editar")
            {
                // Cargar los datos del curso actual en los controles
                txtCurso.Text = _cursoActual.Curso;
                txtCreditos.Text = _cursoActual.Creditos.ToString();
                cmbCarrera.SelectedValue = _cursoActual.id_carrera;
                cmbDocente.SelectedValue = _cursoActual.id_docente;
                cmbAula.SelectedValue = _cursoActual.id_aula;
                cmbHorario.SelectedValue = _cursoActual.id_horario;
                cmbPeriodo.SelectedValue = _cursoActual.id_periodo;
            }




        }






        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_modo.Equals("Agregar"))
            {
                AgregarCurso();
            }
            else if (_modo.Equals("Editar"))
            {
                ActualizarCurso();
            }
            this.Hide();
        }



        private void AgregarCurso()
        {
            try
            {
                _cursoActual = new Entities.Cursos
                {
                    Curso = txtCurso.Text,
                    Creditos = int.Parse(txtCreditos.Text),
                    Carrera = cmbCarrera.SelectedText,
                    id_carrera = (int)(cmbCarrera.SelectedValue),
                    Docente = cmbDocente.SelectedText,
                    id_docente = (int)(cmbDocente.SelectedValue),
                    Aula = cmbAula.SelectedText,
                    id_aula = (int)(cmbAula.SelectedValue),
                    Horarios = cmbHorario.SelectedText,
                    id_horario = (int)(cmbHorario.SelectedValue),
                    Periodo = cmbPeriodo.SelectedText,
                    id_periodo = (int)(cmbPeriodo.SelectedValue)
                };
                new Context().AgregarCurso(_cursoActual);
                MessageBox.Show("Curso agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el curso: " + ex.Message);
            }
        }

        private void ActualizarCurso()
        {
            try
            {
                _cursoActual.Curso = txtCurso.Text;
                _cursoActual.Creditos = int.Parse(txtCreditos.Text);
                _cursoActual.Carrera = cmbCarrera.SelectedText;
                _cursoActual.id_carrera = (int)(cmbCarrera.SelectedValue);
                _cursoActual.Docente = cmbDocente.SelectedText;
                _cursoActual.id_docente = (int)(cmbDocente.SelectedValue);
                _cursoActual.Aula = cmbAula.SelectedText;
                _cursoActual.id_aula = (int)(cmbAula.SelectedValue);
                _cursoActual.Horarios = cmbHorario.SelectedText;
                _cursoActual.id_horario = (int)(cmbHorario.SelectedValue);
                _cursoActual.Periodo = cmbPeriodo.SelectedText;
                _cursoActual.id_periodo = (int)(cmbPeriodo.SelectedValue);
                new Context().ActualizarCurso(_cursoActual);
                MessageBox.Show("Curso actualizado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el curso: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
