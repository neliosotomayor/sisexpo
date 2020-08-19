namespace CapaPresentacion
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.beRadio = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlArandanos = new System.Windows.Forms.Panel();
            this.lblArandanoCont = new System.Windows.Forms.Label();
            this.lblArandanoFact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlArveja = new System.Windows.Forms.Panel();
            this.lblArvejaCont = new System.Windows.Forms.Label();
            this.lblArvejaFact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGranada = new System.Windows.Forms.Panel();
            this.lblGranadaCont = new System.Windows.Forms.Label();
            this.lblGranadaFact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlJengibre = new System.Windows.Forms.Panel();
            this.lblJengibreCont = new System.Windows.Forms.Label();
            this.lblJengibreFact = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCurcuma = new System.Windows.Forms.Panel();
            this.lblCurcumaCont = new System.Windows.Forms.Label();
            this.lblCurcumaFact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPalta = new System.Windows.Forms.Panel();
            this.lblPaltaCont = new System.Windows.Forms.Label();
            this.lblPaltaFact = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.beRadioArandanos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beArveja = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beCurcuma = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beGranada = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beJengibre = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bePalta = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlArandanos.SuspendLayout();
            this.pnlArveja.SuspendLayout();
            this.pnlGranada.SuspendLayout();
            this.pnlJengibre.SuspendLayout();
            this.pnlCurcuma.SuspendLayout();
            this.pnlPalta.SuspendLayout();
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
            this.pnlCabecera.Size = new System.Drawing.Size(630, 38);
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
            this.lblTitulo.Size = new System.Drawing.Size(93, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Dashboard";
            // 
            // pbCerrar
            // 
            this.pbCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(592, 0);
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
            // pnlArandanos
            // 
            this.pnlArandanos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(50)))), ((int)(((byte)(141)))));
            this.pnlArandanos.Controls.Add(this.lblArandanoCont);
            this.pnlArandanos.Controls.Add(this.lblArandanoFact);
            this.pnlArandanos.Controls.Add(this.label1);
            this.pnlArandanos.Location = new System.Drawing.Point(25, 58);
            this.pnlArandanos.Name = "pnlArandanos";
            this.pnlArandanos.Size = new System.Drawing.Size(172, 104);
            this.pnlArandanos.TabIndex = 1;
            // 
            // lblArandanoCont
            // 
            this.lblArandanoCont.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArandanoCont.ForeColor = System.Drawing.Color.White;
            this.lblArandanoCont.Location = new System.Drawing.Point(95, 1);
            this.lblArandanoCont.Name = "lblArandanoCont";
            this.lblArandanoCont.Size = new System.Drawing.Size(75, 36);
            this.lblArandanoCont.TabIndex = 9;
            this.lblArandanoCont.Text = "$$";
            this.lblArandanoCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArandanoFact
            // 
            this.lblArandanoFact.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArandanoFact.ForeColor = System.Drawing.Color.White;
            this.lblArandanoFact.Location = new System.Drawing.Point(2, 52);
            this.lblArandanoFact.Name = "lblArandanoFact";
            this.lblArandanoFact.Size = new System.Drawing.Size(167, 36);
            this.lblArandanoFact.TabIndex = 1;
            this.lblArandanoFact.Text = "$$";
            this.lblArandanoFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arandanos";
            // 
            // pnlArveja
            // 
            this.pnlArveja.BackColor = System.Drawing.Color.Lime;
            this.pnlArveja.Controls.Add(this.lblArvejaCont);
            this.pnlArveja.Controls.Add(this.lblArvejaFact);
            this.pnlArveja.Controls.Add(this.label2);
            this.pnlArveja.Location = new System.Drawing.Point(228, 58);
            this.pnlArveja.Name = "pnlArveja";
            this.pnlArveja.Size = new System.Drawing.Size(172, 104);
            this.pnlArveja.TabIndex = 2;
            // 
            // lblArvejaCont
            // 
            this.lblArvejaCont.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArvejaCont.ForeColor = System.Drawing.Color.White;
            this.lblArvejaCont.Location = new System.Drawing.Point(95, 1);
            this.lblArvejaCont.Name = "lblArvejaCont";
            this.lblArvejaCont.Size = new System.Drawing.Size(75, 36);
            this.lblArvejaCont.TabIndex = 6;
            this.lblArvejaCont.Text = "$$";
            this.lblArvejaCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArvejaFact
            // 
            this.lblArvejaFact.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArvejaFact.ForeColor = System.Drawing.Color.White;
            this.lblArvejaFact.Location = new System.Drawing.Point(2, 52);
            this.lblArvejaFact.Name = "lblArvejaFact";
            this.lblArvejaFact.Size = new System.Drawing.Size(167, 36);
            this.lblArvejaFact.TabIndex = 5;
            this.lblArvejaFact.Text = "$$";
            this.lblArvejaFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arveja";
            // 
            // pnlGranada
            // 
            this.pnlGranada.BackColor = System.Drawing.Color.Red;
            this.pnlGranada.Controls.Add(this.lblGranadaCont);
            this.pnlGranada.Controls.Add(this.lblGranadaFact);
            this.pnlGranada.Controls.Add(this.label3);
            this.pnlGranada.Location = new System.Drawing.Point(25, 184);
            this.pnlGranada.Name = "pnlGranada";
            this.pnlGranada.Size = new System.Drawing.Size(172, 103);
            this.pnlGranada.TabIndex = 2;
            // 
            // lblGranadaCont
            // 
            this.lblGranadaCont.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranadaCont.ForeColor = System.Drawing.Color.White;
            this.lblGranadaCont.Location = new System.Drawing.Point(95, 1);
            this.lblGranadaCont.Name = "lblGranadaCont";
            this.lblGranadaCont.Size = new System.Drawing.Size(75, 36);
            this.lblGranadaCont.TabIndex = 9;
            this.lblGranadaCont.Text = "$$";
            this.lblGranadaCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGranadaFact
            // 
            this.lblGranadaFact.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGranadaFact.ForeColor = System.Drawing.Color.White;
            this.lblGranadaFact.Location = new System.Drawing.Point(2, 51);
            this.lblGranadaFact.Name = "lblGranadaFact";
            this.lblGranadaFact.Size = new System.Drawing.Size(167, 36);
            this.lblGranadaFact.TabIndex = 6;
            this.lblGranadaFact.Text = "$$";
            this.lblGranadaFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Granada";
            // 
            // pnlJengibre
            // 
            this.pnlJengibre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(194)))), ((int)(((byte)(98)))));
            this.pnlJengibre.Controls.Add(this.lblJengibreCont);
            this.pnlJengibre.Controls.Add(this.lblJengibreFact);
            this.pnlJengibre.Controls.Add(this.label4);
            this.pnlJengibre.Location = new System.Drawing.Point(228, 184);
            this.pnlJengibre.Name = "pnlJengibre";
            this.pnlJengibre.Size = new System.Drawing.Size(172, 103);
            this.pnlJengibre.TabIndex = 2;
            // 
            // lblJengibreCont
            // 
            this.lblJengibreCont.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJengibreCont.ForeColor = System.Drawing.Color.White;
            this.lblJengibreCont.Location = new System.Drawing.Point(95, 1);
            this.lblJengibreCont.Name = "lblJengibreCont";
            this.lblJengibreCont.Size = new System.Drawing.Size(75, 36);
            this.lblJengibreCont.TabIndex = 7;
            this.lblJengibreCont.Text = "$$";
            this.lblJengibreCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJengibreFact
            // 
            this.lblJengibreFact.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJengibreFact.ForeColor = System.Drawing.Color.White;
            this.lblJengibreFact.Location = new System.Drawing.Point(2, 51);
            this.lblJengibreFact.Name = "lblJengibreFact";
            this.lblJengibreFact.Size = new System.Drawing.Size(167, 36);
            this.lblJengibreFact.TabIndex = 7;
            this.lblJengibreFact.Text = "$$";
            this.lblJengibreFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jengibre";
            // 
            // pnlCurcuma
            // 
            this.pnlCurcuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(118)))), ((int)(((byte)(2)))));
            this.pnlCurcuma.Controls.Add(this.lblCurcumaCont);
            this.pnlCurcuma.Controls.Add(this.lblCurcumaFact);
            this.pnlCurcuma.Controls.Add(this.label5);
            this.pnlCurcuma.Location = new System.Drawing.Point(431, 58);
            this.pnlCurcuma.Name = "pnlCurcuma";
            this.pnlCurcuma.Size = new System.Drawing.Size(172, 104);
            this.pnlCurcuma.TabIndex = 3;
            // 
            // lblCurcumaCont
            // 
            this.lblCurcumaCont.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurcumaCont.ForeColor = System.Drawing.Color.White;
            this.lblCurcumaCont.Location = new System.Drawing.Point(95, 1);
            this.lblCurcumaCont.Name = "lblCurcumaCont";
            this.lblCurcumaCont.Size = new System.Drawing.Size(75, 36);
            this.lblCurcumaCont.TabIndex = 7;
            this.lblCurcumaCont.Text = "$$";
            this.lblCurcumaCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurcumaFact
            // 
            this.lblCurcumaFact.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurcumaFact.ForeColor = System.Drawing.Color.White;
            this.lblCurcumaFact.Location = new System.Drawing.Point(2, 52);
            this.lblCurcumaFact.Name = "lblCurcumaFact";
            this.lblCurcumaFact.Size = new System.Drawing.Size(167, 36);
            this.lblCurcumaFact.TabIndex = 8;
            this.lblCurcumaFact.Text = "$$";
            this.lblCurcumaFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Curcuma";
            // 
            // pnlPalta
            // 
            this.pnlPalta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.pnlPalta.Controls.Add(this.lblPaltaCont);
            this.pnlPalta.Controls.Add(this.lblPaltaFact);
            this.pnlPalta.Controls.Add(this.label6);
            this.pnlPalta.Location = new System.Drawing.Point(431, 184);
            this.pnlPalta.Name = "pnlPalta";
            this.pnlPalta.Size = new System.Drawing.Size(172, 103);
            this.pnlPalta.TabIndex = 8;
            // 
            // lblPaltaCont
            // 
            this.lblPaltaCont.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaltaCont.ForeColor = System.Drawing.Color.White;
            this.lblPaltaCont.Location = new System.Drawing.Point(95, 1);
            this.lblPaltaCont.Name = "lblPaltaCont";
            this.lblPaltaCont.Size = new System.Drawing.Size(75, 36);
            this.lblPaltaCont.TabIndex = 8;
            this.lblPaltaCont.Text = "$$";
            this.lblPaltaCont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaltaFact
            // 
            this.lblPaltaFact.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaltaFact.ForeColor = System.Drawing.Color.White;
            this.lblPaltaFact.Location = new System.Drawing.Point(2, 51);
            this.lblPaltaFact.Name = "lblPaltaFact";
            this.lblPaltaFact.Size = new System.Drawing.Size(167, 36);
            this.lblPaltaFact.TabIndex = 8;
            this.lblPaltaFact.Text = "$$";
            this.lblPaltaFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Palta";
            // 
            // beRadioArandanos
            // 
            this.beRadioArandanos.ElipseRadius = 7;
            this.beRadioArandanos.TargetControl = this.pnlArandanos;
            // 
            // beArveja
            // 
            this.beArveja.ElipseRadius = 7;
            this.beArveja.TargetControl = this.pnlArveja;
            // 
            // beCurcuma
            // 
            this.beCurcuma.ElipseRadius = 7;
            this.beCurcuma.TargetControl = this.pnlCurcuma;
            // 
            // beGranada
            // 
            this.beGranada.ElipseRadius = 7;
            this.beGranada.TargetControl = this.pnlGranada;
            // 
            // beJengibre
            // 
            this.beJengibre.ElipseRadius = 7;
            this.beJengibre.TargetControl = this.pnlJengibre;
            // 
            // bePalta
            // 
            this.bePalta.ElipseRadius = 7;
            this.bePalta.TargetControl = this.pnlPalta;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 314);
            this.Controls.Add(this.pnlPalta);
            this.Controls.Add(this.pnlCurcuma);
            this.Controls.Add(this.pnlJengibre);
            this.Controls.Add(this.pnlGranada);
            this.Controls.Add(this.pnlArveja);
            this.Controls.Add(this.pnlArandanos);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlArandanos.ResumeLayout(false);
            this.pnlArandanos.PerformLayout();
            this.pnlArveja.ResumeLayout(false);
            this.pnlArveja.PerformLayout();
            this.pnlGranada.ResumeLayout(false);
            this.pnlGranada.PerformLayout();
            this.pnlJengibre.ResumeLayout(false);
            this.pnlJengibre.PerformLayout();
            this.pnlCurcuma.ResumeLayout(false);
            this.pnlCurcuma.PerformLayout();
            this.pnlPalta.ResumeLayout(false);
            this.pnlPalta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlCabecera;
        public System.Windows.Forms.PictureBox pbCerrar;
        public System.Windows.Forms.PictureBox pbLogo;
        public System.Windows.Forms.Label lblTitulo;
        public Bunifu.Framework.UI.BunifuElipse beRadio;
        private System.Windows.Forms.Panel pnlPalta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCurcuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlJengibre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlGranada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlArveja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlArandanos;
        private System.Windows.Forms.Label lblArandanoFact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaltaFact;
        private System.Windows.Forms.Label lblCurcumaFact;
        private System.Windows.Forms.Label lblJengibreFact;
        private System.Windows.Forms.Label lblGranadaFact;
        private System.Windows.Forms.Label lblArvejaFact;
        private System.Windows.Forms.Label lblPaltaCont;
        private System.Windows.Forms.Label lblCurcumaCont;
        private System.Windows.Forms.Label lblJengibreCont;
        private System.Windows.Forms.Label lblGranadaCont;
        private System.Windows.Forms.Label lblArvejaCont;
        private System.Windows.Forms.Label lblArandanoCont;
        public Bunifu.Framework.UI.BunifuElipse beRadioArandanos;
        public Bunifu.Framework.UI.BunifuElipse beArveja;
        public Bunifu.Framework.UI.BunifuElipse beCurcuma;
        public Bunifu.Framework.UI.BunifuElipse beGranada;
        public Bunifu.Framework.UI.BunifuElipse beJengibre;
        public Bunifu.Framework.UI.BunifuElipse bePalta;
    }
}

