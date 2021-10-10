
namespace BugTrackingSystem.CapaPresentacion
{
    partial class FrmGeneracionMensualSueldo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDtoAsig = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDtoAsig = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbDescuento = new System.Windows.Forms.RadioButton();
            this.rbAsignacion = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudSueldoBruto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldoTotal = new System.Windows.Forms.TextBox();
            this.txtDtoSueldo = new System.Windows.Forms.TextBox();
            this.txtAsigSueldo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAsignaciones = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDescuentos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldoBruto)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpAcciones.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.cboDtoAsig);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.rbDescuento);
            this.groupBox1.Controls.Add(this.rbAsignacion);
            this.groupBox1.Location = new System.Drawing.Point(271, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(485, 102);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Sueldo";
            // 
            // cboDtoAsig
            // 
            this.cboDtoAsig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDtoAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDtoAsig.FormattingEnabled = true;
            this.cboDtoAsig.Location = new System.Drawing.Point(21, 46);
            this.cboDtoAsig.Margin = new System.Windows.Forms.Padding(2);
            this.cboDtoAsig.Name = "cboDtoAsig";
            this.cboDtoAsig.Size = new System.Drawing.Size(168, 21);
            this.cboDtoAsig.TabIndex = 10;
            this.cboDtoAsig.SelectedIndexChanged += new System.EventHandler(this.cboDtoAsig_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDtoAsig, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudCantidad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtImporte, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 17);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 76);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Monto Unitario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDtoAsig
            // 
            this.txtDtoAsig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDtoAsig.Location = new System.Drawing.Point(86, 2);
            this.txtDtoAsig.Margin = new System.Windows.Forms.Padding(2);
            this.txtDtoAsig.Name = "txtDtoAsig";
            this.txtDtoAsig.ReadOnly = true;
            this.txtDtoAsig.Size = new System.Drawing.Size(165, 20);
            this.txtDtoAsig.TabIndex = 13;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidad.Location = new System.Drawing.Point(86, 27);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(165, 20);
            this.nudCantidad.TabIndex = 17;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImporte.Location = new System.Drawing.Point(86, 52);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(165, 20);
            this.txtImporte.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Monto Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbDescuento
            // 
            this.rbDescuento.AutoSize = true;
            this.rbDescuento.Location = new System.Drawing.Point(114, 25);
            this.rbDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.rbDescuento.Name = "rbDescuento";
            this.rbDescuento.Size = new System.Drawing.Size(77, 17);
            this.rbDescuento.TabIndex = 12;
            this.rbDescuento.TabStop = true;
            this.rbDescuento.Text = "Descuento";
            this.rbDescuento.UseVisualStyleBackColor = true;
            this.rbDescuento.Click += new System.EventHandler(this.rbDescuento_Click);
            // 
            // rbAsignacion
            // 
            this.rbAsignacion.AutoSize = true;
            this.rbAsignacion.Location = new System.Drawing.Point(21, 25);
            this.rbAsignacion.Margin = new System.Windows.Forms.Padding(2);
            this.rbAsignacion.Name = "rbAsignacion";
            this.rbAsignacion.Size = new System.Drawing.Size(77, 17);
            this.rbAsignacion.TabIndex = 11;
            this.rbAsignacion.TabStop = true;
            this.rbAsignacion.Text = "Asignación";
            this.rbAsignacion.UseVisualStyleBackColor = true;
            this.rbAsignacion.Click += new System.EventHandler(this.rbAsignacion_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(2, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sueldo bruto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(26, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Usuario:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboUsuario
            // 
            this.cboUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(76, 2);
            this.cboUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(170, 21);
            this.cboUsuario.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(32, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fecha:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(76, 27);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(170, 20);
            this.dtpFecha.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(257, 102);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sueldo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.nudSueldoBruto, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtpFecha, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboUsuario, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 76);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // nudSueldoBruto
            // 
            this.nudSueldoBruto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSueldoBruto.DecimalPlaces = 2;
            this.nudSueldoBruto.Location = new System.Drawing.Point(76, 52);
            this.nudSueldoBruto.Margin = new System.Windows.Forms.Padding(2);
            this.nudSueldoBruto.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudSueldoBruto.Name = "nudSueldoBruto";
            this.nudSueldoBruto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudSueldoBruto.Size = new System.Drawing.Size(170, 20);
            this.nudSueldoBruto.TabIndex = 31;
            this.nudSueldoBruto.ValueChanged += new System.EventHandler(this.nudSueldoBruto_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(33, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Asignaciones:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(248, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Descuentos:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17172F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSueldoTotal, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDtoSueldo, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtAsigSueldo, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(342, 17);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(630, 23);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(479, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "TOTAL:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSueldoTotal
            // 
            this.txtSueldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSueldoTotal.Location = new System.Drawing.Point(528, 2);
            this.txtSueldoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSueldoTotal.Name = "txtSueldoTotal";
            this.txtSueldoTotal.ReadOnly = true;
            this.txtSueldoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoTotal.TabIndex = 38;
            // 
            // txtDtoSueldo
            // 
            this.txtDtoSueldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDtoSueldo.Location = new System.Drawing.Point(319, 2);
            this.txtDtoSueldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtDtoSueldo.Name = "txtDtoSueldo";
            this.txtDtoSueldo.ReadOnly = true;
            this.txtDtoSueldo.Size = new System.Drawing.Size(97, 20);
            this.txtDtoSueldo.TabIndex = 34;
            // 
            // txtAsigSueldo
            // 
            this.txtAsigSueldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsigSueldo.Location = new System.Drawing.Point(110, 2);
            this.txtAsigSueldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtAsigSueldo.Name = "txtAsigSueldo";
            this.txtAsigSueldo.ReadOnly = true;
            this.txtAsigSueldo.Size = new System.Drawing.Size(97, 20);
            this.txtAsigSueldo.TabIndex = 36;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Pink;
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Location = new System.Drawing.Point(9, 388);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(976, 54);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            // 
            // grpAcciones
            // 
            this.grpAcciones.BackColor = System.Drawing.Color.Pink;
            this.grpAcciones.Controls.Add(this.tableLayoutPanel3);
            this.grpAcciones.Location = new System.Drawing.Point(761, 10);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(225, 102);
            this.grpAcciones.TabIndex = 49;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Controls.Add(this.btnAceptar, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLimpiar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(225, 52);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.Pink;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Image = global::BugTrackingSystem.Properties.Resources.BtnGuardar;
            this.btnAceptar.Location = new System.Drawing.Point(171, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(51, 46);
            this.btnAceptar.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btnAceptar, "Guardar transacción");
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Pink;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Image = global::BugTrackingSystem.Properties.Resources.BtnAgregar;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 46);
            this.btnAgregar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar asignación/descuento");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Pink;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Image = global::BugTrackingSystem.Properties.Resources.BtnLimpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(115, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(50, 46);
            this.btnLimpiar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar transacción actual");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Pink;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Image = global::BugTrackingSystem.Properties.Resources.BtnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(59, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 46);
            this.btnEliminar.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar asignación/descuento seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Pink;
            this.groupBox3.Controls.Add(this.dgvAsignaciones);
            this.groupBox3.Location = new System.Drawing.Point(9, 116);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(487, 268);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignaciones";
            // 
            // dgvAsignaciones
            // 
            this.dgvAsignaciones.AllowUserToAddRows = false;
            this.dgvAsignaciones.AllowUserToDeleteRows = false;
            this.dgvAsignaciones.AllowUserToOrderColumns = true;
            this.dgvAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignaciones.Location = new System.Drawing.Point(6, 18);
            this.dgvAsignaciones.MultiSelect = false;
            this.dgvAsignaciones.Name = "dgvAsignaciones";
            this.dgvAsignaciones.ReadOnly = true;
            this.dgvAsignaciones.RowHeadersWidth = 51;
            this.dgvAsignaciones.Size = new System.Drawing.Size(476, 245);
            this.dgvAsignaciones.TabIndex = 33;
            this.dgvAsignaciones.Click += new System.EventHandler(this.dgvAsignaciones_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Pink;
            this.groupBox5.Controls.Add(this.dgvDescuentos);
            this.groupBox5.Location = new System.Drawing.Point(500, 116);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(487, 268);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Descuentos";
            // 
            // dgvDescuentos
            // 
            this.dgvDescuentos.AllowUserToAddRows = false;
            this.dgvDescuentos.AllowUserToDeleteRows = false;
            this.dgvDescuentos.AllowUserToOrderColumns = true;
            this.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescuentos.Location = new System.Drawing.Point(6, 18);
            this.dgvDescuentos.MultiSelect = false;
            this.dgvDescuentos.Name = "dgvDescuentos";
            this.dgvDescuentos.ReadOnly = true;
            this.dgvDescuentos.RowHeadersWidth = 51;
            this.dgvDescuentos.Size = new System.Drawing.Size(476, 245);
            this.dgvDescuentos.TabIndex = 33;
            this.dgvDescuentos.Click += new System.EventHandler(this.dgvDescuentos_Click);
            // 
            // FrmGeneracionMensualSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(995, 451);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGeneracionMensualSueldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGeneracionMensualSueldo";
            this.Load += new System.EventHandler(this.FrmGeneracionMensualSueldo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSueldoBruto)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grpAcciones.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignaciones)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescuentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtDtoAsig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nudSueldoBruto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAsignaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldoTotal;
        private System.Windows.Forms.TextBox txtDtoSueldo;
        private System.Windows.Forms.TextBox txtAsigSueldo;
        private System.Windows.Forms.ComboBox cboDtoAsig;
        private System.Windows.Forms.RadioButton rbDescuento;
        private System.Windows.Forms.RadioButton rbAsignacion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvDescuentos;
    }
}