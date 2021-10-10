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

namespace BugTrackingSystem.CapaPresentacion
{
    public partial class FrmGeneracionMensualSueldo : Form
    {
        private BindingList<SueldoAsignacion> listaSueldoAsignacion;
        private BindingList<SueldoDescuento> listaSueldoDescuento;
        private readonly UsuarioService usuarioService;
        private readonly SueldoService sueldoService;
        private readonly DescuentoService descuentoService;
        private readonly AsignacionService asignacionService;

        public FrmGeneracionMensualSueldo()
        {
            InitializeComponent();
            InitializeDataGridView();

            usuarioService = new UsuarioService();
            sueldoService = new SueldoService();
            descuentoService = new DescuentoService();
            asignacionService = new AsignacionService();

            listaSueldoAsignacion = new BindingList<SueldoAsignacion>();
            listaSueldoDescuento = new BindingList<SueldoDescuento>();
        }

        private void FrmGeneracionMensualSueldo_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboUsuario, usuarioService.ObtenerUsuarios(), "Nombre");

            dgvAsignaciones.DataSource = listaSueldoAsignacion;
            dgvDescuentos.DataSource = listaSueldoDescuento;
        }

        private void InitializeDataGridView()   
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvAsignaciones.ColumnCount = 3;
            dgvAsignaciones.ColumnHeadersVisible = true;
            dgvDescuentos.ColumnCount = 3;
            dgvDescuentos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvAsignaciones.AutoGenerateColumns = false;
            dgvDescuentos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Beige,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            dgvAsignaciones.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvDescuentos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            CrearColumnas(dgvAsignaciones, 0, "Asignación", "Asignacion", 210, "");
            CrearColumnas(dgvAsignaciones, 1, "Cantidad", "Cantidad", 110, "");
            CrearColumnas(dgvAsignaciones, 2, "Monto Total", "Monto", 110, "C");
            CrearColumnas(dgvDescuentos, 0, "Descuento", "Descuento", 210, "");
            CrearColumnas(dgvDescuentos, 1, "Cantidad", "Cantidad", 110, "");
            CrearColumnas(dgvDescuentos, 2, "Monto Total", "Monto", 110, "C");
        }

        private void CrearColumnas(DataGridView tabla, int columna, string nombre, string propiedad, int tamaño, string formato)
        {
            tabla.Columns[columna].Name = nombre;
            tabla.Columns[columna].DataPropertyName = propiedad;
            tabla.Columns[columna].DefaultCellStyle.Format = formato;
            tabla.Columns[columna].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tabla.Columns[columna].Width = tamaño;
        }

        private void LlenarCombo(ComboBox cbx, Object source, string display)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbx.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbx.DisplayMember = display;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbx.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cboDtoAsig.SelectedItem == null)
            {
                MessageBox.Show("Debe elegir una asignación/descuento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbAsignacion.Checked)
            {
                bool bandera = true;

                foreach (SueldoAsignacion s in listaSueldoAsignacion)
                {
                    if (s.Asignacion.IdAsignacion.Equals(((Asignacion)cboDtoAsig.SelectedItem).IdAsignacion))
                    {
                        s.Cantidad += Convert.ToInt32(nudCantidad.Value);
                        s.Monto += Convert.ToDecimal(txtImporte.Text);
                        bandera = false;
                        break;
                    }
                }

                if (bandera)
                {
                    listaSueldoAsignacion.Add(new SueldoAsignacion()
                    {
                        // Usuario = (Usuario)cboUsuario.SelectedItem, --> Deberían ser agregados al final de la transacción, dentro del foreach
                        // Fecha = (DateTime)dtpFecha.Value,
                        Asignacion = (Asignacion)cboDtoAsig.SelectedItem,
                        Monto = Convert.ToDecimal(txtImporte.Text),
                        Cantidad = Convert.ToInt32(nudCantidad.Value)
                    });
                }

                dgvAsignaciones.Refresh();
            }
            else if (rbDescuento.Checked)
            {
                bool bandera = true;

                foreach (SueldoDescuento s in listaSueldoDescuento)
                {
                    if (s.Descuento.IdDescuento.Equals(((Descuento)cboDtoAsig.SelectedItem).IdDescuento))
                    {
                        s.Cantidad += Convert.ToInt32(nudCantidad.Value);
                        s.Monto += Convert.ToDecimal(txtImporte.Text);
                        bandera = false;
                        break;
                    }
                }

                if (bandera)
                {
                    listaSueldoDescuento.Add(new SueldoDescuento()
                    {
                        // Usuario = (Usuario)cboUsuario.SelectedItem, --> Deberían ser agregados al final de la transacción, dentro del foreach
                        // Fecha = (DateTime)dtpFecha.Value,
                        Descuento = (Descuento)cboDtoAsig.SelectedItem,
                        Monto = Convert.ToDecimal(txtImporte.Text),
                        Cantidad = Convert.ToInt32(nudCantidad.Value)
                    });
                }

                dgvDescuentos.Refresh();
            }

            CalcularTotales();
            cboDtoAsig.SelectedIndex = -1;
            nudCantidad.Value = 1;
            dgvDescuentos.ClearSelection();
            dgvAsignaciones.ClearSelection();
        }

        private void CalcularTotales()
        {
            decimal totalAsignaciones = listaSueldoAsignacion.Sum(a => a.Monto);
            txtAsigSueldo.Text = totalAsignaciones.ToString("C");

            decimal totalDescuentos = listaSueldoDescuento.Sum(d => d.Monto);
            txtDtoSueldo.Text = totalDescuentos.ToString("C");

            var sueldoBruto = nudSueldoBruto.Value;

            var importeTotal = sueldoBruto + totalAsignaciones - totalDescuentos;
            txtSueldoTotal.Text = importeTotal.ToString("C");
        }

        private void cboDtoAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarMontoEImporte();
        }

        private void ActualizarMontoEImporte()
        {
            if (cboDtoAsig.SelectedIndex == -1)
            {
                txtDtoAsig.Text = "";
                txtImporte.Text = "";
                return;
            }

            if (rbAsignacion.Checked)
            {
                Asignacion seleccionada = (Asignacion)cboDtoAsig.SelectedItem;
                txtDtoAsig.Text = (seleccionada.Monto).ToString();
                txtImporte.Text = (seleccionada.Monto * nudCantidad.Value).ToString();
            }
            else if (rbDescuento.Checked)
            {
                Descuento seleccionado = (Descuento)cboDtoAsig.SelectedItem;
                txtDtoAsig.Text = (seleccionado.Monto).ToString();
                txtImporte.Text = (seleccionado.Monto * nudCantidad.Value).ToString();
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarMontoEImporte();
        }

        private void rbDescuento_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboDtoAsig, descuentoService.ObtenerDescuentos(), "Nombre");
            ActualizarMontoEImporte();
        }

        private void rbAsignacion_Click(object sender, EventArgs e)
        {
            LlenarCombo(cboDtoAsig, asignacionService.ObtenerAsignaciones(), "Nombre");
            ActualizarMontoEImporte();
        }

        private void nudSueldoBruto_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Seguro que desea limpiar la transacción?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rta == DialogResult.Yes)
            {
                cboUsuario.SelectedIndex = -1;
                dtpFecha.Value = DateTime.Today;
                nudSueldoBruto.Value = 0;
                nudCantidad.Value = 1;
                cboDtoAsig.SelectedIndex = -1;
                ActualizarMontoEImporte();
                listaSueldoAsignacion.Clear();
                listaSueldoDescuento.Clear();
                CalcularTotales();
            }
        }

        private void dgvAsignaciones_Click(object sender, EventArgs e)
        {
            dgvDescuentos.ClearSelection();
        }

        private void dgvDescuentos_Click(object sender, EventArgs e)
        {
            dgvAsignaciones.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDescuentos.SelectedCells.Count > 0)
            {
                SueldoDescuento sueldoDescuento = (SueldoDescuento)dgvDescuentos.CurrentRow.DataBoundItem;
                listaSueldoDescuento.Remove(sueldoDescuento);
                CalcularTotales();
                return;
            };

            if (dgvAsignaciones.SelectedCells.Count > 0)
            {
                SueldoAsignacion sueldoAsignacion = (SueldoAsignacion)dgvAsignaciones.CurrentRow.DataBoundItem;
                listaSueldoAsignacion.Remove(sueldoAsignacion);
                CalcularTotales();
                return;
            };

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Sueldo sueldo = new Sueldo();

            if (txtSueldoTotal.Text.Contains("-"))
            {
                DialogResult rta = MessageBox.Show("El sueldo total es menor a 0. ¿Seguro que desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rta == DialogResult.No)
                    return;
            }

            if (cboUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                sueldo.Usuario = (Usuario)cboUsuario.SelectedItem;

            sueldo.Fecha = dtpFecha.Value;

            if (nudSueldoBruto.Value == 0)
            {
                MessageBox.Show("Debe asignar un sueldo bruto mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
                sueldo.SueldoBruto = nudSueldoBruto.Value;

            if (Existe(sueldo))
            {
                MessageBox.Show("Ya existe una transacción con tal fecha y usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // A partir de acá se realiza la transaction

            if (true) // Si la transaccion se genera correctamente (cambiar el true por lo que corresponda)
            {
                DialogResult rta = MessageBox.Show("Sueldo generado correctamente. ¿Desea limpiar la transacción?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rta == DialogResult.Yes)
                {
                    cboUsuario.SelectedIndex = -1;
                    dtpFecha.Value = DateTime.Today;
                    nudSueldoBruto.Value = 0;
                    nudCantidad.Value = 1;
                    cboDtoAsig.SelectedIndex = -1;
                    ActualizarMontoEImporte();
                    listaSueldoAsignacion.Clear();
                    listaSueldoDescuento.Clear();
                    CalcularTotales();
                }
            }
            else
                MessageBox.Show("Hubo un error al generar la transacción. Por favor revise los datos nuevamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Existe(Sueldo sueldo)
        {
            var parametro = new Dictionary<string, object>()
            {
                { "borrado", true },
                { "idUsuario", ((Usuario)cboUsuario.SelectedItem).IdUsuario },
                { "fechaExacta", (dtpFecha.Value) }
            };

            IList<Sueldo> listadoSueldos = sueldoService.ObtenerSueldos(parametro);

            foreach (Sueldo s in listadoSueldos)
            {
                if (s.Usuario.IdUsuario.Equals(sueldo.Usuario.IdUsuario) && (s.Fecha.ToString("dd/MM/yyyy")).Equals(sueldo.Fecha.ToString("dd/MM/yyyy")))
                    return true;
            }
            return false;
        }
    }
}
