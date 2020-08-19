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
    public partial class FrmRegNotasDeCredito : Form
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

        private static FrmRegNotasDeCredito _instance;
        
        public static FrmRegNotasDeCredito Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmRegNotasDeCredito();
                return _instance;
            }
        }

        private int iIdExportacion = 0;
        private bool bCreoColumnasNotaDeCredito = false;
        private decimal iTotal = 0;

        CNExportacion objExportacion = new CNExportacion();

        CENotaCredito objEntidad = new CENotaCredito();
        CNNotaCredito objNegocio = new CNNotaCredito();

        CNNotaCreditoTipo objNotaCreditoTipo = new CNNotaCreditoTipo();
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
            dgvDatos.DataSource = objExportacion.MostrarExportaciones(sBuscar);
        }

        public void MostrarBuscarTablaNotasDeCredito(int sBuscar)
        {
            //---------CNIncidencias objNegocio = new CNIncidencias();
            dgvNotasDeCredito.DataSource = objNegocio.MostrarNotasDeCreditoPorExportacion(sBuscar);

            CalcularTotalNotaDeCredito();

            if ((bCreoColumnasNotaDeCredito == false) && (dgvNotasDeCredito.RowCount > 0))
            {
                MostrarColumnasNotaDeCredito();
                bCreoColumnasNotaDeCredito = true;
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
            lblAbonoCliente.Enabled = bValor;
            lblAbonoProducto.Enabled = bValor;
            lblAbonoFactura.Enabled = bValor;
            lblAbonoFacturaImporte.Enabled = bValor;
        }

        private void HabilitaBotones(bool bValor)
        {
            dgvDatos.Enabled = bValor;
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

            //Detalle de la Exportación
            lblAbonoCliente.Text = "";
            lblAbonoProducto.Text = "";
            lblAbonoFactura.Text = "";
            lblAbonoFacturaImporte.Text = "";
            dtpNotaCreditoFecha.Text = "";
            cmbNotaCreditoNCTipo.SelectedValue = 0;
            txtNotaCreditoNumero.Text = "";
            txtNotaCreditoImporte.Text = "";
            lblNotasDeCreditoTotal.Text = "";

            ToolStripStatusLabel2.Text = "";
            ToolStripStatusLabel4.Text = "";
            ToolStripStatusLabel6.Text = "";
            ToolStripStatusLabel8.Text = "";
        }

        private void LimpiarControlesExportacionesDetalle()
        {
            dtpNotaCreditoFecha.Text = "";
            cmbNotaCreditoNCTipo.SelectedValue = 0;
            txtNotaCreditoNumero.Text = "";
            txtNotaCreditoImporte.Text = "";
        }
        
        private void MostrarAuditoria()
        {
            //Usuario_Creacion = dgvDatos.GetString(4);
            //Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
            //Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
            //Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)
            ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[24].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[24].Value.ToString();
            ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[25].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[25].Value.ToString();
            ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[26].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[26].Value.ToString();
            ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[27].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[27].Value.ToString();
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
            else if (dgvDatos.CurrentRow.Cells[14].Value.ToString() == "M")
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
            MostrarBuscarTablaNotasDeCredito(iIdExportacion);
            lblAbonoCliente.Text = lblClienteNombre.Text;
            lblAbonoProducto.Text = cmbProducto.Text;
            lblAbonoFactura.Text = txtFacturaNumero.Text;
            lblAbonoFacturaImporte.Text = txtFacturaImporte.Text;
            //cmbDetallePresentacion.DataSource = objProductoPresentacion.MostrarPresentacionesPorProducto(Convert.ToInt32(dgvDatos.CurrentRow.Cells[7].Value));
            //cmbDetallePresentacion.ValueMember = "ProPre_Id";
            //cmbDetallePresentacion.DisplayMember = "ProPre_Descripcion";
        }

        private void BuscaIds()
        {
            if (Convert.ToInt32(txtClienteId.Text) > 0)
            {
                lblClienteNombre.Text = objCliente.MostrarClienteId(Convert.ToInt32(txtClienteId.Text));
                //Detalle de Abonos
                lblAbonoCliente.Text = lblClienteNombre.Text;
            }

            if (Convert.ToInt32(txtOrigenId.Text) > 0)
            {
                if (bcbAereo.Checked)
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

        private void CargaComboNCTipo()
        {
            cmbNotaCreditoNCTipo.DataSource = objNotaCreditoTipo.MostrarNotaCreditoTipos("");
            cmbNotaCreditoNCTipo.ValueMember = "NCTip_Id";
            cmbNotaCreditoNCTipo.DisplayMember = "NCTip_Descripcion";
        }

        private void CargaComboEstadoNave()
        {
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
        }

        private bool ValidaCampos()
        {
            return ((txtNotaCreditoNumero.Text.Length > 0) && (txtNotaCreditoImporte.Text.Length > 0) && (cmbNotaCreditoNCTipo.Text.Length > 0));
        }

        private void CalcularTotalNotaDeCredito()
        {
            iTotal = 0;
            foreach (DataGridViewRow rFila in dgvNotasDeCredito.Rows)
            {
                iTotal = iTotal + Decimal.Parse(rFila.Cells[9].Value.ToString());
            }
            lblNotasDeCreditoTotal.Text = iTotal.ToString();
            //Convert.ToDecimal
        }
        #endregion

        public FrmRegNotasDeCredito()
        {
            InitializeComponent();
        }

        private void FrmRegNotasDeCredito_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargaComboEstadoNave();
            CargaComboProductos();
            CargaComboOperadores();
            CargaComboNCTipo();
            MostrarBuscarTabla("");
            MostrarColumnas();
            HabilitaControles(false);
            HabilitaBotones(true);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
            //Refrescar los TabPanel
            for (int i = 2; i >= 0; i--)
            {
                tabControl1.SelectedIndex = i;
            }
        }

        private void FrmRegNotasDeCredito_FormClosed(object sender, FormClosedEventArgs e)
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
            Close();
        }

        #region Botones

        private void bfbAgregarNotaCredito_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                //CEExportacionDetalle objEntidadDetalle = new CEExportacionDetalle();
                //CNExportacionDetalle objNegocioDetalle = new CNExportacionDetalle();
                objEntidad.Exportacion_Id = iIdExportacion;
                objEntidad.NC_Fecha = dtpNotaCreditoFecha.Text;
                objEntidad.NC_Nro = txtNotaCreditoNumero.Text;
                objEntidad.NC_Importe = Convert.ToDecimal(txtNotaCreditoImporte.Text);
                objEntidad.NCTipo_Id = Convert.ToInt32(cmbNotaCreditoNCTipo.SelectedValue);
                objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                objNegocio.InsertarNotaCredito(objEntidad);

                MostrarBuscarTablaNotasDeCredito(iIdExportacion);
                LimpiarControlesExportacionesDetalle();
                CalcularTotalNotaDeCredito();
                dgvNotasDeCredito.ClearSelection();
            }
            else
            {
                cFuncion.MensajeAdvertencia("Los Campos BANCO, TRANSFERENCIA y IMPORTE no pueden estar vacios!!");
            }
        }

        private void bfbEliminarNotaCredito_Click(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                try
                {
                    //CEExportacionDetalle objEntidadDetalle = new CEExportacionDetalle();
                    //CNExportacionDetalle objNegocioDetalle = new CNExportacionDetalle();
                    objEntidad.NC_Id = Convert.ToInt32(dgvNotasDeCredito.CurrentRow.Cells[0].Value);

                    objNegocio.EliminarNotaCredito(objEntidad);

                    MostrarBuscarTablaNotasDeCredito(iIdExportacion);
                    LimpiarControlesExportacionesDetalle();
                    CalcularTotalNotaDeCredito();
                    dgvNotasDeCredito.ClearSelection();
                }
                catch (Exception ex)
                {
                    cFuncion.MensajeError("No se pudo eliminar el registro seleccionado: " + ex);
                }
            }
        }

        #endregion

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

        private void dtpAbonoFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpNotaCreditoFecha.CustomFormat = "dd/MM/yyyy";
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

        private void dtpAbonoFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpNotaCreditoFecha.CustomFormat = " ";
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

    }
}
