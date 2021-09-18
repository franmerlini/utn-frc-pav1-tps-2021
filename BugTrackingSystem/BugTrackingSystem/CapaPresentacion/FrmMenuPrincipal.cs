using BugTrackingSystem.CapaPresentacion;
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
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void MostrarVentana(Form ventana)
        {
            this.IsMdiContainer = true;
            if (this.MdiChildren.Length != 0)
                this.MdiChildren[0].Close();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAsignaciones ventana = new FrmConsultaAsignaciones();
            MostrarVentana(ventana);
        }
    }
}
