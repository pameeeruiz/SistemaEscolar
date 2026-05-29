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
    public partial class FrmAlumnos : Form
    {
        private string _modo;

        private Alumnos _alumnoActual;

        public FrmAlumnos()
        {
            InitializeComponent();
            _modo = "Agregar";
            _alumnoActual = new Alumnos();
        }

        public FrmAlumnos(Alumnos alumnoActual)
        {
            InitializeComponent();

            _modo = "Editar";

            _alumnoActual = alumnoActual;
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void LoadData()
        {
            Context context = new Context();

            List<Carreras> carreras =
                context.getCarreras();

            ControllersHelper.LlenarCombo(
                cmbCarrera,
                carreras,
                "nombre",
                "id_carrera"
            );

            cmbEstatus.Items.Add("Activo");
            cmbEstatus.Items.Add("Inactivo");

            if (_modo == "Editar")
            {
                txtNombre.Text =
                    _alumnoActual.nombre;

                txtMatricula.Text =
                    _alumnoActual.matricula;

                txtCorreo.Text =
                    _alumnoActual.correo;

                cmbCarrera.SelectedValue =
                    _alumnoActual.id_carrera;

                cmbEstatus.Text =
                    _alumnoActual.Estatus;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarAlumno();
        }
        private void GuardarAlumno()
        {
            try
            {
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Ingresa nombre");
                    return;
                }

                if (txtMatricula.Text.Trim() == "")
                {
                    MessageBox.Show("Ingresa matrícula");
                    return;
                }

                if (txtCorreo.Text.Trim() == "")
                {
                    MessageBox.Show("Ingresa correo");
                    return;
                }

                if (cmbCarrera.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona carrera");
                    return;
                }

                _alumnoActual.nombre =
                    txtNombre.Text;

                _alumnoActual.matricula =
                    txtMatricula.Text;

                _alumnoActual.correo =
                    txtCorreo.Text;

                _alumnoActual.id_carrera =
                    Convert.ToInt32(cmbCarrera.SelectedValue);

                _alumnoActual.Estatus =
                    cmbEstatus.Text;

                Context context = new Context();

                if (_modo == "Agregar")
                {
                    context.AgregarAlumno(_alumnoActual);

                    MessageBox.Show(
                        "Alumno agregado correctamente"
                    );
                }
                else
                {
                    context.ActualizarAlumno(_alumnoActual);

                    MessageBox.Show(
                        "Alumno actualizado correctamente"
                    );
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_modo != "Editar")
            {
                MessageBox.Show(
                    "Debes cargar un alumno"
                );

                return;
            }

            DialogResult r =
                MessageBox.Show(
                    "¿Eliminar alumno?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

            if (r == DialogResult.Yes)
            {
                Context context = new Context();

                context.EliminarAlumno(
                    _alumnoActual.id_alumno
                );

                MessageBox.Show(
                    "Alumno eliminado"
                );

                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Context context = new Context();

            List<Alumnos> lista =
                context.BuscarAlumno(
                    txtNombre.Text
                );

            if (lista.Count > 0)
            {
                _alumnoActual = lista[0];

                _modo = "Editar";

                LoadData();

                MessageBox.Show(
                    "Alumno encontrado"
                );
            }
            else
            {
                MessageBox.Show(
                    "Alumno no encontrado"
                );
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();

            txtMatricula.Clear();

            txtCorreo.Clear();

            cmbCarrera.SelectedIndex = -1;

            cmbEstatus.SelectedIndex = -1;

            cmbEstatus.Text = "Activo";

            _modo = "Agregar";

            _alumnoActual = new Alumnos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _modo = "Editar";

            MessageBox.Show(
                "Modo edición activado"
            );
        }
    }
}
