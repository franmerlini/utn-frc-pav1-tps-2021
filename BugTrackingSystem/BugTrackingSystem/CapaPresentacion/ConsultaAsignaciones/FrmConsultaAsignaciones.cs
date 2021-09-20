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
    public partial class FrmConsultaAsignaciones : Form
    {
        private readonly AsistenciaUsuarioService asistenciaService;
        private readonly UsuarioService usuarioService;
        private readonly EstadoAsistenciaService estadoAsistenciaService;

        public FrmConsultaAsignaciones()
        {
            InitializeComponent();
            InitializeDataGridView();

            btnConsultar.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnInformacion.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnDeshacer.FlatAppearance.BorderSize = 0;
            btnRehacer.FlatAppearance.BorderSize = 0;

            asistenciaService = new AsistenciaUsuarioService();
            usuarioService = new UsuarioService();
            estadoAsistenciaService = new EstadoAsistenciaService();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Sección reviso de filtros:

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (DateTime.TryParse(dateFechaDesde.Text, out DateTime fechaDesde) && dateFechaDesde.Checked)
            {
                parametros.Add("fechaDesde", fechaDesde);
            }

            if (DateTime.TryParse(dateFechaHasta.Text, out DateTime fechaHasta) && dateFechaHasta.Checked)
            {
                parametros.Add("fechaHasta", fechaHasta);
            }

            string usuario;
            if (cboUsuario.SelectedValue == null)
                usuario = cboUsuario.Text;
            else
                usuario = cboUsuario.SelectedValue.ToString();

            if (!string.IsNullOrEmpty(usuario))
            {
                parametros.Add("usuario", usuario);
            }

            if (!string.IsNullOrEmpty(cboEstado.Text))
            {
                var idEstadoAsistencia = cboEstado.SelectedValue.ToString();
                parametros.Add("idEstado", idEstadoAsistencia);
            }

            if (!ChkBaja.Checked)
            {
                parametros.Add("borrado", false);
            }

            // Solicitamos la lista de bugs que cumplan con los filtros:
            IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerAsistenciasUsuario(parametros);

            dgvConsultaAsistencias.DataSource = listadoAsistencias;
            if (listadoAsistencias.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvConsultaAsistencias.ColumnCount = 7;
            dgvConsultaAsistencias.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvConsultaAsistencias.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvConsultaAsistencias.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(dgvConsultaAsistencias, 0, "Nombre", "Usuario", 150);
            CrearColumnas(dgvConsultaAsistencias, 1, "Fecha", "Fecha", 70);
            CrearColumnas(dgvConsultaAsistencias, 2, "Hora Ingreso", "HoraIngreso", 100);
            CrearColumnas(dgvConsultaAsistencias, 3, "Hora Salida", "HoraSalida", 100);
            CrearColumnas(dgvConsultaAsistencias, 4, "Estado", "EstadoAsistencia", 110);
            CrearColumnas(dgvConsultaAsistencias, 5, "Comentario", "Comentario", 320);
            CrearColumnas(dgvConsultaAsistencias, 6, "Borrado", "Borrado", 80);

        }

        private void FrmConsultaAsignaciones_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "Nombre");
            LlenarCombo(cboEstado, estadoAsistenciaService.ObtenerEstadosAsistencia(), "Nombre", "IdEstadoAsistencia");
        }

        private void LlenarCombo(ComboBox cbx, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbx.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbx.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbx.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbx.SelectedIndex = -1;
        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmConsultaAsignacionesAgregar frmAgregar = new FrmConsultaAsignacionesAgregar();
            frmAgregar.ShowDialog();
        }
    }
}
