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
    public partial class FrmRegAbonos : Form
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

        private static FrmRegAbonos _instance;
        
        public static FrmRegAbonos Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmRegAbonos();
                return _instance;
            }
        }

        private int iIdExportacion = 0;
        private bool bCreoColumnasAbono = false;
        private decimal iTotal = 0;

        CNExportacion objExportacion = new CNExportacion();

        CEAbono objEntidad = new CEAbono();
        CNAbono objNegocio = new CNAbono();

        CNBanco objBanco = new CNBanco();
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

        public void MostrarBuscarTablaAbonos(int sBuscar)
        {
            //---------CNIncidencias objNegocio = new CNIncidencias();
            dgvAbonos.DataSource = objNegocio.MostrarAbonosPorExportacion(sBuscar);

            CalcularTotalDetalle();

            if ((bCreoColumnasAbono == false) && (dgvAbonos.RowCount > 0))
            {
                MostrarColumnasAbono();
                bCreoColumnasAbono = true;
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
            dtpAbonoFecha.Text = "";
            cmbAbonoBanco.SelectedValue = 0;
            txtAbonoTransferencia.Text = "";
            txtAbonoImporte.Text = "";
            lblAbonosTotal.Text = "";

            ToolStripStatusLabel2.Text = "";
            ToolStripStatusLabel4.Text = "";
            ToolStripStatusLabel6.Text = "";
            ToolStripStatusLabel8.Text = "";
        }

        private void LimpiarControlesExportacionesDetalle()
        {
            dtpAbonoFecha.Text = "";
            cmbAbonoBanco.SelectedValue = 0;
            txtAbonoTransferencia.Text = "";
            txtAbonoImporte.Text = "";
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
            MostrarBuscarTablaAbonos(iIdExportacion);
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

        private void CargaComboBancos()
        {
            cmbAbonoBanco.DataSource = objBanco.MostrarBancos("");
            cmbAbonoBanco.ValueMember = "Ban_Id";
            cmbAbonoBanco.DisplayMember = "Ban_Nombre";
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
            return ((txtAbonoTransferencia.Text.Length > 0) && (txtAbonoImporte.Text.Length > 0) && (cmbAbonoBanco.Text.Length > 0));
        }

        private void CalcularTotalDetalle()
        {
            iTotal = 0;
            foreach (DataGridViewRow rFila in dgvAbonos.Rows)
            {
                iTotal = iTotal + Decimal.Parse(rFila.Cells[9].Value.ToString());
            }
            lblAbonosTotal.Text = iTotal.ToString();
            //Convert.ToDecimal
        }
        #endregion

        public FrmRegAbonos()
        {
            InitializeComponent();
        }

        private void FrmRegAbonos_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargaComboEstadoNave();
            CargaComboProductos();
            CargaComboOperadores();
            CargaComboBancos();
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

        private void FrmRegAbonos_FormClosed(object sender, FormClosedEventArgs e)
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

        private void bfbAgregarAbono_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                //CEExportacionDetalle objEntidadDetalle = new CEExportacionDetalle();
                //CNExportacionDetalle objNegocioDetalle = new CNExportacionDetalle();
                objEntidad.Exportacion_Id = iIdExportacion;
                objEntidad.Abo_Fecha = dtpAbonoFecha.Text;
                objEntidad.Abo_Importe = Convert.ToDecimal(txtAbonoImporte.Text);
                objEntidad.Banco_Id = Convert.ToInt32(cmbAbonoBanco.SelectedValue);
                objEntidad.Abo_NroTransferencia = txtAbonoTransferencia.Text;
                objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                objNegocio.InsertarAbono(objEntidad);

                MostrarBuscarTablaAbonos(iIdExportacion);
                LimpiarControlesExportacionesDetalle();
                CalcularTotalDetalle();
                dgvAbonos.ClearSelection();
            }
            else
            {
                cFuncion.MensajeAdvertencia("Los Campos BANCO, TRANSFERENCIA y IMPORTE no pueden estar vacios!!");
            }
        }

        private void bfbEliminarAbono_Click(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                try
                {
                    //CEExportacionDetalle objEntidadDetalle = new CEExportacionDetalle();
                    //CNExportacionDetalle objNegocioDetalle = new CNExportacionDetalle();
                    objEntidad.Abo_Id = Convert.ToInt32(dgvAbonos.CurrentRow.Cells[0].Value);

                    objNegocio.EliminarAbono(objEntidad);

                    MostrarBuscarTablaAbonos(iIdExportacion);
                    LimpiarControlesExportacionesDetalle();
                    CalcularTotalDetalle();
                    dgvAbonos.ClearSelection();
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
            dtpAbonoFecha.CustomFormat = "dd/MM/yyyy";
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
                dtpAbonoFecha.CustomFormat = " ";
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
