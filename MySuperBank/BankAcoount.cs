using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
   public class BankAcoount
    {
        public string Number { get; } // Numbers only gettable

        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }


        }

        private List<Transaction> allTransactions = new List<Transaction>();

        private static int accountNumberSeed = 123;

        public BankAcoount()
        {
                
        }
        public BankAcoount(string name, decimal intitialBalance)
        {
            this.Owner = name;
           // this.Balance = intitialBalance;
           MakeDeposite(intitialBalance,DateTime.Now, "InitialBalance");
            this.Number = accountNumberSeed.ToString();
           
            accountNumberSeed++;
        }

        public void MakeDeposite(decimal amount, DateTime date, string note)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdraw must be positie");

            }

            var deposite = new Transaction(amount, date, note);
            allTransactions.Add(deposite);


        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }


            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not suffcient funds for this withdrawal");
            }

            var withdarawarl = new Transaction(-amount, date, note);
            allTransactions.Add(withdarawarl);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            //Header
            report.AppendLine("Date\t\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                //ROWS
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");

            }

            return report.ToString(); 
        }
    }
}
