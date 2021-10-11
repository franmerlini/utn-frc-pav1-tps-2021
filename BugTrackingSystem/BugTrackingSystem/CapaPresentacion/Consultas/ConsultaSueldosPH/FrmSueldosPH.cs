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
            DgvSueldosPH.ColumnCount = 4;
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
            CrearColumnas(DgvSueldosPH, 3, "Borrado", "Borrado", 110);
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

            IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico();
            DgvSueldosPH.DataSource = listadoSueldos;
            lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;
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

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico(parametros);
            DgvSueldosPH.DataSource = listadoSueldos;
            lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;

            if (listadoSueldos.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CboPerfil.SelectedIndex = -1;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvSueldosPH.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoPerfilHistorico sueldoPerfilHistorico = (SueldoPerfilHistorico)DgvSueldosPH.CurrentRow.DataBoundItem;

            if (sueldoPerfilHistorico.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                sueldoPerfilHistorico.Borrado = true;

                var parametrosEliminacion = new Dictionary<string, object>
                {
                    {"idPerfilBase", Convert.ToInt32(sueldoPerfilHistorico.Perfil.IdPerfil) },
                    {"fechaBase", Convert.ToDateTime(sueldoPerfilHistorico.Fecha) }
                };

                if (!sueldoPerfilHistoricoService.ActualizarSueldoPerfilHistorico(sueldoPerfilHistorico, parametrosEliminacion))
                    MessageBox.Show("El registro no se pudo borrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico(parametros);
                DgvSueldosPH.DataSource = listadoSueldos;
                lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmSueldosPHABM frmAgregar = new FrmSueldosPHABM(FrmSueldosPHABM.FormMode.nuevo);
            frmAgregar.ShowDialog();

            IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico(parametros);
            DgvSueldosPH.DataSource = listadoSueldos;
            lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvSueldosPH.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de editarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SueldoPerfilHistorico sueldoPerfilHistorico = (SueldoPerfilHistorico)DgvSueldosPH.CurrentRow.DataBoundItem;
            FrmSueldosPHABM frmEditar = new FrmSueldosPHABM(FrmSueldosPHABM.FormMode.actualizar, sueldoPerfilHistorico);
            frmEditar.ShowDialog();

            IList<SueldoPerfilHistorico> listadoSueldos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico(parametros);
            DgvSueldosPH.DataSource = listadoSueldos;
            lblTotal.Text = "Registros encontrados: " + listadoSueldos.Count;
        }
    }
}
