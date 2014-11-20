using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overerving_inheritance
{
    public class Camper : Voertuig 
    {
        // Fields
        private ushort aantalPersonen;
        private bool douche;
        private bool toilet;
        private float leefOppervlak;
        private ushort aantalBedden;

        // Properties
        public short AantalPersonen { get; set;}
        public bool Douche { get; set;}
        public bool Toilet { get; set;}
        private float LeefOppervlak { get; set; }
        private short AantalBedden { get; set;}

        // Constructor
        public Camper(ushort aantalPersonen, bool douche, bool toilet, float leefOppervlak,
                           ushort aantalBedden, int aantalWielen, string ikBenEen, 
                                string geluidswaarschuwing) : base(aantalWielen, ikBenEen, geluidswaarschuwing)
        {
            this.aantalPersonen = aantalPersonen;
            this.douche = douche;
            this.toilet = toilet;
            this.leefOppervlak = leefOppervlak;
            this.aantalBedden = aantalBedden;
        }

        // Helper method
        private string ToiletWelOfNiet()
        {
            if (this.toilet)
            {
                return "wel een";
            }
            else
            {
                return "geen";
            }
        }

        private string DoucheWelOfNiet()
        {
            //ternary operator ? :
            return (this.douche) ? "wel een" : "geen";
        }

      
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Er kunnen in deze camper maar liefst {0} personen", this.aantalPersonen);
            Console.WriteLine("Er zijn in deze camper maar liefst {0} bedden", this.aantalBedden);
            Console.WriteLine("Deze camper heeft maar liefst {0} vierkante meter oppervlakte", this.leefOppervlak);
            Console.WriteLine("Deze camper heeft {0} toilet", this.ToiletWelOfNiet());
            Console.WriteLine("Deze camper heeft {0} douche", this.DoucheWelOfNiet());
        }
        
        

    }
}
