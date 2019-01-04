using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaidDemo
{
    public partial class SettingsWindow : Form
    {
        List<Institution> sandboxInstitutions = new List<Institution>();
        List<Institution> developmentInstitutions = new List<Institution>();
        List<Institution> bankAccountsToDeauthorize = new List<Institution>();

        public SettingsWindow()
        {
            InitializeComponent();

            checkBoxReverseAmounts.Checked = Settings.Instance.ReverseTransactionAmounts;

            sandboxInstitutions.AddRange(Settings.Instance.SandboxInstitutions);
            developmentInstitutions.AddRange(Settings.Instance.DevelopmentInstitutions);

            if (Settings.Instance.PlaidSettings.Environment == Enums.Environment.Sandbox)
            {
                foreach (Institution bank in sandboxInstitutions)
                    listBoxBankAccounts.Items.Add(bank);
            }
            else
            {
                foreach (Institution bank in developmentInstitutions)
                    listBoxBankAccounts.Items.Add(bank);
            }

            textBoxClientId.Text = Settings.Instance.PlaidSettings.Client_Id;
            textBoxPublicKey.Text = Settings.Instance.PlaidSettings.Public_Key;
            textBoxSandboxSecret.Text = Settings.Instance.PlaidSettings.Sandbox_Secret;
            textBoxDevelopmentSecret.Text = Settings.Instance.PlaidSettings.Development_Secret;

            foreach (Enums.Environment value in Enum.GetValues(typeof(Enums.Environment)))
                comboBoxPlaidEnvironments.Items.Add(value);

            comboBoxPlaidEnvironments.SelectedItem = Settings.Instance.PlaidSettings.Environment;

            if (!VerifyPlaidSettings())
                tabControl.SelectedTab = tabPagePlaid;

            comboBoxPlaidEnvironments.SelectedIndexChanged += comboBoxPlaidEnvironments_SelectedIndexChanged;
        }

        private bool VerifyPlaidSettings()
        {
            if (string.IsNullOrEmpty(Settings.Instance.PlaidSettings.Client_Id) ||
                string.IsNullOrEmpty(Settings.Instance.PlaidSettings.Public_Key))
            {
                return false;
            }

            return true;
        }

        private void linkLabelPlaidLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://dashboard.plaid.com/overview");
        }

        private void buttonAddBankAccount_Click(object sender, EventArgs e)
        {
            PlaidInterface.StartPlaidLink();

            textBoxPublicToken.Text = "";
            textBoxInstitutionId.Text = "";
            labelInstitutionId.Visible = true;
            textBoxInstitutionId.Visible = true;
            labelPublicToken.Visible = true;
            textBoxPublicToken.Visible = true;
            buttonAuthorize.Visible = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxBankAccounts.SelectedItems.Count == 0)
                MessageBox.Show("No account is selected in the list");
            else
            {
                List<Institution> selectedBanks = listBoxBankAccounts.SelectedItems.Cast<Institution>().ToList();
                for (int i = 0; i < selectedBanks.Count; i++)
                {
                    if ((Enums.Environment)comboBoxPlaidEnvironments.SelectedItem == Enums.Environment.Sandbox)
                        sandboxInstitutions.Remove(selectedBanks[i]);
                    else
                        developmentInstitutions.Remove(selectedBanks[i]);

                    SyncListBox();

                    bankAccountsToDeauthorize.Add(selectedBanks[i]);
                }
            }
        }

        private void buttonAuthorize_Click(object sender, EventArgs e)
        {
            Institution bank = PlaidInterface.GetInstitutionById(textBoxInstitutionId.Text);
            bank.Credentials = PlaidInterface.AuthorizeInstitution(bank, textBoxPublicToken.Text);

            if ((Enums.Environment)comboBoxPlaidEnvironments.SelectedItem == Enums.Environment.Sandbox)
                sandboxInstitutions.Add(bank);
            else
                developmentInstitutions.Add(bank);

            SyncListBox();

            labelInstitutionId.Visible = false;
            textBoxInstitutionId.Visible = false;
            labelPublicToken.Visible = false;
            textBoxPublicToken.Visible = false;
            buttonAuthorize.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveSettings();

            this.Close();
        }

        private void SaveSettings()
        {
            Settings.Instance.ReverseTransactionAmounts = checkBoxReverseAmounts.Checked;

            Settings.Instance.PlaidSettings.Client_Id = textBoxClientId.Text;
            Settings.Instance.PlaidSettings.Public_Key = textBoxPublicKey.Text;
            Settings.Instance.PlaidSettings.Sandbox_Secret = textBoxSandboxSecret.Text;
            Settings.Instance.PlaidSettings.Development_Secret = textBoxDevelopmentSecret.Text;
            Settings.Instance.PlaidSettings.Environment = (Enums.Environment)comboBoxPlaidEnvironments.SelectedItem;

            Settings.Instance.SandboxInstitutions.Clear();
            Settings.Instance.SandboxInstitutions.AddRange(sandboxInstitutions);
            Settings.Instance.DevelopmentInstitutions.Clear();
            Settings.Instance.DevelopmentInstitutions.AddRange(developmentInstitutions);

            Settings.SaveSettings();
        }

        private void SyncListBox()
        {
            listBoxBankAccounts.Items.Clear();
            if ((Enums.Environment)comboBoxPlaidEnvironments.SelectedItem == Enums.Environment.Sandbox)
            {
                foreach (Institution bank in sandboxInstitutions)
                    listBoxBankAccounts.Items.Add(bank);
            }
            else
            {
                foreach (Institution bank in developmentInstitutions)
                    listBoxBankAccounts.Items.Add(bank);
            }
        }

        private void comboBoxPlaidEnvironments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncListBox();
        }

        private void listBoxBankAccounts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = this.listBoxBankAccounts.IndexFromPoint(new Point(e.X, e.Y));

                if (index < 0)
                    return;

                this.listBoxBankAccounts.SelectedIndex = index;

                ContextMenu removeMenu = new ContextMenu();
                MenuItem removeItem = new MenuItem() { Text = "Remove" };
                removeItem.Click += (s, args) => 
                {
                    bankAccountsToDeauthorize.Add((Institution)listBoxBankAccounts.Items[index]);

                    if ((Enums.Environment)comboBoxPlaidEnvironments.SelectedItem == Enums.Environment.Sandbox)
                        sandboxInstitutions.RemoveAt(index);
                    else
                        developmentInstitutions.RemoveAt(index);

                    SyncListBox();
                };
                removeMenu.MenuItems.Add(removeItem);
                removeMenu.Show((sender as ListBox), new Point(e.X, e.Y));
            }
        }

        private void DeauthorizeBankAccounts()
        {
            foreach (Institution bank in bankAccountsToDeauthorize)
                PlaidInterface.DeauthorizeInstitution(bank);
        }
    }
}
