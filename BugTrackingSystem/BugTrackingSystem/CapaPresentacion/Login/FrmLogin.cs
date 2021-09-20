using BugTrackingSystem.CapaLogicaNegocio;
using BugTrackingSystem.DAO;
using BugTrackingSystem.Entidades;
using BugTrackingSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class FrmLogin : Form
    {
        private readonly UsuarioService usuarioService;

        public FrmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string cont = txtContra.Text;

            if (nom == "" || cont == "")
            {
                MessageBox.Show("¡Asegurese de completar todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuario usu = usuarioService.ValidarUsuario(nom, cont);
                if (usu != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Intente de nuevo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (txtContra.PasswordChar == '•')
            {
                txtContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '•';
            }
        }
    }
}
