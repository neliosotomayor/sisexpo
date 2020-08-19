namespace CapaPresentacion
{
    partial class FrmRpt_Mantenimientos
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
            this.UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UP_CONSULTA_MANTENIMIENTOS_FECHATableAdapter = new CapaPresentacion.DSReportesTableAdapters.UP_CONSULTA_MANTENIMIENTOS_FECHATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsMantenimientos";
            reportDataSource1.Value = this.UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.Rpt_Mantenimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(481, 333);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSReportes
            // 
            this.DSReportes.DataSetName = "DSReportes";
            this.DSReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource
            // 
            this.UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource.DataMember = "UP_CONSULTA_MANTENIMIENTOS_FECHA";
            this.UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource.DataSource = this.DSReportes;
            // 
            // UP_CONSULTA_MANTENIMIENTOS_FECHATableAdapter
            // 
            this.UP_CONSULTA_MANTENIMIENTOS_FECHATableAdapter.ClearBeforeFill = true;
            // 
            // FrmRpt_Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 333);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRpt_Mantenimientos";
            this.Text = "FrmRpt_Mantenimientos";
            this.Load += new System.EventHandler(this.FrmRpt_Mantenimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UP_CONSULTA_MANTENIMIENTOS_FECHABindingSource;
        private DSReportes DSReportes;
        private DSReportesTableAdapters.UP_CONSULTA_MANTENIMIENTOS_FECHATableAdapter UP_CONSULTA_MANTENIMIENTOS_FECHATableAdapter;
    }
}