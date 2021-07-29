using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XTB.Helpers;
using Rappen.XTB.Helpers.Controls;
using Rappen.XTB.Helpers.Extensions;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace XRMTokensRun
{
    public partial class XRMTR : PluginControlBase
    {
        private Settings settings;

        public XRMTR()
        {
            InitializeComponent();
        }

        public override void ClosingPlugin(PluginCloseInfo info)
        {
            SettingsManager.Instance.Save(GetType(), settings, ConnectionDetail?.ConnectionName);
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            if (!SettingsManager.Instance.TryLoad(GetType(), out settings, ConnectionDetail?.ConnectionName))
            {
                settings = new Settings();
            }
            if (newService == null)
            {
                tableselect.DataSource = null;
            }
            else
            {
                tableselect.DataSource = newService.LoadEntities().EntityMetadata;
            }
            record.Service = newService;
        }

        private void tableselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entity = tableselect.SelectedEntity;
            if (entity != null && settings != null)
            {
                settings.Table = entity.LogicalName;
                var token = settings.Token?.FirstOrDefault(t => t.key == settings.Table)?.value;
                txtTokensIn.Text = token;
            }
            btnGetRecord.Enabled = entity != null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var look = new XRMLookupDialog
            {
                Service = Service,
                LogicalName = tableselect.SelectedEntity.LogicalName
            };
            if (look.ShowDialog() == DialogResult.OK)
            {
                record.Record = look.Record;
                ShowColumns();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            SaveSettings();
            txtTokensOut.Text = record.Record.Substitute(Service, txtTokensIn.Text);
        }

        private void SaveSettings()
        {
            if (settings.Token?.FirstOrDefault(t => t.key == tableselect.SelectedEntity.LogicalName) is KeyValuePair token)
            {
                token.value = txtTokensIn.Text;
            }
            else
            {
                settings.Token.Add(new KeyValuePair { key = tableselect.SelectedEntity.LogicalName, value = txtTokensIn.Text });
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            var rec = Service.Retrieve(record.Record.LogicalName, record.Record.Id, new ColumnSet(true));
            record.Record = null;
            record.Record = rec;
            ShowColumns();
        }

        private void ShowColumns()
        {
            lstRecord.Items.Clear();
            lstRecord.Items.AddRange(record.Record.Attributes.Keys.Select(k => new ListViewItem(k)).ToArray());
        }

        private void lstRecord_DoubleClick(object sender, EventArgs e)
        {
            if (lstRecord.SelectedItems == null || lstRecord.SelectedItems.Count == 0)
            {
                return;
            }
            txtTokensIn.Text += "{" + lstRecord.SelectedItems[0].Text + "}";
        }
    }
}