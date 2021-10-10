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

namespace BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones
{
    public partial class FrmAsignacionesABM : Form
    {
        private readonly AsignacionService asignacionService;
        private readonly Asignacion asignacionSeleccionado;
        public enum FormMode { nuevo, actualizar };
        private readonly FormMode formMode;

        public FrmAsignacionesABM(FormMode formMode, Asignacion asignacion = null)
        {
            InitializeComponent();
            asignacionService = new AsignacionService();
            asignacionSeleccionado = asignacion;
            this.formMode = formMode;
        }

        private void FrmAsignacionesABM_Load(object sender, EventArgs e)
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
                        TxtNombre.Text = asignacionSeleccionado.Nombre;
                        nudMonto.Value = asignacionSeleccionado.Monto;
                        chkBorrado.Checked = asignacionSeleccionado.Borrado;
                        break;
                    }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            Asignacion asignacion = new Asignacion();

            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre para la asignación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                asignacion.Nombre = TxtNombre.Text;

            asignacion.Monto = nudMonto.Value;

            switch (formMode)
            {
                case FormMode.nuevo:
                    {

                        if (asignacionService.CrearAsignacion(asignacion))
                        {
                            MessageBox.Show("¡Registro creado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtNombre.Text = "";
                            nudMonto.Value = 0;
                        }
                        else
                            MessageBox.Show("El registro no se ha podido crear", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {

                        asignacion.Borrado = chkBorrado.Checked;
                        asignacion.IdAsignacion = asignacionSeleccionado.IdAsignacion;

                        if (asignacionService.ActualizarAsignacion(asignacion))
                        {
                            MessageBox.Show("Asignación actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar la asignación!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
