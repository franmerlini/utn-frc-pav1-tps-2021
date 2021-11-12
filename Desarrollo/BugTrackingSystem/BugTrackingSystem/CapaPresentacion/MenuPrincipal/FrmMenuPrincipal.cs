using BugTrackingSystem.CapaPresentacion;
using BugTrackingSystem.CapaPresentacion.Ayuda;
using BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones;
using BugTrackingSystem.CapaPresentacion.ConsultaDescuentos;
using BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldosPH;
using BugTrackingSystem.CapaPresentacion.ConsultaSueldos;
using BugTrackingSystem.CapaPresentacion.ConsultaUsuarios;
using BugTrackingSystem.CapaPresentacion.Reportes.ListaSueldo;
using BugTrackingSystem.CapaPresentacion.Reportes.ReporteSueldo;
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
            ReiniciarMenu();
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
                BtnNombreUsuario.Text = usuario.Nombre;
                BtnPerfilNombre.Text = usuario.Perfil.Nombre;
                PnlMenuLateral.Visible = true;
                switch (usuario.Perfil.Nombre)
                {
                    case "Administrador":
                        {
                            BtnReportes.Visible = true;
                            BtnGestion.Visible = true;
                            BtnTransacciones.Visible = true;
                            BtnUsuarios.Enabled = true;
                            break;
                        }
                    case "Tester":
                        {
                            BtnGestion.Visible = true;
                            break;
                        }
                    case "Desarrollador":
                        {
                            BtnGestion.Visible = true;
                            break;
                        }
                    case "Responsable de Reportes":
                        {
                            BtnTransacciones.Visible = true;
                            BtnReportes.Visible = true;
                            break;
                        }
                }
            }
        }
        private void ReiniciarMenu()
        {
            BtnReportes.Visible = false;
            BtnGestion.Visible = false;
            BtnTransacciones.Visible = false;
            BtnUsuarios.Enabled = false;
            PnlGestion.Visible = false;
            PnlTransacciones.Visible = false;
            PnlReportes.Visible = false;
            PnlMenuLateral.Visible = false;
        }

        // Método para iniciar las ventanas dentro del menú principal.
        private void MostrarVentana(Form ventana, string titulo)
        {
            if (formActivo != null)
            {
                if (ventana.GetType() == formActivo.GetType() && titulo != "Bug Tracking System")
                {
                    return;
                }
                formActivo.Close();
            }
            formActivo = ventana;
            this.Text = titulo;
            formActivo.TopLevel = false;
            formActivo.Dock = DockStyle.Fill;
            PnlPrincipal.Controls.Add(formActivo);
            PnlPrincipal.Tag = formActivo;
            formActivo.BringToFront();
            formActivo.Show();
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
        private void BtnSalir_Click(object sender, EventArgs e) { this.Close(); }
        private void BtnAsignaciones_Click(object sender, EventArgs e){MostrarVentana(new FrmAsignaciones(), "Consulta de Asignaciones");}
        private void BtnAsistencias_Click(object sender, EventArgs e){MostrarVentana(new FrmAsistencias(), "Consulta de Asistencias");}
        private void Descuentos_Click(object sender, EventArgs e) {MostrarVentana(new FrmDescuentos(), "Consulta de Descuentos");}
        private void BtnSueldos_Click(object sender, EventArgs e) {MostrarVentana(new FrmSueldos(), "Consulta de Sueldos");}
        private void BtnUsuarios_Click(object sender, EventArgs e) {MostrarVentana(new FrmUsuarios(), "Consulta de Usuarios"); }
        private void BtnTransaccionSueldo_Click(object sender, EventArgs e) {MostrarVentana(new FrmGeneracionMensualSueldo(), "Generación mensual de sueldos");}
        private void BtnSueldosPH_Click(object sender, EventArgs e) { MostrarVentana(new FrmSueldosPH(), "Consulta de Sueldos Perfil Histórico");}
        private void BtnReporteSueldos_Click(object sender, EventArgs e) { MostrarVentana(new FrmReporteSueldo(), "Reporte de Sueldos"); }
        private void BtnListadoSueldos_Click(object sender, EventArgs e) { MostrarVentana(new FrmListaSueldo(), "Listado de Sueldos"); }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            if (PnlGestion.Visible)
                PnlGestion.Visible = false;
            else
            {
                PnlGestion.Visible = true;
                PnlTransacciones.Visible = false;
                PnlReportes.Visible = false;
            }
        }
        private void BtnTransacciones_Click(object sender, EventArgs e)
        {
            if (PnlTransacciones.Visible)
                PnlTransacciones.Visible = false;
            else
            {
                PnlTransacciones.Visible = true;
                PnlGestion.Visible = false;
                PnlReportes.Visible = false;
            }
        }
        private void BtnReportes_Click(object sender, EventArgs e)
        {
            if (PnlReportes.Visible)
                PnlReportes.Visible = false;
            else
            {
                PnlReportes.Visible = true;
                PnlGestion.Visible = false;
                PnlTransacciones.Visible = false;
            }

        }
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult rta;
            rta = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.No)
            {
                return;
            }
            else
            {
                ReiniciarMenu();
                login = new FrmLogin();
                login.FormClosing += Login_FormClosing;
                MostrarVentana(login, "Bug Tracking System");
            }
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new FrmAyuda();
            ayuda.ShowDialog();
        }

        // Método para remover el flickering en los formularios
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
    }
}
