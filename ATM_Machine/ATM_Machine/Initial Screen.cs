using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine
{
    public  class Main_Screen
    {
        public void Screen()
        {
            Console.WriteLine("\tWelcome to ABC Bank");

            Console.WriteLine("\nPlease Insert Your Card ");

            Console.ReadLine();

            Console.WriteLine("\n................................................");
            Console.WriteLine();

            Start start = new Start();
            start.pin();
        }
    }
}
