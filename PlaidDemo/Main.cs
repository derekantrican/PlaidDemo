using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaidDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //Turn on double buffering for faster grid loading
            dataGridView.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dataGridView, true, null);

            Settings.ReadSettings();
            VerifyPlaidSettings();

            PopulateInstitutions();

            comboBoxSortDirection.SelectedIndex = 0;
        }

        private void VerifyPlaidSettings()
        {
            if (string.IsNullOrEmpty(Settings.Instance.PlaidSettings.Client_Id) ||
                string.IsNullOrEmpty(Settings.Instance.PlaidSettings.Public_Key))
            {
                MessageBox.Show("Plaid settings are incorrect. Please open the settings window and check your settings");
            }
        }

        private void PopulateInstitutions()
        {
            comboBoxBanks.Items.Clear();
            comboBoxBanks.Items.Add("All banks");

            foreach (Institution bank in Settings.GetCurrentInstitutions())
                comboBoxBanks.Items.Add(bank);

            comboBoxBanks.SelectedIndex = 0;
        }

        private void PopulateAccounts()
        {
            comboBoxAccounts.Items.Clear();
            comboBoxAccounts.Items.Add("All accounts");

            if (comboBoxBanks.SelectedItem.ToString() == "All banks")
            {
                foreach (Institution bank in Settings.GetCurrentInstitutions())
                {
                    List<Account> accountsForBank = PlaidInterface.GetInstitutionAccounts(bank);
                    bank.Accounts = accountsForBank;
                    foreach (Account account in accountsForBank)
                        comboBoxAccounts.Items.Add(account);
                }
            }
            else
            {
                Institution selectedBank = (Institution)comboBoxBanks.SelectedItem;
                List<Account> accounts = PlaidInterface.GetInstitutionAccounts(selectedBank);
                selectedBank.Accounts = accounts;
                foreach (Account account in accounts)
                    comboBoxAccounts.Items.Add(account);
            }

            comboBoxAccounts.SelectedIndex = 0;
        }

        List<Transaction> transactionsToDisplay = new List<Transaction>();
        private void PopulateTransactions()
        {
            transactionsToDisplay = new List<Transaction>();

            if (comboBoxAccounts.Items.Count == 0)
            {
                MessageBox.Show("Click \"Get Accounts\" first");
                return;
            }

            if (comboBoxAccounts.SelectedItem.ToString() == "All accounts")
            {
                if (comboBoxBanks.SelectedItem.ToString() == "All banks")
                {
                    foreach (Institution bank in Settings.GetCurrentInstitutions())
                    {
                        List<Transaction> transactionsForBank = PlaidInterface.GetTransactions(bank, dateTimePickerStart.Value, dateTimePickerEnd.Value);
                        PlaidInterface.AddTransactionsToAccounts(bank.Accounts, transactionsForBank);

                        transactionsToDisplay.AddRange(transactionsForBank);
                    }
                }
                else
                {
                    Institution selectedBank = (Institution)comboBoxBanks.SelectedItem;
                    List<Transaction> transactionsForBank = PlaidInterface.GetTransactions(selectedBank, dateTimePickerStart.Value, dateTimePickerEnd.Value);
                    PlaidInterface.AddTransactionsToAccounts(selectedBank.Accounts, transactionsForBank);

                    transactionsToDisplay.AddRange(transactionsForBank);
                }
            }
            else
            {
                Account selectedAccount = (Account)comboBoxAccounts.SelectedItem;

                Institution bankHoldingAccount = Settings.GetCurrentInstitutions().Find(p => p.Accounts.Find(a => a.Id == selectedAccount.Id) != null);
                comboBoxBanks.SelectedItem = bankHoldingAccount;

                List<Transaction> transactionsForBank = PlaidInterface.GetTransactions(bankHoldingAccount, dateTimePickerStart.Value, dateTimePickerEnd.Value);
                PlaidInterface.AddTransactionsToAccounts(bankHoldingAccount.Accounts, transactionsForBank);

                transactionsToDisplay.AddRange(selectedAccount.RecentTransactions);
            }

            if ((string)comboBoxSortDirection.SelectedItem == "Ascending")
                transactionsToDisplay.Sort((a, b) => a.Date.CompareTo(b.Date));
            else
                transactionsToDisplay.Sort((a, b) => b.Date.CompareTo(a.Date));

            DisplayTransactions();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            dataGridView.Height = this.Height - 120;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.SaveSettings();
        }

        private void buttonGetAccounts_Click(object sender, EventArgs e)
        {
            PopulateAccounts();
        }

        private void buttonGetTransactions_Click(object sender, EventArgs e)
        {
            PopulateTransactions();
        }

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAccounts.SelectedItem.ToString() != "All accounts")
            {
                Account selectedAccount = (Account)comboBoxAccounts.SelectedItem;

                Institution bankHoldingAccount = Settings.GetCurrentInstitutions().Find(p => p.Accounts.Find(a => a.Id == selectedAccount.Id) != null);
                comboBoxBanks.SelectedItem = bankHoldingAccount;
            }
        }

        private void DisplayTransactions()
        {
            DataTable transactions = new DataTable();
            transactions.Columns.Add("Date", typeof(DateTime));
            transactions.Columns.Add("Bank", typeof(string));
            transactions.Columns.Add("Name", typeof(string));
            transactions.Columns.Add("Amount", typeof(string));

            foreach (Transaction transaction in transactionsToDisplay)
            {
                Institution relatedBank = Settings.GetCurrentInstitutions().Find(b => b.Accounts.Find(a => a.RecentTransactions.Find(t => t.Id == transaction.Id) != null) != null);
                transactions.Rows.Add(transaction.Date, relatedBank, transaction.Name, transaction.FormattedAmount);
            }

            dataGridView.DataSource = transactions;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void comboBoxSortDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxSortDirection.SelectedItem == "Ascending")
                transactionsToDisplay.Sort((a, b) => a.Date.CompareTo(b.Date));
            else
                transactionsToDisplay.Sort((a, b) => b.Date.CompareTo(a.Date));

            DisplayTransactions();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.ShowDialog();

            PopulateInstitutions();
            comboBoxAccounts.Items.Clear();
            dataGridView.DataSource = new DataTable();
        }

        private void pictureBoxExport_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Transactions.csv");

            if (File.Exists(filePath))
                File.Delete(filePath);

            foreach (Transaction transaction in transactionsToDisplay)
            {
                Institution relatedBank = Settings.GetCurrentInstitutions().Find(b => b.Accounts.Find(a => a.RecentTransactions.Find(t => t.Id == transaction.Id) != null) != null);
                string transactionString = transaction.Date + "," + relatedBank + "," + transaction.Name + "," + transaction.FormattedAmount;
                File.AppendAllText(filePath, transactionString);
            }

            MessageBox.Show("Transactions exported to " + filePath);
        }
    }
}
