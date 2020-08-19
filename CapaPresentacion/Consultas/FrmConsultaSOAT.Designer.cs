namespace CapaPresentacion
{
    partial class FrmConsultaSOAT
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaSOAT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblColumna1 = new System.Windows.Forms.Label();
            this.beRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtVehiculoId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbVehiculoId = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.bfbBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.bfbImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehiculoId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
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
            this.pnlCabecera.Size = new System.Drawing.Size(908, 38);
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
            this.lblTitulo.Size = new System.Drawing.Size(144, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Consulta de SOAT";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(873, 5);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(28, 26);
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
            // lblColumna1
            // 
            this.lblColumna1.AutoSize = true;
            this.lblColumna1.BackColor = System.Drawing.Color.White;
            this.lblColumna1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumna1.ForeColor = System.Drawing.Color.Gray;
            this.lblColumna1.Location = new System.Drawing.Point(16, 101);
            this.lblColumna1.Name = "lblColumna1";
            this.lblColumna1.Size = new System.Drawing.Size(40, 17);
            this.lblColumna1.TabIndex = 2;
            this.lblColumna1.Text = "Placa";
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
            this.StatusStrip1.Location = new System.Drawing.Point(0, 472);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(908, 22);
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
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(150, 17);
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
            this.ToolStripStatusLabel8.Size = new System.Drawing.Size(120, 17);
            this.ToolStripStatusLabel8.Text = "...";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblNombre.Location = new System.Drawing.Point(16, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 17);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Desde";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(12, 121);
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
            this.dgvDatos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(884, 336);
            this.dgvDatos.TabIndex = 38;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            this.dgvDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(229, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre del Chofer";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.BackColor = System.Drawing.Color.White;
            this.lblVehiculo.Enabled = false;
            this.lblVehiculo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVehiculo.ForeColor = System.Drawing.Color.Gray;
            this.lblVehiculo.Location = new System.Drawing.Point(454, 55);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(73, 18);
            this.lblVehiculo.TabIndex = 37;
            this.lblVehiculo.Text = "Vehículo";
            this.lblVehiculo.DoubleClick += new System.EventHandler(this.lblVehiculo_DoubleClick);
            // 
            // txtVehiculoId
            // 
            this.txtVehiculoId.BackColor = System.Drawing.Color.Yellow;
            this.txtVehiculoId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehiculoId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehiculoId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVehiculoId.Location = new System.Drawing.Point(571, 56);
            this.txtVehiculoId.Name = "txtVehiculoId";
            this.txtVehiculoId.ReadOnly = true;
            this.txtVehiculoId.Size = new System.Drawing.Size(52, 18);
            this.txtVehiculoId.TabIndex = 93;
            this.txtVehiculoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVehiculoId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(398, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(453, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 108;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(205, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 110;
            this.label3.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(673, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 112;
            this.label5.Text = "Fecha Vencimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // pbVehiculoId
            // 
            this.pbVehiculoId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbVehiculoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.pbVehiculoId.Image = ((System.Drawing.Image)(resources.GetObject("pbVehiculoId.Image")));
            this.pbVehiculoId.Location = new System.Drawing.Point(549, 46);
            this.pbVehiculoId.Name = "pbVehiculoId";
            this.pbVehiculoId.Size = new System.Drawing.Size(16, 37);
            this.pbVehiculoId.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVehiculoId.TabIndex = 92;
            this.pbVehiculoId.TabStop = false;
            this.pbVehiculoId.Click += new System.EventHandler(this.pbVehiculoId_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(443, 46);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(122, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 90;
            this.pictureBox7.TabStop = false;
            // 
            // bfbBuscar
            // 
            this.bfbBuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbBuscar.BorderRadius = 7;
            this.bfbBuscar.ButtonText = "Buscar";
            this.bfbBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.bfbBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbBuscar.Iconimage")));
            this.bfbBuscar.Iconimage_right = null;
            this.bfbBuscar.Iconimage_right_Selected = null;
            this.bfbBuscar.Iconimage_Selected = null;
            this.bfbBuscar.IconMarginLeft = 0;
            this.bfbBuscar.IconMarginRight = 0;
            this.bfbBuscar.IconRightVisible = true;
            this.bfbBuscar.IconRightZoom = 0D;
            this.bfbBuscar.IconVisible = true;
            this.bfbBuscar.IconZoom = 50D;
            this.bfbBuscar.IsTab = false;
            this.bfbBuscar.Location = new System.Drawing.Point(653, 46);
            this.bfbBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbBuscar.Name = "bfbBuscar";
            this.bfbBuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbBuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbBuscar.selected = false;
            this.bfbBuscar.Size = new System.Drawing.Size(119, 37);
            this.bfbBuscar.TabIndex = 38;
            this.bfbBuscar.Text = "Buscar";
            this.bfbBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbBuscar.Textcolor = System.Drawing.Color.White;
            this.bfbBuscar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbBuscar.Click += new System.EventHandler(this.bfbBuscar_Click);
            // 
            // pbNombre
            // 
            this.pbNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbNombre.Image")));
            this.pbNombre.Location = new System.Drawing.Point(68, 46);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(119, 37);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNombre.TabIndex = 31;
            this.pbNombre.TabStop = false;
            // 
            // bfbImprimir
            // 
            this.bfbImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbImprimir.BorderRadius = 7;
            this.bfbImprimir.ButtonText = "Imprimir";
            this.bfbImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.bfbImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbImprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbImprimir.Iconimage")));
            this.bfbImprimir.Iconimage_right = null;
            this.bfbImprimir.Iconimage_right_Selected = null;
            this.bfbImprimir.Iconimage_Selected = null;
            this.bfbImprimir.IconMarginLeft = 0;
            this.bfbImprimir.IconMarginRight = 0;
            this.bfbImprimir.IconRightVisible = true;
            this.bfbImprimir.IconRightZoom = 0D;
            this.bfbImprimir.IconVisible = true;
            this.bfbImprimir.IconZoom = 50D;
            this.bfbImprimir.IsTab = false;
            this.bfbImprimir.Location = new System.Drawing.Point(782, 46);
            this.bfbImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbImprimir.Name = "bfbImprimir";
            this.bfbImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbImprimir.selected = false;
            this.bfbImprimir.Size = new System.Drawing.Size(119, 37);
            this.bfbImprimir.TabIndex = 39;
            this.bfbImprimir.Text = "Imprimir";
            this.bfbImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbImprimir.Textcolor = System.Drawing.Color.White;
            this.bfbImprimir.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbImprimir.Click += new System.EventHandler(this.bfbImprimir_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(77, 55);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaDesde.TabIndex = 119;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(267, 55);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaHasta.TabIndex = 120;
            // 
            // FrmConsultaSOAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 494);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.txtVehiculoId);
            this.Controls.Add(this.pbVehiculoId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.bfbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.bfbImprimir);
            this.Controls.Add(this.lblColumna1);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaSOAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Areas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaSOAT_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaSOAT_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVehiculoId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuFlatButton bfbImprimir;
        public System.Windows.Forms.Panel pnlCabecera;
        public System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblColumna1;
        public Bunifu.Framework.UI.BunifuElipse beRadio;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel8;
        public System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.DataGridView dgvDatos;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuFlatButton bfbBuscar;
        public System.Windows.Forms.Label lblVehiculo;
        public System.Windows.Forms.TextBox txtVehiculoId;
        public System.Windows.Forms.PictureBox pbVehiculoId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    }
}

