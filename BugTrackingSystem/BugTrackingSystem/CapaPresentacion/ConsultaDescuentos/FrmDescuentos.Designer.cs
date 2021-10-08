
namespace BugTrackingSystem.CapaPresentacion.ConsultaDescuentos
{
    partial class FrmDescuentos
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
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DgvDescuentos = new System.Windows.Forms.DataGridView();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnInformacion = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.ChkBaja = new System.Windows.Forms.CheckBox();
            this.CboDescuento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDescuentos)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.SkyBlue;
            this.grpInformacion.Controls.Add(this.lblTotal);
            this.grpInformacion.Location = new System.Drawing.Point(964, 15);
            this.grpInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInformacion.Size = new System.Drawing.Size(347, 153);
            this.grpInformacion.TabIndex = 9;
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
            // DgvDescuentos
            // 
            this.DgvDescuentos.AllowUserToAddRows = false;
            this.DgvDescuentos.AllowUserToDeleteRows = false;
            this.DgvDescuentos.AllowUserToOrderColumns = true;
            this.DgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDescuentos.Location = new System.Drawing.Point(16, 175);
            this.DgvDescuentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvDescuentos.MultiSelect = false;
            this.DgvDescuentos.Name = "DgvDescuentos";
            this.DgvDescuentos.ReadOnly = true;
            this.DgvDescuentos.RowHeadersWidth = 51;
            this.DgvDescuentos.Size = new System.Drawing.Size(1295, 364);
            this.DgvDescuentos.TabIndex = 10;
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.SkyBlue;
            this.grpAcciones.Controls.Add(this.tableLayoutPanel1);
            this.grpAcciones.Location = new System.Drawing.Point(663, 15);
            this.grpAcciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAcciones.Size = new System.Drawing.Size(293, 153);
            this.grpAcciones.TabIndex = 8;
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
            this.tableLayoutPanel1.Controls.Add(this.BtnNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnInformacion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 49);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 64);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnNuevo.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Add;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Location = new System.Drawing.Point(4, 4);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(59, 54);
            this.BtnNuevo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.BtnNuevo, "Agregar un registro");
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnInformacion
            // 
            this.BtnInformacion.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnInformacion.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Info;
            this.BtnInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnInformacion.FlatAppearance.BorderSize = 0;
            this.BtnInformacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInformacion.ForeColor = System.Drawing.Color.Transparent;
            this.BtnInformacion.Location = new System.Drawing.Point(205, 4);
            this.BtnInformacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnInformacion.Name = "BtnInformacion";
            this.BtnInformacion.Size = new System.Drawing.Size(60, 54);
            this.BtnInformacion.TabIndex = 13;
            this.toolTip1.SetToolTip(this.BtnInformacion, "Ver detalles de registro seleccionado");
            this.BtnInformacion.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnEditar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.editaar;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditar.Location = new System.Drawing.Point(138, 4);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(59, 54);
            this.BtnEditar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.BtnEditar, "Editar registro seleccionado");
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnEliminar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Remove_Red;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Location = new System.Drawing.Point(71, 4);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(59, 54);
            this.BtnEliminar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.BtnEliminar, "Eliminar registro seleccionado");
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.SkyBlue;
            this.grpFiltros.Controls.Add(this.ChkBaja);
            this.grpFiltros.Controls.Add(this.CboDescuento);
            this.grpFiltros.Controls.Add(this.label4);
            this.grpFiltros.Controls.Add(this.CboUsuario);
            this.grpFiltros.Controls.Add(this.label3);
            this.grpFiltros.Controls.Add(this.BtnConsultar);
            this.grpFiltros.Controls.Add(this.DateFechaHasta);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.DateFechaDesde);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Location = new System.Drawing.Point(16, 15);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltros.Size = new System.Drawing.Size(639, 153);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // ChkBaja
            // 
            this.ChkBaja.AutoSize = true;
            this.ChkBaja.Location = new System.Drawing.Point(352, 121);
            this.ChkBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkBaja.Name = "ChkBaja";
            this.ChkBaja.Size = new System.Drawing.Size(161, 21);
            this.ChkBaja.TabIndex = 9;
            this.ChkBaja.Text = "Incluir dados de baja";
            this.ChkBaja.UseVisualStyleBackColor = true;
            // 
            // CboDescuento
            // 
            this.CboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDescuento.FormattingEnabled = true;
            this.CboDescuento.Location = new System.Drawing.Point(413, 66);
            this.CboDescuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboDescuento.Name = "CboDescuento";
            this.CboDescuento.Size = new System.Drawing.Size(216, 24);
            this.CboDescuento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descuento:";
            // 
            // CboUsuario
            // 
            this.CboUsuario.FormattingEnabled = true;
            this.CboUsuario.Location = new System.Drawing.Point(115, 66);
            this.CboUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboUsuario.MaxLength = 50;
            this.CboUsuario.Name = "CboUsuario";
            this.CboUsuario.Size = new System.Drawing.Size(187, 24);
            this.CboUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnConsultar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Knob_Search;
            this.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.Location = new System.Drawing.Point(572, 95);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(59, 54);
            this.BtnConsultar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnConsultar, "Realizar consulta");
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // DateFechaHasta
            // 
            this.DateFechaHasta.Checked = false;
            this.DateFechaHasta.CustomFormat = "";
            this.DateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaHasta.Location = new System.Drawing.Point(413, 31);
            this.DateFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateFechaHasta.Name = "DateFechaHasta";
            this.DateFechaHasta.ShowCheckBox = true;
            this.DateFechaHasta.Size = new System.Drawing.Size(216, 22);
            this.DateFechaHasta.TabIndex = 3;
            this.DateFechaHasta.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Hasta:";
            // 
            // DateFechaDesde
            // 
            this.DateFechaDesde.Checked = false;
            this.DateFechaDesde.CustomFormat = "";
            this.DateFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaDesde.Location = new System.Drawing.Point(115, 31);
            this.DateFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateFechaDesde.Name = "DateFechaDesde";
            this.DateFechaDesde.ShowCheckBox = true;
            this.DateFechaDesde.Size = new System.Drawing.Size(187, 22);
            this.DateFechaDesde.TabIndex = 1;
            this.DateFechaDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            // 
            // FrmDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1327, 554);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.DgvDescuentos);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDescuentos";
            this.Load += new System.EventHandler(this.FrmDescuentos_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDescuentos)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DgvDescuentos;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnInformacion;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.CheckBox ChkBaja;
        private System.Windows.Forms.ComboBox CboDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DateTimePicker DateFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}