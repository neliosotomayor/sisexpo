using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using DevExpress.XtraGrid.Views.Grid;

namespace CapaPresentacion
{
    public partial class FrmConsultaExpo : Form
    {
        #region MueveFormularioNuevo

        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        // función privada usada para mover el formulario actual

        private void MueveFormularioNuevo()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }

        #endregion

        #region Variables

        readonly Funciones cFuncion = new Funciones();

        private static FrmConsultaExpo _instance;

        CEExportacionSaldo objEntidad = new CEExportacionSaldo();
        CNExportacionSaldo objNegocio = new CNExportacionSaldo();

        CEExportacionDetalle objEntidadExportacionDetalle = new CEExportacionDetalle();
        CNExportacionDetalle objNegocioExportacionDetalle = new CNExportacionDetalle();

        CNNotaCredito objNotaCredito = new CNNotaCredito();
        CNAbono objAbono = new CNAbono();

        CNPuerto objPuerto = new CNPuerto();
        CNProductoPresentacion objProductoPresentacion = new CNProductoPresentacion();

        List<CEExportacionSaldo> lstExportaciones = new List<CEExportacionSaldo>();

        List<CEExportacionDetalle> lstDetalleExportaciones = new List<CEExportacionDetalle>();

        #endregion

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            
            lstExportaciones = objNegocio.MostrarExportacionesSaldos(sBuscar);

            lstDetalleExportaciones = objNegocioExportacionDetalle.MostrarExportacionesDetalle(0);
            
            //grdCabeceraDetalle.DataSource = lstCab;

            //foreach (CEExportacion Exportacion in lstCab)
            //{
            //    Exportacion.lstDetalle = lstDet.FindAll(c => c.Exportacion_Id == Exportacion.Exp_Id);
            //}

            grdCabeceraDetalle.DataSource = lstExportaciones;
            grdCabeceraDetalle.Refresh();
        }

        private void LimpiarControles()
        {
            ToolStripStatusLabel2.Text = "";
            ToolStripStatusLabel4.Text = "";
            ToolStripStatusLabel6.Text = "";
            ToolStripStatusLabel8.Text = "";
        }

        private void MostrarAuditoria()
        {
            //Usuario_Creacion = dgvDatos.GetString(4);
            //Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
            //Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
            //Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)

            //ToolStripStatusLabel2.Text = dgvExportaciones.CurrentRow.Cells[25].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[25].Value.ToString();
            //ToolStripStatusLabel4.Text = dgvExportaciones.CurrentRow.Cells[26].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[26].Value.ToString();
            //ToolStripStatusLabel6.Text = dgvExportaciones.CurrentRow.Cells[27].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[27].Value.ToString();
            //ToolStripStatusLabel8.Text = dgvExportaciones.CurrentRow.Cells[28].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[28].Value.ToString();
        }

        #endregion

        #region Botones

        public FrmConsultaExpo()
        {
            InitializeComponent();
        }

        private void FrmConsultaExpo_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            //CargaComboTipoTransporte();
            MostrarBuscarTabla("");
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
        }

        private void FrmConsultaExpo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }


        #endregion

        #region Eventos

        public static FrmConsultaExpo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmConsultaExpo();
                return _instance;
            }
        }

        private void grvCabecera_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            //si cabecera (Exportacion) no tiene detalle (Detalle exportacion) el signo + se habilita
            GridView view = sender as GridView;
            CEExportacionSaldo cabecera = view.GetRow(e.RowHandle) as CEExportacionSaldo;
            if (cabecera != null)
                e.IsEmpty = !lstDetalleExportaciones.Any(x => x.Exportacion_Id == cabecera.Exp_Id);
        }

        private void grvCabecera_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            //Carga datos al detalle
            GridView view = sender as GridView;
            CEExportacionSaldo cabecera = view.GetRow(e.RowHandle) as CEExportacionSaldo;
            if (cabecera != null)
                e.ChildList = lstDetalleExportaciones.Where(x => x.Exportacion_Id == cabecera.Exp_Id).ToList();
        }

        private void grvCabecera_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            //Asigna valor 1, porque solo hay un detalle
            e.RelationCount = 1;
        }

        private void grvCabecera_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            //Nombre de la relacion
            e.RelationName = "DetailView";
        }

        #endregion

        private void mnuExportarExcel_Click(object sender, EventArgs e)
        {
            //Código para exportar el Grid a XLS
            if (sfdRutaArchivo.ShowDialog() == DialogResult.OK)
            {
                grdCabeceraDetalle.ExportToXls(sfdRutaArchivo.FileName);
            }
        }
    }
}