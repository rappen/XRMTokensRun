
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstRecord = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtTokensIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtTokensOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetRecord = new System.Windows.Forms.Button();
            this.recordname = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.record = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.tableselect = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1723, 44);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.IsLink = true;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(126, 38);
            this.toolStripLabel1.Text = "XRM Tokens";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstRecord);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnReload);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.recordname);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tableselect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1723, 865);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 5;
            // 
            // lstRecord
            // 
            this.lstRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRecord.HideSelection = false;
            this.lstRecord.Location = new System.Drawing.Point(194, 282);
            this.lstRecord.Name = "lstRecord";
            this.lstRecord.Size = new System.Drawing.Size(360, 457);
            this.lstRecord.TabIndex = 8;
            this.lstRecord.UseCompatibleStateImageBehavior = false;
            this.lstRecord.View = System.Windows.Forms.View.List;
            this.lstRecord.DoubleClick += new System.EventHandler(this.lstRecord_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Columns";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Window;
            this.btnReload.Location = new System.Drawing.Point(194, 201);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(231, 49);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Reload with all columns";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(189, 775);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "XRM Tokens document";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Record";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtTokensIn);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.btnResult);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtTokensOut);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Size = new System.Drawing.Size(1131, 865);
            this.splitContainer2.SplitterDistance = 343;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtTokensIn
            // 
            this.txtTokensIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokensIn.Location = new System.Drawing.Point(33, 94);
            this.txtTokensIn.Multiline = true;
            this.txtTokensIn.Name = "txtTokensIn";
            this.txtTokensIn.Size = new System.Drawing.Size(1062, 173);
            this.txtTokensIn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "XRM Tokens - input";
            // 
            // btnResult
            // 
            this.btnResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResult.BackColor = System.Drawing.SystemColors.Window;
            this.btnResult.Location = new System.Drawing.Point(33, 281);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(231, 47);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result XRM Tokens";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtTokensOut
            // 
            this.txtTokensOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTokensOut.BackColor = System.Drawing.SystemColors.Window;
            this.txtTokensOut.Location = new System.Drawing.Point(33, 78);
            this.txtTokensOut.Multiline = true;
            this.txtTokensOut.Name = "txtTokensOut";
            this.txtTokensOut.ReadOnly = true;
            this.txtTokensOut.Size = new System.Drawing.Size(1062, 408);
            this.txtTokensOut.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "XRM Tokens - result";
            // 
            // btnGetRecord
            // 
            this.btnGetRecord.BackColor = System.Drawing.SystemColors.Window;
            this.btnGetRecord.Location = new System.Drawing.Point(194, 130);
            this.btnGetRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetRecord.Name = "btnGetRecord";
            this.btnGetRecord.Size = new System.Drawing.Size(231, 47);
            this.btnGetRecord.TabIndex = 4;
            this.btnGetRecord.Text = "Select Record";
            this.btnGetRecord.UseVisualStyleBackColor = false;
            this.btnGetRecord.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordname
            // 
            this.recordname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordname.Column = null;
            this.recordname.DisplayFormat = "";
            this.recordname.Location = new System.Drawing.Point(194, 166);
            this.recordname.Name = "recordname";
            this.recordname.RecordHost = this.record;
            this.recordname.Size = new System.Drawing.Size(360, 29);
            this.recordname.TabIndex = 3;
            // 
            // record
            // 
            this.record.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.record.LogicalName = null;
            this.record.Record = null;
            this.record.Service = null;
            // 
            // tableselect
            // 
            this.tableselect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableselect.FormattingEnabled = true;
            this.tableselect.Location = new System.Drawing.Point(194, 49);
            this.tableselect.Name = "tableselect";
            this.tableselect.Size = new System.Drawing.Size(360, 32);
            this.tableselect.TabIndex = 0;
            this.tableselect.SelectedIndexChanged += new System.EventHandler(this.tableselect_SelectedIndexChanged);
            // 
            // XRMTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnGetRecord);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "XRMTR";
            this.Size = new System.Drawing.Size(1723, 909);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ListView lstRecord;
        private System.Windows.Forms.Label label5;
    }
}
