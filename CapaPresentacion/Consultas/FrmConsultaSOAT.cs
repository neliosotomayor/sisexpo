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

namespace CapaPresentacion
{
    public partial class FrmConsultaSOAT : Form
    {
        Funciones cFuncion = new Funciones();

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

        private static FrmConsultaSOAT _instance;
        
        public static FrmConsultaSOAT Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmConsultaSOAT();
                return _instance;
            }
        }

        //private int iIdCombustible = 0;
        private bool bMostroColumnas = false;

        //CEVehiculo objEntidad = new CEVehiculo();
        CNProducto objNegocio = new CNProducto();

        //CNBancos objNegocioBancos = new CNBancos();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            //CNIncidencias objNegocio = new CNIncidencias();
            //dgvDatos.DataSource = objNegocio.MostrarCombustible(sBuscar);
            //dgvDatos.DataSource = objNegocio.ConsultaCombustibleFecha("01/01/1900", "01/01/1900", 0);
        
        }

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;    //IdVehiculo

            dgvDatos.Columns[1].Visible = true;     //Veh_Placa
            dgvDatos.Columns[1].Width = 30;         //Veh_Placa

            dgvDatos.Columns[2].Visible = false;     //Veh_Serie

            dgvDatos.Columns[3].Visible = false;    //Veh_VIN
            dgvDatos.Columns[4].Visible = false;    //Veh_Motor
            dgvDatos.Columns[5].Visible = false;    //Veh_Color

            dgvDatos.Columns[6].Visible = false;    //Marca_Id

            dgvDatos.Columns[7].Visible = false;    //Modelo_Id

            dgvDatos.Columns[8].Visible = false;    //Veh_PlacaAnterior
            dgvDatos.Columns[9].Visible = false;    //VehiculoEstado_Id
            dgvDatos.Columns[10].Visible = false;   //Veh_Descripcion
            dgvDatos.Columns[11].Visible = false;   //Veh_Ubicacion
            dgvDatos.Columns[12].Visible = false;   //Veh_Propietario
            dgvDatos.Columns[13].Visible = false;   //Seguro_Id
            dgvDatos.Columns[14].Visible = false;   //Chofer_Id

            dgvDatos.Columns[15].Visible = true;   //ChoferNombre
            dgvDatos.Columns[15].Width = 80;        //ChoferNombre

            dgvDatos.Columns[16].Visible = false;   //Veh_SOAT_Cia

            dgvDatos.Columns[17].Visible = false;    //Veh_SOAT_Contrato

            dgvDatos.Columns[18].Visible = true;    //Veh_SOAT_Fecha_Inicio
            dgvDatos.Columns[18].Width = 80;        //Veh_SOAT_Fecha_Inicio

            dgvDatos.Columns[19].Visible = true;    //Veh_SOAT_Fecha_Vencimiento
            dgvDatos.Columns[19].Width = 80;        //Veh_SOAT_Fecha_Vencimiento

            dgvDatos.Columns[20].Visible = false;   //Veh_Activo

            dgvDatos.Columns[21].Visible = false;   //Usuario Creacion
            dgvDatos.Columns[22].Visible = false;   //Fecha Creacion
            dgvDatos.Columns[23].Visible = false;   //Usuario Modificacion
            dgvDatos.Columns[24].Visible = false;   //Fecha Modificacion

            dgvDatos.ClearSelection();

            bMostroColumnas = true;
        }

        public void HabilitaControles(bool bValor)
        {
            dtpFechaDesde.Enabled = bValor;
            dtpFechaHasta.Enabled = bValor;
            lblVehiculo.Enabled = bValor;
            pbVehiculoId.Enabled = bValor;
        }

        private void HabilitaBotones(bool bValor)
        {
            bfbBuscar.Enabled = bValor; 
            dgvDatos.Enabled = bValor;
        }

        private void LimpiarControles()
        {
            //txtFechaDesde.Text = "";
            //txtFechaHasta.Text = "";
            txtVehiculoId.Text = "0";
            lblVehiculo.Text = "";
        }

        private void MostrarAuditoria()
        {
            //Usuario_Creacion = dgvDatos.GetString(4);
            //Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
            //Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
            //Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)
            if (dgvDatos.Rows.Count > 0)
            { 
                ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[21].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[21].Value.ToString();
                ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[22].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[22].Value.ToString();
                ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[23].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[23].Value.ToString();
                ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[24].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[24].Value.ToString();
            }
        }

        //private void BuscaIds()
        //{
        //    if (Convert.ToInt32(txtVehiculoId.Text) > 0)
        //    {
        //        lblVehiculo.Text = objNegocioBancos.MostrarBancosId(Convert.ToInt32(txtVehiculoId.Text));
        //    }
        //}

        #endregion

        public FrmConsultaSOAT()
        {
            InitializeComponent();
        }

        private void FrmConsultaSOAT_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            //MostrarBuscarTabla("");
            //MostrarColumnas();
            HabilitaControles(true);
            HabilitaBotones(true);
            bfbImprimir.Enabled = false;
            lblTitulo.Text = string.Format("Consulta de SOAT - .:{0}:.", FrmLogin.gUsuario);
            dtpFechaDesde.Focus();
        }

        private void FrmConsultaSOAT_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        #region Botones

        private void bfbImprimir_Click(object sender, EventArgs e)
        {
            FrmRpt_SOAT Rpt = new FrmRpt_SOAT();
            Rpt.FechaDesde = dtpFechaDesde.Text;
            Rpt.FechaHasta = dtpFechaHasta.Text;
            Rpt.VehiculoId = Convert.ToInt32(txtVehiculoId.Text);
            //if (txtFechaDesde.TextLength > 0 && txtFechaHasta.TextLength > 0)
                Rpt.Filtro = string.Format("Del: {0} Al: {1}", dtpFechaDesde.Text, dtpFechaHasta.Text);
            //else
            //    Rpt.Filtro = "";
            Rpt.ShowDialog();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //LimpiarControles();
            //MuestraDatosControles();
            MostrarAuditoria();
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            //LimpiarControles();
            //MuestraDatosControles();
            MostrarAuditoria();
        }

        private void dgvDatos_KeyUp(object sender, KeyEventArgs e)
        {
            //LimpiarControles();
            //MuestraDatosControles();
            MostrarAuditoria();
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }

        #endregion

        private void pbVehiculoId_Click(object sender, EventArgs e)
        {
            //FrmVehiculos formhijo = new FrmVehiculos();
            //AddOwnedForm(formhijo);
            //formhijo.FKIdVehiculo = 7;
            //formhijo.ShowDialog();
        }

        private void lblVehiculo_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Desea borrar el valor del campo?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                txtVehiculoId.Text = "0";
                lblVehiculo.Text = "";
            }
        }

        private void bfbBuscar_Click(object sender, EventArgs e)
        {
            //--------------------------------------------LimpiarControles();
            //dgvDatos.DataSource = objNegocio.ConsultaSOATFecha(dtpFechaDesde.Text, dtpFechaHasta.Text, Convert.ToInt32(txtVehiculoId.Text));
            if (bMostroColumnas == false)
            {
                MostrarColumnas();
            }
            bfbImprimir.Enabled = (dgvDatos.Rows.Count > 0);
        }

    }
}
