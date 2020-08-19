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
    public partial class FrmTalleres : Form
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

        private static FrmTalleres _instance;
        
        public static FrmTalleres Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmTalleres();
                return _instance;
            }
        }

        private int iIdTaller;
        private bool bModifica = false;

        CETalleres objEntidad = new CETalleres();
        CNTalleres objNegocio = new CNTalleres();

        CNBancos objNegocioBancos = new CNBancos();

        #region Procedimientos

        public void MostrarBuscarTabla(string sBuscar)
        {
            //CNTalleres objNegocio = new CNTalleres();
            dgvDatos.DataSource = objNegocio.MostrarTalleres(sBuscar);
        }

        public void MostrarColumnas()
        {
            dgvDatos.Columns[0].Visible = false;    //IdTaller

            dgvDatos.Columns[1].Visible = true;     //Tal_Nombre
            dgvDatos.Columns[1].Width = 100;        //Tal_Nombre

            dgvDatos.Columns[2].Visible = true;     //Tal_Ruc
            dgvDatos.Columns[2].Width = 100;        //Tal_Ruc

            dgvDatos.Columns[3].Visible = false;    //Banco_Id
            dgvDatos.Columns[4].Visible = false;    //Tal_NumCta

            dgvDatos.Columns[5].Visible = false;    //Tal_Direccion

            dgvDatos.Columns[6].Visible = false;    //Tal_Ubigeo
            dgvDatos.Columns[7].Visible = false;    //Tal_Telefono
            dgvDatos.Columns[8].Visible = false;    //Tal_Activo

            dgvDatos.Columns[9].Visible = false;    //Usuario Creacion
            dgvDatos.Columns[10].Visible = false;   //Fecha Creacion
            dgvDatos.Columns[11].Visible = false;   //Usuario Modificacion
            dgvDatos.Columns[12].Visible = false;   //Fecha Modificacion

            dgvDatos.ClearSelection();
        }

        public void HabilitaControles(bool bValor)
        {
            txtNombre.Enabled = bValor;
            txtRUC.Enabled = bValor;
            txtDireccion.Enabled = bValor;
            //txtUbigeo.Enabled = bValor;
            txtTelefono.Enabled = bValor;
            pbBancoId.Enabled = bValor;
            lblBanco.Enabled = bValor;
            txtNumCta.Enabled = bValor;
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
            txtRUC.Text = "";
            txtDireccion.Text = "";
            //txtUbigeo.Text = "";
            txtTelefono.Text = "";
            txtBancoId.Text = "0";
            lblBanco.Text = "";
            txtNumCta.Text = "";
        }

        private void MostrarAuditoria()
        {
            //Usuario_Creacion = dgvDatos.GetString(4);
            //Fecha_Creacion = drLeerFilas.GetDateTime(5) == null ? Convert.ToDateTime("") : drLeerFilas.GetDateTime(5),
            //Usuario_Modificacion = drLeerFilas.IsDBNull(6) ? "" : drLeerFilas.GetString(6),
            //Fecha_Modificacion = drLeerFilas.IsDBNull(7) ? DateTime.Now : drLeerFilas.GetDateTime(7)
            ToolStripStatusLabel2.Text = dgvDatos.CurrentRow.Cells[9].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[9].Value.ToString();
            ToolStripStatusLabel4.Text = dgvDatos.CurrentRow.Cells[10].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[10].Value.ToString();
            ToolStripStatusLabel6.Text = dgvDatos.CurrentRow.Cells[11].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[11].Value.ToString();
            ToolStripStatusLabel8.Text = dgvDatos.CurrentRow.Cells[12].Value.ToString() == "" ? "..." : dgvDatos.CurrentRow.Cells[12].Value.ToString();
        }

        private void MuestraDatosControles()
        {
            iIdTaller = Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value);
            txtNombre.Text = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            txtRUC.Text = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            txtBancoId.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            txtNumCta.Text = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvDatos.CurrentRow.Cells[5].Value.ToString();
            //txtUbigeo.Text = dgvDatos.CurrentRow.Cells[6].Value.ToString();
            txtTelefono.Text = dgvDatos.CurrentRow.Cells[7].Value.ToString();
        }

        private void BuscaIds()
        {
            if (Convert.ToInt32(txtBancoId.Text) > 0)
            {
                lblBanco.Text = objNegocioBancos.MostrarBancosId(Convert.ToInt32(txtBancoId.Text));
            }
        }

        #endregion

        public FrmTalleres()
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
                MessageBox.Show("Seleccione la fila que desea modificar!!", "Sistema de Transporte");
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
                    objEntidad.Tal_Nombre = txtNombre.Text;
                    objEntidad.Tal_Ruc = txtRUC.Text;
                    objEntidad.Banco_Id = Convert.ToInt32(txtBancoId.Text);
                    objEntidad.Tal_NumCta = txtNumCta.Text;
                    objEntidad.Tal_Direccion = txtDireccion.Text;
                    objEntidad.Tal_Ubigeo = "";  //txtUbigeo.Text;
                    objEntidad.Tal_Telefono = txtTelefono.Text;

                    objEntidad.Usuario_Creacion = "NSOTOMAYOR";   //Usuario logueado al sistema

                    objNegocio.InsertarTalleres(objEntidad);

                    MessageBox.Show("Se agregó el registro!!", "Sistema de Transporte");

                    MostrarBuscarTabla("");
                    LimpiarControles();
                    HabilitaControles(false);
                    HabilitaBotones(true);
                    dgvDatos.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar el registro: " + ex,"Sistema de Transporte");
                }
            }

            if (bModifica == true)
            {
                //Actualiza
                try
                {
                    objEntidad.Tal_Id = iIdTaller;
                    objEntidad.Tal_Nombre = txtNombre.Text;
                    objEntidad.Tal_Ruc = txtRUC.Text;
                    objEntidad.Banco_Id = Convert.ToInt32(txtBancoId.Text);
                    objEntidad.Tal_NumCta = txtNumCta.Text;
                    objEntidad.Tal_Direccion = txtDireccion.Text;
                    objEntidad.Tal_Ubigeo = "";  // txtUbigeo.Text;
                    objEntidad.Tal_Telefono = txtTelefono.Text;

                    objEntidad.Usuario_Modificacion = "NSOTOMAYOR";  //Usuario logueado al sistema

                    objNegocio.ModificarTalleres(objEntidad);

                    MessageBox.Show("Se modificó el registro seleccionado!!","Sistema de Transporte");

                    MostrarBuscarTabla("");
                    LimpiarControles();
                    bModifica = false;
                    HabilitaControles(false);
                    HabilitaBotones(true);
                    dgvDatos.ClearSelection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar el registro seleccionado: " + ex,"Sistema de Transporte");
                }

            }
            
        }

        private void bfbImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción en desarrollo");
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
            MostrarAuditoria();
        }

        private void dgvDatos_KeyUp(object sender, KeyEventArgs e)
        {
            LimpiarControles();
            MuestraDatosControles();
            MostrarAuditoria();
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }

        private void bfbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Realmente desea eliminar los datos?", "Elimina registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                try
                {
                    objEntidad.Tal_Id = iIdTaller;
                    objEntidad.Usuario_Modificacion = "NSOTOMAYOR";  //Usuario logueado al sistema

                    objNegocio.EliminarTalleres(objEntidad);

                    MessageBox.Show("Se eliminó el registro seleccionado!!","Sistema de Transporte");

                    MostrarBuscarTabla("");
                    LimpiarControles();
                    bModifica = false;
                    HabilitaControles(false);
                    HabilitaBotones(true);
                    dgvDatos.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el registro seleccionado: " + ex,"Sistema de Transporte");
                }
            }
        }

        #endregion

        private void pbBancoId_Click(object sender, EventArgs e)
        {
            FrmBancos formhijo = new FrmBancos();
            AddOwnedForm(formhijo);
            formhijo.FKIdBanco = 1;
            formhijo.ShowDialog();
        }

        private void lblBanco_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea borrar el valor del campo?", "Limpiar Campo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);   //preguntamos si esta seguro de eliminar o no los datos
            if (result == DialogResult.OK)
            {
                txtBancoId.Text = "0";
                lblBanco.Text = "";
            }
        }
    }
}
