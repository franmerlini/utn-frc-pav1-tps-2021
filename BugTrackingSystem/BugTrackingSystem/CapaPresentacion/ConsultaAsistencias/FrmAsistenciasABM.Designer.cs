
namespace BugTrackingSystem.CapaPresentacion
{
    partial class FrmAsistenciasABM
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistenciasABM));
            this.grpEntradas = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rtxtComentario = new System.Windows.Forms.RichTextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dateHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateHoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkBorrado = new System.Windows.Forms.CheckBox();
            this.grpEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntradas
            // 
            this.grpEntradas.Controls.Add(this.chkBorrado);
            this.grpEntradas.Controls.Add(this.btnVolver);
            this.grpEntradas.Controls.Add(this.btnCrearUsuario);
            this.grpEntradas.Controls.Add(this.btnAceptar);
            this.grpEntradas.Controls.Add(this.rtxtComentario);
            this.grpEntradas.Controls.Add(this.lblComentario);
            this.grpEntradas.Controls.Add(this.cboEstado);
            this.grpEntradas.Controls.Add(this.lblEstado);
            this.grpEntradas.Controls.Add(this.dateHoraSalida);
            this.grpEntradas.Controls.Add(this.label1);
            this.grpEntradas.Controls.Add(this.dateHoraIngreso);
            this.grpEntradas.Controls.Add(this.lblHoraIngreso);
            this.grpEntradas.Controls.Add(this.dateFecha);
            this.grpEntradas.Controls.Add(this.lblFecha);
            this.grpEntradas.Controls.Add(this.cboUsuario);
            this.grpEntradas.Controls.Add(this.lblUsuario);
            this.grpEntradas.Location = new System.Drawing.Point(-2, 0);
            this.grpEntradas.Name = "grpEntradas";
            this.grpEntradas.Size = new System.Drawing.Size(367, 366);
            this.grpEntradas.TabIndex = 1;
            this.grpEntradas.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolver.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Left;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(267, 321);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(40, 40);
            this.btnVolver.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(228, 36);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(91, 23);
            this.btnCrearUsuario.TabIndex = 28;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.BtnCrearUsuario_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAceptar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Valid_Green;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(311, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(40, 40);
            this.btnAceptar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // rtxtComentario
            // 
            this.rtxtComentario.Location = new System.Drawing.Point(114, 213);
            this.rtxtComentario.MaxLength = 500;
            this.rtxtComentario.Name = "rtxtComentario";
            this.rtxtComentario.Size = new System.Drawing.Size(203, 96);
            this.rtxtComentario.TabIndex = 26;
            this.rtxtComentario.Text = "";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(46, 213);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 13);
            this.lblComentario.TabIndex = 25;
            this.lblComentario.Text = "Comentario:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(114, 178);
            this.cboEstado.MaxLength = 50;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(204, 21);
            this.cboEstado.TabIndex = 24;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(65, 181);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // dateHoraSalida
            // 
            this.dateHoraSalida.Checked = false;
            this.dateHoraSalida.CustomFormat = "HH:mm ";
            this.dateHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHoraSalida.Location = new System.Drawing.Point(115, 143);
            this.dateHoraSalida.Name = "dateHoraSalida";
            this.dateHoraSalida.ShowUpDown = true;
            this.dateHoraSalida.Size = new System.Drawing.Size(204, 20);
            this.dateHoraSalida.TabIndex = 22;
            this.dateHoraSalida.Value = new System.DateTime(2021, 9, 21, 23, 58, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hora Salida:";
            // 
            // dateHoraIngreso
            // 
            this.dateHoraIngreso.Checked = false;
            this.dateHoraIngreso.CustomFormat = "HH:mm";
            this.dateHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHoraIngreso.Location = new System.Drawing.Point(115, 109);
            this.dateHoraIngreso.Name = "dateHoraIngreso";
            this.dateHoraIngreso.ShowUpDown = true;
            this.dateHoraIngreso.Size = new System.Drawing.Size(204, 20);
            this.dateHoraIngreso.TabIndex = 20;
            this.dateHoraIngreso.Value = new System.DateTime(2021, 9, 22, 1, 0, 0, 0);
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Location = new System.Drawing.Point(38, 112);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(71, 13);
            this.lblHoraIngreso.TabIndex = 19;
            this.lblHoraIngreso.Text = "Hora Ingreso:";
            // 
            // dateFecha
            // 
            this.dateFecha.CustomFormat = "";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(115, 73);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(204, 20);
            this.dateFecha.TabIndex = 18;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(69, 77);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboUsuario
            // 
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(115, 37);
            this.cboUsuario.MaxLength = 50;
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(107, 21);
            this.cboUsuario.TabIndex = 16;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(33, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Elegir Usuario:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Salmon;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(85, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 16);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Agregar un registro nuevo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Brown;
            this.btnSalir.Location = new System.Drawing.Point(330, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // chkBorrado
            // 
            this.chkBorrado.AutoSize = true;
            this.chkBorrado.Location = new System.Drawing.Point(115, 334);
            this.chkBorrado.Name = "chkBorrado";
            this.chkBorrado.Size = new System.Drawing.Size(63, 17);
            this.chkBorrado.TabIndex = 30;
            this.chkBorrado.Text = "Borrado";
            this.chkBorrado.UseVisualStyleBackColor = true;
            // 
            // FrmAsistenciasABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 366);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpEntradas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAsistenciasABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo registro";
            this.Load += new System.EventHandler(this.FrmAsistenciasABM_Load);
            this.grpEntradas.ResumeLayout(false);
            this.grpEntradas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEntradas;
        private System.Windows.Forms.RichTextBox rtxtComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dateHoraSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHoraIngreso;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkBorrado;
    }
}