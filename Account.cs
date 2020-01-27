﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IsleCollection
{

    enum TypeOfAccounts
    {
        Collecting,
    }
    class Account
    {
        private static int lastAccountNumber = 0;
        #region Properties
        /// <summary>
        /// Unique account number
        /// </summary>
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public TypeOfAccounts AccountType { get; set; }
        public decimal Balance { get; private set; }

        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructor
        public Account()
        {
            //lastAccountNumber += 1;
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
}
