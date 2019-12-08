namespace Interfaz
{
    partial class ClienteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.tabPageNuevoCliente = new System.Windows.Forms.TabPage();
            this.tabPageBuscarCliente = new System.Windows.Forms.TabPage();
            this.btnBuscarClienteCliente = new System.Windows.Forms.Button();
            this.dataGridBusquedaCliente = new System.Windows.Forms.DataGridView();
            this.label53 = new System.Windows.Forms.Label();
            this.comboBoxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.textBoxNroDocumento = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tabPageDetalleCliente = new System.Windows.Forms.TabPage();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.dBTP2019DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTP2019DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelcliente.SuspendLayout();
            this.tabControlCliente.SuspendLayout();
            this.tabPageBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusquedaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTP2019DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTP2019DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcliente
            // 
            this.panelcliente.AutoSize = true;
            this.panelcliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelcliente.Controls.Add(this.label1);
            this.panelcliente.Controls.Add(this.tabControlCliente);
            this.panelcliente.Controls.Add(this.btnNuevoCliente);
            this.panelcliente.Controls.Add(this.btnConsultarCliente);
            this.panelcliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcliente.Location = new System.Drawing.Point(0, 0);
            this.panelcliente.Name = "panelcliente";
            this.panelcliente.Size = new System.Drawing.Size(1119, 543);
            this.panelcliente.TabIndex = 10;
            this.panelcliente.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcliente_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(596, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.tabPageNuevoCliente);
            this.tabControlCliente.Controls.Add(this.tabPageBuscarCliente);
            this.tabControlCliente.Controls.Add(this.tabPageDetalleCliente);
            this.tabControlCliente.Location = new System.Drawing.Point(3, 52);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(1039, 495);
            this.tabControlCliente.TabIndex = 7;
            this.tabControlCliente.SelectedIndexChanged += new System.EventHandler(this.tabControlCliente_SelectedIndexChanged);
            this.tabControlCliente.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlCliente_Selected);
            // 
            // tabPageNuevoCliente
            // 
            this.tabPageNuevoCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPageNuevoCliente.Name = "tabPageNuevoCliente";
            this.tabPageNuevoCliente.Size = new System.Drawing.Size(1031, 469);
            this.tabPageNuevoCliente.TabIndex = 2;
            this.tabPageNuevoCliente.Text = "Nuevo";
            this.tabPageNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // tabPageBuscarCliente
            // 
            this.tabPageBuscarCliente.Controls.Add(this.btnBuscarClienteCliente);
            this.tabPageBuscarCliente.Controls.Add(this.dataGridBusquedaCliente);
            this.tabPageBuscarCliente.Controls.Add(this.label53);
            this.tabPageBuscarCliente.Controls.Add(this.comboBoxTipoDocumento);
            this.tabPageBuscarCliente.Controls.Add(this.textBoxNroDocumento);
            this.tabPageBuscarCliente.Controls.Add(this.textBoxNombre);
            this.tabPageBuscarCliente.Controls.Add(this.textBoxApellido);
            this.tabPageBuscarCliente.Controls.Add(this.textBoxIdCliente);
            this.tabPageBuscarCliente.Controls.Add(this.label57);
            this.tabPageBuscarCliente.Controls.Add(this.label59);
            this.tabPageBuscarCliente.Controls.Add(this.label60);
            this.tabPageBuscarCliente.Controls.Add(this.label63);
            this.tabPageBuscarCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarCliente.Name = "tabPageBuscarCliente";
            this.tabPageBuscarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarCliente.Size = new System.Drawing.Size(1031, 469);
            this.tabPageBuscarCliente.TabIndex = 0;
            this.tabPageBuscarCliente.Text = "Buscar";
            this.tabPageBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnBuscarClienteCliente
            // 
            this.btnBuscarClienteCliente.Location = new System.Drawing.Point(667, 91);
            this.btnBuscarClienteCliente.Name = "btnBuscarClienteCliente";
            this.btnBuscarClienteCliente.Size = new System.Drawing.Size(103, 29);
            this.btnBuscarClienteCliente.TabIndex = 40;
            this.btnBuscarClienteCliente.Text = "Buscar";
            this.btnBuscarClienteCliente.UseVisualStyleBackColor = true;
            this.btnBuscarClienteCliente.Click += new System.EventHandler(this.btnBuscarClienteCliente_Click);
            // 
            // dataGridBusquedaCliente
            // 
            this.dataGridBusquedaCliente.AllowUserToAddRows = false;
            this.dataGridBusquedaCliente.AllowUserToDeleteRows = false;
            this.dataGridBusquedaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBusquedaCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridBusquedaCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusquedaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridBusquedaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBusquedaCliente.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridBusquedaCliente.Location = new System.Drawing.Point(79, 180);
            this.dataGridBusquedaCliente.Name = "dataGridBusquedaCliente";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusquedaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridBusquedaCliente.RowTemplate.ReadOnly = true;
            this.dataGridBusquedaCliente.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBusquedaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBusquedaCliente.Size = new System.Drawing.Size(868, 150);
            this.dataGridBusquedaCliente.TabIndex = 39;
            this.dataGridBusquedaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBusquedaCliente_CellClick_1);
            this.dataGridBusquedaCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBusquedaCliente_CellContentClick);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(526, 35);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(89, 13);
            this.label53.TabIndex = 38;
            this.label53.Text = "Tipo Documento:";
            // 
            // comboBoxTipoDocumento
            // 
            this.comboBoxTipoDocumento.FormattingEnabled = true;
            this.comboBoxTipoDocumento.Location = new System.Drawing.Point(619, 30);
            this.comboBoxTipoDocumento.Name = "comboBoxTipoDocumento";
            this.comboBoxTipoDocumento.Size = new System.Drawing.Size(60, 21);
            this.comboBoxTipoDocumento.TabIndex = 37;
            this.comboBoxTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDocumento_SelectedIndexChanged);
            // 
            // textBoxNroDocumento
            // 
            this.textBoxNroDocumento.Location = new System.Drawing.Point(743, 31);
            this.textBoxNroDocumento.Name = "textBoxNroDocumento";
            this.textBoxNroDocumento.Size = new System.Drawing.Size(136, 20);
            this.textBoxNroDocumento.TabIndex = 36;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(171, 113);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(205, 20);
            this.textBoxNombre.TabIndex = 31;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(171, 72);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(205, 20);
            this.textBoxApellido.TabIndex = 30;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(171, 33);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(205, 20);
            this.textBoxIdCliente.TabIndex = 29;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(76, 74);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(47, 13);
            this.label57.TabIndex = 26;
            this.label57.Text = "Apellido:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(692, 35);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(47, 13);
            this.label59.TabIndex = 24;
            this.label59.Text = "Número:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(76, 116);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 13);
            this.label60.TabIndex = 23;
            this.label60.Text = "Nombre:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(76, 33);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(82, 13);
            this.label63.TabIndex = 20;
            this.label63.Text = "Cliente Número:";
            // 
            // tabPageDetalleCliente
            // 
            this.tabPageDetalleCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetalleCliente.Name = "tabPageDetalleCliente";
            this.tabPageDetalleCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetalleCliente.Size = new System.Drawing.Size(1031, 469);
            this.tabPageDetalleCliente.TabIndex = 1;
            this.tabPageDetalleCliente.Text = "Detalle";
            this.tabPageDetalleCliente.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(21, 12);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(78, 24);
            this.btnNuevoCliente.TabIndex = 5;
            this.btnNuevoCliente.Text = "Nuevo";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(105, 12);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(78, 24);
            this.btnConsultarCliente.TabIndex = 6;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 543);
            this.Controls.Add(this.panelcliente);
            this.Name = "ClienteForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.panelcliente.ResumeLayout(false);
            this.tabControlCliente.ResumeLayout(false);
            this.tabPageBuscarCliente.ResumeLayout(false);
            this.tabPageBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBusquedaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTP2019DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTP2019DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcliente;
        private System.Windows.Forms.TabPage tabPageNuevoCliente;
        private System.Windows.Forms.TabPage tabPageBuscarCliente;
        private System.Windows.Forms.Button btnBuscarClienteCliente;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.ComboBox comboBoxTipoDocumento;
        private System.Windows.Forms.TextBox textBoxNroDocumento;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TabPage tabPageDetalleCliente;
        public System.Windows.Forms.TabControl tabControlCliente;
        public System.Windows.Forms.Button btnNuevoCliente;
        public System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.DataGridView dataGridBusquedaCliente;
        private System.Windows.Forms.BindingSource dBTP2019DataSetBindingSource;
       // private DBTP2019DataSet dBTP2019DataSet;
        private System.Windows.Forms.BindingSource dBTP2019DataSetBindingSource1;
        private System.Windows.Forms.Label label1;
    }
}