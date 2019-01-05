namespace PlaidDemo
{
    partial class Main
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxBanks = new System.Windows.Forms.ComboBox();
            this.buttonGetAccounts = new System.Windows.Forms.Button();
            this.buttonGetTransactions = new System.Windows.Forms.Button();
            this.comboBoxAccounts = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxSortDirection = new System.Windows.Forms.ComboBox();
            this.pictureBoxExport = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(800, 369);
            this.dataGridView.TabIndex = 0;
            // 
            // comboBoxBanks
            // 
            this.comboBoxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBanks.FormattingEnabled = true;
            this.comboBoxBanks.Location = new System.Drawing.Point(12, 10);
            this.comboBoxBanks.Name = "comboBoxBanks";
            this.comboBoxBanks.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBanks.TabIndex = 2;
            // 
            // buttonGetAccounts
            // 
            this.buttonGetAccounts.Location = new System.Drawing.Point(190, 9);
            this.buttonGetAccounts.Name = "buttonGetAccounts";
            this.buttonGetAccounts.Size = new System.Drawing.Size(90, 23);
            this.buttonGetAccounts.TabIndex = 3;
            this.buttonGetAccounts.Text = "Get Accounts";
            this.buttonGetAccounts.UseVisualStyleBackColor = true;
            this.buttonGetAccounts.Click += new System.EventHandler(this.buttonGetAccounts_Click);
            // 
            // buttonGetTransactions
            // 
            this.buttonGetTransactions.Location = new System.Drawing.Point(694, 53);
            this.buttonGetTransactions.Name = "buttonGetTransactions";
            this.buttonGetTransactions.Size = new System.Drawing.Size(94, 23);
            this.buttonGetTransactions.TabIndex = 5;
            this.buttonGetTransactions.Text = "GetTransactions";
            this.buttonGetTransactions.UseVisualStyleBackColor = true;
            this.buttonGetTransactions.Click += new System.EventHandler(this.buttonGetTransactions_Click);
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccounts.FormattingEnabled = true;
            this.comboBoxAccounts.Location = new System.Drawing.Point(12, 54);
            this.comboBoxAccounts.Name = "comboBoxAccounts";
            this.comboBoxAccounts.Size = new System.Drawing.Size(253, 21);
            this.comboBoxAccounts.TabIndex = 4;
            this.comboBoxAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccounts_SelectedIndexChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(324, 55);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(448, 55);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(291, 58);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(27, 13);
            this.labelFrom.TabIndex = 8;
            this.labelFrom.Text = "from";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(426, 58);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(16, 13);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "to";
            // 
            // comboBoxSortDirection
            // 
            this.comboBoxSortDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortDirection.FormattingEnabled = true;
            this.comboBoxSortDirection.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxSortDirection.Location = new System.Drawing.Point(551, 54);
            this.comboBoxSortDirection.Name = "comboBoxSortDirection";
            this.comboBoxSortDirection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSortDirection.TabIndex = 10;
            this.comboBoxSortDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortDirection_SelectedIndexChanged);
            // 
            // pictureBoxExport
            // 
            this.pictureBoxExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExport.Image = global::PlaidDemo.Properties.Resources.export;
            this.pictureBoxExport.Location = new System.Drawing.Point(744, -1);
            this.pictureBoxExport.Name = "pictureBoxExport";
            this.pictureBoxExport.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExport.TabIndex = 12;
            this.pictureBoxExport.TabStop = false;
            this.pictureBoxExport.Click += new System.EventHandler(this.pictureBoxExport_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSettings.Image = global::PlaidDemo.Properties.Resources.settings;
            this.pictureBoxSettings.Location = new System.Drawing.Point(775, -1);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 11;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxExport);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.comboBoxSortDirection);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonGetTransactions);
            this.Controls.Add(this.comboBoxAccounts);
            this.Controls.Add(this.buttonGetAccounts);
            this.Controls.Add(this.comboBoxBanks);
            this.Controls.Add(this.dataGridView);
            this.Name = "Main";
            this.Text = "Plaid Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxBanks;
        private System.Windows.Forms.Button buttonGetAccounts;
        private System.Windows.Forms.Button buttonGetTransactions;
        private System.Windows.Forms.ComboBox comboBoxAccounts;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxSortDirection;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.PictureBox pictureBoxExport;
    }
}

