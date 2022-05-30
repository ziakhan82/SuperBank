using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAcoount("Zia", 1000 );
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

         
           // Console.WriteLine(account.Owner + " Your balance is " + account.Balance);

            account.MakeWithdrawal(120,DateTime.Now, " 120 From Roskilde Station" );
            Console.WriteLine(account.Balance);
            account.MakeDeposite(1000,DateTime.Now,"You Added 1000" );

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine("Actual Amount " + account.Balance);





























            //  var account1 = new BankAcoount("Zakiullah", 500);
            // Console.WriteLine("Account " + account1.Number + " was created for " + account1.Owner + " with " +account1.Balance);


            //Console.WriteLine(account.Owner + "Your Balance is " + account.Balance);


            // Console.WriteLine(account1.Owner + "Your balance is " + account1.Balance);
            //account1.MakeDeposite(2000,DateTime.Now,"You Added 2000 to your Account Zakiullah");
            //Console.WriteLine(account1.Owner +" You added 2000 " + "Your balance is " + account1.Balance );



            //Test that intital amount must be positive
            //try
            //{
            //    var invalidAccount = new BankAcoount("Invalid",-55);
            //}
            //catch (ArgumentException e)

            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());

            //} 

            //// test for negative balance
            //try
            //{ account.MakeWithdrawal(750000,DateTime.Now,"Attep to overdraw");

            //}
            //catch (InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught trying to overdraw");
            //    Console.WriteLine(e.ToString());
            //}





        }
    }
}
