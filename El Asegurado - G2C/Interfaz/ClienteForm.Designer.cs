﻿namespace Interfaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelcliente = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.tabPageNuevoCliente = new System.Windows.Forms.TabPage();
            this.tabPageBuscarCliente = new System.Windows.Forms.TabPage();
            this.btnBuscarClienteCliente = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.panelcliente.SuspendLayout();
            this.tabControlCliente.SuspendLayout();
            this.tabPageBuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CLIENTE";
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
            this.tabPageBuscarCliente.Controls.Add(this.dataGridView2);
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
            // dataGridView2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(31, 179);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.Size = new System.Drawing.Size(937, 150);
            this.dataGridView2.TabIndex = 39;
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
            this.textBoxNroDocumento.TextChanged += new System.EventHandler(this.textBoxNroDocumento_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(171, 113);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(205, 20);
            this.textBoxNombre.TabIndex = 31;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombreCliente_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(171, 72);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(205, 20);
            this.textBoxApellido.TabIndex = 30;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellidoCliente_TextChanged);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(171, 33);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(205, 20);
            this.textBoxIdCliente.TabIndex = 29;
            this.textBoxIdCliente.TextChanged += new System.EventHandler(this.textBoxIdCliente_TextChanged);
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
            this.panelcliente.ResumeLayout(false);
            this.panelcliente.PerformLayout();
            this.tabControlCliente.ResumeLayout(false);
            this.tabPageBuscarCliente.ResumeLayout(false);
            this.tabPageBuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageNuevoCliente;
        private System.Windows.Forms.TabPage tabPageBuscarCliente;
        private System.Windows.Forms.Button btnBuscarClienteCliente;
        private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}