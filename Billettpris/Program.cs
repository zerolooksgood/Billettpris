using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billettpris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            func("Person1",15);
            func("Person2",31);
            func("Person3",63);
            Console.ReadLine();
        }
        
        //Oppg 1
        static void func(string navn, int alder)
        {
            //Oppg 2
            int billettpris = 0;
            if (alder <= 17)
            {
                billettpris = 30;
            } else if (alder >= 63)
            {
                billettpris = 35;
            } else
            {
                billettpris = 50;
            }
            Console.WriteLine($"{navn} må betale {billettpris}kr for billetten sin");
        }
    }
}
