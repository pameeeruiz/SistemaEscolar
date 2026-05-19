
namespace SistemaEscolar.dsk
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }
        public void CargarCursos()
        {
            Business.Context context = new Business.Context();
            List<Entities.Cursos> cursos = context.GetCursos();
            dtgCursos.DataSource = cursos;
        }

        public void Cursos_Load(object sender, EventArgs e)
        {
            CargarCursos();
            dtgCursos.Columns["id_curso"].Visible = false;
            dtgCursos.Columns["id_carrera"].Visible = false;
            dtgCursos.Columns["id_curso_horario"].Visible = false;
            dtgCursos.Columns["id_docente"].Visible = false;
            dtgCursos.Columns["id_aula"].Visible = false;
            dtgCursos.Columns["id_horario"].Visible = false;
            dtgCursos.Columns["id_periodo"].Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //agregar cursos
            FrmMgtCursocs frmMgtCursocs = new FrmMgtCursocs();
            frmMgtCursocs.ShowDialog();
            CargarCursos();

            frmMgtCursocs.Close();
        }

        private void btnEditarCursos_Click(object sender, EventArgs e)
        {
            if (dtgCursos.CurrentRow != null)
            {
                Entities.Cursos cursoSeleccionado = (Entities.Cursos)dtgCursos.CurrentRow.DataBoundItem;
                FrmMgtCursocs frmMgtCursos = new FrmMgtCursocs(cursoSeleccionado);
                frmMgtCursos.ShowDialog();
                CargarCursos();
                frmMgtCursos.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un curso para editar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
               "¿Deseas salir?",
               "Confirmar",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    public class ControllersHelper
    {
        /// <summary>
        /// Llena un ComboBox con cualquier lista de objetos.
        /// </summary>
        /// <typeparam name="T">El tipo de objeto en la lista</typeparam>
        /// <param name="combo">El control ComboBox</param>
        /// <param name="lista">La fuente de datos</param>
        /// <param name="campoTexto">Nombre de la propiedad para mostrar (Text)</param>
        /// <param name="campoValor">Nombre de la propiedad para el valor interno (Value)</param>
        public static void LlenarCombo<T>(ComboBox combo, List<T> lista, string campoTexto, string campoValor)
        {
            // Limpiamos cualquier dato previo
            combo.DataSource = null;
            if (lista != null && lista.Count > 0)
            {
                // Asignamos el mapeo de nombres de propiedades
                combo.DisplayMember = campoTexto;
                combo.ValueMember = campoValor;
                // Asignamos la lista como fuente de datos
                combo.DataSource = lista;
                combo.SelectedIndex = -1;
            }
        }
    }

}
