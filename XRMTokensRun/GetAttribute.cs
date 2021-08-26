using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XTB.Helpers.Extensions;
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

        public static AttributeMetadata ShowDialog(XRMTR owner, EntityMetadata entity, IEnumerable<AttributeMetadata> attributes = null)
        {
            var dialog = new GetAttribute();
            dialog.xrmtr = owner;
            dialog.txtTable.Text = entity.DisplayName.UserLocalizedLabel.Label;
            dialog.xrmColumn.DataSource = attributes == null ?
                entity.Attributes.Where(a => a.IsLogical == false) :
                attributes;
            if (dialog.ShowDialog(owner) == DialogResult.OK && dialog.xrmColumn.SelectedAttribute is AttributeMetadata attr)
            {
                return attr;
            }
            return null;
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
        }

        private void xrmParentEntity_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (xrmParentEntity.SelectedEntity is EntityMetadata ent)
            {
                var parent = xrmtr.Service.GetEntity(ent.LogicalName);
                xrmParentAttr.DataSource = parent.Attributes
                    .Where(a => a.IsLogical == false);
                if (xrmParentAttr.DataSource is IEnumerable<AttributeMetadata> atts)
                {
                    if (atts.FirstOrDefault(a => a.IsPrimaryName == true) is AttributeMetadata pri)
                    {
                        xrmParentAttr.SelectedIndex = pri;
                    }
                }
            }
            else
            {
                xrmParentAttr.DataSource = null;
            }
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
        }
    }
}