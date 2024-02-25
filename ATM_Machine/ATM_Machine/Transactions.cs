using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    public class Transactions
    {
        public void Transaction()
        {
            Console.WriteLine("\t1.Balance Check\t\t2.Cash WithDrawal");
            Console.WriteLine();
            Console.WriteLine("\t3.Cash Deposit \t\t4.Exit");
            Console.WriteLine();
            Console.WriteLine("\n................................................");
            int response=Convert.ToInt32(Console.ReadLine());

            

            switch (response)
            {
                case 1:
                    BalanceCheck BC=new BalanceCheck();
                    BC.balanceCheck();
                    break;
                case 2:
                    Cash_Withdrawal CW= new Cash_Withdrawal();
                    CW.CashWithdraw();
                    break;
                case 3:Cash_Deposit CD=new Cash_Deposit();
                    CD.cashDeposit();
                    break;
                case 4:
                    Console.WriteLine("\tTHANK YOU");
                    Console.WriteLine("\tYou May Remove Your Card\n\n");
                    Console.Beep();
                    Console.ReadKey();
                    Console.WriteLine("\n................................................");
                    Console.WriteLine();

                    Main_Screen mainScreen = new Main_Screen();
                    mainScreen.Screen();
                    break;
                default: Console.WriteLine("Invalid Response");
                    break;
            }

        }
    }
}
