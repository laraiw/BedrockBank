using System;
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
            //Create an instance of an account == object
            var account = new Account();
            account.Name = "Larai's Checking";
            account.Deposit(400);
            Console.WriteLine(
                "Name: {0}, AccountNumber: {1}; Balance: {2:c}", 
                account.Name, account.AccountNumber, 
                account.Balance
                );
          

            var savingsaccount = new Account();  //same as - Account savingsaccount = new Account(); "var" figures it out
            savingsaccount.Name = "Larai's Savings";
            savingsaccount.Deposit(10);
            savingsaccount.Withdraw(100);

            //Exception Handling

           try
            {
                savingsaccount.Withdraw(100);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(
                    "Oops, somethings went wrong {0}",
                     ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Yikes, somethings went wrong!");
            }
            Console.WriteLine(
                "Name: {0}, AccountNumber: {1}; Balance: {2:c}",
                savingsaccount.Name, savingsaccount.AccountNumber,
                savingsaccount.Balance
                );

        }
    }
}
