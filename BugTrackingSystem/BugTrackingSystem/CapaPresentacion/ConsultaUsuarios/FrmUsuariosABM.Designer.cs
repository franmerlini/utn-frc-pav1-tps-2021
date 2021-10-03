
namespace BugTrackingSystem.CapaPresentacion.ConsultaUsuarios
{
    partial class FrmUsuariosABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.CboPerfil = new System.Windows.Forms.ComboBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkBorrado = new System.Windows.Forms.CheckBox();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Brown;
            this.btnSalir.Location = new System.Drawing.Point(341, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Salmon;
            this.LblTitulo.Enabled = false;
            this.LblTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblTitulo.Location = new System.Drawing.Point(87, 4);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(198, 16);
            this.LblTitulo.TabIndex = 31;
            this.LblTitulo.Text = "Agregar un registro nuevo";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Elegir Perfil:";
            // 
            // CboPerfil
            // 
            this.CboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPerfil.FormattingEnabled = true;
            this.CboPerfil.Location = new System.Drawing.Point(119, 87);
            this.CboPerfil.MaxLength = 50;
            this.CboPerfil.Name = "CboPerfil";
            this.CboPerfil.Size = new System.Drawing.Size(204, 21);
            this.CboPerfil.TabIndex = 36;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(119, 123);
            this.TxtEstado.MaxLength = 1;
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(204, 20);
            this.TxtEstado.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estado:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(119, 159);
            this.TxtPassword.MaxLength = 50;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(204, 20);
            this.TxtPassword.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(119, 51);
            this.TxtUsuario.MaxLength = 50;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(204, 20);
            this.TxtUsuario.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Usuario:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(119, 195);
            this.TxtEmail.MaxLength = 50;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(204, 20);
            this.TxtEmail.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Email:";
            // 
            // ChkBorrado
            // 
            this.ChkBorrado.AutoSize = true;
            this.ChkBorrado.Location = new System.Drawing.Point(119, 232);
            this.ChkBorrado.Name = "ChkBorrado";
            this.ChkBorrado.Size = new System.Drawing.Size(63, 17);
            this.ChkBorrado.TabIndex = 45;
            this.ChkBorrado.Text = "Borrado";
            this.ChkBorrado.UseVisualStyleBackColor = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVolver.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Left;
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.BtnVolver.Location = new System.Drawing.Point(268, 232);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(40, 40);
            this.BtnVolver.TabIndex = 47;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAceptar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Valid_Green;
            this.BtnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAceptar.Location = new System.Drawing.Point(315, 232);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(40, 40);
            this.BtnAceptar.TabIndex = 46;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // FrmUsuariosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(367, 280);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.ChkBorrado);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuariosABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuariosABM";
            this.Load += new System.EventHandler(this.FrmUsuariosABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboPerfil;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkBorrado;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnAceptar;
    }
}