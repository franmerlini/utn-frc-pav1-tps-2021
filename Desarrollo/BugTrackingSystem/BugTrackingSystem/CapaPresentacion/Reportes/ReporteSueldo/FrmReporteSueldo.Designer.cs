
namespace BugTrackingSystem.CapaPresentacion.Reportes.ReporteSueldo
{
    partial class FrmReporteSueldo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.taSueldoHistoricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSueldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSueldo = new BugTrackingSystem.CapaAccesoDatos.DataSet.DsSueldo();
            this.taSueldoHistoricoTableAdapter = new BugTrackingSystem.CapaAccesoDatos.DataSet.DsSueldoTableAdapters.TaSueldoHistoricoTableAdapter();
            this.AsignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescuentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionesTableAdapter = new BugTrackingSystem.CapaAccesoDatos.DataSet.DsSueldoTableAdapters.AsignacionesTableAdapter();
            this.taSueldoHistoricoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.descuentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.descuentosTableAdapter = new BugTrackingSystem.CapaAccesoDatos.DataSet.DsSueldoTableAdapters.DescuentosTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taSueldoHistoricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taSueldoHistoricoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpFiltros, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RvReporte, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpFiltros.Controls.Add(this.BtnGenerar);
            this.grpFiltros.Controls.Add(this.dateFechaHasta);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.dateFechaDesde);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpFiltros.Location = new System.Drawing.Point(3, 3);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(794, 54);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnGenerar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnConsultar;
            this.BtnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGenerar.FlatAppearance.BorderSize = 0;
            this.BtnGenerar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGenerar.Location = new System.Drawing.Point(483, 15);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(32, 32);
            this.BtnGenerar.TabIndex = 5;
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.Checked = false;
            this.dateFechaHasta.CustomFormat = "";
            this.dateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaHasta.Location = new System.Drawing.Point(310, 25);
            this.dateFechaHasta.Name = "dateFechaHasta";
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
            // RvReporte
            // 
            this.RvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DsSueldoHistorico";
            reportDataSource4.Value = this.taSueldoHistoricoBindingSource;
            reportDataSource5.Name = "DsAsignacion";
            reportDataSource5.Value = this.AsignacionesBindingSource;
            reportDataSource6.Name = "DsDescuento";
            reportDataSource6.Value = this.DescuentosBindingSource;
            this.RvReporte.LocalReport.DataSources.Add(reportDataSource4);
            this.RvReporte.LocalReport.DataSources.Add(reportDataSource5);
            this.RvReporte.LocalReport.DataSources.Add(reportDataSource6);
            this.RvReporte.LocalReport.ReportEmbeddedResource = "BugTrackingSystem.CapaPresentacion.Reportes.ReporteSueldo.ReportesSueldo.rdlc";
            this.RvReporte.Location = new System.Drawing.Point(3, 63);
            this.RvReporte.Name = "RvReporte";
            this.RvReporte.ServerReport.BearerToken = null;
            this.RvReporte.Size = new System.Drawing.Size(794, 384);
            this.RvReporte.TabIndex = 2;
            // 
            // taSueldoHistoricoBindingSource
            // 
            this.taSueldoHistoricoBindingSource.DataMember = "TaSueldoHistorico";
            this.taSueldoHistoricoBindingSource.DataSource = this.dsSueldoBindingSource;
            // 
            // dsSueldoBindingSource
            // 
            this.dsSueldoBindingSource.DataSource = this.dsSueldo;
            this.dsSueldoBindingSource.Position = 0;
            // 
            // dsSueldo
            // 
            this.dsSueldo.DataSetName = "DsSueldo";
            this.dsSueldo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taSueldoHistoricoTableAdapter
            // 
            this.taSueldoHistoricoTableAdapter.ClearBeforeFill = true;
            // 
            // AsignacionesBindingSource
            // 
            this.AsignacionesBindingSource.DataMember = "Asignaciones";
            this.AsignacionesBindingSource.DataSource = this.dsSueldo;
            // 
            // DescuentosBindingSource
            // 
            this.DescuentosBindingSource.DataMember = "Descuentos";
            this.DescuentosBindingSource.DataSource = this.dsSueldo;
            // 
            // asignacionesTableAdapter
            // 
            this.asignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // taSueldoHistoricoBindingSource1
            // 
            this.taSueldoHistoricoBindingSource1.DataMember = "TaSueldoHistorico";
            this.taSueldoHistoricoBindingSource1.DataSource = this.dsSueldoBindingSource;
            // 
            // asignacionesBindingSource1
            // 
            this.asignacionesBindingSource1.DataMember = "Asignaciones";
            this.asignacionesBindingSource1.DataSource = this.dsSueldoBindingSource;
            // 
            // descuentosBindingSource1
            // 
            this.descuentosBindingSource1.DataMember = "Descuentos";
            this.descuentosBindingSource1.DataSource = this.dsSueldoBindingSource;
            // 
            // descuentosTableAdapter
            // 
            this.descuentosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteSueldo";
            this.Text = "FrmReporteSueldo";
            this.Load += new System.EventHandler(this.FrmReporteSueldo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taSueldoHistoricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescuentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taSueldoHistoricoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer RvReporte;
        private CapaAccesoDatos.DataSet.DsSueldo dsSueldo;
        private System.Windows.Forms.BindingSource dsSueldoBindingSource;
        private System.Windows.Forms.BindingSource taSueldoHistoricoBindingSource;
        private CapaAccesoDatos.DataSet.DsSueldoTableAdapters.TaSueldoHistoricoTableAdapter taSueldoHistoricoTableAdapter;
        private System.Windows.Forms.BindingSource AsignacionesBindingSource;
        private System.Windows.Forms.BindingSource DescuentosBindingSource;
        private CapaAccesoDatos.DataSet.DsSueldoTableAdapters.AsignacionesTableAdapter asignacionesTableAdapter;
        private System.Windows.Forms.BindingSource taSueldoHistoricoBindingSource1;
        private System.Windows.Forms.BindingSource asignacionesBindingSource1;
        private System.Windows.Forms.BindingSource descuentosBindingSource1;
        private CapaAccesoDatos.DataSet.DsSueldoTableAdapters.DescuentosTableAdapter descuentosTableAdapter;
    }
}