using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overerving_inheritance
{
    public class Fiets : Voertuig
    {
        // Fields
        private int aantalVersnellingen;

        // Properties
        public int AantalVersnellingen
        {
            get { return this.aantalVersnellingen; }
            set { this.aantalVersnellingen = value; }
        }

        public Fiets(string ikBenEen, string geluidswaarschuwing, int aantalVersnellingen, int aantalWielen)
            : base(aantalWielen, ikBenEen, geluidswaarschuwing)
        {
            this.aantalVersnellingen = aantalVersnellingen;
        }

        public void Draw()
        {
            base.Draw();
            Console.WriteLine("Het aantal versnellingen is: {0}", this.aantalVersnellingen);            
        }
    }
}
