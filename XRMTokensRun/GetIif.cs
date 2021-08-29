using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XTB.Helpers.Extensions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetIif : Form
    {
        private XRMTR xrmtr;

        public GetIif()
        {
            InitializeComponent();
        }

        public static string ShowDialog(XRMTR owner)
        {
            var dialog = new GetIif();
            dialog.xrmtr = owner;
            if (dialog.ShowDialog((Control)owner) == DialogResult.OK)
            {
                var result = "<iif|" +
                    dialog.txtValue1.Text + "|" +
                    dialog.cmbOperator.Text + "|" +
                    dialog.txtValue2.Text + "|" +
                    dialog.txtTrue.Text + "|" +
                    dialog.txtFalse.Text + ">";
                return result;
            }
            return null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#ifelse");
        }

        private void btnValue1_Click(object sender, System.EventArgs e)
        {
            if (GetAttribute.ShowDialog(xrmtr) is string val && !string.IsNullOrEmpty(val))
            {
                txtValue1.Text = val;
            }
        }
    }
}