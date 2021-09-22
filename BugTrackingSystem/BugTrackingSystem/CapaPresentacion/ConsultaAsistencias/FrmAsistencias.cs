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
    public partial class FrmAsistencias : Form
    {
        private readonly AsistenciaUsuarioService asistenciaService;
        private readonly UsuarioService usuarioService;
        private readonly EstadoAsistenciaService estadoAsistenciaService;

        private Dictionary<string, object> parametros = new Dictionary<string, object>();

        public FrmAsistencias()
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
            parametros.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Sección reviso de filtros:

            parametros.Clear();

            if (DateTime.TryParse(dateFechaDesde.Text, out DateTime fechaDesde) && dateFechaDesde.Checked)
            {
                parametros.Add("fechaDesde", fechaDesde);
            }

            if (DateTime.TryParse(dateFechaHasta.Text, out DateTime fechaHasta) && dateFechaHasta.Checked)
            {
                parametros.Add("fechaHasta", fechaHasta);
            }

            string usuario;
            if (cboUsuario.SelectedValue == null && !string.IsNullOrEmpty(cboUsuario.Text))
            {
                usuario = cboUsuario.Text;
                parametros.Add("usuario", usuario);
            }
            else if (cboUsuario.SelectedValue != null)
            {
                usuario = cboUsuario.SelectedValue.ToString();
                parametros.Add("usuarioExacto", usuario);
            }

            if (cboEstado.SelectedValue != null)
            {
                var idEstadoAsistencia = cboEstado.SelectedValue.ToString();
                parametros.Add("idEstadoAsistencia", idEstadoAsistencia);
            }

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            // Solicitamos la lista de bugs que cumplan con los filtros:
            IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerAsistenciasUsuario(parametros);

            dgvConsultaAsistencias.DataSource = listadoAsistencias;
            if (listadoAsistencias.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cboEstado.SelectedIndex = -1;
            cboUsuario.SelectedIndex = -1;

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

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "Nombre");
            LlenarCombo(cboEstado, estadoAsistenciaService.ObtenerEstadosAsistencia(), "Nombre", "IdEstadoAsistencia");

            IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerAsistenciasUsuario();
            dgvConsultaAsistencias.DataSource = listadoAsistencias;
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

        // Método para crear las columnas de la DataGridView
        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        // Botón para crear nuevo registro
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAsistenciasABM frmAgregar = new FrmAsistenciasABM();
            frmAgregar.ShowDialog();

            IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerAsistenciasUsuario(parametros);
            dgvConsultaAsistencias.DataSource = listadoAsistencias;
        }

        // Botón para eliminar un registro seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConsultaAsistencias.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AsistenciaUsuario asistenciaUsuario = (AsistenciaUsuario)dgvConsultaAsistencias.CurrentRow.DataBoundItem;

            if (asistenciaUsuario.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                if (asistenciaService.EliminarAsistenciaUsuario(asistenciaUsuario))
                    MessageBox.Show("Registro eliminado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("El registro no se pudo borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerAsistenciasUsuario(parametros);
                dgvConsultaAsistencias.DataSource = listadoAsistencias;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAsistenciasABM frmEditar = new FrmAsistenciasABM();

            if (dgvConsultaAsistencias.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de editarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            AsistenciaUsuario asistenciaUsuario = (AsistenciaUsuario)dgvConsultaAsistencias.CurrentRow.DataBoundItem;

            frmEditar.InicializarFormulario(FrmAsistenciasABM.FormMode.actualizar, asistenciaUsuario);

            frmEditar.ShowDialog();

            IList<AsistenciaUsuario> listadoAsistencias = asistenciaService.ObtenerAsistenciasUsuario(parametros);
            dgvConsultaAsistencias.DataSource = listadoAsistencias;
        }
    }
}
