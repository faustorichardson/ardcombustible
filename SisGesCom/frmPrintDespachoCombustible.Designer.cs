﻿namespace SisGesCom
{
    partial class frmPrintDespachoCombustible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintDespachoCombustible));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDepartamentos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTituloForm
            // 
            this.lblTituloForm.Size = new System.Drawing.Size(428, 22);
            this.lblTituloForm.Text = "Genera Reporte Despacho Combustible (Resumido)";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(455, 103);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 45);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(455, 43);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 45);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "Generar";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(119, 146);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(215, 20);
            this.dtHasta.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "HASTA:";
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(119, 110);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(215, 20);
            this.dtDesde.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DESDE:";
            // 
            // chkDepartamentos
            // 
            this.chkDepartamentos.AutoSize = true;
            this.chkDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDepartamentos.Location = new System.Drawing.Point(120, 50);
            this.chkDepartamentos.Name = "chkDepartamentos";
            this.chkDepartamentos.Size = new System.Drawing.Size(163, 17);
            this.chkDepartamentos.TabIndex = 28;
            this.chkDepartamentos.Text = "Filtrar por Departamento";
            this.chkDepartamentos.UseVisualStyleBackColor = true;
            this.chkDepartamentos.CheckedChanged += new System.EventHandler(this.chkDepartamentos_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "DEPENDENCIA:";
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Location = new System.Drawing.Point(120, 76);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(283, 21);
            this.cmbCombustible.TabIndex = 26;
            // 
            // frmPrintDespachoCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 195);
            this.Controls.Add(this.chkDepartamentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCombustible);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.label1);
            this.Name = "frmPrintDespachoCombustible";
            this.Text = "frmPrintDespachoCombustible";
            this.Load += new System.EventHandler(this.frmPrintDespachoCombustible_Load);
            this.Controls.SetChildIndex(this.lblTituloForm, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dtDesde, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.dtHasta, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.cmbCombustible, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.chkDepartamentos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDepartamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCombustible;
    }
}