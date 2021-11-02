
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
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlMenuLateral = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.PnlReportes = new System.Windows.Forms.Panel();
            this.BtnReporte1 = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.PnlTransacciones = new System.Windows.Forms.Panel();
            this.BtnTransaccionSueldo = new System.Windows.Forms.Button();
            this.BtnTransacciones = new System.Windows.Forms.Button();
            this.PnlGestion = new System.Windows.Forms.Panel();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnSueldosPH = new System.Windows.Forms.Button();
            this.BtnSueldos = new System.Windows.Forms.Button();
            this.Descuentos = new System.Windows.Forms.Button();
            this.BtnAsistencias = new System.Windows.Forms.Button();
            this.BtnAsignaciones = new System.Windows.Forms.Button();
            this.BtnGestion = new System.Windows.Forms.Button();
            this.PnlCuenta = new System.Windows.Forms.Panel();
            this.BtnPerfilNombre = new System.Windows.Forms.Button();
            this.BtnNombreUsuario = new System.Windows.Forms.Button();
            this.BtnCuenta = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlMenuLateral.SuspendLayout();
            this.PnlReportes.SuspendLayout();
            this.PnlTransacciones.SuspendLayout();
            this.PnlGestion.SuspendLayout();
            this.PnlCuenta.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.AutoSize = true;
            this.PnlPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlPrincipal.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Background;
            this.PnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(185, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1099, 541);
            this.PnlPrincipal.TabIndex = 13;
            // 
            // PnlMenuLateral
            // 
            this.PnlMenuLateral.AutoScroll = true;
            this.PnlMenuLateral.Controls.Add(this.BtnCerrarSesion);
            this.PnlMenuLateral.Controls.Add(this.BtnAyuda);
            this.PnlMenuLateral.Controls.Add(this.PnlReportes);
            this.PnlMenuLateral.Controls.Add(this.BtnSalir);
            this.PnlMenuLateral.Controls.Add(this.BtnReportes);
            this.PnlMenuLateral.Controls.Add(this.PnlTransacciones);
            this.PnlMenuLateral.Controls.Add(this.BtnTransacciones);
            this.PnlMenuLateral.Controls.Add(this.PnlGestion);
            this.PnlMenuLateral.Controls.Add(this.BtnGestion);
            this.PnlMenuLateral.Controls.Add(this.PnlCuenta);
            this.PnlMenuLateral.Controls.Add(this.BtnCuenta);
            this.PnlMenuLateral.Controls.Add(this.PnlLogo);
            this.PnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuLateral.Name = "PnlMenuLateral";
            this.PnlMenuLateral.Size = new System.Drawing.Size(185, 541);
            this.PnlMenuLateral.TabIndex = 14;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.BtnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 550);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(168, 31);
            this.BtnCerrarSesion.TabIndex = 3;
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAyuda.FlatAppearance.BorderSize = 0;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.ForeColor = System.Drawing.Color.White;
            this.BtnAyuda.Location = new System.Drawing.Point(0, 581);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(168, 32);
            this.BtnAyuda.TabIndex = 11;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyuda.UseVisualStyleBackColor = true;
            // 
            // PnlReportes
            // 
            this.PnlReportes.AutoSize = true;
            this.PnlReportes.Controls.Add(this.BtnReporte1);
            this.PnlReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlReportes.Location = new System.Drawing.Point(0, 519);
            this.PnlReportes.Name = "PnlReportes";
            this.PnlReportes.Size = new System.Drawing.Size(168, 31);
            this.PnlReportes.TabIndex = 13;
            this.PnlReportes.Visible = false;
            // 
            // BtnReporte1
            // 
            this.BtnReporte1.BackColor = System.Drawing.Color.Firebrick;
            this.BtnReporte1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReporte1.FlatAppearance.BorderSize = 0;
            this.BtnReporte1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnReporte1.Location = new System.Drawing.Point(0, 0);
            this.BtnReporte1.Name = "BtnReporte1";
            this.BtnReporte1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReporte1.Size = new System.Drawing.Size(168, 31);
            this.BtnReporte1.TabIndex = 1;
            this.BtnReporte1.Text = "Reporte 1";
            this.BtnReporte1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReporte1.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(0, 613);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(168, 32);
            this.BtnSalir.TabIndex = 12;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Location = new System.Drawing.Point(0, 487);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(168, 32);
            this.BtnReportes.TabIndex = 9;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // PnlTransacciones
            // 
            this.PnlTransacciones.Controls.Add(this.BtnTransaccionSueldo);
            this.PnlTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTransacciones.Location = new System.Drawing.Point(0, 441);
            this.PnlTransacciones.Name = "PnlTransacciones";
            this.PnlTransacciones.Size = new System.Drawing.Size(168, 46);
            this.PnlTransacciones.TabIndex = 8;
            this.PnlTransacciones.Visible = false;
            // 
            // BtnTransaccionSueldo
            // 
            this.BtnTransaccionSueldo.BackColor = System.Drawing.Color.Firebrick;
            this.BtnTransaccionSueldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransaccionSueldo.FlatAppearance.BorderSize = 0;
            this.BtnTransaccionSueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransaccionSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransaccionSueldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnTransaccionSueldo.Location = new System.Drawing.Point(0, 0);
            this.BtnTransaccionSueldo.Name = "BtnTransaccionSueldo";
            this.BtnTransaccionSueldo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnTransaccionSueldo.Size = new System.Drawing.Size(168, 46);
            this.BtnTransaccionSueldo.TabIndex = 1;
            this.BtnTransaccionSueldo.Text = "Generación Mensual de Sueldos";
            this.BtnTransaccionSueldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransaccionSueldo.UseVisualStyleBackColor = false;
            this.BtnTransaccionSueldo.Click += new System.EventHandler(this.BtnTransaccionSueldo_Click);
            // 
            // BtnTransacciones
            // 
            this.BtnTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransacciones.FlatAppearance.BorderSize = 0;
            this.BtnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransacciones.ForeColor = System.Drawing.Color.White;
            this.BtnTransacciones.Location = new System.Drawing.Point(0, 409);
            this.BtnTransacciones.Name = "BtnTransacciones";
            this.BtnTransacciones.Size = new System.Drawing.Size(168, 32);
            this.BtnTransacciones.TabIndex = 7;
            this.BtnTransacciones.Text = "Transacciones";
            this.BtnTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransacciones.UseVisualStyleBackColor = true;
            this.BtnTransacciones.Click += new System.EventHandler(this.BtnTransacciones_Click);
            // 
            // PnlGestion
            // 
            this.PnlGestion.Controls.Add(this.BtnUsuarios);
            this.PnlGestion.Controls.Add(this.BtnSueldosPH);
            this.PnlGestion.Controls.Add(this.BtnSueldos);
            this.PnlGestion.Controls.Add(this.Descuentos);
            this.PnlGestion.Controls.Add(this.BtnAsistencias);
            this.PnlGestion.Controls.Add(this.BtnAsignaciones);
            this.PnlGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlGestion.Location = new System.Drawing.Point(0, 223);
            this.PnlGestion.Name = "PnlGestion";
            this.PnlGestion.Size = new System.Drawing.Size(168, 186);
            this.PnlGestion.TabIndex = 6;
            this.PnlGestion.Visible = false;
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.Firebrick;
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuarios.Enabled = false;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 155);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnUsuarios.Size = new System.Drawing.Size(168, 31);
            this.BtnUsuarios.TabIndex = 6;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnSueldosPH
            // 
            this.BtnSueldosPH.BackColor = System.Drawing.Color.Firebrick;
            this.BtnSueldosPH.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSueldosPH.FlatAppearance.BorderSize = 0;
            this.BtnSueldosPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSueldosPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSueldosPH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSueldosPH.Location = new System.Drawing.Point(0, 124);
            this.BtnSueldosPH.Name = "BtnSueldosPH";
            this.BtnSueldosPH.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSueldosPH.Size = new System.Drawing.Size(168, 31);
            this.BtnSueldosPH.TabIndex = 5;
            this.BtnSueldosPH.Text = "Sueldos Perfil Histórico";
            this.BtnSueldosPH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSueldosPH.UseVisualStyleBackColor = false;
            this.BtnSueldosPH.Click += new System.EventHandler(this.BtnSueldosPH_Click);
            // 
            // BtnSueldos
            // 
            this.BtnSueldos.BackColor = System.Drawing.Color.Firebrick;
            this.BtnSueldos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSueldos.FlatAppearance.BorderSize = 0;
            this.BtnSueldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSueldos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSueldos.Location = new System.Drawing.Point(0, 93);
            this.BtnSueldos.Name = "BtnSueldos";
            this.BtnSueldos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSueldos.Size = new System.Drawing.Size(168, 31);
            this.BtnSueldos.TabIndex = 4;
            this.BtnSueldos.Text = "Sueldos";
            this.BtnSueldos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSueldos.UseVisualStyleBackColor = false;
            this.BtnSueldos.Click += new System.EventHandler(this.BtnSueldos_Click);
            // 
            // Descuentos
            // 
            this.Descuentos.BackColor = System.Drawing.Color.Firebrick;
            this.Descuentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Descuentos.FlatAppearance.BorderSize = 0;
            this.Descuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Descuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descuentos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Descuentos.Location = new System.Drawing.Point(0, 62);
            this.Descuentos.Name = "Descuentos";
            this.Descuentos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Descuentos.Size = new System.Drawing.Size(168, 31);
            this.Descuentos.TabIndex = 3;
            this.Descuentos.Text = "Descuentos";
            this.Descuentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Descuentos.UseVisualStyleBackColor = false;
            this.Descuentos.Click += new System.EventHandler(this.Descuentos_Click);
            // 
            // BtnAsistencias
            // 
            this.BtnAsistencias.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAsistencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAsistencias.FlatAppearance.BorderSize = 0;
            this.BtnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsistencias.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAsistencias.Location = new System.Drawing.Point(0, 31);
            this.BtnAsistencias.Name = "BtnAsistencias";
            this.BtnAsistencias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAsistencias.Size = new System.Drawing.Size(168, 31);
            this.BtnAsistencias.TabIndex = 2;
            this.BtnAsistencias.Text = "Asistencias";
            this.BtnAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsistencias.UseVisualStyleBackColor = false;
            this.BtnAsistencias.Click += new System.EventHandler(this.BtnAsistencias_Click);
            // 
            // BtnAsignaciones
            // 
            this.BtnAsignaciones.BackColor = System.Drawing.Color.Firebrick;
            this.BtnAsignaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAsignaciones.FlatAppearance.BorderSize = 0;
            this.BtnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAsignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsignaciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAsignaciones.Location = new System.Drawing.Point(0, 0);
            this.BtnAsignaciones.Name = "BtnAsignaciones";
            this.BtnAsignaciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAsignaciones.Size = new System.Drawing.Size(168, 31);
            this.BtnAsignaciones.TabIndex = 1;
            this.BtnAsignaciones.Text = "Asignaciones";
            this.BtnAsignaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAsignaciones.UseVisualStyleBackColor = false;
            this.BtnAsignaciones.Click += new System.EventHandler(this.BtnAsignaciones_Click);
            // 
            // BtnGestion
            // 
            this.BtnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGestion.FlatAppearance.BorderSize = 0;
            this.BtnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestion.ForeColor = System.Drawing.Color.White;
            this.BtnGestion.Location = new System.Drawing.Point(0, 191);
            this.BtnGestion.Name = "BtnGestion";
            this.BtnGestion.Size = new System.Drawing.Size(168, 32);
            this.BtnGestion.TabIndex = 5;
            this.BtnGestion.Text = "Gestión";
            this.BtnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestion.UseVisualStyleBackColor = true;
            this.BtnGestion.Click += new System.EventHandler(this.BtnGestion_Click);
            // 
            // PnlCuenta
            // 
            this.PnlCuenta.AutoSize = true;
            this.PnlCuenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlCuenta.Controls.Add(this.BtnPerfilNombre);
            this.PnlCuenta.Controls.Add(this.BtnNombreUsuario);
            this.PnlCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCuenta.Location = new System.Drawing.Point(0, 134);
            this.PnlCuenta.Name = "PnlCuenta";
            this.PnlCuenta.Size = new System.Drawing.Size(168, 57);
            this.PnlCuenta.TabIndex = 4;
            this.PnlCuenta.Visible = false;
            // 
            // BtnPerfilNombre
            // 
            this.BtnPerfilNombre.AutoEllipsis = true;
            this.BtnPerfilNombre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPerfilNombre.BackColor = System.Drawing.Color.Firebrick;
            this.BtnPerfilNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPerfilNombre.Enabled = false;
            this.BtnPerfilNombre.FlatAppearance.BorderSize = 0;
            this.BtnPerfilNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPerfilNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPerfilNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPerfilNombre.Location = new System.Drawing.Point(0, 31);
            this.BtnPerfilNombre.Name = "BtnPerfilNombre";
            this.BtnPerfilNombre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnPerfilNombre.Size = new System.Drawing.Size(168, 26);
            this.BtnPerfilNombre.TabIndex = 2;
            this.BtnPerfilNombre.Text = "Perfil: -";
            this.BtnPerfilNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPerfilNombre.UseVisualStyleBackColor = false;
            // 
            // BtnNombreUsuario
            // 
            this.BtnNombreUsuario.AutoEllipsis = true;
            this.BtnNombreUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNombreUsuario.BackColor = System.Drawing.Color.Firebrick;
            this.BtnNombreUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNombreUsuario.Enabled = false;
            this.BtnNombreUsuario.FlatAppearance.BorderSize = 0;
            this.BtnNombreUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNombreUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnNombreUsuario.Location = new System.Drawing.Point(0, 0);
            this.BtnNombreUsuario.Name = "BtnNombreUsuario";
            this.BtnNombreUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnNombreUsuario.Size = new System.Drawing.Size(168, 31);
            this.BtnNombreUsuario.TabIndex = 1;
            this.BtnNombreUsuario.Text = "Usuario: -";
            this.BtnNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNombreUsuario.UseVisualStyleBackColor = false;
            // 
            // BtnCuenta
            // 
            this.BtnCuenta.AutoSize = true;
            this.BtnCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCuenta.FlatAppearance.BorderSize = 0;
            this.BtnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuenta.ForeColor = System.Drawing.Color.White;
            this.BtnCuenta.Location = new System.Drawing.Point(0, 102);
            this.BtnCuenta.Name = "BtnCuenta";
            this.BtnCuenta.Size = new System.Drawing.Size(168, 32);
            this.BtnCuenta.TabIndex = 3;
            this.BtnCuenta.Text = "Cuenta";
            this.BtnCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCuenta.UseVisualStyleBackColor = true;
            this.BtnCuenta.Click += new System.EventHandler(this.BtnCuenta_Click);
            // 
            // PnlLogo
            // 
            this.PnlLogo.Controls.Add(this.PicLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(168, 102);
            this.PnlLogo.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Bug;
            this.PicLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicLogo.Image = global::BugTrackingSystem.Properties.Resources.Bug;
            this.PicLogo.Location = new System.Drawing.Point(39, 8);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(88, 88);
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 541);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.PnlMenuLateral);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracking System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMenuPrincipal_Shown);
            this.PnlMenuLateral.ResumeLayout(false);
            this.PnlMenuLateral.PerformLayout();
            this.PnlReportes.ResumeLayout(false);
            this.PnlTransacciones.ResumeLayout(false);
            this.PnlGestion.ResumeLayout(false);
            this.PnlCuenta.ResumeLayout(false);
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlMenuLateral;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnPerfilNombre;
        private System.Windows.Forms.Button BtnNombreUsuario;
        private System.Windows.Forms.Panel PnlCuenta;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnCuenta;
        private System.Windows.Forms.Panel PnlGestion;
        private System.Windows.Forms.Button Descuentos;
        private System.Windows.Forms.Button BtnAsistencias;
        private System.Windows.Forms.Button BtnGestion;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Panel PnlTransacciones;
        private System.Windows.Forms.Button BtnTransaccionSueldo;
        private System.Windows.Forms.Button BtnTransacciones;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnSueldosPH;
        private System.Windows.Forms.Button BtnSueldos;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PnlReportes;
        private System.Windows.Forms.Button BtnReporte1;
        private System.Windows.Forms.Button BtnAsignaciones;
    }
}