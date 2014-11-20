using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overerving_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig voertuigA = new Voertuig(2, "onbekend bewegend voorwerp", "miep beep");
            Vrachtwagen vrachtwagenA = new Vrachtwagen("vrachtwagen", "Mwaaaooooop", 4, 200000);
            Fiets fietsA = new Fiets("Fiets", "tring tring", 14, 2);
            voertuigA.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            vrachtwagenA.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            fietsA.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.ReadLine();
        }
    }
}
