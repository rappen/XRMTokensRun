using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XTB.Helpers;
using Rappen.XTB.Helpers.Controls;
using Rappen.XTB.Helpers.Extensions;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace XRMTokensRun
{
    public partial class XRMTR : PluginControlBase, IGitHubPlugin, IPayPalPlugin, IMessageBusHost, IAboutPlugin, IHelpPlugin
    {
        private Settings settings;

        public event EventHandler<MessageBusEventArgs> OnOutgoingMessage;

        public EntityMetadataCollection entities { get; private set; }

        public EntityMetadata recordmeta => Service?.GetEntity(cmbTable.SelectedEntity?.LogicalName);

        public string RepositoryName => "XRMTokensRun";

        public string UserName => "rappen";

        public string DonationDescription => "Donation to XRM Tokens Runner for XrmToolBox";

        public string EmailAccount => "jonas@rappen.net";

        public string HelpUrl => "https://jonasr.app/xrm-tokens/";

        public XRMTR()
        {
            InitializeComponent();
            MetadataExtensions.attributeProperties = MetadataExtensions.attributeProperties.Union(new string[] {
                "IsLogical",
                "EntityLogicalName"
            }).ToArray();

            cmbTokenHelp.Items.Add(" - Data -");
            cmbTokenHelp.Items.Add(new TokenHelp("Column", "{column}", 1, 6, "A simple column, of lookup.column", "https://jonasr.app/xrm-tokens/#attribute"));
            cmbTokenHelp.Items.Add(new TokenHelp("Column Raw", "{column|<value>}", 1, 6, "Like Column, but always return simlest type.", "https://jonasr.app/xrm-tokens/#raw"));
            cmbTokenHelp.Items.Add(new TokenHelp("System", "<system|value|format>", 8, 5, "Gets 'systems' like now related to 'data'.", "https://jonasr.app/xrm-tokens/#system"));
            cmbTokenHelp.Items.Add("");
            cmbTokenHelp.Items.Add(" - Formatting -");
            cmbTokenHelp.Items.Add(new TokenHelp("Left", "<Left|length>", 6, 6, "Can add to Left number of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Right", "<Right|length>", 7, 6, "Can add to Right number of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("SubStr", "<SubStr|start|length>", 8, 12, "Can add to SubString of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Pad", "<Pad|R|length| >", 7, 6, "Can add to Pad number of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Replace", "<Replace|old|new>", 9, 7, "Can replace old info to new info of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Math", "<Math|operator|value>", 6, 14, "Can add to make calculate of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add("");
            cmbTokenHelp.Items.Add(" - Advance -");
            cmbTokenHelp.Items.Add(new TokenHelp("IIF", "<iif|value1|operator|value2|then|else>", 5, 6, "If-else to decide how info shall be returned.", "https://jonasr.app/xrm-tokens/#ifelse"));
            cmbTokenHelp.Items.Add(new TokenHelp("Expand", "<expand|entity|attribute|{attribute}|orderby|, |true|true|max>", 8, 6, "Return all children from the Column", "https://jonasr.app/xrm-tokens/#expand"));
        }

        private void XRMTR_Load(object sender, EventArgs e)
        {
            LoadSetting();
            Enable(true);
        }

        public override void ClosingPlugin(PluginCloseInfo info)
        {
            SaveSettings();
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            LoadSetting();
            entities = newService?.LoadEntities()?.EntityMetadata;
            cmbTable.DataSource = entities;
            record.Service = newService;
            if (settings.Table != null)
            {
                cmbTable.SetSelected(settings.Table);
            }
        }

        private void LoadSetting()
        {
            if (settings == null && !SettingsManager.Instance.TryLoad(GetType(), out settings))
            {
                settings = new Settings();
            }
        }

        private void SaveSettings()
        {
            if (settings == null)
            {
                settings = new Settings();
            }
            settings.Table = cmbTable.SelectedEntity.LogicalName;
            if (settings.Token?.FirstOrDefault(t => t.key == cmbTable.SelectedEntity.LogicalName) is KeyValuePair token)
            {
                token.value = txtTokensIn.Text;
            }
            else
            {
                settings.Token.Add(new KeyValuePair { key = cmbTable.SelectedEntity.LogicalName, value = txtTokensIn.Text });
            }
            SettingsManager.Instance.Save(GetType(), settings);
        }

        private void Enable(bool on)
        {
            cmbTable.Enabled = on && Service != null;
            btnGetRecord.Enabled = on && cmbTable.SelectedEntity != null;
            gbTokens.Enabled = on && record?.Record != null;
            btnAddToken.Enabled = on && record?.Record != null && cmbTokenHelp.SelectedItem is TokenHelp;
            btnSmartColumn.Enabled = on && record?.Record != null;
            btnSmartExpand.Enabled = on && record?.Record != null;
            btnSmartIf.Enabled = on && record?.Record != null;
            btnSmartSystem.Enabled = on && record?.Record != null;
            btnBackTool.Enabled = btnBackTool.Tag != null;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entity = cmbTable.SelectedEntity;
            record.Record = null;
            if (entity != null && settings != null)
            {
                var token = settings.Token?.FirstOrDefault(t => t.key == entity.LogicalName)?.value;
                txtTokensIn.Lines = token?.Split('\n');
            }
            Enable(true);
        }

        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            var look = new XRMLookupDialog
            {
                Service = Service,
                LogicalName = cmbTable.SelectedEntity.LogicalName
            };
            if (look.ShowDialog() == DialogResult.OK)
            {
                record.Record = Service.Retrieve(look.Record.LogicalName, look.Record.Id, new ColumnSet(true));
            }
            Execute();
            Enable(true);
        }

        private void Execute()
        {
            timer1.Stop();
            if (record.Record == null)
            {
                return;
            }
            SaveSettings();
            try
            {
                lblError.Text = "";
                txtTokensOut.Text = "";
                txtTokensOut.Text = record.Record.Substitute(Service, txtTokensIn.Text);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://jonasr.app/xrm-tokens/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Execute();
        }

        private void txtTokensIn_TextChanged(object sender, EventArgs e)
        {
            Auto();
        }

        private void Auto()
        {
            timer1.Stop();
            timer1.Start();
        }

        private void btnAddToken_Click(object sender, EventArgs e)
        {
            if (cmbTokenHelp.SelectedItem is TokenHelp help)
            {
                cmbTokenHelp.SelectedIndex = -1;
                var selstart = txtTokensIn.SelectionStart;
                txtTokensIn.SelectedText = "";
                txtTokensIn.Text = txtTokensIn.Text.Insert(selstart, help.content);
                txtTokensIn.SelectionStart = selstart + help.cursorpos;
                txtTokensIn.SelectionLength = help.sellength;
                txtTokensIn.Focus();
            }
        }

        private void AddSmartToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return;
            }
            cmbTokenHelp.SelectedIndex = -1;
            var selstart = txtTokensIn.SelectionStart;
            txtTokensIn.SelectedText = "";
            txtTokensIn.Text = txtTokensIn.Text.Insert(selstart, token);
            txtTokensIn.SelectionStart = selstart;
            txtTokensIn.SelectionLength = token.Length;
            txtTokensIn.Focus();
        }

        private void cmbTokenHelp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTokenHelp.SelectedItem is TokenHelp help)
            {
                lblSmart.Text = help.help;
                linkHelp.Enabled = true;
            }
            else
            {
                lblSmart.Text = "";
                linkHelp.Enabled = false;
            }
            Enable(true);
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbTokenHelp.SelectedItem is TokenHelp help)
            {
                Process.Start(help.url);
            }
        }

        private void btnSmartColumn_Click(object sender, EventArgs e)
        {
            AddSmartToken(GetAttribute.ShowDialog(this));
        }

        private void btnSmartExpand_Click(object sender, EventArgs e)
        {
            AddSmartToken(GetChildEntityAttribute.ShowDialog(this));
        }

        private void btnSmartIf_Click(object sender, EventArgs e)
        {
            AddSmartToken(GetIif.ShowDialog(this));
        }

        private void btnSmartSystem_Click(object sender, EventArgs e)
        {
            AddSmartToken(GetSystem.ShowDialog(this));
        }

        public void ShowAboutDialog()
        {
            throw new NotImplementedException();
        }

        public void OnIncomingMessage(MessageBusEventArgs message)
        {
            SetBackTag(null);
            string entity = null;
            string idstr = null;
            if (message.TargetArgument is string str && str.Contains(":"))
            {
                entity = str.Split(':')[0];
                idstr = str.Split(':')[1];
            }
            else if (message.TargetArgument is EntityReference er)
            {
                entity = er.LogicalName;
                idstr = er.Id.ToString();
            }
            else if (message.TargetArgument is Entity ent)
            {
                entity = ent.LogicalName;
                idstr = ent.Id.ToString();
            }
            if (!string.IsNullOrWhiteSpace(entity) && Guid.TryParse(idstr, out Guid id))
            {
                SetBackTag(message.SourcePlugin);
                cmbTable.SetSelected(entity);
                record.LogicalName = entity;
                record.Id = id;
                Enable(true);
            }
        }

        private void btnBackTool_Click(object sender, EventArgs e)
        {
            OnOutgoingMessage(this, new MessageBusEventArgs(btnBackTool.Tag.ToString()) { TargetArgument = txtTokensIn.Text });
        }

        private void SetBackTag(string tag)
        {
            btnBackTool.Tag = tag;
            if (string.IsNullOrWhiteSpace(tag))
            {
                btnBackTool.Text = "Send back XRM Tokens";
            }
            else
            {
                btnBackTool.Text = $"Send back XRM Tokens to tools {tag}";
            }
        }
    }
}