using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.CapaPresentacion.ConsultaDescuentos
{
    public partial class FrmDescuentosABM : Form
    {
        private readonly DescuentoService descuentoService;
        private readonly Descuento descuentoSeleccionado;
        public enum FormMode { nuevo, actualizar };
        private readonly FormMode formMode;

        public FrmDescuentosABM(FormMode formMode, Descuento descuento = null)
        {
            InitializeComponent();
            descuentoService = new DescuentoService();
            this.formMode = formMode;
            descuentoSeleccionado = descuento;
        }

        private void FrmDescuentosABM_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Agregar un registro nuevo";
                        chkBorrado.Visible = false;
                        break;
                    }
                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar un registro";
                        lblTitulo.Text = "Actualizar un registro";
                        TxtNombre.Text = descuentoSeleccionado.Nombre;
                        nudMonto.Value = descuentoSeleccionado.Monto;
                        chkBorrado.Checked = descuentoSeleccionado.Borrado;
                        break;
                    }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Descuento descuento = new Descuento();

            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para el descuento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                descuento.Nombre = TxtNombre.Text;

            descuento.Monto = nudMonto.Value;

            switch (formMode)
            {
                case FormMode.nuevo:
                    {

                        if (descuentoService.CrearDescuento(descuento))
                        {
                            MessageBox.Show("¡Registro creado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            nudMonto.Value = 0;
                            TxtNombre.Text = "";
                        }
                        else
                            MessageBox.Show("El registro no se ha podido crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {

                        descuento.Borrado = chkBorrado.Checked;
                        descuento.IdDescuento = descuentoSeleccionado.IdDescuento;

                        if (descuentoService.ActualizarDescuento(descuento))
                        {
                            MessageBox.Show("Descuento actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar el descuento!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Código para poder mover la ventana desde el menu strip

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
