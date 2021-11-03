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
        public Usuario Usuario { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }

        internal void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string cont = txtContra.Text;

            if (nom == "" || cont == "")
            {
                MessageBox.Show("¡Asegurese de completar todos los campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuario = usuarioService.ValidarUsuario(nom, cont);
                if (Usuario != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Intente de nuevo...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChkContra_CheckedChanged(object sender, EventArgs e)
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
