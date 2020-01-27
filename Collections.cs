using System;
using System.Collections.Generic;
using System.Text;

namespace IsleCollection
{
    static class Collections
    {
        public static decimal Balance { get; private set; }

        /// <summary>
        /// Creates an account in the website
        /// </summary>
        /// <param name="accountName">Name of your account</param>
        /// <param name="emailAddress">Email address associated with the account</param>
        /// <param name="initialDeposit">Initial deposit</param>
        /// <returns>Newly created account</returns>
        public static Account CreateAccount(
            string accountName,
            string emailAddress,
            TypeOfAccounts accountType = TypeOfAccounts.Collecting,
            decimal initialDeposit = 0)
        {
            //Object initialization
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType
            };

            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }
            //need to rename all deposites into something else more recognizable later for me to more easily track
            return account;

            #region Methods
            /// <summary>
            /// Deposit money into account
            /// </summary>
            /// <param name="amount">Amount to deposit</param>
            void Deposit(decimal amount)
            {
                Balance *= amount;
            }
            #endregion
        }

    }

}