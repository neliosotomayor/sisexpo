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
    public partial class FrmUsuarios : Form
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

        private static FrmUsuarios _instance;
        
        public static FrmUsuarios Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmUsuarios();
                return _instance;
            }
        }

        private int iIdSeguro = 0;
        private bool bModifica = false;

        CEUsuario objEntidad = new CEUsuario();
        CNUsuario objNegocio = new CNUsuario();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            //CNUsuarios objNegocio = new CNUsuarios();
            dgvDatos.DataSource = objNegocio.MostrarUsuarios(sBuscar);
        }

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;   //IdUsuario

            dgvDatos.Columns[1].Visible = true;    //Usu_Nombre
            dgvDatos.Columns[1].Width = 100;       //Usu_Nombre

            dgvDatos.Columns[2].Visible = true;    //Usu_Apellido
            dgvDatos.Columns[2].Width = 100;       //Usu_Apellido

            dgvDatos.Columns[3].Visible = false;   //Usu_Usuario
            dgvDatos.Columns[4].Visible = false;   //Usu_Password

            dgvDatos.Columns[5].Visible = false;   //Usuario Creacion
            dgvDatos.Columns[6].Visible = false;   //Fecha Creacion
            dgvDatos.Columns[7].Visible = false;   //Usuario Modificacion
            dgvDatos.Columns[8].Visible = false;   //Fecha Modificacion

            dgvDatos.ClearSelection();
        }

        public void HabilitaControles(bool bValor)
        {
            txtNombre.Enabled = bValor;
            txtApellido.Enabled = bValor;
            txtUsuario.Enabled = bValor;
            txtPassword.Enabled = bValor;
            txtPassword2.Enabled = bValor;
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
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtPassword2.Text = "";
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
            iIdSeguro = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            txtUsuario.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            txtPassword2.Text= dgvDatos.CurrentRow.Cells[4].Value.ToString();
        }

        #endregion

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            MostrarBuscarTabla("");
            MostrarColumnas();
            HabilitaControles(false);
            HabilitaBotones(true);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
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
                    objEntidad.Usu_Nombre = txtNombre.Text;
                    objEntidad.Usu_Apellido = txtApellido.Text;
                    objEntidad.Usu_Usuario = txtUsuario.Text;
                    objEntidad.Usu_Password = Seguridad.GetSHA256(txtPassword.Text.Trim());

                    objEntidad.Usuario_Creacion = FrmLogin.gUsuario;   //Usuario logueado al sistema

                    objNegocio.InsertarUsuario(objEntidad);

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
                    objEntidad.Usu_Id = iIdSeguro;
                    objEntidad.Usu_Nombre = txtNombre.Text;
                    objEntidad.Usu_Apellido = txtApellido.Text;
                    objEntidad.Usu_Usuario = txtUsuario.Text;
                    objEntidad.Usu_Password = Seguridad.GetSHA256(txtPassword.Text.Trim());

                    objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                    objNegocio.ModificarUsuario(objEntidad);

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
            DialogResult result = cFuncion.MensajeConfirmacion("Realmente desea eliminar los datos?");   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                try
                {
                    objEntidad.Usu_Id = iIdSeguro;
                    objEntidad.Usuario_Modificacion = FrmLogin.gUsuario;  //Usuario logueado al sistema

                    objNegocio.EliminarUsuario(objEntidad);

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

    }
}
