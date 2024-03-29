﻿using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XRM.Helpers.Extensions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetChildEntityAttribute : Form
    {
        private XRMTR xrmtr;
        private EntityMetadata sourceentity;

        public GetChildEntityAttribute()
        {
            InitializeComponent();
        }

        public static string ShowDialog(XRMTR owner, EntityMetadata entity = null, IEnumerable<AttributeMetadata> attributes = null)
        {
            var dialog = new GetChildEntityAttribute();
            dialog.xrmtr = owner;
            dialog.sourceentity = entity ?? dialog.xrmtr.recordmeta;
            dialog.txtTable.Text = dialog.sourceentity.DisplayName.UserLocalizedLabel.Label;
            var ents = dialog.sourceentity.OneToManyRelationships.Select(r => r.ReferencingEntity);
            dialog.xrmEntityComboBox1.DataSource = owner.entities.Where(e => ents.Contains(e.LogicalName));
            if (dialog.ShowDialog((Control)owner) == DialogResult.OK)
            {
                return dialog.GetResult();
            }
            return null;
        }

        private string GetResult()
        {
            return "<expand|" +
                xrmEntityComboBox1.SelectedEntity?.LogicalName + "|" +
                xrmLookup.SelectedAttribute?.LogicalName + "|" +
                (xrmShow.SelectedAttribute == null ? "|" : "{" + xrmShow.SelectedAttribute?.LogicalName + "}|") +
                xrmOrder.SelectedAttribute?.LogicalName +
                (!chkOrderSel.Checked ? "|" : "/desc|") +
                txtSeparate.Text + "|" +
                (chkDistinct.Checked ? "true" : "false") + "|" +
                (chkActive.Checked ? "true" : "false") + "|" +
                mskMax.Text + ">";
        }

        private void xrmEntityComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (xrmEntityComboBox1.SelectedEntity is EntityMetadata select)
            {
                // get relations, which is the attributes
                var childentity = xrmtr.Service.GetEntity(select.LogicalName);
                xrmLookup.DataSource = childentity.Attributes
                    .OfType<LookupAttributeMetadata>()
                    .Where(a => a.Targets.Contains(sourceentity.LogicalName));
                xrmShow.DataSource = childentity.Attributes
                    .Where(a => a.IsLogical == false);
                xrmOrder.DataSource = childentity.Attributes
                    .Where(a => a.IsLogical == false)
                    .Where(a => a is StringAttributeMetadata || a is IntegerAttributeMetadata);
            }
            else
            {
                xrmLookup.DataSource = null;
                xrmShow.DataSource = null;
                xrmOrder.DataSource = null;
            }
            ShowResult();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/#expand");
        }

        private void ShowResult(object sender = null, System.EventArgs e = null)
        {
            txtResult.Text = GetResult();
        }
    }
}