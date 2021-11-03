using BugTrackingSystem.CapaAccesoDatos.DataSet;
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

namespace BugTrackingSystem.CapaPresentacion.Reportes.ReporteSueldo
{
    public partial class FrmReporteSueldo : Form
    {
        public FrmReporteSueldo()
        {
            InitializeComponent();
        }

        private void FrmReporteSueldo_Load(object sender, EventArgs e)
        {
            dateFechaDesde.Value = DateTime.Today.AddMonths(-1);
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string fechaDesde = dateFechaDesde.Text;
            string fechaHasta = dateFechaHasta.Text;
            RvReporte.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prFechaDesde", fechaDesde), new ReportParameter("prFechaHasta", fechaHasta) });
            this.descuentosTableAdapter.Fill(this.dsSueldo.Descuentos);
            this.asignacionesTableAdapter.Fill(this.dsSueldo.Asignaciones);
            this.taSueldoHistoricoTableAdapter.Fill(this.dsSueldo.TaSueldoHistorico);
            this.RvReporte.RefreshReport();
        }
    }
}
