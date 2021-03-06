﻿namespace CapaPresentacion
{
    partial class FrmConsultaExportaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (_instance != null)
                {
                    _instance.Dispose();
                    _instance = null;
                }
                if (objNegocio != null)
                {
                    objNegocio.Dispose();
                    objNegocio = null;
                }
                if (objNegocioExportacionDetalle != null)
                {
                    objNegocioExportacionDetalle.Dispose();
                    objNegocioExportacionDetalle = null;
                }
                if (objProducto != null)
                {
                    objProducto.Dispose();
                    objProducto = null;
                }
                if (objOperador != null)
                {
                    objOperador.Dispose();
                    objOperador = null;
                }
                if (objCliente != null)
                {
                    objCliente.Dispose();
                    objCliente = null;
                }
                if (objPuerto != null)
                {
                    objPuerto.Dispose();
                    objPuerto = null;
                }
                if (objProductoPresentacion != null)
                {
                    objProductoPresentacion.Dispose();
                    objProductoPresentacion = null;
                }
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaExportaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.beRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldoCliente = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTotalAbonos = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalNotasDeCredito = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvNotasDeCredito = new System.Windows.Forms.DataGridView();
            this.dgvAbonos = new System.Windows.Forms.DataGridView();
            this.lblColumnaFactFecha = new System.Windows.Forms.Label();
            this.lblColumnaProducto = new System.Windows.Forms.Label();
            this.lblColumnaFactMonto = new System.Windows.Forms.Label();
            this.lblColumnaFactCajas = new System.Windows.Forms.Label();
            this.lblColumnaFactNro = new System.Windows.Forms.Label();
            this.dgvExportaciones = new System.Windows.Forms.DataGridView();
            this.lblColumnaCliente = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pbLogoBuscar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cmbEstadoNave = new System.Windows.Forms.ComboBox();
            this.lblEstadoNave = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.gbTravesia = new System.Windows.Forms.GroupBox();
            this.lblTerrestre = new System.Windows.Forms.Label();
            this.bcbTerrestre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblMaritimo = new System.Windows.Forms.Label();
            this.bcbMaritimo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblAereo = new System.Windows.Forms.Label();
            this.bcbAereo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.dtpTTA = new System.Windows.Forms.DateTimePicker();
            this.dtpETA = new System.Windows.Forms.DateTimePicker();
            this.dtpTTD = new System.Windows.Forms.DateTimePicker();
            this.dtpETD = new System.Windows.Forms.DateTimePicker();
            this.lblTTD = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTTA = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblPuertoDestinoNombre = new System.Windows.Forms.Label();
            this.txtDestinoId = new System.Windows.Forms.TextBox();
            this.lblPuertoDestino = new System.Windows.Forms.Label();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.lblPuertoOrigenNombre = new System.Windows.Forms.Label();
            this.txtOrigenId = new System.Windows.Forms.TextBox();
            this.lblPuertoOrigen = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.lblETD = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.lblETA = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.txtDUA = new System.Windows.Forms.TextBox();
            this.lblDUA = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.lblContenedor = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.dtpFacturaFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFactura = new System.Windows.Forms.Label();
            this.txtFacturaImporte = new System.Windows.Forms.TextBox();
            this.lblFacturaImporte = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtFacturaCajas = new System.Windows.Forms.TextBox();
            this.lblFacturaCajas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtFacturaNumero = new System.Windows.Forms.TextBox();
            this.lblFacturaNumero = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFacturaFecha = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbDescripcion = new System.Windows.Forms.PictureBox();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lblDetalleTotal = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDetalleFacturaImporte = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDetalleFactura = new System.Windows.Forms.Label();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDetalleExportacion = new System.Windows.Forms.DataGridView();
            this.lblDetalleProducto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.lblDetalleCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDeCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.gbTravesia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).BeginInit();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleExportacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Controls.Add(this.pbCerrar);
            this.pnlCabecera.Controls.Add(this.pbLogo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(920, 38);
            this.pnlCabecera.TabIndex = 0;
            this.pnlCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(40, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consulta de Exportaciones";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(882, 0);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(38, 38);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 1;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(27, 26);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // beRadio
            // 
            this.beRadio.ElipseRadius = 7;
            this.beRadio.TargetControl = this;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel4,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel6,
            this.ToolStripStatusLabel8});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 673);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(920, 22);
            this.StatusStrip1.TabIndex = 22;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.AutoSize = false;
            this.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.ToolStripStatusLabel1.Text = "C:";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.AutoSize = false;
            this.ToolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(150, 17);
            this.ToolStripStatusLabel2.Text = "...";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.AutoSize = false;
            this.ToolStripStatusLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.ToolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(170, 17);
            this.ToolStripStatusLabel4.Text = "...";
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.AutoSize = false;
            this.ToolStripStatusLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.ToolStripStatusLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(45, 17);
            this.ToolStripStatusLabel5.Text = "M:";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.AutoSize = false;
            this.ToolStripStatusLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.ToolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(150, 17);
            this.ToolStripStatusLabel6.Text = "...";
            // 
            // ToolStripStatusLabel8
            // 
            this.ToolStripStatusLabel8.AutoSize = false;
            this.ToolStripStatusLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.ToolStripStatusLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripStatusLabel8.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8";
            this.ToolStripStatusLabel8.Size = new System.Drawing.Size(170, 17);
            this.ToolStripStatusLabel8.Text = "...";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(7, 46);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(904, 620);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(904, 620);
            this.tabPane1.TabIndex = 109;
            this.tabPane1.Text = "Lista de Exportaciones";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Exportaciones Realizadas";
            this.tabNavigationPage1.Controls.Add(this.label23);
            this.tabNavigationPage1.Controls.Add(this.label22);
            this.tabNavigationPage1.Controls.Add(this.label19);
            this.tabNavigationPage1.Controls.Add(this.label18);
            this.tabNavigationPage1.Controls.Add(this.label3);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.Controls.Add(this.lblSaldoCliente);
            this.tabNavigationPage1.Controls.Add(this.pictureBox17);
            this.tabNavigationPage1.Controls.Add(this.label21);
            this.tabNavigationPage1.Controls.Add(this.lblTotalAbonos);
            this.tabNavigationPage1.Controls.Add(this.pictureBox16);
            this.tabNavigationPage1.Controls.Add(this.label6);
            this.tabNavigationPage1.Controls.Add(this.lblTotalNotasDeCredito);
            this.tabNavigationPage1.Controls.Add(this.pictureBox15);
            this.tabNavigationPage1.Controls.Add(this.label2);
            this.tabNavigationPage1.Controls.Add(this.label16);
            this.tabNavigationPage1.Controls.Add(this.label17);
            this.tabNavigationPage1.Controls.Add(this.dgvNotasDeCredito);
            this.tabNavigationPage1.Controls.Add(this.dgvAbonos);
            this.tabNavigationPage1.Controls.Add(this.lblColumnaFactFecha);
            this.tabNavigationPage1.Controls.Add(this.lblColumnaProducto);
            this.tabNavigationPage1.Controls.Add(this.lblColumnaFactMonto);
            this.tabNavigationPage1.Controls.Add(this.lblColumnaFactCajas);
            this.tabNavigationPage1.Controls.Add(this.lblColumnaFactNro);
            this.tabNavigationPage1.Controls.Add(this.dgvExportaciones);
            this.tabNavigationPage1.Controls.Add(this.lblColumnaCliente);
            this.tabNavigationPage1.Controls.Add(this.txtBuscar);
            this.tabNavigationPage1.Controls.Add(this.pbLogoBuscar);
            this.tabNavigationPage1.Controls.Add(this.pbBuscar);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(886, 575);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(807, 325);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 17);
            this.label23.TabIndex = 277;
            this.label23.Text = "Importe";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(695, 325);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 17);
            this.label22.TabIndex = 276;
            this.label22.Text = "NC Nro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(573, 325);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 275;
            this.label19.Text = "Descripción";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(239, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 17);
            this.label18.TabIndex = 274;
            this.label18.Text = "Transferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(362, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 273;
            this.label3.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(149, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 272;
            this.label1.Text = "Fecha";
            // 
            // lblSaldoCliente
            // 
            this.lblSaldoCliente.BackColor = System.Drawing.Color.White;
            this.lblSaldoCliente.Enabled = false;
            this.lblSaldoCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaldoCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblSaldoCliente.Location = new System.Drawing.Point(742, 530);
            this.lblSaldoCliente.Name = "lblSaldoCliente";
            this.lblSaldoCliente.Size = new System.Drawing.Size(120, 18);
            this.lblSaldoCliente.TabIndex = 269;
            this.lblSaldoCliente.Text = "0.00";
            this.lblSaldoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(731, 521);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(142, 37);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 270;
            this.pictureBox17.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gray;
            this.label21.Location = new System.Drawing.Point(597, 527);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 25);
            this.label21.TabIndex = 271;
            this.label21.Text = "Saldo Cliente";
            // 
            // lblTotalAbonos
            // 
            this.lblTotalAbonos.BackColor = System.Drawing.Color.White;
            this.lblTotalAbonos.Enabled = false;
            this.lblTotalAbonos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAbonos.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalAbonos.Location = new System.Drawing.Point(164, 530);
            this.lblTotalAbonos.Name = "lblTotalAbonos";
            this.lblTotalAbonos.Size = new System.Drawing.Size(120, 18);
            this.lblTotalAbonos.TabIndex = 266;
            this.lblTotalAbonos.Text = "0.00";
            this.lblTotalAbonos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.White;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(154, 521);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(142, 37);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 267;
            this.pictureBox16.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(16, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 268;
            this.label6.Text = "Total Abonos";
            // 
            // lblTotalNotasDeCredito
            // 
            this.lblTotalNotasDeCredito.BackColor = System.Drawing.Color.White;
            this.lblTotalNotasDeCredito.Enabled = false;
            this.lblTotalNotasDeCredito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalNotasDeCredito.ForeColor = System.Drawing.Color.Red;
            this.lblTotalNotasDeCredito.Location = new System.Drawing.Point(435, 530);
            this.lblTotalNotasDeCredito.Name = "lblTotalNotasDeCredito";
            this.lblTotalNotasDeCredito.Size = new System.Drawing.Size(120, 18);
            this.lblTotalNotasDeCredito.TabIndex = 263;
            this.lblTotalNotasDeCredito.Text = "0.00";
            this.lblTotalNotasDeCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.White;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(424, 521);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(142, 37);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 264;
            this.pictureBox15.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(329, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 265;
            this.label2.Text = "Total NC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(476, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 123;
            this.label16.Text = "Fecha";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(19, 325);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 17);
            this.label17.TabIndex = 122;
            this.label17.Text = "Banco";
            // 
            // dgvNotasDeCredito
            // 
            this.dgvNotasDeCredito.AllowUserToAddRows = false;
            this.dgvNotasDeCredito.AllowUserToDeleteRows = false;
            this.dgvNotasDeCredito.AllowUserToResizeColumns = false;
            this.dgvNotasDeCredito.AllowUserToResizeRows = false;
            this.dgvNotasDeCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotasDeCredito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotasDeCredito.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotasDeCredito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasDeCredito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotasDeCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasDeCredito.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotasDeCredito.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotasDeCredito.Location = new System.Drawing.Point(466, 345);
            this.dgvNotasDeCredito.MultiSelect = false;
            this.dgvNotasDeCredito.Name = "dgvNotasDeCredito";
            this.dgvNotasDeCredito.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasDeCredito.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNotasDeCredito.RowHeadersVisible = false;
            this.dgvNotasDeCredito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasDeCredito.Size = new System.Drawing.Size(407, 163);
            this.dgvNotasDeCredito.TabIndex = 121;
            // 
            // dgvAbonos
            // 
            this.dgvAbonos.AllowUserToAddRows = false;
            this.dgvAbonos.AllowUserToDeleteRows = false;
            this.dgvAbonos.AllowUserToResizeColumns = false;
            this.dgvAbonos.AllowUserToResizeRows = false;
            this.dgvAbonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAbonos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonos.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbonos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAbonos.Location = new System.Drawing.Point(15, 345);
            this.dgvAbonos.MultiSelect = false;
            this.dgvAbonos.Name = "dgvAbonos";
            this.dgvAbonos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbonos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAbonos.RowHeadersVisible = false;
            this.dgvAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonos.Size = new System.Drawing.Size(407, 163);
            this.dgvAbonos.TabIndex = 120;
            // 
            // lblColumnaFactFecha
            // 
            this.lblColumnaFactFecha.AutoSize = true;
            this.lblColumnaFactFecha.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactFecha.Location = new System.Drawing.Point(224, 69);
            this.lblColumnaFactFecha.Name = "lblColumnaFactFecha";
            this.lblColumnaFactFecha.Size = new System.Drawing.Size(72, 17);
            this.lblColumnaFactFecha.TabIndex = 119;
            this.lblColumnaFactFecha.Text = "Fact.Fecha";
            // 
            // lblColumnaProducto
            // 
            this.lblColumnaProducto.AutoSize = true;
            this.lblColumnaProducto.BackColor = System.Drawing.Color.White;
            this.lblColumnaProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaProducto.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaProducto.Location = new System.Drawing.Point(696, 69);
            this.lblColumnaProducto.Name = "lblColumnaProducto";
            this.lblColumnaProducto.Size = new System.Drawing.Size(64, 17);
            this.lblColumnaProducto.TabIndex = 118;
            this.lblColumnaProducto.Text = "Producto";
            // 
            // lblColumnaFactMonto
            // 
            this.lblColumnaFactMonto.AutoSize = true;
            this.lblColumnaFactMonto.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactMonto.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactMonto.Location = new System.Drawing.Point(611, 69);
            this.lblColumnaFactMonto.Name = "lblColumnaFactMonto";
            this.lblColumnaFactMonto.Size = new System.Drawing.Size(78, 17);
            this.lblColumnaFactMonto.TabIndex = 117;
            this.lblColumnaFactMonto.Text = "Fact.Monto";
            // 
            // lblColumnaFactCajas
            // 
            this.lblColumnaFactCajas.AutoSize = true;
            this.lblColumnaFactCajas.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactCajas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactCajas.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactCajas.Location = new System.Drawing.Point(499, 69);
            this.lblColumnaFactCajas.Name = "lblColumnaFactCajas";
            this.lblColumnaFactCajas.Size = new System.Drawing.Size(69, 17);
            this.lblColumnaFactCajas.TabIndex = 116;
            this.lblColumnaFactCajas.Text = "Fact.Cajas";
            // 
            // lblColumnaFactNro
            // 
            this.lblColumnaFactNro.AutoSize = true;
            this.lblColumnaFactNro.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactNro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactNro.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactNro.Location = new System.Drawing.Point(362, 69);
            this.lblColumnaFactNro.Name = "lblColumnaFactNro";
            this.lblColumnaFactNro.Size = new System.Drawing.Size(60, 17);
            this.lblColumnaFactNro.TabIndex = 115;
            this.lblColumnaFactNro.Text = "Fact.Nro";
            // 
            // dgvExportaciones
            // 
            this.dgvExportaciones.AllowUserToAddRows = false;
            this.dgvExportaciones.AllowUserToDeleteRows = false;
            this.dgvExportaciones.AllowUserToResizeColumns = false;
            this.dgvExportaciones.AllowUserToResizeRows = false;
            this.dgvExportaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExportaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExportaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvExportaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExportaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExportaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportaciones.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExportaciones.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExportaciones.Location = new System.Drawing.Point(15, 89);
            this.dgvExportaciones.MultiSelect = false;
            this.dgvExportaciones.Name = "dgvExportaciones";
            this.dgvExportaciones.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExportaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvExportaciones.RowHeadersVisible = false;
            this.dgvExportaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExportaciones.Size = new System.Drawing.Size(858, 211);
            this.dgvExportaciones.TabIndex = 113;
            this.dgvExportaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvExportaciones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            this.dgvExportaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyUp);
            // 
            // lblColumnaCliente
            // 
            this.lblColumnaCliente.AutoSize = true;
            this.lblColumnaCliente.BackColor = System.Drawing.Color.White;
            this.lblColumnaCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaCliente.Location = new System.Drawing.Point(19, 69);
            this.lblColumnaCliente.Name = "lblColumnaCliente";
            this.lblColumnaCliente.Size = new System.Drawing.Size(51, 17);
            this.lblColumnaCliente.TabIndex = 109;
            this.lblColumnaCliente.Text = "Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(59, 24);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 18);
            this.txtBuscar.TabIndex = 112;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pbLogoBuscar
            // 
            this.pbLogoBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoBuscar.Image")));
            this.pbLogoBuscar.Location = new System.Drawing.Point(21, 16);
            this.pbLogoBuscar.Name = "pbLogoBuscar";
            this.pbLogoBuscar.Size = new System.Drawing.Size(32, 33);
            this.pbLogoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoBuscar.TabIndex = 111;
            this.pbLogoBuscar.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(15, 14);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(313, 37);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 110;
            this.pbBuscar.TabStop = false;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.Caption = "Mantenimiento de Exportaciones";
            this.tabNavigationPage2.Controls.Add(this.cmbEstadoNave);
            this.tabNavigationPage2.Controls.Add(this.lblEstadoNave);
            this.tabNavigationPage2.Controls.Add(this.pictureBox13);
            this.tabNavigationPage2.Controls.Add(this.gbTravesia);
            this.tabNavigationPage2.Controls.Add(this.txtDUA);
            this.tabNavigationPage2.Controls.Add(this.lblDUA);
            this.tabNavigationPage2.Controls.Add(this.pictureBox11);
            this.tabNavigationPage2.Controls.Add(this.txtBooking);
            this.tabNavigationPage2.Controls.Add(this.lblBooking);
            this.tabNavigationPage2.Controls.Add(this.pictureBox10);
            this.tabNavigationPage2.Controls.Add(this.txtContenedor);
            this.tabNavigationPage2.Controls.Add(this.lblContenedor);
            this.tabNavigationPage2.Controls.Add(this.pictureBox8);
            this.tabNavigationPage2.Controls.Add(this.cmbOperador);
            this.tabNavigationPage2.Controls.Add(this.lblOperador);
            this.tabNavigationPage2.Controls.Add(this.pictureBox6);
            this.tabNavigationPage2.Controls.Add(this.gbFactura);
            this.tabNavigationPage2.Controls.Add(this.cmbProducto);
            this.tabNavigationPage2.Controls.Add(this.txtComentario);
            this.tabNavigationPage2.Controls.Add(this.lblComentario);
            this.tabNavigationPage2.Controls.Add(this.pictureBox1);
            this.tabNavigationPage2.Controls.Add(this.lblClienteNombre);
            this.tabNavigationPage2.Controls.Add(this.txtClienteId);
            this.tabNavigationPage2.Controls.Add(this.lblCliente);
            this.tabNavigationPage2.Controls.Add(this.pictureBox7);
            this.tabNavigationPage2.Controls.Add(this.lblDescripcion);
            this.tabNavigationPage2.Controls.Add(this.pbDescripcion);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(886, 575);
            // 
            // cmbEstadoNave
            // 
            this.cmbEstadoNave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoNave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstadoNave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoNave.FormattingEnabled = true;
            this.cmbEstadoNave.Location = new System.Drawing.Point(645, 315);
            this.cmbEstadoNave.Name = "cmbEstadoNave";
            this.cmbEstadoNave.Size = new System.Drawing.Size(120, 25);
            this.cmbEstadoNave.TabIndex = 160;
            // 
            // lblEstadoNave
            // 
            this.lblEstadoNave.AutoSize = true;
            this.lblEstadoNave.BackColor = System.Drawing.Color.White;
            this.lblEstadoNave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoNave.ForeColor = System.Drawing.Color.Gray;
            this.lblEstadoNave.Location = new System.Drawing.Point(631, 289);
            this.lblEstadoNave.Name = "lblEstadoNave";
            this.lblEstadoNave.Size = new System.Drawing.Size(84, 17);
            this.lblEstadoNave.TabIndex = 162;
            this.lblEstadoNave.Text = "Estado Nave";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(634, 309);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(144, 37);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 161;
            this.pictureBox13.TabStop = false;
            // 
            // gbTravesia
            // 
            this.gbTravesia.BackColor = System.Drawing.Color.White;
            this.gbTravesia.Controls.Add(this.lblTerrestre);
            this.gbTravesia.Controls.Add(this.bcbTerrestre);
            this.gbTravesia.Controls.Add(this.lblMaritimo);
            this.gbTravesia.Controls.Add(this.bcbMaritimo);
            this.gbTravesia.Controls.Add(this.lblAereo);
            this.gbTravesia.Controls.Add(this.bcbAereo);
            this.gbTravesia.Controls.Add(this.label13);
            this.gbTravesia.Controls.Add(this.pictureBox27);
            this.gbTravesia.Controls.Add(this.dtpTTA);
            this.gbTravesia.Controls.Add(this.dtpETA);
            this.gbTravesia.Controls.Add(this.dtpTTD);
            this.gbTravesia.Controls.Add(this.dtpETD);
            this.gbTravesia.Controls.Add(this.lblTTD);
            this.gbTravesia.Controls.Add(this.pictureBox5);
            this.gbTravesia.Controls.Add(this.lblTTA);
            this.gbTravesia.Controls.Add(this.pictureBox12);
            this.gbTravesia.Controls.Add(this.lblPuertoDestinoNombre);
            this.gbTravesia.Controls.Add(this.txtDestinoId);
            this.gbTravesia.Controls.Add(this.lblPuertoDestino);
            this.gbTravesia.Controls.Add(this.pictureBox20);
            this.gbTravesia.Controls.Add(this.lblPuertoOrigenNombre);
            this.gbTravesia.Controls.Add(this.txtOrigenId);
            this.gbTravesia.Controls.Add(this.lblPuertoOrigen);
            this.gbTravesia.Controls.Add(this.pictureBox19);
            this.gbTravesia.Controls.Add(this.lblETD);
            this.gbTravesia.Controls.Add(this.pictureBox18);
            this.gbTravesia.Controls.Add(this.lblETA);
            this.gbTravesia.Controls.Add(this.pictureBox14);
            this.gbTravesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTravesia.ForeColor = System.Drawing.Color.Black;
            this.gbTravesia.Location = new System.Drawing.Point(24, 358);
            this.gbTravesia.Name = "gbTravesia";
            this.gbTravesia.Size = new System.Drawing.Size(835, 159);
            this.gbTravesia.TabIndex = 153;
            this.gbTravesia.TabStop = false;
            // 
            // lblTerrestre
            // 
            this.lblTerrestre.AutoSize = true;
            this.lblTerrestre.BackColor = System.Drawing.Color.White;
            this.lblTerrestre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerrestre.ForeColor = System.Drawing.Color.Gray;
            this.lblTerrestre.Location = new System.Drawing.Point(84, 111);
            this.lblTerrestre.Name = "lblTerrestre";
            this.lblTerrestre.Size = new System.Drawing.Size(76, 17);
            this.lblTerrestre.TabIndex = 187;
            this.lblTerrestre.Text = "TERRESTRE";
            // 
            // bcbTerrestre
            // 
            this.bcbTerrestre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbTerrestre.ChechedOffColor = System.Drawing.Color.Red;
            this.bcbTerrestre.Checked = false;
            this.bcbTerrestre.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbTerrestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbTerrestre.Location = new System.Drawing.Point(57, 110);
            this.bcbTerrestre.Name = "bcbTerrestre";
            this.bcbTerrestre.Size = new System.Drawing.Size(20, 20);
            this.bcbTerrestre.TabIndex = 186;
            this.bcbTerrestre.OnChange += new System.EventHandler(this.bcbTerrestre_OnChange);
            // 
            // lblMaritimo
            // 
            this.lblMaritimo.AutoSize = true;
            this.lblMaritimo.BackColor = System.Drawing.Color.White;
            this.lblMaritimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritimo.ForeColor = System.Drawing.Color.Gray;
            this.lblMaritimo.Location = new System.Drawing.Point(84, 85);
            this.lblMaritimo.Name = "lblMaritimo";
            this.lblMaritimo.Size = new System.Drawing.Size(75, 17);
            this.lblMaritimo.TabIndex = 185;
            this.lblMaritimo.Text = "MARITIMO";
            // 
            // bcbMaritimo
            // 
            this.bcbMaritimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbMaritimo.ChechedOffColor = System.Drawing.Color.Red;
            this.bcbMaritimo.Checked = false;
            this.bcbMaritimo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbMaritimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbMaritimo.Location = new System.Drawing.Point(57, 84);
            this.bcbMaritimo.Name = "bcbMaritimo";
            this.bcbMaritimo.Size = new System.Drawing.Size(20, 20);
            this.bcbMaritimo.TabIndex = 184;
            this.bcbMaritimo.OnChange += new System.EventHandler(this.bcbMaritimo_OnChange);
            // 
            // lblAereo
            // 
            this.lblAereo.AutoSize = true;
            this.lblAereo.BackColor = System.Drawing.Color.White;
            this.lblAereo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAereo.ForeColor = System.Drawing.Color.Gray;
            this.lblAereo.Location = new System.Drawing.Point(84, 59);
            this.lblAereo.Name = "lblAereo";
            this.lblAereo.Size = new System.Drawing.Size(49, 17);
            this.lblAereo.TabIndex = 183;
            this.lblAereo.Text = "AEREO";
            // 
            // bcbAereo
            // 
            this.bcbAereo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbAereo.ChechedOffColor = System.Drawing.Color.Red;
            this.bcbAereo.Checked = true;
            this.bcbAereo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbAereo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbAereo.Location = new System.Drawing.Point(57, 58);
            this.bcbAereo.Name = "bcbAereo";
            this.bcbAereo.Size = new System.Drawing.Size(20, 20);
            this.bcbAereo.TabIndex = 182;
            this.bcbAereo.OnChange += new System.EventHandler(this.bcbAereo_OnChange);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(9, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 181;
            this.label13.Text = "Tipo de Transporte";
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(12, 40);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(190, 103);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 180;
            this.pictureBox27.TabStop = false;
            // 
            // dtpTTA
            // 
            this.dtpTTA.CustomFormat = " ";
            this.dtpTTA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTTA.Location = new System.Drawing.Point(699, 115);
            this.dtpTTA.Name = "dtpTTA";
            this.dtpTTA.Size = new System.Drawing.Size(95, 20);
            this.dtpTTA.TabIndex = 178;
            this.dtpTTA.ValueChanged += new System.EventHandler(this.dtpTTA_ValueChanged);
            this.dtpTTA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTTA_KeyDown);
            // 
            // dtpETA
            // 
            this.dtpETA.CustomFormat = " ";
            this.dtpETA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETA.Location = new System.Drawing.Point(531, 115);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.Size = new System.Drawing.Size(95, 20);
            this.dtpETA.TabIndex = 177;
            this.dtpETA.ValueChanged += new System.EventHandler(this.dtpETA_ValueChanged);
            this.dtpETA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpETA_KeyDown);
            // 
            // dtpTTD
            // 
            this.dtpTTD.CustomFormat = " ";
            this.dtpTTD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTTD.Location = new System.Drawing.Point(699, 49);
            this.dtpTTD.Name = "dtpTTD";
            this.dtpTTD.Size = new System.Drawing.Size(95, 20);
            this.dtpTTD.TabIndex = 176;
            this.dtpTTD.ValueChanged += new System.EventHandler(this.dtpTTD_ValueChanged);
            this.dtpTTD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpTTD_KeyDown);
            // 
            // dtpETD
            // 
            this.dtpETD.CustomFormat = " ";
            this.dtpETD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpETD.Location = new System.Drawing.Point(531, 49);
            this.dtpETD.Name = "dtpETD";
            this.dtpETD.Size = new System.Drawing.Size(95, 20);
            this.dtpETD.TabIndex = 175;
            this.dtpETD.ValueChanged += new System.EventHandler(this.dtpETD_ValueChanged);
            this.dtpETD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpETD_KeyDown);
            // 
            // lblTTD
            // 
            this.lblTTD.AutoSize = true;
            this.lblTTD.BackColor = System.Drawing.Color.White;
            this.lblTTD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTD.ForeColor = System.Drawing.Color.Gray;
            this.lblTTD.Location = new System.Drawing.Point(685, 20);
            this.lblTTD.Name = "lblTTD";
            this.lblTTD.Size = new System.Drawing.Size(34, 17);
            this.lblTTD.TabIndex = 174;
            this.lblTTD.Text = "TTD";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(688, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 173;
            this.pictureBox5.TabStop = false;
            // 
            // lblTTA
            // 
            this.lblTTA.AutoSize = true;
            this.lblTTA.BackColor = System.Drawing.Color.White;
            this.lblTTA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTTA.ForeColor = System.Drawing.Color.Gray;
            this.lblTTA.Location = new System.Drawing.Point(685, 86);
            this.lblTTA.Name = "lblTTA";
            this.lblTTA.Size = new System.Drawing.Size(32, 17);
            this.lblTTA.TabIndex = 171;
            this.lblTTA.Text = "TTA";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(688, 106);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(119, 37);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 170;
            this.pictureBox12.TabStop = false;
            // 
            // lblPuertoDestinoNombre
            // 
            this.lblPuertoDestinoNombre.BackColor = System.Drawing.Color.White;
            this.lblPuertoDestinoNombre.Enabled = false;
            this.lblPuertoDestinoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPuertoDestinoNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblPuertoDestinoNombre.Location = new System.Drawing.Point(253, 115);
            this.lblPuertoDestinoNombre.Name = "lblPuertoDestinoNombre";
            this.lblPuertoDestinoNombre.Size = new System.Drawing.Size(188, 18);
            this.lblPuertoDestinoNombre.TabIndex = 165;
            this.lblPuertoDestinoNombre.Text = "Destino";
            this.lblPuertoDestinoNombre.DoubleClick += new System.EventHandler(this.lblPuertoDestinoNombre_DoubleClick);
            // 
            // txtDestinoId
            // 
            this.txtDestinoId.BackColor = System.Drawing.Color.Yellow;
            this.txtDestinoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDestinoId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestinoId.Location = new System.Drawing.Point(357, 86);
            this.txtDestinoId.Name = "txtDestinoId";
            this.txtDestinoId.ReadOnly = true;
            this.txtDestinoId.Size = new System.Drawing.Size(52, 18);
            this.txtDestinoId.TabIndex = 169;
            this.txtDestinoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDestinoId.Visible = false;
            // 
            // lblPuertoDestino
            // 
            this.lblPuertoDestino.AutoSize = true;
            this.lblPuertoDestino.BackColor = System.Drawing.Color.White;
            this.lblPuertoDestino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertoDestino.ForeColor = System.Drawing.Color.Gray;
            this.lblPuertoDestino.Location = new System.Drawing.Point(239, 86);
            this.lblPuertoDestino.Name = "lblPuertoDestino";
            this.lblPuertoDestino.Size = new System.Drawing.Size(56, 17);
            this.lblPuertoDestino.TabIndex = 167;
            this.lblPuertoDestino.Text = "Destino";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(242, 106);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(228, 37);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 166;
            this.pictureBox20.TabStop = false;
            // 
            // lblPuertoOrigenNombre
            // 
            this.lblPuertoOrigenNombre.BackColor = System.Drawing.Color.White;
            this.lblPuertoOrigenNombre.Enabled = false;
            this.lblPuertoOrigenNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPuertoOrigenNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblPuertoOrigenNombre.Location = new System.Drawing.Point(253, 49);
            this.lblPuertoOrigenNombre.Name = "lblPuertoOrigenNombre";
            this.lblPuertoOrigenNombre.Size = new System.Drawing.Size(188, 18);
            this.lblPuertoOrigenNombre.TabIndex = 160;
            this.lblPuertoOrigenNombre.Text = "Origen";
            this.lblPuertoOrigenNombre.DoubleClick += new System.EventHandler(this.lblPuertoOrigenNombre_DoubleClick);
            // 
            // txtOrigenId
            // 
            this.txtOrigenId.BackColor = System.Drawing.Color.Yellow;
            this.txtOrigenId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrigenId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrigenId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrigenId.Location = new System.Drawing.Point(357, 20);
            this.txtOrigenId.Name = "txtOrigenId";
            this.txtOrigenId.ReadOnly = true;
            this.txtOrigenId.Size = new System.Drawing.Size(52, 18);
            this.txtOrigenId.TabIndex = 164;
            this.txtOrigenId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOrigenId.Visible = false;
            // 
            // lblPuertoOrigen
            // 
            this.lblPuertoOrigen.AutoSize = true;
            this.lblPuertoOrigen.BackColor = System.Drawing.Color.White;
            this.lblPuertoOrigen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuertoOrigen.ForeColor = System.Drawing.Color.Gray;
            this.lblPuertoOrigen.Location = new System.Drawing.Point(239, 20);
            this.lblPuertoOrigen.Name = "lblPuertoOrigen";
            this.lblPuertoOrigen.Size = new System.Drawing.Size(50, 17);
            this.lblPuertoOrigen.TabIndex = 162;
            this.lblPuertoOrigen.Text = "Origen";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(242, 40);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(228, 37);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 161;
            this.pictureBox19.TabStop = false;
            // 
            // lblETD
            // 
            this.lblETD.AutoSize = true;
            this.lblETD.BackColor = System.Drawing.Color.White;
            this.lblETD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETD.ForeColor = System.Drawing.Color.Gray;
            this.lblETD.Location = new System.Drawing.Point(517, 20);
            this.lblETD.Name = "lblETD";
            this.lblETD.Size = new System.Drawing.Size(33, 17);
            this.lblETD.TabIndex = 154;
            this.lblETD.Text = "ETD";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(520, 40);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(119, 37);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 153;
            this.pictureBox18.TabStop = false;
            // 
            // lblETA
            // 
            this.lblETA.AutoSize = true;
            this.lblETA.BackColor = System.Drawing.Color.White;
            this.lblETA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblETA.ForeColor = System.Drawing.Color.Gray;
            this.lblETA.Location = new System.Drawing.Point(517, 86);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(31, 17);
            this.lblETA.TabIndex = 107;
            this.lblETA.Text = "ETA";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(520, 106);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(119, 37);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 106;
            this.pictureBox14.TabStop = false;
            // 
            // txtDUA
            // 
            this.txtDUA.BackColor = System.Drawing.Color.White;
            this.txtDUA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDUA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDUA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDUA.Location = new System.Drawing.Point(472, 318);
            this.txtDUA.MaxLength = 10;
            this.txtDUA.Name = "txtDUA";
            this.txtDUA.Size = new System.Drawing.Size(120, 18);
            this.txtDUA.TabIndex = 159;
            // 
            // lblDUA
            // 
            this.lblDUA.AutoSize = true;
            this.lblDUA.BackColor = System.Drawing.Color.White;
            this.lblDUA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUA.ForeColor = System.Drawing.Color.Gray;
            this.lblDUA.Location = new System.Drawing.Point(458, 289);
            this.lblDUA.Name = "lblDUA";
            this.lblDUA.Size = new System.Drawing.Size(36, 17);
            this.lblDUA.TabIndex = 158;
            this.lblDUA.Text = "DUA";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(461, 309);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(144, 37);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 157;
            this.pictureBox11.TabStop = false;
            // 
            // txtBooking
            // 
            this.txtBooking.BackColor = System.Drawing.Color.White;
            this.txtBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBooking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBooking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBooking.Location = new System.Drawing.Point(301, 318);
            this.txtBooking.MaxLength = 20;
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(120, 18);
            this.txtBooking.TabIndex = 156;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.BackColor = System.Drawing.Color.White;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.Color.Gray;
            this.lblBooking.Location = new System.Drawing.Point(287, 289);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(59, 17);
            this.lblBooking.TabIndex = 155;
            this.lblBooking.Text = "Booking";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(290, 309);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(144, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 154;
            this.pictureBox10.TabStop = false;
            // 
            // txtContenedor
            // 
            this.txtContenedor.BackColor = System.Drawing.Color.White;
            this.txtContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContenedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContenedor.Location = new System.Drawing.Point(117, 318);
            this.txtContenedor.MaxLength = 20;
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(120, 18);
            this.txtContenedor.TabIndex = 153;
            // 
            // lblContenedor
            // 
            this.lblContenedor.AutoSize = true;
            this.lblContenedor.BackColor = System.Drawing.Color.White;
            this.lblContenedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenedor.ForeColor = System.Drawing.Color.Gray;
            this.lblContenedor.Location = new System.Drawing.Point(103, 289);
            this.lblContenedor.Name = "lblContenedor";
            this.lblContenedor.Size = new System.Drawing.Size(80, 17);
            this.lblContenedor.TabIndex = 152;
            this.lblContenedor.Text = "Contenedor";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(106, 309);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(144, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 151;
            this.pictureBox8.TabStop = false;
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(590, 79);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(183, 25);
            this.cmbOperador.TabIndex = 148;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.White;
            this.lblOperador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.Gray;
            this.lblOperador.Location = new System.Drawing.Point(576, 53);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(66, 17);
            this.lblOperador.TabIndex = 150;
            this.lblOperador.Text = "Operador";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(579, 73);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(206, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 149;
            this.pictureBox6.TabStop = false;
            // 
            // gbFactura
            // 
            this.gbFactura.BackColor = System.Drawing.Color.White;
            this.gbFactura.Controls.Add(this.dtpFacturaFecha);
            this.gbFactura.Controls.Add(this.lblFactura);
            this.gbFactura.Controls.Add(this.txtFacturaImporte);
            this.gbFactura.Controls.Add(this.lblFacturaImporte);
            this.gbFactura.Controls.Add(this.pictureBox4);
            this.gbFactura.Controls.Add(this.txtFacturaCajas);
            this.gbFactura.Controls.Add(this.lblFacturaCajas);
            this.gbFactura.Controls.Add(this.pictureBox3);
            this.gbFactura.Controls.Add(this.txtFacturaNumero);
            this.gbFactura.Controls.Add(this.lblFacturaNumero);
            this.gbFactura.Controls.Add(this.pictureBox2);
            this.gbFactura.Controls.Add(this.lblFacturaFecha);
            this.gbFactura.Controls.Add(this.pictureBox9);
            this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.ForeColor = System.Drawing.Color.Black;
            this.gbFactura.Location = new System.Drawing.Point(91, 117);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(310, 159);
            this.gbFactura.TabIndex = 147;
            this.gbFactura.TabStop = false;
            // 
            // dtpFacturaFecha
            // 
            this.dtpFacturaFecha.CustomFormat = " ";
            this.dtpFacturaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFacturaFecha.Location = new System.Drawing.Point(27, 49);
            this.dtpFacturaFecha.Name = "dtpFacturaFecha";
            this.dtpFacturaFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFacturaFecha.TabIndex = 165;
            this.dtpFacturaFecha.ValueChanged += new System.EventHandler(this.dtpFacturaFecha_ValueChanged);
            this.dtpFacturaFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFacturaFecha_KeyDown);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.BackColor = System.Drawing.Color.White;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.Gray;
            this.lblFactura.Location = new System.Drawing.Point(-2, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(138, 17);
            this.lblFactura.TabIndex = 160;
            this.lblFactura.Text = "*** F A C T U R A  ***";
            // 
            // txtFacturaImporte
            // 
            this.txtFacturaImporte.BackColor = System.Drawing.Color.White;
            this.txtFacturaImporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacturaImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacturaImporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFacturaImporte.Location = new System.Drawing.Point(160, 115);
            this.txtFacturaImporte.MaxLength = 10;
            this.txtFacturaImporte.Name = "txtFacturaImporte";
            this.txtFacturaImporte.Size = new System.Drawing.Size(110, 18);
            this.txtFacturaImporte.TabIndex = 152;
            this.txtFacturaImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFacturaImporte
            // 
            this.lblFacturaImporte.AutoSize = true;
            this.lblFacturaImporte.BackColor = System.Drawing.Color.White;
            this.lblFacturaImporte.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaImporte.ForeColor = System.Drawing.Color.Gray;
            this.lblFacturaImporte.Location = new System.Drawing.Point(146, 86);
            this.lblFacturaImporte.Name = "lblFacturaImporte";
            this.lblFacturaImporte.Size = new System.Drawing.Size(57, 17);
            this.lblFacturaImporte.TabIndex = 151;
            this.lblFacturaImporte.Text = "Importe";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(149, 106);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 150;
            this.pictureBox4.TabStop = false;
            // 
            // txtFacturaCajas
            // 
            this.txtFacturaCajas.BackColor = System.Drawing.Color.White;
            this.txtFacturaCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacturaCajas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacturaCajas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFacturaCajas.Location = new System.Drawing.Point(26, 115);
            this.txtFacturaCajas.MaxLength = 10;
            this.txtFacturaCajas.Name = "txtFacturaCajas";
            this.txtFacturaCajas.Size = new System.Drawing.Size(96, 18);
            this.txtFacturaCajas.TabIndex = 149;
            this.txtFacturaCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFacturaCajas
            // 
            this.lblFacturaCajas.AutoSize = true;
            this.lblFacturaCajas.BackColor = System.Drawing.Color.White;
            this.lblFacturaCajas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaCajas.ForeColor = System.Drawing.Color.Gray;
            this.lblFacturaCajas.Location = new System.Drawing.Point(12, 86);
            this.lblFacturaCajas.Name = "lblFacturaCajas";
            this.lblFacturaCajas.Size = new System.Drawing.Size(40, 17);
            this.lblFacturaCajas.TabIndex = 148;
            this.lblFacturaCajas.Text = "Cajas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 147;
            this.pictureBox3.TabStop = false;
            // 
            // txtFacturaNumero
            // 
            this.txtFacturaNumero.BackColor = System.Drawing.Color.White;
            this.txtFacturaNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacturaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacturaNumero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFacturaNumero.Location = new System.Drawing.Point(160, 49);
            this.txtFacturaNumero.MaxLength = 20;
            this.txtFacturaNumero.Name = "txtFacturaNumero";
            this.txtFacturaNumero.Size = new System.Drawing.Size(110, 18);
            this.txtFacturaNumero.TabIndex = 143;
            // 
            // lblFacturaNumero
            // 
            this.lblFacturaNumero.AutoSize = true;
            this.lblFacturaNumero.BackColor = System.Drawing.Color.White;
            this.lblFacturaNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaNumero.ForeColor = System.Drawing.Color.Gray;
            this.lblFacturaNumero.Location = new System.Drawing.Point(146, 20);
            this.lblFacturaNumero.Name = "lblFacturaNumero";
            this.lblFacturaNumero.Size = new System.Drawing.Size(58, 17);
            this.lblFacturaNumero.TabIndex = 142;
            this.lblFacturaNumero.Text = "Número";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(149, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 141;
            this.pictureBox2.TabStop = false;
            // 
            // lblFacturaFecha
            // 
            this.lblFacturaFecha.AutoSize = true;
            this.lblFacturaFecha.BackColor = System.Drawing.Color.White;
            this.lblFacturaFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblFacturaFecha.Location = new System.Drawing.Point(12, 20);
            this.lblFacturaFecha.Name = "lblFacturaFecha";
            this.lblFacturaFecha.Size = new System.Drawing.Size(43, 17);
            this.lblFacturaFecha.TabIndex = 107;
            this.lblFacturaFecha.Text = "Fecha";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(15, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(119, 37);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 106;
            this.pictureBox9.TabStop = false;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(363, 79);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(183, 25);
            this.cmbProducto.TabIndex = 113;
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComentario.Location = new System.Drawing.Point(438, 149);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(328, 114);
            this.txtComentario.TabIndex = 115;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.White;
            this.lblComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.Gray;
            this.lblComentario.Location = new System.Drawing.Point(424, 116);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(80, 17);
            this.lblComentario.TabIndex = 123;
            this.lblComentario.Text = "Comentario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.BackColor = System.Drawing.Color.White;
            this.lblClienteNombre.Enabled = false;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClienteNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblClienteNombre.Location = new System.Drawing.Point(103, 82);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(210, 18);
            this.lblClienteNombre.TabIndex = 111;
            this.lblClienteNombre.Text = "Cliente";
            this.lblClienteNombre.DoubleClick += new System.EventHandler(this.lblClienteNombre_DoubleClick);
            // 
            // txtClienteId
            // 
            this.txtClienteId.BackColor = System.Drawing.Color.Yellow;
            this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClienteId.Location = new System.Drawing.Point(162, 53);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(52, 18);
            this.txtClienteId.TabIndex = 121;
            this.txtClienteId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClienteId.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblCliente.Location = new System.Drawing.Point(89, 53);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 119;
            this.lblCliente.Text = "Cliente";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(92, 73);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(243, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 118;
            this.pictureBox7.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(349, 53);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(64, 17);
            this.lblDescripcion.TabIndex = 116;
            this.lblDescripcion.Text = "Producto";
            // 
            // pbDescripcion
            // 
            this.pbDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("pbDescripcion.Image")));
            this.pbDescripcion.Location = new System.Drawing.Point(352, 73);
            this.pbDescripcion.Name = "pbDescripcion";
            this.pbDescripcion.Size = new System.Drawing.Size(206, 37);
            this.pbDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescripcion.TabIndex = 114;
            this.pbDescripcion.TabStop = false;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Detalle de la Exportación";
            this.tabNavigationPage3.Controls.Add(this.lblDetalleTotal);
            this.tabNavigationPage3.Controls.Add(this.pictureBox26);
            this.tabNavigationPage3.Controls.Add(this.label15);
            this.tabNavigationPage3.Controls.Add(this.lblDetalleFacturaImporte);
            this.tabNavigationPage3.Controls.Add(this.pictureBox25);
            this.tabNavigationPage3.Controls.Add(this.label14);
            this.tabNavigationPage3.Controls.Add(this.lblDetalleFactura);
            this.tabNavigationPage3.Controls.Add(this.pictureBox23);
            this.tabNavigationPage3.Controls.Add(this.label12);
            this.tabNavigationPage3.Controls.Add(this.label11);
            this.tabNavigationPage3.Controls.Add(this.label4);
            this.tabNavigationPage3.Controls.Add(this.label8);
            this.tabNavigationPage3.Controls.Add(this.label9);
            this.tabNavigationPage3.Controls.Add(this.label10);
            this.tabNavigationPage3.Controls.Add(this.dgvDetalleExportacion);
            this.tabNavigationPage3.Controls.Add(this.lblDetalleProducto);
            this.tabNavigationPage3.Controls.Add(this.label7);
            this.tabNavigationPage3.Controls.Add(this.pictureBox22);
            this.tabNavigationPage3.Controls.Add(this.lblDetalleCliente);
            this.tabNavigationPage3.Controls.Add(this.label5);
            this.tabNavigationPage3.Controls.Add(this.pictureBox21);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(886, 575);
            // 
            // lblDetalleTotal
            // 
            this.lblDetalleTotal.BackColor = System.Drawing.Color.White;
            this.lblDetalleTotal.Enabled = false;
            this.lblDetalleTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblDetalleTotal.Location = new System.Drawing.Point(730, 390);
            this.lblDetalleTotal.Name = "lblDetalleTotal";
            this.lblDetalleTotal.Size = new System.Drawing.Size(120, 18);
            this.lblDetalleTotal.TabIndex = 260;
            this.lblDetalleTotal.Text = "0.00";
            this.lblDetalleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(719, 381);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(142, 37);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 261;
            this.pictureBox26.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(597, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 17);
            this.label15.TabIndex = 262;
            this.label15.Text = "Total Exportación";
            // 
            // lblDetalleFacturaImporte
            // 
            this.lblDetalleFacturaImporte.BackColor = System.Drawing.Color.White;
            this.lblDetalleFacturaImporte.Enabled = false;
            this.lblDetalleFacturaImporte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleFacturaImporte.ForeColor = System.Drawing.Color.Gray;
            this.lblDetalleFacturaImporte.Location = new System.Drawing.Point(730, 49);
            this.lblDetalleFacturaImporte.Name = "lblDetalleFacturaImporte";
            this.lblDetalleFacturaImporte.Size = new System.Drawing.Size(120, 18);
            this.lblDetalleFacturaImporte.TabIndex = 257;
            this.lblDetalleFacturaImporte.Text = "Importe";
            this.lblDetalleFacturaImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(719, 40);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(142, 37);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 258;
            this.pictureBox25.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(716, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 259;
            this.label14.Text = "Factura Importe";
            // 
            // lblDetalleFactura
            // 
            this.lblDetalleFactura.BackColor = System.Drawing.Color.White;
            this.lblDetalleFactura.Enabled = false;
            this.lblDetalleFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleFactura.ForeColor = System.Drawing.Color.Gray;
            this.lblDetalleFactura.Location = new System.Drawing.Point(544, 49);
            this.lblDetalleFactura.Name = "lblDetalleFactura";
            this.lblDetalleFactura.Size = new System.Drawing.Size(143, 18);
            this.lblDetalleFactura.TabIndex = 254;
            this.lblDetalleFactura.Text = "Factura";
            this.lblDetalleFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(533, 40);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(166, 37);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 255;
            this.pictureBox23.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(530, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 256;
            this.label12.Text = "Factura Nro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(793, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 192;
            this.label11.Text = "Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(614, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 191;
            this.label4.Text = "Precio x Caja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(427, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 190;
            this.label8.Text = "Cantidad Kilos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(257, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 189;
            this.label9.Text = "Cantidad Cajas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(21, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 188;
            this.label10.Text = "Presentación";
            // 
            // dgvDetalleExportacion
            // 
            this.dgvDetalleExportacion.AllowUserToAddRows = false;
            this.dgvDetalleExportacion.AllowUserToDeleteRows = false;
            this.dgvDetalleExportacion.AllowUserToResizeColumns = false;
            this.dgvDetalleExportacion.AllowUserToResizeRows = false;
            this.dgvDetalleExportacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleExportacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleExportacion.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalleExportacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleExportacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleExportacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDetalleExportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleExportacion.ColumnHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleExportacion.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDetalleExportacion.Location = new System.Drawing.Point(14, 120);
            this.dgvDetalleExportacion.MultiSelect = false;
            this.dgvDetalleExportacion.Name = "dgvDetalleExportacion";
            this.dgvDetalleExportacion.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleExportacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalleExportacion.RowHeadersVisible = false;
            this.dgvDetalleExportacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleExportacion.Size = new System.Drawing.Size(858, 237);
            this.dgvDetalleExportacion.TabIndex = 187;
            // 
            // lblDetalleProducto
            // 
            this.lblDetalleProducto.BackColor = System.Drawing.Color.White;
            this.lblDetalleProducto.Enabled = false;
            this.lblDetalleProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleProducto.ForeColor = System.Drawing.Color.Gray;
            this.lblDetalleProducto.Location = new System.Drawing.Point(312, 49);
            this.lblDetalleProducto.Name = "lblDetalleProducto";
            this.lblDetalleProducto.Size = new System.Drawing.Size(188, 18);
            this.lblDetalleProducto.TabIndex = 178;
            this.lblDetalleProducto.Text = "Producto";
            this.lblDetalleProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(298, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 180;
            this.label7.Text = "Producto";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(301, 40);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(210, 37);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 179;
            this.pictureBox22.TabStop = false;
            // 
            // lblDetalleCliente
            // 
            this.lblDetalleCliente.BackColor = System.Drawing.Color.White;
            this.lblDetalleCliente.Enabled = false;
            this.lblDetalleCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDetalleCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblDetalleCliente.Location = new System.Drawing.Point(37, 49);
            this.lblDetalleCliente.Name = "lblDetalleCliente";
            this.lblDetalleCliente.Size = new System.Drawing.Size(231, 18);
            this.lblDetalleCliente.TabIndex = 175;
            this.lblDetalleCliente.Text = "Cliente";
            this.lblDetalleCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 177;
            this.label5.Text = "Cliente";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(26, 40);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(255, 37);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 176;
            this.pictureBox21.TabStop = false;
            // 
            // FrmConsultaExportaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 695);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaExportaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Exportaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaExportaciones_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaExportaciones_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDeCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.gbTravesia.ResumeLayout(false);
            this.gbTravesia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).EndInit();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleExportacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnlCabecera;
        public System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblTitulo;
        public Bunifu.Framework.UI.BunifuElipse beRadio;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel8;
        public System.Windows.Forms.StatusStrip StatusStrip1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        public System.Windows.Forms.Label lblColumnaFactNro;
        private System.Windows.Forms.DataGridView dgvExportaciones;
        public System.Windows.Forms.Label lblColumnaCliente;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.PictureBox pbLogoBuscar;
        public System.Windows.Forms.PictureBox pbBuscar;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblClienteNombre;
        public System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pbDescripcion;
        public System.Windows.Forms.Label lblColumnaProducto;
        public System.Windows.Forms.Label lblColumnaFactMonto;
        public System.Windows.Forms.Label lblColumnaFactCajas;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.Label lblFacturaFecha;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txtFacturaImporte;
        private System.Windows.Forms.Label lblFacturaImporte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtFacturaCajas;
        private System.Windows.Forms.Label lblFacturaCajas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtFacturaNumero;
        private System.Windows.Forms.Label lblFacturaNumero;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Label lblContenedor;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtDUA;
        private System.Windows.Forms.Label lblDUA;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.GroupBox gbTravesia;
        public System.Windows.Forms.Label lblPuertoDestinoNombre;
        public System.Windows.Forms.TextBox txtDestinoId;
        private System.Windows.Forms.Label lblPuertoDestino;
        private System.Windows.Forms.PictureBox pictureBox20;
        public System.Windows.Forms.Label lblPuertoOrigenNombre;
        public System.Windows.Forms.TextBox txtOrigenId;
        private System.Windows.Forms.Label lblPuertoOrigen;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Label lblETD;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Label lblETA;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ComboBox cmbEstadoNave;
        private System.Windows.Forms.Label lblEstadoNave;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label lblTTD;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTTA;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lblFactura;
        public System.Windows.Forms.Label lblColumnaFactFecha;
        private System.Windows.Forms.DateTimePicker dtpFacturaFecha;
        private System.Windows.Forms.DateTimePicker dtpTTA;
        private System.Windows.Forms.DateTimePicker dtpETA;
        private System.Windows.Forms.DateTimePicker dtpTTD;
        private System.Windows.Forms.DateTimePicker dtpETD;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        public System.Windows.Forms.Label lblDetalleProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox22;
        public System.Windows.Forms.Label lblDetalleCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.DataGridView dgvDetalleExportacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lblDetalleFactura;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label lblDetalleFacturaImporte;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label lblDetalleTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.Label lblMaritimo;
        private Bunifu.Framework.UI.BunifuCheckbox bcbMaritimo;
        private System.Windows.Forms.Label lblAereo;
        private Bunifu.Framework.UI.BunifuCheckbox bcbAereo;
        private System.Windows.Forms.Label lblTerrestre;
        private Bunifu.Framework.UI.BunifuCheckbox bcbTerrestre;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvNotasDeCredito;
        private System.Windows.Forms.DataGridView dgvAbonos;
        public System.Windows.Forms.Label lblTotalNotasDeCredito;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblSaldoCliente;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label lblTotalAbonos;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label19;
    }
}

