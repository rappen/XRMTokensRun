using Rappen.XRM.Helpers.Extensions;
using System.Diagnostics;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetSystem : Form
    {
        private XRMTR xrmtr;

        public GetSystem()
        {
            InitializeComponent();
        }

        public static string ShowDialog(XRMTR owner)
        {
            var dialog = new GetSystem();
            dialog.xrmtr = owner;
            if (dialog.ShowDialog((Control)owner) == DialogResult.OK)
            {
                return dialog.GetResult();
            }
            return null;
        }

        private string GetResult()
        {
            var result = "<system|" +
                 cmbOperator.Text;
            if (!string.IsNullOrEmpty(txtFormat.Text))
            {
                result += "|" + txtFormat.Text;
            }
            result += ">";
            return result;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#system");
        }

        private void btnCol_Click(object sender, System.EventArgs e)
        {
            if (GetAttribute.ShowDialog(xrmtr, xrmtr.Service?.GetEntity("systemuser")) is string val && !string.IsNullOrEmpty(val))
            {
                txtFormat.Text = val;
            }
            ShowResult();
        }

        private void cmbOperator_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btnCol.Visible = cmbOperator.Text == "user";
            ShowResult();
        }

        private void ShowResult(object sender = null, System.EventArgs e = null)
        {
            txtResult.Text = GetResult();
        }
    }
}