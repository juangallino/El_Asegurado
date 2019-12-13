namespace Interfaz
{
    partial class PagoPolizaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoPolizaForm));
            this.TituloPanelPoliza = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabBusquedaPoliza = new System.Windows.Forms.TabPage();
            this.textBoxNroPolizaSec = new System.Windows.Forms.TextBox();
            this.textBoxNroPolizaSuc = new System.Windows.Forms.TextBox();
            this.btnBusquedaPoliza = new System.Windows.Forms.Button();
            this.btnVolverTabBusquedaPoliza = new System.Windows.Forms.Button();
            this.textPolizaNroBusquedaPoliza = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tabControlPagoPoliza = new System.Windows.Forms.TabControl();
            this.tabDetallesPoliza = new System.Windows.Forms.TabPage();
            this.textBoxAPagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEmitirReciboPago = new System.Windows.Forms.Button();
            this.dataGridViewCuotasPendientes = new System.Windows.Forms.DataGridView();
            this.chkSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCuotasPendientesPago = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRevDiaPago1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClienteDNI = new System.Windows.Forms.TextBox();
            this.textBoxNroCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVuelto = new System.Windows.Forms.TextBox();
            this.textBoxEntrega = new System.Windows.Forms.TextBox();
            this.textBoxFechaFin = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicio = new System.Windows.Forms.TextBox();
            this.textBoxDatosVehiculo = new System.Windows.Forms.TextBox();
            this.textBoxClienteNombre = new System.Windows.Forms.TextBox();
            this.textBoxPolizaNro = new System.Windows.Forms.TextBox();
            this.btnModPolizaTabDetalles = new System.Windows.Forms.Button();
            this.btnVolverTabDetallePoliza = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tabBusquedaPoliza.SuspendLayout();
            this.tabControlPagoPoliza.SuspendLayout();
            this.tabDetallesPoliza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPanelPoliza
            // 
            this.TituloPanelPoliza.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TituloPanelPoliza.AutoSize = true;
            this.TituloPanelPoliza.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.TituloPanelPoliza.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TituloPanelPoliza.Location = new System.Drawing.Point(378, 13);
            this.TituloPanelPoliza.Name = "TituloPanelPoliza";
            this.TituloPanelPoliza.Size = new System.Drawing.Size(146, 24);
            this.TituloPanelPoliza.TabIndex = 12;
            this.TituloPanelPoliza.Text = "PAGO  PÓLIZA";
            this.TituloPanelPoliza.Click += new System.EventHandler(this.TituloPanelPoliza_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(22, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(78, 24);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(106, 13);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(78, 24);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // tabBusquedaPoliza
            // 
            this.tabBusquedaPoliza.Controls.Add(this.textBoxNroPolizaSec);
            this.tabBusquedaPoliza.Controls.Add(this.textBoxNroPolizaSuc);
            this.tabBusquedaPoliza.Controls.Add(this.btnBusquedaPoliza);
            this.tabBusquedaPoliza.Controls.Add(this.btnVolverTabBusquedaPoliza);
            this.tabBusquedaPoliza.Controls.Add(this.textPolizaNroBusquedaPoliza);
            this.tabBusquedaPoliza.Controls.Add(this.label35);
            this.tabBusquedaPoliza.Location = new System.Drawing.Point(4, 22);
            this.tabBusquedaPoliza.Name = "tabBusquedaPoliza";
            this.tabBusquedaPoliza.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusquedaPoliza.Size = new System.Drawing.Size(831, 449);
            this.tabBusquedaPoliza.TabIndex = 0;
            this.tabBusquedaPoliza.Text = "Búsqueda";
            this.tabBusquedaPoliza.UseVisualStyleBackColor = true;
            this.tabBusquedaPoliza.Click += new System.EventHandler(this.tabBusquedaPoliza_Click);
            // 
            // textBoxNroPolizaSec
            // 
            this.textBoxNroPolizaSec.AcceptsReturn = true;
            this.textBoxNroPolizaSec.AcceptsTab = true;
            this.textBoxNroPolizaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNroPolizaSec.Location = new System.Drawing.Point(334, 25);
            this.textBoxNroPolizaSec.MaxLength = 2;
            this.textBoxNroPolizaSec.Name = "textBoxNroPolizaSec";
            this.textBoxNroPolizaSec.Size = new System.Drawing.Size(25, 26);
            this.textBoxNroPolizaSec.TabIndex = 27;
            this.textBoxNroPolizaSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNroPolizaSuc
            // 
            this.textBoxNroPolizaSuc.AcceptsReturn = true;
            this.textBoxNroPolizaSuc.AcceptsTab = true;
            this.textBoxNroPolizaSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNroPolizaSuc.Location = new System.Drawing.Point(179, 25);
            this.textBoxNroPolizaSuc.MaxLength = 4;
            this.textBoxNroPolizaSuc.Name = "textBoxNroPolizaSuc";
            this.textBoxNroPolizaSuc.Size = new System.Drawing.Size(40, 26);
            this.textBoxNroPolizaSuc.TabIndex = 25;
            this.textBoxNroPolizaSuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxNroPolizaSuc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBusquedaPoliza
            // 
            this.btnBusquedaPoliza.BackColor = System.Drawing.Color.Maroon;
            this.btnBusquedaPoliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusquedaPoliza.BackgroundImage")));
            this.btnBusquedaPoliza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusquedaPoliza.Location = new System.Drawing.Point(388, 25);
            this.btnBusquedaPoliza.Name = "btnBusquedaPoliza";
            this.btnBusquedaPoliza.Size = new System.Drawing.Size(27, 25);
            this.btnBusquedaPoliza.TabIndex = 28;
            this.btnBusquedaPoliza.UseVisualStyleBackColor = false;
            this.btnBusquedaPoliza.Click += new System.EventHandler(this.btnBusquedaCliente_Click_1);
            // 
            // btnVolverTabBusquedaPoliza
            // 
            this.btnVolverTabBusquedaPoliza.Location = new System.Drawing.Point(610, 407);
            this.btnVolverTabBusquedaPoliza.Name = "btnVolverTabBusquedaPoliza";
            this.btnVolverTabBusquedaPoliza.Size = new System.Drawing.Size(72, 26);
            this.btnVolverTabBusquedaPoliza.TabIndex = 28;
            this.btnVolverTabBusquedaPoliza.Text = "Volver";
            this.btnVolverTabBusquedaPoliza.UseVisualStyleBackColor = true;
            this.btnVolverTabBusquedaPoliza.Click += new System.EventHandler(this.btnBuscarTabConsultaPoliza_Click);
            // 
            // textPolizaNroBusquedaPoliza
            // 
            this.textPolizaNroBusquedaPoliza.AcceptsReturn = true;
            this.textPolizaNroBusquedaPoliza.AcceptsTab = true;
            this.textPolizaNroBusquedaPoliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPolizaNroBusquedaPoliza.Location = new System.Drawing.Point(225, 25);
            this.textPolizaNroBusquedaPoliza.MaxLength = 7;
            this.textPolizaNroBusquedaPoliza.Name = "textPolizaNroBusquedaPoliza";
            this.textPolizaNroBusquedaPoliza.Size = new System.Drawing.Size(103, 26);
            this.textPolizaNroBusquedaPoliza.TabIndex = 26;
            this.textPolizaNroBusquedaPoliza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(57, 27);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(111, 20);
            this.label35.TabIndex = 1;
            this.label35.Text = "Póliza Número";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // tabControlPagoPoliza
            // 
            this.tabControlPagoPoliza.Controls.Add(this.tabBusquedaPoliza);
            this.tabControlPagoPoliza.Controls.Add(this.tabDetallesPoliza);
            this.tabControlPagoPoliza.Location = new System.Drawing.Point(12, 43);
            this.tabControlPagoPoliza.Name = "tabControlPagoPoliza";
            this.tabControlPagoPoliza.SelectedIndex = 0;
            this.tabControlPagoPoliza.Size = new System.Drawing.Size(839, 475);
            this.tabControlPagoPoliza.TabIndex = 13;
            // 
            // tabDetallesPoliza
            // 
            this.tabDetallesPoliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDetallesPoliza.Controls.Add(this.textBoxAPagar);
            this.tabDetallesPoliza.Controls.Add(this.label4);
            this.tabDetallesPoliza.Controls.Add(this.btnEmitirReciboPago);
            this.tabDetallesPoliza.Controls.Add(this.dataGridViewCuotasPendientes);
            this.tabDetallesPoliza.Controls.Add(this.lblCuotasPendientesPago);
            this.tabDetallesPoliza.Controls.Add(this.textBox5);
            this.tabDetallesPoliza.Controls.Add(this.label5);
            this.tabDetallesPoliza.Controls.Add(this.textBoxRevDiaPago1);
            this.tabDetallesPoliza.Controls.Add(this.label3);
            this.tabDetallesPoliza.Controls.Add(this.label2);
            this.tabDetallesPoliza.Controls.Add(this.textBoxClienteDNI);
            this.tabDetallesPoliza.Controls.Add(this.textBoxNroCliente);
            this.tabDetallesPoliza.Controls.Add(this.label1);
            this.tabDetallesPoliza.Controls.Add(this.textBoxVuelto);
            this.tabDetallesPoliza.Controls.Add(this.textBoxEntrega);
            this.tabDetallesPoliza.Controls.Add(this.textBoxFechaFin);
            this.tabDetallesPoliza.Controls.Add(this.textBoxFechaInicio);
            this.tabDetallesPoliza.Controls.Add(this.textBoxDatosVehiculo);
            this.tabDetallesPoliza.Controls.Add(this.textBoxClienteNombre);
            this.tabDetallesPoliza.Controls.Add(this.textBoxPolizaNro);
            this.tabDetallesPoliza.Controls.Add(this.btnModPolizaTabDetalles);
            this.tabDetallesPoliza.Controls.Add(this.btnVolverTabDetallePoliza);
            this.tabDetallesPoliza.Controls.Add(this.label56);
            this.tabDetallesPoliza.Controls.Add(this.label54);
            this.tabDetallesPoliza.Controls.Add(this.label51);
            this.tabDetallesPoliza.Controls.Add(this.label50);
            this.tabDetallesPoliza.Controls.Add(this.label46);
            this.tabDetallesPoliza.Controls.Add(this.label45);
            this.tabDetallesPoliza.Controls.Add(this.label44);
            this.tabDetallesPoliza.Location = new System.Drawing.Point(4, 22);
            this.tabDetallesPoliza.Name = "tabDetallesPoliza";
            this.tabDetallesPoliza.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetallesPoliza.Size = new System.Drawing.Size(831, 449);
            this.tabDetallesPoliza.TabIndex = 2;
            this.tabDetallesPoliza.Text = "Detalle";
            this.tabDetallesPoliza.UseVisualStyleBackColor = true;
            // 
            // textBoxAPagar
            // 
            this.textBoxAPagar.AcceptsReturn = true;
            this.textBoxAPagar.AcceptsTab = true;
            this.textBoxAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAPagar.Location = new System.Drawing.Point(117, 409);
            this.textBoxAPagar.Name = "textBoxAPagar";
            this.textBoxAPagar.ReadOnly = true;
            this.textBoxAPagar.Size = new System.Drawing.Size(110, 23);
            this.textBoxAPagar.TabIndex = 46;
            this.textBoxAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAPagar.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "A Pagar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEmitirReciboPago
            // 
            this.btnEmitirReciboPago.Location = new System.Drawing.Point(712, 403);
            this.btnEmitirReciboPago.Name = "btnEmitirReciboPago";
            this.btnEmitirReciboPago.Size = new System.Drawing.Size(108, 25);
            this.btnEmitirReciboPago.TabIndex = 44;
            this.btnEmitirReciboPago.Text = "Emitir Recibo Pago";
            this.btnEmitirReciboPago.UseVisualStyleBackColor = true;
            this.btnEmitirReciboPago.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCuotasPendientes
            // 
            this.dataGridViewCuotasPendientes.AllowUserToAddRows = false;
            this.dataGridViewCuotasPendientes.AllowUserToDeleteRows = false;
            this.dataGridViewCuotasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuotasPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewCuotasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuotasPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSeleccion});
            this.dataGridViewCuotasPendientes.Location = new System.Drawing.Point(146, 231);
            this.dataGridViewCuotasPendientes.Name = "dataGridViewCuotasPendientes";
            this.dataGridViewCuotasPendientes.ReadOnly = true;
            this.dataGridViewCuotasPendientes.Size = new System.Drawing.Size(566, 161);
            this.dataGridViewCuotasPendientes.TabIndex = 43;
            this.dataGridViewCuotasPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCuotasPendientes_CellContentClick);
            // 
            // chkSeleccion
            // 
            this.chkSeleccion.FalseValue = "false";
            this.chkSeleccion.HeaderText = "Sel";
            this.chkSeleccion.IndeterminateValue = "false";
            this.chkSeleccion.Name = "chkSeleccion";
            this.chkSeleccion.ReadOnly = true;
            this.chkSeleccion.TrueValue = "true";
            // 
            // lblCuotasPendientesPago
            // 
            this.lblCuotasPendientesPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuotasPendientesPago.AutoSize = true;
            this.lblCuotasPendientesPago.BackColor = System.Drawing.Color.LightGray;
            this.lblCuotasPendientesPago.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Bold);
            this.lblCuotasPendientesPago.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCuotasPendientesPago.Location = new System.Drawing.Point(299, 199);
            this.lblCuotasPendientesPago.Name = "lblCuotasPendientesPago";
            this.lblCuotasPendientesPago.Size = new System.Drawing.Size(266, 24);
            this.lblCuotasPendientesPago.TabIndex = 14;
            this.lblCuotasPendientesPago.Text = "Cuotas Pendientes de Pago";
            this.lblCuotasPendientesPago.Click += new System.EventHandler(this.lblCuotasPendientesPago_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(680, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(129, 20);
            this.textBox5.TabIndex = 42;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Importe Pagado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxRevDiaPago1
            // 
            this.textBoxRevDiaPago1.Location = new System.Drawing.Point(146, 108);
            this.textBoxRevDiaPago1.Name = "textBoxRevDiaPago1";
            this.textBoxRevDiaPago1.ReadOnly = true;
            this.textBoxRevDiaPago1.Size = new System.Drawing.Size(135, 20);
            this.textBoxRevDiaPago1.TabIndex = 39;
            this.textBoxRevDiaPago1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ultimo Dia Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Documento:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBoxClienteDNI
            // 
            this.textBoxClienteDNI.Location = new System.Drawing.Point(680, 46);
            this.textBoxClienteDNI.Name = "textBoxClienteDNI";
            this.textBoxClienteDNI.ReadOnly = true;
            this.textBoxClienteDNI.Size = new System.Drawing.Size(129, 20);
            this.textBoxClienteDNI.TabIndex = 35;
            this.textBoxClienteDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNroCliente
            // 
            this.textBoxNroCliente.Location = new System.Drawing.Point(146, 47);
            this.textBoxNroCliente.Name = "textBoxNroCliente";
            this.textBoxNroCliente.ReadOnly = true;
            this.textBoxNroCliente.Size = new System.Drawing.Size(163, 20);
            this.textBoxNroCliente.TabIndex = 34;
            this.textBoxNroCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cliente Nro.:";
            // 
            // textBoxVuelto
            // 
            this.textBoxVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVuelto.Location = new System.Drawing.Point(490, 408);
            this.textBoxVuelto.Name = "textBoxVuelto";
            this.textBoxVuelto.ReadOnly = true;
            this.textBoxVuelto.Size = new System.Drawing.Size(99, 23);
            this.textBoxVuelto.TabIndex = 28;
            this.textBoxVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEntrega
            // 
            this.textBoxEntrega.AcceptsReturn = true;
            this.textBoxEntrega.AcceptsTab = true;
            this.textBoxEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEntrega.Location = new System.Drawing.Point(310, 408);
            this.textBoxEntrega.Name = "textBoxEntrega";
            this.textBoxEntrega.Size = new System.Drawing.Size(110, 23);
            this.textBoxEntrega.TabIndex = 27;
            this.textBoxEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxEntrega.TextChanged += new System.EventHandler(this.textBoxEntrega_TextChanged);
            // 
            // textBoxFechaFin
            // 
            this.textBoxFechaFin.Location = new System.Drawing.Point(413, 171);
            this.textBoxFechaFin.Name = "textBoxFechaFin";
            this.textBoxFechaFin.ReadOnly = true;
            this.textBoxFechaFin.Size = new System.Drawing.Size(163, 20);
            this.textBoxFechaFin.TabIndex = 25;
            this.textBoxFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFechaInicio
            // 
            this.textBoxFechaInicio.Location = new System.Drawing.Point(146, 168);
            this.textBoxFechaInicio.Name = "textBoxFechaInicio";
            this.textBoxFechaInicio.ReadOnly = true;
            this.textBoxFechaInicio.Size = new System.Drawing.Size(135, 20);
            this.textBoxFechaInicio.TabIndex = 24;
            this.textBoxFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDatosVehiculo
            // 
            this.textBoxDatosVehiculo.Location = new System.Drawing.Point(146, 139);
            this.textBoxDatosVehiculo.Name = "textBoxDatosVehiculo";
            this.textBoxDatosVehiculo.ReadOnly = true;
            this.textBoxDatosVehiculo.Size = new System.Drawing.Size(430, 20);
            this.textBoxDatosVehiculo.TabIndex = 20;
            // 
            // textBoxClienteNombre
            // 
            this.textBoxClienteNombre.Location = new System.Drawing.Point(146, 76);
            this.textBoxClienteNombre.Name = "textBoxClienteNombre";
            this.textBoxClienteNombre.ReadOnly = true;
            this.textBoxClienteNombre.Size = new System.Drawing.Size(429, 20);
            this.textBoxClienteNombre.TabIndex = 19;
            // 
            // textBoxPolizaNro
            // 
            this.textBoxPolizaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPolizaNro.Location = new System.Drawing.Point(149, 6);
            this.textBoxPolizaNro.Name = "textBoxPolizaNro";
            this.textBoxPolizaNro.ReadOnly = true;
            this.textBoxPolizaNro.Size = new System.Drawing.Size(163, 29);
            this.textBoxPolizaNro.TabIndex = 15;
            this.textBoxPolizaNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnModPolizaTabDetalles
            // 
            this.btnModPolizaTabDetalles.Location = new System.Drawing.Point(838, 440);
            this.btnModPolizaTabDetalles.Name = "btnModPolizaTabDetalles";
            this.btnModPolizaTabDetalles.Size = new System.Drawing.Size(108, 25);
            this.btnModPolizaTabDetalles.TabIndex = 32;
            this.btnModPolizaTabDetalles.Text = "Modificar Póliza";
            this.btnModPolizaTabDetalles.UseVisualStyleBackColor = true;
            // 
            // btnVolverTabDetallePoliza
            // 
            this.btnVolverTabDetallePoliza.Location = new System.Drawing.Point(624, 405);
            this.btnVolverTabDetallePoliza.Name = "btnVolverTabDetallePoliza";
            this.btnVolverTabDetallePoliza.Size = new System.Drawing.Size(70, 25);
            this.btnVolverTabDetallePoliza.TabIndex = 31;
            this.btnVolverTabDetallePoliza.Text = "Volver";
            this.btnVolverTabDetallePoliza.UseVisualStyleBackColor = true;
            this.btnVolverTabDetallePoliza.Click += new System.EventHandler(this.btnVolverTabDetallePoliza_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(434, 411);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(52, 17);
            this.label56.TabIndex = 14;
            this.label56.Text = "Vuelto:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(247, 411);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(58, 17);
            this.label54.TabIndex = 12;
            this.label54.Text = "Entrega";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(36, 171);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(112, 13);
            this.label51.TabIndex = 9;
            this.label51.Text = "Fecha Inicio Vigencia:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(345, 174);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(68, 13);
            this.label50.TabIndex = 8;
            this.label50.Text = "Fin Vigencia:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(57, 141);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(79, 13);
            this.label46.TabIndex = 4;
            this.label46.Text = "Datos Vehiculo";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(47, 81);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 13);
            this.label45.TabIndex = 3;
            this.label45.Text = "Apellido y Nombre:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(46, 8);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(101, 24);
            this.label44.TabIndex = 2;
            this.label44.Text = "Póliza Nro:";
            this.label44.Click += new System.EventHandler(this.label44_Click);
            // 
            // PagoPolizaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 530);
            this.Controls.Add(this.tabControlPagoPoliza);
            this.Controls.Add(this.TituloPanelPoliza);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnVolver);
            this.Name = "PagoPolizaForm";
            this.Text = "Registrar Pago Poliza";
            this.tabBusquedaPoliza.ResumeLayout(false);
            this.tabBusquedaPoliza.PerformLayout();
            this.tabControlPagoPoliza.ResumeLayout(false);
            this.tabDetallesPoliza.ResumeLayout(false);
            this.tabDetallesPoliza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuotasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloPanelPoliza;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TabPage tabBusquedaPoliza;
        private System.Windows.Forms.Button btnVolverTabBusquedaPoliza;
        private System.Windows.Forms.TextBox textPolizaNroBusquedaPoliza;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabControl tabControlPagoPoliza;
        private System.Windows.Forms.Button btnBusquedaPoliza;
        private System.Windows.Forms.TabPage tabDetallesPoliza;
        private System.Windows.Forms.TextBox textBoxVuelto;
        private System.Windows.Forms.TextBox textBoxEntrega;
        private System.Windows.Forms.TextBox textBoxFechaFin;
        private System.Windows.Forms.TextBox textBoxFechaInicio;
        private System.Windows.Forms.TextBox textBoxDatosVehiculo;
        private System.Windows.Forms.TextBox textBoxClienteNombre;
        private System.Windows.Forms.TextBox textBoxPolizaNro;
        private System.Windows.Forms.Button btnModPolizaTabDetalles;
        private System.Windows.Forms.Button btnVolverTabDetallePoliza;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxClienteDNI;
        private System.Windows.Forms.TextBox textBoxNroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCuotasPendientesPago;
        private System.Windows.Forms.Button btnEmitirReciboPago;
        private System.Windows.Forms.DataGridView dataGridViewCuotasPendientes;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRevDiaPago1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNroPolizaSec;
        private System.Windows.Forms.TextBox textBoxNroPolizaSuc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSeleccion;
        private System.Windows.Forms.TextBox textBoxAPagar;
        private System.Windows.Forms.Label label4;
    }
}