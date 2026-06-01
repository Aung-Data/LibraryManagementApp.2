using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp._2
    {
        public class Transaction
        {
            //Transcation Class Fields
            private string transactionID;
            private string bookID;
            private string memberID;
            private string transactionType;
            private DateTime transactionDate;

            //Transcation Class Properties
            public string TransactionID
            {
                get { return transactionID; }
                set { transactionID = value; }
            }

            public string BookID
            {
                get { return bookID; }
                set { bookID = value; }
            }

            public string MemberID
            {
                get { return memberID; }
                set { memberID = value; }
            }

            public string TransactionType
            {
                get { return transactionType; }
                set { transactionType = value; }
            }

            public DateTime TransactionDate
            {
                get { return transactionDate; }
                set { transactionDate = value; }
            }

            //Transcation Class Constructor
            public Transaction(string transactionID, string bookID, string memberID, string transactionType)
            {
                TransactionID = transactionID;
                BookID = bookID;
                MemberID = memberID;
                TransactionType = transactionType;
                TransactionDate = DateTime.Now;
            }

            //Display Transaction Details
            public void DisplayTransaction()
            {
                Console.WriteLine("========== Transaction Details ==========");
                Console.WriteLine($"Transaction ID: \t{TransactionID}");
                Console.WriteLine($"Book ID: \t\t{BookID}");
                Console.WriteLine($"Member ID: \t\t{MemberID}");
                Console.WriteLine($"Transaction Type: \t{TransactionType}");
                Console.WriteLine($"Date: \t\t\t{TransactionDate}");
                Console.WriteLine("=========================================");
            }
        }
    }


