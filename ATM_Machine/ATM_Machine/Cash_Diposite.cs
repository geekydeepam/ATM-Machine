using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class Cash_Deposit:Credentials
    {
       Transactions transactions=new Transactions();
        public void cashDeposit()
        {
            Console.WriteLine("\tPlease Enter Amount in the Multiple of\n\t100  200  500");
            Console.WriteLine("\n\tEnter the Amount");
            double cash_ToDeposit=Convert.ToDouble(Console.ReadLine());

            Balance = Balance + cash_ToDeposit;
            Console.WriteLine();
            Console.WriteLine($"\tYou Have Deposited {cash_ToDeposit} Rs.\n\tYour Balance is {Balance} Rs.");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n................................................");
            Console.WriteLine();
            Transactions transactions = new Transactions();
            transactions.Transaction();

        }
    }
}
