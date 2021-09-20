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
    public partial class FrmConsultaAsignacionesAgregar : Form
    {
        private readonly UsuarioService usuarioService;
        private readonly EstadoAsistenciaService estadoAsistenciaService;
        private readonly AsistenciaUsuarioService asistenciaUsuarioService;

        public FrmConsultaAsignacionesAgregar()
        {
            InitializeComponent();
            btnVolver.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            usuarioService = new UsuarioService();
            estadoAsistenciaService = new EstadoAsistenciaService();
            asistenciaUsuarioService = new AsistenciaUsuarioService();
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

        private void FrmConsultaAsignacionesAgregar_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "IdUsuario");
            LlenarCombo(cboEstado, estadoAsistenciaService.ObtenerEstadosAsistencia(), "Nombre", "IdEstadoAsistencia");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AsistenciaUsuario asistenciaUsuario = new AsistenciaUsuario();

            if (cboUsuario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dictionary<string, object> parametro = new Dictionary<string, object>();
                parametro.Add("idUsuario", cboUsuario.SelectedValue);
                asistenciaUsuario.Usuario = usuarioService.ObtenerUsuarios(parametro)[0];
            }

            asistenciaUsuario.Fecha = Convert.ToDateTime(dateFecha.Value);

            if (dateHoraIngreso.Checked)
                asistenciaUsuario.HoraIngreso = dateHoraIngreso.Value;

            if (dateHoraSalida.Checked)
                asistenciaUsuario.HoraSalida = dateHoraSalida.Value;

            if (cboEstado.SelectedValue != null)
            {
                Dictionary<string, object> parametro = new Dictionary<string, object>();
                parametro.Add("idEstadoAsistencia", cboEstado.SelectedValue);
                asistenciaUsuario.EstadoAsistencia = estadoAsistenciaService.ObtenerEstadosAsistencia(parametro)[0];
            }

            if (!string.IsNullOrEmpty(rtxtComentario.Text))
                asistenciaUsuario.Comentario = rtxtComentario.Text;

            if (asistenciaUsuarioService.CrearAsistenciaUsuario(asistenciaUsuario))
            {
                MessageBox.Show("Registro creado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtxtComentario.Text = "";
                cboEstado.SelectedIndex = -1;
                cboUsuario.SelectedIndex = -1;
                dateFecha.Value = DateTime.Today;
            }
            else
                MessageBox.Show("El registro no se ha podido crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: VER TEMA DE AÑADIR NULLS DENTRO DE LOS REGISTROS SQL

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
