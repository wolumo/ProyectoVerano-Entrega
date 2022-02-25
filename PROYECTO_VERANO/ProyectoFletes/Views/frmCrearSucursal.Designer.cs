
namespace ProyectoFletes.Views
{
    partial class frmCrearSucursal
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.dtmAntiguedad = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bntMapa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Sucursal";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(37, 108);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(310, 21);
            this.cmbDepartamento.TabIndex = 4;
            this.cmbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbDepartamento_SelectedIndexChanged);
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.SystemColors.Control;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Location = new System.Drawing.Point(34, 273);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(310, 20);
            this.txtTel.TabIndex = 9;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(34, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(31, 88);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(88, 16);
            this.lblDepartamento.TabIndex = 15;
            this.lblDepartamento.Text = "Departamento";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(34, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 1);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(38, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(36, 273);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 16);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(36, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 1);
            this.panel5.TabIndex = 3;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntiguedad.Location = new System.Drawing.Point(33, 319);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(71, 16);
            this.lblAntiguedad.TabIndex = 22;
            this.lblAntiguedad.Text = "Antiguedad";
            // 
            // dtmAntiguedad
            // 
            this.dtmAntiguedad.Location = new System.Drawing.Point(34, 339);
            this.dtmAntiguedad.Name = "dtmAntiguedad";
            this.dtmAntiguedad.Size = new System.Drawing.Size(314, 20);
            this.dtmAntiguedad.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nombre Direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(38, 170);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.WordWrap = false;
            // 
            // bntMapa
            // 
            this.bntMapa.BackColor = System.Drawing.SystemColors.Desktop;
            this.bntMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMapa.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntMapa.Location = new System.Drawing.Point(260, 167);
            this.bntMapa.Name = "bntMapa";
            this.bntMapa.Size = new System.Drawing.Size(88, 26);
            this.bntMapa.TabIndex = 26;
            this.bntMapa.Text = "Mapa";
            this.bntMapa.UseVisualStyleBackColor = false;
            this.bntMapa.Click += new System.EventHandler(this.bntMapa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Coordenadas (Latitud, Longitud)";
            // 
            // txtLatitud
            // 
            this.txtLatitud.BackColor = System.Drawing.SystemColors.Control;
            this.txtLatitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLatitud.Location = new System.Drawing.Point(34, 228);
            this.txtLatitud.Multiline = true;
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.ReadOnly = true;
            this.txtLatitud.Size = new System.Drawing.Size(162, 24);
            this.txtLatitud.TabIndex = 28;
            this.txtLatitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLatitud.WordWrap = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(38, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 1);
            this.panel4.TabIndex = 3;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BackColor = System.Drawing.SystemColors.Control;
            this.txtLongitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongitud.Location = new System.Drawing.Point(194, 228);
            this.txtLongitud.Multiline = true;
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.ReadOnly = true;
            this.txtLongitud.Size = new System.Drawing.Size(162, 24);
            this.txtLongitud.TabIndex = 29;
            this.txtLongitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLongitud.WordWrap = false;
            // 
            // frmCrearSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 470);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntMapa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmAntiguedad);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearSucursal";
            this.Text = "frmCrearPiloto";
            this.Load += new System.EventHandler(this.frmCrearSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.DateTimePicker dtmAntiguedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntMapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ComboBox cmbDepartamento;
        public System.Windows.Forms.TextBox txtLongitud;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtLatitud;
    }
}