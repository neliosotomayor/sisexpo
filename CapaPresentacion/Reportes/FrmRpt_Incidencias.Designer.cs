namespace CapaPresentacion
{
    partial class FrmRpt_Incidencias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSReportes = new CapaPresentacion.DSReportes();
            this.UP_CONSULTA_INCIDENCIAS_FECHABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UP_CONSULTA_INCIDENCIAS_FECHATableAdapter = new CapaPresentacion.DSReportesTableAdapters.UP_CONSULTA_INCIDENCIAS_FECHATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UP_CONSULTA_INCIDENCIAS_FECHABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dsIncidencias";
            reportDataSource2.Value = this.UP_CONSULTA_INCIDENCIAS_FECHABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Rpt_Incidencias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(482, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UP_CONSULTA_INCIDENCIAS_FECHABindingSource
            // 
            this.UP_CONSULTA_INCIDENCIAS_FECHABindingSource.DataMember = "UP_CONSULTA_INCIDENCIAS_FECHA";
            this.UP_CONSULTA_INCIDENCIAS_FECHABindingSource.DataSource = this.DSReportes;
            // 
            // UP_CONSULTA_INCIDENCIAS_FECHATableAdapter
            // 
            this.UP_CONSULTA_INCIDENCIAS_FECHATableAdapter.ClearBeforeFill = true;
            // 
            // FrmRpt_Incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 355);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Incidencias";
            this.Text = "FrmRpt_Incidencias";
            this.Load += new System.EventHandler(this.FrmRpt_Incidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UP_CONSULTA_INCIDENCIAS_FECHABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UP_CONSULTA_INCIDENCIAS_FECHABindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.UP_CONSULTA_INCIDENCIAS_FECHATableAdapter UP_CONSULTA_INCIDENCIAS_FECHATableAdapter;
    }
}