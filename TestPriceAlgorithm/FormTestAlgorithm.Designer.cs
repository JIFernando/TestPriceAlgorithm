﻿namespace TestPriceAlgorithm
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
            this.textBoxBasePrice = new System.Windows.Forms.TextBox();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.textBoxChangeAmount = new System.Windows.Forms.TextBox();
            this.labelChangeAmount = new System.Windows.Forms.Label();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
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
            this.comboBoxPeriodType = new System.Windows.Forms.ComboBox();
            this.groupBoxAlgorithmConf = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBoxRealData = new System.Windows.Forms.GroupBox();
            this.btnGraphReal = new System.Windows.Forms.Button();
            this.groupBoxExtraConf = new System.Windows.Forms.GroupBox();
            this.textBoxExtraStartPeriod = new System.Windows.Forms.TextBox();
            this.labelExtraStartPeriod = new System.Windows.Forms.Label();
            this.comboBoxExtraPeriodType = new System.Windows.Forms.ComboBox();
            this.labelInfoExtraConfig = new System.Windows.Forms.Label();
            this.textBoxExtraPeriod = new System.Windows.Forms.TextBox();
            this.labelExtraPeriod = new System.Windows.Forms.Label();
            this.textBoxExtraChangePercentage = new System.Windows.Forms.TextBox();
            this.labelExtraChangePercentage = new System.Windows.Forms.Label();
            this.textBoxSingleValue = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBoxAlgorithmConf.SuspendLayout();
            this.groupBoxRealData.SuspendLayout();
            this.groupBoxExtraConf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            this.singleValue.Location = new System.Drawing.Point(537, 359);
            this.singleValue.Name = "singleValue";
            this.singleValue.Size = new System.Drawing.Size(75, 23);
            this.singleValue.TabIndex = 2;
            this.singleValue.Text = "Execute algorithm";
            this.singleValue.UseVisualStyleBackColor = true;
            this.singleValue.Click += new System.EventHandler(this.btnSingleValue_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(416, 424);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(525, 424);
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
            // textBoxBasePrice
            // 
            this.textBoxBasePrice.Location = new System.Drawing.Point(146, 22);
            this.textBoxBasePrice.Name = "textBoxBasePrice";
            this.textBoxBasePrice.Size = new System.Drawing.Size(279, 20);
            this.textBoxBasePrice.TabIndex = 6;
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
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(146, 48);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(279, 20);
            this.textBoxMaxPrice.TabIndex = 8;
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(146, 74);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(279, 20);
            this.textBoxMinPrice.TabIndex = 10;
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
            // textBoxChangeAmount
            // 
            this.textBoxChangeAmount.Location = new System.Drawing.Point(146, 100);
            this.textBoxChangeAmount.Name = "textBoxChangeAmount";
            this.textBoxChangeAmount.Size = new System.Drawing.Size(279, 20);
            this.textBoxChangeAmount.TabIndex = 12;
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
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(146, 126);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(52, 20);
            this.textBoxPeriod.TabIndex = 14;
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
            this.bindingNavigator1.Size = new System.Drawing.Size(1112, 25);
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
            // comboBoxPeriodType
            // 
            this.comboBoxPeriodType.FormattingEnabled = true;
            this.comboBoxPeriodType.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Months"});
            this.comboBoxPeriodType.Location = new System.Drawing.Point(204, 125);
            this.comboBoxPeriodType.Name = "comboBoxPeriodType";
            this.comboBoxPeriodType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriodType.TabIndex = 16;
            // 
            // groupBoxAlgorithmConf
            // 
            this.groupBoxAlgorithmConf.Controls.Add(this.checkBox1);
            this.groupBoxAlgorithmConf.Controls.Add(this.textBoxMinPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.comboBoxPeriodType);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelBasePrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.textBoxBasePrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.textBoxPeriod);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelMaxPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelPeriod);
            this.groupBoxAlgorithmConf.Controls.Add(this.textBoxMaxPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.textBoxChangeAmount);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelMinPrice);
            this.groupBoxAlgorithmConf.Controls.Add(this.labelChangeAmount);
            this.groupBoxAlgorithmConf.Location = new System.Drawing.Point(30, 194);
            this.groupBoxAlgorithmConf.Name = "groupBoxAlgorithmConf";
            this.groupBoxAlgorithmConf.Size = new System.Drawing.Size(452, 208);
            this.groupBoxAlgorithmConf.TabIndex = 17;
            this.groupBoxAlgorithmConf.TabStop = false;
            this.groupBoxAlgorithmConf.Text = "Algorithm configuration";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Include Extra configuration";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBoxRealData
            // 
            this.groupBoxRealData.Controls.Add(this.btnGraphReal);
            this.groupBoxRealData.Controls.Add(this.btnImportCsv);
            this.groupBoxRealData.Controls.Add(this.csvFileName);
            this.groupBoxRealData.Location = new System.Drawing.Point(30, 56);
            this.groupBoxRealData.Name = "groupBoxRealData";
            this.groupBoxRealData.Size = new System.Drawing.Size(957, 97);
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
            this.groupBoxExtraConf.Controls.Add(this.textBoxExtraStartPeriod);
            this.groupBoxExtraConf.Controls.Add(this.labelExtraStartPeriod);
            this.groupBoxExtraConf.Controls.Add(this.comboBoxExtraPeriodType);
            this.groupBoxExtraConf.Controls.Add(this.labelInfoExtraConfig);
            this.groupBoxExtraConf.Controls.Add(this.textBoxExtraPeriod);
            this.groupBoxExtraConf.Controls.Add(this.labelExtraPeriod);
            this.groupBoxExtraConf.Controls.Add(this.textBoxExtraChangePercentage);
            this.groupBoxExtraConf.Controls.Add(this.labelExtraChangePercentage);
            this.groupBoxExtraConf.Location = new System.Drawing.Point(535, 194);
            this.groupBoxExtraConf.Name = "groupBoxExtraConf";
            this.groupBoxExtraConf.Size = new System.Drawing.Size(452, 146);
            this.groupBoxExtraConf.TabIndex = 18;
            this.groupBoxExtraConf.TabStop = false;
            this.groupBoxExtraConf.Text = "Algorithm extra configuration";
            this.groupBoxExtraConf.Visible = false;
            // 
            // textBoxExtraStartPeriod
            // 
            this.textBoxExtraStartPeriod.Location = new System.Drawing.Point(180, 103);
            this.textBoxExtraStartPeriod.Name = "textBoxExtraStartPeriod";
            this.textBoxExtraStartPeriod.Size = new System.Drawing.Size(52, 20);
            this.textBoxExtraStartPeriod.TabIndex = 18;
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
            // comboBoxExtraPeriodType
            // 
            this.comboBoxExtraPeriodType.FormattingEnabled = true;
            this.comboBoxExtraPeriodType.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours",
            "Days",
            "Months"});
            this.comboBoxExtraPeriodType.Location = new System.Drawing.Point(204, 76);
            this.comboBoxExtraPeriodType.Name = "comboBoxExtraPeriodType";
            this.comboBoxExtraPeriodType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtraPeriodType.TabIndex = 16;
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
            // textBoxExtraPeriod
            // 
            this.textBoxExtraPeriod.Location = new System.Drawing.Point(146, 77);
            this.textBoxExtraPeriod.Name = "textBoxExtraPeriod";
            this.textBoxExtraPeriod.Size = new System.Drawing.Size(52, 20);
            this.textBoxExtraPeriod.TabIndex = 14;
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
            // textBoxExtraChangePercentage
            // 
            this.textBoxExtraChangePercentage.Location = new System.Drawing.Point(146, 51);
            this.textBoxExtraChangePercentage.Name = "textBoxExtraChangePercentage";
            this.textBoxExtraChangePercentage.Size = new System.Drawing.Size(279, 20);
            this.textBoxExtraChangePercentage.TabIndex = 12;
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
            // textBoxSingleValue
            // 
            this.textBoxSingleValue.Location = new System.Drawing.Point(646, 361);
            this.textBoxSingleValue.Name = "textBoxSingleValue";
            this.textBoxSingleValue.ReadOnly = true;
            this.textBoxSingleValue.Size = new System.Drawing.Size(279, 20);
            this.textBoxSingleValue.TabIndex = 20;
            this.textBoxSingleValue.Text = "New Price";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormTestAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 474);
            this.Controls.Add(this.textBoxSingleValue);
            this.Controls.Add(this.groupBoxExtraConf);
            this.Controls.Add(this.groupBoxRealData);
            this.Controls.Add(this.groupBoxAlgorithmConf);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.singleValue);
            this.Name = "FormTestAlgorithm";
            this.Text = "Inpuct info";
            this.Load += new System.EventHandler(this.FormTestAlgorithm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBoxAlgorithmConf.ResumeLayout(false);
            this.groupBoxAlgorithmConf.PerformLayout();
            this.groupBoxRealData.ResumeLayout(false);
            this.groupBoxRealData.PerformLayout();
            this.groupBoxExtraConf.ResumeLayout(false);
            this.groupBoxExtraConf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxBasePrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.TextBox textBoxChangeAmount;
        private System.Windows.Forms.Label labelChangeAmount;
        private System.Windows.Forms.TextBox textBoxPeriod;
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
        private System.Windows.Forms.ComboBox comboBoxPeriodType;
        private System.Windows.Forms.GroupBox groupBoxAlgorithmConf;
        private System.Windows.Forms.GroupBox groupBoxRealData;
        private System.Windows.Forms.Button btnGraphReal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBoxExtraConf;
        private System.Windows.Forms.ComboBox comboBoxExtraPeriodType;
        private System.Windows.Forms.Label labelInfoExtraConfig;
        private System.Windows.Forms.TextBox textBoxExtraPeriod;
        private System.Windows.Forms.Label labelExtraPeriod;
        private System.Windows.Forms.TextBox textBoxExtraChangePercentage;
        private System.Windows.Forms.Label labelExtraChangePercentage;
        private System.Windows.Forms.TextBox textBoxExtraStartPeriod;
        private System.Windows.Forms.Label labelExtraStartPeriod;
        private System.Windows.Forms.TextBox textBoxSingleValue;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
