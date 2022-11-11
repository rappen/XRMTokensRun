using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XRM.Tokens;
using Rappen.XTB.Helpers.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace XRMTokensRun
{
    public partial class XRMTR : PluginControlBase, IGitHubPlugin, IPayPalPlugin, IMessageBusHost, IAboutPlugin, IHelpPlugin
    {
        private Settings settings;
        private const string aiEndpoint = "https://dc.services.visualstudio.com/v2/track";
        private const string aiKey = "eed73022-2444-45fd-928b-5eebd8fa46a6";    // jonas@rappen.net tenant, XrmToolBox
        private AppInsights ai = new AppInsights(aiEndpoint, aiKey, Assembly.GetExecutingAssembly(), "XRM Tokens Runner");
        private EntityReference loadingreference;

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

            cmbTokenHelp.Items.Add(" - Power Fx -");
            cmbTokenHelp.Items.Add(new TokenHelp("PowerFx", "<PowerFx|formula>", 9, 7, "Add any formula for Power Fx, including data from Dataverse.", "https://jonasr.app/xrm-tokens/#powerfx"));
            cmbTokenHelp.Items.Add("");
            cmbTokenHelp.Items.Add(" - Data -");
            cmbTokenHelp.Items.Add(new TokenHelp("Column", "{column}", 1, 6, "A simple column, of lookup.column", "https://jonasr.app/xrm-tokens/#attribute"));
            cmbTokenHelp.Items.Add(new TokenHelp("Column Raw", "{column|<value>}", 1, 6, "Like Column, but always return simlest type.", "https://jonasr.app/xrm-tokens/#raw"));
            cmbTokenHelp.Items.Add(new TokenHelp("System", "<system|value|format>", 8, 5, "Gets 'systems' like now related to 'data'.", "https://jonasr.app/xrm-tokens/#system"));
            cmbTokenHelp.Items.Add("");
            cmbTokenHelp.Items.Add(" - Formatting -");
            cmbTokenHelp.Items.Add(new TokenHelp("Left", "<Left|length>", 6, 6, "Can add to Left number of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Right", "<Right|length>", 7, 6, "Can add to Right number of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Upper", "<Upper>", 1, 5, "Make all letters uppercase of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Lower", "<Lower>", 1, 5, "Make all letters lowercase of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("Trim", "<Trim|chars>", 6, 5, "Trim start/end, maybe of a string, of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("TrimStart", "<TrimStart|chars>", 11, 5, "Trim start, maybe of a string, of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
            cmbTokenHelp.Items.Add(new TokenHelp("TrimEnd", "<TrimEnd|chars>", 9, 5, "Trim end, maybe of a string, of Column/System data.", "https://jonasr.app/xrm-tokens/#formatting"));
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
            ai.WriteEvent("Load");
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
            LoadEntitiesEtc();
        }

        private void LoadEntitiesEtc()
        {
            if (Service == null)
            {
                entities = null;
                return;
            }
            Enable(false);
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Load entities",
                Work = (work, arg) =>
                {
                    arg.Result = Service?.LoadEntities()?.EntityMetadata;
                },
                PostWorkCallBack = (arg) =>
                {
                    if (arg.Error != null)
                    {
                        MessageBox.Show(arg.Error.Message);
                    }
                    else if (arg.Result is EntityMetadataCollection result)
                    {
                        entities = result;
                        cmbTable.DataSource = entities;
                        record.Service = Service;
                        if (loadingreference != null)
                        {
                            cmbTable.SetSelected(loadingreference.LogicalName);
                            LoadRecord(loadingreference);
                            loadingreference = null;
                        }
                        else if (settings.Table != null)
                        {
                            cmbTable.SetSelected(settings.Table);
                        }
                    }
                    Enable(true);
                }
            });
        }

        private void LoadSetting()
        {
            if (settings == null && !SettingsManager.Instance.TryLoad(GetType(), out settings, ConnectionDetail?.ConnectionName))
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
            settings.RecordId = settings.RecordId ?? new List<KeyValuePair>();
            settings.Token = settings.Token ?? new List<KeyValuePair>();
            settings.Table = cmbTable.SelectedEntity?.LogicalName;
            if (settings.RecordId?.FirstOrDefault(t => t.key == settings.Table) is KeyValuePair id)
            {
                id.value = record.Id.ToString();
            }
            else
            {
                settings.RecordId.Add(new KeyValuePair { key = settings.Table, value = record.Id.ToString() });
            }
            if (settings.Token?.FirstOrDefault(t => t.key == settings.Table) is KeyValuePair token)
            {
                token.value = txtTokensIn.Text;
            }
            else
            {
                settings.Token.Add(new KeyValuePair { key = settings.Table, value = txtTokensIn.Text });
            }
            SettingsManager.Instance.Save(GetType(), settings, ConnectionDetail?.ConnectionName);
        }

        private void Enable(bool on)
        {
            cmbTable.Enabled = on && Service != null;
            btnGetRecord.Enabled = on && cmbTable.SelectedEntity is EntityMetadata;
            btnRefresh.Enabled = on && record.Record != null;
            btnOpenRecord.Enabled = on && record.Record != null;
            gbTokens.Enabled = on && record.Record != null;
            gbSmart.Enabled = on && record.Record != null;
            btnAddToken.Enabled = cmbTokenHelp.SelectedItem is TokenHelp;
            btnBackTool.Enabled = btnBackTool.Tag != null;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entity = cmbTable.SelectedEntity;
            record.Record = null;
            if (entity != null && settings != null)
            {
                if (settings.RecordId?.FirstOrDefault(r => r.key == entity.LogicalName) is KeyValuePair strid &&
                    Guid.TryParse(strid.value, out Guid id) &&
                    !id.Equals(Guid.Empty))
                {
                    LoadRecord(new EntityReference(entity.LogicalName, id));
                }
                var token = settings.Token?.FirstOrDefault(t => t.key == entity.LogicalName)?.value;
                txtTokensIn.Lines = token?.Split('\n');
            }
            Enable(true);
        }

        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            if (cmbTable.SelectedEntity == null)
            {
                return;
            }
            var look = new XRMLookupDialog
            {
                Service = Service,
                LogicalName = cmbTable.SelectedEntity.LogicalName
            };
            switch (look.ShowDialog())
            {
                case DialogResult.OK:
                    if (look.Record != null)
                    {
                        LoadRecord(look.Record.ToEntityReference());
                    }
                    else
                    {
                        record.Record = null;
                    }
                    break;

                case DialogResult.Abort:
                    record.Record = null;
                    break;
            }
            Enable(true);
        }

        private void LoadRecord(EntityReference reference)
        {
            if (reference == null)
            {
                record.Record = null;
                return;
            }
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading record...",
                Work = (work, args) =>
                {
                    args.Result = Service.Retrieve(reference.LogicalName, reference.Id, new ColumnSet(true));
                },
                PostWorkCallBack = (arg) =>
                {
                    if (arg.Error != null)
                    {
                        ShowErrorDialog(arg.Error);
                    }
                    else if (arg.Result is Entity result)
                    {
                        record.Record = result;
                        Execute();
                    }
                    Enable(true);
                }
            });
        }

        private void Execute()
        {
            timer1.Stop();
            if (record.Record == null)
            {
                return;
            }
            SaveSettings();
            lblError.Text = "";
            txtTokensOut.Text = "";
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Calling XRM Tokens",
                Work = (work, arg) =>
                {
                    arg.Result = record.Record.Tokens(Service, txtTokensIn.Text);
                },
                PostWorkCallBack = (arg) =>
                {
                    if (arg.Error != null)
                    {
                        lblError.Text = arg.Error.Message.Replace("\r\n", ", ");
                    }
                    else if (arg.Result is string result)
                    {
                        txtTokensOut.Text = result;
                    }
                }
            });
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
            InsertValue(txtTokensIn, token);
        }

        internal static void InsertValue(TextBox textbox, string value)
        {
            var selstart = textbox.SelectionStart;
            textbox.SelectedText = "";
            textbox.Text = textbox.Text.Insert(selstart, value);
            textbox.SelectionStart = selstart;
            textbox.SelectionLength = value.Length;
            textbox.Focus();
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

        private void btnSmartPowerFx_Click(object sender, EventArgs e)
        {
            AddSmartToken(GetPowerFx.ShowDialog(this));
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

        private void btnSmartRandom_Click(object sender, EventArgs e)
        {
            AddSmartToken(GetRandom.ShowDialog(this));
        }

        public void ShowAboutDialog()
        {
            var about = new About(this)
            {
                StartPosition = FormStartPosition.CenterParent
            };
            about.lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            about.ShowDialog();
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
                var reference = new EntityReference(entity, id);
                if (entities == null)
                {
                    loadingreference = reference;
                }
                else
                {
                    cmbTable.SetSelected(entity);
                    LoadRecord(reference);
                }
            }
            else
            {
                MessageBox.Show("Call this tool with any of these argument:\n\n  Entity\n  EntityReference\n  LogicalName:Guid (string)\n\nTry again! :)",
                    "Message Argument incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tslAbout_Click(object sender, EventArgs e)
        {
            ShowAboutDialog();
        }

        private void cmbTable_Leave(object sender, EventArgs e)
        {
            if (cmbTable.SelectedItem == null && !string.IsNullOrWhiteSpace(cmbTable.Text))
            {
                foreach (var item in cmbTable.Items)
                {
                    if (item.ToString().Equals(cmbTable.Text, StringComparison.InvariantCultureIgnoreCase))
                    {
                        cmbTable.SelectedItem = item;
                        return;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var entity = cmbTable.SelectedEntity;
            if (entity == null)
            {
                MessageBox.Show("No proper table is selected.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var save = new SaveFileDialog
            {
                Title = $"Save XRM Tokens for {entity.DisplayName?.UserLocalizedLabel?.Label} table",
                DefaultExt = $".{entity.LogicalName}.XRM.Tokens",
                Filter = $"*.{entity.LogicalName}.XRM.Tokens|*.{entity.LogicalName}.XRM.Tokens"
            };
            if (save.ShowDialog(this) == DialogResult.OK)
            {
                System.IO.File.WriteAllText(save.FileName, txtTokensIn.Text);
                MessageBox.Show($"XRM Tokens saved to file:\n{save.FileName}", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var entity = cmbTable.SelectedEntity;
            if (entity == null)
            {
                MessageBox.Show("No proper table is selected.", "Open", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var open = new OpenFileDialog
            {
                Title = $"Open XRM Tokens for {entity.DisplayName?.UserLocalizedLabel?.Label} table",
                Filter = $"*.{entity.LogicalName}.XRM.Tokens|*.{entity.LogicalName}.XRM.Tokens"
            };
            if (open.ShowDialog(this) == DialogResult.OK)
            {
                var text = System.IO.File.ReadAllText(open.FileName);
                MessageBox.Show($"XRM Tokens opened from file:\n{open.FileName}", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTokensIn.Text = text;
            }
        }

        private void btnOpenRecord_Click(object sender, EventArgs e)
        {
            if (Service.GetEntityFormUrl(record.Record?.ToEntityReference()) is string url && !string.IsNullOrEmpty(url))
            {
                ConnectionDetail.OpenUrlWithBrowserProfile(new Uri(url));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var recref = record.Record.ToEntityReference();
            record.Record = null;
            LoadRecord(recref);
        }
    }
}