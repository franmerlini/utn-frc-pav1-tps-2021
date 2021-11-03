
namespace BugTrackingSystem.CapaPresentacion.Reportes.ListaSueldo
{
    partial class FrmListaSueldo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.RVReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSueldo = new BugTrackingSystem.CapaAccesoDatos.DataSet.DsSueldo();
            this.dsSueldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taSueldoNetoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taSueldoNetoTableAdapter = new BugTrackingSystem.CapaAccesoDatos.DataSet.DsSueldoTableAdapters.TaSueldoNetoTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taSueldoNetoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grpFiltros, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RVReporte, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpFiltros.Controls.Add(this.btnGenerar);
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
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGenerar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnConsultar;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenerar.Location = new System.Drawing.Point(483, 15);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(32, 32);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            // RVReporte
            // 
            this.RVReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RVReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DsReporte";
            reportDataSource2.Value = this.taSueldoNetoBindingSource;
            this.RVReporte.LocalReport.DataSources.Add(reportDataSource2);
            this.RVReporte.LocalReport.ReportEmbeddedResource = "BugTrackingSystem.CapaPresentacion.Reportes.ListaSueldo.ListaSueldo.rdlc";
            this.RVReporte.Location = new System.Drawing.Point(3, 63);
            this.RVReporte.Name = "RVReporte";
            this.RVReporte.ServerReport.BearerToken = null;
            this.RVReporte.Size = new System.Drawing.Size(794, 384);
            this.RVReporte.TabIndex = 0;
            // 
            // dsSueldo
            // 
            this.dsSueldo.DataSetName = "DsSueldo";
            this.dsSueldo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsSueldoBindingSource
            // 
            this.dsSueldoBindingSource.DataSource = this.dsSueldo;
            this.dsSueldoBindingSource.Position = 0;
            // 
            // taSueldoNetoBindingSource
            // 
            this.taSueldoNetoBindingSource.DataMember = "TaSueldoNeto";
            this.taSueldoNetoBindingSource.DataSource = this.dsSueldoBindingSource;
            // 
            // taSueldoNetoTableAdapter
            // 
            this.taSueldoNetoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListaSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaSueldo";
            this.Text = "FrmListaSueldo";
            this.Load += new System.EventHandler(this.FrmListaSueldo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSueldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taSueldoNetoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer RVReporte;
        private System.Windows.Forms.BindingSource dsSueldoBindingSource;
        private CapaAccesoDatos.DataSet.DsSueldo dsSueldo;
        private System.Windows.Forms.BindingSource taSueldoNetoBindingSource;
        private CapaAccesoDatos.DataSet.DsSueldoTableAdapters.TaSueldoNetoTableAdapter taSueldoNetoTableAdapter;
    }
}