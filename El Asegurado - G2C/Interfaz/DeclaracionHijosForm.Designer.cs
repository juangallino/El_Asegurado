namespace Interfaz
{
    partial class DeclaracionHijosForm
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
            this.btnAceptar_declaracionH = new System.Windows.Forms.Button();
            this.HijosGridView = new System.Windows.Forms.DataGridView();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerDeclaH = new System.Windows.Forms.DateTimePicker();
            this.comboBoxEstadoCivilDeclaH = new System.Windows.Forms.ComboBox();
            this.estadoCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTP2019DataSet = new Interfaz.DBTP2019DataSet();
            this.comboBoxSexoDeclaH = new System.Windows.Forms.ComboBox();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.sexoTableAdapter = new Interfaz.DBTP2019DataSetTableAdapters.SexoTableAdapter();
            this.estadoCivilTableAdapter = new Interfaz.DBTP2019DataSetTableAdapters.EstadoCivilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HijosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTP2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar_declaracionH
            // 
            this.btnAceptar_declaracionH.Location = new System.Drawing.Point(251, 431);
            this.btnAceptar_declaracionH.Name = "btnAceptar_declaracionH";
            this.btnAceptar_declaracionH.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar_declaracionH.TabIndex = 6;
            this.btnAceptar_declaracionH.Text = "Aceptar";
            this.btnAceptar_declaracionH.UseVisualStyleBackColor = true;
            this.btnAceptar_declaracionH.Click += new System.EventHandler(this.BtnAceptar_declaracionH_Click);
            // 
            // HijosGridView
            // 
            this.HijosGridView.AllowUserToAddRows = false;
            this.HijosGridView.AllowUserToDeleteRows = false;
            this.HijosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HijosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaNac,
            this.Sexo,
            this.EstadoCivil,
            this.Hijo});
            this.HijosGridView.Location = new System.Drawing.Point(12, 216);
            this.HijosGridView.Name = "HijosGridView";
            this.HijosGridView.ReadOnly = true;
            this.HijosGridView.Size = new System.Drawing.Size(352, 190);
            this.HijosGridView.TabIndex = 3;
            this.HijosGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HijosGridView_CellClick);
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            // 
            // Hijo
            // 
            this.Hijo.HeaderText = "id hijo";
            this.Hijo.Name = "Hijo";
            this.Hijo.ReadOnly = true;
            this.Hijo.Visible = false;
            // 
            // dateTimePickerDeclaH
            // 
            this.dateTimePickerDeclaH.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerDeclaH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeclaH.Location = new System.Drawing.Point(158, 34);
            this.dateTimePickerDeclaH.MaxDate = new System.DateTime(2019, 11, 24, 23, 59, 59, 0);
            this.dateTimePickerDeclaH.Name = "dateTimePickerDeclaH";
            this.dateTimePickerDeclaH.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerDeclaH.TabIndex = 1;
            this.dateTimePickerDeclaH.Value = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
            this.dateTimePickerDeclaH.ValueChanged += new System.EventHandler(this.DateTimePickerDeclaH_ValueChanged);
            // 
            // comboBoxEstadoCivilDeclaH
            // 
            this.comboBoxEstadoCivilDeclaH.DataSource = this.estadoCivilBindingSource;
            this.comboBoxEstadoCivilDeclaH.DisplayMember = "nombre";
            this.comboBoxEstadoCivilDeclaH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoCivilDeclaH.FormattingEnabled = true;
            this.comboBoxEstadoCivilDeclaH.Location = new System.Drawing.Point(158, 123);
            this.comboBoxEstadoCivilDeclaH.Name = "comboBoxEstadoCivilDeclaH";
            this.comboBoxEstadoCivilDeclaH.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstadoCivilDeclaH.TabIndex = 3;
            this.comboBoxEstadoCivilDeclaH.ValueMember = "id";
            // 
            // estadoCivilBindingSource
            // 
            this.estadoCivilBindingSource.DataMember = "EstadoCivil";
            this.estadoCivilBindingSource.DataSource = this.dBTP2019DataSet;
            // 
            // dBTP2019DataSet
            // 
            this.dBTP2019DataSet.DataSetName = "DBTP2019DataSet";
            this.dBTP2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSexoDeclaH
            // 
            this.comboBoxSexoDeclaH.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sexoBindingSource, "id", true));
            this.comboBoxSexoDeclaH.DataSource = this.sexoBindingSource1;
            this.comboBoxSexoDeclaH.DisplayMember = "nombre";
            this.comboBoxSexoDeclaH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexoDeclaH.FormattingEnabled = true;
            this.comboBoxSexoDeclaH.Location = new System.Drawing.Point(158, 80);
            this.comboBoxSexoDeclaH.Name = "comboBoxSexoDeclaH";
            this.comboBoxSexoDeclaH.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSexoDeclaH.TabIndex = 2;
            this.comboBoxSexoDeclaH.ValueMember = "id";
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "Sexo";
            this.sexoBindingSource.DataSource = this.dBTP2019DataSet;
            // 
            // sexoBindingSource1
            // 
            this.sexoBindingSource1.DataMember = "Sexo";
            this.sexoBindingSource1.DataSource = this.dBTP2019DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado Civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sexo";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(251, 174);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(152, 174);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // estadoCivilTableAdapter
            // 
            this.estadoCivilTableAdapter.ClearBeforeFill = true;
            // 
            // DeclaracionHijosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 482);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSexoDeclaH);
            this.Controls.Add(this.comboBoxEstadoCivilDeclaH);
            this.Controls.Add(this.dateTimePickerDeclaH);
            this.Controls.Add(this.HijosGridView);
            this.Controls.Add(this.btnAceptar_declaracionH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DeclaracionHijosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Declaracion de Hijos entre 18 y 30 años";
            this.Load += new System.EventHandler(this.DeclaracionHijosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HijosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTP2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar_declaracionH;
        private System.Windows.Forms.DataGridView HijosGridView;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeclaH;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivilDeclaH;
        private System.Windows.Forms.ComboBox comboBoxSexoDeclaH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private DBTP2019DataSet dBTP2019DataSet;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private DBTP2019DataSetTableAdapters.SexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.BindingSource estadoCivilBindingSource;
        private DBTP2019DataSetTableAdapters.EstadoCivilTableAdapter estadoCivilTableAdapter;
        private System.Windows.Forms.BindingSource sexoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hijo;
    }
}