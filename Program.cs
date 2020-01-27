using System;

namespace IsleCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = Collections.CreateAccount("My chance at getting loot is %",
              "test@test.com");
            Console.WriteLine($"AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance}, CD: {myAccount.CreatedDate}, AT: {myAccount.AccountType}, EA: {myAccount.EmailAddress}");

        }
    }
}
