using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Class.BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            Console.WriteLine("");

            account.MakeWithdrawl(120, DateTime.Now, "Hammer");
            Console.WriteLine(account.Balance);

            account.MakeWithdrawl(1200, DateTime.Now, "Konsol");
            Console.WriteLine(account.Balance);
            
            Console.WriteLine(account.GetAccuntHistory());


            try
            {
                account.MakeWithdrawl(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine("Exception caught trying to ovedraw");
                Console.WriteLine(e.ToString());
            }
            try
            {
                var invalidAccount = new Class.BankAccount("invaid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
