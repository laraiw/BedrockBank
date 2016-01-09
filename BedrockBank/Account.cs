using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public
        enum AccountType
    {
        Checking,
        Savings,
        CD
    }

    /// <summary>
    /// This class provides definition for an account for BedRock bank
    /// </summary>
     
    //*********ensure Account class is Publin so factory class can access it

    public class Account
    {
        #region Variables
        /// <summary>
        /// Shared memory for storing the last account; and initializing to 0
        /// </summary>
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name {
            get;            
            set; }

        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get;
            private set; }

        /// <summary>
        /// Balance of the account
        /// </summary>
        public decimal Balance { get;
            private set; }

        public int SSN { get; set; }

        public AccountType TypeOfAccount { get; set; }
        #endregion

        #region Constructors

        //This is a default contructor; has no return type; same as class name
        public Account()
        {
            AccountNumber = ++lastAccountNumber; //pre-increment

            //same as lastAccountNumber = lastAccountNumber + 1; 
            // but will give you 0, so increment by 1 first

        }
        public Account(string name)
        {
            //here set the name
            Name = name;
            //or optionally => this.Name = name;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Money to deposit</param>
        /// <returns>Returns new balance</returns>
        
        public decimal Deposit(decimal amount)
        {
            Balance = Balance + amount;
            
            // or Balance += amount;
            
            return Balance;
        }
        /// <summary>
        /// Withdraw money from your account
        /// </summary>
        /// <param name="amount">Amount to withdraw</param>
        /// <returns>New Balance</returns>
        /// <exception>ArgumentException</exception>
        public decimal Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentNullException("Amount must be min of $1");
            }
            if (amount > 0)
            {
                throw new ArgumentException("You have insufficient funds");
            }
            Balance -= amount;
            // or Balance = Balance - amount;
            return Balance;
        }
        #endregion
    }
}
