
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
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAsignaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAsistencias = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTransaccion = new System.Windows.Forms.ToolStripMenuItem();
            this.generacionMensualDeSueldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.sueldosPorPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldosAsignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldosDescuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsiAyuda});
            this.MnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnsPrincipal.Name = "MnsPrincipal";
            this.MnsPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MnsPrincipal.Size = new System.Drawing.Size(1082, 24);
            this.MnsPrincipal.TabIndex = 0;
            this.MnsPrincipal.Text = "menuStrip1";
            this.MnsPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MnsPrincipal_MouseMove);
            // 
            // tsiArchivo
            // 
            this.tsiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.tsiArchivo.Enabled = false;
            this.tsiArchivo.Name = "tsiArchivo";
            this.tsiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsiArchivo.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // tsiGestion
            // 
            this.tsiGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAsignaciones,
            this.tsiAsistencias,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.sueldosAsignacionesToolStripMenuItem,
            this.sueldosDescuentosToolStripMenuItem,
            this.sueldosPorPerfilToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.tsiGestion.Enabled = false;
            this.tsiGestion.Name = "tsiGestion";
            this.tsiGestion.Size = new System.Drawing.Size(59, 20);
            this.tsiGestion.Text = "Gestion";
            // 
            // tsiAsignaciones
            // 
            this.tsiAsignaciones.Name = "tsiAsignaciones";
            this.tsiAsignaciones.Size = new System.Drawing.Size(188, 22);
            this.tsiAsignaciones.Text = "Asignaciones";
            // 
            // tsiAsistencias
            // 
            this.tsiAsistencias.Name = "tsiAsistencias";
            this.tsiAsistencias.Size = new System.Drawing.Size(188, 22);
            this.tsiAsistencias.Text = "Asistencias";
            this.tsiAsistencias.Click += new System.EventHandler(this.TsiAsignaciones_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modificarToolStripMenuItem.Text = "Descuentos";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.eliminarToolStripMenuItem.Text = "Sueldos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // tsiTransaccion
            // 
            this.tsiTransaccion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generacionMensualDeSueldosToolStripMenuItem});
            this.tsiTransaccion.Enabled = false;
            this.tsiTransaccion.Name = "tsiTransaccion";
            this.tsiTransaccion.Size = new System.Drawing.Size(81, 20);
            this.tsiTransaccion.Text = "Transaccion";
            // 
            // generacionMensualDeSueldosToolStripMenuItem
            // 
            this.generacionMensualDeSueldosToolStripMenuItem.Name = "generacionMensualDeSueldosToolStripMenuItem";
            this.generacionMensualDeSueldosToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.generacionMensualDeSueldosToolStripMenuItem.Text = "Generacion mensual de sueldos";
            // 
            // tsiAyuda
            // 
            this.tsiAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAyudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.tsiAyuda.Name = "tsiAyuda";
            this.tsiAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsiAyuda.Text = "Ayuda";
            // 
            // mostrarAyudaToolStripMenuItem
            // 
            this.mostrarAyudaToolStripMenuItem.Name = "mostrarAyudaToolStripMenuItem";
            this.mostrarAyudaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mostrarAyudaToolStripMenuItem.Text = "Mostrar ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(471, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bug Tracking System";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Brown;
            this.btnSalir.Location = new System.Drawing.Point(1056, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Salmon;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.Brown;
            this.btnMinimizar.Location = new System.Drawing.Point(1031, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 24);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.Text = "―";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // sueldosPorPerfilToolStripMenuItem
            // 
            this.sueldosPorPerfilToolStripMenuItem.Name = "sueldosPorPerfilToolStripMenuItem";
            this.sueldosPorPerfilToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sueldosPorPerfilToolStripMenuItem.Text = "Sueldos por Perfil";
            // 
            // sueldosAsignacionesToolStripMenuItem
            // 
            this.sueldosAsignacionesToolStripMenuItem.Name = "sueldosAsignacionesToolStripMenuItem";
            this.sueldosAsignacionesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sueldosAsignacionesToolStripMenuItem.Text = "Sueldos Asignaciones";
            // 
            // sueldosDescuentosToolStripMenuItem
            // 
            this.sueldosDescuentosToolStripMenuItem.Name = "sueldosDescuentosToolStripMenuItem";
            this.sueldosDescuentosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sueldosDescuentosToolStripMenuItem.Text = "Sueldos Descuentos";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.layered_peaks_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 484);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.MnsPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnsPrincipal;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracking System";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.MdiChildActivate += new System.EventHandler(this.FrmMenuPrincipal_MdiChildActivate);
            this.Shown += new System.EventHandler(this.FrmMenuPrincipal_Shown);
            this.MnsPrincipal.ResumeLayout(false);
            this.MnsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem tsiArchivo;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiGestion;
        private System.Windows.Forms.ToolStripMenuItem tsiAsignaciones;
        private System.Windows.Forms.ToolStripMenuItem tsiAsistencias;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiTransaccion;
        private System.Windows.Forms.ToolStripMenuItem tsiAyuda;
        private System.Windows.Forms.ToolStripMenuItem mostrarAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generacionMensualDeSueldosToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        public System.Windows.Forms.MenuStrip MnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sueldosPorPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldosAsignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldosDescuentosToolStripMenuItem;
    }
}