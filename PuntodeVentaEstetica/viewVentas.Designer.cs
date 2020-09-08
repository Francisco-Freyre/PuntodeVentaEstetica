namespace PuntodeVentaEstetica
{
    partial class viewVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGananciaInv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCostoInv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAgotados = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxVendidos = new System.Windows.Forms.CheckBox();
            this.btnPdf2 = new System.Windows.Forms.Button();
            this.btnExcel2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 66);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 563);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(244, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(169, 20);
            this.txtBuscar.TabIndex = 23;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(198, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Buscar";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv.ColumnHeadersHeight = 27;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv.Location = new System.Drawing.Point(198, 66);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(814, 455);
            this.dgv.TabIndex = 22;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_RowPrePaint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGananciaInv);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblCostoInv);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnPdf);
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtExistencia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxAgotados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 531);
            this.panel2.TabIndex = 0;
            // 
            // lblGananciaInv
            // 
            this.lblGananciaInv.AutoSize = true;
            this.lblGananciaInv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGananciaInv.Location = new System.Drawing.Point(141, 317);
            this.lblGananciaInv.Name = "lblGananciaInv";
            this.lblGananciaInv.Size = new System.Drawing.Size(34, 13);
            this.lblGananciaInv.TabIndex = 10;
            this.lblGananciaInv.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ganancia aprox:";
            // 
            // lblCostoInv
            // 
            this.lblCostoInv.AutoSize = true;
            this.lblCostoInv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCostoInv.Location = new System.Drawing.Point(141, 263);
            this.lblCostoInv.Name = "lblCostoInv";
            this.lblCostoInv.Size = new System.Drawing.Size(34, 13);
            this.lblCostoInv.TabIndex = 8;
            this.lblCostoInv.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo del inventario:";
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(100, 206);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(6, 206);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exportar:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(6, 91);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(169, 20);
            this.txtExistencia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Existencia:";
            // 
            // cbxAgotados
            // 
            this.cbxAgotados.AutoSize = true;
            this.cbxAgotados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cbxAgotados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxAgotados.Location = new System.Drawing.Point(6, 19);
            this.cbxAgotados.Name = "cbxAgotados";
            this.cbxAgotados.Size = new System.Drawing.Size(172, 17);
            this.cbxAgotados.TabIndex = 0;
            this.cbxAgotados.Text = "Productos a punto de agotarse";
            this.cbxAgotados.UseVisualStyleBackColor = false;
            this.cbxAgotados.CheckedChanged += new System.EventHandler(this.cbxAgotados_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.tabPage2.Controls.Add(this.txtBuscar2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dgv2);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial ventas";
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(246, 19);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(169, 20);
            this.txtBuscar2.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(200, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Buscar";
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgv2.ColumnHeadersHeight = 27;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv2.EnableHeadersVisualStyles = false;
            this.dgv2.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv2.Location = new System.Drawing.Point(200, 66);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv2.RowHeadersVisible = false;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv2.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(814, 455);
            this.dgv2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpFinal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.dtpInicio);
            this.panel3.Controls.Add(this.cbxVendidos);
            this.panel3.Controls.Add(this.btnPdf2);
            this.panel3.Controls.Add(this.btnExcel2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 531);
            this.panel3.TabIndex = 25;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(6, 110);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(180, 20);
            this.dtpFinal.TabIndex = 14;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(3, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Final:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(6, 49);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(180, 20);
            this.dtpInicio.TabIndex = 12;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // cbxVendidos
            // 
            this.cbxVendidos.AutoSize = true;
            this.cbxVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cbxVendidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxVendidos.Location = new System.Drawing.Point(6, 151);
            this.cbxVendidos.Name = "cbxVendidos";
            this.cbxVendidos.Size = new System.Drawing.Size(142, 17);
            this.cbxVendidos.TabIndex = 11;
            this.cbxVendidos.Text = "Productos mas vendidos";
            this.cbxVendidos.UseVisualStyleBackColor = false;
            this.cbxVendidos.CheckedChanged += new System.EventHandler(this.cbxVendidos_CheckedChanged);
            // 
            // btnPdf2
            // 
            this.btnPdf2.Location = new System.Drawing.Point(100, 223);
            this.btnPdf2.Name = "btnPdf2";
            this.btnPdf2.Size = new System.Drawing.Size(75, 23);
            this.btnPdf2.TabIndex = 6;
            this.btnPdf2.Text = "PDF";
            this.btnPdf2.UseVisualStyleBackColor = true;
            this.btnPdf2.Click += new System.EventHandler(this.btnPdf2_Click);
            // 
            // btnExcel2
            // 
            this.btnExcel2.Location = new System.Drawing.Point(6, 223);
            this.btnExcel2.Name = "btnExcel2";
            this.btnExcel2.Size = new System.Drawing.Size(75, 23);
            this.btnExcel2.TabIndex = 5;
            this.btnExcel2.Text = "Excel";
            this.btnExcel2.UseVisualStyleBackColor = true;
            this.btnExcel2.Click += new System.EventHandler(this.btnExcel2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(3, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Exportar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(3, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Inicial:";
            // 
            // viewVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1050, 647);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewVentas";
            this.Text = "viewVentas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGananciaInv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCostoInv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.CheckBox cbxAgotados;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.CheckBox cbxVendidos;
        private System.Windows.Forms.Button btnPdf2;
        private System.Windows.Forms.Button btnExcel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}