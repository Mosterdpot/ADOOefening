using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveRepository
{
    public class Plant
    {
        public int PlantNummer { get; set; }
        public string Naam { get; set; }
        public int SoortNummer { get; set; }
        public int LeveranciersNummer { get; set; }
        public string Kleur { get; set; }
        public decimal Verkoopsprijs { get; set; }

    }
}
