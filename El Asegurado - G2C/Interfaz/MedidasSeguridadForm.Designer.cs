namespace Interfaz
{
    partial class MedidasSeguridadForm
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
            this.btnAceptar_gestMedSEg = new System.Windows.Forms.Button();
            this.btncheckGarage = new System.Windows.Forms.CheckBox();
            this.btncheckTuercas = new System.Windows.Forms.CheckBox();
            this.btncheckRastreo = new System.Windows.Forms.CheckBox();
            this.btncheckAlarma = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAceptar_gestMedSEg
            // 
            this.btnAceptar_gestMedSEg.Location = new System.Drawing.Point(278, 160);
            this.btnAceptar_gestMedSEg.Name = "btnAceptar_gestMedSEg";
            this.btnAceptar_gestMedSEg.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar_gestMedSEg.TabIndex = 5;
            this.btnAceptar_gestMedSEg.Text = "Aceptar";
            this.btnAceptar_gestMedSEg.UseVisualStyleBackColor = true;
            this.btnAceptar_gestMedSEg.Click += new System.EventHandler(this.BtnAceptar_gestMedSEg_Click);
            // 
            // btncheckGarage
            // 
            this.btncheckGarage.AutoSize = true;
            this.btncheckGarage.Location = new System.Drawing.Point(26, 16);
            this.btncheckGarage.Name = "btncheckGarage";
            this.btncheckGarage.Size = new System.Drawing.Size(132, 17);
            this.btncheckGarage.TabIndex = 1;
            this.btncheckGarage.Text = "Se guarda en garage?";
            this.btncheckGarage.UseVisualStyleBackColor = true;
            // 
            // btncheckTuercas
            // 
            this.btncheckTuercas.AutoSize = true;
            this.btncheckTuercas.Location = new System.Drawing.Point(26, 114);
            this.btncheckTuercas.Name = "btncheckTuercas";
            this.btncheckTuercas.Size = new System.Drawing.Size(175, 17);
            this.btncheckTuercas.TabIndex = 4;
            this.btncheckTuercas.Text = "Posee tuercas en las 4 ruedas?";
            this.btncheckTuercas.UseVisualStyleBackColor = true;
            // 
            // btncheckRastreo
            // 
            this.btncheckRastreo.AutoSize = true;
            this.btncheckRastreo.Location = new System.Drawing.Point(26, 81);
            this.btncheckRastreo.Name = "btncheckRastreo";
            this.btncheckRastreo.Size = new System.Drawing.Size(135, 17);
            this.btncheckRastreo.TabIndex = 3;
            this.btncheckRastreo.Text = "Posee rastreo satelital?";
            this.btncheckRastreo.UseVisualStyleBackColor = true;
            // 
            // btncheckAlarma
            // 
            this.btncheckAlarma.AutoSize = true;
            this.btncheckAlarma.Location = new System.Drawing.Point(26, 46);
            this.btncheckAlarma.Name = "btncheckAlarma";
            this.btncheckAlarma.Size = new System.Drawing.Size(93, 17);
            this.btncheckAlarma.TabIndex = 2;
            this.btncheckAlarma.Text = "Tiene alarma?";
            this.btncheckAlarma.UseVisualStyleBackColor = true;
            // 
            // MedidasSeguridadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 197);
            this.Controls.Add(this.btncheckAlarma);
            this.Controls.Add(this.btncheckRastreo);
            this.Controls.Add(this.btncheckTuercas);
            this.Controls.Add(this.btncheckGarage);
            this.Controls.Add(this.btnAceptar_gestMedSEg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MedidasSeguridadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Medidas de Seguridad";
            this.Load += new System.EventHandler(this.MedidasSeguridadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar_gestMedSEg;
        private System.Windows.Forms.CheckBox btncheckGarage;
        private System.Windows.Forms.CheckBox btncheckTuercas;
        private System.Windows.Forms.CheckBox btncheckRastreo;
        private System.Windows.Forms.CheckBox btncheckAlarma;
    }
}