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

namespace BugTrackingSystem.CapaPresentacion.ConsultaSueldos
{
    public partial class FrmSueldosABM : Form
    {
        private readonly UsuarioService usuarioService;
        private readonly SueldoService sueldoService;
        private readonly Sueldo sueldoSeleccionado;
        public enum FormMode { nuevo, actualizar };
        private readonly FormMode formMode;

        // Métodos de carga e inicialización
        public FrmSueldosABM(FormMode formMode, Sueldo sueldo = null)
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
            sueldoService = new SueldoService();
            btnSalir.FlatAppearance.BorderSize = 0;
            this.formMode = formMode;
            sueldoSeleccionado = sueldo;
        }

        private void FrmSueldosABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "IdUsuario");

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Registrar un nuevo sueldo";
                        chkBorrado.Visible = false;
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar un sueldo";
                        lblTitulo.Text = "Actualizar un registro";
                        cboUsuario.SelectedValue = sueldoSeleccionado.Usuario.IdUsuario;
                        dateFecha.Value = sueldoSeleccionado.Fecha;
                        nudSueldo.Text = sueldoSeleccionado.SueldoBruto.ToString();
                        chkBorrado.Checked = sueldoSeleccionado.Borrado;
                        break;
                    }
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
            // SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbx.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Sueldo sueldo = new Sueldo
            {
                Usuario = new Usuario()
            };

            if (cboUsuario.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sueldo.Usuario.IdUsuario = Convert.ToInt32(cboUsuario.SelectedValue);
            }

            sueldo.Fecha = Convert.ToDateTime(dateFecha.Value);

            sueldo.SueldoBruto = (float)Convert.ToDouble(nudSueldo.Value);

            if (Existe(sueldo))
            {
                MessageBox.Show("Ya existe un registro con esos datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (sueldoService.CrearSueldo(sueldo))
                        {
                            MessageBox.Show("¡Nuevo sueldo registrado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboUsuario.SelectedIndex = -1;
                            dateFecha.Value = DateTime.Today;
                        }
                        else
                            MessageBox.Show("El nuevo sueldo no ha sido registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        sueldo.Borrado = chkBorrado.Checked;
                        sueldo.Usuario = sueldoSeleccionado.Usuario;

                        if (sueldoService.ActualizarSueldo(sueldo))
                        {
                            MessageBox.Show("Sueldo actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar el sueldo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private bool Existe(Sueldo sueldo)
        {
            IList<Sueldo> listadoSueldos = sueldoService.ObtenerSueldos();

            foreach (Sueldo s in listadoSueldos)
            {
                if (s.Usuario.IdUsuario.Equals(sueldo.Usuario.IdUsuario) && (s.Fecha.ToString("dd/MM/yyyy")).Equals(sueldo.Fecha.ToString("dd/MM/yyyy")))
                {
                    return true;
                }
            }
            return false;
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

        private void MenuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
