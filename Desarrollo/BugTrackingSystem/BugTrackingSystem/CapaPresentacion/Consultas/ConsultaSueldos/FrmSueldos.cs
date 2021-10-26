using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldos;
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

namespace BugTrackingSystem.CapaPresentacion.ConsultaSueldos
{
    public partial class FrmSueldos : Form
    {
        private readonly SueldoService sueldoService;
        private readonly UsuarioService usuarioService;
        private readonly SueldoAsignacionService sueldoAsignacionService;
        private readonly SueldoDescuentoService sueldoDescuentoService;
        private readonly Dictionary<string, object> parametros = new Dictionary<string, object>();

        // Métodos de carga e inicialización
        public FrmSueldos()
        {
            InitializeComponent();
            InitializeDataGridView();

            sueldoService = new SueldoService();
            usuarioService = new UsuarioService();
            sueldoAsignacionService = new SueldoAsignacionService();
            sueldoDescuentoService = new SueldoDescuentoService();
        }

        private void InitializeDataGridView()
        {
            // Crea un DataGridView no vinculado declarando un recuento de columnas.
            dgvSueldos.ColumnCount = 4;
            dgvSueldos.ColumnHeadersVisible = true;

            // Configura la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvSueldos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            dgvSueldos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Define el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(dgvSueldos, 0, "Usuario", "Usuario", 163);
            CrearColumnas(dgvSueldos, 1, "Fecha", "Fecha", 163);
            CrearColumnas(dgvSueldos, 2, "Sueldo Bruto", "SueldoBruto", 163);
            dgvSueldos.Columns[2].DefaultCellStyle.Format = "C";
            CrearColumnas(dgvSueldos, 3, "Sueldo Neto", "", 163);
            dgvSueldos.Columns[3].DefaultCellStyle.Format = "C";
        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        private void FrmSueldos_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "Nombre");
            dateFechaDesde.Checked = true;
            dateFechaDesde.Value = DateTime.Today.AddMonths(-1);

            var parametros = new Dictionary<string, object>
            {
                {"fechaDesde", DateTime.Today.AddMonths(-1)}
            };

            Consultar(parametros, false);
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

        // Botones
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            // Sección reviso de filtros
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

            // Solicita la lista de bugs que cumplan con los filtros:
            Consultar(parametros, true);
            cboUsuario.SelectedIndex = -1;
        }

        private void Consultar(Dictionary<string, object> parametros = null, bool mostrarMensaje = true)
        {
            IList<Sueldo> listadoSueldos = sueldoService.ObtenerSueldos(parametros);
            dgvSueldos.DataSource = listadoSueldos;
            lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;

            if (listadoSueldos.Count == 0 && mostrarMensaje)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvSueldos.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de ver sus detalles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sueldo sueldo = (Sueldo)dgvSueldos.CurrentRow.DataBoundItem;
            var parametrosDetalles = new Dictionary<string, object>
            {
                {"idUsuario", sueldo.Usuario.IdUsuario },
                {"fechaExacta", sueldo.Fecha.ToString("yyyy-MM-dd")},
            };
            FrmSueldosDetalles frmDetalles = new FrmSueldosDetalles(parametrosDetalles);
            frmDetalles.ShowDialog();
        }

        private void dgvSueldos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Ciclo que implementa los sueldos netos dentro de cada fila.
            // TODO: Refactorizar, ya que el modelo actual tiene un orden de O(n*n)

            foreach (DataGridViewRow row in dgvSueldos.Rows)
            {
                var parametrosSueldoNeto = new Dictionary<string, object>
                {
                    {"idUsuario", ((Usuario)row.Cells[0].Value).IdUsuario },
                    {"fechaExacta", ((DateTime)row.Cells[1].Value).ToString("yyyy-MM-dd")},
                };

                IList<SueldoAsignacion> listadoAsignaciones = sueldoAsignacionService.ObtenerSueldoAsignaciones(parametrosSueldoNeto);
                IList<SueldoDescuento> listadoDescuentos = sueldoDescuentoService.ObtenerSueldoDescuentos(parametrosSueldoNeto);

                decimal totalAsignaciones = listadoAsignaciones.Sum(a => a.Monto);
                decimal totalDescuentos = listadoDescuentos.Sum(d => d.Monto);
                var importeTotal = (decimal)row.Cells[2].Value + totalAsignaciones - totalDescuentos;

                row.Cells[3].Value = importeTotal;
            }
        }
    }
}
