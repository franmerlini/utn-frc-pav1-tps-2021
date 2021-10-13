using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.CapaLogicaNegocio.Services;
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

namespace BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldosPH
{
    public partial class FrmSueldosPH : Form
    {
        private readonly SueldoPerfilHistoricoService sueldoPerfilHistoricoService;
        private readonly PerfilService perfilService;
        private readonly Dictionary<string, object> parametros = new Dictionary<string, object>();

        public FrmSueldosPH()
        {
            InitializeComponent();
            InitializeDataGridView();
            sueldoPerfilHistoricoService = new SueldoPerfilHistoricoService();
            perfilService = new PerfilService();
        }

        private void InitializeDataGridView()
        {
            DgvSueldosPH.ColumnCount = 3;
            DgvSueldosPH.ColumnHeadersVisible = true;
            DgvSueldosPH.AutoGenerateColumns = false;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            DgvSueldosPH.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            CrearColumnas(DgvSueldosPH, 0, "Perfil", "Perfil", 238);
            CrearColumnas(DgvSueldosPH, 1, "Fecha", "Fecha", 120);
            CrearColumnas(DgvSueldosPH, 2, "Sueldo", "Sueldo", 462);
            DgvSueldosPH.Columns[2].DefaultCellStyle.Format = "C";
        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        private void LlenarCombo(ComboBox cbx, Object source, string display, String value)
        {
            cbx.DataSource = source;
            cbx.DisplayMember = display;
            cbx.ValueMember = value;
            cbx.SelectedIndex = -1;
        }

        private void FrmSueldosPH_Load(object sender, EventArgs e)
        {
            LlenarCombo(CboPerfil, perfilService.ObtenerPerfiles(), "Nombre", "IdPerfil");
            dateFechaDesde.Value = DateTime.Today.AddMonths(-1);
            dateFechaDesde.Checked = true;
            dateFechaHasta.Value = DateTime.Today;
            dateFechaHasta.Checked = true;

            var parametros = new Dictionary<string, object>
            {
                {"fechaDesde", DateTime.Today.AddMonths(-1)},
                { "fechaHasta", DateTime.Today }
            };

            Consultar(parametros, false);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            parametros.Clear();

            if (DateTime.TryParse(dateFechaDesde.Text, out DateTime fechaDesde) && dateFechaDesde.Checked)
            {
                parametros.Add("fechaDesde", fechaDesde);
            }

            if (DateTime.TryParse(dateFechaHasta.Text, out DateTime fechaHasta) && dateFechaHasta.Checked)
            {
                parametros.Add("fechaHasta", fechaHasta);
            }

            if (CboPerfil.SelectedValue != null)
            {
                string perfil = CboPerfil.SelectedValue.ToString();
                parametros.Add("idPerfil", perfil);
            }

            Consultar(parametros, true);
        }

        private void Consultar(Dictionary<string, object> parametros = null, bool mostrarMensaje = true)
        {
            IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico(parametros);
            DgvSueldosPH.DataSource = listadoSueldos;
            lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;

            if (listadoSueldos.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CboPerfil.SelectedIndex = -1;
        }
    }
}
