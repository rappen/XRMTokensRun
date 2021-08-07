using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XTB.Helpers.Extensions;
using System.Collections.Generic;
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

        public static string ShowDialog(XRMTR owner, EntityMetadata entity, IEnumerable<AttributeMetadata> attributes = null)
        {
            var dialog = new GetChildEntityAttribute();
            dialog.xrmtr = owner;
            dialog.sourceentity = entity;
            dialog.txtTable.Text = entity.DisplayName.UserLocalizedLabel.Label;
            var ents = entity.OneToManyRelationships.Select(r => r.ReferencingEntity);
            dialog.xrmEntityComboBox1.DataSource = owner.entities.Where(e => ents.Contains(e.LogicalName));
            if (dialog.ShowDialog(owner) == DialogResult.OK && dialog.xrmLookup.SelectedAttribute is AttributeMetadata attr)
            {
                return "<expand|" +
                    dialog.xrmEntityComboBox1.SelectedEntity?.LogicalName + "|" +
                    dialog.xrmLookup.SelectedAttribute?.LogicalName + "|" +
                    "{" + dialog.xrmShow.SelectedAttribute?.LogicalName + "}|" +
                    dialog.xrmOrder.SelectedAttribute?.LogicalName + "/asc|" +
                    dialog.txtSeparate.Text + "|" +
                    (dialog.chkDistinct.Checked ? "true" : "false") + "|" +
                    (dialog.chkActive.Checked ? "true" : "false") + "|" +
                    dialog.mskMax.Text + ">";
            }
            return null;
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
        }
    }
}