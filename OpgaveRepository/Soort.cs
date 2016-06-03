using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveRepository
{
    public class Soort
    {
        public int SoortNummer { get; set; }
        public string SoortNaam { get; set; }
        //public int MagazijnNummer { get; set; }

        public Soort(string soortNaam,int soortNummer)
        {
            SoortNaam = soortNaam;
            SoortNummer = soortNummer;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
