using System;

namespace classes {
    class Program {
        static void Main (string[] args) {
            var account = new BankAccount ("Helton ", 200000);
            Console.WriteLine ($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");

            account.MakeWithDrawal (500, DateTime.Now, "Rent payment");
            Console.WriteLine (account.Balance);
            account.MakeDeposit (100, DateTime.Now, "friend paid me back");
            Console.WriteLine (account.Balance);

            // Test that the initial balances must be positive:
            try {
                var invalidAccount = new BankAccount ("invalid", -55);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine ("Exception caught creating account with negative balance");
                Console.WriteLine (e.ToString ());
            }

            Console.WriteLine ();
            // Test for a negative balance
            try {
                account.MakeWithDrawal (750, DateTime.Now, "Attempt to overdraw");
            } catch (InvalidOperationException e) {
                Console.WriteLine ("Exception caught trying to overdraw");
                Console.WriteLine (e.ToString ());
            }

            Console.WriteLine();

            Console.WriteLine(account.GetAccountHistory());
            Console.WriteLine();
            Console.WriteLine($"balance current {account.Balance}");
        }
    }
}