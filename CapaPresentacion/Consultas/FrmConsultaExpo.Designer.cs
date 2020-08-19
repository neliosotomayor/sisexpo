namespace CapaPresentacion
{
    partial class FrmConsultaExpo
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaExpo));
            this.grvDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProPre_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpDet_Cajas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpDet_Kilos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpDet_Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpDet_TotalPresentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCabeceraDetalle = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuExportarExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.grvCabecera = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCli_Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExp_FacturaFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExp_FacturaNro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExp_FacturaCajas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExp_FacturaImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbonos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sfdRutaArchivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCabeceraDetalle)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCabecera)).BeginInit();
            this.pnlCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDetalle
            // 
            this.grvDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProPre_Descripcion,
            this.colExpDet_Cajas,
            this.colExpDet_Kilos,
            this.colExpDet_Precio,
            this.colExpDet_TotalPresentacion});
            this.grvDetalle.GridControl = this.grdCabeceraDetalle;
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grvDetalle.OptionsView.ShowFooter = true;
            this.grvDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // colProPre_Descripcion
            // 
            this.colProPre_Descripcion.Caption = "Presentación";
            this.colProPre_Descripcion.FieldName = "ProPre_Descripcion";
            this.colProPre_Descripcion.Name = "colProPre_Descripcion";
            this.colProPre_Descripcion.OptionsColumn.AllowEdit = false;
            this.colProPre_Descripcion.Visible = true;
            this.colProPre_Descripcion.VisibleIndex = 0;
            // 
            // colExpDet_Cajas
            // 
            this.colExpDet_Cajas.Caption = "Cant Cajas";
            this.colExpDet_Cajas.FieldName = "ExpDet_Cajas";
            this.colExpDet_Cajas.Name = "colExpDet_Cajas";
            this.colExpDet_Cajas.OptionsColumn.AllowEdit = false;
            this.colExpDet_Cajas.Visible = true;
            this.colExpDet_Cajas.VisibleIndex = 1;
            // 
            // colExpDet_Kilos
            // 
            this.colExpDet_Kilos.Caption = "Cant Kilos";
            this.colExpDet_Kilos.FieldName = "ExpDet_Kilos";
            this.colExpDet_Kilos.Name = "colExpDet_Kilos";
            this.colExpDet_Kilos.OptionsColumn.AllowEdit = false;
            this.colExpDet_Kilos.Visible = true;
            this.colExpDet_Kilos.VisibleIndex = 2;
            // 
            // colExpDet_Precio
            // 
            this.colExpDet_Precio.Caption = "$$ x Caja";
            this.colExpDet_Precio.FieldName = "ExpDet_Precio";
            this.colExpDet_Precio.Name = "colExpDet_Precio";
            this.colExpDet_Precio.OptionsColumn.AllowEdit = false;
            this.colExpDet_Precio.Visible = true;
            this.colExpDet_Precio.VisibleIndex = 3;
            // 
            // colExpDet_TotalPresentacion
            // 
            this.colExpDet_TotalPresentacion.Caption = "Importe";
            this.colExpDet_TotalPresentacion.FieldName = "ExpDet_TotalPresentacion";
            this.colExpDet_TotalPresentacion.Name = "colExpDet_TotalPresentacion";
            this.colExpDet_TotalPresentacion.OptionsColumn.AllowEdit = false;
            this.colExpDet_TotalPresentacion.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ExpDet_TotalPresentacion", "SUM={0:0.##}")});
            this.colExpDet_TotalPresentacion.Visible = true;
            this.colExpDet_TotalPresentacion.VisibleIndex = 4;
            // 
            // grdCabeceraDetalle
            // 
            this.grdCabeceraDetalle.ContextMenuStrip = this.contextMenuStrip1;
            gridLevelNode1.LevelTemplate = this.grvDetalle;
            gridLevelNode1.RelationName = "DetailView";
            this.grdCabeceraDetalle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdCabeceraDetalle.Location = new System.Drawing.Point(12, 12);
            this.grdCabeceraDetalle.MainView = this.grvCabecera;
            this.grdCabeceraDetalle.Name = "grdCabeceraDetalle";
            this.grdCabeceraDetalle.Size = new System.Drawing.Size(927, 611);
            this.grdCabeceraDetalle.TabIndex = 4;
            this.grdCabeceraDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCabecera,
            this.grvDetalle});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportarExcel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // mnuExportarExcel
            // 
            this.mnuExportarExcel.Name = "mnuExportarExcel";
            this.mnuExportarExcel.Size = new System.Drawing.Size(157, 22);
            this.mnuExportarExcel.Text = "Exportar a Excel";
            this.mnuExportarExcel.Click += new System.EventHandler(this.mnuExportarExcel_Click);
            // 
            // grvCabecera
            // 
            this.grvCabecera.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProducto,
            this.colCli_Nombre,
            this.colExp_FacturaFecha,
            this.colExp_FacturaNro,
            this.colExp_FacturaCajas,
            this.colExp_FacturaImporte,
            this.colAbonos,
            this.colNC,
            this.colSaldo});
            this.grvCabecera.GridControl = this.grdCabeceraDetalle;
            this.grvCabecera.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Exp_FacturaImporte", null, "(Importe: SUM={0:0.##})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Exp_FacturacionImporte", null, "")});
            this.grvCabecera.Name = "grvCabecera";
            this.grvCabecera.OptionsDetail.ShowDetailTabs = false;
            this.grvCabecera.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.grvCabecera.OptionsPrint.PrintDetails = true;
            this.grvCabecera.OptionsView.ShowFooter = true;
            this.grvCabecera.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.grvCabecera_MasterRowEmpty);
            this.grvCabecera.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvCabecera_MasterRowGetChildList);
            this.grvCabecera.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvCabecera_MasterRowGetRelationName);
            this.grvCabecera.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvCabecera_MasterRowGetRelationCount);
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Producto";
            this.colProducto.FieldName = "Pro_Nombre";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 0;
            // 
            // colCli_Nombre
            // 
            this.colCli_Nombre.Caption = "Cliente";
            this.colCli_Nombre.FieldName = "Cli_Nombre";
            this.colCli_Nombre.Name = "colCli_Nombre";
            this.colCli_Nombre.OptionsColumn.AllowEdit = false;
            this.colCli_Nombre.Visible = true;
            this.colCli_Nombre.VisibleIndex = 1;
            // 
            // colExp_FacturaFecha
            // 
            this.colExp_FacturaFecha.Caption = "Factura Fecha";
            this.colExp_FacturaFecha.FieldName = "Exp_FacturaFecha";
            this.colExp_FacturaFecha.Name = "colExp_FacturaFecha";
            this.colExp_FacturaFecha.OptionsColumn.AllowEdit = false;
            this.colExp_FacturaFecha.Visible = true;
            this.colExp_FacturaFecha.VisibleIndex = 2;
            // 
            // colExp_FacturaNro
            // 
            this.colExp_FacturaNro.Caption = "Factura Nro";
            this.colExp_FacturaNro.FieldName = "Exp_FacturaNro";
            this.colExp_FacturaNro.Name = "colExp_FacturaNro";
            this.colExp_FacturaNro.OptionsColumn.AllowEdit = false;
            this.colExp_FacturaNro.Visible = true;
            this.colExp_FacturaNro.VisibleIndex = 3;
            // 
            // colExp_FacturaCajas
            // 
            this.colExp_FacturaCajas.Caption = "Nro Cajas";
            this.colExp_FacturaCajas.FieldName = "Exp_FacturaCajas";
            this.colExp_FacturaCajas.Name = "colExp_FacturaCajas";
            this.colExp_FacturaCajas.OptionsColumn.AllowEdit = false;
            this.colExp_FacturaCajas.Visible = true;
            this.colExp_FacturaCajas.VisibleIndex = 4;
            // 
            // colExp_FacturaImporte
            // 
            this.colExp_FacturaImporte.Caption = "Importe";
            this.colExp_FacturaImporte.FieldName = "Exp_FacturaImporte";
            this.colExp_FacturaImporte.Name = "colExp_FacturaImporte";
            this.colExp_FacturaImporte.OptionsColumn.AllowEdit = false;
            this.colExp_FacturaImporte.Visible = true;
            this.colExp_FacturaImporte.VisibleIndex = 5;
            // 
            // colAbonos
            // 
            this.colAbonos.Caption = "Abonos";
            this.colAbonos.FieldName = "Abonos";
            this.colAbonos.Name = "colAbonos";
            this.colAbonos.Visible = true;
            this.colAbonos.VisibleIndex = 6;
            // 
            // colNC
            // 
            this.colNC.Caption = "NC";
            this.colNC.FieldName = "NC";
            this.colNC.Name = "colNC";
            this.colNC.Visible = true;
            this.colNC.VisibleIndex = 7;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "Saldo";
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 8;
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
            this.pnlCabecera.Size = new System.Drawing.Size(951, 38);
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
            this.pbCerrar.Location = new System.Drawing.Point(913, 0);
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
            this.StatusStrip1.Size = new System.Drawing.Size(951, 22);
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdCabeceraDetalle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 38);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(951, 635);
            this.layoutControl1.TabIndex = 23;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(951, 635);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdCabeceraDetalle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(931, 615);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // sfdRutaArchivo
            // 
            this.sfdRutaArchivo.Filter = "Archivos Excel | *.xls";
            // 
            // FrmConsultaExpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 695);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.pnlCabecera);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaExpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Exportaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConsultaExpo_FormClosed);
            this.Load += new System.EventHandler(this.FrmConsultaExpo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCabeceraDetalle)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCabecera)).EndInit();
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl grdCabeceraDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCabecera;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colCli_Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colExp_FacturaFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colExp_FacturaNro;
        private DevExpress.XtraGrid.Columns.GridColumn colExp_FacturaCajas;
        private DevExpress.XtraGrid.Columns.GridColumn colExp_FacturaImporte;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colProPre_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDet_Cajas;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDet_Kilos;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDet_Precio;
        private DevExpress.XtraGrid.Columns.GridColumn colExpDet_TotalPresentacion;
        private DevExpress.XtraGrid.Columns.GridColumn colAbonos;
        private DevExpress.XtraGrid.Columns.GridColumn colNC;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuExportarExcel;
        private System.Windows.Forms.SaveFileDialog sfdRutaArchivo;
    }
}

