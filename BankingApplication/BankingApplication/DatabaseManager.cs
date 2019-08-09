using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Added
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BankingApplication
{
    public class DatabaseManager
    {

        public string trnaccountname;
        public DateTime trndate;
        public string trntype;
        public decimal trnamount;
        public string trnorderof;
        public string trnid;

        public decimal NewBalance;

        //Declare Sql Connection
        public SqlConnection cn { get; set; }
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;

        private DataTable dtdatabase = new DataTable(); //creates data table
        private SqlDataAdapter daDatabase;  //delcares a reference variable for the data adapter
        private BindingSource bsDataBase = new BindingSource(); // create a binding source
        private DataRow drDatabase;
        private DataRowView drvDataBase;


        public DatabaseManager(string connection)
        {
            try
            {
                //Create Instance of Connection
                cn = new SqlConnection();
                cn.ConnectionString = connection;
                cmd.Connection = cn;
            }
            catch (Exception err)
            {
                //Error Handling for Sql Connection
                MessageBox.Show(err.Message, "Issue with Database Connection");
            }
        }

        //Load from DBTable to TransactionList
        public void InsertDataToDB(List<Transaction> transactions)
        {
                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO tblTransactions (transactionDate, accountName, transactionType, transactionAmount, orderOf, transactionId)" +
                        "VALUES (@trndate, @trnname, @trntype, @trnamt, @trnorderof, @trnid)");

                    cmd.Connection = cn;

                    foreach (var trn in transactions)
                    {
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@trndate", trn.Date);
                        cmd.Parameters.AddWithValue("@trnname", trn.TransactionName);
                        cmd.Parameters.AddWithValue("@trntype", trn.TransactionType);
                        cmd.Parameters.AddWithValue("@trnamt", trn.TransactionAmount);
                        cmd.Parameters.AddWithValue("@trnorderof", trn.OrderOf);
                        cmd.Parameters.AddWithValue("@trnid", trn.ID);
                        cmd.ExecuteNonQuery();

                }

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message, "Error Inserting into Database");
                    
                }
                finally
                {
                    cmd.Parameters.Clear();
                    cn.Close();

                }
        }
        

        public List<Transaction> LoadDataFromDB(string AccountName)
        {
            //Create List of Transactions
            List<Transaction> transactions = new List<Transaction>();
            Transaction trn;

            if (trnaccountname == null)
            { MessageBox.Show("Please Select an Account"); }

            else
                this.trnaccountname = AccountName;
            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM tblTransactions WHERE accountName LIKE '" + trnaccountname + "'", cn);
                SqlDataReader drBanking = sqlCommand.ExecuteReader();


                while (drBanking.Read())
                {
                    trndate = (DateTime)drBanking["transactionDate"];
                    trnaccountname = (string)drBanking["accountName"];
                    trntype = (string)drBanking["transactionType"];
                    trnamount = (decimal)drBanking["transactionAmount"];
                    trnorderof = (string)drBanking["orderOf"];
                    trnid = (string)drBanking["transactionId"];

                    trn = new Transaction(trnaccountname, trntype, trnamount, trnorderof, trnid, trndate);

                    transactions.Add(trn);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Loading from Database");
            }

            finally
            {
                cn.Close();
            }

            return transactions;
        }

    public decimal getBalance(string accountName)
    {
        this.trnaccountname = accountName;
        try
        {
            cmd.CommandText = "SELECT accountBalance FROM tblAccounts WHERE accountName = @trnaccountname";
            cmd.Parameters.AddWithValue("@trnaccountname", accountName);
            cn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            decimal balance = dr.GetDecimal(0);
            cmd.Parameters.Clear();
            cn.Close();
            return balance;
        }
        catch (Exception err)
        {

            MessageBox.Show(err.Message, "Error Obtaining Balance");
            return 0;
        }
        finally
        {
            cn.Close();
        }
    }

    public void updateBalance(string accountName, decimal newbalance)
    {
        this.trnaccountname = accountName;
        try
        {
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "UPDATE tblAccounts SET accountBalance = @NewBalance WHERE accountName LIKE @trnaccountname";
            cmd.Parameters.AddWithValue("@NewBalance", newbalance);
            cmd.Parameters.AddWithValue("@trnaccountname", accountName);

            cmd.ExecuteNonQuery();
        }
        catch (Exception err)
        {

            MessageBox.Show(err.Message, "Error Updating Balance");
        }
        finally
        {
                cmd.Parameters.Clear();
                cn.Close();
        }
    }
 }
}
