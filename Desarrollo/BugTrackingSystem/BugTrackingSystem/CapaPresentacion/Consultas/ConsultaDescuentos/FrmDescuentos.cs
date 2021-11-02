using BugTrackingSystem.CapaLogicaNegocio;
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

namespace BugTrackingSystem.CapaPresentacion.ConsultaDescuentos
{
    public partial class FrmDescuentos : Form
    {
        private readonly DescuentoService descuentoService;
        private readonly Dictionary<string, object> parametros;

        public FrmDescuentos()
        {
            InitializeComponent();
            InitializeDataGridView();
            descuentoService = new DescuentoService();
            parametros = new Dictionary<string, object>();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            DgvDescuentos.ColumnCount = 3;
            DgvDescuentos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            DgvDescuentos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            DgvDescuentos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(DgvDescuentos, 0, "Nombre", "Nombre");
            CrearColumnas(DgvDescuentos, 1, "Monto", "Monto");
            DgvDescuentos.Columns[1].DefaultCellStyle.Format = "C";
            CrearColumnas(DgvDescuentos, 2, "Borrado", "Borrado");
            DgvDescuentos.Columns[2].Visible = false;

        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void FrmDescuentos_Load(object sender, EventArgs e)
        {
            Consultar(parametros, false);
        }

        // Botones:

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            parametros.Clear();

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            Consultar(parametros, true);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvDescuentos.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Descuento descuento = (Descuento)DgvDescuentos.CurrentRow.DataBoundItem;

            if (descuento.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                descuento.Borrado = true;

                if (!descuentoService.ActualizarDescuento(descuento))
                    MessageBox.Show("El registro no se pudo borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Consultar(parametros, false);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmDescuentosABM frmAgregar = new FrmDescuentosABM(FrmDescuentosABM.FormMode.nuevo);
            frmAgregar.ShowDialog();

            Consultar(parametros, false);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvDescuentos.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de editarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Descuento descuento = (Descuento)DgvDescuentos.CurrentRow.DataBoundItem;
            FrmDescuentosABM frmEditar = new FrmDescuentosABM(FrmDescuentosABM.FormMode.actualizar, descuento);
            frmEditar.ShowDialog();

            Consultar(parametros, false);
        }

        private void Consultar(Dictionary<string, object> parametros = null, bool mostrarMensaje = true)
        {
            IList<Descuento> listadoDescuentos = descuentoService.ObtenerDescuentos(parametros);
            DgvDescuentos.DataSource = listadoDescuentos;
            lblTotal.Text = "Registros encontrados: " + listadoDescuentos.Count;

            if (listadoDescuentos.Count == 0 && mostrarMensaje)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvDescuentos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow a in DgvDescuentos.Rows)
            {
                if ((bool)a.Cells[2].Value)
                {
                    a.DefaultCellStyle.BackColor = Color.LightGray;
                }

            }
        }
    }
}
