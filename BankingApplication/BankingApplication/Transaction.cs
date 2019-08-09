using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApplication
{
    public class Transaction
    {
        public DateTime Date { get; set; }

        public decimal TransactionAmount { get; set; }

        public string TransactionType { get; set; } 

        public string TransactionName { get; set; }

        public string OrderOf { get; set; }

        public string ID { get; set; }

        public Transaction(string accountName, string transactiontype, decimal transactionamount, string orderof, string id, DateTime date)
        {
            TransactionType = transactiontype;
            Date = date;
            TransactionName = accountName;
            TransactionAmount = transactionamount;
            OrderOf = orderof;
            ID = id;

        }
        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        public override string ToString()
        {
            try
            {
                return string.Format("Transaction Date: {0:d}, Account Name: {1}, Type: {2}, Amount: {3:c}, Order of: {4}, ID: {5}",
                Date, TransactionName, TransactionType, TransactionAmount, OrderOf, ID);
            }
            catch (Exception err)
            {

                return err.Message;
            }
            
        }
    }
}