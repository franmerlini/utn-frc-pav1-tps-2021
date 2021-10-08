using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.CapaPresentacion.ConsultaDescuentos
{
    public partial class FrmDescuentosABM : Form
    {
        private readonly UsuarioService usuarioService;
        private readonly SueldoDescuentoService sueldoDescuentoService;
        private readonly DescuentoService descuentoService;
        private readonly SueldoService sueldoService;
        private readonly SueldoDescuento sueldoDescuentoSeleccionado;
        public enum FormMode { nuevo, actualizar };
        private readonly FormMode formMode;

        public FrmDescuentosABM(FormMode formMode, SueldoDescuento sueldoDescuento = null)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            sueldoDescuentoService = new SueldoDescuentoService();
            descuentoService = new DescuentoService();
            sueldoService = new SueldoService();
            this.formMode = formMode;
            sueldoDescuentoSeleccionado = sueldoDescuento;
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

        private void FrmDescuentosABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "IdUsuario");
            LlenarCombo(cboDescuento, descuentoService.ObtenerDescuentos(), "Nombre", "IdDescuento");

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Agregar un registro nuevo";
                        chkBorrado.Visible = false;
                        dateFecha.Value = DateTime.Today;
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar un registro";
                        lblTitulo.Text = "Actualizar un registro";
                        cboUsuario.SelectedValue = sueldoDescuentoSeleccionado.Usuario.IdUsuario;
                        cboDescuento.SelectedValue = sueldoDescuentoSeleccionado.Descuento.IdDescuento;
                        dateFecha.Value = sueldoDescuentoSeleccionado.Fecha;
                        nudCantidad.Value = sueldoDescuentoSeleccionado.Cantidad;
                        nudMonto.Value = sueldoDescuentoSeleccionado.Monto;
                        chkBorrado.Checked = sueldoDescuentoSeleccionado.Borrado;
                        break;
                    }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SueldoDescuento sueldoDescuento = new SueldoDescuento
            {
                Usuario = new Usuario(),
                Descuento = new Descuento()
            };

            if (cboUsuario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sueldoDescuento.Usuario.IdUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            }

            sueldoDescuento.Fecha = Convert.ToDateTime(dateFecha.Value);
            var parametroSueldo = new Dictionary<string, object>
            {
                { "fechaExacta", sueldoDescuento.Fecha },
                { "idUsuario", sueldoDescuento.Usuario.IdUsuario }
            };
            if (sueldoService.ObtenerSueldos(parametroSueldo).Count == 0)
            {
                MessageBox.Show("No existe ningún sueldo registrado con tal usuario y fecha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDescuento.SelectedValue != null)
                sueldoDescuento.Descuento.IdDescuento = Convert.ToInt32(cboDescuento.SelectedValue);
            else
            {
                MessageBox.Show("Debe seleccionar un descuento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sueldoDescuento.Monto = nudMonto.Value;
            sueldoDescuento.Cantidad = Convert.ToInt32(nudCantidad.Value);

            var parametrosRepeticion = new Dictionary<string, object>()
            {
                {"idUsuarioBase", Convert.ToInt32(sueldoDescuento.Usuario.IdUsuario) },
                {"fechaBase", Convert.ToDateTime(sueldoDescuento.Fecha) },
                {"idDescuentoBase", Convert.ToInt32(sueldoDescuento.Descuento.IdDescuento) },
                {"borrado" , true}
            };

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (sueldoDescuentoService.ObtenerSueldoDescuentos(parametrosRepeticion).Count > 0)
                        {
                            MessageBox.Show("¡Ya existe un registro con tal usuario, fecha y descuento! En caso de no encontrarlo, revise entre los registros borrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (sueldoDescuentoService.CrearSueldoDescuento(sueldoDescuento))
                        {
                            MessageBox.Show("¡Registro creado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboDescuento.SelectedIndex = -1;
                            cboUsuario.SelectedIndex = -1;
                            dateFecha.Value = DateTime.Today;
                            nudCantidad.Value = 0;
                            nudMonto.Value = 0;
                        }
                        else
                            MessageBox.Show("El registro no se ha podido crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        if (sueldoDescuentoService.ObtenerSueldoDescuentos(parametrosRepeticion).Count > 0 && (sueldoDescuentoSeleccionado.Fecha != sueldoDescuento.Fecha || sueldoDescuentoSeleccionado.Usuario.IdUsuario != sueldoDescuento.Usuario.IdUsuario || sueldoDescuentoSeleccionado.Descuento.IdDescuento != sueldoDescuento.Descuento.IdDescuento))
                        {
                            MessageBox.Show("¡Ya existe un registro con tal usuario, fecha y descuento! En caso de no encontrarlo, revise entre los registros borrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        sueldoDescuento.Borrado = chkBorrado.Checked;

                        var parametros = new Dictionary<string, object>
                        {
                            {"idUsuarioBase", Convert.ToInt32(sueldoDescuento.Usuario.IdUsuario) },
                            {"fechaBase", Convert.ToDateTime(sueldoDescuento.Fecha) },
                            {"idDescuentoBase", Convert.ToInt32(sueldoDescuento.Descuento.IdDescuento) }
                        };

                        if (sueldoDescuentoService.ActualizarSueldoDescuento(sueldoDescuento, parametros))
                        {
                            MessageBox.Show("Descuento actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar el descuento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Código para poder mover la ventana desde el menu strip

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
