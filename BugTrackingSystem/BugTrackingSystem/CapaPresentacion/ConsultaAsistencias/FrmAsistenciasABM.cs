using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.CapaPresentacion
{
    public partial class FrmAsistenciasABM : Form
    {
        private FormMode formMode = FormMode.nuevo;

        private readonly UsuarioService usuarioService;
        private readonly EstadoAsistenciaService estadoAsistenciaService;
        private readonly AsistenciaUsuarioService asistenciaUsuarioService;
        private AsistenciaUsuario asistenciaUsuarioSeleccionada;

        public FrmAsistenciasABM()
        {
            InitializeComponent();
            btnVolver.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            usuarioService = new UsuarioService();
            estadoAsistenciaService = new EstadoAsistenciaService();
            asistenciaUsuarioService = new AsistenciaUsuarioService();
            btnSalir.FlatAppearance.BorderSize = 0;
        }

        public enum FormMode
        {
            nuevo,
            actualizar
        }

        private void LlenarCombo(ComboBox cbx, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbx.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbx.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbx.ValueMember = value;
            // SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbx.SelectedIndex = -1;
        }

        private void FrmAsistenciasABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "IdUsuario");
            LlenarCombo(cboEstado, estadoAsistenciaService.ObtenerEstadosAsistencia(), "Nombre", "IdEstadoAsistencia");

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nueva Asistencia";
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Asistencia";
                        lblTitulo.Text = "Actualizar Asistencia";
                        cboUsuario.SelectedValue = asistenciaUsuarioSeleccionada.Usuario.IdUsuario;
                        cboEstado.SelectedValue = asistenciaUsuarioSeleccionada.EstadoAsistencia.IdEstadoAsistencia;
                        dateFecha.Value = asistenciaUsuarioSeleccionada.Fecha;
                        dateHoraIngreso.Value = asistenciaUsuarioSeleccionada.HoraIngreso;
                        dateHoraSalida.Value = asistenciaUsuarioSeleccionada.HoraSalida;
                        rtxtComentario.Text = asistenciaUsuarioSeleccionada.Comentario;
                        break;
                    }
            }
        }

        public void InicializarFormulario(FormMode formMode, AsistenciaUsuario asistenciaUsuario)
        {
            this.formMode = formMode;
            asistenciaUsuarioSeleccionada = asistenciaUsuario;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            AsistenciaUsuario asistenciaUsuario = new AsistenciaUsuario();
            asistenciaUsuario.Usuario = new Usuario();
            asistenciaUsuario.EstadoAsistencia = new EstadoAsistencia();

            if (cboUsuario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                asistenciaUsuario.Usuario.IdUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            }

            asistenciaUsuario.Fecha = Convert.ToDateTime(dateFecha.Value);

            DateTime.TryParse(dateHoraIngreso.Text, out DateTime horaDesde);
            asistenciaUsuario.HoraIngreso = horaDesde;

            DateTime.TryParse(dateHoraSalida.Text, out DateTime horaHasta);
            asistenciaUsuario.HoraSalida = horaHasta;

            if (cboEstado.SelectedValue != null)
                asistenciaUsuario.EstadoAsistencia.IdEstadoAsistencia = Convert.ToInt32(cboEstado.SelectedValue);
            else
            {
                Dictionary<string, object> parametroSinAsignar = new Dictionary<string, object>();
                parametroSinAsignar.Add("nombreEstadoAsistencia", "Sin Asignar");
                asistenciaUsuario.EstadoAsistencia.IdEstadoAsistencia = Convert.ToInt32(estadoAsistenciaService.ObtenerEstadosAsistencia(parametroSinAsignar)[0].IdEstadoAsistencia);
            }

            if (!string.IsNullOrEmpty(rtxtComentario.Text))
                asistenciaUsuario.Comentario = rtxtComentario.Text;
            else
                asistenciaUsuario.Comentario = "";

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (asistenciaUsuarioService.CrearAsistenciaUsuario(asistenciaUsuario))
                        {
                            MessageBox.Show("¡Registro creado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            rtxtComentario.Text = "";
                            cboEstado.SelectedIndex = -1;
                            cboUsuario.SelectedIndex = -1;
                            dateFecha.Value = DateTime.Today;
                        }
                        else
                            MessageBox.Show("El registro no se ha podido crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        asistenciaUsuario.IdAsistenciaUsuario = asistenciaUsuarioSeleccionada.IdAsistenciaUsuario;

                        if (asistenciaUsuarioService.ActualizarAsistenciaUsuario(asistenciaUsuario))
                        {
                            MessageBox.Show("Asistencia actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar la asistencia!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
