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

        public FrmConsultaAsignaciones()
        {
            InitializeComponent();
            InitializeDataGridView();
            asistenciaService = new AsistenciaUsuarioService();
            usuarioService = new UsuarioService();
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

            var usuario = "";
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
            IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerConFiltros(parametros);

            dgvConsultaAsistencias.DataSource = listadoAsistencias;
            if (listadoAsistencias.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvConsultaAsistencias.ColumnCount = 10;
            dgvConsultaAsistencias.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvConsultaAsistencias.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvConsultaAsistencias.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            dgvConsultaAsistencias.Columns[0].Name = "Nombre";
            dgvConsultaAsistencias.Columns[0].DataPropertyName = "Usuario";

            dgvConsultaAsistencias.Columns[1].Name = "Fecha";
            dgvConsultaAsistencias.Columns[1].DataPropertyName = "fecha";

            dgvConsultaAsistencias.Columns[2].Name = "Hora Ingreso";
            dgvConsultaAsistencias.Columns[2].DataPropertyName = "HoraIngreso";

            dgvConsultaAsistencias.Columns[3].Name = "Hora Salida";
            dgvConsultaAsistencias.Columns[3].DataPropertyName = "HoraSalida";

            dgvConsultaAsistencias.Columns[4].Name = "Estado";
            dgvConsultaAsistencias.Columns[4].DataPropertyName = "EstadoAsistencia";

            dgvConsultaAsistencias.Columns[5].Name = "Comentario";
            dgvConsultaAsistencias.Columns[5].DataPropertyName = "Comentario";

            dgvConsultaAsistencias.Columns[6].Name = "Borrado";
            dgvConsultaAsistencias.Columns[6].DataPropertyName = "Borrado";

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvConsultaAsistencias.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvConsultaAsistencias.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void FrmConsultaAsignaciones_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerTodos(), "Nombre", "Nombre");

        }
    }
}
