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

namespace BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones
{
    public partial class FrmSueldoAsignacionesABM : Form
    {
        private readonly UsuarioService usuarioService;
        private readonly SueldoAsignacionService sueldoAsignacionService;
        private readonly AsignacionService asignacionService;
        private readonly SueldoService sueldoService;
        private readonly SueldoAsignacion sueldoAsignacionSeleccionado;
        public enum FormMode { nuevo, actualizar };
        private readonly FormMode formMode;

        public FrmSueldoAsignacionesABM(FormMode formMode, SueldoAsignacion sueldoAsignacion = null)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            sueldoAsignacionService = new SueldoAsignacionService();
            asignacionService = new AsignacionService();
            sueldoService = new SueldoService();
            this.formMode = formMode;
            sueldoAsignacionSeleccionado = sueldoAsignacion;
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

        private void FrmAsignacionesABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "IdUsuario");
            LlenarCombo(cboAsignacion, asignacionService.ObtenerAsignaciones(), "Nombre", "IdAsignacion");

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
                        cboUsuario.SelectedValue = sueldoAsignacionSeleccionado.Usuario.IdUsuario;
                        cboAsignacion.SelectedValue = sueldoAsignacionSeleccionado.Asignacion.IdAsignacion;
                        dateFecha.Value = sueldoAsignacionSeleccionado.Fecha;
                        nudCantidad.Value = sueldoAsignacionSeleccionado.Cantidad;
                        nudMonto.Value = sueldoAsignacionSeleccionado.Monto;
                        chkBorrado.Checked = sueldoAsignacionSeleccionado.Borrado;
                        break;
                    }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            // Creación de objeto

            SueldoAsignacion sueldoAsignacion = new SueldoAsignacion
            {
                Usuario = new Usuario(),
                Asignacion = new Asignacion()
            };

            // Se completan datos del objeto
            //      Usuario
            if (cboUsuario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sueldoAsignacion.Usuario.IdUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            }

            //      Fecha
            sueldoAsignacion.Fecha = Convert.ToDateTime(dateFecha.Value);

            //      Asignacion
            if (cboAsignacion.SelectedValue != null)
                sueldoAsignacion.Asignacion.IdAsignacion = Convert.ToInt32(cboAsignacion.SelectedValue);
            else
            {
                MessageBox.Show("Debe seleccionar una asignación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //      Monto
            sueldoAsignacion.Monto = nudMonto.Value;

            //      Cantidad
            sueldoAsignacion.Cantidad = Convert.ToInt32(nudCantidad.Value);

            // Se comprueba que para tal usuario y fecha, existe un elemento dentro de la tabla Sueldos con el que se pueda vincular.
            var parametroSueldo = new Dictionary<string, object>
            {
                { "fechaExacta", sueldoAsignacion.Fecha },
                { "idUsuario", sueldoAsignacion.Usuario.IdUsuario }
            };
            if (sueldoService.ObtenerSueldos(parametroSueldo).Count == 0)
            {
                MessageBox.Show("No existe ningún sueldo bruto registrado con tal usuario y fecha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se crean parámetros de repetición para comprobar que no exista tal registro.
            var parametrosRepeticion = new Dictionary<string, object>()
            {
                {"idUsuario", Convert.ToInt32(sueldoAsignacion.Usuario.IdUsuario) },
                {"fechaExacta", Convert.ToDateTime(sueldoAsignacion.Fecha) },
                {"idAsignacion", Convert.ToInt32(sueldoAsignacion.Asignacion.IdAsignacion) },
                {"borrado" , true}
            };

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        // Se comprueba que no existan registros con los parámetros de repetición.
                        if (sueldoAsignacionService.ObtenerSueldoAsignaciones(parametrosRepeticion).Count > 0)
                        {
                            MessageBox.Show("¡Ya existe un registro con tal usuario, fecha y asignación! En caso de no encontrarlo, revise entre los registros borrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (sueldoAsignacionService.CrearSueldoAsignacion(sueldoAsignacion))
                        {
                            MessageBox.Show("¡Registro creado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboAsignacion.SelectedIndex = -1;
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
                        // Se comprueba que no existan registros con los parámetros de repetición.
                        // Sin embargo, en este caso se tiene en cuenta que solo se hará la comprobación si alguno de los parámetros de repetición
                        // (idUsuario, fecha o idAsignacion) se hayan cambiado, a fin de evitar realizar la comprobación para el mismo registro que se está editando.
                        if (sueldoAsignacionService.ObtenerSueldoAsignaciones(parametrosRepeticion).Count > 0 && (sueldoAsignacionSeleccionado.Fecha != sueldoAsignacion.Fecha || sueldoAsignacionSeleccionado.Usuario.IdUsuario != sueldoAsignacion.Usuario.IdUsuario || sueldoAsignacionSeleccionado.Asignacion.IdAsignacion != sueldoAsignacion.Asignacion.IdAsignacion))
                        {
                            MessageBox.Show("¡Ya existe un registro con tal usuario, fecha y asignación! En caso de no encontrarlo, revise entre los registros borrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        sueldoAsignacion.Borrado = chkBorrado.Checked;

                        var parametros = new Dictionary<string, object>
                        {
                            {"idUsuarioBase", Convert.ToInt32(sueldoAsignacionSeleccionado.Usuario.IdUsuario) },
                            {"fechaBase", Convert.ToDateTime(sueldoAsignacionSeleccionado.Fecha) },
                            {"idAsignacionBase", Convert.ToInt32(sueldoAsignacionSeleccionado.Asignacion.IdAsignacion) }
                        };

                        if (sueldoAsignacionService.ActualizarSueldoAsignacion(sueldoAsignacion, parametros))
                        {
                            MessageBox.Show("Asignación actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar la asignación!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }



            }


        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
