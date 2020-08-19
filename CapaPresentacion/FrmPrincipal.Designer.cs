namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sbMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTituloMenu = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblNombreSistema = new System.Windows.Forms.Label();
            this.pnlMenuConsultas = new System.Windows.Forms.Panel();
            this.pnlMenuRegistro = new System.Windows.Forms.Panel();
            this.pnlMenuMantenimiento = new System.Windows.Forms.Panel();
            this.pnlFondoMenu = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bfbCons_SOAT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbCons_Exportaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbConsultas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbCons_Mantenimientos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbCons_Incidencias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbReg_Abonos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbReg_Exportacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbRegistro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbReg_NotasDeCredito = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Aeropuertos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Puertos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_ProductoPresentacion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Usuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_NotaCreditoTipo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Productos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Operadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbManto_Bancos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbMantenimiento = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bfbSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sbMenu.SuspendLayout();
            this.pnlTituloMenu.SuspendLayout();
            this.pnlMenuConsultas.SuspendLayout();
            this.pnlMenuRegistro.SuspendLayout();
            this.pnlMenuMantenimiento.SuspendLayout();
            this.pnlFondoMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 5;
            this.CurvaSidebar.TargetControl = this.sbMenu;
            // 
            // sbMenu
            // 
            this.sbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.sbMenu.Controls.Add(this.pnlTituloMenu);
            this.sbMenu.Controls.Add(this.pnlMenuConsultas);
            this.sbMenu.Controls.Add(this.pnlMenuRegistro);
            this.sbMenu.Controls.Add(this.pnlMenuMantenimiento);
            this.sbMenu.Controls.Add(this.bfbSalir);
            this.sbMenu.Location = new System.Drawing.Point(10, 10);
            this.sbMenu.MaximumSize = new System.Drawing.Size(230, 748);
            this.sbMenu.MinimumSize = new System.Drawing.Size(50, 500);
            this.sbMenu.Name = "sbMenu";
            this.sbMenu.Size = new System.Drawing.Size(230, 748);
            this.sbMenu.TabIndex = 0;
            // 
            // pnlTituloMenu
            // 
            this.pnlTituloMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.pnlTituloMenu.Controls.Add(this.lblVersion);
            this.pnlTituloMenu.Controls.Add(this.pbCerrar);
            this.pnlTituloMenu.Controls.Add(this.bunifuSeparator1);
            this.pnlTituloMenu.Controls.Add(this.lblNombreSistema);
            this.pnlTituloMenu.Controls.Add(this.pbLogo);
            this.pnlTituloMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlTituloMenu.Name = "pnlTituloMenu";
            this.pnlTituloMenu.Size = new System.Drawing.Size(222, 87);
            this.pnlTituloMenu.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(48, 55);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(163, 24);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "v 9.9.9.9";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 48);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(222, 1);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblNombreSistema
            // 
            this.lblNombreSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSistema.ForeColor = System.Drawing.Color.White;
            this.lblNombreSistema.Location = new System.Drawing.Point(48, 6);
            this.lblNombreSistema.Name = "lblNombreSistema";
            this.lblNombreSistema.Size = new System.Drawing.Size(163, 34);
            this.lblNombreSistema.TabIndex = 4;
            this.lblNombreSistema.Text = "XXX";
            this.lblNombreSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenuConsultas
            // 
            this.pnlMenuConsultas.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuConsultas.Controls.Add(this.bfbCons_SOAT);
            this.pnlMenuConsultas.Controls.Add(this.bfbCons_Exportaciones);
            this.pnlMenuConsultas.Controls.Add(this.bfbConsultas);
            this.pnlMenuConsultas.Controls.Add(this.bfbCons_Mantenimientos);
            this.pnlMenuConsultas.Controls.Add(this.bfbCons_Incidencias);
            this.pnlMenuConsultas.Location = new System.Drawing.Point(3, 96);
            this.pnlMenuConsultas.MaximumSize = new System.Drawing.Size(236, 237);
            this.pnlMenuConsultas.MinimumSize = new System.Drawing.Size(236, 53);
            this.pnlMenuConsultas.Name = "pnlMenuConsultas";
            this.pnlMenuConsultas.Size = new System.Drawing.Size(236, 53);
            this.pnlMenuConsultas.TabIndex = 11;
            // 
            // pnlMenuRegistro
            // 
            this.pnlMenuRegistro.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuRegistro.Controls.Add(this.bfbReg_Abonos);
            this.pnlMenuRegistro.Controls.Add(this.bfbReg_Exportacion);
            this.pnlMenuRegistro.Controls.Add(this.bfbRegistro);
            this.pnlMenuRegistro.Controls.Add(this.bfbReg_NotasDeCredito);
            this.pnlMenuRegistro.Location = new System.Drawing.Point(3, 155);
            this.pnlMenuRegistro.MaximumSize = new System.Drawing.Size(236, 191);
            this.pnlMenuRegistro.MinimumSize = new System.Drawing.Size(236, 53);
            this.pnlMenuRegistro.Name = "pnlMenuRegistro";
            this.pnlMenuRegistro.Size = new System.Drawing.Size(236, 53);
            this.pnlMenuRegistro.TabIndex = 11;
            // 
            // pnlMenuMantenimiento
            // 
            this.pnlMenuMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Aeropuertos);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Puertos);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_ProductoPresentacion);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Usuarios);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_NotaCreditoTipo);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Productos);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Operadores);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Clientes);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbManto_Bancos);
            this.pnlMenuMantenimiento.Controls.Add(this.bfbMantenimiento);
            this.pnlMenuMantenimiento.Location = new System.Drawing.Point(3, 214);
            this.pnlMenuMantenimiento.MaximumSize = new System.Drawing.Size(236, 462);
            this.pnlMenuMantenimiento.MinimumSize = new System.Drawing.Size(236, 53);
            this.pnlMenuMantenimiento.Name = "pnlMenuMantenimiento";
            this.pnlMenuMantenimiento.Size = new System.Drawing.Size(236, 53);
            this.pnlMenuMantenimiento.TabIndex = 5;
            // 
            // pnlFondoMenu
            // 
            this.pnlFondoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlFondoMenu.Controls.Add(this.sbMenu);
            this.pnlFondoMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFondoMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlFondoMenu.MaximumSize = new System.Drawing.Size(250, 0);
            this.pnlFondoMenu.MinimumSize = new System.Drawing.Size(70, 0);
            this.pnlFondoMenu.Name = "pnlFondoMenu";
            this.pnlFondoMenu.Size = new System.Drawing.Size(250, 496);
            this.pnlFondoMenu.TabIndex = 1;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.BackColor = System.Drawing.Color.Silver;
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(881, 12);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(28, 27);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 6;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(8, 55);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(25, 25);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrar.TabIndex = 6;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(1, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(40, 40);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // bfbCons_SOAT
            // 
            this.bfbCons_SOAT.Activecolor = System.Drawing.Color.Transparent;
            this.bfbCons_SOAT.BackColor = System.Drawing.Color.Transparent;
            this.bfbCons_SOAT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbCons_SOAT.BorderRadius = 7;
            this.bfbCons_SOAT.ButtonText = "          De SOAT";
            this.bfbCons_SOAT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbCons_SOAT.DisabledColor = System.Drawing.Color.Gray;
            this.bfbCons_SOAT.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbCons_SOAT.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbCons_SOAT.Iconimage")));
            this.bfbCons_SOAT.Iconimage_right = null;
            this.bfbCons_SOAT.Iconimage_right_Selected = null;
            this.bfbCons_SOAT.Iconimage_Selected = null;
            this.bfbCons_SOAT.IconMarginLeft = 0;
            this.bfbCons_SOAT.IconMarginRight = 0;
            this.bfbCons_SOAT.IconRightVisible = true;
            this.bfbCons_SOAT.IconRightZoom = 0D;
            this.bfbCons_SOAT.IconVisible = true;
            this.bfbCons_SOAT.IconZoom = 50D;
            this.bfbCons_SOAT.IsTab = false;
            this.bfbCons_SOAT.Location = new System.Drawing.Point(15, 192);
            this.bfbCons_SOAT.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbCons_SOAT.Name = "bfbCons_SOAT";
            this.bfbCons_SOAT.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbCons_SOAT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbCons_SOAT.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbCons_SOAT.selected = true;
            this.bfbCons_SOAT.Size = new System.Drawing.Size(206, 39);
            this.bfbCons_SOAT.TabIndex = 14;
            this.bfbCons_SOAT.Text = "          De SOAT";
            this.bfbCons_SOAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbCons_SOAT.Textcolor = System.Drawing.Color.White;
            this.bfbCons_SOAT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbCons_SOAT.Visible = false;
            this.bfbCons_SOAT.Click += new System.EventHandler(this.bfbCons_SOAT_Click);
            // 
            // bfbCons_Exportaciones
            // 
            this.bfbCons_Exportaciones.Activecolor = System.Drawing.Color.Transparent;
            this.bfbCons_Exportaciones.BackColor = System.Drawing.Color.Transparent;
            this.bfbCons_Exportaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbCons_Exportaciones.BorderRadius = 7;
            this.bfbCons_Exportaciones.ButtonText = "          De Exportaciones";
            this.bfbCons_Exportaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbCons_Exportaciones.DisabledColor = System.Drawing.Color.Gray;
            this.bfbCons_Exportaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbCons_Exportaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbCons_Exportaciones.Iconimage")));
            this.bfbCons_Exportaciones.Iconimage_right = null;
            this.bfbCons_Exportaciones.Iconimage_right_Selected = null;
            this.bfbCons_Exportaciones.Iconimage_Selected = null;
            this.bfbCons_Exportaciones.IconMarginLeft = 0;
            this.bfbCons_Exportaciones.IconMarginRight = 0;
            this.bfbCons_Exportaciones.IconRightVisible = true;
            this.bfbCons_Exportaciones.IconRightZoom = 0D;
            this.bfbCons_Exportaciones.IconVisible = true;
            this.bfbCons_Exportaciones.IconZoom = 50D;
            this.bfbCons_Exportaciones.IsTab = false;
            this.bfbCons_Exportaciones.Location = new System.Drawing.Point(15, 57);
            this.bfbCons_Exportaciones.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbCons_Exportaciones.Name = "bfbCons_Exportaciones";
            this.bfbCons_Exportaciones.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbCons_Exportaciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbCons_Exportaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbCons_Exportaciones.selected = true;
            this.bfbCons_Exportaciones.Size = new System.Drawing.Size(206, 39);
            this.bfbCons_Exportaciones.TabIndex = 13;
            this.bfbCons_Exportaciones.Text = "          De Exportaciones";
            this.bfbCons_Exportaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbCons_Exportaciones.Textcolor = System.Drawing.Color.White;
            this.bfbCons_Exportaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbCons_Exportaciones.Click += new System.EventHandler(this.bfbCons_Exportaciones_Click);
            // 
            // bfbConsultas
            // 
            this.bfbConsultas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbConsultas.BackColor = System.Drawing.Color.Transparent;
            this.bfbConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbConsultas.BorderRadius = 7;
            this.bfbConsultas.ButtonText = "          Consultas";
            this.bfbConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbConsultas.DisabledColor = System.Drawing.Color.Gray;
            this.bfbConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbConsultas.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbConsultas.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbConsultas.Iconimage")));
            this.bfbConsultas.Iconimage_right = null;
            this.bfbConsultas.Iconimage_right_Selected = null;
            this.bfbConsultas.Iconimage_Selected = null;
            this.bfbConsultas.IconMarginLeft = 0;
            this.bfbConsultas.IconMarginRight = 0;
            this.bfbConsultas.IconRightVisible = true;
            this.bfbConsultas.IconRightZoom = 0D;
            this.bfbConsultas.IconVisible = true;
            this.bfbConsultas.IconZoom = 50D;
            this.bfbConsultas.IsTab = false;
            this.bfbConsultas.Location = new System.Drawing.Point(0, 3);
            this.bfbConsultas.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbConsultas.Name = "bfbConsultas";
            this.bfbConsultas.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbConsultas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbConsultas.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbConsultas.selected = true;
            this.bfbConsultas.Size = new System.Drawing.Size(213, 48);
            this.bfbConsultas.TabIndex = 4;
            this.bfbConsultas.Text = "          Consultas";
            this.bfbConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbConsultas.Textcolor = System.Drawing.Color.White;
            this.bfbConsultas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbConsultas.Click += new System.EventHandler(this.bfbMenu01_Click);
            // 
            // bfbCons_Mantenimientos
            // 
            this.bfbCons_Mantenimientos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbCons_Mantenimientos.BackColor = System.Drawing.Color.Transparent;
            this.bfbCons_Mantenimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbCons_Mantenimientos.BorderRadius = 7;
            this.bfbCons_Mantenimientos.ButtonText = "          De Mantenimientos";
            this.bfbCons_Mantenimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbCons_Mantenimientos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbCons_Mantenimientos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbCons_Mantenimientos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbCons_Mantenimientos.Iconimage")));
            this.bfbCons_Mantenimientos.Iconimage_right = null;
            this.bfbCons_Mantenimientos.Iconimage_right_Selected = null;
            this.bfbCons_Mantenimientos.Iconimage_Selected = null;
            this.bfbCons_Mantenimientos.IconMarginLeft = 0;
            this.bfbCons_Mantenimientos.IconMarginRight = 0;
            this.bfbCons_Mantenimientos.IconRightVisible = true;
            this.bfbCons_Mantenimientos.IconRightZoom = 0D;
            this.bfbCons_Mantenimientos.IconVisible = true;
            this.bfbCons_Mantenimientos.IconZoom = 50D;
            this.bfbCons_Mantenimientos.IsTab = false;
            this.bfbCons_Mantenimientos.Location = new System.Drawing.Point(15, 147);
            this.bfbCons_Mantenimientos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbCons_Mantenimientos.Name = "bfbCons_Mantenimientos";
            this.bfbCons_Mantenimientos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbCons_Mantenimientos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbCons_Mantenimientos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbCons_Mantenimientos.selected = true;
            this.bfbCons_Mantenimientos.Size = new System.Drawing.Size(206, 39);
            this.bfbCons_Mantenimientos.TabIndex = 10;
            this.bfbCons_Mantenimientos.Text = "          De Mantenimientos";
            this.bfbCons_Mantenimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbCons_Mantenimientos.Textcolor = System.Drawing.Color.White;
            this.bfbCons_Mantenimientos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbCons_Mantenimientos.Visible = false;
            // 
            // bfbCons_Incidencias
            // 
            this.bfbCons_Incidencias.Activecolor = System.Drawing.Color.Transparent;
            this.bfbCons_Incidencias.BackColor = System.Drawing.Color.Transparent;
            this.bfbCons_Incidencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbCons_Incidencias.BorderRadius = 7;
            this.bfbCons_Incidencias.ButtonText = "          Dashboard";
            this.bfbCons_Incidencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbCons_Incidencias.DisabledColor = System.Drawing.Color.Gray;
            this.bfbCons_Incidencias.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbCons_Incidencias.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbCons_Incidencias.Iconimage")));
            this.bfbCons_Incidencias.Iconimage_right = null;
            this.bfbCons_Incidencias.Iconimage_right_Selected = null;
            this.bfbCons_Incidencias.Iconimage_Selected = null;
            this.bfbCons_Incidencias.IconMarginLeft = 0;
            this.bfbCons_Incidencias.IconMarginRight = 0;
            this.bfbCons_Incidencias.IconRightVisible = true;
            this.bfbCons_Incidencias.IconRightZoom = 0D;
            this.bfbCons_Incidencias.IconVisible = true;
            this.bfbCons_Incidencias.IconZoom = 50D;
            this.bfbCons_Incidencias.IsTab = false;
            this.bfbCons_Incidencias.Location = new System.Drawing.Point(15, 102);
            this.bfbCons_Incidencias.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbCons_Incidencias.Name = "bfbCons_Incidencias";
            this.bfbCons_Incidencias.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbCons_Incidencias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbCons_Incidencias.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbCons_Incidencias.selected = true;
            this.bfbCons_Incidencias.Size = new System.Drawing.Size(206, 39);
            this.bfbCons_Incidencias.TabIndex = 9;
            this.bfbCons_Incidencias.Text = "          Dashboard";
            this.bfbCons_Incidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbCons_Incidencias.Textcolor = System.Drawing.Color.White;
            this.bfbCons_Incidencias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbCons_Incidencias.Click += new System.EventHandler(this.bfbCons_Incidencias_Click);
            // 
            // bfbReg_Abonos
            // 
            this.bfbReg_Abonos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbReg_Abonos.BackColor = System.Drawing.Color.Transparent;
            this.bfbReg_Abonos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbReg_Abonos.BorderRadius = 7;
            this.bfbReg_Abonos.ButtonText = "          De Abonos";
            this.bfbReg_Abonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbReg_Abonos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbReg_Abonos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbReg_Abonos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbReg_Abonos.Iconimage")));
            this.bfbReg_Abonos.Iconimage_right = null;
            this.bfbReg_Abonos.Iconimage_right_Selected = null;
            this.bfbReg_Abonos.Iconimage_Selected = null;
            this.bfbReg_Abonos.IconMarginLeft = 0;
            this.bfbReg_Abonos.IconMarginRight = 0;
            this.bfbReg_Abonos.IconRightVisible = true;
            this.bfbReg_Abonos.IconRightZoom = 0D;
            this.bfbReg_Abonos.IconVisible = true;
            this.bfbReg_Abonos.IconZoom = 50D;
            this.bfbReg_Abonos.IsTab = false;
            this.bfbReg_Abonos.Location = new System.Drawing.Point(15, 102);
            this.bfbReg_Abonos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbReg_Abonos.Name = "bfbReg_Abonos";
            this.bfbReg_Abonos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbReg_Abonos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbReg_Abonos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbReg_Abonos.selected = true;
            this.bfbReg_Abonos.Size = new System.Drawing.Size(206, 39);
            this.bfbReg_Abonos.TabIndex = 6;
            this.bfbReg_Abonos.Text = "          De Abonos";
            this.bfbReg_Abonos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbReg_Abonos.Textcolor = System.Drawing.Color.White;
            this.bfbReg_Abonos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbReg_Abonos.Click += new System.EventHandler(this.bfbReg_Abonos_Click);
            // 
            // bfbReg_Exportacion
            // 
            this.bfbReg_Exportacion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bfbReg_Exportacion.BackColor = System.Drawing.Color.Transparent;
            this.bfbReg_Exportacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbReg_Exportacion.BorderRadius = 7;
            this.bfbReg_Exportacion.ButtonText = "          De Exportación";
            this.bfbReg_Exportacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbReg_Exportacion.DisabledColor = System.Drawing.Color.Gray;
            this.bfbReg_Exportacion.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbReg_Exportacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbReg_Exportacion.Iconimage")));
            this.bfbReg_Exportacion.Iconimage_right = null;
            this.bfbReg_Exportacion.Iconimage_right_Selected = null;
            this.bfbReg_Exportacion.Iconimage_Selected = null;
            this.bfbReg_Exportacion.IconMarginLeft = 0;
            this.bfbReg_Exportacion.IconMarginRight = 0;
            this.bfbReg_Exportacion.IconRightVisible = true;
            this.bfbReg_Exportacion.IconRightZoom = 0D;
            this.bfbReg_Exportacion.IconVisible = true;
            this.bfbReg_Exportacion.IconZoom = 50D;
            this.bfbReg_Exportacion.IsTab = false;
            this.bfbReg_Exportacion.Location = new System.Drawing.Point(15, 57);
            this.bfbReg_Exportacion.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbReg_Exportacion.Name = "bfbReg_Exportacion";
            this.bfbReg_Exportacion.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbReg_Exportacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbReg_Exportacion.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbReg_Exportacion.selected = true;
            this.bfbReg_Exportacion.Size = new System.Drawing.Size(206, 39);
            this.bfbReg_Exportacion.TabIndex = 5;
            this.bfbReg_Exportacion.Text = "          De Exportación";
            this.bfbReg_Exportacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbReg_Exportacion.Textcolor = System.Drawing.Color.White;
            this.bfbReg_Exportacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbReg_Exportacion.Click += new System.EventHandler(this.bfbReg_Exportacion_Click);
            // 
            // bfbRegistro
            // 
            this.bfbRegistro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbRegistro.BackColor = System.Drawing.Color.Transparent;
            this.bfbRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbRegistro.BorderRadius = 7;
            this.bfbRegistro.ButtonText = "          Registro";
            this.bfbRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbRegistro.DisabledColor = System.Drawing.Color.Gray;
            this.bfbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbRegistro.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbRegistro.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbRegistro.Iconimage")));
            this.bfbRegistro.Iconimage_right = null;
            this.bfbRegistro.Iconimage_right_Selected = null;
            this.bfbRegistro.Iconimage_Selected = null;
            this.bfbRegistro.IconMarginLeft = 0;
            this.bfbRegistro.IconMarginRight = 0;
            this.bfbRegistro.IconRightVisible = true;
            this.bfbRegistro.IconRightZoom = 0D;
            this.bfbRegistro.IconVisible = true;
            this.bfbRegistro.IconZoom = 50D;
            this.bfbRegistro.IsTab = false;
            this.bfbRegistro.Location = new System.Drawing.Point(0, 3);
            this.bfbRegistro.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbRegistro.Name = "bfbRegistro";
            this.bfbRegistro.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbRegistro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbRegistro.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbRegistro.selected = true;
            this.bfbRegistro.Size = new System.Drawing.Size(213, 48);
            this.bfbRegistro.TabIndex = 11;
            this.bfbRegistro.Text = "          Registro";
            this.bfbRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbRegistro.Textcolor = System.Drawing.Color.White;
            this.bfbRegistro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbRegistro.Click += new System.EventHandler(this.bfbMenu03_Click);
            // 
            // bfbReg_NotasDeCredito
            // 
            this.bfbReg_NotasDeCredito.Activecolor = System.Drawing.Color.Transparent;
            this.bfbReg_NotasDeCredito.BackColor = System.Drawing.Color.Transparent;
            this.bfbReg_NotasDeCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbReg_NotasDeCredito.BorderRadius = 7;
            this.bfbReg_NotasDeCredito.ButtonText = "          De Notas de Crédito";
            this.bfbReg_NotasDeCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbReg_NotasDeCredito.DisabledColor = System.Drawing.Color.Gray;
            this.bfbReg_NotasDeCredito.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbReg_NotasDeCredito.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbReg_NotasDeCredito.Iconimage")));
            this.bfbReg_NotasDeCredito.Iconimage_right = null;
            this.bfbReg_NotasDeCredito.Iconimage_right_Selected = null;
            this.bfbReg_NotasDeCredito.Iconimage_Selected = null;
            this.bfbReg_NotasDeCredito.IconMarginLeft = 0;
            this.bfbReg_NotasDeCredito.IconMarginRight = 0;
            this.bfbReg_NotasDeCredito.IconRightVisible = true;
            this.bfbReg_NotasDeCredito.IconRightZoom = 0D;
            this.bfbReg_NotasDeCredito.IconVisible = true;
            this.bfbReg_NotasDeCredito.IconZoom = 50D;
            this.bfbReg_NotasDeCredito.IsTab = false;
            this.bfbReg_NotasDeCredito.Location = new System.Drawing.Point(15, 147);
            this.bfbReg_NotasDeCredito.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbReg_NotasDeCredito.Name = "bfbReg_NotasDeCredito";
            this.bfbReg_NotasDeCredito.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbReg_NotasDeCredito.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbReg_NotasDeCredito.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbReg_NotasDeCredito.selected = true;
            this.bfbReg_NotasDeCredito.Size = new System.Drawing.Size(206, 39);
            this.bfbReg_NotasDeCredito.TabIndex = 7;
            this.bfbReg_NotasDeCredito.Text = "          De Notas de Crédito";
            this.bfbReg_NotasDeCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbReg_NotasDeCredito.Textcolor = System.Drawing.Color.White;
            this.bfbReg_NotasDeCredito.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbReg_NotasDeCredito.Click += new System.EventHandler(this.bfbReg_NotasDeCredito_Click);
            // 
            // bfbManto_Aeropuertos
            // 
            this.bfbManto_Aeropuertos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Aeropuertos.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Aeropuertos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Aeropuertos.BorderRadius = 7;
            this.bfbManto_Aeropuertos.ButtonText = "          Aeropuertos";
            this.bfbManto_Aeropuertos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Aeropuertos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Aeropuertos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Aeropuertos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Aeropuertos.Iconimage")));
            this.bfbManto_Aeropuertos.Iconimage_right = null;
            this.bfbManto_Aeropuertos.Iconimage_right_Selected = null;
            this.bfbManto_Aeropuertos.Iconimage_Selected = null;
            this.bfbManto_Aeropuertos.IconMarginLeft = 0;
            this.bfbManto_Aeropuertos.IconMarginRight = 0;
            this.bfbManto_Aeropuertos.IconRightVisible = true;
            this.bfbManto_Aeropuertos.IconRightZoom = 0D;
            this.bfbManto_Aeropuertos.IconVisible = true;
            this.bfbManto_Aeropuertos.IconZoom = 50D;
            this.bfbManto_Aeropuertos.IsTab = false;
            this.bfbManto_Aeropuertos.Location = new System.Drawing.Point(15, 417);
            this.bfbManto_Aeropuertos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Aeropuertos.Name = "bfbManto_Aeropuertos";
            this.bfbManto_Aeropuertos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Aeropuertos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Aeropuertos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Aeropuertos.selected = true;
            this.bfbManto_Aeropuertos.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Aeropuertos.TabIndex = 21;
            this.bfbManto_Aeropuertos.Text = "          Aeropuertos";
            this.bfbManto_Aeropuertos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Aeropuertos.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Aeropuertos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Aeropuertos.Click += new System.EventHandler(this.bfbManto_Aeropuertos_Click);
            // 
            // bfbManto_Puertos
            // 
            this.bfbManto_Puertos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Puertos.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Puertos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Puertos.BorderRadius = 7;
            this.bfbManto_Puertos.ButtonText = "          Puertos";
            this.bfbManto_Puertos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Puertos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Puertos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Puertos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Puertos.Iconimage")));
            this.bfbManto_Puertos.Iconimage_right = null;
            this.bfbManto_Puertos.Iconimage_right_Selected = null;
            this.bfbManto_Puertos.Iconimage_Selected = null;
            this.bfbManto_Puertos.IconMarginLeft = 0;
            this.bfbManto_Puertos.IconMarginRight = 0;
            this.bfbManto_Puertos.IconRightVisible = true;
            this.bfbManto_Puertos.IconRightZoom = 0D;
            this.bfbManto_Puertos.IconVisible = true;
            this.bfbManto_Puertos.IconZoom = 50D;
            this.bfbManto_Puertos.IsTab = false;
            this.bfbManto_Puertos.Location = new System.Drawing.Point(15, 372);
            this.bfbManto_Puertos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Puertos.Name = "bfbManto_Puertos";
            this.bfbManto_Puertos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Puertos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Puertos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Puertos.selected = true;
            this.bfbManto_Puertos.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Puertos.TabIndex = 20;
            this.bfbManto_Puertos.Text = "          Puertos";
            this.bfbManto_Puertos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Puertos.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Puertos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Puertos.Click += new System.EventHandler(this.bfbManto_Puertos_Click);
            // 
            // bfbManto_ProductoPresentacion
            // 
            this.bfbManto_ProductoPresentacion.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_ProductoPresentacion.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_ProductoPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_ProductoPresentacion.BorderRadius = 7;
            this.bfbManto_ProductoPresentacion.ButtonText = "          Presentaciones";
            this.bfbManto_ProductoPresentacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_ProductoPresentacion.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_ProductoPresentacion.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_ProductoPresentacion.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_ProductoPresentacion.Iconimage")));
            this.bfbManto_ProductoPresentacion.Iconimage_right = null;
            this.bfbManto_ProductoPresentacion.Iconimage_right_Selected = null;
            this.bfbManto_ProductoPresentacion.Iconimage_Selected = null;
            this.bfbManto_ProductoPresentacion.IconMarginLeft = 0;
            this.bfbManto_ProductoPresentacion.IconMarginRight = 0;
            this.bfbManto_ProductoPresentacion.IconRightVisible = true;
            this.bfbManto_ProductoPresentacion.IconRightZoom = 0D;
            this.bfbManto_ProductoPresentacion.IconVisible = true;
            this.bfbManto_ProductoPresentacion.IconZoom = 50D;
            this.bfbManto_ProductoPresentacion.IsTab = false;
            this.bfbManto_ProductoPresentacion.Location = new System.Drawing.Point(15, 327);
            this.bfbManto_ProductoPresentacion.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_ProductoPresentacion.Name = "bfbManto_ProductoPresentacion";
            this.bfbManto_ProductoPresentacion.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_ProductoPresentacion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_ProductoPresentacion.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_ProductoPresentacion.selected = true;
            this.bfbManto_ProductoPresentacion.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_ProductoPresentacion.TabIndex = 19;
            this.bfbManto_ProductoPresentacion.Text = "          Presentaciones";
            this.bfbManto_ProductoPresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_ProductoPresentacion.Textcolor = System.Drawing.Color.White;
            this.bfbManto_ProductoPresentacion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_ProductoPresentacion.Click += new System.EventHandler(this.bfbManto_ProductoPresentacion_Click);
            // 
            // bfbManto_Usuarios
            // 
            this.bfbManto_Usuarios.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Usuarios.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Usuarios.BorderRadius = 7;
            this.bfbManto_Usuarios.ButtonText = "          Usuarios";
            this.bfbManto_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Usuarios.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Usuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Usuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Usuarios.Iconimage")));
            this.bfbManto_Usuarios.Iconimage_right = null;
            this.bfbManto_Usuarios.Iconimage_right_Selected = null;
            this.bfbManto_Usuarios.Iconimage_Selected = null;
            this.bfbManto_Usuarios.IconMarginLeft = 0;
            this.bfbManto_Usuarios.IconMarginRight = 0;
            this.bfbManto_Usuarios.IconRightVisible = true;
            this.bfbManto_Usuarios.IconRightZoom = 0D;
            this.bfbManto_Usuarios.IconVisible = true;
            this.bfbManto_Usuarios.IconZoom = 50D;
            this.bfbManto_Usuarios.IsTab = false;
            this.bfbManto_Usuarios.Location = new System.Drawing.Point(15, 237);
            this.bfbManto_Usuarios.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Usuarios.Name = "bfbManto_Usuarios";
            this.bfbManto_Usuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Usuarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Usuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Usuarios.selected = true;
            this.bfbManto_Usuarios.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Usuarios.TabIndex = 18;
            this.bfbManto_Usuarios.Text = "          Usuarios";
            this.bfbManto_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Usuarios.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Usuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Usuarios.Click += new System.EventHandler(this.bfbManto_Usuarios_Click);
            // 
            // bfbManto_NotaCreditoTipo
            // 
            this.bfbManto_NotaCreditoTipo.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_NotaCreditoTipo.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_NotaCreditoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_NotaCreditoTipo.BorderRadius = 7;
            this.bfbManto_NotaCreditoTipo.ButtonText = "          Tipos de NC";
            this.bfbManto_NotaCreditoTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_NotaCreditoTipo.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_NotaCreditoTipo.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_NotaCreditoTipo.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_NotaCreditoTipo.Iconimage")));
            this.bfbManto_NotaCreditoTipo.Iconimage_right = null;
            this.bfbManto_NotaCreditoTipo.Iconimage_right_Selected = null;
            this.bfbManto_NotaCreditoTipo.Iconimage_Selected = null;
            this.bfbManto_NotaCreditoTipo.IconMarginLeft = 0;
            this.bfbManto_NotaCreditoTipo.IconMarginRight = 0;
            this.bfbManto_NotaCreditoTipo.IconRightVisible = true;
            this.bfbManto_NotaCreditoTipo.IconRightZoom = 0D;
            this.bfbManto_NotaCreditoTipo.IconVisible = true;
            this.bfbManto_NotaCreditoTipo.IconZoom = 50D;
            this.bfbManto_NotaCreditoTipo.IsTab = false;
            this.bfbManto_NotaCreditoTipo.Location = new System.Drawing.Point(15, 147);
            this.bfbManto_NotaCreditoTipo.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_NotaCreditoTipo.Name = "bfbManto_NotaCreditoTipo";
            this.bfbManto_NotaCreditoTipo.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_NotaCreditoTipo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_NotaCreditoTipo.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_NotaCreditoTipo.selected = true;
            this.bfbManto_NotaCreditoTipo.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_NotaCreditoTipo.TabIndex = 17;
            this.bfbManto_NotaCreditoTipo.Text = "          Tipos de NC";
            this.bfbManto_NotaCreditoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_NotaCreditoTipo.Textcolor = System.Drawing.Color.White;
            this.bfbManto_NotaCreditoTipo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_NotaCreditoTipo.Click += new System.EventHandler(this.bfbManto_NotaCreditoTipo_Click);
            // 
            // bfbManto_Productos
            // 
            this.bfbManto_Productos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Productos.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Productos.BorderRadius = 7;
            this.bfbManto_Productos.ButtonText = "          Productos";
            this.bfbManto_Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Productos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Productos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Productos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Productos.Iconimage")));
            this.bfbManto_Productos.Iconimage_right = null;
            this.bfbManto_Productos.Iconimage_right_Selected = null;
            this.bfbManto_Productos.Iconimage_Selected = null;
            this.bfbManto_Productos.IconMarginLeft = 0;
            this.bfbManto_Productos.IconMarginRight = 0;
            this.bfbManto_Productos.IconRightVisible = true;
            this.bfbManto_Productos.IconRightZoom = 0D;
            this.bfbManto_Productos.IconVisible = true;
            this.bfbManto_Productos.IconZoom = 50D;
            this.bfbManto_Productos.IsTab = false;
            this.bfbManto_Productos.Location = new System.Drawing.Point(15, 102);
            this.bfbManto_Productos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Productos.Name = "bfbManto_Productos";
            this.bfbManto_Productos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Productos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Productos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Productos.selected = true;
            this.bfbManto_Productos.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Productos.TabIndex = 16;
            this.bfbManto_Productos.Text = "          Productos";
            this.bfbManto_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Productos.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Productos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Productos.Click += new System.EventHandler(this.bfbManto_Productos_Click);
            // 
            // bfbManto_Operadores
            // 
            this.bfbManto_Operadores.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Operadores.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Operadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Operadores.BorderRadius = 7;
            this.bfbManto_Operadores.ButtonText = "          Operadores";
            this.bfbManto_Operadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Operadores.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Operadores.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Operadores.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Operadores.Iconimage")));
            this.bfbManto_Operadores.Iconimage_right = null;
            this.bfbManto_Operadores.Iconimage_right_Selected = null;
            this.bfbManto_Operadores.Iconimage_Selected = null;
            this.bfbManto_Operadores.IconMarginLeft = 0;
            this.bfbManto_Operadores.IconMarginRight = 0;
            this.bfbManto_Operadores.IconRightVisible = true;
            this.bfbManto_Operadores.IconRightZoom = 0D;
            this.bfbManto_Operadores.IconVisible = true;
            this.bfbManto_Operadores.IconZoom = 50D;
            this.bfbManto_Operadores.IsTab = false;
            this.bfbManto_Operadores.Location = new System.Drawing.Point(15, 282);
            this.bfbManto_Operadores.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Operadores.Name = "bfbManto_Operadores";
            this.bfbManto_Operadores.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Operadores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Operadores.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Operadores.selected = true;
            this.bfbManto_Operadores.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Operadores.TabIndex = 15;
            this.bfbManto_Operadores.Text = "          Operadores";
            this.bfbManto_Operadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Operadores.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Operadores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Operadores.Click += new System.EventHandler(this.bfbManto_Operadores_Click);
            // 
            // bfbManto_Clientes
            // 
            this.bfbManto_Clientes.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Clientes.BorderRadius = 7;
            this.bfbManto_Clientes.ButtonText = "          Clientes";
            this.bfbManto_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Clientes.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Clientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Clientes.Iconimage")));
            this.bfbManto_Clientes.Iconimage_right = null;
            this.bfbManto_Clientes.Iconimage_right_Selected = null;
            this.bfbManto_Clientes.Iconimage_Selected = null;
            this.bfbManto_Clientes.IconMarginLeft = 0;
            this.bfbManto_Clientes.IconMarginRight = 0;
            this.bfbManto_Clientes.IconRightVisible = true;
            this.bfbManto_Clientes.IconRightZoom = 0D;
            this.bfbManto_Clientes.IconVisible = true;
            this.bfbManto_Clientes.IconZoom = 50D;
            this.bfbManto_Clientes.IsTab = false;
            this.bfbManto_Clientes.Location = new System.Drawing.Point(15, 192);
            this.bfbManto_Clientes.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Clientes.Name = "bfbManto_Clientes";
            this.bfbManto_Clientes.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Clientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Clientes.selected = true;
            this.bfbManto_Clientes.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Clientes.TabIndex = 9;
            this.bfbManto_Clientes.Text = "          Clientes";
            this.bfbManto_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Clientes.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Clientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Clientes.Click += new System.EventHandler(this.bfbManto_Clientes_Click);
            // 
            // bfbManto_Bancos
            // 
            this.bfbManto_Bancos.Activecolor = System.Drawing.Color.Transparent;
            this.bfbManto_Bancos.BackColor = System.Drawing.Color.Transparent;
            this.bfbManto_Bancos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbManto_Bancos.BorderRadius = 7;
            this.bfbManto_Bancos.ButtonText = "          Bancos";
            this.bfbManto_Bancos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbManto_Bancos.DisabledColor = System.Drawing.Color.Gray;
            this.bfbManto_Bancos.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Bancos.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbManto_Bancos.Iconimage")));
            this.bfbManto_Bancos.Iconimage_right = null;
            this.bfbManto_Bancos.Iconimage_right_Selected = null;
            this.bfbManto_Bancos.Iconimage_Selected = null;
            this.bfbManto_Bancos.IconMarginLeft = 0;
            this.bfbManto_Bancos.IconMarginRight = 0;
            this.bfbManto_Bancos.IconRightVisible = true;
            this.bfbManto_Bancos.IconRightZoom = 0D;
            this.bfbManto_Bancos.IconVisible = true;
            this.bfbManto_Bancos.IconZoom = 50D;
            this.bfbManto_Bancos.IsTab = false;
            this.bfbManto_Bancos.Location = new System.Drawing.Point(15, 57);
            this.bfbManto_Bancos.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbManto_Bancos.Name = "bfbManto_Bancos";
            this.bfbManto_Bancos.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbManto_Bancos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbManto_Bancos.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbManto_Bancos.selected = true;
            this.bfbManto_Bancos.Size = new System.Drawing.Size(206, 39);
            this.bfbManto_Bancos.TabIndex = 6;
            this.bfbManto_Bancos.Text = "          Bancos";
            this.bfbManto_Bancos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbManto_Bancos.Textcolor = System.Drawing.Color.White;
            this.bfbManto_Bancos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbManto_Bancos.Click += new System.EventHandler(this.bfbManto_Bancos_Click);
            // 
            // bfbMantenimiento
            // 
            this.bfbMantenimiento.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.bfbMantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbMantenimiento.BorderRadius = 7;
            this.bfbMantenimiento.ButtonText = "          Mantenimiento";
            this.bfbMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbMantenimiento.DisabledColor = System.Drawing.Color.Gray;
            this.bfbMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbMantenimiento.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbMantenimiento.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbMantenimiento.Iconimage")));
            this.bfbMantenimiento.Iconimage_right = null;
            this.bfbMantenimiento.Iconimage_right_Selected = null;
            this.bfbMantenimiento.Iconimage_Selected = null;
            this.bfbMantenimiento.IconMarginLeft = 0;
            this.bfbMantenimiento.IconMarginRight = 0;
            this.bfbMantenimiento.IconRightVisible = true;
            this.bfbMantenimiento.IconRightZoom = 0D;
            this.bfbMantenimiento.IconVisible = true;
            this.bfbMantenimiento.IconZoom = 50D;
            this.bfbMantenimiento.IsTab = false;
            this.bfbMantenimiento.Location = new System.Drawing.Point(0, 3);
            this.bfbMantenimiento.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.bfbMantenimiento.Name = "bfbMantenimiento";
            this.bfbMantenimiento.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbMantenimiento.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbMantenimiento.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbMantenimiento.selected = true;
            this.bfbMantenimiento.Size = new System.Drawing.Size(213, 47);
            this.bfbMantenimiento.TabIndex = 5;
            this.bfbMantenimiento.Text = "          Mantenimiento";
            this.bfbMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbMantenimiento.Textcolor = System.Drawing.Color.White;
            this.bfbMantenimiento.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbMantenimiento.Click += new System.EventHandler(this.mnuMantenimiento_Click);
            // 
            // bfbSalir
            // 
            this.bfbSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbSalir.BackColor = System.Drawing.Color.Transparent;
            this.bfbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bfbSalir.BorderRadius = 7;
            this.bfbSalir.ButtonText = "          Salir";
            this.bfbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfbSalir.DisabledColor = System.Drawing.Color.Gray;
            this.bfbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.bfbSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("bfbSalir.Iconimage")));
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
            this.bfbSalir.Location = new System.Drawing.Point(3, 273);
            this.bfbSalir.Name = "bfbSalir";
            this.bfbSalir.Normalcolor = System.Drawing.Color.Transparent;
            this.bfbSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(90)))));
            this.bfbSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.bfbSalir.selected = true;
            this.bfbSalir.Size = new System.Drawing.Size(213, 48);
            this.bfbSalir.TabIndex = 12;
            this.bfbSalir.Text = "          Salir";
            this.bfbSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfbSalir.Textcolor = System.Drawing.Color.White;
            this.bfbSalir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfbSalir.Click += new System.EventHandler(this.bfbSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.Controls.Add(this.pbMinimizar);
            this.Controls.Add(this.pnlFondoMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.sbMenu.ResumeLayout(false);
            this.pnlTituloMenu.ResumeLayout(false);
            this.pnlMenuConsultas.ResumeLayout(false);
            this.pnlMenuRegistro.ResumeLayout(false);
            this.pnlMenuMantenimiento.ResumeLayout(false);
            this.pnlFondoMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private System.Windows.Forms.FlowLayoutPanel sbMenu;
        private System.Windows.Forms.Panel pnlTituloMenu;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblNombreSistema;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuFlatButton bfbConsultas;
        private System.Windows.Forms.Panel pnlMenuMantenimiento;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Clientes;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Bancos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbMantenimiento;
        private System.Windows.Forms.Panel pnlMenuRegistro;
        private Bunifu.Framework.UI.BunifuFlatButton bfbReg_Abonos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbReg_Exportacion;
        private Bunifu.Framework.UI.BunifuFlatButton bfbRegistro;
        private Bunifu.Framework.UI.BunifuFlatButton bfbReg_NotasDeCredito;
        private Bunifu.Framework.UI.BunifuFlatButton bfbSalir;
        private System.Windows.Forms.Panel pnlFondoMenu;
        private System.Windows.Forms.Panel pnlMenuConsultas;
        private Bunifu.Framework.UI.BunifuFlatButton bfbCons_Mantenimientos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbCons_Incidencias;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Operadores;
        public System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.Label lblVersion;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Usuarios;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_NotaCreditoTipo;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Productos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbCons_Exportaciones;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Puertos;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_ProductoPresentacion;
        private Bunifu.Framework.UI.BunifuFlatButton bfbCons_SOAT;
        private Bunifu.Framework.UI.BunifuFlatButton bfbManto_Aeropuertos;
    }
}