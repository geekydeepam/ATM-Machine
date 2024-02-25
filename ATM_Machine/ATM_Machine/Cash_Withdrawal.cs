using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    internal class Cash_Withdrawal:Credentials
    {
        public void CashWithdraw()
        {
            Transactions transactions = new Transactions();
            Console.WriteLine("\tPlease Enter Amount in the Multiple of\n\n\t 100  200  500");
            Console.WriteLine("\n\tEnter the Amount");
            double cashToWithdraw=Convert.ToDouble(Console.ReadLine());
            if (cashToWithdraw < Balance)
            {
                Balance = Balance - cashToWithdraw;
                Console.WriteLine($"\tYou Have Withdrawn {cashToWithdraw} Rs.\n\n\tYour Balance is {Balance} Rs.");
                Console.WriteLine();

                Console.ReadKey();
                Console.WriteLine("\n................................................");
                transactions.Transaction();
            }
            else
            {
                Console.WriteLine("\tYou Dont Have Sufficient Balance");
                transactions.Transaction();


            }
        }

    }
}
