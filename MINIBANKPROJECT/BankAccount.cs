using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        public string AccNumber { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in alltransaction)
                {
                    balance += item.Amount;
                }
                return balance;


            
            }
        }
        private static int accountnumseed = 1234567890;

        private List<Transaction> alltransaction = new List<Transaction>();
        public BankAccount(String name, decimal initialbalance)
        {
            this.Owner = name;
            MakeDeposit(initialbalance, DateTime.Now, "initialbalance");
            this.AccNumber = accountnumseed.ToString();
            accountnumseed++;
        }
        public void MakeDeposit(decimal amount, DateTime date,String notes)
        {
            if(amount<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposit must be positive");
            }
            var deposit = new Transaction(amount, date, notes);
            alltransaction.Add(deposit);

        }
        public void MakeWithDrawal(decimal amount, DateTime date, String notes)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, notes);
            alltransaction.Add(withdrawal);
        }

           public string GetAccountHistory()
            {
            var report = new StringBuilder();
            //Header
            report.AppendLine("Date \t\t \t\tAmount \t\t\t\t Notes");
                foreach(var j in alltransaction)
            {
                report.AppendLine($"{j.Date} \t\t {j.Amount} \t\t\t {j.Notes}");
            }
            return report.ToString();
            }

            
        

    }
}
