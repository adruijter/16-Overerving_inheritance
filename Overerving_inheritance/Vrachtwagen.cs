using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overerving_inheritance
{
    public class Vrachtwagen : Voertuig
    {
        // Fields
        private int laadvermogen;

        // Properties
        public int Laadvermogen
        {
            get { return this.laadvermogen; }
            set { this.laadvermogen = value; }
        }

        // Constructor
        public Vrachtwagen(string ikBenEen, string geluidswaarschuwing, int aantalWielen, 
                            int laadvermogen) : base(aantalWielen, ikBenEen, geluidswaarschuwing)
        {
            this.laadvermogen = laadvermogen;
        }

        // Draw
        public void Draw()
        {
            base.Draw();
            Console.WriteLine("Het laadvermogen bedraagt {0}", this.laadvermogen);
        }
    }
}
