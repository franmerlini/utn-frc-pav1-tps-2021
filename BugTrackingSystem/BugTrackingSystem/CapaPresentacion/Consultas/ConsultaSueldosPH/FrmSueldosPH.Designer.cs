
namespace BugTrackingSystem.CapaPresentacion.Consultas.ConsultaSueldosPH
{
    partial class FrmSueldosPH
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
            this.DgvSueldosPH = new System.Windows.Forms.DataGridView();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.CboPerfil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSueldosPH)).BeginInit();
            this.grpFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.Tan;
            this.grpInformacion.Controls.Add(this.lblTotal);
            this.grpInformacion.Location = new System.Drawing.Point(497, 12);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(220, 105);
            this.grpInformacion.TabIndex = 9;
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
            // DgvSueldosPH
            // 
            this.DgvSueldosPH.AllowUserToAddRows = false;
            this.DgvSueldosPH.AllowUserToDeleteRows = false;
            this.DgvSueldosPH.AllowUserToOrderColumns = true;
            this.DgvSueldosPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSueldosPH.Location = new System.Drawing.Point(12, 123);
            this.DgvSueldosPH.MultiSelect = false;
            this.DgvSueldosPH.Name = "DgvSueldosPH";
            this.DgvSueldosPH.ReadOnly = true;
            this.DgvSueldosPH.RowHeadersWidth = 51;
            this.DgvSueldosPH.Size = new System.Drawing.Size(705, 315);
            this.DgvSueldosPH.TabIndex = 6;
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.Tan;
            this.grpFiltros.Controls.Add(this.CboPerfil);
            this.grpFiltros.Controls.Add(this.label4);
            this.grpFiltros.Controls.Add(this.dateFechaHasta);
            this.grpFiltros.Controls.Add(this.label2);
            this.grpFiltros.Controls.Add(this.dateFechaDesde);
            this.grpFiltros.Controls.Add(this.label1);
            this.grpFiltros.Controls.Add(this.btnConsultar);
            this.grpFiltros.Location = new System.Drawing.Point(12, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(479, 105);
            this.grpFiltros.TabIndex = 7;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // CboPerfil
            // 
            this.CboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPerfil.FormattingEnabled = true;
            this.CboPerfil.Location = new System.Drawing.Point(87, 56);
            this.CboPerfil.Name = "CboPerfil";
            this.CboPerfil.Size = new System.Drawing.Size(141, 21);
            this.CboPerfil.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(48, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Perfil:";
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.Checked = false;
            this.dateFechaHasta.CustomFormat = "";
            this.dateFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaHasta.Location = new System.Drawing.Point(310, 22);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.ShowCheckBox = true;
            this.dateFechaHasta.Size = new System.Drawing.Size(163, 20);
            this.dateFechaHasta.TabIndex = 13;
            this.dateFechaHasta.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(238, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Hasta:";
            // 
            // dateFechaDesde
            // 
            this.dateFechaDesde.Checked = false;
            this.dateFechaDesde.CustomFormat = "";
            this.dateFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaDesde.Location = new System.Drawing.Point(87, 22);
            this.dateFechaDesde.Name = "dateFechaDesde";
            this.dateFechaDesde.ShowCheckBox = true;
            this.dateFechaDesde.Size = new System.Drawing.Size(141, 20);
            this.dateFechaDesde.TabIndex = 11;
            this.dateFechaDesde.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Desde:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Tan;
            this.btnConsultar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnConsultar;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultar.Location = new System.Drawing.Point(429, 59);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(44, 44);
            this.btnConsultar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnConsultar, "Realizar consulta");
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // FrmSueldosPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BugTrackingSystem.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.DgvSueldosPH);
            this.Controls.Add(this.grpFiltros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSueldosPH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSueldosPH";
            this.Load += new System.EventHandler(this.FrmSueldosPH_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSueldosPH)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DgvSueldosPH;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox CboPerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}