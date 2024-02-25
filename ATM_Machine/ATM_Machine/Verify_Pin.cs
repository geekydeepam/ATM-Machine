using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    

    public class Start:Credentials
    {
        
        public void pin()
        {

            Get_Pin pIN1 = new Get_Pin();
            string Entered_pin = pIN1.gpin();

            if (Correct_Pin.Equals(Entered_pin))
            {
                Transactions transactions = new Transactions();
                transactions.Transaction();    
            }
            else
            {
                Console.WriteLine("\tIncorrect Pin");
                Console.ReadKey();
                Console.Beep();
                Console.WriteLine();
                Main_Screen main_Screen = new Main_Screen();
                main_Screen.Screen();

            }
        }
    }



}
