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

namespace BugTrackingSystem.CapaPresentacion.ConsultaUsuarios
{
    public partial class FrmUsuarios : Form
    {
        private readonly UsuarioService usuarioService = new UsuarioService();
        private readonly PerfilService perfilService = new PerfilService();
        private readonly Dictionary<string, object> parametros = new Dictionary<string, object>();

        public FrmUsuarios()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarios.ColumnCount = 6;
            dgvUsuarios.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarios.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            dgvUsuarios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(dgvUsuarios, 0, "Nombre", "nombre", 190);
            CrearColumnas(dgvUsuarios, 1, "Perfil", "Perfil", 170);
            CrearColumnas(dgvUsuarios, 2, "Contraseña", "Contrasena", 190);
            CrearColumnas(dgvUsuarios, 3, "Email", "Email", 260);
            CrearColumnas(dgvUsuarios, 4, "Estado", "Estado", 120);
            CrearColumnas(dgvUsuarios, 5, "Borrado", "Borrado", 100);
            dgvUsuarios.Columns[5].Visible = false;

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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre", "Nombre");
            LlenarCombo(cboEmail, usuarioService.ObtenerUsuarios(), "Email", "Email");
            LlenarCombo(cboPerfil, perfilService.ObtenerPerfiles(), "Nombre", "IdPerfil");

            Consultar(parametros, false);
        }

        // Botones:

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            parametros.Clear();

            string usuario;
            if (cboUsuario.SelectedValue == null && !string.IsNullOrEmpty(cboUsuario.Text))
            {
                usuario = cboUsuario.Text;
                parametros.Add("nombre", usuario);
            }
            else if (cboUsuario.SelectedValue != null)
            {
                usuario = cboUsuario.SelectedValue.ToString();
                parametros.Add("nombreExacto", usuario);
            }

            string email;
            if (cboEmail.SelectedValue == null && !string.IsNullOrEmpty(cboEmail.Text))
            {
                email = cboEmail.Text;
                parametros.Add("email", email);
            }
            else if (cboEmail.SelectedValue != null)
            {
                email = cboEmail.SelectedValue.ToString();
                parametros.Add("emailExacto", email);
            }

            if (cboPerfil.SelectedValue != null)
            {
                string perfil = cboPerfil.SelectedValue.ToString();
                parametros.Add("idPerfil", perfil);
            }

            if (!string.IsNullOrEmpty(TxtEstado.Text))
            {
                string estado = TxtEstado.Text;
                parametros.Add("estado", estado);
            }

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            Consultar(parametros, true);

            cboPerfil.SelectedIndex = -1;
            cboUsuario.SelectedIndex = -1;
            cboEmail.SelectedIndex = -1;
            TxtEstado.Text = "";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmUsuariosABM frmAgregar = new FrmUsuariosABM(FrmUsuariosABM.FormMode.nuevo);
            frmAgregar.ShowDialog();

            Consultar(parametros, false);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            FrmUsuariosABM frmEditar = new FrmUsuariosABM(FrmUsuariosABM.FormMode.actualizar, usuario);
            frmEditar.ShowDialog();

            Consultar(parametros, false);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            if (usuario.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                usuario.Borrado = true;
                if (!usuarioService.ActualizarUsuario(usuario))
                    MessageBox.Show("El registro no se pudo borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Consultar(parametros, false);
            }   
        }

        private void Consultar(Dictionary<string, object> parametros = null, bool mostrarMensaje = true)
        {
            IList<Usuario> listadoUsuarios = usuarioService.ObtenerUsuarios(parametros);
            dgvUsuarios.DataSource = listadoUsuarios;
            lblTotal.Text = "Registros encontrados: " + listadoUsuarios.Count;

            if (listadoUsuarios.Count == 0 && mostrarMensaje)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow a in dgvUsuarios.Rows)
            {
                if ((bool)a.Cells[5].Value)
                {
                    a.DefaultCellStyle.BackColor = Color.LightGray;
                }

            }
        }
    }
}
