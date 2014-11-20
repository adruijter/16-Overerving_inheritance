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
            Camper camper = new Camper(6, true, false, 120f, 8, 4, "camper", "Tadatadadaaaaaaaah");
            
            // We maken een object van de class Voertuig
            Voertuig voertuig;
           


            //voertuigA.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //vrachtwagenA.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //fietsA.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //camper.Draw();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            // Polymorphisme (meervormig)
            voertuig = voertuigA;
            voertuig.Draw();
            Console.WriteLine("-----------------------------------------------------------------");
            voertuig = vrachtwagenA;
            voertuig.Draw();
            Console.WriteLine("-----------------------------------------------------------------");
            voertuig = camper;
            voertuig.Draw();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
