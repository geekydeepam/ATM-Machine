using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
      public class Get_Pin
       {

        
         public string gpin()
         {
            string pin = "";

            Console.WriteLine("\tEnter Your Pin");

            pin=Console.ReadLine();
            
            return pin;
         }
         static bool IsDigit(char c)
         {
            return char.IsDigit(c);
         }
    }
}
