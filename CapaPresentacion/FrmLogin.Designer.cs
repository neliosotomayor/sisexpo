namespace CapaPresentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.beRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pbDescripcion = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.bfbSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbIngresar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(457, 38);
            this.pnlCabecera.TabIndex = 0;
            this.pnlCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabecera_MouseMove);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(116, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "...";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beRadio
            // 
            this.beRadio.ElipseRadius = 7;
            this.beRadio.TargetControl = this;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(210, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 18);
            this.txtUsuario.TabIndex = 35;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gray;
            this.lblNombre.Location = new System.Drawing.Point(196, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 17);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(210, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(221, 18);
            this.txtPassword.TabIndex = 36;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblDescripcion.Location = new System.Drawing.Point(196, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(77, 17);
            this.lblDescripcion.TabIndex = 40;
            this.lblDescripcion.Text = "Contraseña";
            // 
            // pbDescripcion
            // 
            this.pbDescripcion.Image = ((System.Drawing.Image)(resources.GetObject("pbDescripcion.Image")));
            this.pbDescripcion.Location = new System.Drawing.Point(199, 124);
            this.pbDescripcion.Name = "pbDescripcion";
            this.pbDescripcion.Size = new System.Drawing.Size(243, 37);
            this.pbDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDescripcion.TabIndex = 39;
            this.pbDescripcion.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.Image = ((System.Drawing.Image)(resources.GetObject("pbNombre.Image")));
            this.pbNombre.Location = new System.Drawing.Point(199, 64);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(243, 37);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNombre.TabIndex = 31;
            this.pbNombre.TabStop = false;
            // 
            // bfbSalir
            // 
            this.bfbSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfbSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbSalir.BorderRadius = 7;
            this.bfbSalir.ButtonText = "Salir";
            this.bfbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbSalir.DisabledColor = System.Drawing.Color.Gray;
            this.bfbSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbSalir.Iconimage = null;
            this.bfbSalir.Iconimage_right = null;
            this.bfbSalir.Iconimage_right_Selected = null;
            this.bfbSalir.Iconimage_Selected = null;
            this.bfbSalir.IconMarginLeft = 0;
            this.bfbSalir.IconMarginRight = 0;
            this.bfbSalir.IconRightVisible = true;
            this.bfbSalir.IconRightZoom = 0D;
            this.bfbSalir.IconVisible = true;
            this.bfbSalir.IconZoom = 50D;
            this.bfbSalir.IsTab = false;
            this.bfbSalir.Location = new System.Drawing.Point(326, 175);
            this.bfbSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbSalir.Name = "bfbSalir";
            this.bfbSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbSalir.selected = false;
            this.bfbSalir.Size = new System.Drawing.Size(119, 37);
            this.bfbSalir.TabIndex = 9;
            this.bfbSalir.Text = "Salir";
            this.bfbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbSalir.Textcolor = System.Drawing.Color.White;
            this.bfbSalir.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbSalir.Click += new System.EventHandler(this.bfbSalir_Click);
            // 
            // bfbIngresar
            // 
            this.bfbIngresar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bfbIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbIngresar.BorderRadius = 7;
            this.bfbIngresar.ButtonText = "Ingresar";
            this.bfbIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbIngresar.DisabledColor = System.Drawing.Color.Gray;
            this.bfbIngresar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bfbIngresar.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbIngresar.Iconimage = null;
            this.bfbIngresar.Iconimage_right = null;
            this.bfbIngresar.Iconimage_right_Selected = null;
            this.bfbIngresar.Iconimage_Selected = null;
            this.bfbIngresar.IconMarginLeft = 0;
            this.bfbIngresar.IconMarginRight = 0;
            this.bfbIngresar.IconRightVisible = true;
            this.bfbIngresar.IconRightZoom = 0D;
            this.bfbIngresar.IconVisible = true;
            this.bfbIngresar.IconZoom = 50D;
            this.bfbIngresar.IsTab = false;
            this.bfbIngresar.Location = new System.Drawing.Point(201, 175);
            this.bfbIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bfbIngresar.Name = "bfbIngresar";
            this.bfbIngresar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.bfbIngresar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbIngresar.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbIngresar.selected = false;
            this.bfbIngresar.Size = new System.Drawing.Size(119, 37);
            this.bfbIngresar.TabIndex = 8;
            this.bfbIngresar.Text = "Ingresar";
            this.bfbIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bfbIngresar.Textcolor = System.Drawing.Color.White;
            this.bfbIngresar.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbIngresar.Click += new System.EventHandler(this.bfbIngresar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(8, 45);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(178, 167);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.lblFechaHora);
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 21);
            this.panel1.TabIndex = 41;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(310, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(121, 21);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "...";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblFechaHora.ForeColor = System.Drawing.Color.White;
            this.lblFechaHora.Location = new System.Drawing.Point(12, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(178, 21);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "...";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 242);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.pbDescripcion);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.bfbSalir);
            this.Controls.Add(this.bfbIngresar);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Areas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlCabecera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuFlatButton bfbIngresar;
        public Bunifu.Framework.UI.BunifuFlatButton bfbSalir;
        public System.Windows.Forms.Panel pnlCabecera;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblTitulo;
        public Bunifu.Framework.UI.BunifuElipse beRadio;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pbDescripcion;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblFechaHora;
        public System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Timer timer1;
    }
}

