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


            account.MakeWithdrawl(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);


            try
            {
                var invalidAccount = new Class.BankAccount("invaid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            account.MakeWithdrawl(1200, DateTime.Now, "Lort");
            Console.WriteLine(account.Balance);
            Console.ReadKey();
        }
    }
}
