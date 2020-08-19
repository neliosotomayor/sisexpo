using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class FrmRpt_SOAT : Form
    {
        Funciones cFuncion = new Funciones();

        private String _FechaDesde;
        private String _FechaHasta;
        private int _VehiculoId;
        private string _Filtro;

        public string FechaDesde
        {
            get { return _FechaDesde; }
            set { _FechaDesde = value; }
        }

        public string FechaHasta
        {
            get { return _FechaHasta; }
            set { _FechaHasta = value; }
        }

        public int VehiculoId
        {
            get { return _VehiculoId; }
            set { _VehiculoId = value; }
        }

        public string Filtro
        {
            get { return _Filtro; }
            set { _Filtro = value; }
        }

        public FrmRpt_SOAT()
        {
            InitializeComponent();
        }

        private void FrmRpt_SOAT_Load(object sender, EventArgs e)
        {
            try
            {
                ReportParameter[] pParametros = new ReportParameter[1];
                pParametros[0] = new ReportParameter("pFiltro", Filtro);
                reportViewer1.LocalReport.SetParameters(pParametros);

                this.UP_CONSULTA_VEHICULOS_SOATTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
                this.UP_CONSULTA_VEHICULOS_SOATTableAdapter.Fill(this.DSReportes.UP_CONSULTA_VEHICULOS_SOAT, FechaDesde, FechaHasta, VehiculoId);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                cFuncion.MensajeError(ex.Message.ToString());
                this.reportViewer1.RefreshReport();
            }
        }

    }
}
