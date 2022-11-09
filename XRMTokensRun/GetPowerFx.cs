using Rappen.XRM.Helpers.Extensions;
using System.Diagnostics;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetPowerFx : Form
    {
        private XRMTR xrmtr;

        public GetPowerFx()
        {
            InitializeComponent();
        }

        public static string ShowDialog(XRMTR owner)
        {
            var dialog = new GetPowerFx();
            dialog.xrmtr = owner;
            if (dialog.ShowDialog((Control)owner) == DialogResult.OK)
            {
                return dialog.GetResult();
            }
            return null;
        }

        private string GetResult()
        {
            return "<PowerFx|" + txtFormat.Text + ">";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#powerfx");
        }

        private void btnCol_Click(object sender, System.EventArgs e)
        {
            if (GetAttribute.ShowDialog(xrmtr, xrmtr.recordmeta) is string val && !string.IsNullOrEmpty(val))
            {
                XRMTR.InsertValue(txtFormat, val);
            }
            ShowResult();
        }

        private void ShowResult(object sender = null, System.EventArgs e = null)
        {
            txtResult.Text = GetResult();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://learn.microsoft.com/en-us/power-platform/power-fx/formula-reference?WT.mc_id=BA-MVP-5002475");
        }
    }
}