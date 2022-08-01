using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XRM.Helpers.Extensions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetAttribute : Form
    {
        private XRMTR xrmtr;

        public GetAttribute()
        {
            InitializeComponent();
        }

        public static string ShowDialog(XRMTR owner, EntityMetadata entity = null, IEnumerable<AttributeMetadata> attributes = null)
        {
            var dialog = new GetAttribute();
            dialog.xrmtr = owner;
            if (entity == null)
            {
                entity = dialog.xrmtr.recordmeta;
            }
            dialog.txtTable.Text = entity.DisplayName.UserLocalizedLabel.Label;
            dialog.xrmColumn.DataSource = attributes ?? entity.Attributes
                .Where(a => !string.IsNullOrEmpty(a.DisplayName?.UserLocalizedLabel?.Label));
            dialog.xrmColumn.SetSelectedPrimaryName();
            if (dialog.ShowDialog((Control)owner) == DialogResult.OK)
            {
                return dialog.GetResult();
            }
            return null;
        }

        private string GetResult()
        {
            var result = "{" + xrmColumn.SelectedAttribute?.LogicalName;
            if (chkParent.Checked)
            {
                result += "." + xrmParentAttr.SelectedAttribute?.LogicalName;
            }
            if (chkValue.Checked)
            {
                result += "|<value>";
            }
            if (!string.IsNullOrEmpty(cmbFormat.Text))
            {
                if (!chkValue.Checked)
                {
                    result += "|";
                }
                result += "<" + cmbFormat.Text;
                if (!string.IsNullOrEmpty(txtFormValue.Text))
                {
                    result += "|" + txtFormValue.Text;
                }
                result += ">";
            }
            result += "}";
            return result;
        }

        private void xrmColumn_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (xrmColumn.SelectedAttribute is LookupAttributeMetadata look)
            {
                chkParent.Enabled = true;
                var parets = look.Targets;
                xrmParentEntity.DataSource = xrmtr.entities.Where(ent => parets.Contains(ent.LogicalName));
                chkParent_CheckedChanged(null, null);
            }
            else
            {
                chkParent.Enabled = false;
                chkParent.Checked = false;
                xrmParentEntity.DataSource = null;
            }
            ShowResult();
        }

        private void xrmParentEntity_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (xrmParentEntity.SelectedEntity is EntityMetadata ent)
            {
                var parent = xrmtr.Service.GetEntity(ent.LogicalName);
                xrmParentAttr.DataSource = parent.Attributes
                   .Where(a => !string.IsNullOrEmpty(a.DisplayName?.UserLocalizedLabel?.Label));
                xrmParentAttr.SetSelectedPrimaryName();
            }
            else
            {
                xrmParentAttr.DataSource = null;
            }
            ShowResult();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#attribute");
        }

        private void chkParent_CheckedChanged(object sender, System.EventArgs e)
        {
            xrmParentEntity.Enabled = chkParent.Checked;
            xrmParentAttr.Enabled = chkParent.Checked;
            if (chkParent.Checked)
            {
                if (xrmParentEntity.SelectedEntity == null && xrmParentEntity.Items.Count == 1)
                {
                    xrmParentEntity.SelectedIndex = 0;
                }
            }
            else
            {
                xrmParentEntity.SelectedItem = null;
                xrmParentAttr.SelectedItem = null;
            }
            ShowResult();
        }

        private void ShowResult(object sender = null, System.EventArgs e = null)
        {
            txtResult.Text = GetResult();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#formatting");
        }

        private void cmbFormat_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            txtFormValue.Enabled = !string.IsNullOrEmpty(cmbFormat.Text);
            txtFormValue.Text = "";
            ShowResult();
        }
    }
}