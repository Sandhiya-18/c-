using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("sandhiya", 100000);
            Console.WriteLine($"Account {account.AccNumber} was created for {account.Owner} with {account.Balance} balance.");

            account.MakeWithDrawal(2000, DateTime.Now, "akshay");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());



            //test that the  initial balance must be positive

            try
            {
                var invalidamount = new BankAccount("invaliduser", -100);

            }
            catch (ArgumentOutOfRangeException e)
            {

                Console.WriteLine("Exception caught while creating account with negative balance. ");
                Console.WriteLine(e.ToString());
            }
            account.MakeWithDrawal(2000, DateTime.Now, "akshay");
            Console.WriteLine(account.Balance);



        }

    }
}
