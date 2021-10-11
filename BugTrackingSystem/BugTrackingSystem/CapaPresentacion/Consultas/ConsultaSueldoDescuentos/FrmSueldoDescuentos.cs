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

namespace BugTrackingSystem.CapaPresentacion.ConsultaDescuentos
{
    public partial class FrmSueldoDescuentos : Form
    {
        private readonly SueldoDescuentoService sueldoDescuentoService;
        private readonly UsuarioService usuarioService;
        private readonly DescuentoService descuentoService;
        private readonly Dictionary<string, object> parametros;

        public FrmSueldoDescuentos()
        {
            InitializeComponent();
            InitializeDataGridView();
            sueldoDescuentoService = new SueldoDescuentoService();
            usuarioService = new UsuarioService();
            descuentoService = new DescuentoService();
            parametros = new Dictionary<string, object>();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            DgvDescuentos.ColumnCount = 6;
            DgvDescuentos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            DgvDescuentos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            DgvDescuentos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(DgvDescuentos, 0, "Nombre", "Usuario", 170);
            CrearColumnas(DgvDescuentos, 1, "Fecha", "Fecha", 120);
            CrearColumnas(DgvDescuentos, 2, "Descuento", "Descuento", 260);
            CrearColumnas(DgvDescuentos, 3, "Monto", "Monto", 150);
            DgvDescuentos.Columns[3].DefaultCellStyle.Format = "C";
            CrearColumnas(DgvDescuentos, 4, "Cantidad", "Cantidad", 120);
            CrearColumnas(DgvDescuentos, 5, "Borrado", "Borrado", 110);

        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
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

        private void FrmDescuentos_Load(object sender, EventArgs e)
        {
            LlenarCombo(CboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "Nombre");
            LlenarCombo(CboDescuento, descuentoService.ObtenerDescuentos(), "Nombre", "IdDescuento");

            IList<SueldoDescuento> listadoDescuentos = sueldoDescuentoService.ObtenerSueldoDescuentos();
            DgvDescuentos.DataSource = listadoDescuentos;
            lblTotal.Text = "Registros encontrados: " + listadoDescuentos.Count;
        }

        // Botones:

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            parametros.Clear();

            if (DateTime.TryParse(DateFechaDesde.Text, out DateTime fechaDesde) && DateFechaDesde.Checked)
            {
                parametros.Add("fechaDesde", fechaDesde);
            }

            if (DateTime.TryParse(DateFechaHasta.Text, out DateTime fechaHasta) && DateFechaHasta.Checked)
            {
                parametros.Add("fechaHasta", fechaHasta);
            }

            string usuario;
            if (CboUsuario.SelectedValue == null && !string.IsNullOrEmpty(CboUsuario.Text))
            {
                usuario = CboUsuario.Text;
                parametros.Add("usuario", usuario);
            }
            else if (CboUsuario.SelectedValue != null)
            {
                usuario = CboUsuario.SelectedValue.ToString();
                parametros.Add("usuarioExacto", usuario);
            }

            if (CboDescuento.SelectedValue != null)
            {
                var idDescuento = CboDescuento.SelectedValue.ToString();
                parametros.Add("idDescuento", idDescuento);
            }

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            IList<SueldoDescuento> listadoAsignaciones = sueldoDescuentoService.ObtenerSueldoDescuentos(parametros);
            DgvDescuentos.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;

            if (listadoAsignaciones.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CboUsuario.SelectedIndex = -1;
            CboDescuento.SelectedIndex = -1;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvDescuentos.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoDescuento sueldoDescuento = (SueldoDescuento)DgvDescuentos.CurrentRow.DataBoundItem;

            if (sueldoDescuento.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                sueldoDescuento.Borrado = true;

                var parametrosEliminacion = new Dictionary<string, object>
                {
                    {"idUsuarioBase", Convert.ToInt32(sueldoDescuento.Usuario.IdUsuario) },
                    {"fechaBase", Convert.ToDateTime(sueldoDescuento.Fecha) },
                    {"idDescuentoBase", Convert.ToInt32(sueldoDescuento.Descuento.IdDescuento) }
                };

                if (!sueldoDescuentoService.ActualizarSueldoDescuento(sueldoDescuento, parametrosEliminacion))
                    MessageBox.Show("El registro no se pudo borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IList<SueldoDescuento> listadoDescuentos = sueldoDescuentoService.ObtenerSueldoDescuentos();
            DgvDescuentos.DataSource = listadoDescuentos;
            lblTotal.Text = "Registros encontrados: " + listadoDescuentos.Count;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmSueldoDescuentosABM frmAgregar = new FrmSueldoDescuentosABM(FrmSueldoDescuentosABM.FormMode.nuevo);
            frmAgregar.ShowDialog();

            IList<SueldoDescuento> listadoDescuentos = sueldoDescuentoService.ObtenerSueldoDescuentos(parametros);
            DgvDescuentos.DataSource = listadoDescuentos;
            lblTotal.Text = "Registros encontrados: " + listadoDescuentos.Count;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvDescuentos.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de editarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoDescuento sueldoDescuento = (SueldoDescuento)DgvDescuentos.CurrentRow.DataBoundItem;
            FrmSueldoDescuentosABM frmEditar = new FrmSueldoDescuentosABM(FrmSueldoDescuentosABM.FormMode.actualizar, sueldoDescuento);
            frmEditar.ShowDialog();

            IList<SueldoDescuento> listadoDescuentos = sueldoDescuentoService.ObtenerSueldoDescuentos();
            DgvDescuentos.DataSource = listadoDescuentos;
            lblTotal.Text = "Registros encontrados: " + listadoDescuentos.Count;
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (DgvDescuentos.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de ver sus detalles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoDescuento sueldoDescuento = (SueldoDescuento)DgvDescuentos.CurrentRow.DataBoundItem;
            var parametrosDetalles = new Dictionary<string, object>
            {
                {"usuarioExacto", sueldoDescuento.Usuario.Nombre },
                {"fechaExacta", sueldoDescuento.Fecha},
                {"borrado", true }
            };
            FrmSueldosDetalles frmDetalles = new FrmSueldosDetalles(parametrosDetalles, Color.Khaki);
            frmDetalles.ShowDialog();
        }
    }
}
