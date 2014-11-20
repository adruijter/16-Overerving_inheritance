using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overerving_inheritance
{
    public class Voertuig
    {
        // Fields
        protected string ikBenEen;
        protected int aantalWielen;
        protected string geluidswaarschuwing = "Tuuuut";

        //Properties
        public int AantalWielen
        {
            get { return this.aantalWielen; }
            set { this.aantalWielen = value;  }
        }

        //Constructor 
        public Voertuig(int aantalWielen, string ikBenEen, string geluidswaarschuwing)
        {
            this.aantalWielen = aantalWielen;
            this.ikBenEen = ikBenEen;
            this.geluidswaarschuwing = geluidswaarschuwing;
        }

        public void Draw()
        {
            Console.WriteLine("Weet je wat ik ben? Nee, ik ben een: {0}", this.ikBenEen);            
            Console.WriteLine("Mijn aantal wielen is: {0}", this.aantalWielen);
            Console.WriteLine("Als ik anderen wil waarschuwen klinkt mijn geluid zo: {0}", this.geluidswaarschuwing);
        }
    }
}
