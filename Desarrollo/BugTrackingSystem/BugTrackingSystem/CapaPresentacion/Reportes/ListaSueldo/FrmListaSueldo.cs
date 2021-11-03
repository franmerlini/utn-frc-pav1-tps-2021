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

namespace BugTrackingSystem.CapaPresentacion.Reportes.ListaSueldo
{
    public partial class FrmListaSueldo : Form
    {
        public FrmListaSueldo()
        {
            InitializeComponent();
        }

        private void FrmListaSueldo_Load(object sender, EventArgs e)
        {
            dateFechaDesde.Value = DateTime.Today.AddMonths(-1);

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fechaDesde = dateFechaDesde.Text;
            string fechaHasta = dateFechaHasta.Text;
            RVReporte.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("prFechaDesde", fechaDesde), new ReportParameter("prFechaHasta", fechaHasta) });
            this.taSueldoNetoTableAdapter.Fill(this.dsSueldo.TaSueldoNeto);
            RVReporte.RefreshReport();
        }
    }
}
