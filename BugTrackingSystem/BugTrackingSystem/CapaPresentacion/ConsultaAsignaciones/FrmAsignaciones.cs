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

namespace BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones
{
    public partial class FrmAsignaciones : Form
    {
        private readonly SueldoAsignacionService sueldoAsignacionService;
        private readonly UsuarioService usuarioService;
        private readonly AsignacionService asignacionService;
        private readonly Dictionary<string, object> parametros;

        public FrmAsignaciones()
        {
            InitializeComponent();
            InitializeDataGridView();
            sueldoAsignacionService = new SueldoAsignacionService();
            usuarioService = new UsuarioService();
            asignacionService = new AsignacionService();
            parametros = new Dictionary<string, object>();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            DgvAsignaciones.ColumnCount = 6;
            DgvAsignaciones.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            DgvAsignaciones.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            DgvAsignaciones.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(DgvAsignaciones, 0, "Nombre", "Usuario", 170);
            CrearColumnas(DgvAsignaciones, 1, "Fecha", "Fecha", 120);
            CrearColumnas(DgvAsignaciones, 2, "Asignación", "Asignacion", 260);
            CrearColumnas(DgvAsignaciones, 3, "Monto", "Monto", 150);
            CrearColumnas(DgvAsignaciones, 4, "Cantidad", "Cantidad", 120);
            CrearColumnas(DgvAsignaciones, 5, "Borrado", "Borrado", 110);

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

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {
            LlenarCombo(CboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "Nombre");
            LlenarCombo(CboAsignacion, asignacionService.ObtenerAsignaciones(), "Nombre", "IdAsignacion");

            IList<SueldoAsignacion> listadoAsignaciones = sueldoAsignacionService.ObtenerSueldoAsignaciones();
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
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

            if (CboAsignacion.SelectedValue != null)
            {
                var idAsignacion = CboAsignacion.SelectedValue.ToString();
                parametros.Add("idAsignacion", idAsignacion);
            }

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            IList<SueldoAsignacion> listadoAsignaciones = sueldoAsignacionService.ObtenerSueldoAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;

            if (listadoAsignaciones.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CboUsuario.SelectedIndex = -1;
            CboAsignacion.SelectedIndex = -1;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAsignacionesABM frmAgregar = new FrmAsignacionesABM(FrmAsignacionesABM.FormMode.nuevo);
            frmAgregar.ShowDialog();

            IList<SueldoAsignacion> listadoAsignaciones = sueldoAsignacionService.ObtenerSueldoAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvAsignaciones.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de editarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoAsignacion sueldoAsignacion = (SueldoAsignacion)DgvAsignaciones.CurrentRow.DataBoundItem;
            FrmAsignacionesABM frmEditar = new FrmAsignacionesABM(FrmAsignacionesABM.FormMode.actualizar, sueldoAsignacion);
            frmEditar.ShowDialog();

            IList<SueldoAsignacion> listadoAsignaciones = sueldoAsignacionService.ObtenerSueldoAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAsignaciones.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoAsignacion sueldoAsignacion = (SueldoAsignacion)DgvAsignaciones.CurrentRow.DataBoundItem;

            if (sueldoAsignacion.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                sueldoAsignacion.Borrado = true;

                var parametrosEliminacion = new Dictionary<string, object>
                {
                    {"idUsuarioBase", Convert.ToInt32(sueldoAsignacion.Usuario.IdUsuario) },
                    {"fechaBase", Convert.ToDateTime(sueldoAsignacion.Fecha) },
                    {"idAsignacionBase", Convert.ToInt32(sueldoAsignacion.Asignacion.IdAsignacion) }
                };

                if (!sueldoAsignacionService.ActualizarSueldoAsignacion(sueldoAsignacion, parametrosEliminacion))
                    MessageBox.Show("El registro no se pudo borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IList<SueldoAsignacion> listadoAsignaciones = sueldoAsignacionService.ObtenerSueldoAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }
    }


}
