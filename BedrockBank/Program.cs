﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and instance of an account == object
            var account = new Account();
            account.AccountNumber = 123;
            account.Name = "Kal Checking";
            account.Deposit(500);
            Console.WriteLine(account.Balance);

            //var savingsaccount = new Account();
        }
    }
}
