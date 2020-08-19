using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmDashboard : Form
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

        private static FrmDashboard _instance;
        
        public static FrmDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FrmDashboard();
                return _instance;
            }
        }

        CNDashboard objNegocio = new CNDashboard();

        DataTable dtDatos = new DataTable();
        DataTable dtGrafico = new DataTable();

        #region Procedimientos

        public void MostrarDatos()
        {
            dtDatos = objNegocio.MostrarDatos();
        }

        public void MostrarGrafico(int iOpcion)
        {
            //1 = "UP_DASHBOARD_ARANDANOS";
            //2 = "UP_DASHBOARD_ARVEJA";
            //3 = "UP_DASHBOARD_CURCUMA";
            //4 = "UP_DASHBOARD_GRANADA";
            //5 = "UP_DASHBOARD_JENGIBRE";
            //6 = "UP_DASHBOARD_PALTAS";

            //dtGrafico = objNegocio.MostrarGrafico(iOpcion);

            //ArrayList aPresentacion = new ArrayList();
            //ArrayList aCantidad = new ArrayList();

            //for (int i = 0; i < dtGrafico.Rows.Count; i++)
            //{
            //    aPresentacion.Add(dtGrafico.Rows[i]["Presentacion"].ToString());
            //    aCantidad.Add(Convert.ToInt32(dtGrafico.Rows[i]["Cantidad"].ToString()));
            //}

            //chtGrafico.Series[0].Points.DataBindXY(aPresentacion, aCantidad);   
        }

        private void LimpiarControles()
        {
            lblArandanoCont.Text = "0";
            lblArandanoFact.Text = "$$";

            lblArvejaCont.Text = "0";
            lblArvejaFact.Text = "$$";

            lblCurcumaCont.Text = "0";
            lblCurcumaFact.Text = "$$";

            lblGranadaCont.Text = "0";
            lblGranadaFact.Text = "$$";

            lblJengibreCont.Text = "0";
            lblJengibreFact.Text = "$$";

            lblPaltaCont.Text = "0";
            lblPaltaFact.Text = "$$";
        }
        

        private void MuestraDatosControles()
        {
            lblArandanoCont.Text = dtDatos.Rows[0][0].ToString();
            lblArandanoFact.Text = String.Format("{0:#,###,###.00}", Convert.ToDecimal(dtDatos.Rows[0][1].ToString()));

            lblArvejaCont.Text = dtDatos.Rows[0][2].ToString();
            lblArvejaFact.Text = String.Format("{0:#,###,###.00}", Convert.ToDecimal(dtDatos.Rows[0][3].ToString()));

            lblCurcumaCont.Text = dtDatos.Rows[0][4].ToString();
            lblCurcumaFact.Text = String.Format("{0:#,###,###.00}", Convert.ToDecimal(dtDatos.Rows[0][5].ToString()));

            lblGranadaCont.Text = dtDatos.Rows[0][6].ToString();
            lblGranadaFact.Text = String.Format("{0:#,###,###.00}", Convert.ToDecimal(dtDatos.Rows[0][7].ToString()));

            lblJengibreCont.Text = dtDatos.Rows[0][8].ToString();
            lblJengibreFact.Text = String.Format("{0:#,###,###.00}", Convert.ToDecimal(dtDatos.Rows[0][9].ToString()));

            lblPaltaCont.Text = dtDatos.Rows[0][10].ToString();
            lblPaltaFact.Text = String.Format("{0:#,###,###.00}", Convert.ToDecimal(dtDatos.Rows[0][11].ToString()));
        }

        #endregion

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            MostrarDatos();
            MuestraDatosControles();
            MostrarGrafico(1);
            lblTitulo.Text = string.Format("{0} - .:{1}:.", this.Text, FrmLogin.gUsuario);
        }

        private void FrmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        #region Botones

         private void pnlCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            MueveFormularioNuevo();
        }


        #endregion

    }
}
