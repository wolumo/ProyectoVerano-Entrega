
namespace ProyectoFletes.Views
{
    partial class fmCrearContrato
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
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.lblcmbSucursal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fechaPronost = new System.Windows.Forms.Label();
            this.dtmFechaPronos = new System.Windows.Forms.DateTimePicker();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLugarSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLatitudS = new System.Windows.Forms.TextBox();
            this.txtLongitudS = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtLongLLegada = new System.Windows.Forms.TextBox();
            this.txtLatLLegada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreLLegada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtGasolinaPrecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.txtDistanciaKm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Contrato";
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(20, 71);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(317, 21);
            this.cmbSucursales.TabIndex = 1;
            this.cmbSucursales.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblcmbSucursal
            // 
            this.lblcmbSucursal.AutoSize = true;
            this.lblcmbSucursal.BackColor = System.Drawing.SystemColors.Control;
            this.lblcmbSucursal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmbSucursal.Location = new System.Drawing.Point(18, 47);
            this.lblcmbSucursal.Name = "lblcmbSucursal";
            this.lblcmbSucursal.Size = new System.Drawing.Size(64, 19);
            this.lblcmbSucursal.TabIndex = 2;
            this.lblcmbSucursal.Text = "Sucursal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(18, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 1);
            this.panel1.TabIndex = 3;
            // 
            // fechaPronost
            // 
            this.fechaPronost.AutoSize = true;
            this.fechaPronost.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPronost.Location = new System.Drawing.Point(18, 117);
            this.fechaPronost.Name = "fechaPronost";
            this.fechaPronost.Size = new System.Drawing.Size(139, 19);
            this.fechaPronost.TabIndex = 8;
            this.fechaPronost.Text = "Fecha Pronosticada";
            // 
            // dtmFechaPronos
            // 
            this.dtmFechaPronos.Location = new System.Drawing.Point(22, 139);
            this.dtmFechaPronos.Name = "dtmFechaPronos";
            this.dtmFechaPronos.Size = new System.Drawing.Size(321, 20);
            this.dtmFechaPronos.TabIndex = 9;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrear.Location = new System.Drawing.Point(452, 471);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(321, 42);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(18, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 1);
            this.panel2.TabIndex = 4;
            // 
            // txtRuc
            // 
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuc.Location = new System.Drawing.Point(18, 200);
            this.txtRuc.Multiline = true;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(321, 20);
            this.txtRuc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "N# Ruc Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Location = new System.Drawing.Point(22, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 1);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Direccion Lugar Salida";
            // 
            // txtLugarSalida
            // 
            this.txtLugarSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLugarSalida.Location = new System.Drawing.Point(22, 287);
            this.txtLugarSalida.Multiline = true;
            this.txtLugarSalida.Name = "txtLugarSalida";
            this.txtLugarSalida.ReadOnly = true;
            this.txtLugarSalida.Size = new System.Drawing.Size(321, 22);
            this.txtLugarSalida.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coordenadas Salida (Latitud,Longitud)";
            // 
            // txtLatitudS
            // 
            this.txtLatitudS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLatitudS.Location = new System.Drawing.Point(22, 353);
            this.txtLatitudS.Multiline = true;
            this.txtLatitudS.Name = "txtLatitudS";
            this.txtLatitudS.ReadOnly = true;
            this.txtLatitudS.Size = new System.Drawing.Size(155, 22);
            this.txtLatitudS.TabIndex = 18;
            // 
            // txtLongitudS
            // 
            this.txtLongitudS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongitudS.Location = new System.Drawing.Point(185, 353);
            this.txtLongitudS.Multiline = true;
            this.txtLongitudS.Name = "txtLongitudS";
            this.txtLongitudS.ReadOnly = true;
            this.txtLongitudS.Size = new System.Drawing.Size(158, 22);
            this.txtLongitudS.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(24, 315);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(321, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Location = new System.Drawing.Point(22, 381);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(321, 1);
            this.panel5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Detalles";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel6.Location = new System.Drawing.Point(18, 253);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 1);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel7.Location = new System.Drawing.Point(22, 501);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(321, 1);
            this.panel7.TabIndex = 27;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel8.Location = new System.Drawing.Point(24, 435);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(321, 1);
            this.panel8.TabIndex = 21;
            // 
            // txtLongLLegada
            // 
            this.txtLongLLegada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLongLLegada.Location = new System.Drawing.Point(185, 473);
            this.txtLongLLegada.Multiline = true;
            this.txtLongLLegada.Name = "txtLongLLegada";
            this.txtLongLLegada.ReadOnly = true;
            this.txtLongLLegada.Size = new System.Drawing.Size(158, 22);
            this.txtLongLLegada.TabIndex = 26;
            // 
            // txtLatLLegada
            // 
            this.txtLatLLegada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLatLLegada.Location = new System.Drawing.Point(22, 473);
            this.txtLatLLegada.Multiline = true;
            this.txtLatLLegada.Name = "txtLatLLegada";
            this.txtLatLLegada.ReadOnly = true;
            this.txtLatLLegada.Size = new System.Drawing.Size(155, 22);
            this.txtLatLLegada.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Coordenadas Llegada (Latitud,Longitud)";
            // 
            // txtNombreLLegada
            // 
            this.txtNombreLLegada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreLLegada.Location = new System.Drawing.Point(22, 407);
            this.txtNombreLLegada.Multiline = true;
            this.txtNombreLLegada.Name = "txtNombreLLegada";
            this.txtNombreLLegada.ReadOnly = true;
            this.txtNombreLLegada.Size = new System.Drawing.Size(321, 22);
            this.txtNombreLLegada.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Direccion Lugar Llegada";
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Location = new System.Drawing.Point(450, 102);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(321, 22);
            this.txtPeso.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Peso (En toneladas)";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel9.Location = new System.Drawing.Point(450, 130);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(321, 1);
            this.panel9.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Montos";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel10.Location = new System.Drawing.Point(450, 169);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(321, 1);
            this.panel10.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel11.Location = new System.Drawing.Point(450, 230);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(321, 1);
            this.panel11.TabIndex = 18;
            // 
            // txtGasolinaPrecio
            // 
            this.txtGasolinaPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGasolinaPrecio.Location = new System.Drawing.Point(448, 202);
            this.txtGasolinaPrecio.Multiline = true;
            this.txtGasolinaPrecio.Name = "txtGasolinaPrecio";
            this.txtGasolinaPrecio.Size = new System.Drawing.Size(321, 22);
            this.txtGasolinaPrecio.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(444, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Precio Diesel";
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCalcularPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularPrecio.Location = new System.Drawing.Point(448, 246);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(321, 38);
            this.btnCalcularPrecio.TabIndex = 31;
            this.btnCalcularPrecio.Text = "Calcular ";
            this.btnCalcularPrecio.UseVisualStyleBackColor = false;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(454, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Location = new System.Drawing.Point(540, 295);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(231, 22);
            this.txtMonto.TabIndex = 33;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(454, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 34;
            this.label13.Text = "Impuesto: ";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImpuesto.Location = new System.Drawing.Point(540, 326);
            this.txtImpuesto.Multiline = true;
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(231, 22);
            this.txtImpuesto.TabIndex = 35;
            this.txtImpuesto.TextChanged += new System.EventHandler(this.txtImpuesto_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(454, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Descuento:";
            // 
            // txtDescV
            // 
            this.txtDescV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescV.Location = new System.Drawing.Point(542, 365);
            this.txtDescV.Multiline = true;
            this.txtDescV.Name = "txtDescV";
            this.txtDescV.Size = new System.Drawing.Size(89, 22);
            this.txtDescV.TabIndex = 37;
            this.txtDescV.TextChanged += new System.EventHandler(this.txtDescV_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(460, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 19);
            this.label15.TabIndex = 38;
            this.label15.Text = "Total: ";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(542, 409);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(231, 22);
            this.txtTotal.TabIndex = 39;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFacturar.Location = new System.Drawing.Point(452, 519);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(321, 42);
            this.btnFacturar.TabIndex = 40;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtDistanciaKm
            // 
            this.txtDistanciaKm.BackColor = System.Drawing.SystemColors.Control;
            this.txtDistanciaKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistanciaKm.Enabled = false;
            this.txtDistanciaKm.Location = new System.Drawing.Point(118, 511);
            this.txtDistanciaKm.Multiline = true;
            this.txtDistanciaKm.Name = "txtDistanciaKm";
            this.txtDistanciaKm.Size = new System.Drawing.Size(227, 22);
            this.txtDistanciaKm.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 514);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "Distancia km";
            // 
            // btnAniadir
            // 
            this.btnAniadir.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAniadir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAniadir.Location = new System.Drawing.Point(24, 536);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(321, 38);
            this.btnAniadir.TabIndex = 43;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuento.Location = new System.Drawing.Point(649, 365);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(122, 22);
            this.txtDescuento.TabIndex = 44;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Location = new System.Drawing.Point(450, 471);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(321, 42);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdContrato.Location = new System.Drawing.Point(593, 29);
            this.txtIdContrato.Multiline = true;
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.Size = new System.Drawing.Size(201, 22);
            this.txtIdContrato.TabIndex = 47;
            this.txtIdContrato.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Id Contrato:";
            this.label2.Visible = false;
            // 
            // fmCrearContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 579);
            this.Controls.Add(this.txtIdContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.txtDistanciaKm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDescV);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txtGasolinaPrecio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtLongLLegada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLatLLegada);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtNombreLLegada);
            this.Controls.Add(this.txtLongitudS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLatitudS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLugarSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dtmFechaPronos);
            this.Controls.Add(this.fechaPronost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblcmbSucursal);
            this.Controls.Add(this.cmbSucursales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmCrearContrato";
            this.Load += new System.EventHandler(this.fmCrearContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcmbSucursal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fechaPronost;
        private System.Windows.Forms.DateTimePicker dtmFechaPronos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtGasolinaPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnFacturar;
        public System.Windows.Forms.ComboBox cmbSucursales;
        public System.Windows.Forms.TextBox txtLugarSalida;
        public System.Windows.Forms.TextBox txtLatitudS;
        public System.Windows.Forms.TextBox txtLongitudS;
        public System.Windows.Forms.TextBox txtLongLLegada;
        public System.Windows.Forms.TextBox txtLatLLegada;
        public System.Windows.Forms.TextBox txtNombreLLegada;
        public System.Windows.Forms.TextBox txtDistanciaKm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.Button btnCrear;
        public System.Windows.Forms.TextBox txtRuc;
        public System.Windows.Forms.TextBox txtPeso;
        public System.Windows.Forms.TextBox txtIdContrato;
        public System.Windows.Forms.Label label2;
    }
}