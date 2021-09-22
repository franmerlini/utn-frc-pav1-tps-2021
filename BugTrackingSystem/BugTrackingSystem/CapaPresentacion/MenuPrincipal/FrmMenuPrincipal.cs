using BugTrackingSystem.CapaPresentacion;
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

namespace BugTrackingSystem.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            btnSalir.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatAppearance.BorderSize = 0;
        }

        // Se inicia la ventana de login apenas se muestra el menú principal
        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            MostrarVentana(login, "Bug Tracking System");
        }

        // Cuando el formulario de login se cierre, se activará el menú principal
        private void FrmMenuPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            // Si no hay ninguna ventana hija activa (es decir, el usuario pudo loguearse), se habilita el menú.
            if (this.ActiveMdiChild == null)
            {
                tsiGestion.Enabled = true;
                tsiTransaccion.Enabled = true;
                tsiArchivo.Enabled = true;
            }
        }

        // Se inicia la ventana de Consulta de asignaciones con su botón correspondiente:)
        private void tsiAsignaciones_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                if (this.MdiChildren[0] is FrmAsistencias)
                    return;
            FrmAsistencias ventana = new FrmAsistencias();
            MostrarVentana(ventana, "Consulta de Asistencias");
        }

        // Método para iniciar las ventanas dentro del menú principal.
        private void MostrarVentana(Form ventana, string titulo)
        {
            this.IsMdiContainer = true;
            if (this.ActiveMdiChild != null)
                this.MdiChildren[0].Close();
            lblTitulo.Text = titulo;
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Mensaje en pantalla confirmando si cerrar la ventana
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta;
            rta = MessageBox.Show("¿Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // Código para poder mover la ventana desde el menu strip

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MnsPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
