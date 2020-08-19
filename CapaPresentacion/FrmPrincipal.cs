using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CapaPresentacion.Properties;
using CapaNegocio;
using System.Reflection;
using System.Diagnostics;


namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        Funciones cFuncion = new Funciones();
        CNMenu objMenu = new CNMenu();

        private bool EsExpandidoM1 = false;
        private bool EsExpandidoM2 = false;
        private bool EsExpandidoM3 = false;
        private int iMenu = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void bfbMenu01_Click(object sender, EventArgs e)
        {
            if (!EsExpandidoM1)
            {
                ContraeMenu(iMenu);
                ExpandeMenu(1);
            }
            else
            {
                ContraeMenu(iMenu);
            }
        }

        private void bfbMenu03_Click(object sender, EventArgs e)
        {
            if (!EsExpandidoM3)
            {
                ContraeMenu(iMenu);
                ExpandeMenu(3);
            }
            else
            {
                ContraeMenu(iMenu);
            }
        }

        private void bfbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblNombreSistema.Text = FrmLogin.gPrograma;
            lblVersion.Text = FrmLogin.gVersion;
            
            //Se coloca el codigo necesario para el inicio dle formulario
            //bfbMenu03.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
            for (int i = 1; i <= 3; i++)
            {
                ContraeMenu(i);
            }
            //HabilitaMenu();
        }

        private void HabilitaMenu()
        {
            DataTable Menu = objMenu.HabilitaMenu(FrmLogin.gUsuarioId);
            if (Menu.Rows.Count > 0)
            {
                //Menu Registro
                pnlMenuRegistro.Enabled = (Convert.ToInt32(Menu.Rows[0][0].ToString()) == 1);
                bfbReg_Exportacion.Enabled = (Convert.ToInt32(Menu.Rows[0][1].ToString()) == 1);
                bfbReg_Abonos.Enabled = (Convert.ToInt32(Menu.Rows[0][2].ToString()) == 1);
                bfbReg_NotasDeCredito.Enabled = (Convert.ToInt32(Menu.Rows[0][3].ToString()) == 1);

                //Menu Consultas
                pnlMenuConsultas.Enabled = (Convert.ToInt32(Menu.Rows[0][5].ToString()) == 1);
                bfbCons_Exportaciones.Enabled = (Convert.ToInt32(Menu.Rows[0][6].ToString()) == 1);
                bfbCons_Incidencias.Enabled = (Convert.ToInt32(Menu.Rows[0][7].ToString()) == 1);
                bfbCons_Mantenimientos.Enabled = (Convert.ToInt32(Menu.Rows[0][8].ToString()) == 1);
                bfbCons_SOAT.Enabled = (Convert.ToInt32(Menu.Rows[0][9].ToString()) == 1);

                //Menu Mantenimiento
                pnlMenuMantenimiento.Enabled = (Convert.ToInt32(Menu.Rows[0][10].ToString()) == 1);
                bfbManto_Bancos.Enabled = (Convert.ToInt32(Menu.Rows[0][11].ToString()) == 1);
                bfbManto_Productos.Enabled = (Convert.ToInt32(Menu.Rows[0][12].ToString()) == 1);
                bfbManto_NotaCreditoTipo.Enabled = (Convert.ToInt32(Menu.Rows[0][13].ToString()) == 1);
                bfbManto_Clientes.Enabled = (Convert.ToInt32(Menu.Rows[0][14].ToString()) == 1);
                bfbManto_Usuarios.Enabled = (Convert.ToInt32(Menu.Rows[0][15].ToString()) == 1);
                bfbManto_Operadores.Enabled = (Convert.ToInt32(Menu.Rows[0][16].ToString()) == 1);
                bfbManto_ProductoPresentacion.Enabled = (Convert.ToInt32(Menu.Rows[0][17].ToString()) == 1);
                bfbManto_Puertos.Enabled = (Convert.ToInt32(Menu.Rows[0][18].ToString()) == 1);
            }
        }

        private void ContraeMenu(int iOpcion)
        {
            switch (iOpcion)
            {
                case 1:
                    bfbConsultas.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                    for (int i = 10; pnlMenuConsultas.Height > pnlMenuConsultas.MinimumSize.Height; i = 10)
                    {
                        pnlMenuConsultas.Height -= i;
                    }
                    EsExpandidoM1 = false;
                    iMenu = 0;
                    break;
                case 2:
                    bfbMantenimiento.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                    for (int i = 10; pnlMenuMantenimiento.Height > pnlMenuMantenimiento.MinimumSize.Height; i = 10)
                    {
                        pnlMenuMantenimiento.Height -= i;
                    }
                    EsExpandidoM2 = false;
                    iMenu = 0;
                    break;
                case 3:
                    bfbRegistro.Iconimage_right = Resources.ARROW_DASHBOARD_EXPANDIR;
                    for (int i = 10; pnlMenuRegistro.Height > pnlMenuRegistro.MinimumSize.Height; i = 10)
                    {
                        pnlMenuRegistro.Height -= i;
                    }
                    EsExpandidoM3 = false;
                    iMenu = 0;
                    break;
                default: break;
            }
        }

        private void ExpandeMenu(int iOpcion)
        {
            switch (iOpcion)
            {
                case 1:
                    bfbConsultas.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                    for (int i = pnlMenuConsultas.Height; pnlMenuConsultas.Height < pnlMenuConsultas.MaximumSize.Height; i = 10)
                    {
                        pnlMenuConsultas.Height += i;
                    }
                    EsExpandidoM1 = true;
                    iMenu = 1;
                    break;
                case 2:
                    bfbMantenimiento.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                    for (int i = pnlMenuMantenimiento.Height; pnlMenuMantenimiento.Height < pnlMenuMantenimiento.MaximumSize.Height; i = 10)
                    {
                        pnlMenuMantenimiento.Height += i;
                    }
                    EsExpandidoM2 = true;
                    iMenu = 2;
                    break;
                case 3:
                    bfbRegistro.Iconimage_right = Resources.ARROW_DASHBOARD_CONTRAER;
                    for (int i = pnlMenuRegistro.Height; pnlMenuRegistro.Height < pnlMenuRegistro.MaximumSize.Height; i = 10)
                    {
                        pnlMenuRegistro.Height += i;
                    }
                    EsExpandidoM3 = true;
                    iMenu = 3;
                    break;
                default: break;
            }
        }

        public void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            if (pnlFondoMenu.Width == pnlFondoMenu.MaximumSize.Width)
            {
                pnlFondoMenu.Width = pnlFondoMenu.MinimumSize.Width;
                sbMenu.Width = sbMenu.MinimumSize.Width;
                //panel1.Width = 1306;
                //panel1.Location = new Point(66,0);
                //panel1.Refresh();
            }
            else
            {
                pnlFondoMenu.Width = pnlFondoMenu.MaximumSize.Width;
                sbMenu.Width = sbMenu.MaximumSize.Width;
                //panel1.Width = 1110;
                //panel1.Location = new Point(251, 0);
                //panel1.Refresh();
            }
        }

        #region Mantenimiento

        private void mnuMantenimiento_Click(object sender, EventArgs e)
        {
            if (!EsExpandidoM2)
            {
                ContraeMenu(iMenu);
                ExpandeMenu(2);
            }
            else
            {
                ContraeMenu(iMenu);
            }
        }

        private void bfbManto_Bancos_Click(object sender, EventArgs e)
        {
            ShowForm(FrmBancos.Instance);
        }

        private void bfbManto_Clientes_Click(object sender, EventArgs e)
        {
            ShowForm(FrmClientes.Instance);
        }

        private void bfbManto_NotaCreditoTipo_Click(object sender, EventArgs e)
        {
            ShowForm(FrmNotaCreditoTipo.Instance);
        }

        private void bfbManto_ProductoPresentacion_Click(object sender, EventArgs e)
        {
            ShowForm(FrmProductoPresentacion.Instance);
        }

        private void bfbManto_Usuarios_Click(object sender, EventArgs e)
        {
            if (cFuncion.PuedeEliminar())
            {
                ShowForm(FrmUsuarios.Instance);
            }
            else
            {
                cFuncion.MensajeError("Usted no tiene permisos para esta opción!!");
            }
        }

        private void bfbManto_Operadores_Click(object sender, EventArgs e)
        {
            ShowForm(FrmOperadores.Instance);
        }

        private void bfbManto_Puertos_Click(object sender, EventArgs e)
        {
            ShowForm(FrmPuertos.Instance);
        }

        private void bfbManto_Productos_Click(object sender, EventArgs e)
        {
            ShowForm(FrmProductos.Instance);
        }

        private void bfbManto_Aeropuertos_Click(object sender, EventArgs e)
        {
            ShowForm(FrmAeropuertos.Instance);
        }

        #endregion

        #region Registros

        private void bfbReg_Exportacion_Click(object sender, EventArgs e)
        {
            ShowForm(FrmRegExportaciones.Instance);
        }

        private void bfbReg_Abonos_Click(object sender, EventArgs e)
        {
            ShowForm(FrmRegAbonos.Instance);
        }

        private void bfbReg_NotasDeCredito_Click(object sender, EventArgs e)
        {
            //cFuncion.MensajeAdvertencia("Opción en desarrollo!!");
            ShowForm(FrmRegNotasDeCredito.Instance);
        }
        
        #endregion

        #region Consultas

        private void bfbCons_SOAT_Click(object sender, EventArgs e)
        {
            ShowForm(FrmConsultaSOAT.Instance);
        }

        private void bfbCons_Exportaciones_Click(object sender, EventArgs e)
        {
            //ShowForm(FrmConsultaExportaciones.Instance);
            ShowForm(FrmConsultaExpo.Instance);
        }

        #endregion

        private void bfbCons_Incidencias_Click(object sender, EventArgs e)
        {
            ShowForm(FrmDashboard.Instance);
        }
    }

}
