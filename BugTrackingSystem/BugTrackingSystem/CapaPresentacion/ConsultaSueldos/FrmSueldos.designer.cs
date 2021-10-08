
namespace BugTrackingSystem.CapaPresentacion.ConsultaSueldos
{
    partial class FrmSueldos
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
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvSueldos = new System.Windows.Forms.DataGridView();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkBaja = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldos)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpInformacion.Controls.Add(this.lblTotal);
            this.grpInformacion.Location = new System.Drawing.Point(964, 15);
            this.grpInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Padding = new System.Windows.Forms.Padding(4);
            this.grpInformacion.Size = new System.Drawing.Size(347, 153);
            this.grpInformacion.TabIndex = 5;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(8, 27);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(155, 17);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Registros encontrados:";
            // 
            // dgvSueldos
            // 
            this.dgvSueldos.AllowUserToAddRows = false;
            this.dgvSueldos.AllowUserToDeleteRows = false;
            this.dgvSueldos.AllowUserToOrderColumns = true;
            this.dgvSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSueldos.Location = new System.Drawing.Point(16, 175);
            this.dgvSueldos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSueldos.MultiSelect = false;
            this.dgvSueldos.Name = "dgvSueldos";
            this.dgvSueldos.ReadOnly = true;
            this.dgvSueldos.RowHeadersWidth = 51;
            this.dgvSueldos.Size = new System.Drawing.Size(1295, 364);
            this.dgvSueldos.TabIndex = 3;
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpAcciones.Controls.Add(this.tableLayoutPanel1);
            this.grpAcciones.Location = new System.Drawing.Point(663, 15);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(4);
            this.grpAcciones.Size = new System.Drawing.Size(293, 153);
            this.grpAcciones.TabIndex = 4;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Controls.Add(this.btnNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnInformacion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 64);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Add;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Location = new System.Drawing.Point(4, 4);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(59, 54);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInformacion.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Info;
            this.btnInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInformacion.FlatAppearance.BorderSize = 0;
            this.btnInformacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.ForeColor = System.Drawing.Color.Transparent;
            this.btnInformacion.Location = new System.Drawing.Point(205, 4);
            this.btnInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(60, 54);
            this.btnInformacion.TabIndex = 13;
            this.btnInformacion.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.editaar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(138, 4);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(59, 54);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEliminar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Remove_Red;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(71, 4);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 54);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpFiltros.Controls.Add(this.cboUsuario);
            this.grpFiltros.Controls.Add(this.label3);
            this.grpFiltros.Controls.Add(this.dateFechaHasta);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.dateFechaDesde);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.ChkBaja);
            this.grpFiltros.Controls.Add(this.btnConsultar);
            this.grpFiltros.Location = new System.Drawing.Point(16, 15);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(639, 153);
            this.grpFiltros.TabIndex = 3;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(116, 62);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cboUsuario.MaxLength = 50;
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(187, 24);
            this.cboUsuario.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario:";
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.Checked = false;
            this.dateFechaHasta.CustomFormat = "";
            this.dateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaHasta.Location = new System.Drawing.Point(414, 27);
            this.dateFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.ShowCheckBox = true;
            this.dateFechaHasta.Size = new System.Drawing.Size(216, 22);
            this.dateFechaHasta.TabIndex = 13;
            this.dateFechaHasta.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dateFechaDesde
            // 
            this.dateFechaDesde.Checked = false;
            this.dateFechaDesde.CustomFormat = "";
            this.dateFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaDesde.Location = new System.Drawing.Point(116, 27);
            this.dateFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateFechaDesde.Name = "dateFechaDesde";
            this.dateFechaDesde.ShowCheckBox = true;
            this.dateFechaDesde.Size = new System.Drawing.Size(187, 22);
            this.dateFechaDesde.TabIndex = 11;
            this.dateFechaDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Desde:";
            // 
            // ChkBaja
            // 
            this.ChkBaja.AutoSize = true;
            this.ChkBaja.Location = new System.Drawing.Point(352, 121);
            this.ChkBaja.Margin = new System.Windows.Forms.Padding(4);
            this.ChkBaja.Name = "ChkBaja";
            this.ChkBaja.Size = new System.Drawing.Size(161, 21);
            this.ChkBaja.TabIndex = 9;
            this.ChkBaja.Text = "Incluir dados de baja";
            this.ChkBaja.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConsultar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Search;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Location = new System.Drawing.Point(572, 98);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(59, 54);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmSueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.layered_peaks_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 554);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.dgvSueldos);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpFiltros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSueldos";
            this.Text = "FrmSueldos";
            this.Load += new System.EventHandler(this.FrmSueldos_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldos)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvSueldos;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.CheckBox ChkBaja;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label1;
    }
}