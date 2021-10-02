
namespace BugTrackingSystem.CapaPresentacion
{
    partial class FrmAsistencias
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.ChkBaja = new System.Windows.Forms.CheckBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnInformacion = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.grpInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpFiltros.Controls.Add(this.ChkBaja);
            this.grpFiltros.Controls.Add(this.cboEstado);
            this.grpFiltros.Controls.Add(this.label4);
            this.grpFiltros.Controls.Add(this.cboUsuario);
            this.grpFiltros.Controls.Add(this.label3);
            this.grpFiltros.Controls.Add(this.btnConsultar);
            this.grpFiltros.Controls.Add(this.dateFechaHasta);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.dateFechaDesde);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Location = new System.Drawing.Point(12, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(479, 124);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // ChkBaja
            // 
            this.ChkBaja.AutoSize = true;
            this.ChkBaja.Location = new System.Drawing.Point(264, 98);
            this.ChkBaja.Name = "ChkBaja";
            this.ChkBaja.Size = new System.Drawing.Size(124, 17);
            this.ChkBaja.TabIndex = 9;
            this.ChkBaja.Text = "Incluir dados de baja";
            this.ChkBaja.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(310, 54);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(163, 21);
            this.cboEstado.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado:";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(86, 54);
            this.cboUsuario.MaxLength = 50;
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(141, 21);
            this.cboUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnConsultar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Search;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Location = new System.Drawing.Point(429, 80);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(44, 44);
            this.btnConsultar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnConsultar, "Realizar consulta");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.Checked = false;
            this.dateFechaHasta.CustomFormat = "";
            this.dateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaHasta.Location = new System.Drawing.Point(310, 25);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.ShowCheckBox = true;
            this.dateFechaHasta.Size = new System.Drawing.Size(163, 20);
            this.dateFechaHasta.TabIndex = 3;
            this.dateFechaHasta.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dateFechaDesde
            // 
            this.dateFechaDesde.Checked = false;
            this.dateFechaDesde.CustomFormat = "";
            this.dateFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaDesde.Location = new System.Drawing.Point(86, 25);
            this.dateFechaDesde.Name = "dateFechaDesde";
            this.dateFechaDesde.ShowCheckBox = true;
            this.dateFechaDesde.Size = new System.Drawing.Size(141, 20);
            this.dateFechaDesde.TabIndex = 1;
            this.dateFechaDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpAcciones.Controls.Add(this.tableLayoutPanel1);
            this.grpAcciones.Location = new System.Drawing.Point(497, 12);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(220, 124);
            this.grpAcciones.TabIndex = 1;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInformacion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 52);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNuevo.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 44);
            this.btnNuevo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnNuevo, "Crear nuevo registro");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.editaar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(103, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 44);
            this.btnEditar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar registro seleccionado");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Remove_Red;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(53, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(44, 44);
            this.btnEliminar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar registro seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToAddRows = false;
            this.dgvAsistencias.AllowUserToDeleteRows = false;
            this.dgvAsistencias.AllowUserToOrderColumns = true;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(12, 142);
            this.dgvAsistencias.MultiSelect = false;
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.ReadOnly = true;
            this.dgvAsistencias.Size = new System.Drawing.Size(971, 296);
            this.dgvAsistencias.TabIndex = 2;
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpInformacion.Controls.Add(this.lblTotal);
            this.grpInformacion.Location = new System.Drawing.Point(723, 12);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(260, 124);
            this.grpInformacion.TabIndex = 2;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Registros encontrados:";
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInformacion.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Info;
            this.btnInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnInformacion.Location = new System.Drawing.Point(153, 3);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(45, 44);
            this.btnInformacion.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnInformacion, "Ver detalles del registro seleccionado");
            this.btnInformacion.UseVisualStyleBackColor = false;
            // 
            // FrmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.layered_peaks_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.dgvAsistencias);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpFiltros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsistencias";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmAsignaciones_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.grpAcciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.CheckBox ChkBaja;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnInformacion;
    }
}