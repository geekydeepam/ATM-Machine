using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
     class Program
    {
         public static void Main(string[] args)
        {
            
            Main_Screen main_Screen = new Main_Screen();
            main_Screen.Screen();

            Console.ReadLine();
          
        }
    }
}
