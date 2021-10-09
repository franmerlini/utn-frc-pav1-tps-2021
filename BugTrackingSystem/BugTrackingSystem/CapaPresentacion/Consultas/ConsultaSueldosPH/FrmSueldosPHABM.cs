using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.CapaLogicaNegocio.Services;
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

namespace BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldosPH
{
    public partial class FrmSueldosPHABM : Form
    {
        private readonly SueldoPerfilHistoricoService sueldoPerfilHistoricoService;
        private readonly PerfilService perfilService;
        private readonly SueldoPerfilHistorico sueldoPerfilHistoricoSeleccionado;
        public enum FormMode { nuevo, actualizar};
        private readonly FormMode formMode;

        public FrmSueldosPHABM(FormMode formMode, SueldoPerfilHistorico sueldoPerfilHistorico = null)
        {
            InitializeComponent();
            sueldoPerfilHistoricoService = new SueldoPerfilHistoricoService();
            perfilService = new PerfilService();
            btnSalir.FlatAppearance.BorderSize = 0;
            this.formMode = formMode;
            sueldoPerfilHistoricoSeleccionado = sueldoPerfilHistorico;
        }

        private void FrmSueldosPHABM_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfil, perfilService.ObtenerPerfiles(), "Nombre", "IdPerfil");

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
                        this.Text = "Actualizar un sueldo histórico";
                        lblTitulo.Text = "Actualizar un sueldo histórico";
                        cboPerfil.SelectedValue = sueldoPerfilHistoricoSeleccionado.Perfil.IdPerfil;
                        dateFecha.Value = sueldoPerfilHistoricoSeleccionado.Fecha;
                        nudSueldo.Value = sueldoPerfilHistoricoSeleccionado.Sueldo;
                        chkBorrado.Checked = sueldoPerfilHistoricoSeleccionado.Borrado;
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

        private bool Existe(SueldoPerfilHistorico sueldoPerfilHistorico)
        {
            var parametro = new Dictionary<string, object>()
            {
                { "borrado", true }
            };

            IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico(parametro);

            foreach (SueldoPerfilHistorico s in listadoSueldos)
            {
                if (s.Perfil.IdPerfil.Equals(sueldoPerfilHistorico.Perfil.IdPerfil) && (s.Fecha.ToString("dd/MM/yyyy")).Equals(sueldoPerfilHistorico.Fecha.ToString("dd/MM/yyyy")))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            SueldoPerfilHistorico sueldoPerfilHistorico = new SueldoPerfilHistorico
            {
                Perfil = new Perfil()
            };

            if (cboPerfil.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un perfil.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sueldoPerfilHistorico.Perfil.IdPerfil = Convert.ToInt32(cboPerfil.SelectedValue);
            }

            sueldoPerfilHistorico.Fecha = Convert.ToDateTime(dateFecha.Value);

            sueldoPerfilHistorico.Sueldo = Convert.ToDecimal(nudSueldo.Value);

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (Existe(sueldoPerfilHistorico))
                        {
                            MessageBox.Show("Ya existe un registro con tal perfil y fecha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (sueldoPerfilHistoricoService.CrearSueldoPerfilHistorico(sueldoPerfilHistorico))
                        {
                            MessageBox.Show("¡Nuevo sueldo registrado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cboPerfil.SelectedIndex = -1;
                            dateFecha.Value = DateTime.Today;
                        }
                        else
                            MessageBox.Show("El nuevo sueldo no ha sido registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case FormMode.actualizar:
                    {
                        if (!sueldoPerfilHistoricoSeleccionado.Perfil.IdPerfil.Equals(sueldoPerfilHistorico.Perfil.IdPerfil) || (!sueldoPerfilHistoricoSeleccionado.Fecha.Equals(sueldoPerfilHistorico.Fecha)))
                        {
                            if (Existe(sueldoPerfilHistorico))
                            {
                                MessageBox.Show("Ya existe un registro con tal perfil y fecha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        sueldoPerfilHistorico.Borrado = chkBorrado.Checked;

                        var parametros = new Dictionary<string, object>
                        {
                            {"idPerfilBase", Convert.ToInt32(sueldoPerfilHistoricoSeleccionado.Perfil.IdPerfil) },
                            {"fechaBase", Convert.ToDateTime(sueldoPerfilHistoricoSeleccionado.Fecha) },
                        };

                        if (sueldoPerfilHistoricoService.ActualizarSueldoPerfilHistorico(sueldoPerfilHistorico, parametros))
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
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
