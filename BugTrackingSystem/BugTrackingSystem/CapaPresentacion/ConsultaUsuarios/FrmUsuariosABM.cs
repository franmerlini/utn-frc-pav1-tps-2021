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

namespace BugTrackingSystem.CapaPresentacion.ConsultaUsuarios
{
    public partial class FrmUsuariosABM : Form
    {
        private readonly UsuarioService usuarioService = new UsuarioService();
        private readonly PerfilService perfilService = new PerfilService();
        private readonly Usuario usuarioSeleccionado;
        public enum FormMode { nuevo, actualizar};
        private readonly FormMode formMode;

        public FrmUsuariosABM(FormMode formMode, Usuario usuario = null)
        {
            InitializeComponent();
            this.formMode = formMode;
            btnSalir.FlatAppearance.BorderSize = 0;
            usuarioSeleccionado = usuario;
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

        private void FrmUsuariosABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(CboPerfil, perfilService.ObtenerPerfiles(), "Nombre", "IdPerfil");

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Agregar un usuario nuevo";
                        ChkBorrado.Visible = false;
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar un usuario";
                        LblTitulo.Text = "Actualizar un usuario";
                        CboPerfil.SelectedValue = usuarioSeleccionado.Perfil.IdPerfil;
                        TxtEmail.Text = usuarioSeleccionado.Email;
                        TxtEstado.Text = usuarioSeleccionado.Estado;
                        TxtPassword.Text = usuarioSeleccionado.Contrasena;
                        TxtUsuario.Text = usuarioSeleccionado.Nombre;
                        ChkBorrado.Checked = usuarioSeleccionado.Borrado;
                        break;
                    }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Perfil = new Perfil()
            };

            if (CboPerfil.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usuario.Perfil.IdPerfil = Convert.ToInt32(CboPerfil.SelectedValue);
            }

            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("Debe asignar un email.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usuario.Email = TxtEmail.Text;
            }

            if (string.IsNullOrEmpty(TxtUsuario.Text))
            {
                MessageBox.Show("Debe asignar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usuario.Nombre = TxtUsuario.Text;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Debe asignar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usuario.Contrasena = TxtPassword.Text;
            }

            if (string.IsNullOrEmpty(TxtEstado.Text))
            {
                MessageBox.Show("Debe asignar un estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                usuario.Estado = TxtEstado.Text;
            }

            var parametrosRepeticion = new Dictionary<string, object>()
            {
                {"nombreExacto", usuario.Nombre},
            };

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (usuarioService.ObtenerUsuarios(parametrosRepeticion).Count > 0)
                        {
                            MessageBox.Show("¡Ya existe un registro con tal nombre de usuario! En caso de no encontrarlo, revise entre los registros borrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (usuarioService.CrearUsuario(usuario))
                        {
                            MessageBox.Show("¡Registro creado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CboPerfil.SelectedIndex = -1;
                            TxtEmail.Text = "";
                            TxtEstado.Text = "";
                            TxtUsuario.Text = "";
                            TxtPassword.Text = "";
                        }
                        else
                            MessageBox.Show("El registro no se ha podido crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case FormMode.actualizar:
                    {
                        if (usuarioService.ObtenerUsuarios(parametrosRepeticion).Count > 0 && usuarioSeleccionado.Nombre != usuario.Nombre) 
                        {
                            MessageBox.Show("¡Ya existe un registro con tal nombre de usuario! En caso de no encontrarlo, revise entre los registros borrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        usuario.Borrado = ChkBorrado.Checked;
                        usuario.IdUsuario = usuarioSeleccionado.IdUsuario;

                        if (usuarioService.ActualizarUsuario(usuario))
                        {
                            MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
