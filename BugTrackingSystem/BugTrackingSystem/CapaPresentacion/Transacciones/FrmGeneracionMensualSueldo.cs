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
        private readonly SueldoPerfilHistoricoService sueldoPerfilHistoricoService;

        public FrmGeneracionMensualSueldo()
        {
            InitializeComponent();
            InitializeDataGridView();

            usuarioService = new UsuarioService();
            sueldoService = new SueldoService();
            descuentoService = new DescuentoService();
            asignacionService = new AsignacionService();
            sueldoPerfilHistoricoService = new SueldoPerfilHistoricoService();

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
                LimpiarTransaccion();
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

            if (Existe(sueldo) == 1)
            {
                MessageBox.Show("Ya existe una transacción con tal fecha y usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (Existe(sueldo) == 2)
            {
                DialogResult rta = MessageBox.Show("Ya se ha registrado un recibo de sueldo en este mes para el usuario. ¿Seguro que desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rta == DialogResult.No)
                    return;

                if (txtSueldoTotal.Text.Contains("-"))
                {
                    DialogResult respuesta = MessageBox.Show("El sueldo total es menor a 0. ¿Continuar de todas formas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (respuesta == DialogResult.No)
                        return;
                }
            }
            else if (txtSueldoTotal.Text.Contains("-"))
            {
                DialogResult rta = MessageBox.Show("El sueldo total es menor a 0. ¿Seguro que desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rta == DialogResult.No)
                    return;
            }
            else
            {
                DialogResult rta = MessageBox.Show("¿Está seguro que desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rta == DialogResult.No)
                    return;
            }

            foreach (SueldoAsignacion s in listaSueldoAsignacion)
            {
                s.Fecha = dtpFecha.Value;
                s.Usuario = (Usuario)cboUsuario.SelectedItem;
            }

            foreach (SueldoDescuento s in listaSueldoDescuento)
            {
                s.Fecha = dtpFecha.Value;
                s.Usuario = (Usuario)cboUsuario.SelectedItem;
            }

            var sueldoPerfilHistorico = new SueldoPerfilHistorico()
            {
                Sueldo = sueldo.SueldoBruto,
                Perfil = sueldo.Usuario.Perfil,
                Fecha = sueldo.Fecha
            };

            IList<SueldoPerfilHistorico> listaSueldosHistoricos = sueldoPerfilHistoricoService.ObtenerSueldosPerfilHistorico();
            foreach (SueldoPerfilHistorico s in listaSueldosHistoricos)
            {
                if (s.Perfil.IdPerfil == sueldoPerfilHistorico.Perfil.IdPerfil && s.Fecha.ToString("dd/MM/yyyy") == sueldoPerfilHistorico.Fecha.ToString("dd/MM/yyyy"))
                {
                    if (s.Sueldo == sueldoPerfilHistorico.Sueldo)
                    {
                        sueldoPerfilHistorico = null;
                        break;
                    }

                    DialogResult rta = MessageBox.Show("Ya existe en el sistema un sueldo histórico con perfil " + s.Perfil.Nombre + " y fecha " + s.Fecha.ToString("dd/MM/yyyy") + ", cuyo sueldo bruto es " + s.Sueldo.ToString("C") + ". ¿Desea reemplazarlo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (rta == DialogResult.Yes)
                    {
                        break;
                    }
                    else
                    {
                        sueldoPerfilHistorico = null;
                        break;
                    }                   
                }
            }

            var n = sueldoService.CrearSueldoTransaccion(sueldo, listaSueldoAsignacion, listaSueldoDescuento, sueldoPerfilHistorico);
            if (n == 1)
            {
                MessageBox.Show("Algunos montos o cantidades exceden valores máximos disponibles. Reintente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (n == 0)
            {
                DialogResult rta = MessageBox.Show("Sueldo generado correctamente. \n ¿Desea limpiar la transacción?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (rta == DialogResult.Yes)
                {
                    LimpiarTransaccion();
                }
            }
        }

        private int Existe(Sueldo sueldo)
        {
            IList<Sueldo> listadoSueldos = sueldoService.ObtenerSueldos();

            foreach (Sueldo s in listadoSueldos)
            {
                if (s.Usuario.IdUsuario.Equals(sueldo.Usuario.IdUsuario) && (s.Fecha.ToString("dd/MM/yyyy")).Equals(sueldo.Fecha.ToString("dd/MM/yyyy")))
                    return 1;
            }

            foreach (Sueldo s in listadoSueldos)
            {
                if (s.Usuario.IdUsuario.Equals(sueldo.Usuario.IdUsuario) && (s.Fecha.Month.Equals(sueldo.Fecha.Month)))
                    return 2;
            }

            return 0;
        }

        private void LimpiarTransaccion()
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
}
