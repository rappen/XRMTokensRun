
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
            this.button1 = new System.Windows.Forms.Button();
            this.xrmAttributeComboBox1 = new Rappen.XTB.Helpers.Controls.XRMAttributeComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(339, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // xrmAttributeComboBox1
            // 
            this.xrmAttributeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmAttributeComboBox1.FormattingEnabled = true;
            this.xrmAttributeComboBox1.Location = new System.Drawing.Point(183, 77);
            this.xrmAttributeComboBox1.Name = "xrmAttributeComboBox1";
            this.xrmAttributeComboBox1.Size = new System.Drawing.Size(562, 32);
            this.xrmAttributeComboBox1.TabIndex = 0;
            // 
            // GetAttribute
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xrmAttributeComboBox1);
            this.Name = "GetAttribute";
            this.Text = "GetAttribute";
            this.Load += new System.EventHandler(this.GetAttribute_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal Rappen.XTB.Helpers.Controls.XRMAttributeComboBox xrmAttributeComboBox1;
        private System.Windows.Forms.Button button1;
    }
}