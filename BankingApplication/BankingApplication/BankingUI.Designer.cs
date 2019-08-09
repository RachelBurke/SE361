namespace BankingApplication
{
    partial class BankingUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabaseLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDatabaseSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusBankingApplication = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.grpbxDeposit = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.grpbxWithdrawal = new System.Windows.Forms.GroupBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.txtWithdrawalAmt = new System.Windows.Forms.TextBox();
            this.grpbxTransfer = new System.Windows.Forms.GroupBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtTransferAmt = new System.Windows.Forms.TextBox();
            this.lblTransferTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbxCheck = new System.Windows.Forms.GroupBox();
            this.txtCheckAmt = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtCheckTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.cmbxAccountType = new System.Windows.Forms.ComboBox();
            this.cmbxTransferAcct = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpbxDeposit.SuspendLayout();
            this.grpbxWithdrawal.SuspendLayout();
            this.grpbxTransfer.SuspendLayout();
            this.grpbxCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabase,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDatabase
            // 
            this.mnuDatabase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatabaseLoad,
            this.mnuDatabaseSave});
            this.mnuDatabase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDatabase.Name = "mnuDatabase";
            this.mnuDatabase.Size = new System.Drawing.Size(77, 21);
            this.mnuDatabase.Text = "Database";
            // 
            // mnuDatabaseLoad
            // 
            this.mnuDatabaseLoad.Name = "mnuDatabaseLoad";
            this.mnuDatabaseLoad.Size = new System.Drawing.Size(106, 22);
            this.mnuDatabaseLoad.Text = "Load";
            this.mnuDatabaseLoad.Click += new System.EventHandler(this.mnuDatabaseLoad_Click);
            // 
            // mnuDatabaseSave
            // 
            this.mnuDatabaseSave.Name = "mnuDatabaseSave";
            this.mnuDatabaseSave.Size = new System.Drawing.Size(106, 22);
            this.mnuDatabaseSave.Text = "Save";
            this.mnuDatabaseSave.Click += new System.EventHandler(this.mnuDatabaseSave_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(49, 21);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(114, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBankingApplication,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusBankingApplication
            // 
            this.lblStatusBankingApplication.Name = "lblStatusBankingApplication";
            this.lblStatusBankingApplication.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(63, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(449, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTransactions
            // 
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.Location = new System.Drawing.Point(23, 203);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(646, 69);
            this.lstTransactions.TabIndex = 4;
            // 
            // grpbxDeposit
            // 
            this.grpbxDeposit.Controls.Add(this.btnDeposit);
            this.grpbxDeposit.Controls.Add(this.txtDepositAmt);
            this.grpbxDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxDeposit.Location = new System.Drawing.Point(23, 73);
            this.grpbxDeposit.Name = "grpbxDeposit";
            this.grpbxDeposit.Size = new System.Drawing.Size(200, 57);
            this.grpbxDeposit.TabIndex = 5;
            this.grpbxDeposit.TabStop = false;
            this.grpbxDeposit.Text = "Deposit";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(119, 16);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.Location = new System.Drawing.Point(7, 24);
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.Size = new System.Drawing.Size(106, 21);
            this.txtDepositAmt.TabIndex = 0;
            this.txtDepositAmt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDepositAmt_MouseClick);
            // 
            // grpbxWithdrawal
            // 
            this.grpbxWithdrawal.Controls.Add(this.btnWithdrawal);
            this.grpbxWithdrawal.Controls.Add(this.txtWithdrawalAmt);
            this.grpbxWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxWithdrawal.Location = new System.Drawing.Point(23, 135);
            this.grpbxWithdrawal.Name = "grpbxWithdrawal";
            this.grpbxWithdrawal.Size = new System.Drawing.Size(200, 57);
            this.grpbxWithdrawal.TabIndex = 6;
            this.grpbxWithdrawal.TabStop = false;
            this.grpbxWithdrawal.Text = "Withdrawal";
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawal.Location = new System.Drawing.Point(119, 23);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawal.TabIndex = 3;
            this.btnWithdrawal.Text = "Withdraw";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // txtWithdrawalAmt
            // 
            this.txtWithdrawalAmt.Location = new System.Drawing.Point(7, 24);
            this.txtWithdrawalAmt.Name = "txtWithdrawalAmt";
            this.txtWithdrawalAmt.Size = new System.Drawing.Size(106, 21);
            this.txtWithdrawalAmt.TabIndex = 2;
            this.txtWithdrawalAmt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWithdrawalAmt_MouseClick);
            // 
            // grpbxTransfer
            // 
            this.grpbxTransfer.Controls.Add(this.cmbxTransferAcct);
            this.grpbxTransfer.Controls.Add(this.btnTransfer);
            this.grpbxTransfer.Controls.Add(this.txtTransferAmt);
            this.grpbxTransfer.Controls.Add(this.lblTransferTo);
            this.grpbxTransfer.Controls.Add(this.label3);
            this.grpbxTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxTransfer.Location = new System.Drawing.Point(235, 73);
            this.grpbxTransfer.Name = "grpbxTransfer";
            this.grpbxTransfer.Size = new System.Drawing.Size(208, 119);
            this.grpbxTransfer.TabIndex = 7;
            this.grpbxTransfer.TabStop = false;
            this.grpbxTransfer.Text = "Transfer";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(57, 90);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtTransferAmt
            // 
            this.txtTransferAmt.Location = new System.Drawing.Point(100, 64);
            this.txtTransferAmt.Name = "txtTransferAmt";
            this.txtTransferAmt.Size = new System.Drawing.Size(102, 21);
            this.txtTransferAmt.TabIndex = 3;
            // 
            // lblTransferTo
            // 
            this.lblTransferTo.AutoSize = true;
            this.lblTransferTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferTo.Location = new System.Drawing.Point(7, 69);
            this.lblTransferTo.Name = "lblTransferTo";
            this.lblTransferTo.Size = new System.Drawing.Size(67, 13);
            this.lblTransferTo.TabIndex = 1;
            this.lblTransferTo.Text = "to Savings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Transfer from:";
            // 
            // grpbxCheck
            // 
            this.grpbxCheck.Controls.Add(this.txtCheckAmt);
            this.grpbxCheck.Controls.Add(this.btnSign);
            this.grpbxCheck.Controls.Add(this.txtCheckTo);
            this.grpbxCheck.Controls.Add(this.label5);
            this.grpbxCheck.Controls.Add(this.label4);
            this.grpbxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxCheck.Location = new System.Drawing.Point(449, 73);
            this.grpbxCheck.Name = "grpbxCheck";
            this.grpbxCheck.Size = new System.Drawing.Size(220, 119);
            this.grpbxCheck.TabIndex = 8;
            this.grpbxCheck.TabStop = false;
            this.grpbxCheck.Text = "Check";
            // 
            // txtCheckAmt
            // 
            this.txtCheckAmt.Location = new System.Drawing.Point(112, 27);
            this.txtCheckAmt.Name = "txtCheckAmt";
            this.txtCheckAmt.Size = new System.Drawing.Size(102, 21);
            this.txtCheckAmt.TabIndex = 9;
            this.txtCheckAmt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCheckAmt_MouseClick);
            // 
            // btnSign
            // 
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(75, 90);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(75, 23);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtCheckTo
            // 
            this.txtCheckTo.Location = new System.Drawing.Point(112, 64);
            this.txtCheckTo.Name = "txtCheckTo";
            this.txtCheckTo.Size = new System.Drawing.Size(102, 21);
            this.txtCheckTo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay this Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "to the order of:";
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(27, 41);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(63, 15);
            this.lblAccount.TabIndex = 9;
            this.lblAccount.Text = "Account";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Today\'s Date";
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.BackColor = System.Drawing.Color.Silver;
            this.lblTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysDate.Location = new System.Drawing.Point(562, 45);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(107, 15);
            this.lblTodaysDate.TabIndex = 12;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.Color.Silver;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(308, 45);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(123, 15);
            this.lblBalance.TabIndex = 13;
            // 
            // cmbxAccountType
            // 
            this.cmbxAccountType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbxAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAccountType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxAccountType.FormattingEnabled = true;
            this.cmbxAccountType.Items.AddRange(new object[] {
            "Savings",
            "Checkings"});
            this.cmbxAccountType.Location = new System.Drawing.Point(91, 40);
            this.cmbxAccountType.Name = "cmbxAccountType";
            this.cmbxAccountType.Size = new System.Drawing.Size(132, 20);
            this.cmbxAccountType.TabIndex = 14;
            this.cmbxAccountType.Text = "   -- SELECT ACCOUNT--";
            this.cmbxAccountType.SelectedIndexChanged += new System.EventHandler(this.cmbxAccountType_SelectedIndexChanged);
            // 
            // cmbxTransferAcct
            // 
            this.cmbxTransferAcct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbxTransferAcct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTransferAcct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbxTransferAcct.FormattingEnabled = true;
            this.cmbxTransferAcct.Items.AddRange(new object[] {
            "Savings",
            "Checkings"});
            this.cmbxTransferAcct.Location = new System.Drawing.Point(99, 19);
            this.cmbxTransferAcct.Name = "cmbxTransferAcct";
            this.cmbxTransferAcct.Size = new System.Drawing.Size(101, 23);
            this.cmbxTransferAcct.TabIndex = 5;
            this.cmbxTransferAcct.SelectedIndexChanged += new System.EventHandler(this.cmbxTransferAcct_SelectedIndexChanged_1);
            // 
            // BankingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(700, 336);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpbxTransfer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbxAccountType);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.grpbxCheck);
            this.Controls.Add(this.grpbxWithdrawal);
            this.Controls.Add(this.grpbxDeposit);
            this.Controls.Add(this.lstTransactions);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BankingUI";
            this.Text = "Banking Application: Rachel & Rosa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpbxDeposit.ResumeLayout(false);
            this.grpbxDeposit.PerformLayout();
            this.grpbxWithdrawal.ResumeLayout(false);
            this.grpbxWithdrawal.PerformLayout();
            this.grpbxTransfer.ResumeLayout(false);
            this.grpbxTransfer.PerformLayout();
            this.grpbxCheck.ResumeLayout(false);
            this.grpbxCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabase;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabaseLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuDatabaseSave;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBankingApplication;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstTransactions;
        private System.Windows.Forms.GroupBox grpbxDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtDepositAmt;
        private System.Windows.Forms.GroupBox grpbxWithdrawal;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.TextBox txtWithdrawalAmt;
        private System.Windows.Forms.GroupBox grpbxTransfer;
        private System.Windows.Forms.GroupBox grpbxCheck;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ComboBox cmbxAccountType;
        private System.Windows.Forms.TextBox txtTransferAmt;
        private System.Windows.Forms.Label lblTransferTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtCheckAmt;
        private System.Windows.Forms.ComboBox cmbxTransferAcct;
    }
}

