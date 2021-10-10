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
            dgvAsignaciones.AutoGenerateColumns = false;
            dgvDescuentos.AutoGenerateColumns = false;

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

            //rbAsignacion.Checked = true;

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
            if (rbAsignacion.Checked)
            {
            }
            else if (rbDescuento.Checked)
            {

            }

        }

        private void cboDtoAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMontoEImporte();
        }

        private void CargarMontoEImporte()
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
            CargarMontoEImporte();
        }

        private void rbDescuento_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboDtoAsig, descuentoService.ObtenerDescuentos(), "Nombre");
            CargarMontoEImporte();
        }

        private void rbAsignacion_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboDtoAsig, asignacionService.ObtenerAsignaciones(), "Nombre");
            CargarMontoEImporte();
        }
    }
}
