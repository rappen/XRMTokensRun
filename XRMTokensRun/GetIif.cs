using System.Diagnostics;
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
                return dialog.GetResult();
            }
            return null;
        }

        private string GetResult()
        {
            return "<iif|" +
                txtValue1.Text + "|" +
                cmbOperator.Text + "|" +
                txtValue2.Text + "|" +
                txtTrue.Text + "|" +
                txtFalse.Text + ">";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#ifelse");
        }

        private void btnValue1_Click(object sender, System.EventArgs e)
        {
            var value =
                sender == btnValue1 ? txtValue1 :
                sender == btnValue2 ? txtValue2 :
                sender == btnTrue ? txtTrue :
                sender == btnFalse ? txtFalse : null;
            if (value == null)
            {
                return;
            }
            if (GetAttribute.ShowDialog(xrmtr) is string val && !string.IsNullOrEmpty(val))
            {
                value.Text = val;
            }
            ShowResult();
        }

        private void ShowResult(object sender = null, System.EventArgs e = null)
        {
            txtResult.Text = GetResult();
        }
    }
}