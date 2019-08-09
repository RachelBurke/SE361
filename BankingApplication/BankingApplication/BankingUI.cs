using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Added Directive
using System.Data.SqlClient;

namespace BankingApplication
{
    public partial class BankingUI : Form
    {
        private List<Transaction> transactions;
        private DatabaseManager objDBManager;

        public string AccountName;
        public decimal Balance;
        public decimal TransactionAmount;
        public string TransactionType;
        public string OrderOf;
        public DateTime TransactionDate;
        public string  ID;

        private static Random random = new Random();
        private int randomNumber = random.Next(0, 50);

        public SqlConnection cn { get; set; }


        const string sqlConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\97rac\Documents\Butler\School\Year 3 - Junior\Semester 5\SE361\BankingApplication\BankingApplication\BankingDatabase.mdf";

        public BankingUI()
        {
            InitializeComponent();

            lblTodaysDate.Text = DateTime.Today.ToString("MM/dd/yyyy");

            //Create Instance of TransactionList 
            transactions = new List<Transaction>();
            objDBManager = new DatabaseManager(sqlConnection);
        }

        public void cmbxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatusBankingApplication.Text = "Now Showing "+cmbxAccountType.Text;

            if(cmbxAccountType.SelectedIndex == 0)
            {
                AccountName = "Savings";
                grpbxCheck.Enabled = false;
            }
            else if (cmbxAccountType.SelectedIndex == 1)
            {
                AccountName = "Checkings";
                grpbxCheck.Enabled = true;
            }

            lstTransactions.Items.Clear();
            txtDepositAmt.Text = string.Empty;
            txtWithdrawalAmt.Text = string.Empty;

            cmbxTransferAcct.SelectedIndex = -1;
            txtTransferAmt.Text = string.Empty;

            txtCheckAmt.Text = string.Empty;
            txtCheckTo.Text = string.Empty;

            lstTransactions.Items.Clear();
            Balance = objDBManager.getBalance(AccountName);
            lblBalance.Text = Balance.ToString();

            if (lblBalance.Text == "0")
                lblStatusBankingApplication.Text = "Uh oh.. Looks like your balance is low..";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDepositAmt.Text = string.Empty;
            txtWithdrawalAmt.Text = string.Empty;

            cmbxTransferAcct.SelectedIndex = -1;
            txtTransferAmt.Text = string.Empty;

            txtCheckAmt.Text = string.Empty;
            txtCheckTo.Text = string.Empty;

            lstTransactions.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void mnuDatabaseLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbxAccountType.SelectedIndex == -1)
                { lblStatusBankingApplication.Text = "Please Select an Account"; }

