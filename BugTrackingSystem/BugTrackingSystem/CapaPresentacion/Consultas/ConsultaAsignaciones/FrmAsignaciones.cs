using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones
{
    public partial class FrmAsignaciones : Form
    {
        private readonly AsignacionService asignacionService;
        private readonly Dictionary<string, object> parametros;

        public FrmAsignaciones()
        {
            InitializeComponent();
            InitializeDataGridView();
            asignacionService = new AsignacionService();
            parametros = new Dictionary<string, object>();
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            DgvAsignaciones.ColumnCount = 3;
            DgvAsignaciones.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            DgvAsignaciones.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            DgvAsignaciones.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(DgvAsignaciones, 0, "Nombre", "Nombre", 210);
            CrearColumnas(DgvAsignaciones, 1, "Monto", "Monto", 120);
            DgvAsignaciones.Columns[1].DefaultCellStyle.Format = "C";
            CrearColumnas(DgvAsignaciones, 2, "Borrado", "Borrado", 120);
        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        private void FrmAsignaciones_Load(object sender, EventArgs e)
        {
            IList<Asignacion> listadoAsignaciones = asignacionService.ObtenerAsignaciones();
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }

        // Botones:

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            parametros.Clear();

            if (ChkBaja.Checked)
            {
                parametros.Add("borrado", true);
            }

            IList<Asignacion> listadoAsignaciones = asignacionService.ObtenerAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;

            if (listadoAsignaciones.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAsignacionesABM frmAgregar = new FrmAsignacionesABM(FrmAsignacionesABM.FormMode.nuevo);
            frmAgregar.ShowDialog();

            IList<Asignacion> listadoAsignaciones = asignacionService.ObtenerAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvAsignaciones.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de editarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Asignacion asignacion = (Asignacion)DgvAsignaciones.CurrentRow.DataBoundItem;
            FrmAsignacionesABM frmEditar = new FrmAsignacionesABM(FrmAsignacionesABM.FormMode.actualizar, asignacion);
            frmEditar.ShowDialog();

            IList<Asignacion> listadoAsignaciones = asignacionService.ObtenerAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvAsignaciones.RowCount.Equals(0))
            {
                MessageBox.Show("Debe seleccionar un registro antes de eliminarlo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Asignacion asignacion = (Asignacion)DgvAsignaciones.CurrentRow.DataBoundItem;

            if (asignacion.Borrado == true)
            {
                MessageBox.Show("¡No puede eliminar un registro ya borrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rta = MessageBox.Show("¿Seguro que desea borrar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                asignacion.Borrado = true;

                if (!asignacionService.ActualizarAsignacion(asignacion))
                    MessageBox.Show("El registro no se pudo borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            IList<Asignacion> listadoAsignaciones = asignacionService.ObtenerAsignaciones(parametros);
            DgvAsignaciones.DataSource = listadoAsignaciones;
            lblTotal.Text = "Registros encontrados: " + listadoAsignaciones.Count;
        }

    }


}
