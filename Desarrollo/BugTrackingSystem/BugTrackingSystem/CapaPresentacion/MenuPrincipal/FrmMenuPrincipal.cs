using BugTrackingSystem.CapaPresentacion;
using BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones;
using BugTrackingSystem.CapaPresentacion.ConsultaDescuentos;
using BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldosPH;
using BugTrackingSystem.CapaPresentacion.ConsultaSueldos;
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
        private Form formActivo = null;

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
                            tsiUsuarios.Enabled = true;
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
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = ventana;
            lblTitulo.Text = titulo;
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            PnlPrincipal.Controls.Add(ventana);
            PnlPrincipal.Tag = ventana;
            ventana.BringToFront();
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
            MostrarVentana(new FrmAsistencias(), "Consulta de Asistencias");
        }

        private void TsiUsuarios_Click(object sender, EventArgs e)
        {
            MostrarVentana(new FrmUsuarios(), "Consulta de Usuarios");
        }

        private void TsiSueldosAsignaciones_Click(object sender, EventArgs e)
        {
            MostrarVentana(new FrmAsignaciones(), "Consulta de Asignaciones");
        }

        private void TsiSueldosDescuentos_Click(object sender, EventArgs e)
        {
            MostrarVentana(new FrmDescuentos(), "Consulta de Descuentos");
        }

        private void TsiSueldosPorPefil_Click(object sender, EventArgs e)
        {
            MostrarVentana(new FrmSueldosPH(), "Consulta de Sueldos Perfil Histórico");
        }

        private void GeneracionMensualDeSueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVentana(new FrmGeneracionMensualSueldo(), "Generación mensual de sueldos");
        }

        private void SueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarVentana(new FrmSueldos(), "Consulta de Sueldos");
        }

        private void CerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rta;
            rta = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.No)
            {
                return;
            }
            else
            {
                tsiReportes.Enabled = false;
                tsiArchivo.Enabled = false;
                tsiGestion.Enabled = false;
                tsiTransaccion.Enabled = false;
                LblNombre.Visible = false;
                login = new FrmLogin();
                login.FormClosing += Login_FormClosing;
                MostrarVentana(login, "Bug Tracking System");
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
