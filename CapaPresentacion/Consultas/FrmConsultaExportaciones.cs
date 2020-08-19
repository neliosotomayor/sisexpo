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
    public partial class FrmConsultaExportaciones : Form
    {
        readonly Funciones cFuncion = new Funciones();

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

        private static FrmConsultaExportaciones _instance;

        public static FrmConsultaExportaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmConsultaExportaciones();
                return _instance;
            }
        }

        private int iIdExportacion = 0;
        private bool bCreoColumnasDetalle = false;
        private bool bCreoColumnasAbono = false;
        private bool bCreoColumnasNotaDeCredito = false;
        private decimal iTotalFactura = 0;
        private decimal iTotalAbonos = 0;
        private decimal iTotalNotasDeCredito = 0;
        private decimal iTotalDetalle = 0;

        CEExportacion objEntidad = new CEExportacion();
        CNExportacion objNegocio = new CNExportacion();

        CEExportacionDetalle objEntidadExportacionDetalle = new CEExportacionDetalle();
        CNExportacionDetalle objNegocioExportacionDetalle = new CNExportacionDetalle();

        CNNotaCredito objNotaCredito = new CNNotaCredito();
        CNAbono objAbono = new CNAbono();
        CNProducto objProducto = new CNProducto();
        CNOperador objOperador = new CNOperador();
        CNCliente objCliente = new CNCliente();
        CNAeropuerto objAeropuerto = new CNAeropuerto();
        CNPuerto objPuerto = new CNPuerto();
        CNProductoPresentacion objProductoPresentacion = new CNProductoPresentacion();

        //CNBancos objNegocioBancos = new CNBancos();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            //---------CNIncidencias objNegocio = new CNIncidencias();
            dgvExportaciones.DataSource = objNegocio.MostrarExportaciones(sBuscar);
        }

        public void MostrarBuscarTablaExportacionesDetalle(int sBuscar)
        {
            //---------CNIncidencias objNegocio = new CNIncidencias();
            dgvDetalleExportacion.DataSource = objNegocioExportacionDetalle.MostrarExportacionesDetalle(sBuscar);

            CalcularTotalDetalle();

            if ((bCreoColumnasDetalle == false) && (dgvDetalleExportacion.RowCount > 0))
            {
                MostrarColumnasDetalle();
                bCreoColumnasDetalle = true;
            }
        }

        public void MostrarBuscarTablaAbonos(int sBuscar)
        {
            //---------CNIncidencias objNegocio = new CNIncidencias();
            dgvAbonos.DataSource = objAbono.MostrarAbonosPorExportacion(sBuscar);

            CalcularTotalAbonos();

            if ((bCreoColumnasAbono == false) && (dgvAbonos.RowCount > 0))
            {
                MostrarColumnasAbono();
                bCreoColumnasAbono = true;
            }
        }

        public void MostrarColumnasAbono()
        {
            dgvAbonos.Columns[0].Visible = false;    //Abo_Id

            dgvAbonos.Columns[1].Visible = false;    //Exportacion_Id

            dgvAbonos.Columns[2].Visible = false;    //Abo_FacturaNro

            dgvAbonos.Columns[3].Visible = false;    //Cliente_Id

            dgvAbonos.Columns[4].Visible = false;    //Cli_Nombre

            dgvAbonos.Columns[5].Visible = false;    //Banco_Id

            dgvAbonos.Columns[6].Visible = true;     //Ban_Nombre
            dgvAbonos.Columns[6].Width = 70;         //Ban_Nombre

            dgvAbonos.Columns[7].Visible = true;     //Abo_Fecha
            dgvAbonos.Columns[7].Width = 50;         //Abo_Fecha

            dgvAbonos.Columns[8].Visible = true;     //Abo_NroTransferencia
            dgvAbonos.Columns[8].Width = 50;         //Abo_NroTransferencia
            dgvAbonos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvAbonos.Columns[9].Visible = true;     //Abo_Importe
            dgvAbonos.Columns[9].Width = 50;         //Abo_Importe
            dgvAbonos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAbonos.Columns[9].DefaultCellStyle.Format = "N2";

            dgvAbonos.Columns[10].Visible = false;    //Usuario Creacion
            dgvAbonos.Columns[11].Visible = false;    //Fecha Creacion
            dgvAbonos.Columns[12].Visible = false;    //Usuario Modificacion
            dgvAbonos.Columns[13].Visible = false;   //Fecha Modificacion

            dgvAbonos.ClearSelection();
        }

        public void MostrarBuscarTablaNotasDeCredito(int sBuscar)
        {
            //---------CNIncidencias objNegocio = new CNIncidencias();
            dgvNotasDeCredito.DataSource = objNotaCredito.MostrarNotasDeCreditoPorExportacion(sBuscar);

            CalcularTotalNotasDeCredito();

            if ((bCreoColumnasNotaDeCredito == false) && (dgvNotasDeCredito.RowCount > 0))
            {
                MostrarColumnasNotaDeCredito();
                bCreoColumnasNotaDeCredito = true;
            }
        }

        private void CalcularTotalNotasDeCredito()
        {
            iTotalNotasDeCredito = 0;
            foreach (DataGridViewRow rFila in dgvNotasDeCredito.Rows)
            {
                iTotalNotasDeCredito = iTotalNotasDeCredito + Decimal.Parse(rFila.Cells[9].Value.ToString());
            }
            lblTotalNotasDeCredito.Text = iTotalNotasDeCredito.ToString("F2");
            //Convert.ToDecimal
        }

        private void CalcularTotalAbonos()
        {
            iTotalAbonos = 0;
            foreach (DataGridViewRow rFila in dgvAbonos.Rows)
            {
                iTotalAbonos = iTotalAbonos + Decimal.Parse(rFila.Cells[9].Value.ToString());
            }
            lblTotalAbonos.Text = iTotalAbonos.ToString("F2");
            //Convert.ToDecimal
        }

        private void CalcularTotalDetalle()
        {
            iTotalDetalle = 0;
            foreach (DataGridViewRow rFila in dgvDetalleExportacion.Rows)
            {
                iTotalDetalle = iTotalDetalle + Decimal.Parse(rFila.Cells[7].Value.ToString());
            }
            lblDetalleTotal.Text = iTotalDetalle.ToString("F2");
            //Convert.ToDecimal
        }

        public void MostrarColumnasNotaDeCredito()
        {
            dgvNotasDeCredito.Columns[0].Visible = false;    //NC_Id

            dgvNotasDeCredito.Columns[1].Visible = false;    //Exportacion_Id

            dgvNotasDeCredito.Columns[2].Visible = false;    //Exp_FacturaNro

            dgvNotasDeCredito.Columns[3].Visible = false;    //Cliente_Id

            dgvNotasDeCredito.Columns[4].Visible = false;    //Cli_Nombre

            dgvNotasDeCredito.Columns[5].Visible = true;     //NC_Fecha
            dgvNotasDeCredito.Columns[5].Width = 50;         //NC_Fecha

            dgvNotasDeCredito.Columns[6].Visible = false;    //NCTip_Id

            dgvNotasDeCredito.Columns[7].Visible = true;     //NCTip_Descripcion
            dgvNotasDeCredito.Columns[7].Width = 70;         //NCTip_Descripcion

            dgvNotasDeCredito.Columns[8].Visible = true;     //NC_Nro
            dgvNotasDeCredito.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNotasDeCredito.Columns[8].Width = 50;         //NC_Nro

            dgvNotasDeCredito.Columns[9].Visible = true;     //NC_Importe
            dgvNotasDeCredito.Columns[9].Width = 50;         //NC_Importe
            dgvNotasDeCredito.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNotasDeCredito.Columns[9].DefaultCellStyle.Format = "N2";

            dgvNotasDeCredito.Columns[10].Visible = false;    //Usuario Creacion
            dgvNotasDeCredito.Columns[11].Visible = false;    //Fecha Creacion
            dgvNotasDeCredito.Columns[12].Visible = false;    //Usuario Modificacion
            dgvNotasDeCredito.Columns[13].Visible = false;    //Fecha Modificacion

            dgvNotasDeCredito.ClearSelection();
        }

        public void MostrarColumnas()
        {
            dgvExportaciones.Columns[0].Visible = false;    //Exp_Id

            dgvExportaciones.Columns[1].Visible = false;    //Cli_Id

            dgvExportaciones.Columns[2].Visible = true;     //Cli_Nombre
            dgvExportaciones.Columns[2].Width = 50;         //Cli_Nombre

            dgvExportaciones.Columns[3].Visible = true;     //Exp_FacturaFecha

            dgvExportaciones.Columns[4].Visible = true;     //Exp_FacturaNro
            dgvExportaciones.Columns[4].Width = 40;         //Exp_FacturaNro

            dgvExportaciones.Columns[5].Visible = true;     //Exp_FacturaCajas
            dgvExportaciones.Columns[5].Width = 20;         //Exp_FacturaCajas

            dgvExportaciones.Columns[6].Visible = true;     //Exp_FacturaImporte
            dgvExportaciones.Columns[6].Width = 20;         //Exp_FacturaImporte
            dgvExportaciones.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvExportaciones.Columns[6].DefaultCellStyle.Format = "N2";

            dgvExportaciones.Columns[7].Visible = false;    //Producto_Id

            dgvExportaciones.Columns[8].Visible = true;     //Pro_Nombre
            dgvExportaciones.Columns[8].Width = 40;         //Pro_Nombre

            dgvExportaciones.Columns[9].Visible = false;    //Exp_Contenedor
            dgvExportaciones.Columns[10].Visible = false;   //Exp_Booking
            dgvExportaciones.Columns[11].Visible = false;   //Exp_DUA
            dgvExportaciones.Columns[12].Visible = false;   //Operador_Id
            dgvExportaciones.Columns[13].Visible = false;   //Ope_Nombre
            dgvExportaciones.Columns[14].Visible = false;   //Exp_Transporte

            dgvExportaciones.Columns[15].Visible = false;   //Puerto_IdOrigen
            dgvExportaciones.Columns[16].Visible = false;   //Pue_OrigenNombre
            dgvExportaciones.Columns[17].Visible = false;   //Exp_ETD
            dgvExportaciones.Columns[18].Visible = false;   //Exp_TTD
            dgvExportaciones.Columns[19].Visible = false;   //Puerto_IdDestino
            dgvExportaciones.Columns[20].Visible = false;   //Pue_DestinoNombre
            dgvExportaciones.Columns[21].Visible = false;   //Exp_ETA
            dgvExportaciones.Columns[22].Visible = false;   //Exp_TTA
            dgvExportaciones.Columns[23].Visible = false;   //Exp_EstadoNave
            dgvExportaciones.Columns[24].Visible = false;   //Comentario

            dgvExportaciones.Columns[25].Visible = false;   //Usuario Creacion
            dgvExportaciones.Columns[26].Visible = false;   //Fecha Creacion
            dgvExportaciones.Columns[27].Visible = false;   //Usuario Modificacion
            dgvExportaciones.Columns[28].Visible = false;   //Fecha Modificacion

            dgvExportaciones.ClearSelection();
        }

        public void MostrarColumnasDetalle()
        {
            dgvDetalleExportacion.Columns[0].Visible = false;    //ExpDet_Id

            dgvDetalleExportacion.Columns[1].Visible = false;    //Exportacion_Id

            dgvDetalleExportacion.Columns[2].Visible = false;    //Presentacion_Id

            dgvDetalleExportacion.Columns[3].Visible = true;     //ProPre_Descripcion
            dgvDetalleExportacion.Columns[3].Width = 50;         //ProPre_Descripcion

            dgvDetalleExportacion.Columns[4].Visible = true;     //ExpDet_Cajas
            dgvDetalleExportacion.Columns[4].Width = 50;         //ExpDet_Cajas
            dgvDetalleExportacion.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleExportacion.Columns[4].DefaultCellStyle.Format = "###,###.00";    //N2

            dgvDetalleExportacion.Columns[5].Visible = true;     //ExpDet_Kilos
            dgvDetalleExportacion.Columns[5].Width = 50;         //ExpDet_Kilos
            dgvDetalleExportacion.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleExportacion.Columns[5].DefaultCellStyle.Format = "###,###.00";

            dgvDetalleExportacion.Columns[6].Visible = true;     //ExpDet_Precio
            dgvDetalleExportacion.Columns[6].Width = 50;         //ExpDet_Precio
            dgvDetalleExportacion.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleExportacion.Columns[6].DefaultCellStyle.Format = "###,###.000";

            dgvDetalleExportacion.Columns[7].Visible = true;     //ExpDet_TotalPresentacion
            dgvDetalleExportacion.Columns[7].Width = 50;         //ExpDet_TotalPresentacion
            dgvDetalleExportacion.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalleExportacion.Columns[7].DefaultCellStyle.Format = "###,###.00";

            dgvDetalleExportacion.Columns[8].Visible = false;    //Usuario Creacion
            dgvDetalleExportacion.Columns[9].Visible = false;    //Fecha Creacion
            dgvDetalleExportacion.Columns[10].Visible = false;    //Usuario Modificacion
            dgvDetalleExportacion.Columns[11].Visible = false;   //Fecha Modificacion

            dgvDetalleExportacion.ClearSelection();
        }

        public void HabilitaControles(bool bValor)
        {
            lblClienteNombre.Enabled = bValor;
            cmbProducto.Enabled = bValor;
            cmbOperador.Enabled = bValor;

            dtpFacturaFecha.Enabled = bValor;
            txtFacturaNumero.Enabled = bValor;
            txtFacturaCajas.Enabled = bValor;
            txtFacturaImporte.Enabled = bValor;

            txtComentario.Enabled = bValor;
            txtContenedor.Enabled = bValor;
            txtBooking.Enabled = bValor;
            txtDUA.Enabled = bValor;
            cmbEstadoNave.Enabled = bValor;

            bcbAereo.Enabled = bValor;
            bcbMaritimo.Enabled = bValor;
            bcbTerrestre.Enabled = bValor;

            lblPuertoOrigenNombre.Enabled = bValor;
            dtpETD.Enabled = bValor;
            dtpTTD.Enabled = bValor;
            lblPuertoDestinoNombre.Enabled = bValor;
            dtpETA.Enabled = bValor;
            dtpTTA.Enabled = bValor;

            //Detalle de la Exportación
            lblDetalleCliente.Enabled = bValor;
            lblDetalleProducto.Enabled = bValor;
            lblDetalleFactura.Enabled = bValor;
            lblDetalleFacturaImporte.Enabled = bValor;
        }

        private void HabilitaBotones(bool bValor)
        {
            dgvExportaciones.Enabled = bValor;
            txtBuscar.Enabled = bValor;
        }

        private void LimpiarControles()
        {
            txtClienteId.Text = "";
            lblClienteNombre.Text = "";
            cmbProducto.SelectedValue = 0;
            cmbOperador.SelectedValue = 0;
            dtpFacturaFecha.Text = "";
            txtFacturaNumero.Text = "";
            txtFacturaCajas.Text = "";
            txtFacturaImporte.Text = "";
            txtComentario.Text = "";
            txtContenedor.Text = "";
            txtBooking.Text = "";
            txtDUA.Text = "";
            cmbEstadoNave.SelectedValue = 0;
            bcbAereo.Checked = true;
            bcbMaritimo.Checked = false;
            bcbTerrestre.Checked = false;
            txtOrigenId.Text = "";
            lblPuertoOrigenNombre.Text = "";
            dtpETD.Text = "";
            dtpTTD.Text = "";
            txtDestinoId.Text = "";
            lblPuertoDestinoNombre.Text = "";
            dtpETA.Text = "";
            dtpTTA.Text = "";
            gbTravesia.Visible = true;
            iTotalFactura = 0;
            iTotalAbonos = 0;
            iTotalNotasDeCredito = 0;
            iTotalDetalle = 0;
            lblTotalAbonos.Text = "0.00";
            lblTotalNotasDeCredito.Text = "0.00";
            lblSaldoCliente.Text = "0.00";

            //Detalle de la Exportación
            lblDetalleCliente.Text = "";
            lblDetalleProducto.Text = "";
            lblDetalleFactura.Text = "";
            lblDetalleFacturaImporte.Text = "0.00";
            lblDetalleTotal.Text = "";

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
            ToolStripStatusLabel2.Text = dgvExportaciones.CurrentRow.Cells[25].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[25].Value.ToString();
            ToolStripStatusLabel4.Text = dgvExportaciones.CurrentRow.Cells[26].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[26].Value.ToString();
            ToolStripStatusLabel6.Text = dgvExportaciones.CurrentRow.Cells[27].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[27].Value.ToString();
            ToolStripStatusLabel8.Text = dgvExportaciones.CurrentRow.Cells[28].Value.ToString() == "" ? "..." : dgvExportaciones.CurrentRow.Cells[28].Value.ToString();
        }

        private void MuestraDatosControles()
        {
            iIdExportacion = Convert.ToInt32(dgvExportaciones.CurrentRow.Cells[0].Value);
            txtClienteId.Text = dgvExportaciones.CurrentRow.Cells[1].Value.ToString();
            //ClienteNombre
            dtpFacturaFecha.Text = dgvExportaciones.CurrentRow.Cells[3].Value.ToString();
            txtFacturaNumero.Text = dgvExportaciones.CurrentRow.Cells[4].Value.ToString();
            txtFacturaCajas.Text = dgvExportaciones.CurrentRow.Cells[5].Value.ToString();
            txtFacturaImporte.Text = dgvExportaciones.CurrentRow.Cells[6].Value.ToString();
            cmbProducto.SelectedValue = dgvExportaciones.CurrentRow.Cells[7].Value;
            //ProductoNombre
            txtContenedor.Text = dgvExportaciones.CurrentRow.Cells[9].Value.ToString();
            txtBooking.Text = dgvExportaciones.CurrentRow.Cells[10].Value.ToString();
            txtDUA.Text = dgvExportaciones.CurrentRow.Cells[11].Value.ToString();
            cmbOperador.SelectedValue = dgvExportaciones.CurrentRow.Cells[12].Value;
            //OperadorNombre
            if (dgvExportaciones.CurrentRow.Cells[14].Value.ToString() == "A")
            {
                bcbAereo.Checked = true;
                bcbMaritimo.Checked = false;
                bcbTerrestre.Checked = false;
            }
            else if(dgvExportaciones.CurrentRow.Cells[14].Value.ToString() == "M")
            {
                bcbAereo.Checked = false;
                bcbMaritimo.Checked = true;
                bcbTerrestre.Checked = false;
            }
            else
            {
                bcbAereo.Checked = false;
                bcbMaritimo.Checked = false;
                bcbTerrestre.Checked = true;
            }
            txtOrigenId.Text = dgvExportaciones.CurrentRow.Cells[15].Value.ToString();
            //PuertoOrigenNombre
            dtpETD.Text = dgvExportaciones.CurrentRow.Cells[17].Value.ToString();
            dtpTTD.Text = dgvExportaciones.CurrentRow.Cells[18].Value.ToString();
            txtDestinoId.Text = dgvExportaciones.CurrentRow.Cells[19].Value.ToString();
            //PuertoDestinoNombre
            dtpETA.Text = dgvExportaciones.CurrentRow.Cells[21].Value.ToString();
            dtpTTA.Text = dgvExportaciones.CurrentRow.Cells[22].Value.ToString();
            cmbEstadoNave.SelectedValue = dgvExportaciones.CurrentRow.Cells[23].Value.ToString();
            txtComentario.Text = dgvExportaciones.CurrentRow.Cells[24].Value.ToString();

            //Detalle de la Exportacion
            MostrarBuscarTablaExportacionesDetalle(iIdExportacion);
            lblDetalleProducto.Text = cmbProducto.Text;
            lblDetalleFactura.Text = txtFacturaNumero.Text;
            lblDetalleFacturaImporte.Text = txtFacturaImporte.Text;

            MostrarBuscarTablaAbonos(iIdExportacion);
            MostrarBuscarTablaNotasDeCredito(iIdExportacion);

            iTotalFactura = Convert.ToDecimal(txtFacturaImporte.Text);

            iTotalFactura = iTotalFactura - (iTotalAbonos + iTotalNotasDeCredito);
            lblSaldoCliente.Text = iTotalFactura.ToString("F2");
            //if (iTotalFactura > 0)
            //{
            //    lblSaldoCliente.ForeColor = Color.Red;
            //}
            //else
            //{
            //    lblSaldoCliente.ForeColor = Color.Gray;
            //}
        }

        private void BuscaIds()
        {
            if (Convert.ToInt32(txtClienteId.Text) > 0)
            {
                lblClienteNombre.Text = objCliente.MostrarClienteId(Convert.ToInt32(txtClienteId.Text));
                //Detalle de Exportacion
                lblDetalleCliente.Text = lblClienteNombre.Text;
            }

            if (Convert.ToInt32(txtOrigenId.Text) > 0)
            {
                if (bcbAereo.Checked )
                {
                    lblPuertoOrigenNombre.Text = objAeropuerto.MostrarAeropuertoId(Convert.ToInt32(txtOrigenId.Text));
                }
                else
                {
                    lblPuertoOrigenNombre.Text = objPuerto.MostrarPuertoId(Convert.ToInt32(txtOrigenId.Text));
                }
            }

            if (Convert.ToInt32(txtDestinoId.Text) > 0)
            {
                if (bcbAereo.Checked)
                {
                    lblPuertoDestinoNombre.Text = objAeropuerto.MostrarAeropuertoId(Convert.ToInt32(txtDestinoId.Text));
                }
                else
                {
                    lblPuertoDestinoNombre.Text = objPuerto.MostrarPuertoId(Convert.ToInt32(txtDestinoId.Text));
                }
            }

        }

        private void CargaComboProductos()
        {
            cmbProducto.DataSource = objProducto.MostrarProductos("");
            cmbProducto.ValueMember = "Pro_Id";
            cmbProducto.DisplayMember = "Pro_Nombre";
        }

        private void CargaComboOperadores()
        {
            cmbOperador.DataSource = objOperador.MostrarOperadores("");
            cmbOperador.ValueMember = "Ope_Id";
            cmbOperador.DisplayMember = "Ope_Nombre";
        }

        private void CargaComboEstadoNave()
        {
            //cmbTipoIncidencia.DataSource = objTipoIncidencia.MostrarTipoIncidencia();
            //cmbProducto.ValueMember = "Id";
            //cmbProducto.DisplayMember = "TipoIncidencia";

            DataTable dt = new DataTable("ESTADONAVE");
            dt.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("Tipo");

            DataRow fila = dt.NewRow(); fila["Id"] = " "; fila["Tipo"] = "        "; dt.Rows.Add(fila);
            fila = dt.NewRow(); fila["Id"] = "A"; fila["Tipo"] = "ARRIBO  "; dt.Rows.Add(fila);
            fila = dt.NewRow(); fila["Id"] = "T"; fila["Tipo"] = "TRAVESIA"; dt.Rows.Add(fila);

            cmbEstadoNave.DataSource = dt;
            cmbEstadoNave.ValueMember = "Id";
            cmbEstadoNave.DisplayMember = "Tipo";

            //seleccionar el tipo de licencia actual
            //cmbTipoLicencia.SelectedValue = IdLicencia;
        }

        #endregion

        #region Botones

        public FrmConsultaExportaciones()
        {
            InitializeComponent();
        }

        private void FrmConsultaExportaciones_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargaComboEstadoNave();
            CargaComboProductos();
            CargaComboOperadores();
            //CargaComboTipoTransporte();
            MostrarBuscarTabla("");
            MostrarColumnas();
            HabilitaControles(false);
            HabilitaBotones(true);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
            //Refrescar los TabPanel
            for (int i = 2; i >= 0; i--)
            {
                tabPane1.SelectedPageIndex = i;
            }

        }

        private void FrmConsultaExportaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txtBuscar.Text);
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarControles();
            MuestraDatosControles();
            BuscaIds();
            MostrarAuditoria();
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            LimpiarControles();
            MuestraDatosControles();
            BuscaIds();
            MostrarAuditoria();
        }

        private void dgvDatos_KeyUp(object sender, KeyEventArgs e)
        {
            LimpiarControles();
            MuestraDatosControles();
            BuscaIds();
            MostrarAuditoria();
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }

        #endregion

        private void dtpFacturaFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFacturaFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpETD_ValueChanged(object sender, EventArgs e)
        {
            dtpETD.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpTTD_ValueChanged(object sender, EventArgs e)
        {
            dtpTTD.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpETA_ValueChanged(object sender, EventArgs e)
        {
            dtpETA.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpTTA_ValueChanged(object sender, EventArgs e)
        {
            dtpTTA.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpFacturaFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFacturaFecha.CustomFormat = " ";
            }
        }

        private void dtpETD_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpETD.CustomFormat = " ";
            }
        }

        private void dtpTTD_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpTTD.CustomFormat = " ";
            }
        }

        private void dtpETA_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpETA.CustomFormat = " ";
            }
        }

        private void dtpTTA_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpTTA.CustomFormat = " ";
            }
        }

        private void pbClienteId_Click(object sender, EventArgs e)
        {
            FrmClientes formhijo = new FrmClientes();
            AddOwnedForm(formhijo);
            formhijo.FKIdCliente = 1;
            formhijo.ShowDialog();
        }

        private void pbPuertoOrigenId_Click(object sender, EventArgs e)
        {
            if (bcbAereo.Checked)
            {
                FrmAeropuertos formhijo = new FrmAeropuertos();
                AddOwnedForm(formhijo);
                formhijo.FKIdAeropuerto = 1;
                formhijo.ShowDialog();
            }
            else
            {
                FrmPuertos formhijo = new FrmPuertos();
                AddOwnedForm(formhijo);
                formhijo.FKIdPuerto = 1;
                formhijo.ShowDialog();
            }
        }

        private void pbPuertoDestinoId_Click(object sender, EventArgs e)
        {
            if (bcbAereo.Checked)
            {
                FrmAeropuertos formhijo = new FrmAeropuertos();
                AddOwnedForm(formhijo);
                formhijo.FKIdAeropuerto = 2;
                formhijo.ShowDialog();
            }
            else
            {
                FrmPuertos formhijo = new FrmPuertos();
                AddOwnedForm(formhijo);
                formhijo.FKIdPuerto = 2;
                formhijo.ShowDialog();
            }
        }

        private void lblClienteNombre_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Desea borrar el valor del campo?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                txtClienteId.Text = "0";
                lblClienteNombre.Text = "";
            }
        }

        private void lblPuertoOrigenNombre_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Desea borrar el valor del campo?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                txtOrigenId.Text = "0";
                lblPuertoOrigenNombre.Text = "";
            }
        }

        private void lblPuertoDestinoNombre_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Desea borrar el valor del campo?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                txtDestinoId.Text = "0";
                lblPuertoDestinoNombre.Text = "";
            }
        }

        private void bcbMaritimo_OnChange(object sender, EventArgs e)
        {
            bcbAereo.Checked = !bcbMaritimo.Checked;
            bcbTerrestre.Checked = !bcbMaritimo.Checked;

        }

        private void bcbAereo_OnChange(object sender, EventArgs e)
        {
            bcbMaritimo.Checked = !bcbAereo.Checked;
            bcbTerrestre.Checked = !bcbAereo.Checked;
        }

        private void bcbTerrestre_OnChange(object sender, EventArgs e)
        {
            bcbAereo.Checked = !bcbTerrestre.Checked;
            bcbMaritimo.Checked = !bcbTerrestre.Checked;
        }
    }
}