                else
                { //Loads Records
                    transactions = objDBManager.LoadDataFromDB(AccountName);
                    lblStatusBankingApplication.Text = "Records have been Loaded";

                    //Displays Records
                    lstTransactions.Items.Clear();
                    lstTransactions.Items.AddRange(transactions.ToArray());
                    lblStatusBankingApplication.Text += " Records are being Displayed";
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Warning");
            }
    
         }

        private void mnuDatabaseSave_Click(object sender, EventArgs e)
        {
            lblStatusBankingApplication.Text = "Transaction Saved to Database.";
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Banking Application R&R");
        }

        private void cmbxTransferAcct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbxTransferAcct.SelectedIndex == 1)
                {
                    lblTransferTo.Text = "Savings";
                    cmbxAccountType.SelectedIndex = 1;
                    lblStatusBankingApplication.Text = "Transfer is Ready";
                    cmbxTransferAcct.SelectedIndex = 1;
                }
                else if (cmbxTransferAcct.SelectedIndex == 0)
                {
                    lblTransferTo.Text = "Checkings";
                    cmbxAccountType.SelectedIndex = 0;
                    lblStatusBankingApplication.Text = "Transfer is Ready";
                    cmbxTransferAcct.SelectedIndex = 0;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error with Transfer.");
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (cmbxAccountType.SelectedIndex == -1) { lblStatusBankingApplication.Text = "Select an Account"; }

            else try
            {
                decimal balance = Decimal.Parse(lblBalance.Text);
                decimal transactionAmount = Decimal.Parse(txtDepositAmt.Text);
              
                if (transactionAmount <= 0)
                    {
                        lblStatusBankingApplication.Text = "Enter Positive Number.";

                        //Deadcode
                    }

                else
                {
                    string accountName = cmbxAccountType.Text;

                    decimal newBalance = Account.Deposit(balance, transactionAmount, accountName);

                    lblBalance.Text = newBalance.ToString();
                    lblStatusBankingApplication.Text = "$" + transactionAmount + " Deposited to " + accountName;

                    objDBManager.updateBalance(accountName, newBalance);

                    //Display
                    TransactionDate = DateTime.Now;
                    ID = Transaction.RandomDigits(randomNumber); ;
                    TransactionType = "Deposit";
                    TransactionAmount = Convert.ToDecimal(txtDepositAmt.Text);
                    OrderOf = "none";

                    Transaction objTransaction;
                    objTransaction = new Transaction(AccountName, TransactionType,
                    TransactionAmount, OrderOf, ID, TransactionDate);

                    transactions.Add(objTransaction);

                    lstTransactions.Items.Add(objTransaction.ToString());
                    lblStatusBankingApplication.Text += " Records are being Displayed";
                    objDBManager.InsertDataToDB(transactions);
                    lblStatusBankingApplication.Text = "Transaction was added to database.";

                    if (TransactionType == null)
                        lblStatusBankingApplication.Text = "There is no transaction to display.";

                    TransactionType = null;

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Warning!");
            }
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {

            if (cmbxAccountType.SelectedIndex == -1) { lblStatusBankingApplication.Text = "Select an Account"; }
            else try
            {

                decimal balance = Decimal.Parse(lblBalance.Text);
                decimal transactionAmount = Decimal.Parse(txtWithdrawalAmt.Text);
                if (transactionAmount <= 0)
                    {
                        lblStatusBankingApplication.Text = "Enter Positive Number.";

                        //Deadcode
                    }
                

                else
                {
                    string accountName = cmbxAccountType.Text;
                    decimal newBalance = default(decimal);
                    if (balance < transactionAmount)
                        {
                            lblStatusBankingApplication.Text = "INSUFFICIENT FUNDS";

                            //Deadcode
                        }
                    else
                    {
                        newBalance = Account.Withdraw(balance, transactionAmount, accountName);

                        lblBalance.Text = newBalance.ToString();
                        lblStatusBankingApplication.Text = "$" + transactionAmount + " Withdrawn from " + accountName;

                        objDBManager.updateBalance(accountName, newBalance);

                        //display
                        TransactionDate = DateTime.Now;
                        ID = Transaction.RandomDigits(randomNumber);
                        TransactionType = "Withdraw";
                        TransactionAmount = Convert.ToDecimal(txtWithdrawalAmt.Text);
                        OrderOf = "none";

                        Transaction objTransaction;
                        objTransaction = new Transaction(AccountName, TransactionType,
                        TransactionAmount, OrderOf, ID, TransactionDate);

                        transactions.Add(objTransaction);

                        lstTransactions.Items.Add(objTransaction.ToString());
                        lblStatusBankingApplication.Text += " Records are being Displayed";
                        objDBManager.InsertDataToDB(transactions);
                        lblStatusBankingApplication.Text = "Transaction was added to database.";

                        if (TransactionType == null)
                            lblStatusBankingApplication.Text = "There is no transaction to display.";

                        TransactionType = null;
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Warning!");
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (cmbxAccountType.SelectedIndex != 1) { lblStatusBankingApplication.Text = "Select Checkings"; }
            else try
                {
                    decimal balance = Decimal.Parse(lblBalance.Text);
                    decimal transactionAmount = Decimal.Parse(txtCheckAmt.Text);

                    if (transactionAmount <= 0)
                    {
                        lblStatusBankingApplication.Text = "Enter Positive Number.";

                        //Deadcode
                    }

                    else //Positive Number
                    {
                        string orderto = txtCheckTo.Text;

                        if (txtCheckTo.TextLength == 0) { lblStatusBankingApplication.Text = "Enter 'to Order of'"; }
                        else
                        {
                            if(balance < transactionAmount)
                            {
                                lblStatusBankingApplication.Text = "INSUFFICIENT FUNDS!";

                                //Deadcode
                            }
                            else
                            {
                                string accountName = cmbxAccountType.Text;
                                decimal newBalance = default(decimal);
                                newBalance = Account.Checks(balance, transactionAmount, accountName);


                                lblBalance.Text = newBalance.ToString();
                                lblStatusBankingApplication.Text = "$" + transactionAmount + " Signed to " + orderto;

                                objDBManager.updateBalance(accountName, newBalance);

                                //display
                                TransactionDate = DateTime.Now;
                                ID = Transaction.RandomDigits(randomNumber);
                                TransactionType = "Check";
                                TransactionAmount = Convert.ToDecimal(txtCheckAmt.Text);
                                string payto = txtCheckTo.Text;
                                OrderOf = payto;

                                Transaction objTransaction;
                                objTransaction = new Transaction(AccountName, TransactionType,
                                TransactionAmount, OrderOf, ID, TransactionDate);

                                transactions.Add(objTransaction);

                                lstTransactions.Items.Add(objTransaction.ToString());
                                lblStatusBankingApplication.Text += " Records are being Displayed";
                                objDBManager.InsertDataToDB(transactions);
                                lblStatusBankingApplication.Text = "Transaction was added to database.";

                                if (TransactionType == null)
                                    lblStatusBankingApplication.Text = "There is no transaction to display.";

                                TransactionType = null;
                            } 
                        }
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message, "Warning!");
                }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (cmbxAccountType.SelectedIndex == -1) { lblStatusBankingApplication.Text = "Select an Account"; }
            else try
            {

                decimal balance = Decimal.Parse(lblBalance.Text);
                decimal transactionAmount = Decimal.Parse(txtTransferAmt.Text);                

                string accountName = cmbxTransferAcct.Text;
                decimal newBalance1 = default(decimal);

                if (transactionAmount <= 0)
                    {
                        lblStatusBankingApplication.Text = "Enter Positive Number.";

                        //Deadcode
                    }
                else if (accountName == null)
                { lblStatusBankingApplication.Text = "Chose an Account to Transfer from."; }
                else if (balance < transactionAmount)
                {
                        lblStatusBankingApplication.Text = "INSUFFICIENT FUNDS" ;

                        //Deadcode

                 }
                else
                {

                    newBalance1 = Account.Withdraw(balance, transactionAmount, accountName);
                    objDBManager.updateBalance(accountName, newBalance1);

                    lblBalance.Text = newBalance1.ToString();

                    string transferto = lblTransferTo.Text;
                    AccountName = transferto;

                    decimal transferbalance = objDBManager.getBalance(AccountName) + transactionAmount;

                    objDBManager.updateBalance(AccountName, transferbalance);
                    objDBManager.InsertDataToDB(transactions);

                    AccountName = cmbxTransferAcct.Text;

                    lblStatusBankingApplication.Text = "$" + transactionAmount + " Transferred to " + transferto;

                    //display
                    TransactionDate = DateTime.Now;
                    ID = Transaction.RandomDigits(randomNumber);
                    TransactionType = "Transfer";
                    TransactionAmount = Convert.ToDecimal(txtTransferAmt.Text);
                    OrderOf = "none";

                    Transaction objTransaction;
                    objTransaction = new Transaction(AccountName, TransactionType,
                    TransactionAmount, OrderOf, ID, TransactionDate);

                    transactions.Add(objTransaction);

                    lstTransactions.Items.Add(objTransaction.ToString());
                    lblStatusBankingApplication.Text += " Records are being Displayed";
                    objDBManager.InsertDataToDB(transactions);
                    lblStatusBankingApplication.Text = "Transaction was added to database.";

                    if (TransactionType == null)
                        lblStatusBankingApplication.Text = "There is no transaction to display.";

                    TransactionType = null;
                    }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Warning!");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Deadcode
        }

        private void txtWithdrawalAmt_MouseClick(object sender, MouseEventArgs e)
        {
            txtDepositAmt.Text = string.Empty;
            cmbxTransferAcct.SelectedIndex = -1;
            txtTransferAmt.Text = string.Empty;

            txtCheckAmt.Text = string.Empty;
            txtCheckTo.Text = string.Empty;
        }

        private void txtDepositAmt_MouseClick(object sender, MouseEventArgs e)
        {
            txtWithdrawalAmt.Text = string.Empty;
            cmbxTransferAcct.SelectedIndex = -1;
            txtTransferAmt.Text = string.Empty;

            txtCheckAmt.Text = string.Empty;
            txtCheckTo.Text = string.Empty;
        }

        private void txtCheckAmt_MouseClick(object sender, MouseEventArgs e)
        {
            txtDepositAmt.Text = string.Empty;
            txtWithdrawalAmt.Text = string.Empty;
            cmbxTransferAcct.SelectedIndex = -1;
            txtTransferAmt.Text = string.Empty;
        }

        private void cmbxTransferAcct_MouseClick(object sender, MouseEventArgs e)
        {
            txtWithdrawalAmt.Text = string.Empty;
            txtDepositAmt.Text = string.Empty;
            txtCheckAmt.Text = string.Empty;
            txtCheckTo.Text = string.Empty;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Deadcode
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Deadcode
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Deadcode
        }
    }
}
