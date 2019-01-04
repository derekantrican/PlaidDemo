namespace PlaidDemo
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.checkBoxReverseAmounts = new System.Windows.Forms.CheckBox();
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.textBoxInstitutionId = new System.Windows.Forms.TextBox();
            this.labelInstitutionId = new System.Windows.Forms.Label();
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.labelPublicToken = new System.Windows.Forms.Label();
            this.textBoxPublicToken = new System.Windows.Forms.TextBox();
            this.buttonAddBankAccount = new System.Windows.Forms.Button();
            this.listBoxBankAccounts = new System.Windows.Forms.ListBox();
            this.tabPagePlaid = new System.Windows.Forms.TabPage();
            this.linkLabelPlaidLink = new System.Windows.Forms.LinkLabel();
            this.labelPlaidMessage = new System.Windows.Forms.Label();
            this.labelEnvironmentType = new System.Windows.Forms.Label();
            this.comboBoxPlaidEnvironments = new System.Windows.Forms.ComboBox();
            this.labelDevelopmentSecret = new System.Windows.Forms.Label();
            this.textBoxDevelopmentSecret = new System.Windows.Forms.TextBox();
            this.labelSandboxSecret = new System.Windows.Forms.Label();
            this.textBoxSandboxSecret = new System.Windows.Forms.TextBox();
            this.labelPublicKey = new System.Windows.Forms.Label();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.labelClientId = new System.Windows.Forms.Label();
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageAccounts.SuspendLayout();
            this.tabPagePlaid.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(347, 386);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(51, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(404, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(43, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageAccounts);
            this.tabControl.Controls.Add(this.tabPagePlaid);
            this.tabControl.Location = new System.Drawing.Point(3, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(455, 348);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.checkBoxReverseAmounts);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Size = new System.Drawing.Size(447, 322);
            this.tabPageMain.TabIndex = 2;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // checkBoxReverseAmounts
            // 
            this.checkBoxReverseAmounts.AutoSize = true;
            this.checkBoxReverseAmounts.Location = new System.Drawing.Point(17, 14);
            this.checkBoxReverseAmounts.Name = "checkBoxReverseAmounts";
            this.checkBoxReverseAmounts.Size = new System.Drawing.Size(198, 17);
            this.checkBoxReverseAmounts.TabIndex = 0;
            this.checkBoxReverseAmounts.Text = "Reverse Transaction Amounts? (+/-)";
            this.checkBoxReverseAmounts.UseVisualStyleBackColor = true;
            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.Controls.Add(this.buttonRemove);
            this.tabPageAccounts.Controls.Add(this.textBoxInstitutionId);
            this.tabPageAccounts.Controls.Add(this.labelInstitutionId);
            this.tabPageAccounts.Controls.Add(this.buttonAuthorize);
            this.tabPageAccounts.Controls.Add(this.labelPublicToken);
            this.tabPageAccounts.Controls.Add(this.textBoxPublicToken);
            this.tabPageAccounts.Controls.Add(this.buttonAddBankAccount);
            this.tabPageAccounts.Controls.Add(this.listBoxBankAccounts);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(447, 322);
            this.tabPageAccounts.TabIndex = 1;
            this.tabPageAccounts.Text = "Bank Accounts";
            this.tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // textBoxInstitutionId
            // 
            this.textBoxInstitutionId.Location = new System.Drawing.Point(184, 265);
            this.textBoxInstitutionId.Name = "textBoxInstitutionId";
            this.textBoxInstitutionId.Size = new System.Drawing.Size(207, 20);
            this.textBoxInstitutionId.TabIndex = 6;
            this.textBoxInstitutionId.Visible = false;
            // 
            // labelInstitutionId
            // 
            this.labelInstitutionId.AutoSize = true;
            this.labelInstitutionId.Location = new System.Drawing.Point(105, 268);
            this.labelInstitutionId.Name = "labelInstitutionId";
            this.labelInstitutionId.Size = new System.Drawing.Size(67, 13);
            this.labelInstitutionId.TabIndex = 5;
            this.labelInstitutionId.Text = "Institution Id:";
            this.labelInstitutionId.Visible = false;
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Location = new System.Drawing.Point(397, 277);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(43, 23);
            this.buttonAuthorize.TabIndex = 4;
            this.buttonAuthorize.Text = "Add";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            this.buttonAuthorize.Visible = false;
            this.buttonAuthorize.Click += new System.EventHandler(this.buttonAuthorize_Click);
            // 
            // labelPublicToken
            // 
            this.labelPublicToken.AutoSize = true;
            this.labelPublicToken.Location = new System.Drawing.Point(105, 298);
            this.labelPublicToken.Name = "labelPublicToken";
            this.labelPublicToken.Size = new System.Drawing.Size(73, 13);
            this.labelPublicToken.TabIndex = 3;
            this.labelPublicToken.Text = "Public Token:";
            this.labelPublicToken.Visible = false;
            // 
            // textBoxPublicToken
            // 
            this.textBoxPublicToken.Location = new System.Drawing.Point(184, 295);
            this.textBoxPublicToken.Name = "textBoxPublicToken";
            this.textBoxPublicToken.Size = new System.Drawing.Size(207, 20);
            this.textBoxPublicToken.TabIndex = 2;
            this.textBoxPublicToken.Visible = false;
            // 
            // buttonAddBankAccount
            // 
            this.buttonAddBankAccount.Location = new System.Drawing.Point(6, 263);
            this.buttonAddBankAccount.Name = "buttonAddBankAccount";
            this.buttonAddBankAccount.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBankAccount.TabIndex = 1;
            this.buttonAddBankAccount.Text = "Add New";
            this.buttonAddBankAccount.UseVisualStyleBackColor = true;
            this.buttonAddBankAccount.Click += new System.EventHandler(this.buttonAddBankAccount_Click);
            // 
            // listBoxBankAccounts
            // 
            this.listBoxBankAccounts.FormattingEnabled = true;
            this.listBoxBankAccounts.Location = new System.Drawing.Point(6, 6);
            this.listBoxBankAccounts.Name = "listBoxBankAccounts";
            this.listBoxBankAccounts.Size = new System.Drawing.Size(435, 251);
            this.listBoxBankAccounts.TabIndex = 0;
            this.listBoxBankAccounts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxBankAccounts_MouseDown);
            // 
            // tabPagePlaid
            // 
            this.tabPagePlaid.Controls.Add(this.linkLabelPlaidLink);
            this.tabPagePlaid.Controls.Add(this.labelPlaidMessage);
            this.tabPagePlaid.Controls.Add(this.labelEnvironmentType);
            this.tabPagePlaid.Controls.Add(this.comboBoxPlaidEnvironments);
            this.tabPagePlaid.Controls.Add(this.labelDevelopmentSecret);
            this.tabPagePlaid.Controls.Add(this.textBoxDevelopmentSecret);
            this.tabPagePlaid.Controls.Add(this.labelSandboxSecret);
            this.tabPagePlaid.Controls.Add(this.textBoxSandboxSecret);
            this.tabPagePlaid.Controls.Add(this.labelPublicKey);
            this.tabPagePlaid.Controls.Add(this.textBoxPublicKey);
            this.tabPagePlaid.Controls.Add(this.labelClientId);
            this.tabPagePlaid.Controls.Add(this.textBoxClientId);
            this.tabPagePlaid.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlaid.Name = "tabPagePlaid";
            this.tabPagePlaid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaid.Size = new System.Drawing.Size(447, 322);
            this.tabPagePlaid.TabIndex = 0;
            this.tabPagePlaid.Text = "Plaid";
            this.tabPagePlaid.UseVisualStyleBackColor = true;
            // 
            // linkLabelPlaidLink
            // 
            this.linkLabelPlaidLink.AutoSize = true;
            this.linkLabelPlaidLink.Location = new System.Drawing.Point(196, 12);
            this.linkLabelPlaidLink.Name = "linkLabelPlaidLink";
            this.linkLabelPlaidLink.Size = new System.Drawing.Size(189, 13);
            this.linkLabelPlaidLink.TabIndex = 11;
            this.linkLabelPlaidLink.TabStop = true;
            this.linkLabelPlaidLink.Text = "https://dashboard.plaid.com/overview";
            this.linkLabelPlaidLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPlaidLink_LinkClicked);
            // 
            // labelPlaidMessage
            // 
            this.labelPlaidMessage.AutoSize = true;
            this.labelPlaidMessage.Location = new System.Drawing.Point(5, 12);
            this.labelPlaidMessage.Name = "labelPlaidMessage";
            this.labelPlaidMessage.Size = new System.Drawing.Size(196, 13);
            this.labelPlaidMessage.TabIndex = 10;
            this.labelPlaidMessage.Text = "Please insert your Plaid credentials from ";
            // 
            // labelEnvironmentType
            // 
            this.labelEnvironmentType.AutoSize = true;
            this.labelEnvironmentType.Location = new System.Drawing.Point(6, 183);
            this.labelEnvironmentType.Name = "labelEnvironmentType";
            this.labelEnvironmentType.Size = new System.Drawing.Size(69, 13);
            this.labelEnvironmentType.TabIndex = 9;
            this.labelEnvironmentType.Text = "Environment:";
            // 
            // comboBoxPlaidEnvironments
            // 
            this.comboBoxPlaidEnvironments.FormattingEnabled = true;
            this.comboBoxPlaidEnvironments.Location = new System.Drawing.Point(81, 180);
            this.comboBoxPlaidEnvironments.Name = "comboBoxPlaidEnvironments";
            this.comboBoxPlaidEnvironments.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlaidEnvironments.TabIndex = 8;
            // 
            // labelDevelopmentSecret
            // 
            this.labelDevelopmentSecret.AutoSize = true;
            this.labelDevelopmentSecret.Location = new System.Drawing.Point(6, 116);
            this.labelDevelopmentSecret.Name = "labelDevelopmentSecret";
            this.labelDevelopmentSecret.Size = new System.Drawing.Size(107, 13);
            this.labelDevelopmentSecret.TabIndex = 7;
            this.labelDevelopmentSecret.Text = "Development Secret:";
            // 
            // textBoxDevelopmentSecret
            // 
            this.textBoxDevelopmentSecret.Location = new System.Drawing.Point(119, 113);
            this.textBoxDevelopmentSecret.Name = "textBoxDevelopmentSecret";
            this.textBoxDevelopmentSecret.Size = new System.Drawing.Size(310, 20);
            this.textBoxDevelopmentSecret.TabIndex = 6;
            // 
            // labelSandboxSecret
            // 
            this.labelSandboxSecret.AutoSize = true;
            this.labelSandboxSecret.Location = new System.Drawing.Point(6, 90);
            this.labelSandboxSecret.Name = "labelSandboxSecret";
            this.labelSandboxSecret.Size = new System.Drawing.Size(86, 13);
            this.labelSandboxSecret.TabIndex = 5;
            this.labelSandboxSecret.Text = "Sandbox Secret:";
            // 
            // textBoxSandboxSecret
            // 
            this.textBoxSandboxSecret.Location = new System.Drawing.Point(98, 87);
            this.textBoxSandboxSecret.Name = "textBoxSandboxSecret";
            this.textBoxSandboxSecret.Size = new System.Drawing.Size(331, 20);
            this.textBoxSandboxSecret.TabIndex = 4;
            // 
            // labelPublicKey
            // 
            this.labelPublicKey.AutoSize = true;
            this.labelPublicKey.Location = new System.Drawing.Point(6, 64);
            this.labelPublicKey.Name = "labelPublicKey";
            this.labelPublicKey.Size = new System.Drawing.Size(60, 13);
            this.labelPublicKey.TabIndex = 3;
            this.labelPublicKey.Text = "Public Key:";
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(72, 61);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(357, 20);
            this.textBoxPublicKey.TabIndex = 2;
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(6, 38);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(48, 13);
            this.labelClientId.TabIndex = 1;
            this.labelClientId.Text = "Client Id:";
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(60, 35);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(369, 20);
            this.textBoxClientId.TabIndex = 0;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(6, 292);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 7;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 421);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            this.tabPageAccounts.ResumeLayout(false);
            this.tabPageAccounts.PerformLayout();
            this.tabPagePlaid.ResumeLayout(false);
            this.tabPagePlaid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePlaid;
        private System.Windows.Forms.TabPage tabPageAccounts;
        private System.Windows.Forms.Label labelDevelopmentSecret;
        private System.Windows.Forms.TextBox textBoxDevelopmentSecret;
        private System.Windows.Forms.Label labelSandboxSecret;
        private System.Windows.Forms.TextBox textBoxSandboxSecret;
        private System.Windows.Forms.Label labelPublicKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Label labelEnvironmentType;
        private System.Windows.Forms.ComboBox comboBoxPlaidEnvironments;
        private System.Windows.Forms.LinkLabel linkLabelPlaidLink;
        private System.Windows.Forms.Label labelPlaidMessage;
        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.Label labelPublicToken;
        private System.Windows.Forms.TextBox textBoxPublicToken;
        private System.Windows.Forms.Button buttonAddBankAccount;
        private System.Windows.Forms.ListBox listBoxBankAccounts;
        private System.Windows.Forms.TextBox textBoxInstitutionId;
        private System.Windows.Forms.Label labelInstitutionId;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.CheckBox checkBoxReverseAmounts;
        private System.Windows.Forms.Button buttonRemove;
    }
}