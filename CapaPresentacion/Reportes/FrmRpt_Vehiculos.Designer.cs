namespace CapaPresentacion
{
    partial class FrmRpt_Vehiculos
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
            this.DSReportes = new CapaPresentacion.DSReportes();
            this.UP_REPORTE_VEHICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UP_REPORTE_VEHICULOSTableAdapter = new CapaPresentacion.DSReportesTableAdapters.UP_REPORTE_VEHICULOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UP_REPORTE_VEHICULOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsVehiculos";
            reportDataSource1.Value = this.UP_REPORTE_VEHICULOSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Rpt_Vehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(515, 403);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UP_REPORTE_VEHICULOSBindingSource
            // 
            this.UP_REPORTE_VEHICULOSBindingSource.DataMember = "UP_REPORTE_VEHICULOS";
            this.UP_REPORTE_VEHICULOSBindingSource.DataSource = this.DSReportes;
            // 
            // UP_REPORTE_VEHICULOSTableAdapter
            // 
            this.UP_REPORTE_VEHICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRpt_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 403);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Vehiculos";
            this.Text = "FrmRpt_Vehiculos";
            this.Load += new System.EventHandler(this.FrmRpt_Vehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UP_REPORTE_VEHICULOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UP_REPORTE_VEHICULOSBindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.UP_REPORTE_VEHICULOSTableAdapter UP_REPORTE_VEHICULOSTableAdapter;
    }
}