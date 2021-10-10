
namespace BugTrackingSystem.CapaPresentacion.ConsultaAsignaciones
{
    partial class FrmAsignacionesABM
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpEntradas = new System.Windows.Forms.GroupBox();
            this.tlpEntradas = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkBorrado = new System.Windows.Forms.CheckBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.grpEntradas.SuspendLayout();
            this.tlpEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Salmon;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Brown;
            this.btnSalir.Location = new System.Drawing.Point(330, -2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(26, 24);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Salmon;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(86, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 16);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Agregar un registro nuevo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseDown);
            // 
            // grpEntradas
            // 
            this.grpEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpEntradas.Controls.Add(this.tlpEntradas);
            this.grpEntradas.Location = new System.Drawing.Point(0, 20);
            this.grpEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.grpEntradas.Name = "grpEntradas";
            this.grpEntradas.Padding = new System.Windows.Forms.Padding(2);
            this.grpEntradas.Size = new System.Drawing.Size(356, 152);
            this.grpEntradas.TabIndex = 33;
            this.grpEntradas.TabStop = false;
            // 
            // tlpEntradas
            // 
            this.tlpEntradas.ColumnCount = 3;
            this.tlpEntradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpEntradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpEntradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpEntradas.Controls.Add(this.lblUsuario, 0, 0);
            this.tlpEntradas.Controls.Add(this.btnVolver, 1, 3);
            this.tlpEntradas.Controls.Add(this.btnAceptar, 2, 3);
            this.tlpEntradas.Controls.Add(this.label2, 0, 1);
            this.tlpEntradas.Controls.Add(this.nudMonto, 1, 1);
            this.tlpEntradas.Controls.Add(this.chkBorrado, 1, 2);
            this.tlpEntradas.Controls.Add(this.TxtNombre, 1, 0);
            this.tlpEntradas.Location = new System.Drawing.Point(4, 17);
            this.tlpEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.tlpEntradas.Name = "tlpEntradas";
            this.tlpEntradas.RowCount = 4;
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.06557F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpEntradas.Size = new System.Drawing.Size(345, 126);
            this.tlpEntradas.TabIndex = 59;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(50, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 26);
            this.lblUsuario.TabIndex = 58;
            this.lblUsuario.Text = "Nombre:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "Monto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMonto
            // 
            this.nudMonto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Location = new System.Drawing.Point(103, 29);
            this.nudMonto.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(201, 20);
            this.nudMonto.TabIndex = 58;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnVolver.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnVolver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(272, 81);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 42);
            this.btnVolver.TabIndex = 62;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAceptar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(310, 81);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(32, 42);
            this.btnAceptar.TabIndex = 57;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // chkBorrado
            // 
            this.chkBorrado.AutoSize = true;
            this.chkBorrado.Location = new System.Drawing.Point(103, 55);
            this.chkBorrado.Name = "chkBorrado";
            this.chkBorrado.Size = new System.Drawing.Size(63, 17);
            this.chkBorrado.TabIndex = 52;
            this.chkBorrado.Text = "Borrado";
            this.chkBorrado.UseVisualStyleBackColor = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(103, 3);
            this.TxtNombre.MaxLength = 40;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(201, 20);
            this.TxtNombre.TabIndex = 63;
            // 
            // FrmAsignacionesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(356, 169);
            this.Controls.Add(this.grpEntradas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsignacionesABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsignacionesABM";
            this.Load += new System.EventHandler(this.FrmAsignacionesABM_Load);
            this.grpEntradas.ResumeLayout(false);
            this.tlpEntradas.ResumeLayout(false);
            this.tlpEntradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox grpEntradas;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpEntradas;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkBorrado;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}