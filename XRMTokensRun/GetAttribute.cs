using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XRMTokensRun
{
    public partial class GetAttribute : Form
    {
        public GetAttribute()
        {
            InitializeComponent();
        }

        public static AttributeMetadata ShowDialog(Control owner, EntityMetadata entity, IEnumerable<AttributeMetadata> attributes = null)
        {
            var dialog = new GetAttribute();
            dialog.txtTable.Text = entity.DisplayName.UserLocalizedLabel.Label;
            dialog.xrmAttributeComboBox1.DataSource = attributes == null ?
                entity.Attributes.Where(a => a.IsLogical == false) :
                attributes;
            if (dialog.ShowDialog(owner) == DialogResult.OK && dialog.xrmAttributeComboBox1.SelectedAttribute is AttributeMetadata attr)
            {
                return attr;
            }
            return null;
        }
    }
}