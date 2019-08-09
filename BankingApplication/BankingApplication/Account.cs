using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Add using directives
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BankingApplication
{
    public class Account
    {
         private List<Transaction> transactions;

        public string AccountName
        { get; set; }

        public decimal Balance
        { get; set; }

        public Account(string accountname, decimal balance)
        {
            AccountName = accountname;
            Balance = balance;
        }

        public static decimal Withdraw(decimal balance, decimal transactionAmount, string accountName)
        {
                balance = balance - transactionAmount;
                return balance;           
        }

        public static decimal Deposit(decimal balance, decimal transactionAmount, string accountName)
        {
            balance = balance + transactionAmount;
            return balance;
        }

        public static decimal Checks(decimal balance, decimal transactionAmount, string accountName)
        {
            balance = balance - transactionAmount;
            return balance;
        }
        public void Display(string accountName)
        {
           //Display for sepcific account is in Load function as well 
        }


    }
}