
namespace XRMTokensRun
{
    partial class GetAttribute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetAttribute));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkValue = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkParent = new System.Windows.Forms.CheckBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xrmParentEntity = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.xrmParentAttr = new Rappen.XTB.Helpers.Controls.XRMAttributeComboBox();
            this.xrmColumn = new Rappen.XTB.Helpers.Controls.XRMAttributeComboBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.txtFormValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRecurdUrl = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(138, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Column";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(272, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(138, 87);
            this.txtTable.Margin = new System.Windows.Forms.Padding(4);
            this.txtTable.Name = "txtTable";
            this.txtTable.ReadOnly = true;
            this.txtTable.Size = new System.Drawing.Size(401, 22);
            this.txtTable.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parent Column";
            // 
            // chkValue
            // 
            this.chkValue.AutoSize = true;
            this.chkValue.Location = new System.Drawing.Point(138, 220);
            this.chkValue.Margin = new System.Windows.Forms.Padding(4);
            this.chkValue.Name = "chkValue";
            this.chkValue.Size = new System.Drawing.Size(15, 14);
            this.chkValue.TabIndex = 17;
            this.chkValue.UseVisualStyleBackColor = true;
            this.chkValue.CheckedChanged += new System.EventHandler(this.ShowResult);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Value";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(138, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 16);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Documentation Column";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 22);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Column information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Parent Table";
            // 
            // chkParent
            // 
            this.chkParent.AutoSize = true;
            this.chkParent.Location = new System.Drawing.Point(138, 156);
            this.chkParent.Name = "chkParent";
            this.chkParent.Size = new System.Drawing.Size(15, 14);
            this.chkParent.TabIndex = 27;
            this.chkParent.UseVisualStyleBackColor = true;
            this.chkParent.CheckedChanged += new System.EventHandler(this.chkParent_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResult.Location = new System.Drawing.Point(138, 351);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(401, 22);
            this.txtResult.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Result";
            // 
            // xrmParentEntity
            // 
            this.xrmParentEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmParentEntity.Enabled = false;
            this.xrmParentEntity.FormattingEnabled = true;
            this.xrmParentEntity.Location = new System.Drawing.Point(164, 151);
            this.xrmParentEntity.Margin = new System.Windows.Forms.Padding(4);
            this.xrmParentEntity.Name = "xrmParentEntity";
            this.xrmParentEntity.Size = new System.Drawing.Size(375, 24);
            this.xrmParentEntity.TabIndex = 25;
            this.xrmParentEntity.SelectedIndexChanged += new System.EventHandler(this.xrmParentEntity_SelectedIndexChanged);
            // 
            // xrmParentAttr
            // 
            this.xrmParentAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmParentAttr.Enabled = false;
            this.xrmParentAttr.FormattingEnabled = true;
            this.xrmParentAttr.Location = new System.Drawing.Point(164, 181);
            this.xrmParentAttr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xrmParentAttr.Name = "xrmParentAttr";
            this.xrmParentAttr.Size = new System.Drawing.Size(375, 24);
            this.xrmParentAttr.TabIndex = 10;
            this.xrmParentAttr.SelectedIndexChanged += new System.EventHandler(this.ShowResult);
            // 
            // xrmColumn
            // 
            this.xrmColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmColumn.FormattingEnabled = true;
            this.xrmColumn.Location = new System.Drawing.Point(138, 121);
            this.xrmColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xrmColumn.Name = "xrmColumn";
            this.xrmColumn.Size = new System.Drawing.Size(401, 24);
            this.xrmColumn.TabIndex = 0;
            this.xrmColumn.SelectedIndexChanged += new System.EventHandler(this.xrmColumn_SelectedIndexChanged);
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "",
            "Left",
            "Right",
            "Upper",
            "Lower",
            "Trim",
            "TrimStart",
            "TrimEnd",
            "SubStr",
            "Pad",
            "Replace",
            "Math"});
            this.cmbFormat.Location = new System.Drawing.Point(138, 276);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(401, 24);
            this.cmbFormat.TabIndex = 37;
            this.cmbFormat.SelectedIndexChanged += new System.EventHandler(this.cmbFormat_SelectedIndexChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(33, 279);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(70, 16);
            this.linkLabel2.TabIndex = 38;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Formatting";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // txtFormValue
            // 
            this.txtFormValue.Location = new System.Drawing.Point(138, 306);
            this.txtFormValue.Name = "txtFormValue";
            this.txtFormValue.Size = new System.Drawing.Size(401, 22);
            this.txtFormValue.TabIndex = 39;
            this.txtFormValue.TextChanged += new System.EventHandler(this.ShowResult);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Format Values";
            // 
            // chkRecurdUrl
            // 
            this.chkRecurdUrl.AutoSize = true;
            this.chkRecurdUrl.Location = new System.Drawing.Point(138, 247);
            this.chkRecurdUrl.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecurdUrl.Name = "chkRecurdUrl";
            this.chkRecurdUrl.Size = new System.Drawing.Size(15, 14);
            this.chkRecurdUrl.TabIndex = 42;
            this.chkRecurdUrl.UseVisualStyleBackColor = true;
            this.chkRecurdUrl.CheckedChanged += new System.EventHandler(this.ShowResult);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Record URL";
            // 
            // GetAttribute
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 437);
            this.Controls.Add(this.chkRecurdUrl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFormValue);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkParent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xrmParentEntity);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.xrmParentAttr);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xrmColumn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetAttribute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get Column";
            this.Load += new System.EventHandler(this.ShowResult);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTable;
        private Rappen.XTB.Helpers.Controls.XRMAttributeComboBox xrmColumn;
        private System.Windows.Forms.Label label4;
        private Rappen.XTB.Helpers.Controls.XRMAttributeComboBox xrmParentAttr;
        private System.Windows.Forms.CheckBox chkValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmParentEntity;
        private System.Windows.Forms.CheckBox chkParent;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox txtFormValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkRecurdUrl;
        private System.Windows.Forms.Label label8;
    }
}