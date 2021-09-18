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

namespace BugTrackingSystem.Forms
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(Usuario usu)
        {
            InitializeComponent();
            lblUsuario.Text = usu.Nombre;
            lblPerfil.Text = usu.Perfil.Nombre;
            lblUsuario.Visible = true;
            lblPerfil.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void tsiAsignaciones_Click(object sender, EventArgs e)
        {
            FrmConsultaAsignaciones ventana = new FrmConsultaAsignaciones;
        }
    }
}
