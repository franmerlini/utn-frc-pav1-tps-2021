
namespace BugTrackingSystem.CapaPresentacion
{
    partial class FrmAsistenciasABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistenciasABM));
            this.grpEntradas = new System.Windows.Forms.GroupBox();
            this.tlpEntradas = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.chkBorrado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtComentario = new System.Windows.Forms.RichTextBox();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.dateHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.dateHoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHoraIngreso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpEntradas.SuspendLayout();
            this.tlpEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntradas
            // 
            this.grpEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpEntradas.Controls.Add(this.tlpEntradas);
            this.grpEntradas.Location = new System.Drawing.Point(0, 20);
            this.grpEntradas.Name = "grpEntradas";
            this.grpEntradas.Size = new System.Drawing.Size(356, 288);
            this.grpEntradas.TabIndex = 1;
            this.grpEntradas.TabStop = false;
            // 
            // tlpEntradas
            // 
            this.tlpEntradas.ColumnCount = 3;
            this.tlpEntradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tlpEntradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpEntradas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlpEntradas.Controls.Add(this.label5, 0, 1);
            this.tlpEntradas.Controls.Add(this.btnAceptar, 2, 7);
            this.tlpEntradas.Controls.Add(this.btnVolver, 1, 7);
            this.tlpEntradas.Controls.Add(this.chkBorrado, 1, 6);
            this.tlpEntradas.Controls.Add(this.label6, 0, 0);
            this.tlpEntradas.Controls.Add(this.rtxtComentario, 1, 5);
            this.tlpEntradas.Controls.Add(this.cboUsuario, 1, 0);
            this.tlpEntradas.Controls.Add(this.cboEstado, 1, 4);
            this.tlpEntradas.Controls.Add(this.lblComentario, 0, 5);
            this.tlpEntradas.Controls.Add(this.dateHoraSalida, 1, 3);
            this.tlpEntradas.Controls.Add(this.dateFecha, 1, 1);
            this.tlpEntradas.Controls.Add(this.dateHoraIngreso, 1, 2);
            this.tlpEntradas.Controls.Add(this.lblEstado, 0, 4);
            this.tlpEntradas.Controls.Add(this.lblHoraIngreso, 0, 2);
            this.tlpEntradas.Controls.Add(this.label1, 0, 3);
            this.tlpEntradas.Location = new System.Drawing.Point(5, 18);
            this.tlpEntradas.Margin = new System.Windows.Forms.Padding(2);
            this.tlpEntradas.Name = "tlpEntradas";
            this.tlpEntradas.RowCount = 8;
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpEntradas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpEntradas.Size = new System.Drawing.Size(345, 264);
            this.tlpEntradas.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 64;
            this.label5.Text = "Fecha:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAceptar.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnAceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(310, 225);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(32, 36);
            this.btnAceptar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnAceptar, "Aceptar");
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolver.BackgroundImage = global::BugTrackingSystem.Properties.Resources.BtnVolver;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.ForeColor = System.Drawing.Color.Transparent;
            this.btnVolver.Location = new System.Drawing.Point(272, 225);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(32, 36);
            this.btnVolver.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // chkBorrado
            // 
            this.chkBorrado.AutoSize = true;
            this.chkBorrado.Location = new System.Drawing.Point(103, 199);
            this.chkBorrado.Name = "chkBorrado";
            this.chkBorrado.Size = new System.Drawing.Size(63, 17);
            this.chkBorrado.TabIndex = 30;
            this.chkBorrado.Text = "Borrado";
            this.chkBorrado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 26);
            this.label6.TabIndex = 62;
            this.label6.Text = "Usuario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtComentario
            // 
            this.rtxtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtComentario.Location = new System.Drawing.Point(103, 133);
            this.rtxtComentario.MaxLength = 500;
            this.rtxtComentario.Name = "rtxtComentario";
            this.rtxtComentario.Size = new System.Drawing.Size(201, 60);
            this.rtxtComentario.TabIndex = 26;
            this.rtxtComentario.Text = "";
            // 
            // cboUsuario
            // 
            this.cboUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(103, 3);
            this.cboUsuario.MaxLength = 50;
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(201, 21);
            this.cboUsuario.TabIndex = 16;
            // 
            // cboEstado
            // 
            this.cboEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(103, 107);
            this.cboEstado.MaxLength = 50;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(201, 21);
            this.cboEstado.TabIndex = 24;
            // 
            // lblComentario
            // 
            this.lblComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(34, 130);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(63, 66);
            this.lblComentario.TabIndex = 25;
            this.lblComentario.Text = "Comentario:";
            this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateHoraSalida
            // 
            this.dateHoraSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateHoraSalida.Checked = false;
            this.dateHoraSalida.CustomFormat = "HH:mm ";
            this.dateHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHoraSalida.Location = new System.Drawing.Point(103, 81);
            this.dateHoraSalida.Name = "dateHoraSalida";
            this.dateHoraSalida.ShowUpDown = true;
            this.dateHoraSalida.Size = new System.Drawing.Size(201, 20);
            this.dateHoraSalida.TabIndex = 22;
            this.dateHoraSalida.Value = new System.DateTime(2021, 9, 21, 23, 58, 0, 0);
            // 
            // dateFecha
            // 
            this.dateFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFecha.CustomFormat = "";
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(103, 29);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(201, 20);
            this.dateFecha.TabIndex = 18;
            // 
            // dateHoraIngreso
            // 
            this.dateHoraIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateHoraIngreso.Checked = false;
            this.dateHoraIngreso.CustomFormat = "HH:mm";
            this.dateHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHoraIngreso.Location = new System.Drawing.Point(103, 55);
            this.dateHoraIngreso.Name = "dateHoraIngreso";
            this.dateHoraIngreso.ShowUpDown = true;
            this.dateHoraIngreso.Size = new System.Drawing.Size(201, 20);
            this.dateHoraIngreso.TabIndex = 20;
            this.dateHoraIngreso.Value = new System.DateTime(2021, 9, 22, 1, 0, 0, 0);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(54, 104);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 26);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoraIngreso
            // 
            this.lblHoraIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHoraIngreso.AutoSize = true;
            this.lblHoraIngreso.Location = new System.Drawing.Point(26, 52);
            this.lblHoraIngreso.Name = "lblHoraIngreso";
            this.lblHoraIngreso.Size = new System.Drawing.Size(71, 26);
            this.lblHoraIngreso.TabIndex = 19;
            this.lblHoraIngreso.Text = "Hora Ingreso:";
            this.lblHoraIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hora Salida:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Salmon;
            this.lblTitulo.Enabled = false;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(85, 2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 16);
            this.lblTitulo.TabIndex = 27;
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
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuStrip1_MouseMove);
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
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmAsistenciasABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 307);
            this.Controls.Add(this.grpEntradas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAsistenciasABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevo registro";
            this.Load += new System.EventHandler(this.FrmAsistenciasABM_Load);
            this.grpEntradas.ResumeLayout(false);
            this.tlpEntradas.ResumeLayout(false);
            this.tlpEntradas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEntradas;
        private System.Windows.Forms.RichTextBox rtxtComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dateHoraSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateHoraIngreso;
        private System.Windows.Forms.Label lblHoraIngreso;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkBorrado;
        private System.Windows.Forms.TableLayoutPanel tlpEntradas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}