using Rappen.XRM.Helpers.Extensions;
using System.Diagnostics;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetRandom : Form
    {
        private XRMTR xrmtr;

        public GetRandom()
        {
            InitializeComponent();
        }

        public static string ShowDialog(XRMTR owner)
        {
            var dialog = new GetRandom();
            dialog.xrmtr = owner;
            if (dialog.ShowDialog((Control)owner) == DialogResult.OK)
            {
                return dialog.GetResult();
            }
            return null;
        }

        private string GetResult()
        {
            var result = "<random|" +
                 cmbOperator.Text;
            if (!string.IsNullOrEmpty(txtParam1.Text))
            {
                result += "|" + txtParam1.Text;
            }
            if (!string.IsNullOrEmpty(txtParam2.Text))
            {
                result += "|" + txtParam2.Text;
            }
            result += ">";
            return result;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#random");
        }

        private void cmbOperator_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (cmbOperator.Text.ToLowerInvariant())
            {
                case "text":
                    lblParam1.Text = "Length *";
                    lblParam2.Text = "Characters";
                    break;

                case "number":
                    lblParam1.Text = "First number";
                    lblParam2.Text = "Last number";
                    break;

                case "date":
                    lblParam1.Text = "First date";
                    lblParam2.Text = "Last date";
                    break;

                default:
                    lblParam1.Text = "";
                    lblParam2.Text = "";
                    break;
            }
            txtParam1.Enabled = cmbOperator.Text.ToLowerInvariant() != "guid";
            txtParam2.Enabled = cmbOperator.Text.ToLowerInvariant() != "guid";
            ShowResult();
        }

        private void ShowResult(object sender = null, System.EventArgs e = null)
        {
            txtResult.Text = GetResult();
        }
    }
}