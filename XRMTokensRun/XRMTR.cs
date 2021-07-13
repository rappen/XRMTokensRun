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
        private Settings mySettings;

        public XRMTR()
        {
            InitializeComponent();
            
            btnGetRecord.BackColor = Color.White;
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();
            }
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
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
            txtTokensOut.Text = record.Record.Substitute(Service, txtTokensIn.Text);
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
            if (lstRecord.SelectedItems == null)
            {
                return;
            }
            txtTokensIn.Text += "{" + lstRecord.SelectedItems[0].Text + "}";
        }
    }
}