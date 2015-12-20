using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class BankFactory
    {
        //method is called CreateAccount, which creates an account;
        //returns account, takes in 2 parameters;
        //creates accounts for us

        public static Account CreateAccount(string name, int ssn, decimal amount)
        {
            var account = new Account();
            account.Name = name;
            //account.Deposit(amount);
            account.SSN = ssn;
            account.TypeOfAccount = AccountType.Checking;
            return account;
        }
    }
}
