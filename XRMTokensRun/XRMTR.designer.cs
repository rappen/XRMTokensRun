
namespace XRMTokensRun
{
    partial class XRMTR
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XRMTR));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBackTool = new System.Windows.Forms.ToolStripButton();
            this.tslAbout = new System.Windows.Forms.ToolStripLabel();
            this.gbGetRecord = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenRecord = new System.Windows.Forms.Button();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTable = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recordname = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.record = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbTokens = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTokensIn = new System.Windows.Forms.TextBox();
            this.gbSmart = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSmartRandom = new System.Windows.Forms.Button();
            this.btnSmartSystem = new System.Windows.Forms.Button();
            this.btnSmartIf = new System.Windows.Forms.Button();
            this.btnSmartExpand = new System.Windows.Forms.Button();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.lblSmart = new System.Windows.Forms.Label();
            this.btnAddToken = new System.Windows.Forms.Button();
            this.btnSmartColumn = new System.Windows.Forms.Button();
            this.cmbTokenHelp = new System.Windows.Forms.ComboBox();
            this.gbTokenResult = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.TextBox();
            this.txtTokensOut = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripMenu.SuspendLayout();
            this.gbGetRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbTokens.SuspendLayout();
            this.gbSmart.SuspendLayout();
            this.gbTokenResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btnBackTool,
            this.tslAbout});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.toolStripMenu.Size = new System.Drawing.Size(997, 39);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(181, 28);
            this.toolStripLabel1.Text = "XRM Tokens Documentation";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnBackTool
            // 
            this.btnBackTool.Image = ((System.Drawing.Image)(resources.GetObject("btnBackTool.Image")));
            this.btnBackTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackTool.Name = "btnBackTool";
            this.btnBackTool.Size = new System.Drawing.Size(156, 28);
            this.btnBackTool.Text = "Send back XRM Tokens";
            this.btnBackTool.ToolTipText = "Send back XRM Tokens\r\nMake sure the target tool knows the same features of the XR" +
    "M Tokens!";
            this.btnBackTool.Click += new System.EventHandler(this.btnBackTool_Click);
            // 
            // tslAbout
            // 
            this.tslAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslAbout.Image = ((System.Drawing.Image)(resources.GetObject("tslAbout.Image")));
            this.tslAbout.IsLink = true;
            this.tslAbout.Name = "tslAbout";
            this.tslAbout.Size = new System.Drawing.Size(106, 28);
            this.tslAbout.Text = "by Jonas Rapp";
            this.tslAbout.Click += new System.EventHandler(this.tslAbout_Click);
            // 
            // gbGetRecord
            // 
            this.gbGetRecord.Controls.Add(this.btnRefresh);
            this.gbGetRecord.Controls.Add(this.btnOpenRecord);
            this.gbGetRecord.Controls.Add(this.btnGetRecord);
            this.gbGetRecord.Controls.Add(this.label2);
            this.gbGetRecord.Controls.Add(this.cmbTable);
            this.gbGetRecord.Controls.Add(this.label1);
            this.gbGetRecord.Controls.Add(this.recordname);
            this.gbGetRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGetRecord.Location = new System.Drawing.Point(0, 4);
            this.gbGetRecord.Name = "gbGetRecord";
            this.gbGetRecord.Size = new System.Drawing.Size(997, 106);
            this.gbGetRecord.TabIndex = 1;
            this.gbGetRecord.TabStop = false;
            this.gbGetRecord.Text = "Get Record";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(776, 53);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 33);
            this.btnRefresh.TabIndex = 7;
            this.tt.SetToolTip(this.btnRefresh, "Refresh selected record - useful if record has changed.");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenRecord
            // 
            this.btnOpenRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenRecord.BackColor = System.Drawing.SystemColors.Window;
            this.btnOpenRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenRecord.Image")));
            this.btnOpenRecord.Location = new System.Drawing.Point(819, 53);
            this.btnOpenRecord.Name = "btnOpenRecord";
            this.btnOpenRecord.Size = new System.Drawing.Size(37, 33);
            this.btnOpenRecord.TabIndex = 8;
            this.tt.SetToolTip(this.btnOpenRecord, "Open this record in the browser.");
            this.btnOpenRecord.UseVisualStyleBackColor = false;
            this.btnOpenRecord.Click += new System.EventHandler(this.btnOpenRecord_Click);
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetRecord.BackColor = System.Drawing.SystemColors.Window;
            this.btnGetRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnGetRecord.Image")));
            this.btnGetRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetRecord.Location = new System.Drawing.Point(862, 53);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(120, 33);
            this.btnGetRecord.TabIndex = 10;
            this.btnGetRecord.Text = "Lookup...";
            this.tt.SetToolTip(this.btnGetRecord, "Choose the record for this table.");
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Record";
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(23, 58);
            this.cmbTable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(375, 24);
            this.cmbTable.TabIndex = 0;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            this.cmbTable.Leave += new System.EventHandler(this.cmbTable_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // recordname
            // 
            this.recordname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordname.BackColor = System.Drawing.SystemColors.Window;
            this.recordname.Column = null;
            this.recordname.DisplayFormat = "";
            this.recordname.Location = new System.Drawing.Point(425, 58);
            this.recordname.Margin = new System.Windows.Forms.Padding(4);
            this.recordname.Name = "recordname";
            this.recordname.ReadOnly = true;
            this.recordname.RecordHost = this.record;
            this.recordname.Size = new System.Drawing.Size(344, 22);
            this.recordname.TabIndex = 3;
            // 
            // record
            // 
            this.record.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.record.LogicalName = null;
            this.record.Record = null;
            this.record.Service = null;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 39);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbTokens);
            this.splitContainer2.Panel1.Controls.Add(this.gbGetRecord);
            this.splitContainer2.Panel1.Controls.Add(this.gbSmart);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbTokenResult);
            this.splitContainer2.Size = new System.Drawing.Size(997, 599);
            this.splitContainer2.SplitterDistance = 386;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbTokens
            // 
            this.gbTokens.Controls.Add(this.btnSave);
            this.gbTokens.Controls.Add(this.btnOpen);
            this.gbTokens.Controls.Add(this.label3);
            this.gbTokens.Controls.Add(this.txtTokensIn);
            this.gbTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTokens.Location = new System.Drawing.Point(0, 110);
            this.gbTokens.Name = "gbTokens";
            this.gbTokens.Size = new System.Drawing.Size(997, 191);
            this.gbTokens.TabIndex = 5;
            this.gbTokens.TabStop = false;
            this.gbTokens.Text = "XRM Tokens";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(862, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.SystemColors.Window;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(735, 26);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 33);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input - all the text and Tokens";
            // 
            // txtTokensIn
            // 
            this.txtTokensIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokensIn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTokensIn.HideSelection = false;
            this.txtTokensIn.Location = new System.Drawing.Point(23, 68);
            this.txtTokensIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTokensIn.Multiline = true;
            this.txtTokensIn.Name = "txtTokensIn";
            this.txtTokensIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTokensIn.Size = new System.Drawing.Size(959, 108);
            this.txtTokensIn.TabIndex = 1;
            this.txtTokensIn.TextChanged += new System.EventHandler(this.txtTokensIn_TextChanged);
            // 
            // gbSmart
            // 
            this.gbSmart.Controls.Add(this.button1);
            this.gbSmart.Controls.Add(this.btnSmartRandom);
            this.gbSmart.Controls.Add(this.btnSmartSystem);
            this.gbSmart.Controls.Add(this.btnSmartIf);
            this.gbSmart.Controls.Add(this.btnSmartExpand);
            this.gbSmart.Controls.Add(this.linkHelp);
            this.gbSmart.Controls.Add(this.lblSmart);
            this.gbSmart.Controls.Add(this.btnAddToken);
            this.gbSmart.Controls.Add(this.btnSmartColumn);
            this.gbSmart.Controls.Add(this.cmbTokenHelp);
            this.gbSmart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSmart.Location = new System.Drawing.Point(0, 301);
            this.gbSmart.Name = "gbSmart";
            this.gbSmart.Size = new System.Drawing.Size(997, 85);
            this.gbSmart.TabIndex = 6;
            this.gbSmart.TabStop = false;
            this.gbSmart.Text = "Build XRM Tokens";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(23, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Power Fx";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSmartPowerFx_Click);
            // 
            // btnSmartRandom
            // 
            this.btnSmartRandom.BackColor = System.Drawing.SystemColors.Window;
            this.btnSmartRandom.Location = new System.Drawing.Point(254, 32);
            this.btnSmartRandom.Name = "btnSmartRandom";
            this.btnSmartRandom.Size = new System.Drawing.Size(71, 25);
            this.btnSmartRandom.TabIndex = 30;
            this.btnSmartRandom.Text = "Random";
            this.btnSmartRandom.UseVisualStyleBackColor = false;
            this.btnSmartRandom.Click += new System.EventHandler(this.btnSmartRandom_Click);
            // 
            // btnSmartSystem
            // 
            this.btnSmartSystem.BackColor = System.Drawing.SystemColors.Window;
            this.btnSmartSystem.Location = new System.Drawing.Point(177, 32);
            this.btnSmartSystem.Name = "btnSmartSystem";
            this.btnSmartSystem.Size = new System.Drawing.Size(71, 25);
            this.btnSmartSystem.TabIndex = 20;
            this.btnSmartSystem.Text = "System";
            this.btnSmartSystem.UseVisualStyleBackColor = false;
            this.btnSmartSystem.Click += new System.EventHandler(this.btnSmartSystem_Click);
            // 
            // btnSmartIf
            // 
            this.btnSmartIf.BackColor = System.Drawing.SystemColors.Window;
            this.btnSmartIf.Location = new System.Drawing.Point(408, 32);
            this.btnSmartIf.Name = "btnSmartIf";
            this.btnSmartIf.Size = new System.Drawing.Size(71, 25);
            this.btnSmartIf.TabIndex = 50;
            this.btnSmartIf.Text = "If";
            this.btnSmartIf.UseVisualStyleBackColor = false;
            this.btnSmartIf.Click += new System.EventHandler(this.btnSmartIf_Click);
            // 
            // btnSmartExpand
            // 
            this.btnSmartExpand.BackColor = System.Drawing.SystemColors.Window;
            this.btnSmartExpand.Location = new System.Drawing.Point(331, 32);
            this.btnSmartExpand.Name = "btnSmartExpand";
            this.btnSmartExpand.Size = new System.Drawing.Size(71, 25);
            this.btnSmartExpand.TabIndex = 40;
            this.btnSmartExpand.Text = "Expand";
            this.btnSmartExpand.UseVisualStyleBackColor = false;
            this.btnSmartExpand.Click += new System.EventHandler(this.btnSmartExpand_Click);
            // 
            // linkHelp
            // 
            this.linkHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkHelp.AutoSize = true;
            this.linkHelp.Enabled = false;
            this.linkHelp.Location = new System.Drawing.Point(651, 59);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(31, 16);
            this.linkHelp.TabIndex = 80;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Link";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // lblSmart
            // 
            this.lblSmart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSmart.AutoSize = true;
            this.lblSmart.Location = new System.Drawing.Point(697, 59);
            this.lblSmart.Name = "lblSmart";
            this.lblSmart.Size = new System.Drawing.Size(90, 16);
            this.lblSmart.TabIndex = 3;
            this.lblSmart.Text = "Select above!";
            // 
            // btnAddToken
            // 
            this.btnAddToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToken.BackColor = System.Drawing.SystemColors.Window;
            this.btnAddToken.Enabled = false;
            this.btnAddToken.Location = new System.Drawing.Point(862, 31);
            this.btnAddToken.Name = "btnAddToken";
            this.btnAddToken.Size = new System.Drawing.Size(120, 25);
            this.btnAddToken.TabIndex = 70;
            this.btnAddToken.Text = "Add Manual";
            this.btnAddToken.UseVisualStyleBackColor = false;
            this.btnAddToken.Click += new System.EventHandler(this.btnAddToken_Click);
            // 
            // btnSmartColumn
            // 
            this.btnSmartColumn.BackColor = System.Drawing.SystemColors.Window;
            this.btnSmartColumn.Location = new System.Drawing.Point(100, 32);
            this.btnSmartColumn.Name = "btnSmartColumn";
            this.btnSmartColumn.Size = new System.Drawing.Size(71, 25);
            this.btnSmartColumn.TabIndex = 10;
            this.btnSmartColumn.Text = "Column";
            this.btnSmartColumn.UseVisualStyleBackColor = false;
            this.btnSmartColumn.Click += new System.EventHandler(this.btnSmartColumn_Click);
            // 
            // cmbTokenHelp
            // 
            this.cmbTokenHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTokenHelp.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTokenHelp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTokenHelp.FormattingEnabled = true;
            this.cmbTokenHelp.Location = new System.Drawing.Point(654, 32);
            this.cmbTokenHelp.Name = "cmbTokenHelp";
            this.cmbTokenHelp.Size = new System.Drawing.Size(202, 24);
            this.cmbTokenHelp.TabIndex = 60;
            this.cmbTokenHelp.SelectedIndexChanged += new System.EventHandler(this.cmbTokenHelp_SelectedIndexChanged);
            // 
            // gbTokenResult
            // 
            this.gbTokenResult.Controls.Add(this.lblError);
            this.gbTokenResult.Controls.Add(this.txtTokensOut);
            this.gbTokenResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTokenResult.Location = new System.Drawing.Point(0, 0);
            this.gbTokenResult.Name = "gbTokenResult";
            this.gbTokenResult.Size = new System.Drawing.Size(997, 205);
            this.gbTokenResult.TabIndex = 10;
            this.gbTokenResult.TabStop = false;
            this.gbTokenResult.Text = "Result";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.BackColor = System.Drawing.SystemColors.Window;
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblError.Location = new System.Drawing.Point(23, 177);
            this.lblError.Multiline = true;
            this.lblError.Name = "lblError";
            this.lblError.ReadOnly = true;
            this.lblError.Size = new System.Drawing.Size(959, 25);
            this.lblError.TabIndex = 4;
            // 
            // txtTokensOut
            // 
            this.txtTokensOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokensOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtTokensOut.Location = new System.Drawing.Point(23, 34);
            this.txtTokensOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtTokensOut.Multiline = true;
            this.txtTokensOut.Name = "txtTokensOut";
            this.txtTokensOut.ReadOnly = true;
            this.txtTokensOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTokensOut.Size = new System.Drawing.Size(959, 139);
            this.txtTokensOut.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // XRMTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "XRMTR";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(997, 638);
            this.TabIcon = ((System.Drawing.Image)(resources.GetObject("$this.TabIcon")));
            this.Load += new System.EventHandler(this.XRMTR_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbGetRecord.ResumeLayout(false);
            this.gbGetRecord.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbTokens.ResumeLayout(false);
            this.gbTokens.PerformLayout();
            this.gbSmart.ResumeLayout(false);
            this.gbSmart.PerformLayout();
            this.gbTokenResult.ResumeLayout(false);
            this.gbTokenResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.Label label1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox cmbTable;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost record;
        private Rappen.XTB.Helpers.Controls.XRMColumnText recordname;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtTokensIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTokensOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.GroupBox gbGetRecord;
        private System.Windows.Forms.GroupBox gbTokens;
        private System.Windows.Forms.GroupBox gbTokenResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbSmart;
        private System.Windows.Forms.ComboBox cmbTokenHelp;
        private System.Windows.Forms.Button btnAddToken;
        private System.Windows.Forms.Button btnSmartColumn;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Label lblSmart;
        private System.Windows.Forms.Button btnGetRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSmartExpand;
        private System.Windows.Forms.Button btnSmartIf;
        private System.Windows.Forms.Button btnSmartSystem;
        private System.Windows.Forms.ToolStripButton btnBackTool;
        private System.Windows.Forms.ToolStripLabel tslAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnSmartRandom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnOpenRecord;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.TextBox lblError;
        private System.Windows.Forms.Button button1;
    }
}
