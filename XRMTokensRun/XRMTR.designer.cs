
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbTokenHelp = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRecord = new System.Windows.Forms.ListView();
            this.btnReload = new System.Windows.Forms.Button();
            this.gbGetRecord = new System.Windows.Forms.GroupBox();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.tableselect = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.recordname = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.record = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbSmart = new System.Windows.Forms.GroupBox();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.lblSmart = new System.Windows.Forms.Label();
            this.btnAddToken = new System.Windows.Forms.Button();
            this.btnSmartToken = new System.Windows.Forms.Button();
            this.cmbTokenHelp = new System.Windows.Forms.ComboBox();
            this.gbTokens = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTokensIn = new System.Windows.Forms.TextBox();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.gbTokenResult = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTokensOut = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbTokenHelp.SuspendLayout();
            this.gbGetRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbSmart.SuspendLayout();
            this.gbTokens.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.gbTokenResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1183, 31);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(143, 28);
            this.toolStripButton1.Text = "Execute XRM Tokens";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 28);
            this.toolStripLabel1.Text = "XRM Tokens";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 31);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbTokenHelp);
            this.splitContainer1.Panel1.Controls.Add(this.gbGetRecord);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1183, 766);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 11;
            this.splitContainer1.TabIndex = 5;
            // 
            // gbTokenHelp
            // 
            this.gbTokenHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTokenHelp.Controls.Add(this.label5);
            this.gbTokenHelp.Controls.Add(this.lstRecord);
            this.gbTokenHelp.Controls.Add(this.btnReload);
            this.gbTokenHelp.Location = new System.Drawing.Point(12, 195);
            this.gbTokenHelp.Name = "gbTokenHelp";
            this.gbTokenHelp.Size = new System.Drawing.Size(385, 506);
            this.gbTokenHelp.TabIndex = 10;
            this.gbTokenHelp.TabStop = false;
            this.gbTokenHelp.Text = "Tokens Help";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Columns";
            // 
            // lstRecord
            // 
            this.lstRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRecord.HideSelection = false;
            this.lstRecord.Location = new System.Drawing.Point(133, 32);
            this.lstRecord.Margin = new System.Windows.Forms.Padding(4);
            this.lstRecord.Name = "lstRecord";
            this.lstRecord.Size = new System.Drawing.Size(235, 424);
            this.lstRecord.TabIndex = 8;
            this.lstRecord.UseCompatibleStateImageBehavior = false;
            this.lstRecord.View = System.Windows.Forms.View.List;
            this.lstRecord.DoubleClick += new System.EventHandler(this.lstRecord_DoubleClick);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReload.BackColor = System.Drawing.SystemColors.Window;
            this.btnReload.Location = new System.Drawing.Point(133, 464);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(195, 35);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload with all columns";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // gbGetRecord
            // 
            this.gbGetRecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGetRecord.Controls.Add(this.btnGetRecord);
            this.gbGetRecord.Controls.Add(this.tableselect);
            this.gbGetRecord.Controls.Add(this.label1);
            this.gbGetRecord.Controls.Add(this.label2);
            this.gbGetRecord.Controls.Add(this.recordname);
            this.gbGetRecord.Location = new System.Drawing.Point(12, 19);
            this.gbGetRecord.Name = "gbGetRecord";
            this.gbGetRecord.Size = new System.Drawing.Size(385, 158);
            this.gbGetRecord.TabIndex = 9;
            this.gbGetRecord.TabStop = false;
            this.gbGetRecord.Text = "Get Record";
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.BackColor = System.Drawing.SystemColors.Window;
            this.btnGetRecord.Location = new System.Drawing.Point(133, 68);
            this.btnGetRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(195, 35);
            this.btnGetRecord.TabIndex = 4;
            this.btnGetRecord.Text = "Select Record";
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.btnGetRecurd_Click);
            // 
            // tableselect
            // 
            this.tableselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableselect.FormattingEnabled = true;
            this.tableselect.Location = new System.Drawing.Point(133, 30);
            this.tableselect.Margin = new System.Windows.Forms.Padding(4);
            this.tableselect.Name = "tableselect";
            this.tableselect.Size = new System.Drawing.Size(235, 24);
            this.tableselect.TabIndex = 0;
            this.tableselect.SelectedIndexChanged += new System.EventHandler(this.tableselect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Record";
            // 
            // recordname
            // 
            this.recordname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordname.Column = null;
            this.recordname.DisplayFormat = "";
            this.recordname.Location = new System.Drawing.Point(133, 118);
            this.recordname.Margin = new System.Windows.Forms.Padding(4);
            this.recordname.Name = "recordname";
            this.recordname.RecordHost = this.record;
            this.recordname.Size = new System.Drawing.Size(235, 22);
            this.recordname.TabIndex = 3;
            // 
            // record
            // 
            this.record.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.record.LogicalName = null;
            this.record.Record = null;
            this.record.Service = null;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(161, 726);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(148, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "XRM Tokens document";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbSmart);
            this.splitContainer2.Panel1.Controls.Add(this.gbTokens);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbOption);
            this.splitContainer2.Panel2.Controls.Add(this.gbTokenResult);
            this.splitContainer2.Size = new System.Drawing.Size(772, 766);
            this.splitContainer2.SplitterDistance = 296;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // gbSmart
            // 
            this.gbSmart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSmart.Controls.Add(this.linkHelp);
            this.gbSmart.Controls.Add(this.lblSmart);
            this.gbSmart.Controls.Add(this.btnAddToken);
            this.gbSmart.Controls.Add(this.btnSmartToken);
            this.gbSmart.Controls.Add(this.cmbTokenHelp);
            this.gbSmart.Location = new System.Drawing.Point(3, 184);
            this.gbSmart.Name = "gbSmart";
            this.gbSmart.Size = new System.Drawing.Size(756, 105);
            this.gbSmart.TabIndex = 6;
            this.gbSmart.TabStop = false;
            this.gbSmart.Text = "Smart Help";
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.Enabled = false;
            this.linkHelp.Location = new System.Drawing.Point(23, 63);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(32, 16);
            this.linkHelp.TabIndex = 4;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Link";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // lblSmart
            // 
            this.lblSmart.AutoSize = true;
            this.lblSmart.Location = new System.Drawing.Point(69, 63);
            this.lblSmart.Name = "lblSmart";
            this.lblSmart.Size = new System.Drawing.Size(91, 16);
            this.lblSmart.TabIndex = 3;
            this.lblSmart.Text = "Select above!";
            // 
            // btnSmart
            // 
            this.btnAddToken.Enabled = false;
            this.btnAddToken.Location = new System.Drawing.Point(247, 32);
            this.btnAddToken.Name = "btnAddToken";
            this.btnAddToken.Size = new System.Drawing.Size(120, 23);
            this.btnAddToken.TabIndex = 2;
            this.btnAddToken.Text = "Add Token";
            this.btnAddToken.UseVisualStyleBackColor = true;
            this.btnAddToken.Click += new System.EventHandler(this.btnAddToken_Click);
            // 
            // btnSmart
            // 
            this.btnSmartToken.Enabled = false;
            this.btnSmartToken.Location = new System.Drawing.Point(380, 32);
            this.btnSmartToken.Name = "btnSmartToken";
            this.btnSmartToken.Size = new System.Drawing.Size(120, 23);
            this.btnSmartToken.TabIndex = 2;
            this.btnSmartToken.Text = "Smart Token";
            this.btnSmartToken.UseVisualStyleBackColor = true;
            this.btnSmartToken.Click += new System.EventHandler(this.btnSmartToken_Click);
            // 
            // cmbTokenHelp
            // 
            this.cmbTokenHelp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTokenHelp.FormattingEnabled = true;
            this.cmbTokenHelp.Location = new System.Drawing.Point(23, 32);
            this.cmbTokenHelp.Name = "cmbTokenHelp";
            this.cmbTokenHelp.Size = new System.Drawing.Size(202, 24);
            this.cmbTokenHelp.TabIndex = 1;
            this.cmbTokenHelp.SelectedIndexChanged += new System.EventHandler(this.cmbTokenHelp_SelectedIndexChanged);
            // 
            // gbTokens
            // 
            this.gbTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTokens.Controls.Add(this.label3);
            this.gbTokens.Controls.Add(this.txtTokensIn);
            this.gbTokens.Location = new System.Drawing.Point(3, 19);
            this.gbTokens.Name = "gbTokens";
            this.gbTokens.Size = new System.Drawing.Size(756, 159);
            this.gbTokens.TabIndex = 5;
            this.gbTokens.TabStop = false;
            this.gbTokens.Text = "XRM Tokens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Input - all the text and Tokens";
            // 
            // txtTokensIn
            // 
            this.txtTokensIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokensIn.Location = new System.Drawing.Point(23, 68);
            this.txtTokensIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTokensIn.Multiline = true;
            this.txtTokensIn.Name = "txtTokensIn";
            this.txtTokensIn.Size = new System.Drawing.Size(718, 76);
            this.txtTokensIn.TabIndex = 1;
            this.txtTokensIn.TextChanged += new System.EventHandler(this.txtTokensIn_TextChanged);
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.chkAuto);
            this.gbOption.Location = new System.Drawing.Point(3, 3);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(756, 153);
            this.gbOption.TabIndex = 5;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Execute Option";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(23, 32);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(137, 20);
            this.chkAuto.TabIndex = 0;
            this.chkAuto.Text = "Execute Automatic";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // gbTokenResult
            // 
            this.gbTokenResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTokenResult.Controls.Add(this.lblError);
            this.gbTokenResult.Controls.Add(this.label4);
            this.gbTokenResult.Controls.Add(this.txtTokensOut);
            this.gbTokenResult.Location = new System.Drawing.Point(3, 162);
            this.gbTokenResult.Name = "gbTokenResult";
            this.gbTokenResult.Size = new System.Drawing.Size(756, 235);
            this.gbTokenResult.TabIndex = 4;
            this.gbTokenResult.TabStop = false;
            this.gbTokenResult.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "XRM Tokens - result";
            // 
            // txtTokensOut
            // 
            this.txtTokensOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokensOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtTokensOut.Location = new System.Drawing.Point(23, 68);
            this.txtTokensOut.Margin = new System.Windows.Forms.Padding(4);
            this.txtTokensOut.Multiline = true;
            this.txtTokensOut.Name = "txtTokensOut";
            this.txtTokensOut.ReadOnly = true;
            this.txtTokensOut.Size = new System.Drawing.Size(718, 135);
            this.txtTokensOut.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(23, 214);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(37, 16);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Error";
            // 
            // XRMTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "XRMTR";
            this.Size = new System.Drawing.Size(1183, 797);
            this.Load += new System.EventHandler(this.XRMTR_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbTokenHelp.ResumeLayout(false);
            this.gbTokenHelp.PerformLayout();
            this.gbGetRecord.ResumeLayout(false);
            this.gbGetRecord.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbSmart.ResumeLayout(false);
            this.gbSmart.PerformLayout();
            this.gbTokens.ResumeLayout(false);
            this.gbTokens.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.gbTokenResult.ResumeLayout(false);
            this.gbTokenResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox tableselect;
        private System.Windows.Forms.Button btnGetRecord;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost record;
        private Rappen.XTB.Helpers.Controls.XRMColumnText recordname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtTokensIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTokensOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ListView lstRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTokenHelp;
        private System.Windows.Forms.GroupBox gbGetRecord;
        private System.Windows.Forms.GroupBox gbTokens;
        private System.Windows.Forms.GroupBox gbTokenResult;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbSmart;
        private System.Windows.Forms.ComboBox cmbTokenHelp;
        private System.Windows.Forms.Button btnAddToken;
        private System.Windows.Forms.Button btnSmartToken;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Label lblSmart;
        private System.Windows.Forms.Label lblError;
    }
}
