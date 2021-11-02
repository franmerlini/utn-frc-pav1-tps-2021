using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.CapaPresentacion.Reportes.ReporteSueldos
{
    public partial class FrmReporteSueldos : Form
    {
        public FrmReporteSueldos()
        {
            InitializeComponent();
        }

        private void FrmReporteSueldos_Load(object sender, EventArgs e)
        {
            dateFechaDesde.Value = DateTime.Today.AddMonths(-1);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
