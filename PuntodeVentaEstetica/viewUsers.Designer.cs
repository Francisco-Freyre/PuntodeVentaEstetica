namespace PuntodeVentaEstetica
{
    partial class viewUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsuarioCancel = new System.Windows.Forms.Button();
            this.btnUsuarioGuardar = new System.Windows.Forms.Button();
            this.lblUsuarioPass = new System.Windows.Forms.Label();
            this.txtUsuarioPass = new System.Windows.Forms.TextBox();
            this.lblUsuarioUser = new System.Windows.Forms.Label();
            this.txtUsuarioUser = new System.Windows.Forms.TextBox();
            this.lblUsuarioApellido = new System.Windows.Forms.Label();
            this.txtUsuarioApellido = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUsuarioCancel);
            this.panel2.Controls.Add(this.btnUsuarioGuardar);
            this.panel2.Controls.Add(this.lblUsuarioPass);
            this.panel2.Controls.Add(this.txtUsuarioPass);
            this.panel2.Controls.Add(this.lblUsuarioUser);
            this.panel2.Controls.Add(this.txtUsuarioUser);
            this.panel2.Controls.Add(this.lblUsuarioApellido);
            this.panel2.Controls.Add(this.txtUsuarioApellido);
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.txtUsuarioNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 581);
            this.panel2.TabIndex = 4;
            // 
            // btnUsuarioCancel
            // 
            this.btnUsuarioCancel.Location = new System.Drawing.Point(141, 335);
            this.btnUsuarioCancel.Name = "btnUsuarioCancel";
            this.btnUsuarioCancel.Size = new System.Drawing.Size(88, 40);
            this.btnUsuarioCancel.TabIndex = 7;
            this.btnUsuarioCancel.Text = "Cancelar";
            this.btnUsuarioCancel.UseVisualStyleBackColor = true;
            this.btnUsuarioCancel.Click += new System.EventHandler(this.btnUsuarioCancel_Click);
            // 
            // btnUsuarioGuardar
            // 
            this.btnUsuarioGuardar.Location = new System.Drawing.Point(35, 335);
            this.btnUsuarioGuardar.Name = "btnUsuarioGuardar";
            this.btnUsuarioGuardar.Size = new System.Drawing.Size(88, 40);
            this.btnUsuarioGuardar.TabIndex = 6;
            this.btnUsuarioGuardar.Text = "Guardar";
            this.btnUsuarioGuardar.UseVisualStyleBackColor = true;
            this.btnUsuarioGuardar.Click += new System.EventHandler(this.btnUsuarioGuardar_Click_1);
            // 
            // lblUsuarioPass
            // 
            this.lblUsuarioPass.AutoSize = true;
            this.lblUsuarioPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioPass.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblUsuarioPass.Location = new System.Drawing.Point(31, 234);
            this.lblUsuarioPass.Name = "lblUsuarioPass";
            this.lblUsuarioPass.Size = new System.Drawing.Size(81, 19);
            this.lblUsuarioPass.TabIndex = 4;
            this.lblUsuarioPass.Text = "Contraseña:";
            // 
            // txtUsuarioPass
            // 
            this.txtUsuarioPass.Location = new System.Drawing.Point(35, 272);
            this.txtUsuarioPass.Name = "txtUsuarioPass";
            this.txtUsuarioPass.Size = new System.Drawing.Size(194, 20);
            this.txtUsuarioPass.TabIndex = 5;
            // 
            // lblUsuarioUser
            // 
            this.lblUsuarioUser.AutoSize = true;
            this.lblUsuarioUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioUser.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblUsuarioUser.Location = new System.Drawing.Point(31, 162);
            this.lblUsuarioUser.Name = "lblUsuarioUser";
            this.lblUsuarioUser.Size = new System.Drawing.Size(59, 19);
            this.lblUsuarioUser.TabIndex = 4;
            this.lblUsuarioUser.Text = "Usuario:";
            // 
            // txtUsuarioUser
            // 
            this.txtUsuarioUser.Location = new System.Drawing.Point(35, 200);
            this.txtUsuarioUser.Name = "txtUsuarioUser";
            this.txtUsuarioUser.Size = new System.Drawing.Size(194, 20);
            this.txtUsuarioUser.TabIndex = 5;
            // 
            // lblUsuarioApellido
            // 
            this.lblUsuarioApellido.AutoSize = true;
            this.lblUsuarioApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioApellido.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblUsuarioApellido.Location = new System.Drawing.Point(31, 92);
            this.lblUsuarioApellido.Name = "lblUsuarioApellido";
            this.lblUsuarioApellido.Size = new System.Drawing.Size(69, 19);
            this.lblUsuarioApellido.TabIndex = 4;
            this.lblUsuarioApellido.Text = "Apellidos:";
            // 
            // txtUsuarioApellido
            // 
            this.txtUsuarioApellido.Location = new System.Drawing.Point(35, 130);
            this.txtUsuarioApellido.Name = "txtUsuarioApellido";
            this.txtUsuarioApellido.Size = new System.Drawing.Size(194, 20);
            this.txtUsuarioApellido.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblNombreUsuario.Location = new System.Drawing.Point(31, 25);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(35, 63);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(194, 20);
            this.txtUsuarioNombre.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(962, 441);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 40);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 27;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuarios.Location = new System.Drawing.Point(269, 72);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(769, 350);
            this.dgvUsuarios.TabIndex = 8;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick_1);
            // 
            // viewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1050, 647);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewUsers";
            this.Text = "viewUsers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUsuarioCancel;
        private System.Windows.Forms.Button btnUsuarioGuardar;
        private System.Windows.Forms.Label lblUsuarioPass;
        private System.Windows.Forms.TextBox txtUsuarioPass;
        private System.Windows.Forms.Label lblUsuarioUser;
        private System.Windows.Forms.TextBox txtUsuarioUser;
        private System.Windows.Forms.Label lblUsuarioApellido;
        private System.Windows.Forms.TextBox txtUsuarioApellido;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
    }
}