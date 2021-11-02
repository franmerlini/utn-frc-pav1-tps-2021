using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.CapaPresentacion.Reportes.ListadoSueldos
{
    public partial class FrmListadoSueldos : Form
    {
        public FrmListadoSueldos()
        {
            InitializeComponent();
        }

        private void FrmListadoSueldos_Load(object sender, EventArgs e)
        {
            dateFechaDesde.Value = DateTime.Today.AddMonths(-1);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fechaDesde = dateFechaDesde.Text;
            string fechaHasta = dateFechaHasta.Text;
            RVListado.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prFechaDesde", fechaDesde), new ReportParameter("prFechaHasta", fechaHasta) });
            this.SueldosPorPerfilTableAdapter.Fill(this.DSListadoSueldos.SueldosPorPerfil);
            RVListado.RefreshReport();
        }
    }
}
