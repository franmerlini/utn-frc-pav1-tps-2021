using BugTrackingSystem.CapaPresentacion;
using BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones;
using BugTrackingSystem.CapaPresentacion.ConsultaDescuentos;
using BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldosPH;
using BugTrackingSystem.CapaPresentacion.ConsultaUsuarios;
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
        private Usuario usuario;
        private FrmLogin login;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        // Se inicia la ventana de login apenas se muestra el menú principal
        private void FrmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            login = new FrmLogin();
            login.FormClosing += Login_FormClosing;
            MostrarVentana(login, "Bug Tracking System");
        }

        // Event handler del form login para extraer el usuario
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login.Usuario != null)
            {
                usuario = login.Usuario;
                switch (usuario.Perfil.Nombre)
                {
                    case "Administrador":
                        {
                            tsiReportes.Enabled = true;
                            tsiArchivo.Enabled = true;
                            tsiGestion.Enabled = true;
                            tsiTransaccion.Enabled = true;
                            break;
                        }
                    case "Tester":
                        {
                            tsiArchivo.Enabled = true;
                            tsiGestion.Enabled = true;
                            tsiUsuarios.Enabled = false;
                            break;
                        }
                    case "Desarrollador":
                        {
                            tsiArchivo.Enabled = true;
                            tsiGestion.Enabled = true;
                            tsiUsuarios.Enabled = false;
                            break;
                        }
                    case "Responsable de Reportes":
                        {
                            tsiArchivo.Enabled = true;
                            tsiTransaccion.Enabled = true;
                            tsiReportes.Enabled = true;
                            break;
                        }
                }
                LblNombre.Text = "Usuario: " + usuario.Nombre + " - Perfil: " + usuario.Perfil.Nombre;
                LblNombre.Visible = true;
            }
        }

        // Método para iniciar las ventanas dentro del menú principal.
        private void MostrarVentana(Form ventana, string titulo)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild.GetType() == ventana.GetType())
                {
                    return;
                }
                this.MdiChildren[0].Close();
            }
            lblTitulo.Text = titulo;
            ventana.MdiParent = this;
            ventana.Show();
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

        // Botones:

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TsiAsignaciones_Click(object sender, EventArgs e)
        {
            FrmAsistencias ventana = new FrmAsistencias();
            MostrarVentana(ventana, "Consulta de Asistencias");
        }

        private void TsiUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios ventana = new FrmUsuarios();
            MostrarVentana(ventana, "Consulta de Usuarios");
        }

        private void TsiSueldosAsignaciones_Click(object sender, EventArgs e)
        {
            FrmAsignaciones ventana = new FrmAsignaciones();
            MostrarVentana(ventana, "Consulta de Asignaciones");
        }

        private void TsiSueldosDescuentos_Click(object sender, EventArgs e)
        {
            FrmDescuentos ventana = new FrmDescuentos();
            MostrarVentana(ventana, "Consulta de Descuentos");
        }

        private void TsiSueldosPorPefil_Click(object sender, EventArgs e)
        {
            FrmSueldosPH ventana = new FrmSueldosPH();
            MostrarVentana(ventana, "Consulta de Sueldos Perfil Histórico");
        }

<<<<<<< Updated upstream
        private void generacionMensualDeSueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGeneracionMensualSueldo ventana = new FrmGeneracionMensualSueldo();
            MostrarVentana(ventana, "Generación mensual de sueldos");
=======
        private void GeneracionMensualDeSueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {

>>>>>>> Stashed changes
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
