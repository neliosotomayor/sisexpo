using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using System.Reflection;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {

        public static string gUsuario = string.Empty;
        public static int gUsuarioId = 0;
        public static string gVersion = Application.ProductVersion;    //string.Empty;
        public static string gTitulo = Application.ProductName;
        public static string gPrograma = string.Empty;
        Funciones cFunciones = new Funciones();

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

        private static FrmLogin _instance;
        
        public static FrmLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmLogin();
                return _instance;
            }
        }

        CEUsuario objEntidad = new CEUsuario();
        CNUsuario objNegocio = new CNUsuario();

        #region Procedimientos

        public void HabilitaControles(bool bValor)
        {
            txtUsuario.Enabled = bValor;
            txtPassword.Enabled = bValor;
        }

        private void HabilitaBotones(bool bValor)
        {
            bfbIngresar.Enabled = bValor;
            bfbSalir.Enabled = bValor;
        }

        private void LimpiarControles()
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
        }

        private void BuscaUsuario()
        {
            if (txtUsuario.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                //lblBanco.Text = objNegocioBancos.MostrarBancoId(Convert.ToInt32(txtBancoId.Text));
            }
        }

        private void AccesoSistema()
        {
            string sPassword = Seguridad.GetSHA256(txtPassword.Text.Trim());

            DataTable Datos = objNegocio.ValidaUsuario(txtUsuario.Text, sPassword);
            //Evaluar si existe el Usuario
            if (Datos.Rows.Count == 0)
            {
                cFunciones.MensajeOk("Usuario o Password incorrecto!!");
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal();
                gUsuarioId = Convert.ToInt32(Datos.Rows[0][0].ToString());  //Column Usu_Id
                gUsuario = Datos.Rows[0][3].ToString();  //Columna Usu_Usuario
                                                         //frm.Apellidos = Datos.Rows[0][1].ToString();
                                                         //frm.Nombre = Datos.Rows[0][2].ToString();
                                                         //frm.Acceso = Datos.Rows[0][3].ToString();
                frm.Show();
                this.Hide();
            }
        }

        #endregion

        public FrmLogin()
        {
            var thisApp = Assembly.GetExecutingAssembly();
            AssemblyName name = new AssemblyName(thisApp.FullName);
            gPrograma = name.Name;

            InitializeComponent();
 
            lblTitulo.Text = gTitulo;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //gConexion = Properties.Settings.Default.conectar;
            //gConexion = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;
            //gVersion = Application.ProductVersion;

            lblVersion.Text = gVersion;
            lblFechaHora.Text = DateTime.Now.ToString();
            LimpiarControles();
            HabilitaControles(true);
            HabilitaBotones(true);
            txtUsuario.Focus();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        #region Botones

        private void bfbIngresar_Click(object sender, EventArgs e)
        {
            AccesoSistema();
        }

        private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void bfbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                AccesoSistema();
            }
        }
    }
}
