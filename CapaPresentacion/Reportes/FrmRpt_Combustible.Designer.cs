namespace CapaPresentacion
{
    partial class FrmRpt_Combustible
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSReportes = new CapaPresentacion.DSReportes();
            this.uPCONSULTACOMBUSTIBLEFECHABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uP_CONSULTA_COMBUSTIBLE_FECHATableAdapter = new CapaPresentacion.DSReportesTableAdapters.UP_CONSULTA_COMBUSTIBLE_FECHATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPCONSULTACOMBUSTIBLEFECHABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsCombustible";
            reportDataSource1.Value = this.uPCONSULTACOMBUSTIBLEFECHABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Rpt_Combustible.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(542, 410);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSReportes
            // 
            this.dSReportes.DataSetName = "DSReportes";
            this.dSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uPCONSULTACOMBUSTIBLEFECHABindingSource
            // 
            this.uPCONSULTACOMBUSTIBLEFECHABindingSource.DataMember = "UP_CONSULTA_COMBUSTIBLE_FECHA";
            this.uPCONSULTACOMBUSTIBLEFECHABindingSource.DataSource = this.dSReportes;
            // 
            // uP_CONSULTA_COMBUSTIBLE_FECHATableAdapter
            // 
            this.uP_CONSULTA_COMBUSTIBLE_FECHATableAdapter.ClearBeforeFill = true;
            // 
            // RptCombustible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 410);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Combustible";
            this.Text = "FrmRpt_Combustible";
            this.Load += new System.EventHandler(this.FrmRpt_Combustible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uPCONSULTACOMBUSTIBLEFECHABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uPCONSULTACOMBUSTIBLEFECHABindingSource;
        private DSReportes dSReportes;
        private DSReportesTableAdapters.UP_CONSULTA_COMBUSTIBLE_FECHATableAdapter uP_CONSULTA_COMBUSTIBLE_FECHATableAdapter;
    }
}