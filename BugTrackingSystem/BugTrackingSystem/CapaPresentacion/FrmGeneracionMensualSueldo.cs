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
    public partial class FrmGeneracionMensualSueldo : Form
    {
        private readonly BindingList<SueldoAsignacion> listaSueldoAsignacion;
        private readonly BindingList<SueldoDescuento> listaSueldoDescuento;
        private readonly UsuarioService usuarioService;
        private readonly SueldoService sueldoService;
        private readonly DescuentoService descuentoService;
        private readonly AsignacionService asignacionService;

        public FrmGeneracionMensualSueldo()
        {
            InitializeComponent();
            InitializeDataGridView();

            usuarioService = new UsuarioService();
            sueldoService = new SueldoService();
            descuentoService = new DescuentoService();
            asignacionService = new AsignacionService();

            listaSueldoAsignacion = new BindingList<SueldoAsignacion>();
            listaSueldoDescuento = new BindingList<SueldoDescuento>();
        }

        private void FrmGeneracionMensualSueldo_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre");

            dgvAsignaciones.DataSource = listaSueldoAsignacion;
            dgvDescuentos.DataSource = listaSueldoDescuento;
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvAsignaciones.ColumnCount = 2;
            dgvAsignaciones.ColumnHeadersVisible = true;
            dgvDescuentos.ColumnCount = 2;
            dgvDescuentos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvAsignaciones.AutoGenerateColumns = false;
            dgvDescuentos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            dgvAsignaciones.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvDescuentos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(dgvAsignaciones, 0, "Observación", "Asignacion", 210);
            CrearColumnas(dgvAsignaciones, 1, "Monto", "Monto", 120);
            CrearColumnas(dgvDescuentos, 0, "Observación", "Descuento", 210);
            CrearColumnas(dgvDescuentos, 1, "Monto", "Monto", 120);
        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        private void LlenarCombo(ComboBox cbx, Object source, string display)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbx.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbx.DisplayMember = display;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbx.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cboDtoAsig.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir una asignación/descuento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbAsignacion.Checked)
            {
                listaSueldoAsignacion.Add(new SueldoAsignacion()
                {
                    Usuario = (Usuario)cboUsuario.SelectedItem,
                    Fecha = (DateTime)dtpFecha.Value,
                    Asignacion = (Asignacion)cboDtoAsig.SelectedItem,
                    Monto = Convert.ToDecimal(txtImporte.Text),
                    Cantidad = Convert.ToInt32(nudCantidad.Value)
                });
            }
            else if (rbDescuento.Checked)
            {
                listaSueldoDescuento.Add(new SueldoDescuento()
                {
                    Usuario = (Usuario)cboUsuario.SelectedItem,
                    Fecha = (DateTime)dtpFecha.Value,
                    Descuento = (Descuento)cboDtoAsig.SelectedItem,
                    Monto = Convert.ToDecimal(txtImporte.Text),
                    Cantidad = Convert.ToInt32(nudCantidad.Value)
                });
            }

            CalcularTotales();
            cboDtoAsig.SelectedIndex = -1;
        }

        private void CalcularTotales()
        {
            decimal totalAsignaciones = listaSueldoAsignacion.Sum(a => a.Monto);
            txtAsigSueldo.Text = totalAsignaciones.ToString("C");

            decimal totalDescuentos = listaSueldoDescuento.Sum(d => d.Monto);
            txtDtoSueldo.Text = totalDescuentos.ToString("C");

            var sueldoBruto = nudSueldoBruto.Value;

            var importeTotal = sueldoBruto + totalAsignaciones - totalDescuentos;
            txtSueldoTotal.Text = importeTotal.ToString("C");
        }

        private void cboDtoAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarMontoEImporte();
        }

        private void ActualizarMontoEImporte()
        {
            if (cboDtoAsig.SelectedIndex == -1)
            {
                txtDtoAsig.Text = "";
                txtImporte.Text = "";
                return;
            }

            if (rbAsignacion.Checked)
            {
                Asignacion seleccionada = (Asignacion)cboDtoAsig.SelectedItem;
                txtDtoAsig.Text = (seleccionada.Monto).ToString();
                txtImporte.Text = (seleccionada.Monto * nudCantidad.Value).ToString();
            }
            else if (rbDescuento.Checked)
            {
                Descuento seleccionado = (Descuento)cboDtoAsig.SelectedItem;
                txtDtoAsig.Text = (seleccionado.Monto).ToString();
                txtImporte.Text = (seleccionado.Monto * nudCantidad.Value).ToString();
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarMontoEImporte();
        }

        private void rbDescuento_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboDtoAsig, descuentoService.ObtenerDescuentos(), "Nombre");
            ActualizarMontoEImporte();
        }

        private void rbAsignacion_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboDtoAsig, asignacionService.ObtenerAsignaciones(), "Nombre");
            ActualizarMontoEImporte();
        }

        private void nudSueldoBruto_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }
    }
}
