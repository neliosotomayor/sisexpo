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
    public partial class FrmClientes : Form
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

        private static FrmClientes _instance;
        
        public static FrmClientes Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmClientes();
                return _instance;
            }
        }

        public int FKIdCliente = 0;
        private int iIdCliente = 0;
        private bool bModifica = false;

        CECliente objEntidad = new CECliente();
        CNCliente objNegocio = new CNCliente();
        //CNTipoSangre objTipoSangre = new CNTipoSangre();
        //CNTipoLicencia objTipoLicencia = new CNTipoLicencia();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            //-----------------CNChoferes objNegocio = new CNChoferes();
            dgvDatos.DataSource = objNegocio.MostrarClientes(sBuscar);
        }

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;    //Cli_Id

            dgvDatos.Columns[1].Visible = true;     //Cli_Nombre
            dgvDatos.Columns[1].Width = 100;        //Cli_Nombre

            dgvDatos.Columns[2].Visible = false;     //Cli_Credito
            //dgvDatos.Columns[2].Width = 100;        //Cli_Credito

            dgvDatos.Columns[3].Visible = false;   //Usuario Creacion
            dgvDatos.Columns[4].Visible = false;   //Fecha Creacion
            dgvDatos.Columns[5].Visible = false;   //Usuario Modificacion
            dgvDatos.Columns[6].Visible = false;   //Fecha Modificacion

            dgvDatos.ClearSelection();
        }

        public void HabilitaControles(bool bValor)
        {
            txtNombre.Enabled = bValor;
            cmbTipoCredito.Enabled = bValor;
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
            txtNombre.Text = "";
            cmbTipoCredito.SelectedValue = 0;
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
            ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[3].Value.ToString();
            ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[4].Value.ToString();
            ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[5].Value.ToString();
            ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[6].Value.ToString();
        }

        private void MuestraDatosControles()
        {
            iIdCliente = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);                                                               //Cli_Id
            txtNombre.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();                                                                //Cli_Nombre
            cmbTipoCredito.SelectedValue = dgvDatos.CurrentRow.Cells[2].Value.ToString() == "" ? 0 : dgvDatos.CurrentRow.Cells[2].Value;   //Cli_Credito
        }

        private void CargaComboTipoCredito()
        {
            //cmbTipoSangre.DataSource = objTipoSangre.MostrarTipoSangre();
            //cmbTipoCredito.ValueMember = "Id";
            //cmbTipoCredito.DisplayMember = "TipoCredito";
            
            DataTable dt = new DataTable("CREDITO");
            dt.Clear();
            dt.Columns.Add("Id");
            dt.Columns.Add("Tipo");

            DataRow fila = dt.NewRow(); fila["Id"] = 0; fila["Tipo"] = "   "; dt.Rows.Add(fila);
                    fila = dt.NewRow(); fila["Id"] = 1; fila["Tipo"] = "Crédito a 15 días";  dt.Rows.Add(fila);
                    fila = dt.NewRow(); fila["Id"] = 2; fila["Tipo"] = "Crédito a 30 días";  dt.Rows.Add(fila);
                    fila = dt.NewRow(); fila["Id"] = 3; fila["Tipo"] = "Crédito a 45 días";  dt.Rows.Add(fila);
                    fila = dt.NewRow(); fila["Id"] = 4; fila["Tipo"] = "Crédito a 60 días";  dt.Rows.Add(fila);
                    fila = dt.NewRow(); fila["Id"] = 5; fila["Tipo"] = "Crédito a 75 días";  dt.Rows.Add(fila);
                    fila = dt.NewRow(); fila["Id"] = 6; fila["Tipo"] = "Crédito a 90 días";  dt.Rows.Add(fila);

            cmbTipoCredito.DataSource = dt;
            cmbTipoCredito.ValueMember = "Id";
            cmbTipoCredito.DisplayMember = "Tipo";
        }


        #endregion

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            CargaComboTipoCredito();
            MostrarBuscarTabla("");
            MostrarColumnas();
            HabilitaControles(false);
            HabilitaBotones(true);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
        }

        private void FrmClientes_FormClosed(object sender, FormClosedEventArgs e)
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

        #region Botones

        private void bfbNuevo_Click(object sender, EventArgs e)
        {
            HabilitaBotones(false);
            LimpiarControles();
            HabilitaControles(true);
            txtNombre.Focus();
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
                //Nuevo
                try
                {
                    objEntidad.Cli_Nombre = txtNombre.Text;
                    objEntidad.Cli_Credito = Convert.ToInt32(cmbTipoCredito.SelectedValue);

                    objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                    objNegocio.InsertarCliente(objEntidad);

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

            if (bModifica == true)
            {
                //Actualiza
                try
                {
                    objEntidad.Cli_Id = iIdCliente;
                    objEntidad.Cli_Nombre = txtNombre.Text;
                    objEntidad.Cli_Credito = Convert.ToInt32(cmbTipoCredito.SelectedValue);

                    objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                    objNegocio.ModificarCliente(objEntidad);

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
            MuestraDatosControles();
            MostrarAuditoria();
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            MuestraDatosControles();
            MostrarAuditoria();
        }

        private void dgvDatos_KeyUp(object sender, KeyEventArgs e)
        {
            MuestraDatosControles();
            MostrarAuditoria();
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }

        private void bfbEliminar_Click(object sender, EventArgs e)
        {
            if (cFuncion.PuedeEliminar())
            {
                DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
                if (result == DialogResult.OK)
                {
                    try
                    {
                        objEntidad.Cli_Id = iIdCliente;
                        //objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                        objNegocio.EliminarCliente(objEntidad);

                        cFuncion.MensajeOk("Se eliminó el registro seleccionado!!");

                        MostrarBuscarTabla("");
                        LimpiarControles();
                        bModifica = false;
                        HabilitaControles(false);
                        HabilitaBotones(true);
                    }
                    catch (Exception ex)
                    {
                        cFuncion.MensajeError("No se pudo eliminar el registro seleccionado: " + ex);
                    }
                }
            }
            else
            {
                cFuncion.MensajeError("Usted no tiene permisos para eliminar datos!!");
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FKIdCliente == 1)  //Llamada desde el Formulario Registro de Exportaciones
            {
                FrmRegExportaciones formPadre = Owner as FrmRegExportaciones;
                formPadre.txtClienteId.Text = iIdCliente.ToString();
                formPadre.lblClienteNombre.Text = string.Format("{0}", dgvDatos.CurrentRow.Cells[1].Value);
                FKIdCliente = 0;
                this.Close();
            }
        }

        #endregion

        //private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (FKIdChofer == 1) //Llamada desde el Formulario Vehiculos
        //    {
        //        FrmVehiculos formPadre = Owner as FrmVehiculos;
        //        formPadre.txtChoferId.Text = iIdChofer.ToString();
        //        formPadre.lblChofer.Text = string.Format("{0} {1}", dgvDatos.CurrentRow.Cells[1].Value, dgvDatos.CurrentRow.Cells[2].Value);
        //        FKIdChofer = 0;
        //        this.Close();
        //    }
        //    if (FKIdChofer == 2) //Llamada desde el Formulario Registro de Incidencias
        //    {
        //        FrmRegIncidencias formPadre = Owner as FrmRegIncidencias;
        //        formPadre.txtChoferId.Text = iIdChofer.ToString();
        //        formPadre.lblChofer.Text = string.Format("{0} {1}", dgvDatos.CurrentRow.Cells[1].Value, dgvDatos.CurrentRow.Cells[2].Value);
        //        FKIdChofer = 0;
        //        this.Close();
        //    }
        //    if (FKIdChofer == 3) //Llamada desde el Formulario Registro de Combustible
        //    {
        //        FrmRegCombustible formPadre = Owner as FrmRegCombustible;
        //        formPadre.txtChoferId.Text = iIdChofer.ToString();
        //        formPadre.lblChofer.Text = string.Format("{0} {1}", dgvDatos.CurrentRow.Cells[1].Value, dgvDatos.CurrentRow.Cells[2].Value);
        //        FKIdChofer = 0;
        //        this.Close();
        //    }
        //}

    }
}
