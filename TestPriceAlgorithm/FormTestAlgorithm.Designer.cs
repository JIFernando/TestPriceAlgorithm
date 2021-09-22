using System;

namespace TestPriceAlgorithm
{
    partial class FormTestAlgorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestAlgorithm));
            this.btnImportCsv = new System.Windows.Forms.Button();
            this.csvFileName = new System.Windows.Forms.TextBox();
            this.singleValue = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.labelBasePrice = new System.Windows.Forms.Label();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.txtMaxPrice = new System.Windows.Forms.TextBox();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.txtChangeAmount = new System.Windows.Forms.TextBox();
            this.labelChangeAmount = new System.Windows.Forms.Label();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbPeriodType = new System.Windows.Forms.ComboBox();
            this.periodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxAlgorithmConf = new System.Windows.Forms.GroupBox();
            this.chbIncludeExtra = new System.Windows.Forms.CheckBox();
            this.groupBoxRealData = new System.Windows.Forms.GroupBox();
            this.btnGraphReal = new System.Windows.Forms.Button();
            this.groupBoxExtraConf = new System.Windows.Forms.GroupBox();
            this.txtExtraStartPeriod = new System.Windows.Forms.TextBox();
            this.labelExtraStartPeriod = new System.Windows.Forms.Label();
            this.cbExtraPeriodType = new System.Windows.Forms.ComboBox();
            this.labelInfoExtraConfig = new System.Windows.Forms.Label();
            this.txtExtraPeriod = new System.Windows.Forms.TextBox();
            this.labelExtraPeriod = new System.Windows.Forms.Label();
            this.txtChangePercentage = new System.Windows.Forms.TextBox();
            this.labelExtraChangePercentage = new System.Windows.Forms.Label();
            this.txtSingleValue = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.periodDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBenefitsReal = new System.Windows.Forms.TextBox();
            this.txtBenefitAlg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalculateBenefits = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.gtNormalBuyers = new System.Windows.Forms.GroupBox();
            this.txtRandomBuyers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonths = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAgressiveBuyers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompulsiveBuyers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOcaassionalBuyers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumbBuyers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCautiousBuyers = new System.Windows.Forms.TextBox();
            this.txtNormalBuyers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodTypeBindingSource)).BeginInit();
            this.groupBoxAlgorithmConf.SuspendLayout();
            this.groupBoxRealData.SuspendLayout();
            this.groupBoxExtraConf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodDataBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gtNormalBuyers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportCsv
            // 
            this.btnImportCsv.Location = new System.Drawing.Point(33, 29);
            this.btnImportCsv.Name = "btnImportCsv";
            this.btnImportCsv.Size = new System.Drawing.Size(75, 23);
            this.btnImportCsv.TabIndex = 0;
            this.btnImportCsv.Text = "Import CSV";
            this.btnImportCsv.UseVisualStyleBackColor = true;
            this.btnImportCsv.Click += new System.EventHandler(this.btnImportCsv_Click);
            // 
            // csvFileName
            // 
            this.csvFileName.Location = new System.Drawing.Point(146, 31);
            this.csvFileName.Name = "csvFileName";
            this.csvFileName.ReadOnly = true;
            this.csvFileName.Size = new System.Drawing.Size(279, 20);
            this.csvFileName.TabIndex = 1;
            this.csvFileName.Text = "Real data file name";
            // 
            // singleValue
            // 
            this.singleValue.Location = new System.Drawing.Point(67, 397);
            this.singleValue.Name = "singleValue";
            this.singleValue.Size = new System.Drawing.Size(75, 23);
            this.singleValue.TabIndex = 2;
            this.singleValue.Text = "Execute algorithm";
            this.singleValue.UseVisualStyleBackColor = true;
            this.singleValue.Click += new System.EventHandler(this.btnSingleValue_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(1006, 60);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(1006, 99);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonGraph.TabIndex = 4;
            this.buttonGraph.Text = "Graph";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // labelBasePrice
            // 
            this.labelBasePrice.AutoSize = true;
            this.labelBasePrice.Location = new System.Drawing.Point(25, 29);
            this.labelBasePrice.Name = "labelBasePrice";
            this.labelBasePrice.Size = new System.Drawing.Size(74, 13);
            this.labelBasePrice.TabIndex = 5;
            this.labelBasePrice.Text = "Product Price:";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(146, 22);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(279, 20);
            this.txtBasePrice.TabIndex = 6;
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(25, 51);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(97, 13);
            this.labelMaxPrice.TabIndex = 7;
            this.labelMaxPrice.Text = "Product Max Price:";
            // 
            // txtMaxPrice
            // 
            this.txtMaxPrice.Location = new System.Drawing.Point(146, 48);
            this.txtMaxPrice.Name = "txtMaxPrice";
            this.txtMaxPrice.Size = new System.Drawing.Size(279, 20);
            this.txtMaxPrice.TabIndex = 8;
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Location = new System.Drawing.Point(146, 74);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(279, 20);
            this.txtMinPrice.TabIndex = 10;
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(25, 77);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(94, 13);
            this.labelMinPrice.TabIndex = 9;
            this.labelMinPrice.Text = "Product Min Price:";
            // 
            // txtChangeAmount
            // 
            this.txtChangeAmount.Location = new System.Drawing.Point(146, 100);
            this.txtChangeAmount.Name = "txtChangeAmount";
            this.txtChangeAmount.Size = new System.Drawing.Size(279, 20);
            this.txtChangeAmount.TabIndex = 12;
            // 
            // labelChangeAmount
            // 
            this.labelChangeAmount.AutoSize = true;
            this.labelChangeAmount.Location = new System.Drawing.Point(25, 103);
            this.labelChangeAmount.Name = "labelChangeAmount";
            this.labelChangeAmount.Size = new System.Drawing.Size(83, 13);
            this.labelChangeAmount.TabIndex = 11;
            this.labelChangeAmount.Text = "Change Amount";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(146, 126);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(52, 20);
            this.txtPeriod.TabIndex = 14;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(25, 129);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(40, 13);
            this.labelPeriod.TabIndex = 13;
            this.labelPeriod.Text = "Period:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1128, 25);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cbPeriodType
            // 
            this.cbPeriodType.FormattingEnabled = true;
            this.cbPeriodType.Location = new System.Drawing.Point(204, 125);
            this.cbPeriodType.Name = "cbPeriodType";
            this.cbPeriodType.Size = new System.Drawing.Size(121, 21);
            this.cbPeriodType.TabIndex = 16;
            // 
            // periodTypeBindingSource
            // 
            this.periodTypeBindingSource.DataSource = typeof(TestPriceAlgorithm.FormTestAlgorithm.PeriodType);
            // 
            // groupBoxAlgorithmConf
            // 
            this.groupBoxAlgorithmConf.Controls.Add(this.chbIncludeExtra);
            this.groupBoxAlgorithmConf.Controls.Add(this.txtMinPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.cbPeriodType);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelBasePrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.txtBasePrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.txtPeriod);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelMaxPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelPeriod);
            this.groupBoxAlgorithmConf.Controls.Add(this.txtMaxPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.txtChangeAmount);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelMinPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelChangeAmount);
            this.groupBoxAlgorithmConf.Location = new System.Drawing.Point(39, 22);
            this.groupBoxAlgorithmConf.Name = "groupBoxAlgorithmConf";
            this.groupBoxAlgorithmConf.Size = new System.Drawing.Size(452, 208);
            this.groupBoxAlgorithmConf.TabIndex = 17;
            this.groupBoxAlgorithmConf.TabStop = false;
            this.groupBoxAlgorithmConf.Text = "Algorithm configuration";
            // 
            // chbIncludeExtra
            // 
            this.chbIncludeExtra.AutoSize = true;
            this.chbIncludeExtra.Location = new System.Drawing.Point(146, 167);
            this.chbIncludeExtra.Name = "chbIncludeExtra";
            this.chbIncludeExtra.Size = new System.Drawing.Size(152, 17);
            this.chbIncludeExtra.TabIndex = 17;
            this.chbIncludeExtra.Text = "Include Extra configuration";
            this.chbIncludeExtra.UseVisualStyleBackColor = true;
            this.chbIncludeExtra.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxRealData
            // 
            this.groupBoxRealData.Controls.Add(this.btnGraphReal);
            this.groupBoxRealData.Controls.Add(this.btnImportCsv);
            this.groupBoxRealData.Controls.Add(this.csvFileName);
            this.groupBoxRealData.Location = new System.Drawing.Point(523, 267);
            this.groupBoxRealData.Name = "groupBoxRealData";
            this.groupBoxRealData.Size = new System.Drawing.Size(452, 97);
            this.groupBoxRealData.TabIndex = 18;
            this.groupBoxRealData.TabStop = false;
            this.groupBoxRealData.Text = "Real Data";
            // 
            // btnGraphReal
            // 
            this.btnGraphReal.Location = new System.Drawing.Point(33, 58);
            this.btnGraphReal.Name = "btnGraphReal";
            this.btnGraphReal.Size = new System.Drawing.Size(75, 23);
            this.btnGraphReal.TabIndex = 19;
            this.btnGraphReal.Text = "Graph";
            this.btnGraphReal.UseVisualStyleBackColor = true;
            this.btnGraphReal.Click += new System.EventHandler(this.btnGraphReal_Click);
            // 
            // groupBoxExtraConf
            // 
            this.groupBoxExtraConf.Controls.Add(this.txtExtraStartPeriod);
            this.groupBoxExtraConf.Controls.Add(this.labelExtraStartPeriod);
            this.groupBoxExtraConf.Controls.Add(this.cbExtraPeriodType);
            this.groupBoxExtraConf.Controls.Add(this.labelInfoExtraConfig);
            this.groupBoxExtraConf.Controls.Add(this.txtExtraPeriod);
            this.groupBoxExtraConf.Controls.Add(this.labelExtraPeriod);
            this.groupBoxExtraConf.Controls.Add(this.txtChangePercentage);
            this.groupBoxExtraConf.Controls.Add(this.labelExtraChangePercentage);
            this.groupBoxExtraConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxExtraConf.Location = new System.Drawing.Point(39, 244);
            this.groupBoxExtraConf.Name = "groupBoxExtraConf";
            this.groupBoxExtraConf.Size = new System.Drawing.Size(452, 146);
            this.groupBoxExtraConf.TabIndex = 18;
            this.groupBoxExtraConf.TabStop = false;
            this.groupBoxExtraConf.Text = "Algorithm extra configuration";
            // 
            // txtExtraStartPeriod
            // 
            this.txtExtraStartPeriod.Enabled = false;
            this.txtExtraStartPeriod.Location = new System.Drawing.Point(180, 103);
            this.txtExtraStartPeriod.Name = "txtExtraStartPeriod";
            this.txtExtraStartPeriod.Size = new System.Drawing.Size(52, 20);
            this.txtExtraStartPeriod.TabIndex = 18;
            // 
            // labelExtraStartPeriod
            // 
            this.labelExtraStartPeriod.AutoSize = true;
            this.labelExtraStartPeriod.Location = new System.Drawing.Point(25, 107);
            this.labelExtraStartPeriod.Name = "labelExtraStartPeriod";
            this.labelExtraStartPeriod.Size = new System.Drawing.Size(149, 13);
            this.labelExtraStartPeriod.TabIndex = 17;
            this.labelExtraStartPeriod.Text = "Start configuration afer period:";
            // 
            // cbExtraPeriodType
            // 
            this.cbExtraPeriodType.Enabled = false;
            this.cbExtraPeriodType.FormattingEnabled = true;
            this.cbExtraPeriodType.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Months"});
            this.cbExtraPeriodType.Location = new System.Drawing.Point(204, 76);
            this.cbExtraPeriodType.Name = "cbExtraPeriodType";
            this.cbExtraPeriodType.Size = new System.Drawing.Size(121, 21);
            this.cbExtraPeriodType.TabIndex = 16;
            // 
            // labelInfoExtraConfig
            // 
            this.labelInfoExtraConfig.AutoSize = true;
            this.labelInfoExtraConfig.Location = new System.Drawing.Point(25, 29);
            this.labelInfoExtraConfig.Name = "labelInfoExtraConfig";
            this.labelInfoExtraConfig.Size = new System.Drawing.Size(277, 13);
            this.labelInfoExtraConfig.TabIndex = 5;
            this.labelInfoExtraConfig.Text = "Change the prices in case the sales are very unexpective";
            // 
            // txtExtraPeriod
            // 
            this.txtExtraPeriod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtraPeriod.Enabled = false;
            this.txtExtraPeriod.Location = new System.Drawing.Point(146, 77);
            this.txtExtraPeriod.Name = "txtExtraPeriod";
            this.txtExtraPeriod.Size = new System.Drawing.Size(52, 20);
            this.txtExtraPeriod.TabIndex = 14;
            // 
            // labelExtraPeriod
            // 
            this.labelExtraPeriod.AutoSize = true;
            this.labelExtraPeriod.Location = new System.Drawing.Point(25, 80);
            this.labelExtraPeriod.Name = "labelExtraPeriod";
            this.labelExtraPeriod.Size = new System.Drawing.Size(40, 13);
            this.labelExtraPeriod.TabIndex = 13;
            this.labelExtraPeriod.Text = "Period:";
            // 
            // txtChangePercentage
            // 
            this.txtChangePercentage.Enabled = false;
            this.txtChangePercentage.Location = new System.Drawing.Point(146, 51);
            this.txtChangePercentage.Name = "txtChangePercentage";
            this.txtChangePercentage.Size = new System.Drawing.Size(279, 20);
            this.txtChangePercentage.TabIndex = 12;
            // 
            // labelExtraChangePercentage
            // 
            this.labelExtraChangePercentage.AutoSize = true;
            this.labelExtraChangePercentage.Location = new System.Drawing.Point(25, 54);
            this.labelExtraChangePercentage.Name = "labelExtraChangePercentage";
            this.labelExtraChangePercentage.Size = new System.Drawing.Size(102, 13);
            this.labelExtraChangePercentage.TabIndex = 11;
            this.labelExtraChangePercentage.Text = "Change Percentage";
            // 
            // txtSingleValue
            // 
            this.txtSingleValue.Location = new System.Drawing.Point(185, 399);
            this.txtSingleValue.Name = "txtSingleValue";
            this.txtSingleValue.ReadOnly = true;
            this.txtSingleValue.Size = new System.Drawing.Size(279, 20);
            this.txtSingleValue.TabIndex = 20;
            this.txtSingleValue.Text = "New Price";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Benefits- Real";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Benefit algorithm";
            // 
            // txtBenefitsReal
            // 
            this.txtBenefitsReal.Location = new System.Drawing.Point(236, 29);
            this.txtBenefitsReal.Name = "txtBenefitsReal";
            this.txtBenefitsReal.ReadOnly = true;
            this.txtBenefitsReal.Size = new System.Drawing.Size(180, 20);
            this.txtBenefitsReal.TabIndex = 19;
            // 
            // txtBenefitAlg
            // 
            this.txtBenefitAlg.Location = new System.Drawing.Point(236, 58);
            this.txtBenefitAlg.Name = "txtBenefitAlg";
            this.txtBenefitAlg.ReadOnly = true;
            this.txtBenefitAlg.Size = new System.Drawing.Size(180, 20);
            this.txtBenefitAlg.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalculateBenefits);
            this.groupBox1.Controls.Add(this.txtBenefitAlg);
            this.groupBox1.Controls.Add(this.txtBenefitsReal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(523, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 97);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comparation Benefits";
            // 
            // CalculateBenefits
            // 
            this.CalculateBenefits.Location = new System.Drawing.Point(33, 29);
            this.CalculateBenefits.Name = "CalculateBenefits";
            this.CalculateBenefits.Size = new System.Drawing.Size(75, 23);
            this.CalculateBenefits.TabIndex = 0;
            this.CalculateBenefits.Text = "Calculate Benefits";
            this.CalculateBenefits.UseVisualStyleBackColor = true;
            this.CalculateBenefits.Click += new System.EventHandler(this.CalculateBenefits_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSimulate);
            this.panel1.Controls.Add(this.gtNormalBuyers);
            this.panel1.Controls.Add(this.groupBoxAlgorithmConf);
            this.panel1.Controls.Add(this.buttonGraph);
            this.panel1.Controls.Add(this.groupBoxRealData);
            this.panel1.Controls.Add(this.buttonExport);
            this.panel1.Controls.Add(this.txtSingleValue);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxExtraConf);
            this.panel1.Controls.Add(this.singleValue);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 583);
            this.panel1.TabIndex = 22;
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(1006, 22);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(75, 23);
            this.btnSimulate.TabIndex = 21;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // gtNormalBuyers
            // 
            this.gtNormalBuyers.Controls.Add(this.txtRandomBuyers);
            this.gtNormalBuyers.Controls.Add(this.label10);
            this.gtNormalBuyers.Controls.Add(this.txtMonths);
            this.gtNormalBuyers.Controls.Add(this.label9);
            this.gtNormalBuyers.Controls.Add(this.txtAgressiveBuyers);
            this.gtNormalBuyers.Controls.Add(this.label8);
            this.gtNormalBuyers.Controls.Add(this.txtCompulsiveBuyers);
            this.gtNormalBuyers.Controls.Add(this.label5);
            this.gtNormalBuyers.Controls.Add(this.txtOcaassionalBuyers);
            this.gtNormalBuyers.Controls.Add(this.label3);
            this.gtNormalBuyers.Controls.Add(this.txtNumbBuyers);
            this.gtNormalBuyers.Controls.Add(this.label4);
            this.gtNormalBuyers.Controls.Add(this.txtCautiousBuyers);
            this.gtNormalBuyers.Controls.Add(this.txtNormalBuyers);
            this.gtNormalBuyers.Controls.Add(this.label6);
            this.gtNormalBuyers.Controls.Add(this.label7);
            this.gtNormalBuyers.Location = new System.Drawing.Point(523, 22);
            this.gtNormalBuyers.Name = "gtNormalBuyers";
            this.gtNormalBuyers.Size = new System.Drawing.Size(452, 239);
            this.gtNormalBuyers.TabIndex = 18;
            this.gtNormalBuyers.TabStop = false;
            this.gtNormalBuyers.Text = "Posible buyer configuration";
            // 
            // txtRandomBuyers
            // 
            this.txtRandomBuyers.Location = new System.Drawing.Point(146, 178);
            this.txtRandomBuyers.Name = "txtRandomBuyers";
            this.txtRandomBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtRandomBuyers.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "%Random Buyers:";
            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(146, 205);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(279, 20);
            this.txtMonths.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Months to simulate:";
            // 
            // txtAgressiveBuyers
            // 
            this.txtAgressiveBuyers.Location = new System.Drawing.Point(146, 152);
            this.txtAgressiveBuyers.Name = "txtAgressiveBuyers";
            this.txtAgressiveBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtAgressiveBuyers.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "%Aggressive buyers:";
            // 
            // txtCompulsiveBuyers
            // 
            this.txtCompulsiveBuyers.Location = new System.Drawing.Point(146, 126);
            this.txtCompulsiveBuyers.Name = "txtCompulsiveBuyers";
            this.txtCompulsiveBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtCompulsiveBuyers.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "%Compulsive buyers:";
            // 
            // txtOcaassionalBuyers
            // 
            this.txtOcaassionalBuyers.Location = new System.Drawing.Point(146, 74);
            this.txtOcaassionalBuyers.Name = "txtOcaassionalBuyers";
            this.txtOcaassionalBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtOcaassionalBuyers.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Buyer:s per day";
            // 
            // txtNumbBuyers
            // 
            this.txtNumbBuyers.Location = new System.Drawing.Point(146, 22);
            this.txtNumbBuyers.Name = "txtNumbBuyers";
            this.txtNumbBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtNumbBuyers.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "%Cautious buyers:";
            // 
            // txtCautiousBuyers
            // 
            this.txtCautiousBuyers.Location = new System.Drawing.Point(146, 48);
            this.txtCautiousBuyers.Name = "txtCautiousBuyers";
            this.txtCautiousBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtCautiousBuyers.TabIndex = 8;
            // 
            // txtNormalBuyers
            // 
            this.txtNormalBuyers.Location = new System.Drawing.Point(146, 100);
            this.txtNormalBuyers.Name = "txtNormalBuyers";
            this.txtNormalBuyers.Size = new System.Drawing.Size(279, 20);
            this.txtNormalBuyers.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "%Occasional buyers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "%Normal buyers:";
            // 
            // FormTestAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 612);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTestAlgorithm";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormTestAlgorithm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodTypeBindingSource)).EndInit();
            this.groupBoxAlgorithmConf.ResumeLayout(false);
            this.groupBoxAlgorithmConf.PerformLayout();
            this.groupBoxRealData.ResumeLayout(false);
            this.groupBoxRealData.PerformLayout();
            this.groupBoxExtraConf.ResumeLayout(false);
            this.groupBoxExtraConf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodDataBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gtNormalBuyers.ResumeLayout(false);
            this.gtNormalBuyers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportCsv;
        private System.Windows.Forms.TextBox csvFileName;
        private System.Windows.Forms.Button singleValue;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Label labelBasePrice;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.TextBox txtChangeAmount;
        private System.Windows.Forms.Label labelChangeAmount;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ComboBox cbPeriodType;
        private System.Windows.Forms.GroupBox groupBoxAlgorithmConf;
        private System.Windows.Forms.GroupBox groupBoxRealData;
        private System.Windows.Forms.Button btnGraphReal;
        private System.Windows.Forms.CheckBox chbIncludeExtra;
        private System.Windows.Forms.GroupBox groupBoxExtraConf;
        private System.Windows.Forms.ComboBox cbExtraPeriodType;
        private System.Windows.Forms.Label labelInfoExtraConfig;
        private System.Windows.Forms.TextBox txtExtraPeriod;
        private System.Windows.Forms.Label labelExtraPeriod;
        private System.Windows.Forms.TextBox txtChangePercentage;
        private System.Windows.Forms.Label labelExtraChangePercentage;
        private System.Windows.Forms.TextBox txtExtraStartPeriod;
        private System.Windows.Forms.Label labelExtraStartPeriod;
        private System.Windows.Forms.TextBox txtSingleValue;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.BindingSource periodDataBindingSource;
        private System.Windows.Forms.TextBox txtBenefitAlg;
        private System.Windows.Forms.TextBox txtBenefitsReal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalculateBenefits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource periodTypeBindingSource;
        private System.Windows.Forms.GroupBox gtNormalBuyers;
        private System.Windows.Forms.TextBox txtOcaassionalBuyers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumbBuyers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCautiousBuyers;
        private System.Windows.Forms.TextBox txtNormalBuyers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgressiveBuyers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompulsiveBuyers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.TextBox txtRandomBuyers;
        private System.Windows.Forms.Label label10;
    }
}

