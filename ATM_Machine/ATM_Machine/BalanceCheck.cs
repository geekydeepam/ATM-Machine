using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class BalanceCheck:Credentials
    {
        

        public void balanceCheck()
        {
            Console.WriteLine($"\tYour Balance is {Balance}");

            Console.WriteLine();
            Console.ReadKey();

            Transactions transactions = new Transactions();
            transactions.Transaction();
        }
    }
}
