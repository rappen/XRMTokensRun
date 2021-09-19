
namespace XRMTokensRun
{
    partial class GetIif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetIif));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.btnValue1 = new System.Windows.Forms.Button();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnValue2 = new System.Windows.Forms.Button();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.txtTrue = new System.Windows.Forms.TextBox();
            this.btnFalse = new System.Windows.Forms.Button();
            this.txtFalse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(138, 340);
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
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value 1";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(272, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Value 2";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(138, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 16);
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
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "IF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Operator";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(138, 88);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(346, 22);
            this.txtValue1.TabIndex = 27;
            this.txtValue1.TextChanged += new System.EventHandler(this.ShowResult);
            // 
            // btnValue1
            // 
            this.btnValue1.Location = new System.Drawing.Point(490, 88);
            this.btnValue1.Name = "btnValue1";
            this.btnValue1.Size = new System.Drawing.Size(49, 23);
            this.btnValue1.TabIndex = 28;
            this.btnValue1.Text = "Col";
            this.btnValue1.UseVisualStyleBackColor = true;
            this.btnValue1.Click += new System.EventHandler(this.btnValue1_Click);
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "eq",
            "neq",
            "lt",
            "gt",
            "le",
            "ge"});
            this.cmbOperator.Location = new System.Drawing.Point(138, 117);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(346, 24);
            this.cmbOperator.TabIndex = 29;
            this.cmbOperator.SelectedIndexChanged += new System.EventHandler(this.ShowResult);
            // 
            // btnValue2
            // 
            this.btnValue2.Location = new System.Drawing.Point(490, 147);
            this.btnValue2.Name = "btnValue2";
            this.btnValue2.Size = new System.Drawing.Size(49, 23);
            this.btnValue2.TabIndex = 31;
            this.btnValue2.Text = "Col";
            this.btnValue2.UseVisualStyleBackColor = true;
            this.btnValue2.Click += new System.EventHandler(this.btnValue1_Click);
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(138, 147);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(346, 22);
            this.txtValue2.TabIndex = 30;
            this.txtValue2.TextChanged += new System.EventHandler(this.ShowResult);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "True-result";
            // 
            // btnTrue
            // 
            this.btnTrue.Location = new System.Drawing.Point(490, 193);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(49, 23);
            this.btnTrue.TabIndex = 34;
            this.btnTrue.Text = "Col";
            this.btnTrue.UseVisualStyleBackColor = true;
            this.btnTrue.Click += new System.EventHandler(this.btnValue1_Click);
            // 
            // txtTrue
            // 
            this.txtTrue.Location = new System.Drawing.Point(138, 193);
            this.txtTrue.Name = "txtTrue";
            this.txtTrue.Size = new System.Drawing.Size(346, 22);
            this.txtTrue.TabIndex = 33;
            this.txtTrue.TextChanged += new System.EventHandler(this.ShowResult);
            // 
            // btnFalse
            // 
            this.btnFalse.Location = new System.Drawing.Point(490, 221);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(49, 23);
            this.btnFalse.TabIndex = 36;
            this.btnFalse.Text = "Col";
            this.btnFalse.UseVisualStyleBackColor = true;
            this.btnFalse.Click += new System.EventHandler(this.btnValue1_Click);
            // 
            // txtFalse
            // 
            this.txtFalse.Location = new System.Drawing.Point(138, 221);
            this.txtFalse.Name = "txtFalse";
            this.txtFalse.Size = new System.Drawing.Size(346, 22);
            this.txtFalse.TabIndex = 35;
            this.txtFalse.TextChanged += new System.EventHandler(this.ShowResult);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "False-result";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResult.Location = new System.Drawing.Point(138, 277);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(401, 47);
            this.txtResult.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Result";
            // 
            // GetIif
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(575, 390);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.txtFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.txtTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValue2);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.btnValue1);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetIif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get IIF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.Button btnValue1;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button btnValue2;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.TextBox txtTrue;
        private System.Windows.Forms.Button btnFalse;
        private System.Windows.Forms.TextBox txtFalse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label11;
    }
}