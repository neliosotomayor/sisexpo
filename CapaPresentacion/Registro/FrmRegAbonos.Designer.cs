namespace CapaPresentacion
{
    partial class FrmRegAbonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegAbonos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblColumnaFactFecha = new System.Windows.Forms.Label();
            this.lblColumnaProducto = new System.Windows.Forms.Label();
            this.lblColumnaFactMonto = new System.Windows.Forms.Label();
            this.lblColumnaFactCajas = new System.Windows.Forms.Label();
            this.lblColumnaFactNro = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblColumnaCliente = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pbLogoBuscar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbEstadoNave = new System.Windows.Forms.ComboBox();
            this.txtDUA = new System.Windows.Forms.TextBox();
            this.txtBooking = new System.Windows.Forms.TextBox();
            this.txtContenedor = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
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
            this.lblPuertoOrigenNombre = new System.Windows.Forms.Label();
            this.lblPuertoDestinoNombre = new System.Windows.Forms.Label();
            this.dtpTTD = new System.Windows.Forms.DateTimePicker();
            this.dtpETD = new System.Windows.Forms.DateTimePicker();
            this.lblTTD = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTTA = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lblItinerario = new System.Windows.Forms.Label();
            this.txtDestinoId = new System.Windows.Forms.TextBox();
            this.lblPuertoDestino = new System.Windows.Forms.Label();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.txtOrigenId = new System.Windows.Forms.TextBox();
            this.lblPuertoOrigen = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.lblETD = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.lblETA = new System.Windows.Forms.Label();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.lblDUA = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lblContenedor = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.txtFacturaCajas = new System.Windows.Forms.TextBox();
            this.txtFacturaImporte = new System.Windows.Forms.TextBox();
            this.txtFacturaNumero = new System.Windows.Forms.TextBox();
            this.dtpFacturaFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblFacturaImporte = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblFacturaCajas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblFacturaNumero = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFacturaFecha = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbDescripcion = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAbonosTotal = new System.Windows.Forms.Label();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblAbonoFacturaImporte = new System.Windows.Forms.Label();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAbonoFactura = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAbonoProducto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.txtAbonoImporte = new System.Windows.Forms.TextBox();
            this.txtAbonoTransferencia = new System.Windows.Forms.TextBox();
            this.lblAbonoCliente = new System.Windows.Forms.Label();
            this.dtpAbonoFecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.cmbAbonoBanco = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvAbonos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.bfbEliminarAbono = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbAgregarAbono = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
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
            this.pnlCabecera.Size = new System.Drawing.Size(914, 38);
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
            this.lblTitulo.Size = new System.Drawing.Size(158, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Registro de Abonos";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(876, 0);
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
            this.StatusStrip1.Location = new System.Drawing.Point(0, 546);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(914, 22);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 495);
            this.tabControl1.TabIndex = 110;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblColumnaFactFecha);
            this.tabPage1.Controls.Add(this.lblColumnaProducto);
            this.tabPage1.Controls.Add(this.lblColumnaFactMonto);
            this.tabPage1.Controls.Add(this.lblColumnaFactCajas);
            this.tabPage1.Controls.Add(this.lblColumnaFactNro);
            this.tabPage1.Controls.Add(this.dgvDatos);
            this.tabPage1.Controls.Add(this.lblColumnaCliente);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.pbLogoBuscar);
            this.tabPage1.Controls.Add(this.pbBuscar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exportaciones Realizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblColumnaFactFecha
            // 
            this.lblColumnaFactFecha.AutoSize = true;
            this.lblColumnaFactFecha.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactFecha.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactFecha.Location = new System.Drawing.Point(223, 68);
            this.lblColumnaFactFecha.Name = "lblColumnaFactFecha";
            this.lblColumnaFactFecha.Size = new System.Drawing.Size(72, 17);
            this.lblColumnaFactFecha.TabIndex = 129;
            this.lblColumnaFactFecha.Text = "Fact.Fecha";
            // 
            // lblColumnaProducto
            // 
            this.lblColumnaProducto.AutoSize = true;
            this.lblColumnaProducto.BackColor = System.Drawing.Color.White;
            this.lblColumnaProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaProducto.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaProducto.Location = new System.Drawing.Point(696, 68);
            this.lblColumnaProducto.Name = "lblColumnaProducto";
            this.lblColumnaProducto.Size = new System.Drawing.Size(64, 17);
            this.lblColumnaProducto.TabIndex = 128;
            this.lblColumnaProducto.Text = "Producto";
            // 
            // lblColumnaFactMonto
            // 
            this.lblColumnaFactMonto.AutoSize = true;
            this.lblColumnaFactMonto.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactMonto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactMonto.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactMonto.Location = new System.Drawing.Point(611, 68);
            this.lblColumnaFactMonto.Name = "lblColumnaFactMonto";
            this.lblColumnaFactMonto.Size = new System.Drawing.Size(78, 17);
            this.lblColumnaFactMonto.TabIndex = 127;
            this.lblColumnaFactMonto.Text = "Fact.Monto";
            // 
            // lblColumnaFactCajas
            // 
            this.lblColumnaFactCajas.AutoSize = true;
            this.lblColumnaFactCajas.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactCajas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactCajas.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactCajas.Location = new System.Drawing.Point(498, 68);
            this.lblColumnaFactCajas.Name = "lblColumnaFactCajas";
            this.lblColumnaFactCajas.Size = new System.Drawing.Size(69, 17);
            this.lblColumnaFactCajas.TabIndex = 126;
            this.lblColumnaFactCajas.Text = "Fact.Cajas";
            // 
            // lblColumnaFactNro
            // 
            this.lblColumnaFactNro.AutoSize = true;
            this.lblColumnaFactNro.BackColor = System.Drawing.Color.White;
            this.lblColumnaFactNro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaFactNro.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaFactNro.Location = new System.Drawing.Point(361, 68);
            this.lblColumnaFactNro.Name = "lblColumnaFactNro";
            this.lblColumnaFactNro.Size = new System.Drawing.Size(60, 17);
            this.lblColumnaFactNro.TabIndex = 125;
            this.lblColumnaFactNro.Text = "Fact.Nro";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(14, 88);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(858, 369);
            this.dgvDatos.TabIndex = 124;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            this.dgvDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyUp);
            // 
            // lblColumnaCliente
            // 
            this.lblColumnaCliente.AutoSize = true;
            this.lblColumnaCliente.BackColor = System.Drawing.Color.White;
            this.lblColumnaCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnaCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblColumnaCliente.Location = new System.Drawing.Point(18, 68);
            this.lblColumnaCliente.Name = "lblColumnaCliente";
            this.lblColumnaCliente.Size = new System.Drawing.Size(51, 17);
            this.lblColumnaCliente.TabIndex = 120;
            this.lblColumnaCliente.Text = "Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(58, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 18);
            this.txtBuscar.TabIndex = 123;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pbLogoBuscar
            // 
            this.pbLogoBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoBuscar.Image")));
            this.pbLogoBuscar.Location = new System.Drawing.Point(20, 15);
            this.pbLogoBuscar.Name = "pbLogoBuscar";
            this.pbLogoBuscar.Size = new System.Drawing.Size(32, 33);
            this.pbLogoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoBuscar.TabIndex = 122;
            this.pbLogoBuscar.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscar.Image")));
            this.pbBuscar.Location = new System.Drawing.Point(14, 13);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(313, 37);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 121;
            this.pbBuscar.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbEstadoNave);
            this.tabPage2.Controls.Add(this.txtDUA);
            this.tabPage2.Controls.Add(this.txtBooking);
            this.tabPage2.Controls.Add(this.txtContenedor);
            this.tabPage2.Controls.Add(this.lblClienteNombre);
            this.tabPage2.Controls.Add(this.cmbProducto);
            this.tabPage2.Controls.Add(this.cmbOperador);
            this.tabPage2.Controls.Add(this.txtComentario);
            this.tabPage2.Controls.Add(this.lblEstadoNave);
            this.tabPage2.Controls.Add(this.pictureBox13);
            this.tabPage2.Controls.Add(this.gbTravesia);
            this.tabPage2.Controls.Add(this.lblDUA);
            this.tabPage2.Controls.Add(this.pictureBox11);
            this.tabPage2.Controls.Add(this.lblBooking);
            this.tabPage2.Controls.Add(this.pictureBox10);
            this.tabPage2.Controls.Add(this.lblContenedor);
            this.tabPage2.Controls.Add(this.pictureBox8);
            this.tabPage2.Controls.Add(this.lblOperador);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Controls.Add(this.gbFactura);
            this.tabPage2.Controls.Add(this.lblComentario);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.txtClienteId);
            this.tabPage2.Controls.Add(this.lblCliente);
            this.tabPage2.Controls.Add(this.pictureBox7);
            this.tabPage2.Controls.Add(this.lblDescripcion);
            this.tabPage2.Controls.Add(this.pbDescripcion);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento de Exportaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoNave
            // 
            this.cmbEstadoNave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoNave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEstadoNave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstadoNave.FormattingEnabled = true;
            this.cmbEstadoNave.Location = new System.Drawing.Point(618, 264);
            this.cmbEstadoNave.Name = "cmbEstadoNave";
            this.cmbEstadoNave.Size = new System.Drawing.Size(163, 25);
            this.cmbEstadoNave.TabIndex = 194;
            // 
            // txtDUA
            // 
            this.txtDUA.BackColor = System.Drawing.Color.White;
            this.txtDUA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDUA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDUA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDUA.Location = new System.Drawing.Point(447, 267);
            this.txtDUA.MaxLength = 10;
            this.txtDUA.Name = "txtDUA";
            this.txtDUA.Size = new System.Drawing.Size(114, 18);
            this.txtDUA.TabIndex = 193;
            // 
            // txtBooking
            // 
            this.txtBooking.BackColor = System.Drawing.Color.White;
            this.txtBooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBooking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBooking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBooking.Location = new System.Drawing.Point(281, 267);
            this.txtBooking.MaxLength = 10;
            this.txtBooking.Name = "txtBooking";
            this.txtBooking.Size = new System.Drawing.Size(114, 18);
            this.txtBooking.TabIndex = 190;
            // 
            // txtContenedor
            // 
            this.txtContenedor.BackColor = System.Drawing.Color.White;
            this.txtContenedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContenedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtContenedor.Location = new System.Drawing.Point(111, 267);
            this.txtContenedor.MaxLength = 10;
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(114, 18);
            this.txtContenedor.TabIndex = 186;
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.BackColor = System.Drawing.Color.White;
            this.lblClienteNombre.Enabled = false;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClienteNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblClienteNombre.Location = new System.Drawing.Point(111, 39);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(218, 18);
            this.lblClienteNombre.TabIndex = 163;
            this.lblClienteNombre.Text = "Cliente";
            this.lblClienteNombre.DoubleClick += new System.EventHandler(this.lblClienteNombre_DoubleClick);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(371, 36);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(183, 25);
            this.cmbProducto.TabIndex = 164;
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOperador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.Location = new System.Drawing.Point(598, 36);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(183, 25);
            this.cmbOperador.TabIndex = 181;
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.White;
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComentario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComentario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComentario.Location = new System.Drawing.Point(438, 102);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComentario.Size = new System.Drawing.Size(341, 118);
            this.txtComentario.TabIndex = 166;
            // 
            // lblEstadoNave
            // 
            this.lblEstadoNave.AutoSize = true;
            this.lblEstadoNave.BackColor = System.Drawing.Color.White;
            this.lblEstadoNave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoNave.ForeColor = System.Drawing.Color.Gray;
            this.lblEstadoNave.Location = new System.Drawing.Point(604, 238);
            this.lblEstadoNave.Name = "lblEstadoNave";
            this.lblEstadoNave.Size = new System.Drawing.Size(84, 17);
            this.lblEstadoNave.TabIndex = 196;
            this.lblEstadoNave.Text = "Estado Nave";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(607, 258);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(186, 37);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 195;
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
            this.gbTravesia.Controls.Add(this.lblPuertoOrigenNombre);
            this.gbTravesia.Controls.Add(this.lblPuertoDestinoNombre);
            this.gbTravesia.Controls.Add(this.dtpTTD);
            this.gbTravesia.Controls.Add(this.dtpETD);
            this.gbTravesia.Controls.Add(this.lblTTD);
            this.gbTravesia.Controls.Add(this.pictureBox5);
            this.gbTravesia.Controls.Add(this.lblTTA);
            this.gbTravesia.Controls.Add(this.pictureBox12);
            this.gbTravesia.Controls.Add(this.lblItinerario);
            this.gbTravesia.Controls.Add(this.txtDestinoId);
            this.gbTravesia.Controls.Add(this.lblPuertoDestino);
            this.gbTravesia.Controls.Add(this.pictureBox20);
            this.gbTravesia.Controls.Add(this.txtOrigenId);
            this.gbTravesia.Controls.Add(this.lblPuertoOrigen);
            this.gbTravesia.Controls.Add(this.pictureBox19);
            this.gbTravesia.Controls.Add(this.lblETD);
            this.gbTravesia.Controls.Add(this.pictureBox18);
            this.gbTravesia.Controls.Add(this.lblETA);
            this.gbTravesia.Controls.Add(this.pictureBox14);
            this.gbTravesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTravesia.ForeColor = System.Drawing.Color.Black;
            this.gbTravesia.Location = new System.Drawing.Point(100, 301);
            this.gbTravesia.Name = "gbTravesia";
            this.gbTravesia.Size = new System.Drawing.Size(693, 159);
            this.gbTravesia.TabIndex = 187;
            this.gbTravesia.TabStop = false;
            // 
            // lblTerrestre
            // 
            this.lblTerrestre.AutoSize = true;
            this.lblTerrestre.BackColor = System.Drawing.Color.White;
            this.lblTerrestre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerrestre.ForeColor = System.Drawing.Color.Gray;
            this.lblTerrestre.Location = new System.Drawing.Point(64, 109);
            this.lblTerrestre.Name = "lblTerrestre";
            this.lblTerrestre.Size = new System.Drawing.Size(76, 17);
            this.lblTerrestre.TabIndex = 195;
            this.lblTerrestre.Text = "TERRESTRE";
            // 
            // bcbTerrestre
            // 
            this.bcbTerrestre.BackColor = System.Drawing.Color.Red;
            this.bcbTerrestre.ChechedOffColor = System.Drawing.Color.Red;
            this.bcbTerrestre.Checked = false;
            this.bcbTerrestre.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbTerrestre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbTerrestre.Location = new System.Drawing.Point(37, 108);
            this.bcbTerrestre.Name = "bcbTerrestre";
            this.bcbTerrestre.Size = new System.Drawing.Size(20, 20);
            this.bcbTerrestre.TabIndex = 194;
            // 
            // lblMaritimo
            // 
            this.lblMaritimo.AutoSize = true;
            this.lblMaritimo.BackColor = System.Drawing.Color.White;
            this.lblMaritimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaritimo.ForeColor = System.Drawing.Color.Gray;
            this.lblMaritimo.Location = new System.Drawing.Point(64, 83);
            this.lblMaritimo.Name = "lblMaritimo";
            this.lblMaritimo.Size = new System.Drawing.Size(75, 17);
            this.lblMaritimo.TabIndex = 193;
            this.lblMaritimo.Text = "MARITIMO";
            // 
            // bcbMaritimo
            // 
            this.bcbMaritimo.BackColor = System.Drawing.Color.Red;
            this.bcbMaritimo.ChechedOffColor = System.Drawing.Color.Red;
            this.bcbMaritimo.Checked = false;
            this.bcbMaritimo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbMaritimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbMaritimo.Location = new System.Drawing.Point(37, 82);
            this.bcbMaritimo.Name = "bcbMaritimo";
            this.bcbMaritimo.Size = new System.Drawing.Size(20, 20);
            this.bcbMaritimo.TabIndex = 192;
            // 
            // lblAereo
            // 
            this.lblAereo.AutoSize = true;
            this.lblAereo.BackColor = System.Drawing.Color.White;
            this.lblAereo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAereo.ForeColor = System.Drawing.Color.Gray;
            this.lblAereo.Location = new System.Drawing.Point(64, 57);
            this.lblAereo.Name = "lblAereo";
            this.lblAereo.Size = new System.Drawing.Size(49, 17);
            this.lblAereo.TabIndex = 191;
            this.lblAereo.Text = "AEREO";
            // 
            // bcbAereo
            // 
            this.bcbAereo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbAereo.ChechedOffColor = System.Drawing.Color.Red;
            this.bcbAereo.Checked = true;
            this.bcbAereo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbAereo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bcbAereo.Location = new System.Drawing.Point(37, 56);
            this.bcbAereo.Name = "bcbAereo";
            this.bcbAereo.Size = new System.Drawing.Size(20, 20);
            this.bcbAereo.TabIndex = 190;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(12, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 189;
            this.label13.Text = "Tipo de Transporte";
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(15, 39);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(142, 103);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 188;
            this.pictureBox27.TabStop = false;
            // 
            // dtpTTA
            // 
            this.dtpTTA.CustomFormat = " ";
            this.dtpTTA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTTA.Location = new System.Drawing.Point(568, 114);
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
            this.dtpETA.Location = new System.Drawing.Point(435, 114);
            this.dtpETA.Name = "dtpETA";
            this.dtpETA.Size = new System.Drawing.Size(95, 20);
            this.dtpETA.TabIndex = 177;
            this.dtpETA.ValueChanged += new System.EventHandler(this.dtpETA_ValueChanged);
            this.dtpETA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpETA_KeyDown);
            // 
            // lblPuertoOrigenNombre
            // 
            this.lblPuertoOrigenNombre.BackColor = System.Drawing.Color.White;
            this.lblPuertoOrigenNombre.Enabled = false;
            this.lblPuertoOrigenNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPuertoOrigenNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblPuertoOrigenNombre.Location = new System.Drawing.Point(192, 48);
            this.lblPuertoOrigenNombre.Name = "lblPuertoOrigenNombre";
            this.lblPuertoOrigenNombre.Size = new System.Drawing.Size(207, 18);
            this.lblPuertoOrigenNombre.TabIndex = 160;
            this.lblPuertoOrigenNombre.Text = "Puerto Origen";
            this.lblPuertoOrigenNombre.DoubleClick += new System.EventHandler(this.lblPuertoOrigenNombre_DoubleClick);
            // 
            // lblPuertoDestinoNombre
            // 
            this.lblPuertoDestinoNombre.BackColor = System.Drawing.Color.White;
            this.lblPuertoDestinoNombre.Enabled = false;
            this.lblPuertoDestinoNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPuertoDestinoNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblPuertoDestinoNombre.Location = new System.Drawing.Point(192, 114);
            this.lblPuertoDestinoNombre.Name = "lblPuertoDestinoNombre";
            this.lblPuertoDestinoNombre.Size = new System.Drawing.Size(207, 18);
            this.lblPuertoDestinoNombre.TabIndex = 165;
            this.lblPuertoDestinoNombre.Text = "Puerto Destino";
            this.lblPuertoDestinoNombre.DoubleClick += new System.EventHandler(this.lblPuertoDestinoNombre_DoubleClick);
            // 
            // dtpTTD
            // 
            this.dtpTTD.CustomFormat = " ";
            this.dtpTTD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTTD.Location = new System.Drawing.Point(568, 48);
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
            this.dtpETD.Location = new System.Drawing.Point(435, 48);
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
            this.lblTTD.Location = new System.Drawing.Point(554, 19);
            this.lblTTD.Name = "lblTTD";
            this.lblTTD.Size = new System.Drawing.Size(34, 17);
            this.lblTTD.TabIndex = 174;
            this.lblTTD.Text = "TTD";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(557, 39);
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
            this.lblTTA.Location = new System.Drawing.Point(554, 85);
            this.lblTTA.Name = "lblTTA";
            this.lblTTA.Size = new System.Drawing.Size(32, 17);
            this.lblTTA.TabIndex = 171;
            this.lblTTA.Text = "TTA";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(557, 105);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(119, 37);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 170;
            this.pictureBox12.TabStop = false;
            // 
            // lblItinerario
            // 
            this.lblItinerario.AutoSize = true;
            this.lblItinerario.BackColor = System.Drawing.Color.White;
            this.lblItinerario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItinerario.ForeColor = System.Drawing.Color.Gray;
            this.lblItinerario.Location = new System.Drawing.Point(-3, 0);
            this.lblItinerario.Name = "lblItinerario";
            this.lblItinerario.Size = new System.Drawing.Size(160, 17);
            this.lblItinerario.TabIndex = 161;
            this.lblItinerario.Text = "*** I T I N E R A R I O ***";
            // 
            // txtDestinoId
            // 
            this.txtDestinoId.BackColor = System.Drawing.Color.Yellow;
            this.txtDestinoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDestinoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDestinoId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDestinoId.Location = new System.Drawing.Point(296, 85);
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
            this.lblPuertoDestino.Location = new System.Drawing.Point(178, 85);
            this.lblPuertoDestino.Name = "lblPuertoDestino";
            this.lblPuertoDestino.Size = new System.Drawing.Size(101, 17);
            this.lblPuertoDestino.TabIndex = 167;
            this.lblPuertoDestino.Text = "Puerto Destino";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(181, 105);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(228, 37);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 166;
            this.pictureBox20.TabStop = false;
            // 
            // txtOrigenId
            // 
            this.txtOrigenId.BackColor = System.Drawing.Color.Yellow;
            this.txtOrigenId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrigenId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrigenId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrigenId.Location = new System.Drawing.Point(296, 19);
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
            this.lblPuertoOrigen.Location = new System.Drawing.Point(178, 19);
            this.lblPuertoOrigen.Name = "lblPuertoOrigen";
            this.lblPuertoOrigen.Size = new System.Drawing.Size(95, 17);
            this.lblPuertoOrigen.TabIndex = 162;
            this.lblPuertoOrigen.Text = "Puerto Origen";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(181, 39);
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
            this.lblETD.Location = new System.Drawing.Point(421, 19);
            this.lblETD.Name = "lblETD";
            this.lblETD.Size = new System.Drawing.Size(33, 17);
            this.lblETD.TabIndex = 154;
            this.lblETD.Text = "ETD";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(424, 39);
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
            this.lblETA.Location = new System.Drawing.Point(421, 85);
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(31, 17);
            this.lblETA.TabIndex = 107;
            this.lblETA.Text = "ETA";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(424, 105);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(119, 37);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 106;
            this.pictureBox14.TabStop = false;
            // 
            // lblDUA
            // 
            this.lblDUA.AutoSize = true;
            this.lblDUA.BackColor = System.Drawing.Color.White;
            this.lblDUA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUA.ForeColor = System.Drawing.Color.Gray;
            this.lblDUA.Location = new System.Drawing.Point(433, 238);
            this.lblDUA.Name = "lblDUA";
            this.lblDUA.Size = new System.Drawing.Size(36, 17);
            this.lblDUA.TabIndex = 192;
            this.lblDUA.Text = "DUA";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(436, 258);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(136, 37);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 191;
            this.pictureBox11.TabStop = false;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.BackColor = System.Drawing.Color.White;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.Color.Gray;
            this.lblBooking.Location = new System.Drawing.Point(267, 238);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(59, 17);
            this.lblBooking.TabIndex = 189;
            this.lblBooking.Text = "Booking";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(270, 258);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(136, 37);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 188;
            this.pictureBox10.TabStop = false;
            // 
            // lblContenedor
            // 
            this.lblContenedor.AutoSize = true;
            this.lblContenedor.BackColor = System.Drawing.Color.White;
            this.lblContenedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenedor.ForeColor = System.Drawing.Color.Gray;
            this.lblContenedor.Location = new System.Drawing.Point(97, 238);
            this.lblContenedor.Name = "lblContenedor";
            this.lblContenedor.Size = new System.Drawing.Size(80, 17);
            this.lblContenedor.TabIndex = 185;
            this.lblContenedor.Text = "Contenedor";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(100, 258);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(136, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 184;
            this.pictureBox8.TabStop = false;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.Color.White;
            this.lblOperador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.Gray;
            this.lblOperador.Location = new System.Drawing.Point(584, 10);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(66, 17);
            this.lblOperador.TabIndex = 183;
            this.lblOperador.Text = "Operador";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(587, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(206, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 182;
            this.pictureBox6.TabStop = false;
            // 
            // gbFactura
            // 
            this.gbFactura.BackColor = System.Drawing.Color.White;
            this.gbFactura.Controls.Add(this.txtFacturaCajas);
            this.gbFactura.Controls.Add(this.txtFacturaImporte);
            this.gbFactura.Controls.Add(this.txtFacturaNumero);
            this.gbFactura.Controls.Add(this.dtpFacturaFecha);
            this.gbFactura.Controls.Add(this.lblFactura);
            this.gbFactura.Controls.Add(this.lblFacturaImporte);
            this.gbFactura.Controls.Add(this.pictureBox4);
            this.gbFactura.Controls.Add(this.lblFacturaCajas);
            this.gbFactura.Controls.Add(this.pictureBox3);
            this.gbFactura.Controls.Add(this.lblFacturaNumero);
            this.gbFactura.Controls.Add(this.pictureBox2);
            this.gbFactura.Controls.Add(this.lblFacturaFecha);
            this.gbFactura.Controls.Add(this.pictureBox9);
            this.gbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFactura.ForeColor = System.Drawing.Color.Black;
            this.gbFactura.Location = new System.Drawing.Point(99, 73);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(310, 159);
            this.gbFactura.TabIndex = 180;
            this.gbFactura.TabStop = false;
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
            // txtFacturaNumero
            // 
            this.txtFacturaNumero.BackColor = System.Drawing.Color.White;
            this.txtFacturaNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFacturaNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFacturaNumero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFacturaNumero.Location = new System.Drawing.Point(160, 49);
            this.txtFacturaNumero.MaxLength = 10;
            this.txtFacturaNumero.Name = "txtFacturaNumero";
            this.txtFacturaNumero.Size = new System.Drawing.Size(110, 18);
            this.txtFacturaNumero.TabIndex = 143;
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
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.White;
            this.lblComentario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.Color.Gray;
            this.lblComentario.Location = new System.Drawing.Point(424, 73);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(80, 17);
            this.lblComentario.TabIndex = 173;
            this.lblComentario.Text = "Comentario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            // 
            // txtClienteId
            // 
            this.txtClienteId.BackColor = System.Drawing.Color.Yellow;
            this.txtClienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClienteId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtClienteId.Location = new System.Drawing.Point(170, 10);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.ReadOnly = true;
            this.txtClienteId.Size = new System.Drawing.Size(52, 18);
            this.txtClienteId.TabIndex = 171;
            this.txtClienteId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClienteId.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblCliente.Location = new System.Drawing.Point(97, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 169;
            this.lblCliente.Text = "Cliente";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(100, 30);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(243, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 168;
            this.pictureBox7.TabStop = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(357, 10);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(64, 17);
            this.lblDescripcion.TabIndex = 167;
            this.lblDescripcion.Text = "Producto";
            // 
            // pbDescripcion
            // 
            this.pbDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("pbDescripcion.Image")));
            this.pbDescripcion.Location = new System.Drawing.Point(360, 30);
            this.pbDescripcion.Name = "pbDescripcion";
            this.pbDescripcion.Size = new System.Drawing.Size(206, 37);
            this.pbDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescripcion.TabIndex = 165;
            this.pbDescripcion.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblAbonosTotal);
            this.tabPage3.Controls.Add(this.pictureBox26);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.lblAbonoFacturaImporte);
            this.tabPage3.Controls.Add(this.pictureBox25);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.lblAbonoFactura);
            this.tabPage3.Controls.Add(this.pictureBox16);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lblAbonoProducto);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.pictureBox22);
            this.tabPage3.Controls.Add(this.txtAbonoImporte);
            this.tabPage3.Controls.Add(this.txtAbonoTransferencia);
            this.tabPage3.Controls.Add(this.lblAbonoCliente);
            this.tabPage3.Controls.Add(this.dtpAbonoFecha);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.pictureBox23);
            this.tabPage3.Controls.Add(this.cmbAbonoBanco);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.pictureBox17);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.dgvAbonos);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.pictureBox24);
            this.tabPage3.Controls.Add(this.bfbEliminarAbono);
            this.tabPage3.Controls.Add(this.bfbAgregarAbono);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.pictureBox21);
            this.tabPage3.Controls.Add(this.pictureBox15);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(886, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblAbonosTotal
            // 
            this.lblAbonosTotal.BackColor = System.Drawing.Color.White;
            this.lblAbonosTotal.Enabled = false;
            this.lblAbonosTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbonosTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblAbonosTotal.Location = new System.Drawing.Point(743, 429);
            this.lblAbonosTotal.Name = "lblAbonosTotal";
            this.lblAbonosTotal.Size = new System.Drawing.Size(120, 18);
            this.lblAbonosTotal.TabIndex = 269;
            this.lblAbonosTotal.Text = "0.00";
            this.lblAbonosTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(732, 420);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(142, 37);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 270;
            this.pictureBox26.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gray;
            this.label15.Location = new System.Drawing.Point(636, 430);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 271;
            this.label15.Text = "Total Abonos";
            // 
            // lblAbonoFacturaImporte
            // 
            this.lblAbonoFacturaImporte.BackColor = System.Drawing.Color.White;
            this.lblAbonoFacturaImporte.Enabled = false;
            this.lblAbonoFacturaImporte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbonoFacturaImporte.ForeColor = System.Drawing.Color.Gray;
            this.lblAbonoFacturaImporte.Location = new System.Drawing.Point(730, 44);
            this.lblAbonoFacturaImporte.Name = "lblAbonoFacturaImporte";
            this.lblAbonoFacturaImporte.Size = new System.Drawing.Size(120, 18);
            this.lblAbonoFacturaImporte.TabIndex = 266;
            this.lblAbonoFacturaImporte.Text = "Importe";
            this.lblAbonoFacturaImporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(719, 35);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(142, 37);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 267;
            this.pictureBox25.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(716, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 268;
            this.label14.Text = "Factura Importe";
            // 
            // lblAbonoFactura
            // 
            this.lblAbonoFactura.BackColor = System.Drawing.Color.White;
            this.lblAbonoFactura.Enabled = false;
            this.lblAbonoFactura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbonoFactura.ForeColor = System.Drawing.Color.Gray;
            this.lblAbonoFactura.Location = new System.Drawing.Point(544, 44);
            this.lblAbonoFactura.Name = "lblAbonoFactura";
            this.lblAbonoFactura.Size = new System.Drawing.Size(143, 18);
            this.lblAbonoFactura.TabIndex = 263;
            this.lblAbonoFactura.Text = "Factura";
            this.lblAbonoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(533, 35);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(166, 37);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 264;
            this.pictureBox16.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(530, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 265;
            this.label2.Text = "Factura Nro";
            // 
            // lblAbonoProducto
            // 
            this.lblAbonoProducto.BackColor = System.Drawing.Color.White;
            this.lblAbonoProducto.Enabled = false;
            this.lblAbonoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbonoProducto.ForeColor = System.Drawing.Color.Gray;
            this.lblAbonoProducto.Location = new System.Drawing.Point(312, 44);
            this.lblAbonoProducto.Name = "lblAbonoProducto";
            this.lblAbonoProducto.Size = new System.Drawing.Size(188, 18);
            this.lblAbonoProducto.TabIndex = 260;
            this.lblAbonoProducto.Text = "Producto";
            this.lblAbonoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(298, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 262;
            this.label7.Text = "Producto";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(301, 35);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(210, 37);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 261;
            this.pictureBox22.TabStop = false;
            // 
            // txtAbonoImporte
            // 
            this.txtAbonoImporte.BackColor = System.Drawing.Color.White;
            this.txtAbonoImporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbonoImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbonoImporte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAbonoImporte.Location = new System.Drawing.Point(582, 117);
            this.txtAbonoImporte.MaxLength = 10;
            this.txtAbonoImporte.Name = "txtAbonoImporte";
            this.txtAbonoImporte.Size = new System.Drawing.Size(94, 18);
            this.txtAbonoImporte.TabIndex = 238;
            this.txtAbonoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAbonoTransferencia
            // 
            this.txtAbonoTransferencia.BackColor = System.Drawing.Color.White;
            this.txtAbonoTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbonoTransferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAbonoTransferencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAbonoTransferencia.Location = new System.Drawing.Point(413, 117);
            this.txtAbonoTransferencia.MaxLength = 20;
            this.txtAbonoTransferencia.Name = "txtAbonoTransferencia";
            this.txtAbonoTransferencia.Size = new System.Drawing.Size(127, 18);
            this.txtAbonoTransferencia.TabIndex = 226;
            this.txtAbonoTransferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAbonoCliente
            // 
            this.lblAbonoCliente.BackColor = System.Drawing.Color.White;
            this.lblAbonoCliente.Enabled = false;
            this.lblAbonoCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbonoCliente.ForeColor = System.Drawing.Color.Gray;
            this.lblAbonoCliente.Location = new System.Drawing.Point(37, 44);
            this.lblAbonoCliente.Name = "lblAbonoCliente";
            this.lblAbonoCliente.Size = new System.Drawing.Size(230, 18);
            this.lblAbonoCliente.TabIndex = 227;
            this.lblAbonoCliente.Text = "Cliente";
            this.lblAbonoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpAbonoFecha
            // 
            this.dtpAbonoFecha.CustomFormat = " ";
            this.dtpAbonoFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAbonoFecha.Location = new System.Drawing.Point(38, 117);
            this.dtpAbonoFecha.Name = "dtpAbonoFecha";
            this.dtpAbonoFecha.Size = new System.Drawing.Size(112, 20);
            this.dtpAbonoFecha.TabIndex = 250;
            this.dtpAbonoFecha.ValueChanged += new System.EventHandler(this.dtpAbonoFecha_ValueChanged);
            this.dtpAbonoFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpAbonoFecha_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(23, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 249;
            this.label12.Text = "Fecha";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(26, 108);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(136, 37);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 248;
            this.pictureBox23.TabStop = false;
            // 
            // cmbAbonoBanco
            // 
            this.cmbAbonoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbonoBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbAbonoBanco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAbonoBanco.FormattingEnabled = true;
            this.cmbAbonoBanco.Location = new System.Drawing.Point(190, 114);
            this.cmbAbonoBanco.Name = "cmbAbonoBanco";
            this.cmbAbonoBanco.Size = new System.Drawing.Size(183, 25);
            this.cmbAbonoBanco.TabIndex = 245;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(176, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 247;
            this.label3.Text = "Banco";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(179, 108);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(206, 37);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 246;
            this.pictureBox17.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(803, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 244;
            this.label11.Text = "Importe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(619, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 243;
            this.label4.Text = "Transferencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(298, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 241;
            this.label9.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(23, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 240;
            this.label10.Text = "Banco";
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
            this.dgvAbonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.dgvAbonos.Location = new System.Drawing.Point(16, 191);
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
            this.dgvAbonos.Size = new System.Drawing.Size(858, 219);
            this.dgvAbonos.TabIndex = 239;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(568, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 237;
            this.label6.Text = "Importe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(399, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 225;
            this.label1.Text = "Transferencia";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(571, 108);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(117, 37);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 236;
            this.pictureBox24.TabStop = false;
            // 
            // bfbEliminarAbono
            // 
            this.bfbEliminarAbono.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbEliminarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbEliminarAbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEliminarAbono.BorderRadius = 7;
            this.bfbEliminarAbono.ButtonText = "";
            this.bfbEliminarAbono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbEliminarAbono.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEliminarAbono.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEliminarAbono.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEliminarAbono.Iconimage")));
            this.bfbEliminarAbono.Iconimage_right = null;
            this.bfbEliminarAbono.Iconimage_right_Selected = null;
            this.bfbEliminarAbono.Iconimage_Selected = null;
            this.bfbEliminarAbono.IconMarginLeft = 0;
            this.bfbEliminarAbono.IconMarginRight = 0;
            this.bfbEliminarAbono.IconRightVisible = false;
            this.bfbEliminarAbono.IconRightZoom = 0D;
            this.bfbEliminarAbono.IconVisible = true;
            this.bfbEliminarAbono.IconZoom = 50D;
            this.bfbEliminarAbono.IsTab = false;
            this.bfbEliminarAbono.Location = new System.Drawing.Point(793, 88);
            this.bfbEliminarAbono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbEliminarAbono.Name = "bfbEliminarAbono";
            this.bfbEliminarAbono.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbEliminarAbono.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbEliminarAbono.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEliminarAbono.selected = false;
            this.bfbEliminarAbono.Size = new System.Drawing.Size(68, 66);
            this.bfbEliminarAbono.TabIndex = 235;
            this.bfbEliminarAbono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbEliminarAbono.Textcolor = System.Drawing.Color.White;
            this.bfbEliminarAbono.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbEliminarAbono.Click += new System.EventHandler(this.bfbEliminarAbono_Click);
            // 
            // bfbAgregarAbono
            // 
            this.bfbAgregarAbono.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbAgregarAbono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbAgregarAbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbAgregarAbono.BorderRadius = 7;
            this.bfbAgregarAbono.ButtonText = "";
            this.bfbAgregarAbono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbAgregarAbono.DisabledColor = System.Drawing.Color.Gray;
            this.bfbAgregarAbono.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbAgregarAbono.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbAgregarAbono.Iconimage")));
            this.bfbAgregarAbono.Iconimage_right = null;
            this.bfbAgregarAbono.Iconimage_right_Selected = null;
            this.bfbAgregarAbono.Iconimage_Selected = null;
            this.bfbAgregarAbono.IconMarginLeft = 0;
            this.bfbAgregarAbono.IconMarginRight = 0;
            this.bfbAgregarAbono.IconRightVisible = false;
            this.bfbAgregarAbono.IconRightZoom = 0D;
            this.bfbAgregarAbono.IconVisible = true;
            this.bfbAgregarAbono.IconZoom = 50D;
            this.bfbAgregarAbono.IsTab = false;
            this.bfbAgregarAbono.Location = new System.Drawing.Point(707, 88);
            this.bfbAgregarAbono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbAgregarAbono.Name = "bfbAgregarAbono";
            this.bfbAgregarAbono.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbAgregarAbono.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbAgregarAbono.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbAgregarAbono.selected = false;
            this.bfbAgregarAbono.Size = new System.Drawing.Size(68, 66);
            this.bfbAgregarAbono.TabIndex = 234;
            this.bfbAgregarAbono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbAgregarAbono.Textcolor = System.Drawing.Color.White;
            this.bfbAgregarAbono.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbAgregarAbono.Click += new System.EventHandler(this.bfbAgregarAbono_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(23, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 229;
            this.label5.Text = "Cliente";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(26, 35);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(252, 37);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 228;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(402, 108);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(151, 37);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 224;
            this.pictureBox15.TabStop = false;
            // 
            // FrmRegAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 568);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegAbonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Abonos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRegAbonos_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegAbonos_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Label lblColumnaFactFecha;
        public System.Windows.Forms.Label lblColumnaProducto;
        public System.Windows.Forms.Label lblColumnaFactMonto;
        public System.Windows.Forms.Label lblColumnaFactCajas;
        public System.Windows.Forms.Label lblColumnaFactNro;
        private System.Windows.Forms.DataGridView dgvDatos;
        public System.Windows.Forms.Label lblColumnaCliente;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.PictureBox pbLogoBuscar;
        public System.Windows.Forms.PictureBox pbBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbEstadoNave;
        private System.Windows.Forms.Label lblEstadoNave;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.GroupBox gbTravesia;
        private System.Windows.Forms.DateTimePicker dtpTTA;
        private System.Windows.Forms.DateTimePicker dtpETA;
        private System.Windows.Forms.DateTimePicker dtpTTD;
        private System.Windows.Forms.DateTimePicker dtpETD;
        private System.Windows.Forms.Label lblTTD;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTTA;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lblItinerario;
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
        private System.Windows.Forms.TextBox txtDUA;
        private System.Windows.Forms.Label lblDUA;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox txtBooking;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.TextBox txtContenedor;
        private System.Windows.Forms.Label lblContenedor;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.DateTimePicker dtpFacturaFecha;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFacturaImporte;
        private System.Windows.Forms.Label lblFacturaImporte;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtFacturaCajas;
        private System.Windows.Forms.Label lblFacturaCajas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtFacturaNumero;
        private System.Windows.Forms.Label lblFacturaNumero;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblFacturaFecha;
        private System.Windows.Forms.PictureBox pictureBox9;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvAbonos;
        private System.Windows.Forms.TextBox txtAbonoImporte;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.TextBox txtAbonoTransferencia;
        public Bunifu.Framework.UI.BunifuFlatButton bfbEliminarAbono;
        private System.Windows.Forms.PictureBox pictureBox21;
        public Bunifu.Framework.UI.BunifuFlatButton bfbAgregarAbono;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblAbonoCliente;
        private System.Windows.Forms.DateTimePicker dtpAbonoFecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.ComboBox cmbAbonoBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox17;
        public System.Windows.Forms.Label lblAbonoFacturaImporte;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblAbonoFactura;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblAbonoProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox22;
        public System.Windows.Forms.Label lblAbonosTotal;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTerrestre;
        private Bunifu.Framework.UI.BunifuCheckbox bcbTerrestre;
        private System.Windows.Forms.Label lblMaritimo;
        private Bunifu.Framework.UI.BunifuCheckbox bcbMaritimo;
        private System.Windows.Forms.Label lblAereo;
        private Bunifu.Framework.UI.BunifuCheckbox bcbAereo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox27;
    }
}

