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
            this.RvReporte.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            // ReportDataSource reportDataSource = new ReportDataSource();
            // reportDataSource.Name = "DsReporte";
            // reportDataSource.Value = D
            this.RvReporte.RefreshReport();
        }
    }
}
