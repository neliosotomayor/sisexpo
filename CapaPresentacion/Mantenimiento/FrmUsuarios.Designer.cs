namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblColumna1 = new System.Windows.Forms.Label();
            this.beRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bfbEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbGrabar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbModificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbNuevo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbDescripcion = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.pbLogoBuscar = new System.Windows.Forms.PictureBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
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
            this.pnlCabecera.Size = new System.Drawing.Size(732, 38);
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
            this.lblTitulo.Size = new System.Drawing.Size(222, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Mantenimiento de Usuarios";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(694, 0);
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
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(56, 56);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(258, 18);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblColumna1
            // 
            this.lblColumna1.AutoSize = true;
            this.lblColumna1.BackColor = System.Drawing.Color.White;
            this.lblColumna1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumna1.ForeColor = System.Drawing.Color.Gray;
            this.lblColumna1.Location = new System.Drawing.Point(16, 101);
            this.lblColumna1.Name = "lblColumna1";
            this.lblColumna1.Size = new System.Drawing.Size(58, 17);
            this.lblColumna1.TabIndex = 2;
            this.lblColumna1.Text = "Nombre";
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
            this.StatusStrip1.Location = new System.Drawing.Point(0, 451);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(732, 22);
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
            this.ToolStripStatusLabel8.Size = new System.Drawing.Size(150, 17);
            this.ToolStripStatusLabel8.Text = "...";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(483, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 18);
            this.txtNombre.TabIndex = 35;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblNombre.Location = new System.Drawing.Point(469, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre";
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
            this.dgvDatos.Size = new System.Drawing.Size(409, 252);
            this.dgvDatos.TabIndex = 38;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            this.dgvDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyUp);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.Location = new System.Drawing.Point(483, 190);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(221, 18);
            this.txtApellido.TabIndex = 41;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(469, 161);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(60, 17);
            this.lblDescripcion.TabIndex = 40;
            this.lblDescripcion.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(220, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Apellido";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Red;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(483, 310);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(97, 18);
            this.txtPassword.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(469, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Password";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(483, 250);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 18);
            this.txtUsuario.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(469, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Usuario";
            // 
            // txtPassword2
            // 
            this.txtPassword2.BackColor = System.Drawing.Color.Red;
            this.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword2.ForeColor = System.Drawing.Color.White;
            this.txtPassword2.Location = new System.Drawing.Point(607, 310);
            this.txtPassword2.MaxLength = 10;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(97, 18);
            this.txtPassword2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(593, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Confirmación";
            // 
            // bfbEliminar
            // 
            this.bfbEliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbEliminar.BorderRadius = 7;
            this.bfbEliminar.ButtonText = "Eliminar";
            this.bfbEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.bfbEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbEliminar.Iconimage")));
            this.bfbEliminar.Iconimage_right = null;
            this.bfbEliminar.Iconimage_right_Selected = null;
            this.bfbEliminar.Iconimage_Selected = null;
            this.bfbEliminar.IconMarginLeft = 0;
            this.bfbEliminar.IconMarginRight = 0;
            this.bfbEliminar.IconRightVisible = true;
            this.bfbEliminar.IconRightZoom = 0D;
            this.bfbEliminar.IconVisible = true;
            this.bfbEliminar.IconZoom = 50D;
            this.bfbEliminar.IsTab = false;
            this.bfbEliminar.Location = new System.Drawing.Point(472, 46);
            this.bfbEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbEliminar.Name = "bfbEliminar";
            this.bfbEliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbEliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbEliminar.selected = false;
            this.bfbEliminar.Size = new System.Drawing.Size(119, 37);
            this.bfbEliminar.TabIndex = 43;
            this.bfbEliminar.Text = "Eliminar";
            this.bfbEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbEliminar.Textcolor = System.Drawing.Color.White;
            this.bfbEliminar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbEliminar.Click += new System.EventHandler(this.bfbEliminar_Click);
            // 
            // bfbGrabar
            // 
            this.bfbGrabar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bfbGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bfbGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbGrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbGrabar.BorderRadius = 7;
            this.bfbGrabar.ButtonText = "Grabar";
            this.bfbGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbGrabar.DisabledColor = System.Drawing.Color.Gray;
            this.bfbGrabar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbGrabar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbGrabar.Iconimage")));
            this.bfbGrabar.Iconimage_right = null;
            this.bfbGrabar.Iconimage_right_Selected = null;
            this.bfbGrabar.Iconimage_Selected = null;
            this.bfbGrabar.IconMarginLeft = 0;
            this.bfbGrabar.IconMarginRight = 0;
            this.bfbGrabar.IconRightVisible = true;
            this.bfbGrabar.IconRightZoom = 0D;
            this.bfbGrabar.IconVisible = true;
            this.bfbGrabar.IconZoom = 50D;
            this.bfbGrabar.IsTab = false;
            this.bfbGrabar.Location = new System.Drawing.Point(472, 401);
            this.bfbGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbGrabar.Name = "bfbGrabar";
            this.bfbGrabar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbGrabar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbGrabar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbGrabar.selected = false;
            this.bfbGrabar.Size = new System.Drawing.Size(243, 37);
            this.bfbGrabar.TabIndex = 12;
            this.bfbGrabar.Text = "Grabar";
            this.bfbGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbGrabar.Textcolor = System.Drawing.Color.White;
            this.bfbGrabar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbGrabar.Click += new System.EventHandler(this.bfbGrabar_Click);
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
            this.bfbImprimir.Location = new System.Drawing.Point(596, 46);
            this.bfbImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbImprimir.Name = "bfbImprimir";
            this.bfbImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbImprimir.selected = false;
            this.bfbImprimir.Size = new System.Drawing.Size(119, 37);
            this.bfbImprimir.TabIndex = 11;
            this.bfbImprimir.Text = "Imprimir";
            this.bfbImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbImprimir.Textcolor = System.Drawing.Color.White;
            this.bfbImprimir.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbImprimir.Click += new System.EventHandler(this.bfbImprimir_Click);
            // 
            // bfbCancelar
            // 
            this.bfbCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.bfbCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bfbCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbCancelar.BorderRadius = 7;
            this.bfbCancelar.ButtonText = "Cancelar";
            this.bfbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.bfbCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbCancelar.Iconimage")));
            this.bfbCancelar.Iconimage_right = null;
            this.bfbCancelar.Iconimage_right_Selected = null;
            this.bfbCancelar.Iconimage_Selected = null;
            this.bfbCancelar.IconMarginLeft = 0;
            this.bfbCancelar.IconMarginRight = 0;
            this.bfbCancelar.IconRightVisible = true;
            this.bfbCancelar.IconRightZoom = 0D;
            this.bfbCancelar.IconVisible = true;
            this.bfbCancelar.IconZoom = 50D;
            this.bfbCancelar.IsTab = false;
            this.bfbCancelar.Location = new System.Drawing.Point(296, 401);
            this.bfbCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbCancelar.Name = "bfbCancelar";
            this.bfbCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbCancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbCancelar.selected = false;
            this.bfbCancelar.Size = new System.Drawing.Size(119, 37);
            this.bfbCancelar.TabIndex = 10;
            this.bfbCancelar.Text = "Cancelar";
            this.bfbCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbCancelar.Textcolor = System.Drawing.Color.White;
            this.bfbCancelar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbCancelar.Click += new System.EventHandler(this.bfbCancelar_Click);
            // 
            // bfbModificar
            // 
            this.bfbModificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bfbModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbModificar.BorderRadius = 7;
            this.bfbModificar.ButtonText = "Modificar";
            this.bfbModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbModificar.DisabledColor = System.Drawing.Color.Gray;
            this.bfbModificar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbModificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbModificar.Iconimage")));
            this.bfbModificar.Iconimage_right = null;
            this.bfbModificar.Iconimage_right_Selected = null;
            this.bfbModificar.Iconimage_Selected = null;
            this.bfbModificar.IconMarginLeft = 0;
            this.bfbModificar.IconMarginRight = 0;
            this.bfbModificar.IconRightVisible = true;
            this.bfbModificar.IconRightZoom = 0D;
            this.bfbModificar.IconVisible = true;
            this.bfbModificar.IconZoom = 50D;
            this.bfbModificar.IsTab = false;
            this.bfbModificar.Location = new System.Drawing.Point(157, 401);
            this.bfbModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbModificar.Name = "bfbModificar";
            this.bfbModificar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbModificar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbModificar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbModificar.selected = false;
            this.bfbModificar.Size = new System.Drawing.Size(119, 37);
            this.bfbModificar.TabIndex = 9;
            this.bfbModificar.Text = "Modificar";
            this.bfbModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbModificar.Textcolor = System.Drawing.Color.White;
            this.bfbModificar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbModificar.Click += new System.EventHandler(this.bfbModificar_Click);
            // 
            // bfbNuevo
            // 
            this.bfbNuevo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bfbNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbNuevo.BorderRadius = 7;
            this.bfbNuevo.ButtonText = "Nuevo";
            this.bfbNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbNuevo.DisabledColor = System.Drawing.Color.Gray;
            this.bfbNuevo.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbNuevo.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbNuevo.Iconimage")));
            this.bfbNuevo.Iconimage_right = null;
            this.bfbNuevo.Iconimage_right_Selected = null;
            this.bfbNuevo.Iconimage_Selected = null;
            this.bfbNuevo.IconMarginLeft = 0;
            this.bfbNuevo.IconMarginRight = 0;
            this.bfbNuevo.IconRightVisible = true;
            this.bfbNuevo.IconRightZoom = 0D;
            this.bfbNuevo.IconVisible = true;
            this.bfbNuevo.IconZoom = 50D;
            this.bfbNuevo.IsTab = false;
            this.bfbNuevo.Location = new System.Drawing.Point(18, 401);
            this.bfbNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbNuevo.Name = "bfbNuevo";
            this.bfbNuevo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbNuevo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbNuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbNuevo.selected = false;
            this.bfbNuevo.Size = new System.Drawing.Size(119, 37);
            this.bfbNuevo.TabIndex = 8;
            this.bfbNuevo.Text = "Nuevo";
            this.bfbNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbNuevo.Textcolor = System.Drawing.Color.White;
            this.bfbNuevo.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbNuevo.Click += new System.EventHandler(this.bfbNuevo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(596, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(472, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(472, 241);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pbDescripcion
            // 
            this.pbDescripcion.Location = new System.Drawing.Point(472, 181);
            this.pbDescripcion.Name = "pbDescripcion";
            this.pbDescripcion.Size = new System.Drawing.Size(243, 37);
            this.pbDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescripcion.TabIndex = 39;
            this.pbDescripcion.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.Location = new System.Drawing.Point(472, 121);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(243, 37);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNombre.TabIndex = 31;
            this.pbNombre.TabStop = false;
            // 
            // pbLogoBuscar
            // 
            this.pbLogoBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoBuscar.Image")));
            this.pbLogoBuscar.Location = new System.Drawing.Point(18, 48);
            this.pbLogoBuscar.Name = "pbLogoBuscar";
            this.pbLogoBuscar.Size = new System.Drawing.Size(32, 33);
            this.pbLogoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoBuscar.TabIndex = 3;
            this.pbLogoBuscar.TabStop = false;
            // 
            // pbBuscar
            // 
            this.pbBuscar.Location = new System.Drawing.Point(12, 46);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(313, 37);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 2;
            this.pbBuscar.TabStop = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 473);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bfbEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pbDescripcion);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.bfbGrabar);
            this.Controls.Add(this.bfbImprimir);
            this.Controls.Add(this.bfbCancelar);
            this.Controls.Add(this.bfbModificar);
            this.Controls.Add(this.bfbNuevo);
            this.Controls.Add(this.lblColumna1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pbLogoBuscar);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUsuarios_FormClosed);
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtBuscar;
        public Bunifu.Framework.UI.BunifuFlatButton bfbNuevo;
        public Bunifu.Framework.UI.BunifuFlatButton bfbModificar;
        public Bunifu.Framework.UI.BunifuFlatButton bfbCancelar;
        public Bunifu.Framework.UI.BunifuFlatButton bfbGrabar;
        public Bunifu.Framework.UI.BunifuFlatButton bfbImprimir;
        public System.Windows.Forms.Panel pnlCabecera;
        public System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.PictureBox pbBuscar;
        public System.Windows.Forms.PictureBox pbLogoBuscar;
        public System.Windows.Forms.Label lblColumna1;
        public Bunifu.Framework.UI.BunifuElipse beRadio;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel8;
        public System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pbDescripcion;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuFlatButton bfbEliminar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

