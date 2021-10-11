
namespace BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones
{
    partial class FrmAsignaciones
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
            this.DgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.ChkBaja = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsignaciones)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpInformacion.Controls.Add(this.lblTotal);
            this.grpInformacion.Location = new System.Drawing.Point(238, 12);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(260, 105);
            this.grpInformacion.TabIndex = 5;
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
            // DgvAsignaciones
            // 
            this.DgvAsignaciones.AllowUserToAddRows = false;
            this.DgvAsignaciones.AllowUserToDeleteRows = false;
            this.DgvAsignaciones.AllowUserToOrderColumns = true;
            this.DgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsignaciones.Location = new System.Drawing.Point(12, 123);
            this.DgvAsignaciones.MultiSelect = false;
            this.DgvAsignaciones.Name = "DgvAsignaciones";
            this.DgvAsignaciones.ReadOnly = true;
            this.DgvAsignaciones.Size = new System.Drawing.Size(486, 315);
            this.DgvAsignaciones.TabIndex = 6;
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpAcciones.Controls.Add(this.ChkBaja);
            this.grpAcciones.Controls.Add(this.tableLayoutPanel1);
            this.grpAcciones.Location = new System.Drawing.Point(12, 12);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(220, 105);
            this.grpAcciones.TabIndex = 4;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // ChkBaja
            // 
            this.ChkBaja.AutoSize = true;
            this.ChkBaja.Location = new System.Drawing.Point(9, 86);
            this.ChkBaja.Name = "ChkBaja";
            this.ChkBaja.Size = new System.Drawing.Size(124, 17);
            this.ChkBaja.TabIndex = 9;
            this.ChkBaja.Text = "Incluir dados de baja";
            this.ChkBaja.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.BtnNuevo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEditar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnEliminar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnConsultar, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 52);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnNuevo.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnAgregar;
            this.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnNuevo.Location = new System.Drawing.Point(3, 3);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(44, 44);
            this.BtnNuevo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.BtnNuevo, "Agregar un registro nuevo");
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnEditar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnEditar;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEditar.Location = new System.Drawing.Point(103, 3);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(44, 44);
            this.BtnEditar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.BtnEditar, "Editar registro seleccionado");
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnEliminar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnEliminar;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Location = new System.Drawing.Point(53, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(44, 44);
            this.BtnEliminar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.BtnEliminar, "Eliminar registro seleccionado");
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnConsultar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnConsultar;
            this.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConsultar.Location = new System.Drawing.Point(153, 3);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(44, 44);
            this.BtnConsultar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnConsultar, "Realizar consulta");
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // FrmAsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.grpInformacion);
            this.Controls.Add(this.DgvAsignaciones);
            this.Controls.Add(this.grpAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignaciones";
            this.Load += new System.EventHandler(this.FrmAsignaciones_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsignaciones)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.grpAcciones.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DgvAsignaciones;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox ChkBaja;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}