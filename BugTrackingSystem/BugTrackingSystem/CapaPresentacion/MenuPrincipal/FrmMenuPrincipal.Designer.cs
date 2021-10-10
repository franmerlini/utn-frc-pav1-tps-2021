
namespace BugTrackingSystem.Forms
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.MnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAsistencias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAsignaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDescuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSueldosPorPefil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTransaccion = new System.Windows.Forms.ToolStripMenuItem();
            this.generacionMensualDeSueldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.MnsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsPrincipal
            // 
            this.MnsPrincipal.BackColor = System.Drawing.Color.Salmon;
            this.MnsPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiArchivo,
            this.tsiGestion,
            this.tsiTransaccion,
            this.tsiReportes,
            this.tsiAyuda});
            this.MnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnsPrincipal.Name = "MnsPrincipal";
            this.MnsPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MnsPrincipal.Size = new System.Drawing.Size(1443, 28);
            this.MnsPrincipal.TabIndex = 0;
            this.MnsPrincipal.Text = "menuStrip1";
            this.MnsPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MnsPrincipal_MouseMove);
            // 
            // tsiArchivo
            // 
            this.tsiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiSalir});
            this.tsiArchivo.Enabled = false;
            this.tsiArchivo.Name = "tsiArchivo";
            this.tsiArchivo.Size = new System.Drawing.Size(73, 24);
            this.tsiArchivo.Text = "Archivo";
            // 
            // tsiSalir
            // 
            this.tsiSalir.Name = "tsiSalir";
            this.tsiSalir.Size = new System.Drawing.Size(121, 26);
            this.tsiSalir.Text = "Salir";
            this.tsiSalir.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // tsiGestion
            // 
            this.tsiGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAsistencias,
            this.tsiAsignaciones,
            this.tsiDescuentos,
            this.tsiSueldosPorPefil,
            this.tsiUsuarios});
            this.tsiGestion.Enabled = false;
            this.tsiGestion.Name = "tsiGestion";
            this.tsiGestion.Size = new System.Drawing.Size(73, 24);
            this.tsiGestion.Text = "Gestion";
            // 
            // tsiAsistencias
            // 
            this.tsiAsistencias.Name = "tsiAsistencias";
            this.tsiAsistencias.Size = new System.Drawing.Size(245, 26);
            this.tsiAsistencias.Text = "Asistencias";
            this.tsiAsistencias.Click += new System.EventHandler(this.TsiAsignaciones_Click);
            // 
            // tsiAsignaciones
            // 
            this.tsiAsignaciones.Name = "tsiAsignaciones";
            this.tsiAsignaciones.Size = new System.Drawing.Size(196, 22);
            this.tsiAsignaciones.Text = "Asignaciones";
            this.tsiAsignaciones.Click += new System.EventHandler(this.TsiSueldosAsignaciones_Click);
            // 
            // tsiDescuentos
            // 
            this.tsiDescuentos.Name = "tsiDescuentos";
            this.tsiDescuentos.Size = new System.Drawing.Size(196, 22);
            this.tsiDescuentos.Text = "Descuentos";
            this.tsiDescuentos.Click += new System.EventHandler(this.TsiSueldosDescuentos_Click);
            // 
            // tsiSueldosPorPefil
            // 
            this.tsiSueldosPorPefil.Name = "tsiSueldosPorPefil";
            this.tsiSueldosPorPefil.Size = new System.Drawing.Size(245, 26);
            this.tsiSueldosPorPefil.Text = "Sueldos Perfil Histórico";
            this.tsiSueldosPorPefil.Click += new System.EventHandler(this.TsiSueldosPorPefil_Click);
            // 
            // tsiUsuarios
            // 
            this.tsiUsuarios.Name = "tsiUsuarios";
            this.tsiUsuarios.Size = new System.Drawing.Size(245, 26);
            this.tsiUsuarios.Text = "Usuarios";
            this.tsiUsuarios.Click += new System.EventHandler(this.TsiUsuarios_Click);
            // 
            // tsiTransaccion
            // 
            this.tsiTransaccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generacionMensualDeSueldosToolStripMenuItem});
            this.tsiTransaccion.Enabled = false;
            this.tsiTransaccion.Name = "tsiTransaccion";
            this.tsiTransaccion.Size = new System.Drawing.Size(114, 24);
            this.tsiTransaccion.Text = "Transacciones";
            // 
            // generacionMensualDeSueldosToolStripMenuItem
            // 
            this.generacionMensualDeSueldosToolStripMenuItem.Name = "generacionMensualDeSueldosToolStripMenuItem";
            this.generacionMensualDeSueldosToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.generacionMensualDeSueldosToolStripMenuItem.Text = "Generacion mensual de sueldos";
            this.generacionMensualDeSueldosToolStripMenuItem.Click += new System.EventHandler(this.generacionMensualDeSueldosToolStripMenuItem_Click);
            // 
            // tsiReportes
            // 
            this.tsiReportes.Enabled = false;
            this.tsiReportes.Name = "tsiReportes";
            this.tsiReportes.Size = new System.Drawing.Size(82, 24);
            this.tsiReportes.Text = "Reportes";
            // 
            // tsiAyuda
            // 
            this.tsiAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.tsiAyuda.Name = "tsiAyuda";
            this.tsiAyuda.Size = new System.Drawing.Size(65, 24);
            this.tsiAyuda.Text = "Ayuda";
            // 
            // mostrarAyudaToolStripMenuItem
            // 
            this.mostrarAyudaToolStripMenuItem.Name = "mostrarAyudaToolStripMenuItem";
            this.mostrarAyudaToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.mostrarAyudaToolStripMenuItem.Text = "Mostrar ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(628, 7);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(172, 17);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bug Tracking System";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Salmon;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Brown;
            this.btnMinimizar.Location = new System.Drawing.Point(1375, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 30);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.Text = "―";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Brown;
            this.btnSalir.Location = new System.Drawing.Point(1408, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(35, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.LblNombre.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblNombre.Location = new System.Drawing.Point(4, 620);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(224, 17);
            this.LblNombre.TabIndex = 11;
            this.LblNombre.Text = "Usuario Conectado: - Perfil:";
            this.LblNombre.Visible = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.layered_peaks_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 644);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.MnsPrincipal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnsPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracking System";
            this.TransparencyKey = System.Drawing.Color.Brown;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMenuPrincipal_Shown);
            this.MnsPrincipal.ResumeLayout(false);
            this.MnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsiSalir;
        private System.Windows.Forms.ToolStripMenuItem tsiGestion;
        private System.Windows.Forms.ToolStripMenuItem tsiAsistencias;
        private System.Windows.Forms.ToolStripMenuItem tsiTransaccion;
        private System.Windows.Forms.ToolStripMenuItem tsiAyuda;
        private System.Windows.Forms.ToolStripMenuItem mostrarAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem generacionMensualDeSueldosToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.MenuStrip MnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsiSueldosPorPefil;
        private System.Windows.Forms.ToolStripMenuItem tsiAsignaciones;
        private System.Windows.Forms.ToolStripMenuItem tsiDescuentos;
        private System.Windows.Forms.ToolStripMenuItem tsiReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label LblNombre;
    }
}