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
    public partial class FrmRegExportaciones : Form
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

        private static FrmRegExportaciones _instance;

        public static FrmRegExportaciones Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmRegExportaciones();
                return _instance;
            }
        }

        private int iIdExportacion = 0;
        private bool bModifica = false;
        private bool bCreoColumnasDetalle = false;
        private decimal iTotal = 0;

        CEExportacion objEntidad = new CEExportacion();
        CNExportacion objNegocio = new CNExportacion();

        CEExportacionDetalle objEntidadExportacionDetalle = new CEExportacionDetalle();
        CNExportacionDetalle objNegocioExportacionDetalle = new CNExportacionDetalle();

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
            dgvDatos.DataSource = objNegocio.MostrarExportaciones(sBuscar);
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

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;    //Exp_Id

            dgvDatos.Columns[1].Visible = false;    //Cli_Id

            dgvDatos.Columns[2].Visible = true;     //Cli_Nombre
            dgvDatos.Columns[2].Width = 50;         //Cli_Nombre

            dgvDatos.Columns[3].Visible = true;     //Exp_FacturaFecha

            dgvDatos.Columns[4].Visible = true;     //Exp_FacturaNro
            dgvDatos.Columns[4].Width = 40;         //Exp_FacturaNro

            dgvDatos.Columns[5].Visible = true;     //Exp_FacturaCajas
            dgvDatos.Columns[5].Width = 20;         //Exp_FacturaCajas

            dgvDatos.Columns[6].Visible = true;     //Exp_FacturaImporte
            dgvDatos.Columns[6].Width = 20;         //Exp_FacturaImporte
            dgvDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns[6].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns[7].Visible = false;    //Producto_Id

            dgvDatos.Columns[8].Visible = true;     //Pro_Nombre
            dgvDatos.Columns[8].Width = 40;         //Pro_Nombre

            dgvDatos.Columns[9].Visible = false;    //Exp_Contenedor
            dgvDatos.Columns[10].Visible = false;   //Exp_Booking
            dgvDatos.Columns[11].Visible = false;   //Exp_DUA
            dgvDatos.Columns[12].Visible = false;   //Operador_Id
            dgvDatos.Columns[13].Visible = false;   //Ope_Nombre
            dgvDatos.Columns[14].Visible = false;   //Exp_Transporte

            dgvDatos.Columns[15].Visible = false;   //Puerto_IdOrigen
            dgvDatos.Columns[16].Visible = false;   //Pue_OrigenNombre
            dgvDatos.Columns[17].Visible = false;   //Exp_ETD
            dgvDatos.Columns[18].Visible = false;   //Exp_TTD
            dgvDatos.Columns[19].Visible = false;   //Puerto_IdDestino
            dgvDatos.Columns[20].Visible = false;   //Pue_DestinoNombre
            dgvDatos.Columns[21].Visible = false;   //Exp_ETA
            dgvDatos.Columns[22].Visible = false;   //Exp_TTA
            dgvDatos.Columns[23].Visible = false;   //Exp_EstadoNave
            dgvDatos.Columns[24].Visible = false;   //Comentario

            dgvDatos.Columns[25].Visible = false;   //Usuario Creacion
            dgvDatos.Columns[26].Visible = false;   //Fecha Creacion
            dgvDatos.Columns[27].Visible = false;   //Usuario Modificacion
            dgvDatos.Columns[28].Visible = false;   //Fecha Modificacion

            dgvDatos.ClearSelection();
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
            pbClienteId.Enabled = bValor;
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

            pbPuertoOrigenId.Enabled = bValor;
            lblPuertoOrigenNombre.Enabled = bValor;
            dtpETD.Enabled = bValor;
            dtpTTD.Enabled = bValor;
            pbPuertoDestinoId.Enabled = bValor;
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
            bfbGrabar.Enabled = !bValor;
            bfbNuevo.Enabled = bValor;
            bfbModificar.Enabled = bValor;
            bfbCancelar.Enabled = !bValor;
            bfbEliminar.Enabled = bValor;
            bfbImprimir.Enabled = bValor;
            dgvDatos.Enabled = bValor;
            txtBuscar.Enabled = bValor;
        }

        private void LimpiarControles()
        {
            bModifica = false;
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
            cmbEstadoNave.SelectedValue = '0';
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

            //Detalle de la Exportación
            lblDetalleCliente.Text = "";
            lblDetalleProducto.Text = "";
            lblDetalleFactura.Text = "";
            lblDetalleFacturaImporte.Text = "0.00";
            cmbDetallePresentacion.SelectedValue = 0;
            txtDetalleCajas.Text = "";
            txtDetalleKilos.Text = "";
            txtDetallePrecioCaja.Text = "";
            lblDetalleTotal.Text = "";

            ToolStripStatusLabel2.Text = "";
            ToolStripStatusLabel4.Text = "";
            ToolStripStatusLabel6.Text = "";
            ToolStripStatusLabel8.Text = "";
        }

        private void LimpiarControlesExportacionesDetalle()
        {
            cmbDetallePresentacion.SelectedValue = 0;
            txtDetalleCajas.Text = "";
            txtDetalleKilos.Text = "";
            txtDetallePrecioCaja.Text = "";
        }

        private void MostrarAuditoria()
        {
            //Usuario_Creacion = dgvDatos.GetString(4);
            //Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
            //Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
            //Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)
            ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[25].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[25].Value.ToString();
            ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[26].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[26].Value.ToString();
            ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[27].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[27].Value.ToString();
            ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[28].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[28].Value.ToString();
        }

        private void MuestraDatosControles()
        {
            iIdExportacion = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            txtClienteId.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            //ClienteNombre
            dtpFacturaFecha.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            txtFacturaNumero.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString(); ;
            txtFacturaCajas.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString(); ;
            txtFacturaImporte.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString(); ;
            cmbProducto.SelectedValue = dgvDatos.CurrentRow.Cells[7].Value;
            //ProductoNombre
            txtContenedor.Text = dgvDatos.CurrentRow.Cells[9].Value.ToString();
            txtBooking.Text = dgvDatos.CurrentRow.Cells[10].Value.ToString();
            txtDUA.Text = dgvDatos.CurrentRow.Cells[11].Value.ToString();
            cmbOperador.SelectedValue = dgvDatos.CurrentRow.Cells[12].Value;
            //OperadorNombre
            if (dgvDatos.CurrentRow.Cells[14].Value.ToString() == "A")
            {
                bcbAereo.Checked = true;
                bcbMaritimo.Checked = false;
                bcbTerrestre.Checked = false;
            }
            else if(dgvDatos.CurrentRow.Cells[14].Value.ToString() == "M")
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
            txtOrigenId.Text = dgvDatos.CurrentRow.Cells[15].Value.ToString();
            //PuertoOrigenNombre
            dtpETD.Text = dgvDatos.CurrentRow.Cells[17].Value.ToString();
            dtpTTD.Text = dgvDatos.CurrentRow.Cells[18].Value.ToString();
            txtDestinoId.Text = dgvDatos.CurrentRow.Cells[19].Value.ToString();
            //PuertoDestinoNombre
            dtpETA.Text = dgvDatos.CurrentRow.Cells[21].Value.ToString();
            dtpTTA.Text = dgvDatos.CurrentRow.Cells[22].Value.ToString();
            cmbEstadoNave.SelectedValue = dgvDatos.CurrentRow.Cells[23].Value.ToString();
            txtComentario.Text = dgvDatos.CurrentRow.Cells[24].Value.ToString();

            //Detalle de la Exportacion
            MostrarBuscarTablaExportacionesDetalle(iIdExportacion);
            lblDetalleProducto.Text = cmbProducto.Text;
            lblDetalleFactura.Text = txtFacturaNumero.Text;
            lblDetalleFacturaImporte.Text = txtFacturaImporte.Text;
            cmbDetallePresentacion.DataSource = objProductoPresentacion.MostrarPresentacionesPorProducto(Convert.ToInt32(dgvDatos.CurrentRow.Cells[7].Value));
            cmbDetallePresentacion.ValueMember = "ProPre_Id";
            cmbDetallePresentacion.DisplayMember = "ProPre_Descripcion";
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

            DataRow fila = dt.NewRow(); fila["Id"] = "0"; fila["Tipo"] = "        "; dt.Rows.Add(fila);
            fila = dt.NewRow(); fila["Id"] = "A"; fila["Tipo"] = "ARRIBO  "; dt.Rows.Add(fila);
            fila = dt.NewRow(); fila["Id"] = "T"; fila["Tipo"] = "TRAVESIA"; dt.Rows.Add(fila);

            cmbEstadoNave.DataSource = dt;
            cmbEstadoNave.ValueMember = "Id";
            cmbEstadoNave.DisplayMember = "Tipo";

            //seleccionar el tipo de licencia actual
            //cmbTipoLicencia.SelectedValue = IdLicencia;
        }

        private void CargaComboTipoTransporte()
        {
            //cmbTipoIncidencia.DataSource = objTipoIncidencia.MostrarTipoIncidencia();
            //cmbProducto.ValueMember = "Id";
            //cmbProducto.DisplayMember = "TipoIncidencia";

            DataTable dt = new DataTable("TRANSPORTE");
            dt.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("Tipo");

            DataRow fila = dt.NewRow(); fila["Id"] = " "; fila["Tipo"] = "        "; dt.Rows.Add(fila);
            fila = dt.NewRow(); fila["Id"] = "A"; fila["Tipo"] = "AEREO  "; dt.Rows.Add(fila);
            fila = dt.NewRow(); fila["Id"] = "M"; fila["Tipo"] = "MARITIMO"; dt.Rows.Add(fila);

            //cmbTransporte.DataSource = dt;
            //cmbTransporte.ValueMember = "Id";
            //cmbTransporte.DisplayMember = "Tipo";

            //seleccionar el tipo de licencia actual
            //cmbTipoLicencia.SelectedValue = IdLicencia;
        }

        private bool ValidaCampos()
        {
            return ((lblClienteNombre.Text.Length > 0) && 
                    (Convert.ToInt32(cmbProducto.SelectedValue.ToString()) > 0) && 
                    (Convert.ToInt32(cmbOperador.SelectedValue.ToString()) > 0) && 
                    (txtFacturaNumero.Text.Length > 0) &&
                    (txtFacturaCajas.Text.Length > 0) &&
                    (txtFacturaImporte.Text.Length > 0) &&
                    (txtContenedor.Text.Length > 0) &&
                    (txtBooking.Text.Length > 0) &&
                    ((cmbEstadoNave.SelectedValue.ToString()) != "0") &&
                    (lblPuertoOrigenNombre.Text.Length > 0) &&
                    (lblPuertoDestinoNombre.Text.Length > 0));
        }

        private void CalcularTotalDetalle()
        {
            iTotal = 0;
            foreach (DataGridViewRow rFila in dgvDetalleExportacion.Rows)
            {
                iTotal = iTotal + Decimal.Parse(rFila.Cells[7].Value.ToString());
            }
            lblDetalleTotal.Text = iTotal.ToString("F2");
            //Convert.ToDecimal
        }

        #endregion

        #region Botones

        public FrmRegExportaciones()
        {
            InitializeComponent();
        }

        private void FrmRegExportaciones_Load(object sender, EventArgs e)
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

        private void FrmRegExportaciones_FormClosed(object sender, FormClosedEventArgs e)
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

        private void bfbNuevo_Click(object sender, EventArgs e)
        {
            HabilitaBotones(false);
            LimpiarControles();
            HabilitaControles(true);
            cmbProducto.Focus();
        }

        private void bfbModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                bModifica = true;
                MuestraDatosControles();
                HabilitaControles(true);
                HabilitaBotones(false);
            }
            else
            {
                cFuncion.MensajeError("Seleccione la fila que desea modificar!!");
            }
        }

        private void bfbCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            HabilitaControles(false);
            HabilitaBotones(true);
            dgvDatos.ClearSelection();
        }

        private void bfbGrabar_Click(object sender, EventArgs e)
        {
            if (bModifica == false)
            {
                if (ValidaCampos())
                {
                    //Nuevo
                    try
                    {
                        objEntidad.Cliente_Id = Convert.ToInt32(txtClienteId.Text);
                        objEntidad.Exp_FacturaFecha = dtpFacturaFecha.Text;
                        objEntidad.Exp_FacturaNro = txtFacturaNumero.Text;
                        objEntidad.Exp_FacturaCajas = Convert.ToInt64(txtFacturaCajas.Text);
                        objEntidad.Exp_FacturaImporte = Convert.ToDecimal(txtFacturaImporte.Text);
                        objEntidad.Producto_Id = Convert.ToInt32(cmbProducto.SelectedValue);
                        objEntidad.Exp_Contenedor = txtContenedor.Text;
                        objEntidad.Exp_Booking = txtBooking.Text;
                        objEntidad.Exp_DUA = txtDUA.Text;
                        objEntidad.Operador_Id = Convert.ToInt32(cmbOperador.SelectedValue);
                        if (bcbAereo.Checked)
                        {
                            objEntidad.Exp_Transporte = "A";
                        }
                        else if (bcbMaritimo.Checked)
                        {
                            objEntidad.Exp_Transporte = "M";
                        }
                        else
                        {
                            objEntidad.Exp_Transporte = "T";
                        }
                        objEntidad.Puerto_IdOrigen = Convert.ToInt32(txtOrigenId.Text);
                        objEntidad.Exp_ETD = dtpETD.Text;
                        objEntidad.Exp_TTD = dtpTTD.Text;
                        objEntidad.Puerto_IdDestino = Convert.ToInt32(txtDestinoId.Text);
                        objEntidad.Exp_ETA = dtpETA.Text;
                        objEntidad.Exp_TTA = dtpTTA.Text;
                        objEntidad.Exp_EstadoNave = cmbEstadoNave.SelectedValue.ToString();
                        objEntidad.Comentario = txtComentario.Text;
                        objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                        objNegocio.InsertarExportacion(objEntidad);

                        cFuncion.MensajeOk("Se agregó el registro!!");

                        MostrarBuscarTabla("");
                        LimpiarControles();
                        HabilitaControles(false);
                        HabilitaBotones(true);
                        dgvDatos.ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        cFuncion.MensajeError("No se pudo agregar el registro: " + ex);
                    }
                }
                else
                { 
                    cFuncion.MensajeAdvertencia("Debe completar los campos requeridos... \n- Cliente \n- Producto \n- Operador \n- Factura \n- Estado de Nave \n- Tipo Transporte \n- Puerto Origen \n- Puerto Destino");
                }
            }

            if (bModifica == true)
            {
                //Actualiza
                try
                {
                    objEntidad.Exp_Id = iIdExportacion;
                    objEntidad.Cliente_Id = Convert.ToInt32(txtClienteId.Text);
                    objEntidad.Exp_FacturaFecha = dtpFacturaFecha.Text;
                    objEntidad.Exp_FacturaNro = txtFacturaNumero.Text;
                    objEntidad.Exp_FacturaCajas = Convert.ToInt64(txtFacturaCajas.Text);
                    objEntidad.Exp_FacturaImporte = Convert.ToDecimal(txtFacturaImporte.Text);
                    objEntidad.Producto_Id = Convert.ToInt32(cmbProducto.SelectedValue);
                    objEntidad.Exp_Contenedor = txtContenedor.Text;
                    objEntidad.Exp_Booking = txtBooking.Text;
                    objEntidad.Exp_DUA = txtDUA.Text;
                    objEntidad.Operador_Id = Convert.ToInt32(cmbOperador.SelectedValue);
                    if (bcbAereo.Checked)
                    {
                        objEntidad.Exp_Transporte = "A";
                    }
                    else if (bcbMaritimo.Checked)
                    {
                        objEntidad.Exp_Transporte = "M";
                    }
                    else
                    {
                        objEntidad.Exp_Transporte = "T";
                    }
                    objEntidad.Puerto_IdOrigen = Convert.ToInt32(txtOrigenId.Text);
                    objEntidad.Exp_ETD = dtpETD.Text;
                    objEntidad.Exp_TTD = dtpTTD.Text;
                    objEntidad.Puerto_IdDestino = Convert.ToInt32(txtDestinoId.Text);
                    objEntidad.Exp_ETA = dtpETA.Text;
                    objEntidad.Exp_TTA = dtpTTA.Text;
                    objEntidad.Exp_EstadoNave = cmbEstadoNave.SelectedValue.ToString();
                    objEntidad.Comentario = txtComentario.Text;
                    objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                    objNegocio.ModificarExportacion(objEntidad);

                    cFuncion.MensajeOk("Se modificó el registro seleccionado!!");

                    MostrarBuscarTabla("");
                    LimpiarControles();
                    bModifica = false;
                    HabilitaControles(false);
                    HabilitaBotones(true);
                    dgvDatos.ClearSelection();

                }
                catch (Exception ex)
                {
                    cFuncion.MensajeError("No se pudo modificar el registro seleccionado: " + ex);
                }
            }
        }

        private void bfbImprimir_Click(object sender, EventArgs e)
        {
            cFuncion.MensajeOk("Opción en desarrollo");
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

        private void bfbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                try
                {
                    objEntidad.Exp_Id = iIdExportacion;
                    //objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                    objNegocio.EliminarExportacion(objEntidad);

                    cFuncion.MensajeOk("Se eliminó el registro seleccionado!!");

                    MostrarBuscarTabla("");
                    LimpiarControles();
                    bModifica = false;
                    HabilitaControles(false);
                    HabilitaBotones(true);
                    dgvDatos.ClearSelection();
                }
                catch (Exception ex)
                {
                    cFuncion.MensajeError("No se pudo eliminar el registro seleccionado: " + ex);
                }
            }
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

        private void bfbAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                //CEExportacionDetalle objEntidadDetalle = new CEExportacionDetalle();
                //CNExportacionDetalle objNegocioDetalle = new CNExportacionDetalle();
                objEntidadExportacionDetalle.Exportacion_Id = iIdExportacion;
                objEntidadExportacionDetalle.ExpDet_Cajas = Convert.ToInt32(txtDetalleCajas.Text);
                objEntidadExportacionDetalle.ExpDet_Kilos = Convert.ToDecimal(txtDetalleKilos.Text);
                objEntidadExportacionDetalle.ExpDet_Precio = Convert.ToDecimal(txtDetallePrecioCaja.Text);
                objEntidadExportacionDetalle.Presentacion_Id = Convert.ToInt32(cmbDetallePresentacion.SelectedValue);
                objEntidadExportacionDetalle.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                objNegocioExportacionDetalle.InsertarExportacionDetalle(objEntidadExportacionDetalle);

                //cFuncion.MensajeOk("Se agregó el registro!!");

                MostrarBuscarTablaExportacionesDetalle(iIdExportacion);
                LimpiarControlesExportacionesDetalle();
                CalcularTotalDetalle();
                dgvDetalleExportacion.ClearSelection();
            }
            else
            {
                cFuncion.MensajeAdvertencia("Los Campos PRESENTACION, CAJAS, KILOS y PRECIO no pueden estar vacios!!");
            }
        }

        private void bfbEliminarDetalle_Click(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                try
                {
                    //CEExportacionDetalle objEntidadDetalle = new CEExportacionDetalle();
                    //CNExportacionDetalle objNegocioDetalle = new CNExportacionDetalle();
                    objEntidadExportacionDetalle.ExpDet_Id = Convert.ToInt32(dgvDetalleExportacion.CurrentRow.Cells[0].Value);

                    objNegocioExportacionDetalle.EliminarExportacionDetalle(objEntidadExportacionDetalle);

                    //cFuncion.MensajeOk("Se eliminó el registro!!");

                    MostrarBuscarTablaExportacionesDetalle(iIdExportacion);
                    LimpiarControlesExportacionesDetalle();
                    CalcularTotalDetalle();
                    dgvDetalleExportacion.ClearSelection();
                }
                catch (Exception ex)
                {
                    cFuncion.MensajeError("No se pudo eliminar el registro seleccionado: " + ex);
                }
            }
        }

        private void txtDetalleCajas_Leave(object sender, EventArgs e)
        {
            if ((cmbDetallePresentacion.Text.Length > 0) && ((txtDetalleCajas.Text.Length) > 0))
            {
                int iPosicion = cmbDetallePresentacion.Text.Length - 10;
                decimal iPresentacion = Convert.ToDecimal(cmbDetallePresentacion.Text.Substring(iPosicion, 10));
                int iKilos = Convert.ToInt32(txtDetalleCajas.Text.ToString());
                //MessageBox.Show("Prueba: " + cmbDetallePresentacion.Text.Substring(cmbDetallePresentacion.Text.Length - 10, 10));
                txtDetalleKilos.Text = (iPresentacion * Convert.ToDecimal(iKilos)).ToString("F2");  //Muestra dos decimales
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