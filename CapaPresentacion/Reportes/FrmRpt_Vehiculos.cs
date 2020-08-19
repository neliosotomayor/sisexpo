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

namespace CapaPresentacion
{
    public partial class FrmRpt_Vehiculos : Form
    {
        Funciones cFuncion = new Funciones();

        public FrmRpt_Vehiculos()
        {
            InitializeComponent();
        }

        private void FrmRpt_Vehiculos_Load(object sender, EventArgs e)
        {
            try
            {
                this.UP_REPORTE_VEHICULOSTableAdapter.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
                this.UP_REPORTE_VEHICULOSTableAdapter.Fill(this.DSReportes.UP_REPORTE_VEHICULOS);
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
