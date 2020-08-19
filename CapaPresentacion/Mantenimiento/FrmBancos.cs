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
    public partial class FrmBancos : Form
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

        private static FrmBancos _instance;
        
        public static FrmBancos Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmBancos();
                return _instance;
            }
        }

        public int FKIdBanco = 0;
        private int iIdBanco = 0;
        private bool bModifica = false;

        CEBanco objEntidad = new CEBanco();
        CNBanco objNegocio = new CNBanco();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            dgvDatos.DataSource = objNegocio.MostrarBancos(sBuscar);
        }

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;  //Ban_Id

            dgvDatos.Columns[1].Visible = true;   //Ban_Nombre
            dgvDatos.Columns[1].Width = 100;      //Ban_Nombre

            dgvDatos.Columns[2].Visible = false;  //Usuario Creacion
            dgvDatos.Columns[3].Visible = false;  //Fecha Creacion
            dgvDatos.Columns[4].Visible = false;  //Usuario Modificacion
            dgvDatos.Columns[5].Visible = false;  //Fecha Modificacion

            dgvDatos.ClearSelection();
        }

        public void HabilitaControles(bool bValor)
        {
            txtNombre.Enabled = bValor;
            //bfbGrabar.Enabled = bValor;
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
            ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[2].Value.ToString();
            ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[3].Value.ToString();
            ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[4].Value.ToString();
            ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[5].Value.ToString();
        }

        private void MuestraDatosControles()
        {
            iIdBanco = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
        }

        #endregion

        public FrmBancos()
        {
            InitializeComponent();
        }

        private void FrmBancos_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            MostrarBuscarTabla("");
            MostrarColumnas();
            HabilitaControles(false);
            HabilitaBotones(true);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
        }

        private void FrmBancos_FormClosed(object sender, FormClosedEventArgs e)
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
                if (txtNombre.Text.Length > 0)
                {
                    //Nuevo
                    try
                    {
                        objEntidad.Ban_Nombre = txtNombre.Text;
                        //objEntidad.Ban_Ruc = txtDescripcion.Text;
                        objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                        objNegocio.InsertarBanco(objEntidad);

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
                    cFuncion.MensajeAdvertencia("El campo NOMBRE no puede estar vacio!!");
                }
            }

            if (bModifica == true)
            {
                if (txtNombre.Text.Length > 0)
                {
                    //Actualiza
                    try
                    {
                        objEntidad.Ban_Id = iIdBanco;
                        objEntidad.Ban_Nombre = txtNombre.Text;
                        //objEntidad.Ban_Ruc = txtDescripcion.Text;
                        objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                        objNegocio.ModificarBanco(objEntidad);

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
                else
                {
                    cFuncion.MensajeAdvertencia("El campo NOMBRE no puede estar vacio!!");
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
                        objEntidad.Ban_Id = iIdBanco;
                        //objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                        objNegocio.EliminarBanco(objEntidad);

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

        #endregion

        //private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (FKIdBanco == 1)  //Llamada desde el Formulario Mantenimiento de Talleres
        //    {
        //        FrmTalleres formPadre = Owner as FrmTalleres;
        //        formPadre.txtBancoId.Text = iIdBanco.ToString();
        //        formPadre.lblBanco.Text = string.Format("{0}", dgvDatos.CurrentRow.Cells[1].Value);
        //        FKIdBanco = 0;
        //        this.Close();
        //    }
        //    if (FKIdBanco == 2)  //Llamada desde el Formulario Registro de Leasing
        //    {
        //        FrmRegLeasing formPadre = Owner as FrmRegLeasing;
        //        formPadre.txtBancoId.Text = iIdBanco.ToString();
        //        formPadre.lblBanco.Text = string.Format("{0}", dgvDatos.CurrentRow.Cells[1].Value);
        //        FKIdBanco = 0;
        //        this.Close();
        //    }
        //}

    }
}
