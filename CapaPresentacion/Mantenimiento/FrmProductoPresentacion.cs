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
    public partial class FrmProductoPresentacion : Form
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

        private static FrmProductoPresentacion _instance;
        
        public static FrmProductoPresentacion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmProductoPresentacion();
                return _instance;
            }
        }

        public int FKIdProductoPresentacio = 0;
        private int iIdProductoPresentacion = 0;
        private bool bModifica = false;

        CEProductoPresentacion objEntidad = new CEProductoPresentacion();
        CNProductoPresentacion objNegocio = new CNProductoPresentacion();

        CNProducto objNegocioProducto = new CNProducto();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            //---------CNTalleres objNegocio = new CNTalleres();
            dgvDatos.DataSource = objNegocio.MostrarProductoPresentaciones(sBuscar);
        }

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;    //ProPre_Id

            dgvDatos.Columns[1].Visible = false;    //Producto_Id

            dgvDatos.Columns[2].Visible = true;     //Pro_Nombre
            dgvDatos.Columns[2].Width = 70;         //Pro_Nombre

            dgvDatos.Columns[3].Visible = true;     //ProPre_Descripcion
            dgvDatos.Columns[3].Width = 100;        //ProPre_Descripcion

            dgvDatos.Columns[4].Visible = false;    //ProPre_Kilos

            dgvDatos.Columns[5].Visible = false;    //Usuario Creacion
            dgvDatos.Columns[6].Visible = false;    //Fecha Creacion
            dgvDatos.Columns[7].Visible = false;    //Usuario Modificacion
            dgvDatos.Columns[8].Visible = false;    //Fecha Modificacion

            dgvDatos.ClearSelection();
        }

        public void HabilitaControles(bool bValor)
        {
            lblProducto.Enabled = bValor;
            txtPresentacion.Enabled = bValor;
            txtKilos.Enabled = bValor;
            pbProdcutoId.Enabled = bValor;
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
            txtProductoId.Text = "0";
            lblProducto.Text = "";
            txtPresentacion.Text = "";
            txtKilos.Text = "";
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
            ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[5].Value.ToString();
            ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[6].Value.ToString();
            ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[7].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[7].Value.ToString();
            ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[8].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[8].Value.ToString();
        }

        private void MuestraDatosControles()
        {
            iIdProductoPresentacion = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            txtProductoId.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            txtPresentacion.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            txtKilos.Text = Convert.ToString(dgvDatos.CurrentRow.Cells[4].Value);
        }

        private void BuscaIds()
        {
            if (Convert.ToInt32(txtProductoId.Text) > 0)
            {
                lblProducto.Text = objNegocioProducto.MostrarProductoId(Convert.ToInt32(txtProductoId.Text));
            }
        }

        #endregion

        public FrmProductoPresentacion()
        {
            InitializeComponent();
        }

        private void FrmTalleres_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            MostrarBuscarTabla("");
            MostrarColumnas();
            HabilitaControles(false);
            HabilitaBotones(true);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
        }

        private void FrmTalleres_FormClosed(object sender, FormClosedEventArgs e)
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
            txtPresentacion.Focus();
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
                    objEntidad.Producto_Id = Convert.ToInt32(txtProductoId.Text);
                    objEntidad.ProPre_Descripcion = txtPresentacion.Text;
                    objEntidad.ProPre_Kilos = Convert.ToDecimal(txtKilos.Text);

                    objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                    objNegocio.InsertarProductoPresentacion(objEntidad);

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
                    objEntidad.ProPre_Id = iIdProductoPresentacion;
                    objEntidad.Producto_Id = Convert.ToInt32(txtProductoId.Text);
                    objEntidad.ProPre_Descripcion = txtPresentacion.Text;
                    objEntidad.ProPre_Kilos = Convert.ToDecimal(txtKilos.Text);

                    objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                    objNegocio.ModificarProductoPresentacion(objEntidad);

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
            if (cFuncion.PuedeEliminar())
            {
                DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
                if (result == DialogResult.OK)
                {
                    try
                    {
                        objEntidad.ProPre_Id = iIdProductoPresentacion;
                        //objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                        objNegocio.EliminarProductoPresentacion(objEntidad);

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
            else
            {
                cFuncion.MensajeError("Usted no tiene permisos para eliminar datos!!");
            }
        }

        #endregion

        private void pbProdcutoId_Click(object sender, EventArgs e)
        {
            FrmProductos formhijo = new FrmProductos();
            AddOwnedForm(formhijo);
            formhijo.FKIdProducto = 1;
            formhijo.ShowDialog();
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (FKIdTaller == 1) //Llamada desde el Formulario Vehiculos
            //{
            //    FrmRegMantenimiento formPadre = Owner as FrmRegMantenimiento;
            //    formPadre.txtTallerId.Text = iIdTaller.ToString();
            //    formPadre.lblTaller.Text = string.Format("{0} {1}", dgvDatos.CurrentRow.Cells[1].Value, dgvDatos.CurrentRow.Cells[2].Value);
            //    FKIdTaller = 0;
            //    this.Close();
            //}
        }

        private void lblProducto_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = cFuncion.MensajeConfirmacion("Desea borrar el valor del campo?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                txtProductoId.Text = "0";
                lblProducto.Text = "";
            }
        }
    }
}
